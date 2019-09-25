using System;
using Dominio.Entidades;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EscolaContext())
            {
                var stud = new Estudante() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
