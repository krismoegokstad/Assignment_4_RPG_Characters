namespace Assignment_4_RPG_Characters;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create characters
        Fighter fighter = new Fighter("Conan", "A mighty warrior");
        Wizard wizard = new Wizard("Gandalf", "A wise wizard");

        // Create weapons
        Sword sword = new Sword();
        Staff staff = new Staff();

        // Equip weapons
        fighter.EquipWeapon(sword);
        wizard.EquipWeapon(staff);

        // Perform attacks
        Console.WriteLine("\n--- Battle Begins ---\n");
        fighter.Attack();
        wizard.Attack();

        // Change weapons
        Dagger dagger = new Dagger();
        Bow bow = new Bow();

        fighter.EquipWeapon(dagger);
        wizard.EquipWeapon(bow);

        // Perform attacks again
        Console.WriteLine("\n--- New Weapons ---\n");
        fighter.Attack();
        wizard.Attack();
    }
}