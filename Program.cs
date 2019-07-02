using System;

namespace Vetor3
{
    class Program
    {
        static void Main(string[] args)
        {
        int [] numeros={10, 23, 5, 45, 68, 12, 70};
        Console.WriteLine("Qtd do Vetor. "+numeros.Length);
        int rs = numeros[0];
        for(int i = 1; i < numeros.Length; i++){
            rs+=numeros[i];

        }
            Console.WriteLine(rs);

        }

        
    }
}
