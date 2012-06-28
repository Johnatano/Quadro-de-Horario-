using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HeuristicaConstrutiva;


namespace HorarioInteligente
{
    public class ConstroiHorario : HeuristicaConstrutiva.HeuristicaConstrutiva
    {



        public QuadroHorario Horario
        {
            get;
            set;
        }

        public List<Horario> horarios
        {
            get;
            set;
        }

        public List<Professor> professores
        {
            get;
            set;
        }

        List<IComponente> alocPoss
        {
            get;
            set;
        }
        

        public QuadroHorario quadro
        {
            get
            {
                return (QuadroHorario)Solucao;
            }
        }

        public ConstroiHorario()
        {
            horarios = new List<Horario>();
            professores = new List<Professor>();
            

        }

        public override List<IComponente> GerarComponentes()
        {
            alocPoss = new List<IComponente>();
            // para gerar a lista de  componentes possiveis
            for (int i = 0; i < professores.Count(); i++)
            {
                if (!RestrincaoHorario(professores[i], Solucao.Componentes.Count()) && CargaHorariaIncompleta(professores[i]))
                {
                    alocPoss.Add(new Alocacao(professores[i], horarios[Solucao.Componentes.Count()]));
                }
            }

            return alocPoss;
        }

        public override IComponente EscolheMelhorComponente(List<IComponente> Componentes)
        {
            Alocacao alocar = new Alocacao();
            int pos = 0;
            int memPos = -1;
            int numRestricoes = -1;

            foreach (Alocacao aloc in Componentes)
            {
                // para selecionar a lista de prof
                if (aloc.professor.Restricoes.Count() > numRestricoes && CargaHorariaIncompleta(aloc.professor))
                {
                    numRestricoes = aloc.professor.Restricoes.Count();
                    memPos = pos;
                }
                pos++;
            }

            if (memPos > -1)
            {
                alocar = (Alocacao)Componentes[memPos];
            }
            else
            {
                // chama a função para realocar o prof
                alocar = Realocacao();
                if (alocar == null)
                {
                    System.Console.Write("Infelismente não foi possível gerar uma solução .\n\n");
                }
            }

            return alocar;
        }

        Alocacao Realocacao()
        {
            Alocacao al = new Alocacao();
            List<Professor> cargaInc = new List<Professor>();

            for (int i = 0; i < professores.Count(); i++)
            {
                // para adicionar a lista dos professores
                if (CargaHorariaIncompleta(professores[i]))
                {
                    cargaInc.Add(professores[i]);
                }
            }
            for (int i = 0; i < Solucao.Componentes.Count(); i++)
            {
                Alocacao aloc = (Alocacao)Solucao.Componentes[i];
                System.Console.Write(cargaInc.Count + "    " );
                    
                for (int j = 0; j < cargaInc.Count(); j++)
                {
                   // tenta trocar um professor alocado por um disponivel na lista de componentes da solução
                    if (!aloc.horario.restHorario.Contains(cargaInc[j]))
                    {
                        Solucao.Componentes.Remove(Solucao.Componentes[i]);
                        Solucao.Componentes.Insert(i, new Alocacao(cargaInc[j], aloc.horario));
                        return (new Alocacao(aloc.professor, horarios[Solucao.Componentes.Count()]));
                    }
                }
            }
            return al;
        }

       

        Boolean RestrincaoHorario(Professor p, int i)
        {
            // verifica se o professor tem restrição 
            if (p.Restricoes.Contains(horarios[i]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        Boolean CargaHorariaIncompleta(Professor p)
        {
            int alocAulas = 0;

            // verifica a quantidade de alocação do professor
            foreach (Alocacao aloc in Solucao.Componentes)
            {
                if (aloc.professor.nomeProfessor == p.nomeProfessor)
                {
                    alocAulas++;
                }
            }

            if (alocAulas < 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool VerificaSolucaoCompleta()
        {
            if (Solucao.Componentes.Count() < 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddProfessores(Professor p)
        {
            if (!professores.Contains(p))
            {
                professores.Add(p);
            }
        }

        public void RemoveProfessores(Professor p)
        {
            if (professores.Contains(p))
            {
                professores.Remove(p);
            }
        }

        public void AddHorarios(Horario h)
        {
            if (!horarios.Contains(h))
            {
                horarios.Add(h);
            }

        }

        public void RemoveHorarios(Horario h)
        {
            if (horarios.Contains(h))
            {
                horarios.Remove(h);
            }
        }

        public void AddRestricoes(Professor prof, Horario hor)
        {
            int i = 0;
            while (professores[i].nomeProfessor != prof.nomeProfessor)
            {
                i++;
            }
            professores[i].AddRestrincoes(hor);
            i = 0;
            while (horarios[i].ident != hor.ident)
            {
                i++;
            }

            horarios[i].AddRestHorario(prof);
        }





        public override ISolucao CriaSolucaoVazia()
        {
            Horario = new QuadroHorario();
            return Horario;
        }
    }
}
