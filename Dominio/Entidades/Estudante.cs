using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Estudante
    {
        public int EstudanteID { get; set; }
        public string Nome { get; set; }
        public DateTime? DataDeAniversario { get; set; }
        public byte[] Foto { get; set; }
        public decimal Altura { get; set; }
        public float Peso { get; set; }

        public Grade Grade { get; set; }
    }
}
