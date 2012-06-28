using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HeuristicaConstrutiva;


namespace HorarioInteligente
{
    public class Professor
    {
        public string nomeProfessor
        {
            get;
            set;
        }
        public List<Horario> Restricoes
        {
            get;
            set;
        }

        public List<Horario> HorarioAlocado
        {
            get;
            set;
        }

        public Professor()
        {
            Restricoes = new List<Horario>();
            HorarioAlocado = new List<Horario>();
        }

        public Professor(string nome)
        {
            Restricoes = new List<Horario>();
            HorarioAlocado = new List<Horario>();
            this.nomeProfessor = nome;

            //nomeProfessor = nome; 
        }

        public void AddRestrincoes(Horario horario)
        {//!Restricoes.Contains(horario)
            //if (Restricoes != null)
            //if (!Restricoes.Contains(horario))
            if (Restricoes != null)
            {
                Restricoes.Add(horario);
            }
        }

        public void RemoveRestrincoes(Horario horario)
        {
            if (Restricoes != null)
            {
                Restricoes.Remove(horario);
            }
        }

        public void AddHorarioAlocado(Horario horario)
        {
            if (!HorarioAlocado.Contains(horario))
            {
                HorarioAlocado.Add(horario);
            }
        }

        public void RemoveHorarioAlocado(Horario horario)
        {
            if (HorarioAlocado != null)
            {
                HorarioAlocado.Remove(horario);
            }

        }
    }
}
