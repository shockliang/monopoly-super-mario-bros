using Monopoly.SuperMarioBros.Gameplay.Abilities;

namespace Monopoly.SuperMarioBros.Gameplay.Characters
{
    public interface ICharacter
    {
        int Id { get; }
        string Name { get; }
        PowerUp PowerUpBoost { get; }
        SuperStar SuperStarAbility { get; }
    }
}