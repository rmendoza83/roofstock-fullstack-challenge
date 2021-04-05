using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using RoofstockChallenge.DataLayer.Models;

namespace RoofstockChallenge.DataLayer
{
	public class RoofstockChallengeDB : DataConnection
	{
		public RoofstockChallengeDB(LinqToDbConnectionOptions<RoofstockChallengeDB> options)
		: base(options)
		{

		}

		public ITable<Property> Properties => GetTable<Property>();
	}
}
