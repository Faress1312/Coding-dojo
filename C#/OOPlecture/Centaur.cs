public class Centaur : Monster
{
    public double Speed {get ; set ;}
    public double Armor {get ; set ;}
    public string Weapon {get ; set ;}

    public Centaur(double armor , double speed , string weapon): base (name , 0.9 , false , "Fighting")
    {
        Speed = speed ;
        Weapon = "Spear" ;
        Armor = armor ;
    }
}
