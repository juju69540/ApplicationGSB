using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Authentification
{
    class DAOAuthentification
    {
        /// <summary>
        /// Vérifie les identifiants et renvoie un nombre si les deux identifiants ont été trouvés dans la BDD et concordent:
        /// 0: Connexion réussie
        /// 1: Le Login n'a pas été trouvé dans la BDD, ou la connexion avec la BDD a échoué.
        /// 2: Le Mot de passe n'a pas été trouvé ou ne correspond pas.
        /// 3: Erreur qui n'est pas sensé apparaitre
        /// </summary>
        /// <param name="loginToSearch"></param>
        /// <returns></returns>
        /// 
        public static int logToGSB(string loginToSearch, string password)
        {
            string req = "Select * From dbo.connexion Where login Like '" + loginToSearch + "';";
            string logBDD;
            string passwordBDD;
            int logCorrect = 1;
            DAOFactory connectBDD = new DAOFactory();
            connectBDD.connexion();
            SqlDataReader result;
            result = connectBDD.execSQLRead(req);
            if (result != null)
            {
                if (result.Read())
                {
                    logBDD = result[0].ToString();
                    passwordBDD = result[1].ToString();
                    if (password.ToLower() == passwordBDD.ToLower())
                    {
                        logCorrect = 0;
                    }
                    else
                    {
                        logCorrect = 2;
                    }
                }
            }

            connectBDD.deconnexion();

            return logCorrect;
        }

    }
}
