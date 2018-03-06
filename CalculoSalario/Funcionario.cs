using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario {
    public class Funcionario {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario) {
            this.Nome = nome;
            this.Salario = salario;
        }
    }
}
