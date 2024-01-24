public class Sniper : Soldier //! Inheritance
{
    // Properties
    //!Specific Properties for the sniper class = POLYMORPHISM (1)

    public double Precision {get ; set ;}
    public double EagleEye {get ; set ;}
    public double HiddenSkills {get ; set ;}
    public string Weapon {get ; set ;}
    // Constructors
    public Sniper(string name , int age): base(name , age , 1 ,1)
    {
        Precision = 0.9 ;
        EagleEye = 0.7 ;
        Weapon = "Sniper";
        HiddenSkills = 1 ;
    }
    // Methods
    public virtual void ShowInfo()
    {
        base.ShowInfo();
        System.Console.WriteLine($"precision : {Precision}\neagleeye : {EagleEye}\nWeapon : {Weapon}\nhiddenskills : {HiddenSkills}\n");
    }
}