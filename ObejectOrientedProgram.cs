// method


class Character 
{
    public string Name;
    public int Health;
    public int Stamina;
    public int Level;

    public void ShowStatus ()
    {Console.WriteLine (Name, Health, Stamina);}

    public void TakeDamage (int damage)
    {Health = Health - damage;
    
    if (Health <= 0)
    {
        Health = 0;
        Console.WriteLine (Name + " Took " + damage + " Damage. " + " Health is now : " + Health);
        Console.WriteLine ("Dead");
        
    }
    else 
    { 
        Console.WriteLine (Name + " Took " + damage + " Damage. " + " Health is now : " + Health);
    }

    }

    public void Heal (int healAmount)
    {
      Health = Health + healAmount;

      if (Health >= 100)
      {
            Health = 100;
      }
        Console.WriteLine (Name + " healed by : " + healAmount + " Current Health : " + Health);
    }


    public int LevelUp (int exp)
    {
       Level = Level + (exp / 100);
        Console.WriteLine (Name + "'s level : " + Level);
        return Level;
    }



}
class Weapon 
{
    public string Name;
    public int BaseDamage;

    public int CausedDamaged (int bonus)
    {
        int totalDamage;
        totalDamage = BaseDamage + bonus;
        return totalDamage;
    }


}


class Program 
{
    static void Main(string[] args)
    {
        Character arthur = new Character{Name = "Arthur", Health = 100, Stamina = 100, Level = 0};
        Weapon revolver = new Weapon {Name = "Revolver", BaseDamage = 20};
        //arthur.ShowStatus();
        arthur.TakeDamage (revolver.CausedDamaged (15));
        //arthur.TakeDamage (70);
        arthur.Heal (50);
        arthur.LevelUp (120);

    }
}




