using System.Collections.Generic;

namespace RoofstockChallenge.Managers.Models
{
	public class PropertyListResponseModel : BaseResponseModel
	{
		public IEnumerable<PropertyModel> Properties { get; set; }
	}
}
