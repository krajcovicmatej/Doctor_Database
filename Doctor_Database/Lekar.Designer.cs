namespace Doctor_Database
{
	partial class Lekar
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
			this.dgvLekar = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDatumNas = new System.Windows.Forms.TextBox();
			this.tbPriezvisko = new System.Windows.Forms.TextBox();
			this.tbID = new System.Windows.Forms.TextBox();
			this.nudDochadzka = new System.Windows.Forms.NumericUpDown();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Priezvisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Datum_nastupu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Specializacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dochadzka = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvLekar)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDochadzka)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvLekar
			// 
			this.dgvLekar.AllowUserToAddRows = false;
			this.dgvLekar.AllowUserToDeleteRows = false;
			this.dgvLekar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvLekar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLekar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Email,
            this.Meno,
            this.Priezvisko,
            this.telefon,
            this.Datum_nastupu,
            this.Specializacia,
            this.Dochadzka});
			this.dgvLekar.Location = new System.Drawing.Point(0, 0);
			this.dgvLekar.Name = "dgvLekar";
			this.dgvLekar.ReadOnly = true;
			this.dgvLekar.RowHeadersVisible = false;
			this.dgvLekar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLekar.Size = new System.Drawing.Size(804, 359);
			this.dgvLekar.TabIndex = 0;
			this.dgvLekar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dgvLekar.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvLekar_RowStateChanged);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(810, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(264, 359);
			this.panel1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbDatumNas);
			this.groupBox1.Controls.Add(this.tbPriezvisko);
			this.groupBox1.Controls.Add(this.tbID);
			this.groupBox1.Controls.Add(this.nudDochadzka);
			this.groupBox1.Location = new System.Drawing.Point(4, 51);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(237, 243);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dáta";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Dochádzka :";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Dátum nástupu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Prezvisko :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(61, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "ID :";
			// 
			// tbDatumNas
			// 
			this.tbDatumNas.Location = new System.Drawing.Point(111, 92);
			this.tbDatumNas.Name = "tbDatumNas";
			this.tbDatumNas.ReadOnly = true;
			this.tbDatumNas.Size = new System.Drawing.Size(100, 20);
			this.tbDatumNas.TabIndex = 3;
			this.tbDatumNas.TextChanged += new System.EventHandler(this.tbDatumNas_TextChanged);
			// 
			// tbPriezvisko
			// 
			this.tbPriezvisko.Location = new System.Drawing.Point(111, 66);
			this.tbPriezvisko.Name = "tbPriezvisko";
			this.tbPriezvisko.ReadOnly = true;
			this.tbPriezvisko.Size = new System.Drawing.Size(100, 20);
			this.tbPriezvisko.TabIndex = 2;
			// 
			// tbID
			// 
			this.tbID.Location = new System.Drawing.Point(111, 40);
			this.tbID.Name = "tbID";
			this.tbID.ReadOnly = true;
			this.tbID.Size = new System.Drawing.Size(100, 20);
			this.tbID.TabIndex = 1;
			// 
			// nudDochadzka
			// 
			this.nudDochadzka.Location = new System.Drawing.Point(111, 158);
			this.nudDochadzka.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nudDochadzka.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nudDochadzka.Name = "nudDochadzka";
			this.nudDochadzka.ReadOnly = true;
			this.nudDochadzka.Size = new System.Drawing.Size(120, 20);
			this.nudDochadzka.TabIndex = 0;
			this.nudDochadzka.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(166, 21);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Vymazať";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(85, 21);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Upraviť";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(4, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Pridať";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "EMAIL";
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			// 
			// Meno
			// 
			this.Meno.DataPropertyName = "MENO";
			this.Meno.HeaderText = "Meno";
			this.Meno.Name = "Meno";
			this.Meno.ReadOnly = true;
			// 
			// Priezvisko
			// 
			this.Priezvisko.DataPropertyName = "PRIEZVISKO";
			this.Priezvisko.HeaderText = "Priezvisko";
			this.Priezvisko.Name = "Priezvisko";
			this.Priezvisko.ReadOnly = true;
			// 
			// telefon
			// 
			this.telefon.DataPropertyName = "TELEFON";
			this.telefon.HeaderText = "Telefón";
			this.telefon.Name = "telefon";
			this.telefon.ReadOnly = true;
			// 
			// Datum_nastupu
			// 
			this.Datum_nastupu.DataPropertyName = "DATUM_NASTUPU";
			this.Datum_nastupu.HeaderText = "Dátum_nástupu";
			this.Datum_nastupu.Name = "Datum_nastupu";
			this.Datum_nastupu.ReadOnly = true;
			// 
			// Specializacia
			// 
			this.Specializacia.DataPropertyName = "SPECIALIZACIA";
			this.Specializacia.HeaderText = "Špecializácia";
			this.Specializacia.Name = "Specializacia";
			this.Specializacia.ReadOnly = true;
			// 
			// Dochadzka
			// 
			this.Dochadzka.DataPropertyName = "DOCHADZKA";
			this.Dochadzka.HeaderText = "Dochádzka";
			this.Dochadzka.Name = "Dochadzka";
			this.Dochadzka.ReadOnly = true;
			// 
			// Lekar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1086, 365);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvLekar);
			this.Name = "Lekar";
			this.Text = "Lekár";
			this.Load += new System.EventHandler(this.Zamestnanec_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvLekar)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDochadzka)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvLekar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbID;
		private System.Windows.Forms.NumericUpDown nudDochadzka;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDatumNas;
		private System.Windows.Forms.TextBox tbPriezvisko;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Meno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Priezvisko;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
		private System.Windows.Forms.DataGridViewTextBoxColumn Datum_nastupu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Specializacia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Dochadzka;
	}
}