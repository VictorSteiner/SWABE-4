namespace Hearthstone.Domain.Models
{
    public class Set : Entity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int CardCount { get; set; }
    }
}
