using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1.Data_Layer;

namespace Project1.BusinessLayer
{
  public class BLLUser
    {  
        UserDao userDao;
        public  BLLUser()
        { 
            userDao = new UserDao();
        }
        public BLLUser(string path)
        {
            userDao = new UserDao(path);
        }
        public bool LoginCheck(string taiKhoan, string matKhau)
        {
            if (userDao.ListUser.Count <= 0)
                userDao = new UserDao();

            foreach (User item in userDao.ListUser)
            {
                if (item.TaiKhoan.Equals(taiKhoan) && item.MatKhau.Equals(matKhau))
                    return true;
            }
            return false;
        }
    }
}
