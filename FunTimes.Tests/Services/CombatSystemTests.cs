using System.Runtime.InteropServices;
using FluentAssertions;
using FunTimes.Services;
using Xunit;

namespace FunTimes.Tests.Services
{
    public class CombatSystemTests
    {
        [Fact]
        public void Attack_WithTwoCharacters_DoesOnePointOfDamageToDefender()
        {
            // arrange
            var combatSystem = new CombatSystem();
            var hero = new Character(20, 2, 5);
            var monster = new Character(10, 8, 1);

            // act
            combatSystem.Attack(hero, monster);

            // assert
            monster.HitPoints.Should().Be(9);
        }

        [Fact]
        public void Attack_WithHeroStrength10AndMonsterToughness5_Does5DamageToMonster()
        {
            // arrange
            var combatsystem = new CombatSystem();
            var hero = new Character(20, 10, 5);
            var monster = new Character(10, 8, 5);

            // act
            combatsystem.Attack(hero, monster);
            //assert
            monster.HitPoints.Should().Be(5);

        }
    }
}