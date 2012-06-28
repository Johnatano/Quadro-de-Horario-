using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using HeuristicaConstrutiva;

namespace HorarioInteligente
{

    public class Alocacao : IComponente
    {

        public Professor professor
        {
            get;
            set;
        }
        public Horario horario
        {
            get;
            set;
        }

        public Alocacao()
        {
            professor = new Professor();
            horario = new Horario();
        }

        public Alocacao(Professor prof, Horario hor)
        {
            professor = prof;
            horario = hor;
        }


        public object Valor
        {
            get { throw new NotImplementedException(); }
        }




    }





}
