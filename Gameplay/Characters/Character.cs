using Monopoly.SuperMarioBros.Gameplay.Abilities;

namespace Monopoly.SuperMarioBros.Gameplay.Characters
{
    public class Character : ICharacter
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public PowerUp PowerUpBoost { get; private set; }
        public SuperStar SuperStarAbility { get; private set; }
    }
}