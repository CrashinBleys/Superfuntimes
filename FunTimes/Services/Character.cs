namespace FunTimes.Services
{
    public class Character
    {
        public int HitPoints;

        public Character(int hitPoints, int strength, int toughness, Armor armor = null)
        {
            HitPoints = hitPoints;

            Strength = strength;

            Toughness = toughness;

            Armor = armor;
        }

        public int Strength;

        public int Toughness;

        public Armor Armor;
    }
}