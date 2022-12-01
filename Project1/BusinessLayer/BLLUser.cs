﻿using System;
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
        public UserDao userDao;
        public  BLLUser()
        { 
            userDao = new UserDao();
        }
        public BLLUser(string path)
        {
            userDao = new UserDao(path);
        }
        public User LoginCheck(string taiKhoan, string matKhau)
        {
            //if (userDao.ListUser.Count == 0)
            //    userDao = new UserDao();

            if  (taiKhoan == "admin" && matKhau == "admin")
            {
                return userDao.adminUser;
            }

            foreach (User user in userDao.ListUser)
            {
                if (user.MSSV.Equals(taiKhoan) && user.MatKhau.Equals(matKhau))
                    return user;
            }
            return null;
        }

        public User CacheUserCheck()
        {
            
            if (userDao.ListUser.Count >= 1)
            {
                return userDao.ListUser[0];
            }

            return null;
        }
    }
}
