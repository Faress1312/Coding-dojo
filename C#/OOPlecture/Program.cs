Soldier alex = new Soldier ("alex" ,31);
Soldier fares = new Soldier("fares") ;
Soldier ala = new Soldier("ala" , 28 , 0.95 ,1) ;
Sniper bob = new Sniper("Bob",44);
// System.Console.WriteLine(fares.Name);
// fares.ShowInfo();
// alex.ShowInfo();
// // ala.ShowInfo();
// ala.ShowInfo();
// alex.Attack(ala, 0.2);
// ala.ShowInfo();
bob.ShowInfo();
List<Soldier> army = new List<Soldier>(){bob, ala, fares};
foreach(Soldier s in army)
{
    s.ShowInfo();
}
