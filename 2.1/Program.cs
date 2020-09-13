using System;
using System.Threading.Tasks;
using System.Linq;
//2018326660145
//Joshua Mikhay Kusuma
//Prime number seeker
namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">> Prime Number Seeker<< \n");
            bool isPrime = true;
            int spaceCounter = 0;
        beginSimulation:
            try
            {
                Console.WriteLine("Decide the range of Number set !!");
                Console.WriteLine("Lower range: ");
                int lower = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Upper range: ");
                int upper = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The list of Prime Number : ");
                for (int i=lower; i<upper; i++)
                {
                    isPrime = true;
                    for(int j=2; j<i;j++)
                    {
                        if(i%j ==0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if ( isPrime && i != 1)
                    {
                        Console.Write(i + " ");
                    }
                    spaceCounter++;
                    if (spaceCounter % 10 == 0)
                    {
                        Console.WriteLine("\n");
                    }
                }
                Console.WriteLine("\n" + "Thankyou for using....");
            }
            catch
            {
                Console.WriteLine("The input is incorrect ! \n Do you wanna try again? (Y/N)");
                char retry = Convert.ToChar(Console.ReadLine());
                if(retry=='y' || retry=='Y')
                {
                    goto beginSimulation;
                }
                else
                {
                    Console.WriteLine("See you..");
                }
                
            }
        }
    }
}
