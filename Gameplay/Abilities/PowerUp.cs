using Monopoly.SuperMarioBros.Gameplay.Characters;

namespace Monopoly.SuperMarioBros.Gameplay.Abilities
{
    public abstract class PowerUp
    {
        public PowerUpType Type { get; protected set; }
        public string Description { get; protected set; }
        public abstract void Execute(ICharacter target);
    }
}