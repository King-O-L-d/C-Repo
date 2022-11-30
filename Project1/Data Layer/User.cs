using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Data_Layer
{
    public class User
    {
        //Field
        private long iD;
        private string taiKhoan;
        private string matKhau;
        private string hoVaTen;
        private string lop;
        private string gioiTinh;
        private bool nhoMatKhau;

        public User(string taiKhoan, string matKhau, string hoVaTen, string lop, string gioiTinh, bool nhoMatKhau)
        {
            this.iD = 0;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.hoVaTen = hoVaTen;
            this.lop = lop; 
            this.gioiTinh = gioiTinh;       
            this.nhoMatKhau = nhoMatKhau;
        }
        public User()
        {
            this.iD = 0;
            this.taiKhoan = "";
            this.matKhau = "";
            this.hoVaTen = "";
            this.lop = "";
            this.gioiTinh = "";
            this.nhoMatKhau = false;
        }

        public User(string taiKhoan, string matKhau)
        {
            this.iD = 0;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.hoVaTen = "";
            this.lop = "";
            this.gioiTinh = "";
            this.nhoMatKhau = false;
        }

        //Properties
        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string TaiKhoan
        { 
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        public string MatKhau
        {
            get
            {
                return matKhau;
            }
            set
            {
                matKhau = value;
            }
        }
        public string HoVaTen 
        {
            get { return hoVaTen; } 
            set { hoVaTen = value; } 
        }
        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public bool NhoMatKhau
        { 
            get { return nhoMatKhau; }
            set { nhoMatKhau = value; }
        }

        public User DocUser(string line)
        {
            User user = new User();//khoi tao mot user
            string[] mang = line.Split(',');
            user.ID = Convert.ToInt64(mang[0]);
            user.TaiKhoan = mang[1];
            user.MatKhau = mang[2];
            user.HoVaTen = mang[3];
            user.Lop = mang[4]; 
            user.GioiTinh = mang[5];    
            user.NhoMatKhau = Convert.ToBoolean(mang[6]);

            return user;
        }
        public void GhiUser(StreamWriter streamWriter)
        {
            streamWriter.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6}", ID, TaiKhoan, MatKhau, HoVaTen, Lop, GioiTinh, NhoMatKhau));
        }
    }
}
