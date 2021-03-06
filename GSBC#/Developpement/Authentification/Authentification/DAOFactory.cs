﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Authentification
{
    
    class DAOFactory
    {
        private SqlConnection myco;
        private SqlDataAdapter myadapt;
        private SqlCommand mycmd;
        private SqlDataReader dtreader;

        //Modifier ce string pour utiliser une autre BDD
        private string server = "Data Source='172.17.21.10';Initial Catalog=SIO2_GSB_TeamB;User ID=SIO2-dev;Password=btssio-slam-2018";

        public DAOFactory() { }

        public void connexion()
        {
            try
            {
                myco = new SqlConnection(server);
                myco.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void deconnexion()
        {
            try
            {
                myco.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ATTENTION: Peut retourner une valeur null en cas de problème lors de la récupération de données (un message d'erreur apparaitra alors)
        /// </summary>
        /// <param name="req">Requête SQL de type select</param>
        /// <returns></returns>
        public SqlDataReader execSQLRead(string req)
        {
            try
            {
                mycmd = new SqlCommand();
                mycmd.CommandText = req;
                mycmd.Connection = myco;
                myadapt = new SqlDataAdapter();
                myadapt.SelectCommand = mycmd;
                dtreader = mycmd.ExecuteReader();
                return dtreader;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void execSQLWrite(string req)
        {
            try
            {
                mycmd = new SqlCommand();
                mycmd.CommandText = req;
                mycmd.Connection = myco;
                mycmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
