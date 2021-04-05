using LinqToDB;
using LinqToDB.Data;

namespace RoofstockChallenge.DataLayer
{
	public class RoofstockChallengeDB : DataConnection
	{
		public ITable<Property> Properties => GetTable<Property>();
	}
}
