using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WarriorClass : BaseCharClass
{
    public void WarriorClass()
    {
        CharacterClassName="Warrior";
        CharacterClassDescription="Strong dude who kills people with a sword.";
        HP = 75;
        DMGP = 75;
        ARMP = 50;
    }
      public int Choice() // Produces decision
    {
        bool correctInput = true;
        int choice = 0 , choice2;
        while (correctInput)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            bool test = int.TryParse(Console.ReadLine(), out choice);
            if (!test || choice > 3 || choice <= 0)
            {
                Console.WriteLine("Thats not one of the options! Try again!");
                Console.ReadLine();
                Console.Clear();
                continue;
            }
        }
        return choice;
    }

    public void YourTurn(int decision , BanditClass target)
    {
        if (decision == 1)
        {
            NormAttack(target);
            enemyHP= enemyHP - DMGP;
            Console.WriteLine("You Swing a sword at the enemy!");
        }

        if (decision == 2)
        {
            Defend();
            HP = HP - enemyDMGP;
            Console.WriteLine("You brace for impact");
            Console.WriteLine("Knight's HP:" + HP + "/100" );
        }

    }
}