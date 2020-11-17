using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeFolhaPagamento_POO
namespace Course.Entities
{
    class Employee
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Employee()
        {
        }

        public Employee(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Hora = hora;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return Hora * ValorPorHora;
        }
    }
}
