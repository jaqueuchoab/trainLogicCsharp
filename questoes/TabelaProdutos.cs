using System;

public class TabelaProdutos {
  // Atributos
  private int codigo;
  private int quantidade;
  private string descricao;
  private float valorUnitario;

  // Construtor Padrão
  public TabelaProdutos(int codigo = 0, int quantidade = 0) {
    this.codigo = codigo;
    this.quantidade = quantidade;
    if(this.codigo > 0 || this.codigo != 0) {
      MenuProduto(this.codigo);
    }
  }

  // Métodos de Acesso (getters e setters)
  public int GetCodigo() {
    return codigo;
  }

  public string GetDescricao() {
    return descricao;
  }

  public float GetValorUnitario() {
    return valorUnitario;
  }

  public void SetCodigo(int codigo) {
    this.codigo = codigo;
  }

  public void SetDescricao(string descricao) {
    this.descricao = descricao;
  }

  public void SetValorUnitario(float valorUnitario) {
    if (valorUnitario >= 0) {
      this.valorUnitario = valorUnitario;
    } else {
      throw new ArgumentException("O valor unitário não pode ser negativo.");
    }
  }  

  // Método de escolha do produto
  public void MenuProduto(int codigo = 0) {
    if(codigo != 0 || codigo > 0) {
      SetCodigo(codigo);
    } else {
      Console.WriteLine("Código - Descrição         - Preço Unitário");
      Console.WriteLine("  1    - Cachorro Quente   - R$ 4.00");
      Console.WriteLine("  2    - X-Salada          - R$ 4.50");
      Console.WriteLine("  3    - X-Bacon           - R$ 5.00");
      Console.WriteLine("  4    - Torrada Simples   - R$ 2.00");
      Console.WriteLine("  5    - Suco Natural      - R$ 1.50");
      Console.Write("\nDigite o código do produto: ");
      this.codigo = int.Parse(Console.ReadLine());
    }

    switch (this.codigo) {
      case 1:
        SetDescricao("Cachorro Quente");
        SetValorUnitario(4.00f);
        break;
      case 2:
        SetDescricao("X-Salada");
        SetValorUnitario(4.50f);
        break;
      case 3:
        SetDescricao("X-Bacon");
        SetValorUnitario(5.00f);
        break;
      case 4:
        SetDescricao("Torrada Simples");
        SetValorUnitario(2.00f);
        break;
      case 5:
        SetDescricao("Refrigerante");
        SetValorUnitario(1.50f);
        break;
      default:
        Console.WriteLine("Opção inválida.");
        break;
    }
  }

  // Método para ler os dados do pedido
  public void LerDadosPedido() {
    Console.WriteLine("\nEscolha o produto:\n");
    MenuProduto();
    Console.Write("Digite a quantidade:");
    this.quantidade = int.Parse(Console.ReadLine());
  }


  // Método para calcular o valor total do pedido
  public float CalcularValorTotal(float valorUnitario = 0, int quantidade = 0) {
    return (float) valorUnitario * quantidade;
  }

  // Método para exibir o valor total do pedido
  public void ExibirValorTotal() {
    Console.WriteLine(
      $"\n{this.quantidade}UND - {descricao}({codigo}) = {CalcularValorTotal(this.valorUnitario, this.quantidade).ToString("F2")}"
    );
  }
}