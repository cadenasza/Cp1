# MÁTERIA: ADVANCED BUSINESS DEVELOPMENT WITH .NET 💻

<img width="48" height="48" src="https://img.icons8.com/color/48/c-sharp-logo-2.png" alt="c-sharp-logo-2"/>

INTEGRANTES:

Davi Gonzaga Ferreira - RM554890

Jennifer Eduarda Vieira Daleffi - RM557137

Leonardo Cadena de Souza - RM557528 

## Exercício 01

Considere uma empresa que possui diferentes tipos de funcionários, sendo
eles contratados sob o regime CLT (Consolidação das Leis do Trabalho) e como
Pessoa Jurídica (PJ). Cada tipo de funcionário possui regras específicas para o
cálculo de salários e impostos.

# Crie uma classe base chamada Funcionario com as seguintes propriedades:

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
