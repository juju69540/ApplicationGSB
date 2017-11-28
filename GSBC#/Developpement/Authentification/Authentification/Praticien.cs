using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentification
{
    class Praticien
    {
        string nom;
        string social;
        string adresse;
        string tel;
        string contact;
        float coefnoto;
        float coef_confiance;

        public Praticien(string nom, string social, string adresse, string tel, string contact, float coefnoto, float coef_confiance)
        {
            this.nom = nom;
            this.social = social;
            this.adresse = adresse;
            this.tel = tel;
            this.contact = contact;
            this.coefnoto = coefnoto;
            this.coef_confiance = coef_confiance;
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
    }
}
