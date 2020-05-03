using Java.Lang.Annotation;
using System;
using System.Collections.Generic;
using System.Text;
using Test2project.Models;

namespace Test2project.ViewModels
{
    class ChartMainViewModel
    {
        public List<ChartMain> ChartsData { get; set; }

        public ChartMainViewModel()
        {
            ChartsData = new List<ChartMain>();

            ChartsData.Add(new ChartMain { Year = "2014", Target = 500, Sale=342});
            ChartsData.Add(new ChartMain { Year = "2020", Target = 200, Sale=300});
            ChartsData.Add(new ChartMain { Year = "2016", Target = 600, Sale=100});
            ChartsData.Add(new ChartMain { Year = "2017", Target = 250, Sale=342});
            ChartsData.Add(new ChartMain { Year = "2014", Target = 350, Sale=342});

        }
    }
}
