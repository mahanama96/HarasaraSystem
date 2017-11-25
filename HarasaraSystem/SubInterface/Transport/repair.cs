﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Transport
{
    public partial class repair : Form
    {

        public repair(String user)
        {
            InitializeComponent();
            fillcombo();
            timer1.Start();
            label7.Text = user;

        }
        MySqlConnection connnection = new MySqlConnection("server=localhost;user id=root;database=harasara");
        void update()
        { 
        
        //delete from table
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

                    String update = "UPDATE vehicles SET Availability = 'Yes' WHERE VehicleID = '" + this.textBox1.Text + "' ";
                    MySqlCommand command = new MySqlCommand(update, connnection);
                    MySqlCommand cmnd = new MySqlCommand(update, con);
                                      
                    MySqlDataReader myreader;
                    con.Open();
                    myreader = cmnd.ExecuteReader();
                    
        
        
        }
       
        
            void fillcombo()
        { 
        
         try
                {

              MySqlConnection connnection = new MySqlConnection("server=localhost;user id=root;database=harasara");
                    String insert = "SELECT * FROM vehicles ";
                    MySqlCommand command = new MySqlCommand(insert, connnection);
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                    MySqlCommand cmnd = new MySqlCommand(insert, con);
                    MySqlDataReader myreader;
                    con.Open();
                    myreader = cmnd.ExecuteReader();
                    
             while(myreader.Read())
             {
             
                String ID = myreader.GetString("vehicleID");
                //comboBox1.Items.Add(ID);

             
             }
                }

                catch (Exception ex)
                {



                    MessageBox.Show(ex.Message, "Error");




                }

            }

            
        private void bunifuThinButton4_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            driver d1 = new driver();
            d1.ShowDialog();
            this.Close();*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            vehicle v1 = new vehicle(label7.Text);
            v1.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            //search repairing vehicles

            try
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();

                String id;
                //String text;
                id = bunifuTextbox1.text;


                dt = db.ReadValue("Select * From vehiclerepair where '" + id + "' = vehicleID");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message, "Error");




            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuCustomTextbox5.Text))
            {
                String error = "Enter Estimation";
                label1.Text = error.ToString();
                
                // MessageBox.Show("Enter Estimation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox2.Text))
            {
                String error = "Enter Some notes for the repair";
                label2.Text = error.ToString();
                
                //MessageBox.Show("Enter Some notes for the repair.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {


                //adding to repair
                try
                {

                    MySqlConnection connnection = new MySqlConnection("server=localhost;user id=root;database=harasara");
                    String insert = "INSERT INTO vehiclerepair(VehicleID, SubmittedDate,Estimation, DueDate,Notes) VALUES ('" + this.textBox1.Text + "', '" + this.dateTimePicker1.Text.ToString() + "', '" + this.bunifuCustomTextbox5.Text + "', '" + this.dateTimePicker2.Text.ToString() + "', '" + this.bunifuCustomTextbox2.Text + "')";
                    String update = "UPDATE vehicles SET Availability = 'No' WHERE VehicleID = '"+this.textBox1.Text+"'";
                    MySqlCommand command = new MySqlCommand(insert, connnection);
                  //  MySqlCommand command2 = new MySqlCommand(update, connnection);
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                    MySqlCommand cmnd = new MySqlCommand(insert, con);
                   // MySqlCommand cmnd2 = new MySqlCommand(update, con);

                    MySqlDataReader myreader;
                    con.Open();
                    myreader = cmnd.ExecuteReader();
                   
                    //MessageBox.Show("Saved");
                    con.Close();

                    BMS_harasara.dbconnect conn = new BMS_harasara.dbconnect();
                    conn.ExQuery(update);
                    MessageBox.Show("Updated");

                }

                catch (Exception ex)
                {



                    MessageBox.Show(ex.Message, "Error");




                }

            }
        }

        private void bunifuThinButton7_Click(object sender, EventArgs e)
        {
            //clear
            bunifuCustomTextbox2.Clear();
            bunifuCustomTextbox5.Clear();
          
            
        }

        private void bunifuCustomTextbox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void repair_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton6_Click(object sender, EventArgs e)
        {
            MySqlConnection connnection = new MySqlConnection("server=localhost;user id=root;database=harasara");
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                   
                    String delete = "DELETE FROM vehiclerepair WHERE vehicleID = '" + this.textBox1.Text + "'";
                    String update = "UPDATE vehicles SET Availability = 'Yes' WHERE VehicleID = '" + this.textBox1.Text + "'";

                    /*MySqlCommand command = new MySqlCommand(delete, connnection);
                    MySqlCommand cmnd = new MySqlCommand(delete, con);
                   
                   
                    MySqlDataReader myreader;
                    con.Open();
                    myreader = cmnd.ExecuteReader();
                    update();*/
                    try
                    {
                        BMS_harasara.dbconnect conn = new BMS_harasara.dbconnect();
                        conn.ExQuery(delete);
                        conn.ExQuery(update);
                        MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Database error");
                    }
                }

                else
                {

                    MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK);



                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");


            }
        }

        private void bunifuThinButton10_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dbconnect db = new dbconnect();

            try
            {

                dt = db.ReadValue("Select * From vehiclerepair");
                dataGridView1.DataSource = dt;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void bunifuThinButton9_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(bunifuCustomTextbox5.Text))
            {
                String error = "Enter Estimation";
                label6.Text = error.ToString();
                //MessageBox.Show("Enter Driver Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox2.Text))
            {
                String error = "Enter Contact Number";
                label8.Text = error.ToString();
                //MessageBox.Show("Enter Contact Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
            else
            {

                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

                try
                {
                    //update table

                    String update = "UPDATE vehiclerepair SET SubmittedDate = '" + this.dateTimePicker1.Text + "', Estimation = '" + this.bunifuCustomTextbox5.Text + "', DueDate = '" + this.dateTimePicker2.Text + "', Notes ='" + this.bunifuCustomTextbox2.Text + "' WHERE vehicleID = '" + this.textBox1.Text + "'";
                    
                    MySqlCommand cmnd = new MySqlCommand(update, con);
                    MySqlDataReader myreader;
                    con.Open();
                    myreader = cmnd.ExecuteReader();
                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK);



                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error");


                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch))
            {

                e.Handled = true;

            }
        }

        private void bunifuThinButton3_Click(object sender, EventArgs e)
        {
            HarasaraSystem.MainMenu mm = new HarasaraSystem.MainMenu();
            this.Hide();
            mm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > -1)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                bunifuCustomTextbox5.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                bunifuCustomTextbox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                
            }
        }
    }
}
