// See https://aka.ms/new-console-template for more information


try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Diretório não encontrado {ex.Message}");
}

catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
}






