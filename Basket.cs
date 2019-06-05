using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiboneloAssessment
{
    public class Basket
    {
        public List<TShirt> Shirts;
        public List<Golfer> Golfers;
        public List<FormalPant> FormalPants;
        public List<Jean> Jeans;
        
        public Basket()
        {
            Shirts = new List<TShirt>();
            Golfers = new List<Golfer>();
            FormalPants = new List<FormalPant>();
            Jeans = new List<Jean>();
        }

        public double GetTotal()
        {
            double total=0;

            foreach (var tshirt in Shirts) 
	    {
                total += tshirt.GetTotalPrice();     
            }
	    foreach (var golfer in Golfers)
            {
                total += golfer.GetTotalPrice();
            }
            foreach (var fpant in FormalPants)
            {
                total += fpant.GetTotalPrice();
            }
            foreach (var jean in Jeans)
            {
                total += jean.GetTotalPrice();
            }
            return total;
        }
    }
}
