

using System;

namespace TesteClass
{
     class Program
    {
        static void Main(string[] args)
        {

            // atributos
        carro Chevrolet = new carro();
        Chevrolet.corrida = "Velocidade";

        Console.WriteLine(Chevrolet.marca);

        Console.WriteLine(Chevrolet.corrida);

        Console.WriteLine(Chevrolet.correr());
    

        

       

        }

    
       
        
        
    }

}


