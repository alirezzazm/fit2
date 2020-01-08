using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FitDataBase.ModelFitDataBase
{
   public class Fit
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
