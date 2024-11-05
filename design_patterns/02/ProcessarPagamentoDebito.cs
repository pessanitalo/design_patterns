namespace _02
{
    public class ProcessarPagamentoDebito : IRealizarPagamento
    {
        public void ProcessarPagamento()
        {
            Console.WriteLine("Pagamento realizado via Débito.");
        }
    }
}
