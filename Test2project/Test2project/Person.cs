using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace Test2project
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Tel { get; set; }
        public string Age { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }

        public string Image { get; set; }


    }
}
