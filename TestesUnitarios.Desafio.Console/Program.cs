
using System.Runtime.Intrinsics;
using TestesUnitarios.Desafio.Console.Services;




ValidacoesLista vl = new ValidacoesLista();

int[] num = { 5, 7, 8, 9 };

for(int i = 0; i < num.Length; i++){

    num[i] *= 2;

    System.Console.WriteLine(num[i]);    
}

