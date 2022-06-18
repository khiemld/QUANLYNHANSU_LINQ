using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSuADO.Objects;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using LinQQLNV;

namespace QuanLyNhanSuADO.ADOManagement
{
    internal class ADODepartment
    {
        ADOManager manager;
        public ADODepartment()
        {
            
        }
        public DataTable GetAll()
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<PHONGBAN> queryPB = from pb in qlNS.PHONGBANs where pb.DAXOA == false select pb;
                DataTable phongBan = Utilities.ConvertToDataTable<PHONGBAN>(queryPB);
                return phongBan;
            }
        }

        public string GetMa(string tenPB)
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<PHONGBAN> queryPB = qlNS.PHONGBANs.Where(p => p.TENPB.CompareTo(tenPB) == 0);
                DataTable maPB = Utilities.ConvertToDataTable<PHONGBAN>(queryPB);
                if (maPB.Rows.Count > 0)
                {
                    return Utilities.NormalizedString(maPB.Rows[0][0].ToString());
                }
                else
                {
                    return "";
                }
            }
        }

        public PhongBan Get(string maPB)
        {
            //    string query = "SELECT * FROM PhongBan WHERE MaPB = @maPB AND DAXOA = 0";
            //    SqlParameter[] parameters = new SqlParameter[1];
            //    parameters[0] = new SqlParameter("@maPB", maPB);
            //    DataTable phongBan = manager.ExecuteQuery(query, parameters);
            //    List<PhongBan> list = Utilities.ToListPhongBan(phongBan);
            //    return list[0];
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<PHONGBAN> queryGetPB = qlNS.PHONGBANs.Where(p => p.MAPB.CompareTo(maPB) == 0 & p.DAXOA == false);
                DataTable phongBan = Utilities.ConvertToDataTable<PHONGBAN>(queryGetPB);
                List<PhongBan> list = Utilities.ToListPhongBan(phongBan);
                return list[0];
            }
        }

        public bool Update(PhongBan phongBan)
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                PHONGBAN pbQuery = qlNS.PHONGBANs.Where(p => p.MAPB.Equals(phongBan.MaPB) & p.DAXOA == false).SingleOrDefault();

                if (pbQuery != null)
                {
                    pbQuery.MAPB = phongBan.MaPB;
                    pbQuery.MATRUONGPB = phongBan.TruongPB;
                    pbQuery.TENPB = phongBan.TenPB;
                    qlNS.NHANVIENs.Context.SubmitChanges();
                }
                return true;
            }
        }

        public bool Remove(string maPB)
        {
            string query = "UPDATE PhongBan SET DAXOA = 1 WHERE MaPB = @maPB";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@maPB", maPB);
            return manager.ExecuteNonQuery(query, parameters);
        }
        public bool Add(PhongBan phongBan)
        {
            
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                PHONGBAN pb = new PHONGBAN();
                pb.MAPB = phongBan.MaPB;
                pb.MATRUONGPB = phongBan.TruongPB;
                pb.TENPB = phongBan.TenPB;
                qlNS.PHONGBANs.InsertOnSubmit(pb);
                qlNS.PHONGBANs.Context.SubmitChanges();
                return true;
            }
        }

        public bool OnRemoveNhanVien(string maNV)
        {
            string query = "UPDATE PhongBan SET MaTruongPB = null WHERE MaTruongPB = @maNV";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@maNV", maNV);
            return manager.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetCountNhanVien()
        {
            string query = "SELECT MaPB, COUNT(MaNV) AS SoNhanVien FROM NhanVien WHERE DAXOA = 0 GROUP BY MaPB";
            return manager.ExecuteQuery(query);
        }

        public DataTable GetSumSalary()
        {
            string query = "SELECT MaPB, SUM(Luong) AS TongLuong FROM NhanVien WHERE DAXOA = 0 GROUP BY MaPB";
            return manager.ExecuteQuery(query);
        }
    }
}
