using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Dungeon_Crawler.Elements
{
    abstract class LevelElement
    {

        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; protected set; }
        public ConsoleColor Color { get; protected set; }

        protected LevelElement(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
            Console.ResetColor();
        }


    }
}
