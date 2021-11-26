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
        public void Atualiza(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int Proximo()
        {
            throw new NotImplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}