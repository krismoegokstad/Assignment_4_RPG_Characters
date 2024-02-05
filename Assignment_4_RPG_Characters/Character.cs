namespace Assignment_4_RPG_Characters;

public abstract class Character
{
    public string Name { get; set; }
    public string Description { get; set; }
    protected Weapon EquippedWeapon { get; set; }

    public Character(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract void Attack();

    public void EquipWeapon(Weapon weapon)
    {
        EquippedWeapon = weapon;
        Console.WriteLine(Name + " has equipped " + weapon.Description);
    }
}

// Concrete character subclasses
public class Fighter : Character
{
    public Fighter(string name, string description) : base(name, description) { }

    public override void Attack()
    {
        if (EquippedWeapon != null)
        {
            Console.Write(Name + " the Fighter ");
            EquippedWeapon.Attack();
        }
        else
        {
            Console.WriteLine(Name + " the Fighter punches!");
        }
    }
}

public class Wizard : Character
{
    public Wizard(string name, string description) : base(name, description)
    {
    }

    public override void Attack()
    {
        if (EquippedWeapon != null)
        {
            Console.Write(Name + " the Wizard ");
            EquippedWeapon.Attack();
        }
    }

    public class Rogue : Character
    {
        public Rogue(string name, string description) : base(name, description)
        {
        }

        public override void Attack()
        {
            if (EquippedWeapon != null)
            {
                Console.Write(Name + " the Rogue ");
                EquippedWeapon.Attack();
            }
            else
            {
                Console.WriteLine(Name + " the Rogue strikes with bare hands!");
            }
        }
    }

    public class Ranger : Character
    {
        public Ranger(string name, string description) : base(name, description)
        {
        }

        public override void Attack()
        {
            if (EquippedWeapon != null)
            {
                Console.Write(Name + " the Ranger ");
                EquippedWeapon.Attack();
            }
            else
            {
                Console.WriteLine(Name + " the Ranger shoots with bare hands!");
            }
        }
    }
}