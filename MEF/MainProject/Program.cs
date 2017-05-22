using MEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var sportHandler = new SportHandler();

            Console.WriteLine("The next sport are handle:");
            Console.WriteLine(string.Join("\n", sportHandler.GetAllHandledSports()));

            string input = string.Empty;
            do
            {
                Console.WriteLine("Enter name:");
                input = Console.ReadLine();
                var canPlay = sportHandler.CanDoTheSport(input);
                if(input != "exit")
                {
                    Console.WriteLine(string.Join("\n", canPlay));
                }
                Console.WriteLine();

            } while (input != "exit");
        }
    }
}
