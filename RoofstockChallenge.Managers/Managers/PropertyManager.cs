using AutoMapper;
using RoofstockChallenge.DataLayer;
using RoofstockChallenge.DataLayer.Models;
using RoofstockChallenge.Managers.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using LinqToDB;

namespace RoofstockChallenge.Managers.Managers
{
	public class PropertyManager
	{
        private readonly IMapper _mapper;
        private readonly RoofstockChallengeDB _db;
        private readonly IHttpClientFactory _httpClientFactory;
        private const string RAW_DATA_ENDPOINT = "https://samplerspubcontent.blob.core.windows.net/public/properties.json";

        public PropertyManager(IMapper mapper, RoofstockChallengeDB db, IHttpClientFactory httpClientFactory)
        {
            _mapper = mapper;
            _db = db;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<PropertyRawListResponseModel> GetList()
		{
            PropertyRawListResponseModel resp = new PropertyRawListResponseModel();
            try
            {
                // Get the data from the API endpoint
                var request = new HttpRequestMessage(HttpMethod.Get, RAW_DATA_ENDPOINT);
                var client = _httpClientFactory.CreateClient();
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync())
                    {
                        // Serialize the fetched data
                        var data = await JsonSerializer.DeserializeAsync<PropertyRawResponseModel>(responseStream);
                        resp.Properties = _mapper.Map<IEnumerable<PropertyRawModel>>(data.properties);
                        resp.Success = true;
                        resp.ErrorMessage = null;
                    };
                }
                else
                {
                    resp.Success = false;
                    resp.ErrorMessage = "Something Error getting the response";
                }
            }
            catch (Exception ex)
            {
                resp.Success = false;
                resp.ErrorMessage = ex.Message;
            }
            return resp;
        }

        public async Task<BaseResponseModel> Post(PropertyModel model)
		{
            BaseResponseModel resp = new BaseResponseModel();

            try
			{
                Property data = _mapper.Map<Property>(model);
                var result = await _db.InsertAsync(data);
                resp.Success = true;
                resp.ErrorMessage = null;
			}
            catch (Exception ex)
			{
                resp.Success = false;
                resp.ErrorMessage = ex.Message;
			}
			return resp;
		}
	}
}