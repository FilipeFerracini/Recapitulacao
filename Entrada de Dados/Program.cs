﻿using System;

namespace Entrada_de_Dados {
    class Program {
        static void Main(string[] args) {

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string[] vet1 = Console.ReadLine().Split(' ');
            string nome = vet1[0];
            char sexo = char.Parse(vet1[1]);
            int idade = int.Parse(vet1[2]);
            double altura = double.Parse(vet1[3]);
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
