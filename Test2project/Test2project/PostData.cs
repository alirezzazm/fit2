using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace Test2project
{
   public class PostData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        public string Mozoe { get; set; }


    }
}
