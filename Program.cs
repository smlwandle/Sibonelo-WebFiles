using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiboneloAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Basket();

            var tshirt = new TShirt();
            tshirt.Name = "DC Comics";
            tshirt.Size = 'l';
            basket.Shirts.Add(tshirt);

	        var golfer = new Golfer();
            golfer.Name = "Polo";
            golfer.Size = 's';
            basket.Golfers.Add(golfer);

            var fpant = new FormalPant();
            fpant.Name = "Chino";
            fpant.Size = 'm';
            basket.FormalPants.Add(fpant);

            var jean = new Jean();
            jean.Name = "Levis";
            jean.Size = 'm';
            basket.Jeans.Add(jean);

            //Console.WriteLine($"Your total price is :"+basket.GetTotal());
            Console.WriteLine($"Your total price is {basket.GetTotal()}");
            Console.Read();
        }
    }
}
