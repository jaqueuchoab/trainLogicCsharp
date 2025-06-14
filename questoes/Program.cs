using System;

class Program
{
    static void Main(string[] args)
    {
      int option = 0;

      Pedido pedido = new Pedido();
      AreaCirculo circulo = new AreaCirculo();
      TabelaProdutos tabela = new TabelaProdutos();

      Console.WriteLine("Menu de Opções:");
      Console.WriteLine("1 - Ler dados do pedido\n2 - Calcular àrea de um circulo\n3 - Escolha seu lanche\n");
      Console.Write("Escolha uma opção: ");
      option = int.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          // 11, 2, 10
          // 10, 2, 20
          pedido.LerDadosPedido();
          pedido.ExibirValorTotal();
          break;

        case 2:
          // 5.0
          circulo.LerRaio();
          circulo.ExibirAreaCirulo();
          break;

        case 3:
          // 1, 2
          tabela.LerDadosPedido();
          tabela.CalcularValorTotal();
          tabela.ExibirValorTotal();
          break;

        default:
          Console.WriteLine("Opção inválida.");
          break;
      }
    }
}