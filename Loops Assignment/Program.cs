using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Assignment
{
    class Program
    {
        static int x = 0;
        static int y = 0;
        static bool gameOver = false;
        static void Main(string[] args)
        {
            

            while (gameOver == false)
            {
                PlayerDraw(x, y);
                PlayerUpdate();
            }

            
        }

        static void PlayerDraw(int x, int y)
        {

            Console.SetCursorPosition(x, y); // setting the position of the player on screen to (x, y) or (0,0)

            Console.Write("R"); // "R" is the Person/Player you control

        }

        static void PlayerUpdate()
        {
            char input;
            ConsoleKeyInfo readKeyInput;
            readKeyInput = Console.ReadKey(true);
            input = readKeyInput.KeyChar;

            if (input == 'w')
            {
                clear();
                y = y - 1;

                if (y < 0)
                {
                    y = 0;
                }

            }
            else if (input == 's')
            {
                clear();
                y = y + 1;

                if (y >= Console.WindowHeight) // Border Restrictions
                {
                    y = Console.WindowHeight;
                }
            }
            else if (input == 'a')
            {
                clear();
                x = x - 1;

                if (x < 0)
                {
                    x = 0;
                }
            }
            else if (input == 'd')
            {
                clear(); // prevents player trail
                x = x + 1;
                if (x >= Console.WindowWidth)
                {
                    x = Console.WindowWidth - 1;
                }
            }
            
            else if (readKeyInput.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }


        }
    
   static void clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }
}

