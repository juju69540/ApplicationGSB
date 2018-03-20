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
            Dictionary<string, string> lesZoneGeo = DAOVisiteur.getAllZones();
            Visiteur unVisiteur;
            string req = "SELECT * FROM Visiteurs WHERE dateSupp = '0001-01-01';";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                while (result.Read())
                {
                    unVisiteur = new Visiteur(result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), result[5].ToString(), result[6].ToString(), result[7].ToString(), result[8].ToString(), result[9].ToString());
                    foreach (KeyValuePair<string, string> entry in lesZoneGeo)
                    {
                        if (entry.Key == unVisiteur.ZoneGeo)
                        {
                            unVisiteur.ZoneGeo = entry.Value;
                        }
                    }
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

        public static Dictionary<string, string> getAllZones()
        {
            Dictionary<string, string> zones = new Dictionary<string, string>();
            string req = "SELECT * FROM SecteurGeo;";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                while (result.Read())
                {
                    zones.Add(result[0].ToString(), result[1].ToString());
                }
                connectBDD.deconnexion();
                return zones;
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

        public static void AddVisiteurs(string unNom, string unPrenom, string unLogin, string unMdp, string uneAdresse, string unCodeP, string uneVille, DateTime uneDate, string uneZoneGeo)
        {
            Dictionary<string, string> lesZoneGeo = DAOVisiteur.getAllZones();
            int laZoneGeo = 0;
            foreach (KeyValuePair <string, string> entry in lesZoneGeo )
            {
                if (uneZoneGeo == entry.Value)
                {
                    laZoneGeo = Convert.ToInt32(entry.Key);
                }
            }
            string req = "INSERT INTO Visiteurs (nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche, idGeo) VALUES ('" + unNom + "','" + unPrenom + "','" + unLogin + "','" + unMdp + "','" + uneAdresse + "','" + unCodeP + "','" + uneVille + "','" + uneDate + "','" + laZoneGeo + "')";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            try
            {
                connectBDD.execSQLRead(req);
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
        public static void DeleteVisiteurs(string unNom)
        {
            string req = "UPDATE Visiteurs SET dateSupp = GETDATE() WHERE nom='"+unNom+"';";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            try
            {
                connectBDD.execSQLRead(req);
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
