using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseCharClass
{
    private string characterClassName;
    private string characterClassDescription;
    private int HP;
    private int DMGP;
    private int ARMP;

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

     public int HP
    {
          get{return HP;}
          set{HP=value;}
    }

     public int DMGP
    {
          get{return DMGP;}
          set{DMGP=value;}
    }
     public int ARMP
    {
          get{return ARMP;}
          set{ARMP=value;}
    }
}