using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_Database
{
	public partial class InsLekar : Form
	{
		OracleConnection spojenie;
		OracleDataAdapter adapter;
		OracleCommand sql;
		DataSet dset;
		public InsLekar(OracleConnection existujuceSpojenie)
		{
			InitializeComponent();

			spojenie = existujuceSpojenie;
		}

		private void InsLekar_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
		{
			// permit only digits and '+' in textbox
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+')
			{
				e.Handled = true; // Zakáže nepovolený znak
			}

			// permit '+' only at the beginning of the textbox
			if (e.KeyChar == '+' && tbTelefon.SelectionStart != 0)
			{
				e.Handled = true; // prohibit '+' in the middle of the textbox
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// email verification
			if (!tbEmail.Text.Contains("@") || !tbEmail.Text.Contains("."))
			{
				MessageBox.Show("Zadajte platnú emailovú adresu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tbEmail.Focus();
				return;
			}

			// telephone number verification
			if (tbTelefon.Text.Length < 9 || tbTelefon.Text.Length > 15)
			{
				MessageBox.Show("Telefónne číslo musí mať 9 až 15 znakov.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tbTelefon.Focus();
				return;
			}

			// confirmation dialog
			DialogResult odpoved = MessageBox.Show("Naozaj chcete pridať zamestnanca: " + tbMeno.Text + " " + tbPriezvisko.Text + "?", 
				"Potvrdenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			//if the user clicks on "No", return
			if (odpoved == DialogResult.No) 
			{ 
				return; 
			}
			try
			{
				// if any of the fields is empty, show error message
				if (tbEmail.Text == "" || tbMeno.Text == "" || tbPriezvisko.Text == "" || tbTelefon.Text == "" || tbSpec.Text == "")
				{
					MessageBox.Show("Všetky údaje musia byť vyplnené!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// verification of the date
				if (dptDatumNas.Value == null)
				{
					MessageBox.Show("Zadajte dátum nástupu!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// verification of the attendance
				if (nudDoch.Value == 0)
				{
					MessageBox.Show("Zadajte dochádzku!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				// sgl query to get the highest ID (osobne cislo) from the table - "autoincrement"
				string getMaxOsobneCisloQuery = "SELECT max(ID) FROM lekar";
				OracleCommand getMaxOsobneCisloCommand = new OracleCommand(getMaxOsobneCisloQuery, spojenie);

				var maxOsobneCislo = getMaxOsobneCisloCommand.ExecuteScalar();
				int noveOsobneCislo = maxOsobneCislo != DBNull.Value ? Convert.ToInt32(maxOsobneCislo) + 1 : 1;

				// SQL insert command
				string insert = "INSERT INTO Lekar (ID, Email, Meno, Priezvisko, Telefon, Datum_Nastupu, Specializacia, Dochadzka) " +
								"VALUES (:ID, :Email, :Meno, :Priezvisko, :Telefon, TO_DATE(:Datum_Nastupu, 'DD.MM.YYYY'), :Specializacia, :Dochadzka)";

				
				OracleCommand sql = new OracleCommand(insert, spojenie);

				// insert parameters
				sql.Parameters.Add(":ID", noveOsobneCislo); // new ID
				sql.Parameters.Add(":Email", tbEmail.Text);
				sql.Parameters.Add(":Meno", tbMeno.Text);
				sql.Parameters.Add(":Priezvisko", tbPriezvisko.Text);
				sql.Parameters.Add(":Telefon", tbTelefon.Text);
				sql.Parameters.Add(":Datum_Nastupu", dptDatumNas.Value.ToString("dd.MM.yyyy")); // format date
				sql.Parameters.Add(":Specializacia", tbSpec.Text);
				sql.Parameters.Add(":Dochadzka", nudDoch.Value); // number of attendances from the numeric up-down control

				// send the command
				sql.ExecuteNonQuery();

				// if the command was successful, close the form
				this.DialogResult = DialogResult.OK;

			}
			catch (OracleException ex)
			{
				// if error occurs, show the message
				MessageBox.Show(ex.Message, "Chyba pri vkladaní dát");
			}
		}

		private void tbEmail_Leave(object sender, EventArgs e)
		{
			if (!tbEmail.Text.Contains("@") || !tbEmail.Text.Contains("."))
			{
				MessageBox.Show("Zadajte platnú emailovú adresu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tbEmail.Focus();
			}
		}

		private void tbTelefon_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbTelefon_Leave(object sender, EventArgs e)
		{
			if (tbTelefon.Text.Length < 9 || tbTelefon.Text.Length > 15)
			{
				MessageBox.Show("Telefónne číslo musí mať 9 až 15 znakov.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tbTelefon.Focus();
			}
		}
	}
}
