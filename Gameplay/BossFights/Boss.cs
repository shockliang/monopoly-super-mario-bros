namespace Monopoly.SuperMarioBros.Gameplay.BossFights
{
    public class Boss
    {
        public Boss(int id, string name, int payToFight, int winCondition, string effectDescription, string effect, int point)
        {
            this.Id = id;
            this.Name = name;
            this.PayToFight = payToFight;
            this.WinCondition = winCondition;
            this.EffectDescription = effectDescription;
            this.Effect = effect;
            this.Point = point;

        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int PayToFight { get; private set; }
        public int WinCondition { get; private set; }
        public string EffectDescription { get; private set; }
        public string Effect { get; private set; }
        public int Point { get; private set; }
    }
}