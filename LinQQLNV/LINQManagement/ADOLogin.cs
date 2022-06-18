using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using LinQQLNV;

namespace QuanLyNhanSuADO.ADOManagement
{
    internal class ADOLogin
    {
        ADOManager manager;
        public ADOLogin(ADOManager manager)
        {
            this.manager = manager;
        }
        
        public bool LoginCheck(string username, string pwd)
        {
            //string query = "Select * from DangNhap where TenTaiKhoan = @username and MatKhau = @pwd";
            //SqlParameter[] parameters = new SqlParameter[2];
            //parameters[0] = new SqlParameter("@username", username);
            //parameters[1] = new SqlParameter("pwd", pwd);
            //try
            //{
            //    DataTable data = manager.ExecuteQuery(query, parameters);
            //    return data.Rows.Count > 0;
            //}
            //catch(Exception ex)
            //{
            //    return false;
            //}
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                try
                {
                    IEnumerable<DangNhap> queryTN = from tk in qlNS.DangNhaps where tk.TenTaiKhoan.Equals(username) && tk.MatKhau.Equals(pwd) select tk;
                    DataTable thanNhan = Utilities.ConvertToDataTable<DangNhap>(queryTN);
                    return thanNhan.Rows.Count > 0;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }

        }
    }
}
