using AutoMapper;
using HomeCinema.Entities;
using HomeCinema.Web.Models;

namespace HomeCinema.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Movie, MovieViewModel>()
                .ForMember(vm => vm.Title, map => map.MapFrom(m => m.Title))
                .ForMember(vm => vm.Description, map => map.MapFrom(m => m.Description))
                .ForMember(vm => vm.State, map => map.MapFrom(m => m.State))
                .ForMember(vm => vm.CreatedDate, map => map.MapFrom(m => m.CreatedDate))
                .ForMember(vm => vm.CreatedDate, map => map.MapFrom(m => m.ModifiedDate));
        }
    }
}