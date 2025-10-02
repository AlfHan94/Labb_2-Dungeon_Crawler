using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Dungeon_Crawler;

abstract class Enemy : LevelElement
{
    public string Name { get; protected set; }
    public int HP { get; protected set; }

    public Dice AttackDice { get; protected set; }
    public Dice DefenceDice { get; protected set; }

    public bool isDead => HP <= 0;

    protected Enemy(int x, int y) : base(x, y)
    {

    }

    public abstract void Update(Game g);
}
