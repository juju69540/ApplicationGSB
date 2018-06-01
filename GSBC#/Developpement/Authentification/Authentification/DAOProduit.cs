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
        public static List<Produit> getAllProduits()
        {
            List<Produit> meds = new List<Produit>();
            Dictionary<string, string> families = DAOProduit.getAllFamilies();
            Produit med;
            string req = "Select * from Produits;";
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            try
            {
                result = connectBDD.execSQLRead(req);
                while (result.Read())
                {
                    if (string.IsNullOrEmpty(result[8].ToString()))
                    {
                        med = new Produit(result[0].ToString(), result[1].ToString(), result[7].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), result[5].ToString(), Int32.Parse(result[6].ToString()), Int32.Parse(result[9].ToString()));
                        foreach (KeyValuePair<string, string> entry in families)
                        {
                            if (entry.Key == med.Famille)
                            {
                                med.Famille = entry.Value;
                            }
                        }
                        meds.Add(med);
                    }
                }
                return meds;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connectBDD.deconnexion();
            }
        }

        public static Dictionary<string, string> getAllFamilies()
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
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                connectBDD.deconnexion();
            }
        }


        public static void ajouterProduit(string nom, string desc, string dose, string effetThera, string contrIndic, string prixHT, string prixEchant, string famille)
        {
            try
            {
                string req = "insert into dbo.Produits(nomCommercial, description, dosage, effetThera, contreIndic, PrixHT, idFamille, PrixEchantillon) values('" + nom + "', '" + desc + "', " + dose + ", '" + effetThera + "', '" + contrIndic + "', " + prixHT + ", " + famille + ", " + prixEchant + ");";
                DAOFactory addToDb = new DAOFactory();
                addToDb.connexion();
                addToDb.execSQLWrite(req);
                addToDb.deconnexion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void modifProduit(string id, string nom, string desc, string dose, string effetThera, string contrIndic, string prixHT, string prixEchant, string famille)
        {
            try
            {
                string req = "UPDATE dbo.Produits SET nomCommercial = '" + nom + "' , description = '" + desc + "' , dosage = '" + dose + "' , effetThera = '" + effetThera + "' , contreIndic = '" + contrIndic + "' , PrixHT ='" + prixHT + "' , idFamille = '" + famille + "' , PrixEchantillon = '" + prixEchant + "' WHERE idProduit ='" + id + "';";
                DAOFactory updDb = new DAOFactory();
                updDb.connexion();
                updDb.execSQLWrite(req);
                updDb.deconnexion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void supprProduit(string id)
        {
            try
            {
                string req = "UPDATE dbo.Produits SET dateSuppresion = GETDATE() WHERE idProduit = '"+id+"';";
                DAOFactory updDb = new DAOFactory();
                updDb.connexion();
                updDb.execSQLWrite(req);
                updDb.deconnexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
