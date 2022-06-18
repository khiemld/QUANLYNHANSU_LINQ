using System;
using System.Collections.Generic;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSuADO.Objects;
using QuanLyNhanSuADO.ADOManagement;
using ClosedXML.Excel;
using System.Windows.Forms;
using System.Reflection;

namespace QuanLyNhanSuADO
{
    internal static class Utilities
    {
        public static string[] NhanVienHeader = new string[] { "Mã nhân viên", "Tên nhân viên", "Giới tính", "Ngày sinh", "Mã phòng ban", "Trạng thái", "Lương", "Phụ cấp", "Số điện thoại", "Email", "Chuyên môn", "Chức vụ", "Địa chỉ" , "Đã xóa"};

    public static string NormalizedString(string inputString)
        {
            return inputString.Trim();
        }

        public static int ToNumber(string stringValue)
        {
            string newString = Utilities.NormalizedString(stringValue);
            return Convert.ToInt32(newString);
        }

        public static List<NhanVien> ToListNhanVien(DataTable table)
        {
            List<NhanVien> list = new List<NhanVien>();
            foreach (DataRow row in table.Rows)
            {
                NhanVien item = new NhanVien(row["MaNV"].ToString(), row["HoTen"].ToString(), row["GioiTinh"].ToString(), Convert.ToDateTime(row["NgaySinh"]), row["MaPB"].ToString(), row["TrangThai"].ToString(), Utilities.ToNumber(row["Luong"].ToString()), row["SDT"].ToString(), row["DiaChi"].ToString(), row["ChucVu"].ToString(), row["Email"].ToString(), row["ChuyenMon"].ToString(), Utilities.ToNumber(row["PhuCap"].ToString()));
                list.Add(item);
            }
            return list;
        }

        public static void ListNhanVienToComboBox(ADOEmployeeManagement manager, ComboBox comboBox)
        {
            Dictionary<string, string> nhanVien = new Dictionary<string, string>();
            nhanVien.Add("", "Tất cả");
            DataTable allNhanVien = manager.GetAllNhanVien();

            foreach (DataRow row in allNhanVien.Rows)
            {
                nhanVien.Add(row[0].ToString(), row[1].ToString());
            }
            comboBox.DataSource = new BindingSource(nhanVien, null);
            comboBox.SelectedIndex = 0;
        }

        public static List<PhongBan> ToListPhongBan(DataTable table)
        {
            List<PhongBan> list = new List<PhongBan>();
            foreach (DataRow row in table.Rows)
            {
                PhongBan item = new PhongBan(row["MaPB"].ToString(), row["TenPB"].ToString(), row["MaTruongPB"].ToString()) ;
                list.Add(item);
            }
            return list;
        }

        public static List<ThanNhan> ToListThanNhan(DataTable table)
        {
            List<ThanNhan> list = new List<ThanNhan>();
            foreach (DataRow row in table.Rows)
            {
                ThanNhan item = new ThanNhan(row["MaNV"].ToString(), row["HoTen"].ToString(), row["QUANHE"].ToString(), row["SDT"].ToString());
                list.Add(item);
            }
            return list;
        }

        public static string GetKeyValueComboBox(object selectedItem)
        {
            KeyValuePair<string, string> item = (KeyValuePair<string, string>)selectedItem;
            return Utilities.NormalizedString(item.Key);
        }

        public static void ExportExcelFile(DataTable table, string[] columnsName, string sheetName, string title)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add(sheetName);
            ws.Cell(1, 1).Value = title;
           

            for (int i = 0; i < columnsName.Length; i++)
            {
                ws.Cell(2, i + 1).Value = columnsName[i];
                
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < columnsName.Count(); j++)
                {
                    ws.Cell(i + 3, j + 1).Value = table.Rows[i][j];
                }
            }

            wb.SaveAs("E:\\File.xlsx");
            MessageBox.Show("Đã lưu!");
        }

        public static DataTable ConvertToDataTable<TSource>(IEnumerable<TSource> source)
        {
            var props = typeof(TSource).GetProperties();

            var dt = new DataTable();
            foreach (var prop in props)
            {
                dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in source)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                dt.Rows.Add(values);
            }

            return dt;
        }

        public static DataTable LINQResultToDataTable<T>(IEnumerable<T> Linqlist)
        {
            DataTable dt = new DataTable();
            PropertyInfo[] columns = null;

            if (Linqlist == null) return dt;

            foreach (T Record in Linqlist)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                               == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                           (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
