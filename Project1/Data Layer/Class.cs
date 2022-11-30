using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Data_Layer
{
    public class Class
    {
        private long ID;
        private string tenLop;
        private int siSo;

        public long GetId()
        {
            return ID;
        }

        public void SetTenLop(string name)
        {
            this.tenLop = name;
        }

        public string GetTenLop()
        {
            return tenLop;
        }

        public void SetSiSo(int siso)
        {
            this.siSo = siso;
        }

        public int GetSiSo()
        {
            return siSo;
        }

        public Class(string tenLop, int siSo)
        {
            ID = GenerateID();
            this.tenLop = tenLop;
            this.siSo = siSo;
        }

        public Class()
        {
            ID = GenerateID();
            this.tenLop = "";
            this.siSo = 0;
        }

        private long GenerateID()
        {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }
    }
}
