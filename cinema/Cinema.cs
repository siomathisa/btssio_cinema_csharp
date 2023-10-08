using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Cinema
    {
        private Cinema cine;
        private List<Acteur> lesActeurs;
        private List<Film> lesFilms;

        public Cinema()
        {
            this.lesActeurs = new List<Acteur>();
            this.lesFilms = new List<Film>();
        }

        public static Cinema getInstance()
        {
            return new Cinema();
        }

        public Acteur getActeur(int idActeur)
        {
            foreach (Acteur unActeur in this.lesActeurs)
            {
                if(idActeur == unActeur.getId)
                {
                    return unActeur;
                }
            }
            return null;
        }

        public Film getFilm(int idFilm)
        {
            foreach (Film unFilm in this.lesFilms)
            {
                if (idFilm == unFilm.getIdFilm)
                {
                    return unFilm;
                }
            }
            return null;
        }

        public int nbActeur()
        {
            return this.lesActeurs.Count();
        }

        public void setFilm(int annee, string genre, int idFilm, string resume, string titre)
        {
            Film f = new Film(annee, genre, idFilm, resume, titre);
            this.lesFilms.Add(f);
        }

        public void setActeur(int anneeNaissance, int id, string nom, string prenom)
        {
            Acteur a = new Acteur(anneeNaissance, id, nom, prenom);
            this.lesActeurs.Add(a);
        }
    }
}
