namespace FunTimes.Services
{
    public class CombatSystem
    {

        public void Attack(Character attacker, Character defender)
        {
            defender.HitPoints = defender.HitPoints 
                - (attacker.Strength - defender.Toughness + defender.Armor.Armorvalue);
        }
    }

    public class Armor
    {
        public int Armorvalue;

        public Armor(int armorvalue)
        {
            Armorvalue = armorvalue;
        }
    }
}


