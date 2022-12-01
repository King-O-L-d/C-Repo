using Project1.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1.Data_Layer
{
    public class ClassDao
    {
        private List<Class> listClass = new List<Class>();
        public List<Class> ListClass { get { return listClass; } set { listClass = value; } }

        public string classDataPath;

        DocGhiFile docGhi;
        public ClassDao()
        {
            Class lopHoc = new Class("TenLop", 0);
            listClass.Add(lopHoc);
        }
        public ClassDao(string path)
        {
            this.classDataPath = path;
            listClass = new List<Class>();
            docGhi = new DocGhiFile(path);
            listClass = docGhi.DocClass();
        }

        //Thuc hien cac phuong thuc

        public Class GetClassByID(long id)
        {
            foreach (Class lop in listClass)
            {
                if (lop.GetId() == id)
                    return lop;
            }

            return null;
        }

        public Class GetClassByName(string name)
        {
            foreach (Class lop in listClass)
            {
                if (lop.GetTenLop() == name)
                    return lop;
            }

            return null;
        }

        public int GetClassIndexByName(string name)
        {
            for (int i = 0; i < listClass.Count; i++)
            {
                if (listClass[i].GetTenLop() == name)
                    return i;
            }

            return -1;
        }


        public int GetClassIndexByID(long id)
        {
            for (int i = 0; i < listClass.Count; i++)
            {
                if (listClass[i].GetId() == id)
                    return i;
            }

            return 0;
        }

        //them
        public void AddClass(Class data)
        {
            listClass.Add(data);
            docGhi = new DocGhiFile(classDataPath);
            docGhi.GhiClass(classDataPath, listClass);
        }

        public void AddClass(Class data, string path)
        {
            List<Class> classes = new List<Class>
            {
                data
            };
            docGhi = new DocGhiFile(path);
            docGhi.GhiClass(path, classes);
        }
        //sua
        public void EditClass(Class data, int index)
        {
            listClass[index] = data;
            docGhi = new DocGhiFile(classDataPath);
            docGhi.GhiClass(classDataPath, listClass);
        }
        //xoa
        public void DeleteClass(Class lop)
        {
            BLLUser bLLUser = new BLLUser(Main.Instance.userDataPath);
            foreach(User user in bLLUser.userDao.ListUser)
            {
                if (user.TaiKhoan == lop.GetTenLop())
                {
                    MessageBox.Show("Khong the xoa lop");
                    return;
                }
            }

            listClass.Remove(lop);
            docGhi = new DocGhiFile(classDataPath);
            docGhi.GhiClass(classDataPath, listClass);
        }

        public void SaveListClass(List<Class> classes)
        {
            docGhi = new DocGhiFile(classDataPath);
            docGhi.GhiClass(classDataPath, classes);
        }
    }
}
