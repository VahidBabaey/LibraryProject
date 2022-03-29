using libraryproject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class DbCommon
    {
        public static libraryEntities _Context = new libraryEntities();
        public static libraryEntities Context
        {
            get { return DbCommon._Context; }

        }

        public static void Save()
        {
            _Context.SaveChanges();
            MyMessagebox.ShowMessageSuccess();
        }

    }
}
