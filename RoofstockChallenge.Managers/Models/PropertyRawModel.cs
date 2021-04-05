namespace RoofstockChallenge.Managers.Models
{
	public class PropertyRawModel
	{
		public int id { get; set; }
		public Address address { get; set; }
		public Financial financial { get; set; }
		public Physical physical { get; set; }
	}

	public class Address
	{
		public string address1 { get; set; }
		public string address2 { get; set; }
		public string city { get; set; }
		public string country { get; set; }
	}

	public class Physical
	{
		public int yearBuilt { get; set; }
	}

	public class Financial
	{
		public decimal listPrice { get; set; }
		public decimal monthlyRent { get; set; }
	}
}
