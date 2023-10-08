using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Acteur
    {
        private int anneeNaissance;
        private int id;
        private string nom;
        private string prenom;

        public Acteur(int anneeNaissance, int id, string nom, string prenom)
        {
            this.anneeNaissance = anneeNaissance;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        public static Acteur getInstance(int anneeNaissance, int id, string nom, string prenom)
        {
            return new Acteur(anneeNaissance, id, nom, prenom);
        }

        public int getAnneeNaissance
        {
            get { return this.anneeNaissance; }
            set { this.anneeNaissance = value; }
        }
        public int getId
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string getNom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public string getPrenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public override string ToString()
        {
            return $"Nom : {this.nom}, Prénom : {this.prenom}, Année de Naissance : {this.anneeNaissance}";
        }
    }
}
