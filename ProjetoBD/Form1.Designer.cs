﻿namespace ProjetoBD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPastelariaPasteis = new System.Windows.Forms.Label();
            this.comboBoxPasteis = new System.Windows.Forms.ComboBox();
            this.labelPastelaria = new System.Windows.Forms.Label();
            this.comboBoxPastelaria = new System.Windows.Forms.ComboBox();
            this.labelPastelariaGeral = new System.Windows.Forms.Label();
            this.comboBoxPastelariaGeral = new System.Windows.Forms.ComboBox();
            this.listBoxRecibos = new System.Windows.Forms.ListBox();
            this.comboBoxAlmocos = new System.Windows.Forms.ComboBox();
            this.comboBoxBebidas = new System.Windows.Forms.ComboBox();
            this.comboBoxCafes = new System.Windows.Forms.ComboBox();
            this.labelCafe = new System.Windows.Forms.Label();
            this.labelAlmocos = new System.Windows.Forms.Label();
            this.labelBebidas = new System.Windows.Forms.Label();
            this.comboBoxBar = new System.Windows.Forms.ComboBox();
            this.comboBoxRestaurante = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(107, 290);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 24);
            this.comboBox2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente(NIF)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Empregado(NIF)";
            // 
            // labelPastelariaPasteis
            // 
            this.labelPastelariaPasteis.AutoSize = true;
            this.labelPastelariaPasteis.Location = new System.Drawing.Point(330, 195);
            this.labelPastelariaPasteis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPastelariaPasteis.Name = "labelPastelariaPasteis";
            this.labelPastelariaPasteis.Size = new System.Drawing.Size(54, 17);
            this.labelPastelariaPasteis.TabIndex = 5;
            this.labelPastelariaPasteis.Text = "Pasteis";
            this.labelPastelariaPasteis.Visible = false;
            // 
            // comboBoxPasteis
            // 
            this.comboBoxPasteis.FormattingEnabled = true;
            this.comboBoxPasteis.Items.AddRange(new object[] {
            "Bolo Rei",
            "Tranca",
            "Donut"});
            this.comboBoxPasteis.Location = new System.Drawing.Point(333, 216);
            this.comboBoxPasteis.Name = "comboBoxPasteis";
            this.comboBoxPasteis.Size = new System.Drawing.Size(184, 24);
            this.comboBoxPasteis.TabIndex = 4;
            this.comboBoxPasteis.Visible = false;
            // 
            // labelPastelaria
            // 
            this.labelPastelaria.AutoSize = true;
            this.labelPastelaria.Location = new System.Drawing.Point(104, 195);
            this.labelPastelaria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPastelaria.Name = "labelPastelaria";
            this.labelPastelaria.Size = new System.Drawing.Size(109, 17);
            this.labelPastelaria.TabIndex = 3;
            this.labelPastelaria.Text = "Tipo de produto";
            this.labelPastelaria.Visible = false;
            // 
            // comboBoxPastelaria
            // 
            this.comboBoxPastelaria.FormattingEnabled = true;
            this.comboBoxPastelaria.Items.AddRange(new object[] {
            "Geral",
            "Pasteis"});
            this.comboBoxPastelaria.Location = new System.Drawing.Point(107, 216);
            this.comboBoxPastelaria.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPastelaria.Name = "comboBoxPastelaria";
            this.comboBoxPastelaria.Size = new System.Drawing.Size(182, 24);
            this.comboBoxPastelaria.TabIndex = 2;
            this.comboBoxPastelaria.Visible = false;
            this.comboBoxPastelaria.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelPastelariaGeral
            // 
            this.labelPastelariaGeral.AutoSize = true;
            this.labelPastelariaGeral.Location = new System.Drawing.Point(330, 196);
            this.labelPastelariaGeral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPastelariaGeral.Name = "labelPastelariaGeral";
            this.labelPastelariaGeral.Size = new System.Drawing.Size(43, 17);
            this.labelPastelariaGeral.TabIndex = 1;
            this.labelPastelariaGeral.Text = "Geral";
            this.labelPastelariaGeral.Visible = false;
            // 
            // comboBoxPastelariaGeral
            // 
            this.comboBoxPastelariaGeral.FormattingEnabled = true;
            this.comboBoxPastelariaGeral.Items.AddRange(new object[] {
            "Tosta Mista",
            "Torrada",
            "Croissant",
            "Croissant Misto",
            "Croissant com Manteiga",
            "Cafe",
            "Sumo Laranja Natural"});
            this.comboBoxPastelariaGeral.Location = new System.Drawing.Point(333, 216);
            this.comboBoxPastelariaGeral.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPastelariaGeral.Name = "comboBoxPastelariaGeral";
            this.comboBoxPastelariaGeral.Size = new System.Drawing.Size(184, 24);
            this.comboBoxPastelariaGeral.TabIndex = 0;
            this.comboBoxPastelariaGeral.Visible = false;
            // 
            // listBoxRecibos
            // 
            this.listBoxRecibos.FormattingEnabled = true;
            this.listBoxRecibos.ItemHeight = 16;
            this.listBoxRecibos.Location = new System.Drawing.Point(819, 28);
            this.listBoxRecibos.Name = "listBoxRecibos";
            this.listBoxRecibos.Size = new System.Drawing.Size(507, 356);
            this.listBoxRecibos.TabIndex = 15;
            // 
            // comboBoxAlmocos
            // 
            this.comboBoxAlmocos.FormattingEnabled = true;
            this.comboBoxAlmocos.Items.AddRange(new object[] {
            "Panados",
            "Prego no Prato",
            "Peixe com Batatas"});
            this.comboBoxAlmocos.Location = new System.Drawing.Point(551, 520);
            this.comboBoxAlmocos.Name = "comboBoxAlmocos";
            this.comboBoxAlmocos.Size = new System.Drawing.Size(184, 24);
            this.comboBoxAlmocos.TabIndex = 17;
            this.comboBoxAlmocos.Visible = false;
            // 
            // comboBoxBebidas
            // 
            this.comboBoxBebidas.FormattingEnabled = true;
            this.comboBoxBebidas.Items.AddRange(new object[] {
            "Vodka",
            "Liquor",
            "Cerveja",
            "Whisky"});
            this.comboBoxBebidas.Location = new System.Drawing.Point(551, 400);
            this.comboBoxBebidas.Name = "comboBoxBebidas";
            this.comboBoxBebidas.Size = new System.Drawing.Size(184, 24);
            this.comboBoxBebidas.TabIndex = 18;
            this.comboBoxBebidas.Visible = false;
            // 
            // comboBoxCafes
            // 
            this.comboBoxCafes.FormattingEnabled = true;
            this.comboBoxCafes.Items.AddRange(new object[] {
            "Cafe Pastelaria",
            "Cafe Restaurante",
            "Cafe Bar"});
            this.comboBoxCafes.Location = new System.Drawing.Point(107, 125);
            this.comboBoxCafes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCafes.Name = "comboBoxCafes";
            this.comboBoxCafes.Size = new System.Drawing.Size(182, 24);
            this.comboBoxCafes.TabIndex = 19;
            this.comboBoxCafes.SelectedIndexChanged += new System.EventHandler(this.comboBoxCafes_SelectedIndexChanged);
            // 
            // labelCafe
            // 
            this.labelCafe.AutoSize = true;
            this.labelCafe.Location = new System.Drawing.Point(104, 104);
            this.labelCafe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCafe.Name = "labelCafe";
            this.labelCafe.Size = new System.Drawing.Size(89, 17);
            this.labelCafe.TabIndex = 20;
            this.labelCafe.Text = "Tipo de Cafe";
            // 
            // labelAlmocos
            // 
            this.labelAlmocos.AutoSize = true;
            this.labelAlmocos.Location = new System.Drawing.Point(548, 500);
            this.labelAlmocos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlmocos.Name = "labelAlmocos";
            this.labelAlmocos.Size = new System.Drawing.Size(61, 17);
            this.labelAlmocos.TabIndex = 21;
            this.labelAlmocos.Text = "Almocos";
            this.labelAlmocos.Visible = false;
            // 
            // labelBebidas
            // 
            this.labelBebidas.AutoSize = true;
            this.labelBebidas.Location = new System.Drawing.Point(548, 380);
            this.labelBebidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBebidas.Name = "labelBebidas";
            this.labelBebidas.Size = new System.Drawing.Size(59, 17);
            this.labelBebidas.TabIndex = 22;
            this.labelBebidas.Text = "Bebidas";
            this.labelBebidas.Visible = false;
            // 
            // comboBoxBar
            // 
            this.comboBoxBar.FormattingEnabled = true;
            this.comboBoxBar.Items.AddRange(new object[] {
            "Geral",
            "Bebidas"});
            this.comboBoxBar.Location = new System.Drawing.Point(551, 431);
            this.comboBoxBar.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBar.Name = "comboBoxBar";
            this.comboBoxBar.Size = new System.Drawing.Size(182, 24);
            this.comboBoxBar.TabIndex = 23;
            this.comboBoxBar.Visible = false;
            // 
            // comboBoxRestaurante
            // 
            this.comboBoxRestaurante.FormattingEnabled = true;
            this.comboBoxRestaurante.Location = new System.Drawing.Point(551, 550);
            this.comboBoxRestaurante.Name = "comboBoxRestaurante";
            this.comboBoxRestaurante.Size = new System.Drawing.Size(182, 24);
            this.comboBoxRestaurante.TabIndex = 24;
            this.comboBoxRestaurante.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 822);
            this.Controls.Add(this.comboBoxRestaurante);
            this.Controls.Add(this.comboBoxBar);
            this.Controls.Add(this.labelBebidas);
            this.Controls.Add(this.labelAlmocos);
            this.Controls.Add(this.labelCafe);
            this.Controls.Add(this.comboBoxCafes);
            this.Controls.Add(this.comboBoxBebidas);
            this.Controls.Add(this.comboBoxAlmocos);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxRecibos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPastelaria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPastelaria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPasteis);
            this.Controls.Add(this.comboBoxPastelariaGeral);
            this.Controls.Add(this.labelPastelariaPasteis);
            this.Controls.Add(this.labelPastelariaGeral);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPastelariaPasteis;
        private System.Windows.Forms.ComboBox comboBoxPasteis;
        private System.Windows.Forms.Label labelPastelaria;
        private System.Windows.Forms.ComboBox comboBoxPastelaria;
        private System.Windows.Forms.Label labelPastelariaGeral;
        private System.Windows.Forms.ComboBox comboBoxPastelariaGeral;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox listBoxRecibos;
        private System.Windows.Forms.ComboBox comboBoxAlmocos;
        private System.Windows.Forms.ComboBox comboBoxBebidas;
        private System.Windows.Forms.ComboBox comboBoxCafes;
        private System.Windows.Forms.Label labelCafe;
        private System.Windows.Forms.Label labelAlmocos;
        private System.Windows.Forms.Label labelBebidas;
        private System.Windows.Forms.ComboBox comboBoxBar;
        private System.Windows.Forms.ComboBox comboBoxRestaurante;
    }
}

