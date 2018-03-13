using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentification
{
    class Praticien
    {
        private string nom;
        private string social;
        private string adresse;
        private string tel;
        private string contact;
        private float coefnoto;
        private float coef_confiance;
        private string specialite;

        public Praticien(string nom, string social, string adresse, string tel, string contact, float coefnoto, float coef_confiance, string specialite)
        {
            this.nom = nom;
            this.social = social;
            this.adresse = adresse;
            this.tel = tel;
            this.contact = contact;
            this.coefnoto = coefnoto;
            this.coef_confiance = coef_confiance;
            this.Specialite = specialite;
        }

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

        public string Social
        {
            get
            {
                return social;
            }

            set
            {
                social = value;
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

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }

        public string Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public float Coefnoto
        {
            get
            {
                return coefnoto;
            }

            set
            {
                coefnoto = value;
            }
        }

        public float Coef_confiance
        {
            get
            {
                return coef_confiance;
            }

            set
            {
                coef_confiance = value;
            }
        }

        public string Specialite
        {
            get
            {
                return specialite;
            }

            set
            {
                specialite = value;
            }
        }
    }
}
