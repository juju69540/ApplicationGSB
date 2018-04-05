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
                    unVisiteur = new Visiteur(result[0].ToString(), result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), result[5].ToString(), result[6].ToString(), result[7].ToString(), result[8].ToString(), result[9].ToString());
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
        public static Boolean getExistVisiteurs(string unLogin)
        {
            string req = "SELECT * FROM Visiteurs WHERE login='"+unLogin+"';";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                if (result.Read())
                {
                    return false;  
                }
                else
                {
                    return true;
                }
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
        public static string getIdentifiant(string unLogin, string unMdp)
        {
            string req = "SELECT idVisiteur FROM Visiteurs WHERE login='"+unLogin+"' AND mdp='"+unMdp+"';";
            string id;
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                if (result.Read())
                {
                    id = result[0].ToString();
                }
                else
                {
                    id = null;
                }
                return id;
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
        public static Boolean AddVisiteurs(string unNom, string unPrenom, string unLogin, string unMdp, string uneAdresse, string unCodeP, string uneVille, DateTime uneDate, string uneZoneGeo)
        {
            Dictionary<string, string> lesZoneGeo = DAOVisiteur.getAllZones();
            int laZoneGeo = 0;
            if (getExistVisiteurs(unLogin))
            {
                foreach (KeyValuePair<string, string> entry in lesZoneGeo)
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
                    connectBDD.execSQLWrite(req);
                }
                catch (Exception exVis)
                {
                    throw exVis;
                }
                finally
                {
                    connectBDD.deconnexion();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void DeleteVisiteurs(string unId)
        {
            string req = "UPDATE Visiteurs SET dateSupp = GETDATE() WHERE idVisiteur='"+unId+"';";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            try
            {
                connectBDD.execSQLWrite(req);
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
        public static void UpdateVisiteur(string unId, string unNom, string unPrenom, string uneAdresse, string unCP, string uneVille, DateTime uneDateEmb, string uneZoneGeo)
        {
            int id = int.Parse(unId);
            Dictionary<string, string> lesZoneGeo = DAOVisiteur.getAllZones();
            int laZoneGeo = 0;
            foreach (KeyValuePair<string, string> entry in lesZoneGeo)
                {
                    if (uneZoneGeo == entry.Value)
                    {
                        laZoneGeo = Convert.ToInt32(entry.Key);
                    }
                }
            string req = "UPDATE Visiteurs SET nom='"+unNom+"', prenom='"+unPrenom+"', adresse='"+uneAdresse+"', cp='"+unCP+"', ville='"+uneVille+"', dateEmbauche='"+uneDateEmb+"', idGeo='"+laZoneGeo+"' WHERE idVisiteur='"+id+"';";
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
