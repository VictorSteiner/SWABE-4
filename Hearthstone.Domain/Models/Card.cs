namespace Hearthstone.Domain.Models
{
    public class Card : Entity
    {
		public int ClassId { get; set; }
		public int TypeId { get; set; }
		public int SetId { get; set; }
		public int? SpellSchoolId { get; set; }
		public int RarityId { get; set; }
		public int? Health { get; set; }
		public int? Attack { get; set; }
		public int ManaCost { get; set; }
		public string Artist { get; set; }
		public string Text { get; set; }
		public string FlavorText { get; set; }
	}
}
