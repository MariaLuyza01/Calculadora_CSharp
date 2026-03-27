using System;

int opcao = 1;

while (opcao != 0)
{
Console.WriteLine("====== CALCULADORA ======");
Console.WriteLine("Digite o primeiro valor:");
int valor1 = int.Parse(Console.ReadLine());

 Console.WriteLine("===== CALCULADORA =======");
        Console.WriteLine("1- Somar");
        Console.WriteLine("2- Subtrair");
        Console.WriteLine("3- Multiplicar");
        Console.WriteLine("4- Dividir");
        Console.WriteLine("5- Resto da divisão");
        Console.WriteLine("0- Sair");

Console.WriteLine("Escolha a opção:");
opcao = int.Parse(Console.ReadLine());
 
 if (opcao == 0)
 {
    Console.WriteLine("Saindo ...");
    return;
 }

Console.WriteLine("Digite o segundo valor:");
int valor2 = int.Parse(Console.ReadLine());

switch(opcao) 
{
  case 1:
    Console.WriteLine("Resultado:"+ (valor1 + valor2));
    break;
  case 2:
    Console.WriteLine("Resultado:" + (valor1 - valor2));
    break;
      case 3:
    Console.WriteLine("Resultado:"+ (valor1 * valor2));
    break;
       case 4:
       if(valor1 == 0 || valor2 == 0)
       {
        Console.WriteLine("Não é possivel dividir por zero");
       }else{
        Console.WriteLine("Resultado:"+ (valor1 / valor2));
       }
    break;

        case 5:
        if( valor1 == 0 || valor2 == 0)
        {
         Console.WriteLine("Não é possivel dividir por zero");
        } else {
            Console.WriteLine("Resultado:" + (valor1 % valor2));
        }
        break;
  default:
    Console.WriteLine("Opção inválida");
    break;
}
}

