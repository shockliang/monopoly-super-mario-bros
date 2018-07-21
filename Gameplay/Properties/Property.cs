using System;

namespace Monopoly.SuperMarioBros.Gameplay.Properties
{
    public class Property
    {
        public int Id { get; set; }
        public ColourSet Colour { get; set; }
        public string Name { get; set; }
        public int Rent { get; set; }
        public int RentWithColourSet { get; set; }
        public int Point { get; set; }
    }
}