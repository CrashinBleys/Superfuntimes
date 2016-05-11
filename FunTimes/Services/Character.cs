namespace FunTimes.Services
{
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