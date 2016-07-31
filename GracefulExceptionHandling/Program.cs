using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GracefulExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Name");
            string Name = Console.ReadLine();
            try
            {
                if (Name.Length>10)
                {
                    throw new Exception("Length cannot be more than 10");
                }
                Console.WriteLine("Enter your age");
                int Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Hello " + Name + ", your Age is " + Age);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Incorrect format. Exiting program. . . ");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            Console.ReadKey();
            //Program ends here
        }
    }
}
