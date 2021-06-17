using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class Repositorio : IRepositorio<EntidadeBase>
    {
        private List<EntidadeBase> lista = new List<EntidadeBase>();
        public void Atualiza(int id, EntidadeBase objeto)
        {
            lista[id] = objeto;
        }

        public void Exclui(int id)
        {
            lista[id].Excluir();
        }

        public void Insere(EntidadeBase objeto)
        {
            lista.Add(objeto);
        }

        public List<EntidadeBase> Lista()
        {
            return lista;
        }

        public int ProximoId()
        {
            return lista.Count;
        }

        public EntidadeBase RetornaPorId(int id)
        {
            return lista[id];
        }
    }
}