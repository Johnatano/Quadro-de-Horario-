using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeuristicaConstrutiva;

namespace CaixeiroViajante
{
   
    public class Aresta : IComponente
    {
        public int CidadeOrigem { get; set; }
        public int CidadeDestino { get; set; }
        public int Distancia { get; set; }
        //public int[][] GGrafo;
        //public int QtdCidades;

        public Aresta()
        {
            CidadeOrigem = 0;
            CidadeDestino = 0;
            Distancia = 0;

            //QtdCidades = qtdeCidades;

            //for (int i = 0; i < QtdCidades; i++)
            //    for (int j = 0; j < QtdCidades; j++)
            //        GGrafo[i][j] = 0;
        }

        public object Valor
        {
            get
            {
                return Distancia;
            }
        }

        object IComponente.Valor
        {
            get { throw new NotImplementedException(); }
        }
    }
}
