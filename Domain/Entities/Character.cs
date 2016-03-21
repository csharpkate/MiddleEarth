namespace Domain.Entities
{
	public class Character
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public int Age { get; set; }
		public string Interests { get; set; }

		public int RaceId { get; set; }
		public Race Race { get; set; }

		public int RegionId { get; set; }
		public Region Region { get; set; }
	}
}