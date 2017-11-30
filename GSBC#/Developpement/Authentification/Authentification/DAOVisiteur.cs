using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Authentification
{
    class DAOVisiteur
    {
         public static List<Visiteur> getAllVisiteurs()
        {
            List<Visiteur> lesVisiteurs = new List<Visiteur>();
            Visiteur unVisiteur;
            string req = "Select * from Visiteur v INNER JOIN SecteurGeo sg on v.idGeo=sg.idGeo;";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                while (result.Read())
                {
                    unVisiteur = new Visiteur(result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), result[5].ToString(), result[6].ToString(), result[7].ToString(), result[8].ToString(), result[9].ToString());
                    lesVisiteurs.Add(unVisiteur);
                }
                
                return lesVisiteurs;

            }
            catch (Exception exVis)
            {
                throw exVis;
            }
            finally
            {
                connectBDD.deconnexion();
            }
        }
    }
}
