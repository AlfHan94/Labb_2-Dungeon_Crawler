using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Dungeon_Crawler;

class Snake : Enemy
{
    public Snake(int x, int y) : base(x, y)
    {
        Name = "Snake";
        HP = 25;
        Symbol = 's';
        Color = ConsoleColor.DarkGreen;

    }
    
    public override void Update(Game g)
    {
        //TODO: Snake står still om spelaren är mer än 2 rutor bort, annars förflyttar den sig bort från spelaren.
    }
}
