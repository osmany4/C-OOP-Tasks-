namespace Mygame

public Player 
 {
    private int getHealth()
    { return _health;}
    public void setHealth (int thisHealth)
    {_health = thisHealt;}
    

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

