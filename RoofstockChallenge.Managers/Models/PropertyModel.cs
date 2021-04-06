namespace RoofstockChallenge.Managers.Models
{
	public class PropertyModel
	{
		public int? Id { get; set; }
		public int RawId { get; set; }
		public string Address { get; set; }
		public int YearBuilt { get; set; }
		public decimal ListPrice { get; set; }
		public decimal MonthlyRent { get; set; }
		public decimal GrossYield
		{
			get
			{
				if (ListPrice > 0)
				{
					return MonthlyRent * 12 / ListPrice;
				}
				return 0;
			}
		}
	}
}
