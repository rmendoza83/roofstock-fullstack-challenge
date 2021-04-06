using AutoMapper;
using RoofstockChallenge.DataLayer.Models;
using RoofstockChallenge.Managers.Models;

namespace RoofstockChallenge.Web
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<PropertyRawModel, PropertyModel>()
				.ForMember(dest => dest.Id, opt => opt.Ignore())
				.ForMember(dest => dest.RawId, opt => opt.MapFrom(src => src.id))
				.ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.address.address1 + ", " + src.address.city + ", " + src.address.country))
				.ForMember(dest => dest.YearBuilt, opt => opt.MapFrom(src => src.physical.yearBuilt))
				.ForMember(dest => dest.ListPrice, opt => opt.MapFrom(src => src.financial.listPrice))
				.ForMember(dest => dest.MonthlyRent, opt => opt.MapFrom(src => src.financial.monthlyRent));
			CreateMap<PropertyModel, Property>().ReverseMap();
		}
	}
}
