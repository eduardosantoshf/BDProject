﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//HAVE ACCESS TO SQL DB
using System.Data.SqlClient;

namespace ProjetoBD
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;
        private int currentRecibo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
            cn = getBDConnection(); //gets the connection to the DB
            loadRecibos(sender, e); //loads all Recibos from DB and opens the connection
        }

        private SqlConnection getBDConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-B6II5UN;Initial Catalog=ProjetoBD;Integrated Security=True");
            //return new SqlConnection("data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101N;initial catalog=p2g1;User id=p2g1;Password=Diogoedu232.");
        }
        private bool verifyBDConnection()
        {   //used to connect to the DB
            if (cn == null)
                cn = getBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void loadRecibos(object sender, EventArgs e)
        {   //loads all Recibos from the DB
            if (!verifyBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cafes.Recibo", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBoxRecibos.Items.Clear();

            while (reader.Read())
            {
                Recibo R = new Recibo();
                R.reciboID = reader["reciboID"].ToString();
                listBoxRecibos.Items.Add(R);
            }
            cn.Close();

            currentRecibo = 0;
            ShowRecibo();
        }
        public void ShowRecibo()
        {   //shows information of Recibo
            if (listBoxRecibos.Items.Count == 0 | currentRecibo < 0)
                return;
            Recibo recibo = new Recibo();
            recibo = (Recibo)listBoxRecibos.Items[currentRecibo];
            
            /*txtID.Text = contact.CustomerID;
            txtCompany.Text = contact.CompanyName;
            txtContact.Text = contact.ContactName;
            txtAddress1.Text = contact.Address1;
            txtCity.Text = contact.City;
            txtState.Text = contact.State;
            txtZIP.Text = contact.ZIP;
            txtCountry.Text = contact.Country;
            txtTel.Text = contact.tel;
            txtFax.Text = contact.FAX;*/       //used to show the information of the Recibo in the corresponding boxes
        }

        private void CafeBar_Click(object sender, EventArgs e)
        {
            panelBar.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBar.SelectedItem.ToString().Equals("Geral")){
                comboBoxBarBebidas.Visible = false;
                labelBebidas.Visible = false;
                comboBoxBarGeral.Visible = true;
                labelBarGeral.Visible = true;
            }
            if (comboBoxBar.SelectedItem.ToString().Equals("Bebidas"))
            {
                comboBoxBarGeral.Visible = false;
                labelBarGeral.Visible = false;
                comboBoxBarBebidas.Visible = true;
                labelBebidas.Visible = true;
            }
        }

        private void CafePastelaria_Click(object sender, EventArgs e)
        {
            panelPastelaria.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPastelaria.SelectedItem.ToString().Equals("Geral"))
            {
                comboBoxPasteis.Visible = false;
                labelPastelariaPasteis.Visible = false;
                comboBoxPastelariaGeral.Visible = true;
                labelPastelariaGeral.Visible = true;
            }
            if (comboBoxPastelaria.SelectedItem.ToString().Equals("Pasteis"))
            {
                comboBoxPastelariaGeral.Visible = false;
                labelPastelariaGeral.Visible = false;
                comboBoxPasteis.Visible = true;
                labelPastelariaPasteis.Visible = true;
            }
        }

        private void CafeRestaurante_Click(object sender, EventArgs e)
        {
            panelRestaurante.Visible = true;
        }

        private void comboBoxRestaurante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRestaurante.SelectedItem.ToString().Equals("Geral"))
            {
                comboBoxAlmocos.Visible = false;
                labelRestauranteAlmocos.Visible = false;
                comboBoxRestauranteGeral.Visible = true;
                labelRestauranteGeral.Visible = true;
            }
            if (comboBoxRestaurante.SelectedItem.ToString().Equals("Almocos"))
            {
                comboBoxRestauranteGeral.Visible = false;
                labelRestauranteGeral.Visible = false;
                comboBoxAlmocos.Visible = true;
                labelRestauranteAlmocos.Visible = true;
            }
        }

        private void ButtonBarClose_Click(object sender, EventArgs e)
        {
            panelBar.Visible = false;
        }

        private void buttonRestauranteClose_Click(object sender, EventArgs e)
        {
            panelRestaurante.Visible = false;
        }

        private void buttonPastelariaClose_Click(object sender, EventArgs e)
        {
            panelPastelaria.Visible = false;
        }
    }
}
