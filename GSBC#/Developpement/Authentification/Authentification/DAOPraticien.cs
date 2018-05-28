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
                    unPraticien = new Praticien(result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), result[5].ToString(), float.Parse(result[6].ToString()), float.Parse(result[7].ToString()), result[8].ToString());
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
                    unPraticien = new Praticien(result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), result[5].ToString(), float.Parse(result[6].ToString()), float.Parse(result[7].ToString()), result[8].ToString());
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

        public static Boolean getExistPraticiens(string unLogin)
        {
            string req = "SELECT * FROM Praticiens WHERE login='" + unLogin + "';";
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
    }
}
