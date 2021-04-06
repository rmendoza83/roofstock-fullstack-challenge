using Microsoft.AspNetCore.Mvc;
using RoofstockChallenge.Managers.Managers;
using RoofstockChallenge.Managers.Models;
using System.Threading.Tasks;

namespace RoofstockChallenge.Web.Controllers
{
	public class PropertyController : Controller
	{
        private readonly PropertyManager _manager;

        public PropertyController(PropertyManager manager)
		{
            _manager = manager;
		}

        [HttpGet]
        [Route("api/Property/GetList")]
        public async Task<ActionResult> GetList()
        {
            var resp = await _manager.GetList();
            return Ok(resp);
        }

        [HttpPost]
        [Route("api/Property/Post")]
        public async Task<ActionResult> Post([FromBody] PropertyModel model)
        {
            var resp = await _manager.Post(model);
            return Ok(resp);
        }
	}
}
