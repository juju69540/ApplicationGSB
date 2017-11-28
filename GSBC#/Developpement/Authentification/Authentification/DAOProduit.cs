using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Authentification
{
    class DAOProduit
    {

        //public static List<Produit> getAllProduits()
        //{
        //    List<Produit> meds = new List<Produit>();
        //    Dictionary<string, string> families = DAOProduit.getAllFamilies();
        //    Produit med;
        //    string req = "Select * from Produits;";
        //    DAOFactory connectBDD = new DAOFactory();
        //    connectBDD.connexion();
        //    SqlDataReader result;
        //    result = connectBDD.execSQLRead(req);
        //    while(result.Read())
        //    {
        //        med = new Produit(result[1].ToString(), result[2].ToString(), Int32.Parse(result[3].ToString()), result[4].ToString(), result[5].ToString(), Int32.Parse(result[6].ToString()));
<<<<<<< HEAD
        //        med.Famille = families[Int32.Parse(result)]
=======
        //        med.Famille = families[Int32.Parse(result)];
>>>>>>> devPIOT
        //    }

        //    connectBDD.deconnexion();
        //}

        public static Dictionary<string, string> getAllFamilies()
        {
            Dictionary<string, string> families = new Dictionary<string, string>();
            string req = "Select * from Famille;";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            result = connectBDD.execSQLRead(req);
            while (result.Read())
            {
                families.Add(result[0].ToString(), result[1].ToString());
            }
            connectBDD.deconnexion();
            return families;
        }
    }
}
