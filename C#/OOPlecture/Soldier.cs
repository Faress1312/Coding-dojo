public class Soldier 
{
    // properties
    public string Name {get;set;}
    public int Age {get;set;}
    public double Power {get;set;}
    public double Health {get;set;}
    // Constructor **
    public Soldier(string name ) 
    {
        Name = name ;
        Age = 18 ;
    }
    public Soldier(string name  , int age) 
    {
    Name = name ;
    Age = age ;
    Power = 0.5 ;
    Health = 0.5 ;
    }
    public Soldier(string name  , int age , double power , double health) 
    {
    Name = name ;
    Age = age ;
    Power = power ;
    Health = health ;
    }
    // Methods
    public virtual void ShowInfo() 
    {
        System.Console.WriteLine($"Solder Name {Name}\nAge : {Age}\nPower : {Power *100}\nHealth : {Health*100}%");
    }
    public int IncreaseAge()
    {
        Age+=1 ;
        return Age ;
    }
    public void Attack(Soldier target , double damage)
    {
        target.Health-= Power * damage * 10 ;
        System.Console.WriteLine($"[ATTACK] Soldier {Name} attacked Soldier {target.Name} by damage rate equal to {damage} .");
    }
}
