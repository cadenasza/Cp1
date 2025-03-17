using Cp1;

class Program
{
    static void Main(string[] args)
    {
        FuncionarioCLT funcionarioCLT = new FuncionarioCLT("João", 5000, 8);
        FuncionarioPj funcionarioPJ = new FuncionarioPj("Maria", 5000, 15);

        Console.WriteLine($"Salário Líquido de {funcionarioCLT.Nome} (CLT): R$ {funcionarioCLT.CalcularSalario():F2}");
        Console.WriteLine($"Salário Líquido de {funcionarioPJ.Nome} (PJ): R$ {funcionarioPJ.CalcularSalario():F2}");
    }
}