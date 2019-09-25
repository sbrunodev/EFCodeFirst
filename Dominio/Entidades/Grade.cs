using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeNome { get; set; }
        public string Sessao { get; set; }

        public ICollection<Estudante> Estudantes { get; set; }
    }
}
