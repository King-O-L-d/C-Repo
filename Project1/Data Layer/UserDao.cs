using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Data_Layer
{
   public class UserDao
    {
        private List<User> listUser;
        public List<User> ListUser { get { return listUser; } set { listUser = value; } }

        DocGhiFile docGhi;
        public UserDao()
        {
            listUser = new List<User>()
            {
                new User(){ID=0,TaiKhoan="admin",MatKhau="admin",HoVaTen="Kiet",NhoMatKhau=false}

            };
        }
        public UserDao(string path)
        {
            listUser = new List<User>();
            docGhi = new DocGhiFile(path);
            listUser = docGhi.DocUser();


        }







        //Thuc hien cac phuong thuc
        //them

        //sua

        //xoa
    }
}
