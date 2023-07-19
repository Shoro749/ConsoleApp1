using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play
{
    public class Game
    {
        public void playing()
        {
            string[] arr = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            Random rnd = new Random();
            int first = rnd.Next(0, 2);
            int rounds = 0;

            if (first == 0) { player(rounds, arr); }
            else { pc(rounds, arr); }
        }

        public void player(int rounds, string[] arr)
        {
            field(arr);
            if (arr[0] == "0" && arr[4] == "0" && arr[8] == "0")
            {
                Console.WriteLine("Player 2 won!");
                End();
            }
            else if (arr[2] == "0" && arr[4] == "0" && arr[6] == "0")
            {
                Console.WriteLine("Player 2 won!");
                End();
            }
            else if (arr[1] == "0" && arr[4] == "0" && arr[7] == "0")
            {
                Console.WriteLine("Player 2 won!");
                End();
            }
            else if (arr[3] == "0" && arr[4] == "0" && arr[5] == "0")
            {
                Console.WriteLine("Player 2 won!");
                End();
            }
            else if (arr[0] == "0" && arr[1] == "0" && arr[2] == "0")
            {
                Console.WriteLine("Player 2 won!");
                End();
            }
            else if (arr[6] == "0" && arr[7] == "0" && arr[8] == "0")
            {
                Console.WriteLine("Player 2 won!");
                End();
            }
            else if (arr[0] == "0" && arr[3] == "0" && arr[6] == "0")
            {
                Console.WriteLine("Player 2 won!");
                End();
            }
            else if (arr[2] == "0" && arr[5] == "0" && arr[8] == "0")
            {
                Console.WriteLine("Player 2 won!");
                End();
            }

            if (rounds == 8)
            {
                Console.WriteLine("Draw!");
                End();
            }

            while (true)
            {
                Console.Write("\nP) Enter number: ");
                int select = Convert.ToInt32(Console.ReadLine());
                if (arr[select - 1] != "0" && arr[select - 1] != "x")
                {
                    arr[select - 1] = "x";
                    pc(rounds++, arr);
                }

                Console.WriteLine("\nInvalid select!");
            }
        }

        public void pc(int rounds, string[] arr)
        {
            Random rnd = new Random();
            field(arr);
            if (arr[0] == "x" && arr[4] == "x" && arr[8] == "x")
            {
                Console.WriteLine("Player 1 won!");
                End();
            }
            else if (arr[2] == "x" && arr[4] == "x" && arr[6] == "x")
            {
                Console.WriteLine("Player 1 won!");
                End();
            }
            else if (arr[1] == "x" && arr[4] == "x" && arr[7] == "x")
            {
                Console.WriteLine("Player 1 won!");
                End();
            }
            else if (arr[3] == "x" && arr[4] == "x" && arr[5] == "x")
            {
                Console.WriteLine("Player 1 won!");
                End();
            }
            else if (arr[0] == "x" && arr[1] == "x" && arr[2] == "x")
            {
                Console.WriteLine("Player 1 won!");
                End();
            }
            else if (arr[6] == "x" && arr[7] == "x" && arr[8] == "x")
            {
                Console.WriteLine("Player 1 won!");
                End();
            }
            else if (arr[0] == "x" && arr[3] == "x" && arr[6] == "x")
            {
                Console.WriteLine("Player 1 won!");
                End();
            }
            else if (arr[2] == "x" && arr[5] == "x" && arr[8] == "x")
            {
                Console.WriteLine("Player 1 won!");
                End();
            }

            if (rounds == 8)
            {
                Console.WriteLine("Draw!");
                End();
            }

            while (true)
            {
                int select = rnd.Next(0, 9);
                if (arr[select - 1] != "0" && arr[select - 1] != "x")
                {
                    arr[select - 1] = "0";
                    player(rounds++, arr);
                }
            }
        }

        public void field(string[] arr)
        {
            Console.WriteLine("\n");
            Console.WriteLine($" {arr[0]} | {arr[1]} | {arr[2]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {arr[3]} | {arr[4]} | {arr[5]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {arr[6]} | {arr[7]} | {arr[8]} ");
            Console.WriteLine("\n");
        }
        public void End()
        {
            throw new Exception("Кінець гри!");
        }
    }
}
