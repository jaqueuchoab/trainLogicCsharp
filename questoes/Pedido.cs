using System;

public class Pedido
{
	// Atributos 
	private int codigoUm;
  private int codigoDois;
  private int quantidadeUm;
  private int quantidadeDois;
	private float valorUnitarioUm;
	private float valorUnitarioDois;

	// Construtor padrão
	public Pedido (int codigoUm = 0, int quantidadeUm = 0, int codigoDois = 0, int quantidadeDois = 0) {
		this.codigoUm = codigoUm;
		this.quantidadeUm = quantidadeUm;
		this.codigoDois = codigoDois;
		this.quantidadeDois = quantidadeDois;
	}

	// Métodos de acesso (getters e setters)
	public int GetCodigoUm() {
		return codigoUm;
	}

	public int GetCodigoDois() {
		return codigoDois;
	}

	public int GetQuantidadeUm() {
		return quantidadeUm;
	}

	public int GetQuantidadeDois() {
		return quantidadeDois;
	}

	public float GetValorUnitarioUm() {
		return valorUnitarioUm;
	}

	public float GetValorUnitarioDois() {
		return valorUnitarioDois;
	}

	public void SetCodigoUm(int codigo)
	{
		this.codigoUm = codigo;
	}

	public void SetCodigoDois(int codigo)
	{
		this.codigoDois = codigo;
	}

	public void SetQuantidadeUm(int quantidade)
	{
		this.quantidadeUm = quantidade;
	}

	public void SetQuantidadeDois(int quantidade)
	{
		this.quantidadeDois = quantidade;
	}

	public void SetValorUnitarioUm(float valor)
	{
		this.valorUnitarioUm = valor;
	}

	public void SetValorUnitarioDois(float valor)
	{
		this.valorUnitarioDois = valor;
	}

	// Método para leitura dos dados do pedido
	public void LerDadosPedido() {
		// Leitura dos dados do pedido
		Console.WriteLine("Digite o código, quantidade e valor unitário do primeiro item:");
		this.codigoUm = int.Parse(Console.ReadLine());
		this.quantidadeUm = int.Parse(Console.ReadLine());
		this.valorUnitarioUm = float.Parse(Console.ReadLine());

		Console.WriteLine("Digite o código, quantidade e valor unitário do segundo item:");
		this.codigoDois = int.Parse(Console.ReadLine());
		this.quantidadeDois = int.Parse(Console.ReadLine());
		this.valorUnitarioDois = float.Parse(Console.ReadLine());
	}

	// Método para calcular o valor total do pedido
	public float CalcularValorTotal() {
		float valorTotalUm = quantidadeUm * valorUnitarioUm;
		float valorTotalDois = quantidadeDois * valorUnitarioDois;
		return valorTotalUm + valorTotalDois;
	}

	// Método para exibir o valor total do pedido
	public void ExibirValorTotal() {
		// Exibição do resultado formatado
		Console.WriteLine("VALOR A PAGAR: R$ " + CalcularValorTotal().ToString("F2"));
	}
}
