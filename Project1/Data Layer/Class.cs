using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Data_Layer
{
    public class Class
    {
        public long ID { get; set; }
        public string ClassName { get; set; }
        public int SiSo { get; set; }

    public long GetId()
        {
            return ID;
        }

        public void SetTenLop(string name)
        {
            this.ClassName = name;
        }

        public string GetTenLop()
        {
            return ClassName;
        }

        public void SetSiSo(int siso)
        {
            this.SiSo = siso;
        }

        public int GetSiSo()
        {
            return SiSo;
        }

        public Class(string tenLop, int siSo)
        {
            ID = GenerateID();
            this.ClassName = tenLop;
            this.SiSo = siSo;
        }

        public Class()
        {
            ID = 0;
            this.ClassName = "";
            this.SiSo = 0;
        }

        public long GenerateID()
        {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }
    }
}
