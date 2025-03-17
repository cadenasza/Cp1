using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cp1
{
    public class FuncionarioCLT : Funcionario
    {
        public double DescontoINSS { get; set; }

        public FuncionarioCLT(string nome, double salarioBase, double descontoINSS)
            : base(nome, salarioBase)
        {
            DescontoINSS = descontoINSS;
        }
        public override double CalcularSalario()
        {
            return SalarioBase - (SalarioBase * DescontoINSS / 100);
        }
    }


}
