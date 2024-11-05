namespace _02
{
    public static class PagamentoFactory
    {
        public static IRealizarPagamento realizarPagamento(string tipoPagamento)
        {
            return tipoPagamento.ToLower() switch
            {
                "p" => new ProcessarPagamentoPix(),
                "d" => new ProcessarPagamentoDebito(),
                _ => throw new ArgumentException("Tipo de pagamento não suportado")
            };

        }
    }
}
