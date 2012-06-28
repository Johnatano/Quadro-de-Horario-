using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeuristicaConstrutiva;

namespace CaixeiroViajante
{
    public class ConstroiGrafo : HeuristicaConstrutiva.HeuristicaConstrutiva
    {
        public List<Aresta> Arestas { get; set; }
        public int QtdeCidades { get; set; }
        public Grafo grafo
        {
            get
            {
                return (Grafo)Solucao;
            }
        }

        public ConstroiGrafo(int qtdCidade) 
        {
            QtdeCidades = qtdCidade;
            Arestas = new List<Aresta>();
        }

        public void AddAresta(Aresta aresta)
        {
            Arestas.Add(aresta);
        }

        public override List<IComponente> GerarComponentes()
        {
            List<IComponente> arestas = new List<IComponente>();
            foreach (Aresta aresta in Arestas)
            {
                if (grafo.Componentes.Contains(aresta))
                    continue;
                
                arestas.Add(aresta);
            }
            return arestas;
        }

        public override IComponente EscolheMelhorComponente(List<IComponente> Componentes)
        {
            /*Aresta melhor = (Aresta)Componentes.FirstOrDefault();
            foreach (Aresta aresta in Componentes)
            {
                if (melhor != null)
                    if ((int)melhor.Valor < (int)item.Valor)
                        melhor = item;
            }
            return melhor;*/
            return null;
        }

        public override ISolucao CriaSolucaoVazia()
        {
            throw new NotImplementedException();
        }

        public override bool VerificaSolucaoCompleta()
        {
            throw new NotImplementedException();
        }
    }
}
