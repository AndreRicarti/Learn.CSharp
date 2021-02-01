using AutoMapper;

namespace Auto.Mapper
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteListViewModel>()
                .ForMember(destino => destino.NomeCompleto,
                    map => map.MapFrom(source => $"{source.Nome} {source.Sobrenome}"));

            //CreateMap<Cliente, ClienteListViewModel>()
            //    .ForPath(destino => destino.Id,
            //        map => map.MapFrom(source => source.Cliente.FirstOrDefault().Id))
            //    .ForPath(destino => destino.NomeCompleto,
            //        map => map.MapFrom(source => $"{source.Cliente.FirstOrDefault().Nome } {source.Cliente.FirstOrDefault().Nome}"))
            //    .ForPath(destino => destino.DataNascimento,
            //        map => map.MapFrom(source => source.Cliente.FirstOrDefault().DataNascimento));
        }
    }
}