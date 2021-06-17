using System;

namespace DIO.Series
{
    public abstract class Processar
    {
        static Repositorio repositorio = new Repositorio();

        public abstract void Excluir();

        public abstract void Visualizar();
		
        public abstract void Atualizar();

        public abstract void Listar();

        public abstract void Inserir();
    }
}