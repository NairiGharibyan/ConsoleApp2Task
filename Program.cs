using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonachi task
            /*
            int n = int.Parse(Console.ReadLine())
            int first = 0;
            int second = 1;
            for (int i = 0; i < n; i++) {
                if (n <= 1) {
                Console.WriteLine(i);
            }

                int tmp = first;
                first = second; 
                second += tmp;
                Console.WriteLine(tmp);


            }*/

            //Reverse NUm
            /*   int num = int.Parse(Console.ReadLine());
               int reverse_num = 0;

               while (num > 0) {

                   int digit = num % 10;
                   num = num / 10;
                   reverse_num = reverse_num * 10 + digit;
                   reverse_num *= 10 + digit;
               }

               Console.WriteLine(reverse_num);*/

            //Sum of digits
            /*  int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0) {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
            */



            //MUL Table
            /* int n = int.Parse(Console.ReadLine());
             for (int i = 1; i < 10; i++) {
                 Console.WriteLine($"{i} * {n} = {i * n}");
             }*/



            //Prime NUm
            /*int n = int.Parse(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("Not Prime");
            }
            else if (n == 2)
            {
                Console.WriteLine("Prime Num");
            }
            else if (n % 2 == 0) {
                Console.WriteLine("Not prime");
            }
            else
            {
                bool isprime = true;
                for (int i = 3; i * i < n; i += 2)
                {
                    if (n % i == 0)
                    {
                        isprime = false;
                        break;
                    }

                }
                Console.WriteLine(isprime? "Prime Num": "Not prime");
            }
*/


            // Collatz Conjecture
            /*
                        int n=int.Parse(Console.ReadLine());
                        int count = 0;
                        while (n != 1) {
                            if (n % 2 == 0)
                            {
                                n /= 2;
                            }
                            else {
                                n = 3 * n + 1;
                            }
                            count++;
                        }
                        Console.WriteLine(count + " Step");

                        Console.ReadLine();*/


            //Pyramid
            /*
            int n=int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write(i);
                }
                Console.WriteLine();
            }*/

            //Password Generator

            //Longest word
            /*
                        string str = Console.ReadLine();
                        string[] strings = str.Split();
                        string longest = strings[0];
                        for (int i = 0; i < strings.Length; i++) {
                            if (strings[i].Length > longest.Length) {
                                longest = strings[i];
                            }
                        }
                        Console.WriteLine(longest);
                        */
            //Grid Game
            const int gridSize = 10;
            char[,] grid = new char[gridSize, gridSize];
            Random rand = new Random();

           
            int targetX = rand.Next(gridSize);
            int targetY = rand.Next(gridSize);
            grid[targetX, targetY] = 'X';

            int playerX = rand.Next(gridSize);
            int playerY = rand.Next(gridSize);
            grid[playerX, playerY] = 'P';

            while (playerX != targetX || playerY != targetY)
            {

                Console.Clear();
                for (int i = 0; i < gridSize; i++)
                {
                    for (int j = 0; j < gridSize; j++)
                    {
                        if (i == playerX && j == playerY)
                            Console.Write("P ");
                        else if (i == targetX && j == targetY)
                            Console.Write("X ");
                        else
                            Console.Write(". ");
                    }
                    Console.WriteLine();
                }

         
                Console.WriteLine("Press Enter to move");
                Console.ReadLine();


                if (playerX < targetX)
                    playerX++;
                else if (playerX > targetX)
                    playerX--;

                if (playerY < targetY)
                    playerY++;
                else if (playerY > targetY)
                    playerY--;
            }

            
            Console.WriteLine("Player reached the target!");
            Console.ReadLine();
        }
    }






        }
    

