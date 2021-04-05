using System.Collections.Generic;

namespace RoofstockChallenge.Managers.Models
{
	public class PropertyRawListResponseModel : BaseResponseModel
	{
		public IEnumerable<PropertyRawModel> Properties { get; set; }
	}
}
