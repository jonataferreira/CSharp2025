using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp2025.modules
{
    public class ExemploExcecao
    {
        

    public void Metodo1()
    {
        Metodo2();
    }

    public void Metodo2()
    {
        try 
        {
            Metodo3();
        }
        catch(Exception)
        {
            Console.WriteLine("Exceção tratada");
        }
    }
    public void Metodo3()
    {
        Metodo4();
    }
    public void Metodo4()
    {
        throw new Exception("Ocorreu um erro");
    }
    
    
    }



}