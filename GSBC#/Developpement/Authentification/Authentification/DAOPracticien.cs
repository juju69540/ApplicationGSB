using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentification
{
    class DAOPracticien
    {
        public static List<Practicien> getAllPracticien()
        {
            List<Practicien> meds = new List<Practicien>();
            Dictionary<string, string> pracs = DAOPracticien.getAllFPracs();
            Practicien prac;
            string req = "Select * from Practicien;";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                while (result.Read())
                {
                    prac = new Produit(result[1].ToString(), result[7].ToString(), result[2].ToString(), Int32.Parse(result[3].ToString()), result[4].ToString(), result[5].ToString(), Int32.Parse(result[6].ToString()));
                    foreach (KeyValuePair<string, string> entry in families)
                    {
                        if (entry.Key == prac.Famille)
                        {
                            prac.Famille = entry.Value;
                        }
                    }
                }
                return pracs;

            }
            catch (Exception exPrac)
            {
                throw exPrac;
            }
            finally
            {
                connectBDD.deconnexion();
            }
        }

        public static Dictionary<string, string> getAllPracs()
        {
            Dictionary<string, string> families = new Dictionary<string, string>();
            string req = "Select * from Famille;";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                while (result.Read())
                {
                    families.Add(result[0].ToString(), result[1].ToString());
                }
                connectBDD.deconnexion();
                return families;
            }
            catch (Exception exFam)
            {
                throw exFam;
            }
            finally
            {
                connectBDD.deconnexion();
            }
        }
    }
}
