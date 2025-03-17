using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cp1
{
    public class FuncionarioPj : Funcionario
    {
        public double TaxaImposto { get; set; }
        public FuncionarioPj(string nome, double salarioBase, double taxaImposto)
            : base(nome, salarioBase)
        {
            TaxaImposto = taxaImposto;
        }
        public override double CalcularSalario()
        {
            return SalarioBase - (SalarioBase * TaxaImposto / 100);
        }
    }
}
