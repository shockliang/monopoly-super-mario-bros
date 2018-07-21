using Monopoly.SuperMarioBros.Gameplay.Characters;

namespace Monopoly.SuperMarioBros.Gameplay.Abilities
{
    public abstract class SuperStar
    {
        public SuperStarType Type { get; protected set; }
        public string Description { get; protected set; }

        public abstract void Execute(ICharacter target);
    }
}