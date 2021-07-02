using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NinjaClass : BaseCharClass
{
    public void NinjaClass()
    {
        CharacterClassName="Ninja";
        CharacterClassDescription="A stealth dude who kills people with a small sword or kunai.";
        HP = 50;
        DMGP = 100;
        ARMP = 10;
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

    public void YourTurn(int decision , BanditClass target) // Battle methods
    {
        if (decision == 1)
        {  
            Random rnd = new Random();
            int token = rnd.Next(10);
            if(token <= 1)
            {
            CritAttack(target);
            enemyHP= enemyHP - DMGP * 3;
            Console.WriteLine("CRITICAL STRIKE!!! You stab the enemy!");
            Console.WriteLine("Bandit's HP" + enemyHP + "/80");
            }
            else
            {
            NormAttack(target);
            enemyHP= enemyHP - DMGP;
            Console.WriteLine("You stab the enemy!");
            }
            
        }

        if (decision == 2)
        {
            Defend();
            HP = HP - enemyDMGP;
            Console.WriteLine("You brace for impact");
            Console.WriteLine("Ninja's HP:" + HP + "/100" );
        }

    }
}