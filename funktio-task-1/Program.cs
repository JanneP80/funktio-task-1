using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funktio_task_1
{
    class Program
    {
        
        static string ScreenMessenger(int inputnumber)
        {
            string messagecounter = string.Empty; //string for returning stars "*"

            if (inputnumber < 1) // is zero or negative -> not defined
            {
                messagecounter = string.Format("You typed number {0}, it is not defined.", inputnumber);
            }
            else

            for (int i = 0; i < inputnumber; i++)
            {
                // Add more stars in the to be returned string.
                messagecounter = messagecounter.Insert(0, "*"); 
                
            }
            return messagecounter;
        }

        static void Main(string[] args)
        {
            int inputnumber = 0;
            string message = string.Empty;
            

            Console.Write("This program prints as many stars as you want.\nPlease type amount: ");
            bool result = int.TryParse(Console.ReadLine(), out inputnumber);
            if (!result) // incorrect input
            {
                message = "Input is NOT a number.";
            }
            else

            Console.Write(ScreenMessenger(inputnumber)); // Calls and prints

            Console.ReadKey();
        }
    }
}
