using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyNhanSuADO.Objects;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace QuanLyNhanSuADO.ADOManagement
{
    public class ADORelative
    {
        ADOManager manager;
        public ADORelative(ADOManager manager)
        {
            this.manager = manager;
        }
        public bool Add(ThanNhan thanNhan)
        {
            string query = "INSERT INTO ThanNhan VALUES(@maNV, @hoTen, @sdt, @quanhe, 0)";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@maNV", thanNhan.MaNV);
            parameters[1] = new SqlParameter("@hoten", thanNhan.TenTN);
            parameters[2] = new SqlParameter("@sdt", thanNhan.Sdt);
            parameters[3] = new SqlParameter("@quanhe", thanNhan.QuanHeVoiNV);

            return manager.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM ThanNhan where DAXOA = 0";
            return manager.ExecuteQuery(query);
        }

        public ThanNhan Get(string maNV, string ten)
        {
            string query = "SELECT * FROM ThanNhan WHERE MaNV = @maNV AND HoTen = @ten AND DAXOA = 0";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@maNV", maNV);
            parameters[1] = new SqlParameter("@ten", ten);
            DataTable thanNhan = manager.ExecuteQuery(query, parameters);
            List<ThanNhan> list = Utilities.ToListThanNhan(thanNhan);
            return list[0];
        }

        public bool Remove(string maNV, string hoTen)
        {
            string query = "UPDATE THANNHAN SET DAXOA = 1 WHERE MaNV = @maNV AND HoTen = @hoTen ";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@maNV", maNV);
            parameters[1] = new SqlParameter("@hoTen", hoTen);
            return manager.ExecuteNonQuery(query, parameters);
        }
        public bool Update(ThanNhan thanNhan)
        {
            //string query = $"UPDATE ThanNhan SET SDT = {thanNhan.Sdt}, QuanHe = {thanNhan.QuanHeVoiNV} WHERE MaNV = {thanNhan.MaNV} and HoTen = {thanNhan.TenTN}";
            //MessageBox.Show(query);
            //return manager.ExecuteNonQuery(query);
            string query = "UPDATE ThanNhan SET QuanHe = @quanHe, SDT = @sdt WHERE MaNV = @MaNV AND HoTen = @HoTen AND DAXOA = 0";
            MessageBox.Show(query);
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaNV", thanNhan.MaNV);
            parameters[1] = new SqlParameter("@HoTen", thanNhan.TenTN);
            parameters[2] = new SqlParameter("@quanHe", thanNhan.QuanHeVoiNV);
            parameters[3] = new SqlParameter("@sdt", thanNhan.Sdt);
            return manager.ExecuteNonQuery(query, parameters);
        }

        public DataTable Search(string id, string name, string relationship)
        {
            string query = $"SELECT * FROM ThanNhan WHERE MaNV like '%{id}%' and HoTen like '%{name}%' and QuanHe like '%{relationship}%' AND DAXOA = 0";
            return manager.ExecuteQuery(query);
        }

        public bool OnRemoveNhanVien(string maNV)
        {
            string query = "UPDATE ThanNhan SET DAXOA = 1 WHERE MaNV = @maNV";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@maNV", maNV);
            return manager.ExecuteNonQuery(query, parameters);
        }
    }
}