using System;
namespace Teste
{
    class Teste
    {
        public void calculo(){
        string Nome = "Albertao";
        double altura = 1.72;
        Console.WriteLine ($"Seu Nome e {Nome} e voce tem {altura}");
        }
        static void Main(string[]args){
            Teste meuObj = new Teste();
            meuObj.calculo();
        }

    }
}
