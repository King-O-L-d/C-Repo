﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1.Data_Layer
{
    public class DocGhiFile
    {
        string path;
        public DocGhiFile(string path)
        {
            this.path = path;
        }
        //Doc file
        public List<User> DocUser()
        {
            List<User> users = null;//Khai bao danh sach User
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line = string.Empty;
                    User user;
                    users = new List<User>();//khoi tao danh sach
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            user = new User();//khoi tao mot user
                                              // users.Add(user.DocUser(line));
                            string[] mang = line.Split(',');
                            user.ID = Convert.ToInt64(mang[0]);
                            user.TaiKhoan = mang[1];
                            user.MatKhau = mang[2];
                            user.HoVaTen = mang[3];
                            user.Lop = mang[4];
                            user.GioiTinh = mang[5];
                            user.NhoMatKhau = Convert.ToBoolean(mang[6]);
                            users.Add(user);//Them user vao danh sach
                        }
                    }
                    streamReader.Close();
                }

                fileStream.Close();
            }
            return users;
        }
        //Ghi file
        public bool GhiFile(string path, List<User> users)
        {
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                {
                    fileStream.SetLength(0);
                    using (StreamWriter streamWrite = new StreamWriter(fileStream))
                    {
                        foreach (User item in users)
                        {
                            // item.GhiUser(streamWrite);
                            streamWrite.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6}", item.ID, item.TaiKhoan, item.MatKhau, item.HoVaTen, item.Lop, item.GioiTinh, item.NhoMatKhau));
                        }

                        streamWrite.Close();
                    }
                    fileStream.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        public List<Class> DocClass()
        {
            List<Class> lopHoc = null;//Khai bao danh sach User
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line = string.Empty;
                    Class lop;
                    lopHoc = new List<Class>();//khoi tao danh sach
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            lop = new Class();//khoi tao mot user
                                              // users.Add(user.DocUser(line));
                            string[] mang = line.Split(',');
                            lop.SetTenLop(mang[1]);
                            lop.SetSiSo(Int32.Parse(mang[2]));
                            lopHoc.Add(lop);//Them user vao danh sach
                        }
                    }
                    streamReader.Close();
                }

                fileStream.Close();
            }
            return lopHoc;
        }

        public bool GhiClass(string path, List<Class> lopHoc)
        {
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                {
                    fileStream.SetLength(0);
                    using (StreamWriter streamWrite = new StreamWriter(fileStream))
                    {
                        foreach (Class item in lopHoc)
                        {
                            // item.GhiUser(streamWrite);
                            streamWrite.WriteLine(string.Format("{0},{1},{2}", item.GetId(), item.GetTenLop(), item.GetSiSo()));
                        }

                        streamWrite.Close();
                    }
                    fileStream.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

    }


}

