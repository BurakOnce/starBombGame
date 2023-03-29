using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Burak Önce @burakonce9@gmail.com

namespace starsBombGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finish = 0;
            int loop = 0;
            int a = 5;
            int b = 5;
            Console.WriteLine("Welcome to Stars Bomb Game\nStar's half have bombs\nYou have to guess which point has bomb\n");
            Console.WriteLine("If you are successful Stars fall out , If you dont succeed its time to rise up!\n");
            stars(a, b);

            while (finish == 0) 
            {


                while (loop == 0) 
                { 
                    
                Console.WriteLine("\nPick one column point!! size="+a);
                int guessC=Convert.ToInt32(Console.ReadLine());
                    
                Console.WriteLine("Pick one line point!! size="+b);
                int guessL = Convert.ToInt32(Console.ReadLine());

                    if (guessC > a || guessL > b)
                    {
                        Console.WriteLine("Your column guess must be lower than size");
                    }
                    else
                        loop++;
                }


                    if (random() == 1)
                    {
                        Console.WriteLine("\nBooooom!!!");
                        a--;
                        b--;
                        stars(a, b);
                    }
                    else 
                    { 
                        Console.WriteLine("\nThere is no bomb soryyy\n Rise up!");
                        a++;
                        b++;
                        stars(a, b);
                    }

                    if(a<2 && b < 2)
                    {
                        Console.WriteLine("\nYou Won!!!");
                        finish++;
                    }
                    else if (a > 8 && b > 8)
                    {
                        Console.WriteLine("\nYou Lost!!!");
                        finish++;
                    }
                        loop--;

                Console.ReadLine();
            }

            
        }
        static void stars(int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

        }

        static int random()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 3);

            if (randomNumber == 1)
                return 1;

            else return 0;
        }
    }
}
