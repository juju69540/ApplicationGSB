using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentification
{
    class Visiteur
    {
        private string nom;
        private string prenom;
        private string login;
        private string password;
        private string adresse;
        private string codePostal;
        private string ville;
        private DateTime dateEmbauche;

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }
        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }
        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }
        public string CodePostal
        {
            get
            {
                return codePostal;
            }

            set
            {
                codePostal = value;
            }
        }
        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }
        public DateTime DateEmbauche
        {
            get
            {
                return dateEmbauche;
            }

            set
            {
                dateEmbauche = value;
            }
        }
        public Visiteur(string nom, string prenom, string login, string password, string adresse, string codePostal, string ville, DateTime dateEmbauche)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Login = login;
            this.Password = password;
            this.Adresse = adresse;
            this.CodePostal = codePostal;
            this.Ville = ville;
            this.DateEmbauche = dateEmbauche;
        }


    }
}
