using _04_Reflection.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "José",
                Email = "jose@teste.com",
                Senha = "123456ab"
            };

            Log.Gravar(usuario.Clone());

            usuario.Nome = "teste altera nome";
            Log.Gravar(usuario.Clone());

            Carro carro = new Carro()
            {
                Marca = "Fiat",
                Modelo = "Uno"
            };

            Log.Gravar(carro.Clone());

            carro.Modelo = "Palio";

            Log.Gravar(carro.Clone());

            Log.ApresentarLog();

            Console.WriteLine("Log gravado");
            Console.ReadKey();
        }
    }
}
