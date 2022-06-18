using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSuADO.Objects;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using LinQQLNV;
using System;
using System.Linq;

namespace QuanLyNhanSuADO.ADOManagement
{
    public class ADOEmployee
    {
        public ADOEmployee()
        {
       
        }
        public bool Add(NhanVien nhanVien)
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                try
                {
                    NHANVIEN nv = new NHANVIEN();
                    nv.MANV = nhanVien.MaNV;
                    nv.NGAYSINH = nhanVien.NgaySinh;
                    nv.GIOITINH = nhanVien.GioiTinh;
                    nv.HOTEN = nhanVien.HoTen;
                    nv.MAPB = nhanVien.MaPB;
                    nv.TRANGTHAI = nhanVien.TrangThai;
                    nv.LUONG = nhanVien.Luong;
                    nv.PHUCAP = nhanVien.PhuCap;
                    nv.SDT = nhanVien.Sdt;
                    nv.EMAIL = nhanVien.Email;
                    nv.CHUYENMON = nhanVien.ChuyenMon;
                    nv.CHUCVU = nhanVien.ChucVu;
                    nv.DIACHI = nhanVien.DiaChi;
                    qlNS.NHANVIENs.InsertOnSubmit(nv);
                    qlNS.NHANVIENs.Context.SubmitChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
        } 

        public DataTable GetAll()
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<NHANVIEN> queryNV = from nv in qlNS.NHANVIENs where nv.DAXOA == false select nv;
                DataTable nhanVien = Utilities.ConvertToDataTable<NHANVIEN>(queryNV);
                return nhanVien;
            }
        }

        public NhanVien Get(string maNV)
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<NHANVIEN> queryGetNV = qlNS.NHANVIENs.Where(p => p.MANV.CompareTo(maNV) == 0);
                DataTable nhanVien = Utilities.ConvertToDataTable<NHANVIEN>(queryGetNV);
                List<NhanVien> list = Utilities.ToListNhanVien(nhanVien);
                return list[0];
            }
        }

        public bool Update(NhanVien nhanVien)
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                NHANVIEN nvQuery = qlNS.NHANVIENs.Where(p => p.MANV.Equals(nhanVien.MaNV)).SingleOrDefault();

                if (nvQuery != null)
                {
                    nvQuery.MANV = nhanVien.MaNV;
                    nvQuery.NGAYSINH = nhanVien.NgaySinh;
                    nvQuery.GIOITINH = nhanVien.GioiTinh;
                    nvQuery.HOTEN = nhanVien.HoTen;
                    nvQuery.MAPB = nhanVien.MaPB;
                    nvQuery.TRANGTHAI = nhanVien.TrangThai;
                    nvQuery.LUONG = nhanVien.Luong;
                    nvQuery.PHUCAP = nhanVien.PhuCap;
                    nvQuery.SDT = nhanVien.Sdt;
                    nvQuery.EMAIL = nhanVien.Email;
                    nvQuery.CHUYENMON = nhanVien.ChuyenMon;
                    nvQuery.CHUCVU = nhanVien.ChucVu;
                    nvQuery.DIACHI = nhanVien.DiaChi;
                    qlNS.NHANVIENs.Context.SubmitChanges();
                }
                return true;
            }
        }

        public bool Remove(string maNV)
        {
            //string query = "UPDATE NHANVIEN SET DAXOA = 1 WHERE MaNV = @maNV";
            //SqlParameter[] parameters = new SqlParameter[1];
            //parameters[0] = new SqlParameter("@maNV", maNV);
            //return manager.ExecuteNonQuery(query, parameters);
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                NHANVIEN nvQuery = qlNS.NHANVIENs.Where(p => p.MANV.Equals(maNV)).SingleOrDefault();
                if(nvQuery != null)
                {
                    nvQuery.DAXOA = true;
                    qlNS.NHANVIENs.Context.SubmitChanges();
                }
                return true;
            }
        }

        public DataTable Search(string id, string name, string department, string sex)
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {

                IEnumerable<NHANVIEN> querySearch = from nv in qlNS.NHANVIENs
                                                    where (nv.MANV.Contains(id)) & (nv.MAPB.Contains(department)) & (nv.GIOITINH.Contains(sex)) & (nv.HOTEN.Contains(name) & (nv.DAXOA == false)) select nv;



                return Utilities.ConvertToDataTable<NHANVIEN>(querySearch);
            }
        }

        public bool OnRemovePhongBan(string maPB)
        {
            //string query = "Update NhanVien set MaPB = 'NONE' where MaPB = @MaPB";
            //SqlParameter[] parameters = new SqlParameter[1];
            //parameters[0] = new SqlParameter("@MaPB", maPB);
            //return manager.ExecuteNonQuery(query, parameters);
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                NHANVIEN nvQuery = qlNS.NHANVIENs.Where(p => p.MAPB.Equals(maPB)).SingleOrDefault();
                if (nvQuery != null)
                {
                    nvQuery.MAPB = "";
                    qlNS.NHANVIENs.Context.SubmitChanges();
                }
                return true;
            }

        }

        public DataTable GetAllLuongNhanVien(int min, int max)
        {
            //string query = $"SELECT * FROM NhanVien WHERE Luong >= {min} AND Luong <= {max} AND DAXOA = 0";
            //return manager.ExecuteQuery(query);
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {

                IEnumerable<NHANVIEN> queryNV = from nv in qlNS.NHANVIENs where (nv.LUONG > min) && (nv.LUONG < max) && (nv.DAXOA == false) select nv;
                DataTable nhanVien = Utilities.ConvertToDataTable(queryNV);

                return nhanVien;
            }
        }

        public DataTable GetAllNhanVienHaveBirthday()
        {
            //string query = $"SELECT * FROM NhanVien WHERE MONTH(NgaySinh) = MONTH(GETDATE()) AND DAXOA = 0";
            //return manager.ExecuteQuery(query);
            string month = DateTime.Now.Month.ToString();
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<NHANVIEN> nvQuery = from nv in qlNS.NHANVIENs where nv.NGAYSINH.Month.ToString().Equals(month) && nv.DAXOA == false select nv;
                return Utilities.ConvertToDataTable<NHANVIEN>(nvQuery);
            }

        }

        public DataTable GetAllNhanVienRetire()
        {
            //string query = $"SELECT * FROM NhanVien WHERE TrangThai = 'Đã nghỉ' AND DAXOA = 0";
            //return manager.ExecuteQuery(query);
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<NHANVIEN> nvQuery = from nv in qlNS.NHANVIENs where nv.TRANGTHAI == "Đã nghỉ" && nv.DAXOA == false select nv;
                return Utilities.ConvertToDataTable<NHANVIEN>(nvQuery);

            }
        }
    }
}