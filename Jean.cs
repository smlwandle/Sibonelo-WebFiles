using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiboneloAssessment
{
    public class Jean:Product
    {
        public override double GetTotalPrice()
        {
            switch (Size)
            {
                case 's':
                case 'S':
                    return(TotalPrice[0]);

                case 'm':
                case 'M':
                    return(TotalPrice[1]);

                case 'l':
                case 'L':
                    return(TotalPrice[2]);

                default:
                    return(0);
            }
        }
    }
}
