using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1.Data_Layer;

namespace Project1.BusinessLayer
{
    public class BLLClass
    {
        public ClassDao classDao;
        public BLLClass()
        {
            classDao = new ClassDao();
        }
        public BLLClass(string path)
        {
            classDao = new ClassDao(path);
        }
    }
}
