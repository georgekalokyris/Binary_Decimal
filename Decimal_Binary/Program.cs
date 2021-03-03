using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool showMenu = true;
            while (showMenu == true)
            {
            showMenu = Menu();
            }
            

        }

        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("*******************************");
            Console.WriteLine("**Binary & Decimal Converter***");
            Console.WriteLine("*******************************");
            Console.WriteLine("(1) Decimal to Binary Converter");
            Console.WriteLine("(2) Binary to Decimal Converter");
            Console.WriteLine("(3) **********EXIT*************");
            Console.WriteLine("*******************************");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\rPlease enter a Decimal numer");
                    DecimaltoBinary(UserInput());
                    return true;
                case "2":
                    Console.WriteLine("\rPlease enter a Binary numer");
                    BinarytoDecimal(UserInput());
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
            
        }

        private static void DecimaltoBinary(int n)
        {
            //Decimal To Binary using successive division
            int div = 1;
            int bit = 0;
            int deci = n;
            //Start by diving the number and keeping the bit from LSB to MSB
            List<int> LSBtoMSB = new List<int>();
            while (div > 0)
            {
                div = n / 2; //First loop: div = 71 bit = 0 
                bit = n % 2;
                n = n / 2;

                LSBtoMSB.Add(bit);
            }
            //Reverse list from MSB to LSB
            LSBtoMSB.Reverse();

            //Convert the list to a string
            string binary = String.Join("", LSBtoMSB);

            //Return the binary in a string format
            Console.WriteLine($"Your convertion results: Decimal[{deci}] = Binary[{binary}]");
            Console.WriteLine("\r\n Press Enter to return to Main Menu");
            Console.ReadLine();
        }


        public static void BinarytoDecimal(int n)
        {
            //Convert binary to string so we can treat it like a char array
            string binary = n.ToString(); 
            int binlen = binary.Length; //Number of items in the Length char array not indexes!
            
            double deci = 0;

            int j = binlen - 1; //Variable used in the power of 2
            for (int i = 0; i <= binlen - 1; i++) 
            {

                if (binary[i] == '1')
                {
                    deci = deci + Math.Pow(2D, j);
                    j = j - 1;
                }
                else
                {
                    j = j - 1;
                }
            
            }
            
            //Return the binary in a double format
            Console.WriteLine($"Your convertion results: Binary[{binary}] = Decimal[{deci}]]");
            Console.WriteLine("\r\n Press Enter to return to Main Menu");
            Console.ReadLine();
        }

       
        private static int UserInput()
        {   //Method for user input
            int n = int.Parse(Console.ReadLine());
            return n;
        }
    }
}
