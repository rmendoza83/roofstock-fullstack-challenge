using LinqToDB.Mapping;

namespace RoofstockChallenge.DataLayer.Models
{
	[Table(Name = "Properties")]
	public class Property
	{
		[PrimaryKey, Identity]
		public int Id { get; set; }
		[Column("RawId")]
		public int RawId { get; set; }
		[Column("Address")]
		public string Address { get; set; }
		[Column("YearBuilt")]
		public int YearBuilt { get; set; }
		[Column("ListPrice")]
		public decimal ListPrice { get; set; }
		[Column("MonthlyRent")]
		public decimal MonthlyRent { get; set; }
	}
}
