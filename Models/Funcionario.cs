using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula02RH.Models.Enuns;


namespace Aula02RH.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        public TipoFuncionarioEnum TipoFuncionario { get; set; }

        public void ReajustarSalario()
        {
            Salario = Salario + (Salario * 10/100);
        }

        public string ExibirPeriodoExperiencia()
        {
            string periodoExperiencia 
                = string.Format("Período de Experiência: {0} até {1}", 
                    DataAdmissao, DataAdmissao.AddMonths(3));

            return periodoExperiencia;
        }


    }
}