using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AssignmentNektarios.Store;

namespace AssignmentNektarios
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TShirt> shirts = new List<TShirt>();

        
            Console.WriteLine("Give a color with the first letter capital");
            string Color = Console.ReadLine();

            Console.WriteLine("Give a fabric with the first letter capital");
            string fabric1 = Console.ReadLine();

            Console.WriteLine("Give a size with the first letter capital");
            string size = Console.ReadLine();

            Console.WriteLine("You picked a Tshirt with {0} color , fabric {1} and size {2}" , Color, fabric1, size);

            TShirt shirt = new TShirt(Color, fabric1, size);
            shirts.Add(shirt);


            foreach (var fabric in shirts)
            {
                Console.Write("And the total cost is ");
                Console.WriteLine(fabric.CalculatePrice());
            }



            Console.WriteLine();
            Console.WriteLine("Please Choose the payment method.Type:");
            Console.WriteLine("1: Bank transfer" );
            Console.WriteLine("2: Debit Card");
            Console.WriteLine("Type anything else to pay with cash");

            int num = Convert.ToInt32(Console.ReadLine());

            StrategyPayment strategycontext = new StrategyPayment(num);

            IPaymentStartegy strategy = strategycontext.GetpaymentMethod(num);
            








        }
    }
}
