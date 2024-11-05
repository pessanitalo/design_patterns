namespace _01
{
    public static class CriarProcessadorFactory
    {
        public static IProcessadorDocumento CriarProcessador(string tipoDocumento)
        {
            return tipoDocumento.ToLower() switch
            {
                "pdf" => new ProcessarDocumentoPdf(),
                "docx" => new ProcessarDocumentoDoc(),
                "excel" => new ProcessarDocumentoExcel(),
                _ => throw new ArgumentException("Tipo de documento não suportado")
            };
        }
    }
}
