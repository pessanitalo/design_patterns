
using _01;


//utilizando o padrão de projeto Factory para criar tipos de documentos diferentes
IProcessadorDocumento processador = CriarProcessadorFactory.CriarProcessador("docx");
processador.Processar();

Console.ReadLine();