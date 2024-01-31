namespace Mygame

public class Player 
 {
    private int getHealth()
    { return _health;}
    public void setHealth (int thisHealth)
    {_health = thisHealth;}
    

 }



 public abstract class InventoryItem
 {
    protected string _name;
    {
        _name = name
    }

    public string GetName()
    {
        return _name;
    }
    
    public abstract void Use();


 }

