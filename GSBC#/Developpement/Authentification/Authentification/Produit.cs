using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentification
{
    class Produit
    {
        private string nom;
        private string famille;
        private string desc;
        private int dose;
        private string effetThera;
        private string contreIndic;
        private int prixHT;

        public Produit()
        { }

        public Produit(string nom, string famille, string desc, int dose, string effetThera, string contreIndic, int prixHT)
        {
            this.Nom = nom;
            this.famille = famille;
            this.Desc = desc;
            this.Dose = dose;
            this.EffetThera = effetThera;
            this.ContreIndic = contreIndic;
            this.PrixHT = prixHT;
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

        public string Famille
        {
            get
            {
                return famille;
            }

            set
            {
                famille = value;
            }
        }

        public string Desc
        {
            get
            {
                return desc;
            }

            set
            {
                desc = value;
            }
        }

        public int Dose
        {
            get
            {
                return dose;
            }

            set
            {
                dose = value;
            }
        }

        public string EffetThera
        {
            get
            {
                return effetThera;
            }

            set
            {
                effetThera = value;
            }
        }

        public string ContreIndic
        {
            get
            {
                return contreIndic;
            }

            set
            {
                contreIndic = value;
            }
        }

        public int PrixHT
        {
            get
            {
                return prixHT;
            }

            set
            {
                prixHT = value;
            }
        }

        




    }
}
