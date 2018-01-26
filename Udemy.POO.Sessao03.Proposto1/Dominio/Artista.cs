using System;
using System.Collections.Generic;
using System.Globalization;

namespace Udemy.POO.Sessao03.Proposto1.Dominio {
    class Artista : IComparable {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public double Cache { get; private set; }

        public Artista(int codigo, string nome, double cache) {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Cache = cache;
        }

        public int CompareTo(object obj) {
            int ret;
            Artista artistaCompare = (Artista)obj;

            ret = this.Nome.CompareTo(artistaCompare.Nome);

            return ret;
        }

        public override string ToString() {
            return this.Codigo.ToString()
                + ", "
                + this.Nome
                + ", Cachê: "
                + this.Cache.ToString("F2", CultureInfo.InvariantCulture);
        }

        public static void IniciarArtistas(ref List<Artista> listaArtistas) {
            listaArtistas.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            listaArtistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            listaArtistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            listaArtistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
        }
    }
}
