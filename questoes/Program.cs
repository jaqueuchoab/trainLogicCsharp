using System;

class Program
{
    static void Main(string[] args)
    {
      int option = 0;

      Pedido pedido = new Pedido();

      Console.WriteLine("Menu de Opções:");
      Console.WriteLine("1 - Ler dados do pedido\n2- Calcular àrea de um circulo");
      Console.Write("Escolha uma opção: ");
      option = int.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          pedido.LerDadosPedido();
          // 11, 2, 10
          // 10, 2, 20
          pedido.ExibirValorTotal();
          break;

        default:
          Console.WriteLine("Opção inválida.");
          break;
      }
    }
}