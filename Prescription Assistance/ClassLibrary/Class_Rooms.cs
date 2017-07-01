﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class Class_Rooms
    {
        #region Connection String Setup
        DataSet ds = new DataSet();
        static string conString = ValidateConnection.ConString();
        private static SqlConnection conn = new SqlConnection(conString);
        #endregion
        #region Variables
        private string bed_id, patient_id, status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Patient_id
        {
            get { return patient_id; }
            set { patient_id = value; }
        }

        public string Bed_id
        {
            get { return bed_id; }
            set { bed_id = value; }
        }

        #endregion

        public DataSet viewAllBeds()
        {
            SqlCommand cmd = new SqlCommand("select_Room", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "select_Room");
            return ds;
        }

        public DataSet viewBedDetails()
        {
            SqlCommand cmd = new SqlCommand("select_RoomDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Bed_ID", SqlDbType.VarChar).Value = bed_id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "select_RoomDetails");
            return ds;
        }

        public DataSet viewBedandPatient()
        {
            SqlCommand cmd = new SqlCommand("select_RoomandPatient", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Bed_ID", SqlDbType.VarChar).Value = bed_id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "select_RoomDetails");
            return ds;
        }
    }
}
