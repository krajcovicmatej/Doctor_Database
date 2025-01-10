using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace xkrajcovicm2_zadanie
{
	public partial class Form1 : Form
	{
		OracleConnection spojenie;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				spojenie = new OracleConnection();

				Login frmLogin = new Login();
				DialogResult result = frmLogin.ShowDialog();

				if (result != DialogResult.OK)
				{
					Application.Exit();
				}
				//connection string	to Oracle database (student) on server 
				spojenie.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=147.175.137.84)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=student)));User Id=" + frmLogin.tbLogin.Text + ";Password=" + frmLogin.tbPass.Text + ";";
				spojenie.Open();
				//if connection is successful, show the form
				this.Text = this.Text + " (" + frmLogin.tbLogin.Text + ")";
			} catch (OracleException ex) {
				//if connection is not successful, show the error message and close the application
				MessageBox.Show(ex.Message, "Chyba pripojenia");
				Application.Exit();
			} //MessageBox.Show(spojenie.State.ToString(), "Stav spojenia"); }

			
		}

		private void adnimToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Lekar frmLekar = new Lekar(spojenie);
			
			frmLekar.MdiParent = this;
		
			frmLekar.Show();
		}
	}
}
