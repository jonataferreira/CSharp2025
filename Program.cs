// See https://aka.ms/new-console-template for more information
using CSharp2025.modules;








Dictionary<string, string> estados = new Dictionary<string, string>(); //Declarando Dictionary

//Adicionando valores
estados.Add("SP", "São Paulo");
estados.Add("BA","Bahia");
estados.Add("MG","Minas Gerais");


foreach(/*KeyValuePair<string, string>*/ var item in estados) //Mostando Valores
{
    Console.WriteLine($"Chave:{item.Key}, Valor:{item.Value}");
}

Console.WriteLine($"---------------------------");
estados.Remove("BA"); //Removendo o valor
estados["SP"] = "São Paulo - Nome alterado"; //Modificando Valor

foreach(/*KeyValuePair<string, string>*/ var item in estados)
{
    Console.WriteLine($"Chave:{item.Key}, Valor:{item.Value}");
}







/*Stack<int> pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);
pilha.Push(5);


foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento no topo:{pilha.Pop()}");


pilha.Push(10);


foreach (int item in pilha)
{
    Console.WriteLine(item);
}
*/



/*Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);
fila.Enqueue(5);
fila.Enqueue(6);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemlento: {fila.Dequeue()}");

fila.Enqueue(10);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

*/


//new ExemploExcecao().Metodo1();








/*try
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
finally
{
    Console.WriteLine("Fim da execução");
}





*/