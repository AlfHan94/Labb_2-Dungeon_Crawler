using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Dungeon_Crawler;

class Rat : Enemy
{
    public Rat(int x, int y) : base(x, y)
    {
        Name = "Rat";
        HP = 10;
        Symbol = 'r';
        Color = ConsoleColor.DarkYellow;
    }

    public override void Update(Game g)
    {
        //TODO: Rat förflyttar sig 1 steg i slumpmässig vald riktning (upp, ner, höger eller vänster) varje omgång. FIXAR SEN!
    }
}
