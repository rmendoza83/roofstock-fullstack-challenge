using LinqToDB.Mapping;

namespace RoofstockChallenge.DataLayer
{
	public class Property
	{
		[PrimaryKey]
		public int Id { get; set; }
		public int RawId { get; set; }
		public string Address { get; set; }
		public decimal YearBuilt { get; set; }
		public decimal ListPrice { get; set; }
		public decimal MonthlyRent { get; set; }
    }
}
