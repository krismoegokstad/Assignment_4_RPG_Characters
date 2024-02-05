namespace Assignment_4_RPG_Characters;

public abstract class Weapon
{
    public string Description { get; set; }
    public string AttackMessage { get; set; }

    public abstract void Attack();
}

// Concrete weapon classes
public class Sword : Weapon
{
    public Sword()
    {
        Description = "Sword";
        AttackMessage = "slashes with the sword";
    }

    public override void Attack()
    {
        Console.WriteLine("The character " + AttackMessage);
    }
}

public class Dagger : Weapon
{
    public Dagger()
    {
        Description = "Dagger";
        AttackMessage = "stabs with the dagger";
    }

    public override void Attack()
    {
        Console.WriteLine("The character " + AttackMessage);
    }
}

public class Bow : Weapon
{
    public Bow()
    {
        Description = "Bow";
        AttackMessage = "shoots with the bow";
    }

    public override void Attack()
    {
        Console.WriteLine("The character " + AttackMessage);
    }
}

public class Staff : Weapon
{
    public Staff()
    {
        Description = "Staff";
        AttackMessage = "casts a spell with the staff";
    }

    public override void Attack()
    {
        Console.WriteLine("The character " + AttackMessage);
    }
}

public class Wand : Weapon
{
    public Wand()
    {
        Description = "Wand";
        AttackMessage = "casts a magical effect with the wand";
    }

    public override void Attack()
    {
        Console.WriteLine("The character " + AttackMessage);
    }
}
