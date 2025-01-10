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
	public partial class UptLekar : Form
	{
		OracleConnection spojenie;
		OracleDataAdapter adapter;
		OracleCommand sql;
		DataSet dset;
		int idLekara;
		public UptLekar(OracleConnection existujuceSpojenie, int idLekara)
		{
			InitializeComponent();

			spojenie = existujuceSpojenie;
			this.idLekara = idLekara;
		}

		private void UptLekar_Load(object sender, EventArgs e)
		{
			
			try
			{
				
				string query = "SELECT * FROM Lekar WHERE ID = :ID";
				OracleCommand sql = new OracleCommand(query, spojenie);
				sql.Parameters.Add(":ID", idLekara);

				OracleDataReader reader = sql.ExecuteReader();

				if (reader.Read())
				{
				

					tbEmail.Text = reader["Email"].ToString();
					tbMeno.Text = reader["Meno"].ToString();
					tbPriezvisko.Text = reader["Priezvisko"].ToString();
					tbTelefon.Text = reader["Telefon"].ToString();
					dptDatumNas.Value = Convert.ToDateTime(reader["Datum_Nastupu"]);
					tbSpec.Text = reader["Specializacia"].ToString();
					nudDoch.Value = Convert.ToDecimal(reader["Dochadzka"]);
				}
				else
				{
					MessageBox.Show("Lekár s ID " + idLekara + " neexistuje.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Close(); // Closing Form, if "lekar" not found
				}

				reader.Close();
			}
			catch (OracleException ex)
			{
				MessageBox.Show("Chyba pri načítaní údajov lekára: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


			try
			{
					// are all fields filled?
					if (tbEmail.Text == "" || tbMeno.Text == "" || tbPriezvisko.Text == "" || tbTelefon.Text == "" || tbSpec.Text == "")
					{
						MessageBox.Show("Všetky údaje musia byť vyplnené!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					// confirmation dialog
					DialogResult odpoved = MessageBox.Show("Chcete naozaj dané zmeny uložiť?", "Potvrdenie uloženia",
						MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

					// if No is clicked, return
					if (odpoved == DialogResult.No)
					{
						return;
					}

				// SQL command for updating the doctor
				string update = "UPDATE Lekar " +
									"SET Email = :Email, Meno = :Meno, Priezvisko = :Priezvisko, Telefon = :Telefon, " +
									"Datum_Nastupu = TO_DATE(:Datum_Nastupu, 'DD.MM.YYYY'), Specializacia = :Specializacia, Dochadzka = :Dochadzka " +
									"WHERE ID = :ID";

					OracleCommand sql = new OracleCommand(update, spojenie);

					// defining parameters
					sql.Parameters.Add(":Email", tbEmail.Text);
					sql.Parameters.Add(":Meno", tbMeno.Text);
					sql.Parameters.Add(":Priezvisko", tbPriezvisko.Text);
					sql.Parameters.Add(":Telefon", tbTelefon.Text);
					sql.Parameters.Add(":Datum_Nastupu", dptDatumNas.Value.ToString("dd.MM.yyyy"));
					sql.Parameters.Add(":Specializacia", tbSpec.Text);
					sql.Parameters.Add(":Dochadzka", nudDoch.Value);
					sql.Parameters.Add(":ID", idLekara); // ID sa nemení

					// executing the command
					int rowsAffected = sql.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						MessageBox.Show("Údaje lekára boli úspešne aktualizované.", "Úspech", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.DialogResult = DialogResult.OK; // Nastavenie OK pre hlavný formulár
						this.Close(); // Zatvorenie formulára
					}
					else
					{
						MessageBox.Show("Lekár s ID " + idLekara + " neexistuje.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				catch (OracleException ex)
				{
					MessageBox.Show("Chyba pri ukladaní zmien: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			

		}

		private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
		{
			// permit only digits and '+' character
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+')
			{
				e.Handled = true; // Zakáže nepovolený znak
			}

			// permit '+' only at the beginning
			if (e.KeyChar == '+' && tbTelefon.SelectionStart != 0)
			{
				e.Handled = true; // prohibit '+' in the middle of the number
			}
		}

		private void tbEmail_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbEmail_Leave(object sender, EventArgs e)
		{
			if (!tbEmail.Text.Contains("@") || !tbEmail.Text.Contains("."))
			{
				MessageBox.Show("Zadajte platnú emailovú adresu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tbEmail.Focus();
			}
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
