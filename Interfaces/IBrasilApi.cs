using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi {


    public interface IBrasilApi {

        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);

    }
}