namespace xkrajcovicm2_zadanie
{
	partial class UptLekar
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbMeno = new System.Windows.Forms.TextBox();
			this.tbPriezvisko = new System.Windows.Forms.TextBox();
			this.tbTelefon = new System.Windows.Forms.TextBox();
			this.tbSpec = new System.Windows.Forms.TextBox();
			this.dptDatumNas = new System.Windows.Forms.DateTimePicker();
			this.nudDoch = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudDoch)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(56, 277);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Zrušiť";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(187, 277);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Uprav";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Email :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Meno :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Priezvisko :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(54, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Telefón :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Dátum nástupu :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(28, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Špecializácia :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(35, 196);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Dochádzka :";
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(121, 28);
			this.tbEmail.MaxLength = 50;
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(200, 20);
			this.tbEmail.TabIndex = 9;
			this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
			this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
			// 
			// tbMeno
			// 
			this.tbMeno.Location = new System.Drawing.Point(121, 57);
			this.tbMeno.MaxLength = 15;
			this.tbMeno.Name = "tbMeno";
			this.tbMeno.Size = new System.Drawing.Size(200, 20);
			this.tbMeno.TabIndex = 10;
			// 
			// tbPriezvisko
			// 
			this.tbPriezvisko.Location = new System.Drawing.Point(121, 85);
			this.tbPriezvisko.MaxLength = 25;
			this.tbPriezvisko.Name = "tbPriezvisko";
			this.tbPriezvisko.Size = new System.Drawing.Size(200, 20);
			this.tbPriezvisko.TabIndex = 11;
			// 
			// tbTelefon
			// 
			this.tbTelefon.Location = new System.Drawing.Point(121, 113);
			this.tbTelefon.Name = "tbTelefon";
			this.tbTelefon.Size = new System.Drawing.Size(200, 20);
			this.tbTelefon.TabIndex = 12;
			this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
			this.tbTelefon.Leave += new System.EventHandler(this.tbTelefon_Leave);
			// 
			// tbSpec
			// 
			this.tbSpec.Location = new System.Drawing.Point(121, 167);
			this.tbSpec.Name = "tbSpec";
			this.tbSpec.Size = new System.Drawing.Size(200, 20);
			this.tbSpec.TabIndex = 13;
			// 
			// dptDatumNas
			// 
			this.dptDatumNas.Location = new System.Drawing.Point(121, 140);
			this.dptDatumNas.Name = "dptDatumNas";
			this.dptDatumNas.Size = new System.Drawing.Size(200, 20);
			this.dptDatumNas.TabIndex = 14;
			// 
			// nudDoch
			// 
			this.nudDoch.Location = new System.Drawing.Point(121, 194);
			this.nudDoch.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nudDoch.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nudDoch.Name = "nudDoch";
			this.nudDoch.Size = new System.Drawing.Size(200, 20);
			this.nudDoch.TabIndex = 15;
			this.nudDoch.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// UptLekar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 332);
			this.Controls.Add(this.nudDoch);
			this.Controls.Add(this.dptDatumNas);
			this.Controls.Add(this.tbSpec);
			this.Controls.Add(this.tbTelefon);
			this.Controls.Add(this.tbPriezvisko);
			this.Controls.Add(this.tbMeno);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.Name = "UptLekar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Uprav Lekára";
			this.Load += new System.EventHandler(this.UptLekar_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudDoch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbMeno;
		private System.Windows.Forms.TextBox tbPriezvisko;
		private System.Windows.Forms.TextBox tbTelefon;
		private System.Windows.Forms.TextBox tbSpec;
		private System.Windows.Forms.DateTimePicker dptDatumNas;
		private System.Windows.Forms.NumericUpDown nudDoch;
	}
}