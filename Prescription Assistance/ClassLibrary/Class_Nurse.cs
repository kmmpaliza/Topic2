﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class Class_Nurse
    {
        #region Connection String Setup
        DataSet ds = new DataSet();
        static string conString = ValidateConnection.ConString();
        private static SqlConnection conn = new SqlConnection(conString);
        #endregion
        #region Variables
        private string last_name, first_name, password, nurse_id;

        public string Nurse_id
        {
            get { return nurse_id; }
            set { nurse_id = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        #endregion

        public DataSet viewNurseDetails()
        {
            SqlCommand cmd = new SqlCommand("select_Nurse", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nurse_ID", SqlDbType.VarChar).Value = nurse_id;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "select_Nurse");
            return ds;
        }
    }
}
