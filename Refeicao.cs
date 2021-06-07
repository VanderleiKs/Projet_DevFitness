using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFitness
{
    public class Refeicao
    {
        public string Descricao { get; set; }
        public int Calorias { get; set; }

        public Refeicao() { }

        public Refeicao(string descricao, int calorias)
        {
            this.Descricao = descricao;
            this.Calorias = calorias;
        }

        public void ImprimirRefeicoes()
        {
            Console.WriteLine($"{Descricao} com {Calorias} calorias");
        }
    }
}
