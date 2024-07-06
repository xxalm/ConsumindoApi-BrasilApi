using AutoMapper;

namespace IntegracaoBrasilApi.Mappings {

    public class BancoMapping : Profile {
        
        public BancoMapping() {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}