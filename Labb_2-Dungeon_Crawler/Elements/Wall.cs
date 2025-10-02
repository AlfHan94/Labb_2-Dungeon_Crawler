using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Dungeon_Crawler.Elements
{
    class Wall : LevelElement
    {
        public Wall(int x, int y) : base(x, y)
        {
            Symbol = '#';
            Color = ConsoleColor.Gray;
        }

    }
}
