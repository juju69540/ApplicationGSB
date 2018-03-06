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
            List<Praticien> prati = new List<Praticien>();
            Dictionary<string, string> specialites = DAOPraticien.getAllSpecialite();
            Praticien prat;
            string req = "Select * from Praticiens;";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                while (result.Read())
                {
                    prat = new Praticien(result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), result[5].ToString(), float.Parse(result[6].ToString()), float.Parse(result[7].ToString()), result[8].ToString());
                    foreach (KeyValuePair<string, string> entry in specialites)
                    {
                        if (entry.Key == prat.Specialite)
                        {
                            prat.Specialite = entry.Value;
                        }
                    }
                }
                return prati;

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
    }
}
