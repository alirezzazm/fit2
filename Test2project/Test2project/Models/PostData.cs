using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace Test2project
{
   public class PostData
    {
        internal DateTime UpdatedAt;

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        public string Mozoe { get; set; }

        public string ImagePost { get; set; }

        public string ImageProfile { get; set; }

        public string NameContact { get; set; }
        public string Like { get; set; }
        public string Comment { get; set; }
         public string Tamrin { get; set; }
        
    }
}
