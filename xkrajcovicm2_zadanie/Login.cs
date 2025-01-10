using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xkrajcovicm2_zadanie
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			if ((tbLogin.Text == "") && (tbPass.Text == "") && (this.DialogResult == DialogResult.OK)){
				MessageBox.Show("Nesprávne prihlasovacie údaje", "Chyba prihlásenia",MessageBoxButtons.OK,MessageBoxIcon.Error);

				e.Cancel = true;
			}
			
		}
	}
}
