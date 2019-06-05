using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiboneloAssessment
{
    public abstract class Product
    {
        public string Name { get; set; }
        public char Size { get; set; }
        public double[] TotalPrice = { 10, 20, 30 };
        public abstract double GetTotalPrice();
    }
}
