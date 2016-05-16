using FluentAssertions;
using FunTimes.Services;
using Xunit;

namespace FunTimes.Tests.Services
{
    public class CombatSystemTests
    {
        [Fact]
        public void Attack_WithHeroStrength10AndMonsterToughness5_Does5DamageToMonster()
        {
            // arrange
            var combatSystem = new CombatSystem();
            var hero = new Character(20, 2, 5, new Armor(3));
            var monster = new Character(10, 8, 1, new Armor(1));

            // act
            combatSystem.Attack(hero, monster);

            // assert
            monster.HitPoints.Should().Be(8);

        }
    }
}