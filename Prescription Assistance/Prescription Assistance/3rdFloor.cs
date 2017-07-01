﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;

namespace Prescription_Assistance
{
    public partial class _3rdFloor : UserControl
    {
        Class_Rooms cr = new Class_Rooms();
        DataSet ds = new DataSet();

        public _3rdFloor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "300-A";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "300-B";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "300-C";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "300-D";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "300-E";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "300-F";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "300-G";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "300-H";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "301";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "302";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "303";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cr.Bed_id = "304";
            ds = cr.viewBedandPatient();
            MessageBox.Show("Bed: " + ds.Tables[0].Rows[0][1].ToString() + "\nRoom Type: " + ds.Tables[0].Rows[0]["Room"].ToString() + "\nStatus: " + ds.Tables[0].Rows[0]["Status"].ToString() + "\nPatient: " +
                    ds.Tables[0].Rows[0][3].ToString() + "");
        }
    }
}
