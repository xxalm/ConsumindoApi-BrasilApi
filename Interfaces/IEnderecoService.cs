namespace IntegracaoBrasilApi {


    public interface IEnderecoService {

        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);

    }
}