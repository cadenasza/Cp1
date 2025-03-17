# MÁTERIA: ADVANCED BUSINESS DEVELOPMENT WITH .NET 💻

<img width="48" height="48" src="https://img.icons8.com/color/48/c-sharp-logo-2.png" alt="c-sharp-logo-2"/>

# INTEGRANTES:

Davi Gonzaga Ferreira - RM554890

Jennifer Eduarda Vieira Daleffi - RM557137

Leonardo Cadena de Souza - RM557528 

## Exercício 01

Considere uma empresa que possui diferentes tipos de funcionários, sendo
eles contratados sob o regime CLT (Consolidação das Leis do Trabalho) e como
Pessoa Jurídica (PJ). Cada tipo de funcionário possui regras específicas para o
cálculo de salários e impostos.

## Crie uma classe base chamada Funcionario com as seguintes propriedades:

● Nome (string): o nome do funcionário.

● SalarioBase (double): o salário base do funcionário.

## Implemente um método virtual na classe Funcionario chamado
CalcularSalario que retorna o salário base do funcionário.
Crie uma classe derivada chamada FuncionarioCLT, que herda da
classe Funcionario. Esta classe deve ter uma propriedade adicional:

● DescontoINSS (double): a taxa de desconto do INSS sobre o
salário.
Sobrescreva o método CalcularSalario na classe FuncionarioCLT para
considerar o desconto do INSS no cálculo do salário líquido.
Crie outra classe derivada chamada FuncionarioPJ, que herda da classe
Funcionario. Esta classe deve ter uma propriedade adicional:

● TaxaImposto (double): a taxa de imposto sobre o salário para
funcionários PJ.
Sobrescreva o método CalcularSalario na classe FuncionarioPJ para
descontar a taxa de imposto do salário base, resultando no salário
líquido.

No método Main de uma classe chamada Program, crie instâncias de
FuncionarioCLT e FuncionarioPJ com dados fictícios e exiba o salário
líquido de cada funcionário.

## Exercício 02

Imagine que você está desenvolvendo um sistema para lidar com diferentes
formas geométricas. Cada forma deve ser representada por uma classe
específica, e o sistema deve ser capaz de calcular áreas e perímetros para
diferentes tipos de formas.

## Crie uma classe base chamada FormaGeometrica com os seguintes
membros:

● CalcularArea() (método virtual): deve calcular e retornar a área
da forma geométrica.

● CalcularPerimetro() (método virtual): deve calcular e retornar o
perímetro da forma geométrica.

## Implemente duas classes derivadas: Circulo e Retangulo.

● Circulo deve ter uma propriedade adicional Raio (double).

● Retangulo deve ter duas propriedades adicionais Largura e
Altura, ambas do tipo double.

## Sobrescreva os métodos CalcularArea e CalcularPerimetro nas
classes derivadas.

● Para o Circulo, a área deve ser calculada como π * raio^2 e o
perímetro como 2 * π * raio.

● Para o Retangulo, a área deve ser calculada comolargura * altura
e o perímetro como 2 * (largura + altura).

## Crie uma terceira classe derivada chamada Triangulo.

● Triangulo deve ter três propriedades adicionais LadoA, LadoB e
LadoC, todas do tipo double.

## Sobrecarregue os métodos CalcularArea e CalcularPerimetro na
classe Triangulo.

● Para o Triangulo, a área pode ser calculada usando a fórmula de
Herão e o perímetro como a soma dos três lados.

Obs: Fórmula de Herão:

A fórmula de Herão, também conhecida como fórmula de Herão de Alexandria,
é uma fórmula utilizada para calcular a área de um triângulo quando
conhecidos os comprimentos dos três lados. A fórmula é expressa da seguinte
maneira
