// Aaron davila
// Conditional Statement
// 9/12/19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//New program
namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade would you receive");
            // Try statement of the grade they will recieve or think they will recieve.
            try
            {
                string input = Console.ReadLine();
                int new_input = int.Parse(input);
                // If statement starting with A
                if (new_input>= 90)
                {
                    Console.WriteLine("You have reecieved a A!! Good Job!");
                }
                else if (new_input >= 80)
                {
                    Console.WriteLine("You have recieved a B! Decent Job!");
                }
                else if (new_input >= 70)
                {
                    Console.WriteLine("You have recieved a C! Try a little harder.");
                }
                else if (new_input >= 60)
                {
                    Console.WriteLine("You have recieved a D...try again.");
                }
                else
                {
                    Console.WriteLine("You have a recieved a F! You will have to retry the course!")
                }
                Console.ReadLine();
                //preparing a catch statement in case of error.
            }
            catch
            {
                Console.WriteLine("You have an error");
            }
        }
    }
}




        }


    }
}
