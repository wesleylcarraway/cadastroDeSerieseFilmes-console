using System;

namespace DIO.Series
{
    public class Filme : EntidadeBase
    {
        public Filme(int id, Genero genero, string titulo, string descricao, int ano) : base(id, genero, titulo, descricao, ano)
        {
        }
    }
}