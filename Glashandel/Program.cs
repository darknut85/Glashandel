using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Glashandel
{
    class Program
    {
        static void Main(string[] args)
        {
            //parameters
            int meters = 0; bool special = false; bool rest = false; double raid = 0;
            string pause; double cost = 0; double cut = 10;

            //data
            while (true)
            {
                try
                {
                    Console.WriteLine("How many m2 of glass do you need?");
                    raid = Convert.ToDouble(Console.ReadLine());
                    meters = (int)Math.Ceiling(raid);
                    Console.WriteLine(meters);
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid answer. Please try again."); }
            }
            Console.WriteLine("Would you like special glass?"); pause = Console.ReadLine();
            if (pause == "yes"){ special = true; cut = 25;}

            Console.WriteLine("Are spare pieces available for the required size?");
            pause = Console.ReadLine();
            if (pause == "yes") {rest = true;}

            //math
            if (rest == true)
            {
                if (special == true){cost = 55 * raid;}
                else{cost = 30 * raid;}
            }
            else
            {
                if (special == true){cost = 55 * meters;}
                else{cost = 30 * meters;}
            }
            if (cost < 145){cost = cost + cut;}
            if (cost > 250)
            {
                double discount = cost / 100 * 5;
                cost = cost - discount;
            }
            Console.WriteLine("The cost is: " + cost);
            if (rest == true)
            {
                Random rnd = new Random();
                int random = rnd.Next(10000000, 99999999);
                Console.WriteLine("Restcode is: " + random);
            }
        }
    }
    // kosten zijn per bestelling

    // gewoon glas: 30 euro per m2 + 10 euro snijkosten
    // speciaal glas 50 euro per m2 + 25 euro snijkosten

    // gehele m2 (0,4 -> 1,0)
        // tenzij grootte uit restanten kan worden gesneden
            // restantcode voor die grootte

    // geen snijkosten als glaskosten > 145 euro
    // 5% korting als glaskosten > dan 250 euro

    // bepaal verschuldigde bedrag
}
