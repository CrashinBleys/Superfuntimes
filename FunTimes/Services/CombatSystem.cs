namespace FunTimes.Services
{
    public class CombatSystem
    {

        public void Attack(Character attacker, Character defender)
        {
            defender.HitPoints = defender.HitPoints 
                - (attacker.Strength - defender.Toughness);
        }
    }

    public class Character
    {
        public int HitPoints;

        public Character(int hitPoints, int strength, int toughness)
        {
            HitPoints = hitPoints;

            Strength = strength;

            Toughness = toughness;
        }

        public int Strength;

        public int Toughness;
    }
}
