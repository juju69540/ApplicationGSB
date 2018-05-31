using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Authentification
{
    class DAOPraticien
    {
        public static List<Praticien> getAllPraticien()
        {
            List<Praticien> praticien = new List<Praticien>();
            Dictionary<string, string> specialites = DAOPraticien.getAllSpecialite();
            Praticien unPraticien;
            string req = "Select * from Praticiens;";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                while (result.Read())
                {
                    unPraticien = new Praticien(result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), result[5].ToString(), result[6].ToString(), result[7].ToString(), /*float.Parse(result[6].ToString()), float.Parse(result[7].ToString())*/ result[8].ToString());
                    foreach (KeyValuePair<string, string> entry in specialites)
                    {
                        if (entry.Key == unPraticien.Specialite)
                        {
                            unPraticien.Specialite = entry.Value;
                        }
                    }
                    praticien.Add(unPraticien);
                }
                return praticien;

            }
            catch (Exception exPrat)
            {
                throw exPrat;
            }
            finally
            {
                connectBDD.deconnexion();
            }
        }

        public static List<Praticien> getUnPraticien(string unNom)
        {
            List<Praticien> CesPraticiens = new List<Praticien>();
            Dictionary<string, string> specialites = DAOPraticien.getAllSpecialite();
            Praticien unPraticien;
            string req = "SELECT * FROM Praticiens WHERE nom LIKE '" + unNom + "%';";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                while (result.Read())
                {
                    unPraticien = new Praticien(result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), result[5].ToString(), result[6].ToString(), result[7].ToString(), /*float.Parse(result[6].ToString()), float.Parse(result[7].ToString()),*/ result[8].ToString());
                    foreach (KeyValuePair<string, string> entry in specialites)
                    {
                        if (entry.Key == unPraticien.Specialite)
                        {
                            unPraticien.Specialite = entry.Value;
                        }
                    }
                    CesPraticiens.Add(unPraticien);
                }
                return CesPraticiens;
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

        public static Dictionary<string, string> getAllSpecialite()
        {
            Dictionary<string, string> specialite = new Dictionary<string, string>();
            string req = "Select * from Specialite;";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                while (result.Read())
                {
                    specialite.Add(result[0].ToString(), result[1].ToString());
                }
                connectBDD.deconnexion();
                return specialite;
            }
            catch (Exception exSpe)
            {
                throw exSpe;
            }
            finally
            {
                connectBDD.deconnexion();
            }
        }

        public static Boolean getExistPraticiens(string unNom, string uneAdresse)
        {
            string req = "SELECT * FROM Praticiens WHERE nom='" + unNom + "' AND adresse='" + uneAdresse + "';";
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
            catch (Exception exPrat)
            {
                throw exPrat;
            }
            finally
            {
                connectBDD.deconnexion();
            }
        }

        public static string getIdentifiantPraticien(string unNom)
        {
            string req = "SELECT idPraticien FROM Praticiens WHERE nom='" + unNom + "';";
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
            catch (Exception exPrat)
            {
                throw exPrat;
            }
            finally
            {
                connectBDD.deconnexion();
            }
        }

        #region button_form_action_sql

        public static Boolean AddPraticiens(string unNom, string unSocial, string uneAdresse, string unTelephone, string unContact, string unCoefNoto, string unCoefConfiance, string specialite)
        {
            Dictionary<string, string> specialites = DAOPraticien.getAllSpecialite();
            int laspecialite = 0;
            if (getExistPraticiens(unNom,uneAdresse))
            {
                foreach (KeyValuePair<string, string> entry in specialites)
                {
                    if (specialite == entry.Value)
                    {
                        laspecialite = Convert.ToInt32(entry.Key);
                    }
                }
                string req = "INSERT INTO Praticiens (nom, social, adresse, telephone, contact, coeffnoto, coeffconfiance, idSpecialite) VALUES ('" + unNom + "','" + unSocial + "','" + uneAdresse + "','" + unTelephone + "','" + unContact + "','" + unCoefNoto + "','" + unCoefConfiance + "','" + laspecialite + "')";
                DAOFactory connectBDD = new DAOFactory();
                connectBDD.connexion();
                try
                {
                    connectBDD.execSQLWrite(req);
                }
                catch (Exception exPrat)
                {
                    throw exPrat;
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

        public static void UpdatePraticiens(string unId, string unNomP, string unSocial, string uneAdresse, string unTelephone, string unContact, string unCoefNoto, string unCoefConfiance, string specialite)
        {
            int id = int.Parse(unId);
            Dictionary<string, string> specialites = DAOPraticien.getAllSpecialite();
            int laspecialite = 0;
            foreach (KeyValuePair<string, string> entry in specialites)
            {
                if (specialite == entry.Value)
                {
                    laspecialite = Convert.ToInt32(entry.Key);
                }
            }
            string req = "UPDATE Praticiens SET nom='" + unNomP + "', social='" + unSocial + "', adresse='" + uneAdresse + "', telephone='" + unTelephone + "', contact='" + unContact + "', coeffnoto='" + unCoefNoto + "', coeffconfiance='" +unCoefConfiance+ "', idSpecialite='" +laspecialite+ "' WHERE idPraticien='" + id + "';";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            try
            {
                connectBDD.execSQLRead(req);
            }
            catch (Exception exPrat)
            {
                throw exPrat;
            }
            finally
            {
                connectBDD.deconnexion();
            }
        }

        public static void DeletePraticiens(string unId)
        {
            string req = "DELETE FROM Praticiens WHERE idPraticien='" +unId+ "';";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            try
            {
                connectBDD.execSQLWrite(req);
            }
            catch (Exception exPrat)
            {
                throw exPrat;
            }
            finally
            {
                connectBDD.deconnexion();
            }
        }

        #endregion
    }
}