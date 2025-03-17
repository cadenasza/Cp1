using cp1;

class Program
{
    static void Main()
    {
        Circulo circulo = new Circulo(5);
        Retangulo retangulo = new Retangulo(4, 6);
        Triangulo triangulo = new Triangulo(3, 4, 5);

        Console.WriteLine($"Área do círculo: {circulo.CalcularArea():F2}, Perímetro: {circulo.CalcularPerimetro():F2}");
        Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea():F2}, Perímetro: {retangulo.CalcularPerimetro():F2}");
        Console.WriteLine($"Área do triângulo : {triangulo.CalcularArea():F2}, Perímetro: {triangulo.CalcularPerimetro():F2}");
    }
}