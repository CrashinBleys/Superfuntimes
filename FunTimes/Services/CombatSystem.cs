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
}
