
namespace Mygame


public class Character

{
    public string name;
    public  int health;
    public  int attackPower;

    public void Attack(Character.target)
    {
        target.health = health - attackPower;
    }


    public void TakeDamage(target.health)
    {
        Damage = target.health - attackPower;
    }
    public class Player:Character

    public class Enemey:Character
}



public class GameObject 
{
    public string name;
    public double PositionX;
    public double  PositionY;

    public void Interact()
    {
        Console.Writeline("Player collects item");
    }

    public class PowerUp:GameObject
        
      public string Effect;
        }
            public override void Interact() 
            {
                Console.Writeline("Player health boost expires in 10 seconds")
            }        
}