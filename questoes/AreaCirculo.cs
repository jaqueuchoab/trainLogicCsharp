using System;

public class AreaCirculo {
  // Atributos
  private double raio;
  private double PI = 3.14159;

  // Construtor Padrão
  public AreaCirculo(double raio = 1.0f) {
    SetRaio(raio);
  }

  // Métodos de Acesso (getters e setters)
  public double GetRaio() {
    return raio;
  }

  public double GetPI() {
    return PI;
  }

  public void SetRaio(double raio) {
    if(raio > 0) {
      this.raio = raio;
    } else {
      throw new ArgumentException("O raio deve ser um valor positivo.");
    }
  }

  public void SetPI(double pi) {
    if(pi > 0) {
      this.PI = pi;
    } else {
      throw new ArgumentException("O valor de PI deve ser um valor positivo.");
    }
  }

  // Método para calcular a àrea do círculo
  public double CalcularArea() {
    return PI * raio * raio;
  }

  // Método para ler o raio do círculo
  public void LerRaio() {
    Console.Write("Digite o valor do raio do círculo: ");
    this.raio = double.Parse(Console.ReadLine());
  }

  // Método para exibir a àrea do círculo
  public void ExibirAreaCirulo() {
    Console.WriteLine($"A àrea do círculo com raio = {raio} é: {CalcularArea().ToString("F4")}");
  }
}