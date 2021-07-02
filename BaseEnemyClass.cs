using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseCharClass
{
    private string characterClassName;
    private string characterClassDescription;
    private int enemyHP;
    private int enemyDMGP;
    private int enemyARMP;

    public string CharacterClassName
    {
          get{return characterClassName;}
          set{characterClassName=value;}
    }

     public string CharacterClassDescription
    {
          get{return characterClassDescription;}
          set{characterClassDescription=value;}
    }

     public int enemyHP
    {
          get{return enemyHP;}
          set{HP=value;}
    }

     public int enemyDMGP
    {
          get{return enemyDMGP;}
          set{enemyDMGP=value;}
    }
     public int enemyARMP
    {
          get{return enemyARMP;}
          set{enemyARMP=value;}
    }
}