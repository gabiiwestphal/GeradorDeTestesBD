using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloDisciplina;

namespace GeradorDeTestes.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public Disciplina Disciplina { get; set; }
        public string Nome { get; set; }
        public string Serie { get; set; }

        public Materia()
        {

        }

        public Materia(int numero, Disciplina disciplina, string nome, string serie) : this()
        {
            Numero = numero;
            Disciplina = disciplina;
            Nome = nome;
            Serie = serie;
        }
        public override void Atualizar(Materia registro)
        {
            this.Nome = registro.Nome;
            this.Disciplina = registro.Disciplina;
            this.Serie = registro.Serie;

        }

        public override string ToString()
        {
            if (this.Serie == "0")
            {
                return $"{Nome}";
            }
            else
            {

                return $"{Nome} - {Serie}º série";
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Materia materia &&
                   Numero == materia.Numero &&
                   EqualityComparer<Disciplina>.Default.Equals(Disciplina, materia.Disciplina) &&
                   Nome == materia.Nome &&
                   Serie == materia.Serie;
        }
    }
}
