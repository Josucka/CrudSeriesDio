using CrudSeriesDio.Enum;
using System;

namespace CrudSeriesDio.Classe
{
    public class Series : EntidadeBase
    {
        private Genero Genero { get; set; }
        
        private string Titulo { get; set; }
        
        private string Descricao { get; set; }
        
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descriçao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano;
            retorno += "Excluirdo: " + this.Excluido;

            return retorno;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public void Exclui()
        {
            this.Excluido = true;
        }
    }
}
