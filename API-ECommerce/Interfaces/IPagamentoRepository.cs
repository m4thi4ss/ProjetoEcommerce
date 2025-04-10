using API_ECommerce.Models;

namespace API_ECommerce.Interfaces
{
    public interface IPagamentoRepository
    {
        List<Pagamento> ListaTodos();
        Pagamento BuscarPorId(int id);
        void Cadastrar(Pagamento pagamento);
        void Atualizar(int id, Pagamento pagamento);
        void Deletar(int id);

    }
}
