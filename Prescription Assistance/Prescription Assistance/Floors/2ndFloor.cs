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
    public partial class _2ndFloorPrivateRoomD : UserControl
    {
        Class_Rooms cr = new Class_Rooms();
        DataSet ds = new DataSet();
        
        int bed;

        public _2ndFloorPrivateRoomD()
        {
            InitializeComponent();            
        }

        public void refresh()
        {
            if (Form1.usertype.Equals("Doctor"))
            {
                for (int x = 105; x <= 112; x++)
                {
                    this.Controls.Find("pbox" + x, true)[0].Click -= pBox_Click;
                    bed = x;
                }
            }
            else
            {
                for (int x = 105; x <= 112; x++)
                {
                    this.Controls.Find("pbox" + x, true)[0].Click += pBox_Click;
                    bed = x;
                }
            }

            for (int x = 105; x <= 112; x++)
            {
                this.Controls.Find("pbox" + x, true)[0].MouseHover += pBox_Hover;
                this.Controls.Find("pbox" + x, true)[0].MouseLeave += pBox_Leave;
                bed = x;
            }
        }

        public void _2ndFloorPrivateRoom_Load(object sender, EventArgs e)
        {          
            refresh();              
        }

        private void showDialog(string bed)
        {
            AssignRoomPatient ar = new AssignRoomPatient(bed, this, new _3rdFloor(), new _4thFloor(), new _5thFloor(), new View_Rooms());
            ar.ShowDialog();
        }

        private void pBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedpBox = sender as PictureBox;

            for (int x = 105; x <= 112; x++)
            {
                string pbox = "pbox" + x;
                if (clickedpBox.Name == pbox)
                {
                    ds = cr.viewAllBeds();    
                    showDialog(ds.Tables[0].Rows[x][0].ToString());
                }
            }            
        }

        private void pBox_Hover(object sender, EventArgs e)
        {
            PictureBox clickedpBox = sender as PictureBox;

            for (int x = 105; x <= 112; x++)
            {
                string pbox = "pbox" + x;
                if (clickedpBox.Name == pbox)
                {
                    panel1.Visible = true;

                    DataSet ds2 = new DataSet();
                    ds = cr.viewAllBeds();
                    cr.Bed_id = ds.Tables[0].Rows[x][0].ToString();
                    ds2 = cr.viewBedandPatient();
                    label3.Text = cr.Bed_id.ToString();

                    if (ds2.Tables[1].Rows[0][2].ToString() == "Occupied")
                    {
                        label2.Text = ds2.Tables[1].Rows[0][3].ToString();
                    }
                    else
                    {
                        label2.Text = "No Patient";
                    }
                }
            }           
        }

        private void pBox_Leave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
