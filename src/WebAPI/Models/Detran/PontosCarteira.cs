using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Models.Detran
{
    public class PontosCarteira
    {
        public DateTime DataOcorrencia { get; set; }
        public string Descricao { get; set; }
        public int Pontos { get; set; }

    }
}
