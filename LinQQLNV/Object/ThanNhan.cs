using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSuADO.Objects
{
    public class ThanNhan
    {
        private string _maNV;
        private string _tenTN;
        private string _quanHeVoiNV;
        private string _sdt;

        public ThanNhan(string maNV, string tenTN, string quanHeVoiNV, string sdt)
        {
            _maNV = maNV;
            _tenTN = tenTN;
            _quanHeVoiNV = quanHeVoiNV;
            _sdt = sdt;
        }

        public string MaNV { get => _maNV;  }
        public string TenTN { get => _tenTN;  }
        public string Sdt { get => _sdt;  }
        internal string QuanHeVoiNV { get => _quanHeVoiNV;  }

        public bool Validate
        {
            get
            {
                if (string.IsNullOrEmpty(_maNV))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(_tenTN))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(_quanHeVoiNV))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(_sdt))
                {
                    return false;
                }
                return true;
            }
        }
    }
}
