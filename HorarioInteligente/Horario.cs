using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HeuristicaConstrutiva;

namespace HorarioInteligente
{
    public class Horario
    {

        public string ident
        {
            get;
            set;
        }
        public List<Professor> restHorario
        {
            get;
            set;
        }

        public Horario(String ide)
        {
            ident = ide;
            restHorario = new List<Professor>();

        }

        public Horario()
        {
            restHorario = new List<Professor>();

        }

        public void AddRestHorario(Professor prof)
        {
            restHorario.Add(prof);
        }

        public void RemoveRestHorario(Professor prof)
        {
            restHorario.Remove(prof);
        }
    }
}
