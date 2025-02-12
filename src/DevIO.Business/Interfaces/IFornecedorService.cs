using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IFornecedorService
    {
        Task<bool> Adicionar(Fornecedor fornecedor);
        Task<bool> AdicionarDuplicado(Fornecedor fornecedor);
        Task<bool> Atualizar(Fornecedor fornecedor);
        Task<bool> Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}
