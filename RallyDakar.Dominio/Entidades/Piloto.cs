using System;
using System.Collections.Generic;
using System.Text;

namespace RallyDakar.Dominio.Entidades
{
    public class Piloto
    {

        public int id { get; set; }
        public string Nome { get; set; }
        public int EquipeId { get; set; }
        public virtual Equipe Equipe { get; set; }

    }
}
