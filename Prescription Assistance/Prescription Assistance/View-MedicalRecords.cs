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
    public partial class View_MedicalRecords : UserControl
    {
        Class_MedRec cm = new Class_MedRec();
        Class_Patient cp = new Class_Patient();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();

        public View_MedicalRecords()
        {
            InitializeComponent();
        }
        
        private void displayRecords(string text)
        {
            dataGridView1.DataSource = null;
            cm.Patient_id = text;
            
            Class_Patient cp2 = new Class_Patient();
            cp2.Patient_id = text;

            ds = cm.viewMedRecDetails();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds3 = cp2.viewPatientDetails();
                string name = ds3.Tables[0].Rows[0][3].ToString() + " " + ds3.Tables[0].Rows[0][2].ToString();
                lblText.Text = "Displaying Medical Records of " + cp2.Patient_id.ToString() + ", " + name;

                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;

                lblCounter.Visible = true;
                int count = ds.Tables[0].Rows.Count;
                lblCounter.Text = "" + count + " result/s";
            }
            else 
            {
                lblText.Text = @"No Medical Records for '" + text + @"'";
                lblCounter.Text = "0 result/s"; 
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                lblText.Text = "Search field is required.";
            }
            else 
            {
                cp.Patient_id = txtSearch.Text;
                cp.Last_name = txtSearch.Text;
                cp.First_name = txtSearch.Text;
                cp.Age = txtSearch.Text;
                cp.Contact = txtSearch.Text;
                cp.Gender = txtSearch.Text;

                ds2 = cp.searchPatient();
                int count = ds2.Tables[0].Rows.Count;

                if (count == 1)
                {
                    displayRecords(ds2.Tables[0].Rows[0][0].ToString());
                }
                else if (count > 1)
                {
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds2.Tables[0];
                    dataGridView1.Columns[0].Visible = true;
                    int counter = ds2.Tables[0].Rows.Count;
                    lblCounter.Visible = true;
                    lblCounter.Text = "" + counter + " result/s";
                    lblText.Text = @"Search results for '" + txtSearch.Text + @"'";
                }
                else
                {
                    dataGridView1.DataSource = null;
                    lblText.Text = @"No results for '" + txtSearch.Text + @"'";
                    lblCounter.Visible = false;
                }
            }                        
        }

        private void View_MedicalRecords_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
            lblCounter.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {                
                displayRecords(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            }
        }
    }
}
