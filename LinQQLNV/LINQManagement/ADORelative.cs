
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
    public class ADORelative
    {
        ADOManager manager;
        public ADORelative()
        {
            
        }
        public bool Add(ThanNhan thanNhan)
        {
            //string query = "INSERT INTO ThanNhan VALUES(@maNV, @hoTen, @sdt, @quanhe, 0)";
            //SqlParameter[] parameters = new SqlParameter[4];
            //parameters[0] = new SqlParameter("@maNV", thanNhan.MaNV);
            //parameters[1] = new SqlParameter("@hoten", thanNhan.TenTN);
            //parameters[2] = new SqlParameter("@sdt", thanNhan.Sdt);
            //parameters[3] = new SqlParameter("@quanhe", thanNhan.QuanHeVoiNV);

            //return manager.ExecuteNonQuery(query, parameters);
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                try
                {
                    THANNHAN tn = new THANNHAN();
                    tn.MANV = thanNhan.MaNV;
                    tn.HOTEN = thanNhan.TenTN;
                    tn.SDT = thanNhan.Sdt;
                    tn.QUANHE = thanNhan.QuanHeVoiNV;
                    qlNS.THANNHANs.InsertOnSubmit(tn);
                    qlNS.THANNHANs.Context.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public DataTable GetAll()
        {
            //string query = "SELECT * FROM ThanNhan where DAXOA = 0";
            //return manager.ExecuteQuery(query);
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<THANNHAN> queryTN = from nv in qlNS.THANNHANs where nv.DAXOA == false select nv;
                DataTable thanNhan = Utilities.ConvertToDataTable<THANNHAN>(queryTN);
                return thanNhan;
            }
        }

        public ThanNhan Get(string maNV, string ten)
        {
            //string query = "SELECT * FROM ThanNhan WHERE MaNV = @maNV AND HoTen = @ten AND DAXOA = 0";
            //SqlParameter[] parameters = new SqlParameter[2];
            //parameters[0] = new SqlParameter("@maNV", maNV);
            //parameters[1] = new SqlParameter("@ten", ten);
            //DataTable thanNhan = manager.ExecuteQuery(query, parameters);
            //List<ThanNhan> list = Utilities.ToListThanNhan(thanNhan);
            //return list[0];
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<THANNHAN> queryGetTN = from tn in qlNS.THANNHANs where (tn.MANV.Equals(maNV)) && (tn.HOTEN.Equals(ten)) && (tn.DAXOA == false) select tn;
                DataTable thanNhan = Utilities.ConvertToDataTable<THANNHAN>(queryGetTN);
                List<ThanNhan> list = Utilities.ToListThanNhan(thanNhan);
                return list[0];
            }
        }

        public bool Remove(string maNV, string hoTen)
        {
            //string query = "UPDATE THANNHAN SET DAXOA = 1 WHERE MaNV = @maNV AND HoTen = @hoTen ";
            //SqlParameter[] parameters = new SqlParameter[2];
            //parameters[0] = new SqlParameter("@maNV", maNV);
            //parameters[1] = new SqlParameter("@hoTen", hoTen);
            //return manager.ExecuteNonQuery(query, parameters);
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                THANNHAN tnQuery = qlNS.THANNHANs.Where(p => p.MANV.Equals(maNV) && p.HOTEN.Equals(hoTen)).SingleOrDefault();
                if (tnQuery != null)
                {
                    tnQuery.DAXOA = true;
                    qlNS.NHANVIENs.Context.SubmitChanges();
                }
                return true;
            }
        }
        public bool Update(ThanNhan thanNhan)
        {
            //string query = $"UPDATE ThanNhan SET SDT = {thanNhan.Sdt}, QuanHe = {thanNhan.QuanHeVoiNV} WHERE MaNV = {thanNhan.MaNV} and HoTen = {thanNhan.TenTN}";
            //MessageBox.Show(query);
            //return manager.ExecuteNonQuery(query);
            //string query = "UPDATE ThanNhan SET QuanHe = @quanHe, SDT = @sdt WHERE MaNV = @MaNV AND HoTen = @HoTen AND DAXOA = 0";
            //MessageBox.Show(query);
            //SqlParameter[] parameters = new SqlParameter[4];
            //parameters[0] = new SqlParameter("@MaNV", thanNhan.MaNV);
            //parameters[1] = new SqlParameter("@HoTen", thanNhan.TenTN);
            //parameters[2] = new SqlParameter("@quanHe", thanNhan.QuanHeVoiNV);
            //parameters[3] = new SqlParameter("@sdt", thanNhan.Sdt);
            //return manager.ExecuteNonQuery(query, parameters);
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                THANNHAN tnQuery = qlNS.THANNHANs.Where(p => p.MANV.Equals(thanNhan.MaNV) && p.HOTEN.Equals(thanNhan.TenTN)).SingleOrDefault();
                if (tnQuery != null)
                {
                    tnQuery.HOTEN = thanNhan.TenTN;
                    tnQuery.MANV = thanNhan.MaNV;
                    tnQuery.QUANHE = thanNhan.QuanHeVoiNV;
                    tnQuery.SDT = thanNhan.Sdt;
                    qlNS.NHANVIENs.Context.SubmitChanges();
                }
                return true;
            }
        }

        public DataTable Search(string id, string name, string relationship)
        {
            //string query = $"SELECT * FROM ThanNhan WHERE MaNV like '%{id}%' and HoTen like '%{name}%' and QuanHe like '%{relationship}%' AND DAXOA = 0";
            //return manager.ExecuteQuery(query);
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {

                IEnumerable<THANNHAN> querySearch = from tn in qlNS.THANNHANs
                                                    where (tn.MANV.Contains(id)) && (tn.HOTEN.Contains(name)) && (tn.QUANHE.Contains(relationship)) && (tn.DAXOA == false)
                                                    select tn;



                return Utilities.ConvertToDataTable<THANNHAN>(querySearch);
            }
        }

        public bool OnRemoveNhanVien(string maNV)
        {
            //string query = "UPDATE ThanNhan SET DAXOA = 1 WHERE MaNV = @maNV";
            //SqlParameter[] parameters = new SqlParameter[1];
            //parameters[0] = new SqlParameter("@maNV", maNV);
            //return manager.ExecuteNonQuery(query, parameters);
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                THANNHAN tnQuery = qlNS.THANNHANs.Where(p => p.MANV.Equals(maNV)).SingleOrDefault();
                if (tnQuery != null)
                {
                    tnQuery.DAXOA = true;
                    qlNS.NHANVIENs.Context.SubmitChanges();
                }
                return true;
            }
        }
    }
}