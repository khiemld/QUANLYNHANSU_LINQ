using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSuADO.Objects;
using System.Linq;
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using LinQQLNV;
using System.Collections.Generic;

namespace QuanLyNhanSuADO.ADOManagement
{
    public class ADOEmployeeManagement
    {
        private ADOEmployee employee;
        private ADORelative relative;
        private ADODepartment department;
        private ADOLogin login;
        public ADOEmployeeManagement()
        {

            employee = new ADOEmployee();
            //relative = new ADORelative(manager);
            department = new ADODepartment();

        }

        public DataTable GetAllPhongBan()
        {
            return department.GetAll();
        }

        internal DataTable GetAllLuongNhanVien(int min, int max)
        {
            return employee.GetAllLuongNhanVien(min, max);
        }

        public string GetMaPB(string tenPB)
        {
            return department.GetMa(tenPB);
        }

        public PhongBan GetPhongBan(string maPB)
        {
            return department.Get(maPB);
        }

        internal bool LoginCheck(string username, string password)
        {
            return login.LoginCheck(username, password);
        }

        internal DataTable GetAllNhanVienRetire()
        {
            return employee.GetAllNhanVienRetire();
        }

        public bool UpdatePhongBan(PhongBan phongBan)
        {
            return department.Update(phongBan);
        }

        public bool RemovePhongBan(string maPB)
        {
            if (maPB == "NONE")
            {
                return false;
            }
            if (department.Remove(maPB))
            {
                // Change all employee of that department to default department
                try
                {
                    employee.OnRemovePhongBan(maPB);
                }
                catch (Exception ex)
                {
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        internal DataTable GetCountNhanVien()
        {
            return department.GetCountNhanVien();
        }

        internal DataTable GetAllNhanVienHaveBirthday()
        {
            return employee.GetAllNhanVienHaveBirthday();
        }

        public bool AddPhongBan(PhongBan phongBan)
        {
            return department.Add(phongBan);
        }

        // NHAN VIEN
        public bool AddNhanVien(NhanVien nhanVien)
        {
            return employee.Add(nhanVien);
        }

        internal DataTable GetSumSalary()
        {
            return department.GetSumSalary();
        }

        public DataTable GetAllNhanVien()
        {
            return employee.GetAll();
        }

        public NhanVien GetNhanVien(string maNV)
        {
            return employee.Get(maNV);
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            return employee.Update(nhanVien);
        }

        public bool RemoveNhanVien(string maNV)
        {
            if (employee.Remove(maNV))
            {
                try
                {
                    relative.OnRemoveNhanVien(maNV);
                    department.OnRemoveNhanVien(maNV);
                }
                catch (Exception ex)
                {
                }
                return true;
            }
            return false;
        }

        public DataTable SearchNhanVien(string id, string name, string department, string sex)
        {
            return employee.Search(id, name, department, sex);
        }

        // THAN NHAN
        public bool AddThanNhan(ThanNhan thanNhan)
        {
            return relative.Add(thanNhan);
        }

        public DataTable GetAllThanNhan()
        {
            return relative.GetAll();
        }

        public ThanNhan GetThanNhan(string maNV, string ten)
        {
            return relative.Get(maNV, ten);
        }

        public bool RemoveThanNhan(string maNV, string hoTen)
        {
            return relative.Remove(maNV, hoTen);
        }

        public bool UpdateThanNhan(ThanNhan thanNhan)
        {
            return relative.Update(thanNhan);
        }

        public DataTable SearchThanNhan(string id, string name, string relationship)
        {
            return relative.Search(id, name, relationship);
        }
    }                                                     
}                                                         
