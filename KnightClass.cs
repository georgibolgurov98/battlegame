using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KnightClass : BaseCharClass
{
    public void KnightClass()
    {
        CharacterClassName="Knight";
        CharacterClassDescription="Strong dude with alot of armour who kills people with a sword.";
        HP = 100;
        DMGP = 50;
        ARMP = 90;
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
            enemyHP= enemyHP - DMGP;
            NormAttack(target);
            Console.WriteLine("You Swing a sword at the enemy!");
        }

        if (decision == 2)
        {  
             Random rnd = new Random();
            int token = rnd.Next(10);
            if(token <= 1)
            {
            Defend();
            HP = HP;
            Console.WriteLine("You activate your special power and take no dmg.");
            Console.WriteLine("Knight's HP:" + HP + "/100" );
            }
            else
            {
            Defend();
            HP = HP - enemyDMGP;
            Console.WriteLine("You brace for impact");
            Console.WriteLine("Knight's HP:" + HP + "/100" );
            }
           
        }

    }
}