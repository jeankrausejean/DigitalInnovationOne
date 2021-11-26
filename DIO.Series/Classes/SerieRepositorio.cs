using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaserie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaserie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaserie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaserie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaserie;
        }

        public int ProximoId()
        {
            return listaserie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaserie[id];
        }
    }
}