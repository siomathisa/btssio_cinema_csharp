using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Film
    {
        private int annee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;

        public Film (int annee, string genre, int idFilm, string resume, string titre)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
        }

        public static Film getInstance(int annee, string genre, int idFilm, string resume, string titre)
        {
            return new Film(annee, genre, idFilm, resume, titre);
        }

        public int getAnnee
        {
            get { return this.annee; }
            set { this.annee = value; }
        }
        public string getGenre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }
        public int getIdFilm
        {
            get { return this.idFilm; }
            set { this.idFilm = value; }
        }
        public string getResume
        {
            get { return this.resume; }
            set { this.resume = value; }
        }
        public string getTitre
        {
            get { return this.titre; }
            set { this.titre = value; }
        }

        public Acteur getActeur
        {
            get { return this.acteurPrincipal; }
            set { this.acteurPrincipal = value; }
        }

        public Acteur getActeurPrincipal ()
        {
            return this.acteurPrincipal;
        }

        public override string ToString()
        {
            return $"Titre : {this.titre}\nAnnée : {this.annee}\nGenre : {this.genre}\nRésumé : {this.resume}";
        }

    }
}
