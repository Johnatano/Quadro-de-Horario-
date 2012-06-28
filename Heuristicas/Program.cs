﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HeuristicaConstrutiva;
using HeuristicaMelhoria;
using ProblemaMochila;
using HorarioInteligente;

namespace Heuristicas
{
    class Program
    {
        static void Main(string[] args)
        {
            OtimizaMochila heuristica = new OtimizaMochila(75);
            heuristica.AddItem(new Item() { Descricao = "Lanterna", Peso = 3, Utilidade = 15 });
            heuristica.AddItem(new Item() { Descricao = "Canivete Suíço", Peso = 1, Utilidade = 10 });
            heuristica.AddItem(new Item() { Descricao = "Jaca", Peso = 30, Utilidade = 3 });
            heuristica.AddItem(new Item() { Descricao = "Panela", Peso = 5, Utilidade = 15 });
            heuristica.AddItem(new Item() { Descricao = "Carne", Peso = 10, Utilidade = 20 });
            heuristica.AddItem(new Item() { Descricao = "Arroz", Peso = 7, Utilidade = 20 });
            heuristica.AddItem(new Item() { Descricao = "Feijão", Peso = 8, Utilidade = 20 });
            heuristica.AddItem(new Item() { Descricao = "Cerveja", Peso = 15, Utilidade = 8 });
            heuristica.AddItem(new Item() { Descricao = "Mapa", Peso = 1, Utilidade = 15 });
            heuristica.AddItem(new Item() { Descricao = "Celular", Peso = 3, Utilidade = 9 });
            heuristica.AddItem(new Item() { Descricao = "Barraca", Peso = 8, Utilidade = 60 });
            heuristica.AddItem(new Item() { Descricao = "Cobertor", Peso = 8, Utilidade = 25 });
            heuristica.AddItem(new Item() { Descricao = "Jornal", Peso = 3, Utilidade = 5 });
            heuristica.AddItem(new Item() { Descricao = "Papel Higiênico", Peso = 2, Utilidade = 14 });
            heuristica.AddItem(new Item() { Descricao = "Carvão", Peso = 8, Utilidade = 15 });
            heuristica.AddItem(new Item() { Descricao = "Repelente", Peso = 2, Utilidade = 5 });
            heuristica.AddItem(new Item() { Descricao = "Vara de Pescar", Peso = 3, Utilidade = 2 });
            heuristica.AddItem(new Item() { Descricao = "Pente", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Espelho", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Sabão", Peso = 2, Utilidade = 7 });
            heuristica.AddItem(new Item() { Descricao = "Xampu", Peso = 4, Utilidade = 5 });
            heuristica.AddItem(new Item() { Descricao = "Luvas", Peso = 1, Utilidade = 2 });
            heuristica.AddItem(new Item() { Descricao = "Violão", Peso = 15, Utilidade = 4 });
            heuristica.AddItem(new Item() { Descricao = "Fósforo", Peso = 1, Utilidade = 7 });
            heuristica.AddItem(new Item() { Descricao = "Isqueiro", Peso = 1, Utilidade = 9 });
            heuristica.AddItem(new Item() { Descricao = "Bússola", Peso = 2, Utilidade = 14 });
            heuristica.AddItem(new Item() { Descricao = "Roupa", Peso = 5, Utilidade = 28 });
            heuristica.AddItem(new Item() { Descricao = "Sapatos", Peso = 3, Utilidade = 11 });
            heuristica.AddItem(new Item() { Descricao = "Protetor Solar", Peso = 2, Utilidade = 6 });
            heuristica.AddItem(new Item() { Descricao = "Pratos", Peso = 5, Utilidade = 12 });
            heuristica.AddItem(new Item() { Descricao = "Colheres", Peso = 1, Utilidade = 8 });
            heuristica.AddItem(new Item() { Descricao = "Facas", Peso = 1, Utilidade = 13 });
            heuristica.AddItem(new Item() { Descricao = "Binóculos", Peso = 5, Utilidade = 3 });
            heuristica.AddItem(new Item() { Descricao = "GPS", Peso = 5, Utilidade = 20 });
            heuristica.AddItem(new Item() { Descricao = "Notebook", Peso = 15, Utilidade = 5 });
            heuristica.AddItem(new Item() { Descricao = "Som", Peso = 16, Utilidade = 8 });
            heuristica.AddItem(new Item() { Descricao = "Livro", Peso = 3, Utilidade = 3 });
            heuristica.AddItem(new Item() { Descricao = "Corda", Peso = 5, Utilidade = 15 });
            heuristica.AddItem(new Item() { Descricao = "Lixa Unha", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Esmalte", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Alicate", Peso = 2, Utilidade = 8 });
            heuristica.AddItem(new Item() { Descricao = "Machado", Peso = 15, Utilidade = 50 });
            heuristica.AddItem(new Item() { Descricao = "Linha", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Agulha", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Band Aid", Peso = 1, Utilidade = 12 });
            heuristica.AddItem(new Item() { Descricao = "Mertiolate", Peso = 1, Utilidade = 11 });
            heuristica.AddItem(new Item() { Descricao = "Gaze", Peso = 1, Utilidade = 13 });
            heuristica.AddItem(new Item() { Descricao = "Perfume", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Leite", Peso = 4, Utilidade = 10 });
            heuristica.AddItem(new Item() { Descricao = "Biscoitos", Peso = 4, Utilidade = 10 });
            heuristica.AddItem(new Item() { Descricao = "Sucrilhos", Peso = 3, Utilidade = 7 });
            heuristica.AddItem(new Item() { Descricao = "Bombons", Peso = 3, Utilidade = 5 });
            heuristica.AddItem(new Item() { Descricao = "Meias", Peso = 1, Utilidade = 2 });
            heuristica.AddItem(new Item() { Descricao = "Chapeu", Peso = 3, Utilidade = 7 });
            heuristica.AddItem(new Item() { Descricao = "Estilingue", Peso = 1, Utilidade = 4 });
            heuristica.AddItem(new Item() { Descricao = "Martelo", Peso = 6, Utilidade = 12 });
            heuristica.AddItem(new Item() { Descricao = "Arame", Peso = 6, Utilidade = 15 });
            

            heuristica.GerarSolucao();
            int u = 0;
            foreach (IComponente c in heuristica.Solucao.Componentes)
            {
                Item item = (Item)c;
                u += item.Utilidade;
                System.Console.WriteLine(item.Descricao + " \t\t\tPeso: " + item.Peso + " \tUtilidade: " + item.Utilidade);
            }

            System.Console.WriteLine("\n===================================================\n ");
            System.Console.WriteLine("Peso da Mochila: " + heuristica.Mochila.CapacidadeAtual);
            System.Console.WriteLine("Utilidade da Mochila: " + heuristica.Solucao.Avaliacao);

            System.Console.ReadLine();
            
            // Quadro de Horario

            ConstroiHorario quadroHorario = new ConstroiHorario();
            

            Horario SEG12 = new Horario("SEG12");
            quadroHorario.AddHorarios(SEG12);
            Horario SEG34 = new Horario("SEG34");
            quadroHorario.AddHorarios(SEG34);
            Horario TER12 = new Horario("TER12");
            quadroHorario.AddHorarios(TER12);
            Horario TER34 = new Horario("TER34");
            quadroHorario.AddHorarios(TER34);
            Horario QUA12 = new Horario("QUA12");
            quadroHorario.AddHorarios(QUA12);
            Horario QUA34 = new Horario("QUA34");
            quadroHorario.AddHorarios(QUA34);
            Horario QUI12 = new Horario("QUI12");
            quadroHorario.AddHorarios(QUI12);
            Horario QUI34 = new Horario("QUI34");
            quadroHorario.AddHorarios(QUI34);
            Horario SEX12 = new Horario("SEX12");
            quadroHorario.AddHorarios(SEX12);
            Horario SEX34 = new Horario("SEX34");
            quadroHorario.AddHorarios(SEX34);


            Professor P1 = new Professor("P1"); 
            quadroHorario.AddProfessores(P1);
            Professor P2 = new Professor("P2");
            quadroHorario.AddProfessores(P2);
            Professor P3 = new Professor("P3");
            quadroHorario.AddProfessores(P3);
            Professor P4 = new Professor("P4");
            quadroHorario.AddProfessores(P4);
            Professor P5 = new Professor("P5");
            quadroHorario.AddProfessores(P5);
            

            quadroHorario.AddRestricoes(P1, SEG12);
            quadroHorario.AddRestricoes(P1, TER12);
            quadroHorario.AddRestricoes(P1, QUI12);
            
            quadroHorario.AddRestricoes(P2, SEX34);
            quadroHorario.AddRestricoes(P2, QUI34);

            quadroHorario.AddRestricoes(P3, QUA12);
            quadroHorario.AddRestricoes(P3, QUA34);
            quadroHorario.AddRestricoes(P3, TER34);

            quadroHorario.AddRestricoes(P4, SEX34);
            quadroHorario.AddRestricoes(P4, QUI12);

            quadroHorario.AddRestricoes(P5, TER12);
            quadroHorario.AddRestricoes(P5, QUI12);
            quadroHorario.AddRestricoes(P5, QUA12);

            quadroHorario.GerarSolucao();

            System.Console.WriteLine("\n===================================================\n ");
            System.Console.WriteLine("\nQuadro de Horario\n\n ");
            foreach(Alocacao al in quadroHorario.Solucao.Componentes)
            {
                   System.Console.Write("Horario: "+al.horario.ident + "  Professor: " + al.professor.nomeProfessor+"\n");
                  
            }
            
            System.Console.ReadLine();
        
        }
    }
}
