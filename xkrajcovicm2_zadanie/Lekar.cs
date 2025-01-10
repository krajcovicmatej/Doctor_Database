using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace Doctor_Database
{
	public partial class Lekar : Form
	{
		OracleConnection spojenie;
		OracleDataAdapter adapter;
		OracleCommand sql;
		DataSet dset;
		public Lekar(OracleConnection existujuceSpojenie)
		{
			InitializeComponent();

			spojenie = existujuceSpojenie;

			dset = new DataSet();
		}

	

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Zamestnanec_Load(object sender, EventArgs e)
		{
			try
			{ 

				string select = "SELECT Lekar.* FROM Lekar";
				//hardcoded select
				//string select = "SELECT ID, Email, Meno, Priezvisko, Telefon, Datum_Nastupu, SPECIALIZACIA, Dochadzka FROM Lekar";

				//inicialization Data Adapter
				adapter = new OracleDataAdapter(select, spojenie);
				//data loading from Oracle to DataSet
				dset.Tables.Clear();
				adapter.Fill(dset, "Lekar");
			  //data binding to DataGridView
			  dgvLekar.DataSource = dset.Tables["Lekar"];
			}
			catch (OracleException ex)
			{
				//if connection is not successful, show the error message and close the application
				MessageBox.Show(ex.Message, "Chyba pri načítaní dát"); }
			}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void dgvLekar_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			if (dgvLekar.SelectedRows.Count > 0)
			{

				tbID.Text = dgvLekar.SelectedRows[0].Cells["ID"].Value.ToString();
				tbPriezvisko.Text = dgvLekar.SelectedRows[0].Cells["Priezvisko"].Value.ToString();
				tbDatumNas.Text = dgvLekar.SelectedRows[0].Cells["Datum_nastupu"].Value.ToString();
				nudDochadzka.Value = Convert.ToInt32(dgvLekar.SelectedRows[0].Cells["Dochadzka"].Value);


			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
	
			
			 try { 
			//finding out if the user really wants to delete the employee
			DialogResult odpoved = MessageBox.Show("Naozaj chcte vymazať zamestnanca s ID: " 
			+ tbID.Text, "Vymazanie zamestnanca", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			// answer YES 
			if (odpoved == DialogResult.Yes) {
			//Sql delete command
			string delete = "delete from Lekar where ID = " + tbID.Text;
			sql = new OracleCommand(delete, spojenie); 
			sql.ExecuteNonQuery(); 
											} 
				} catch (OracleException ex) {
			//if error occurs, show the message
			MessageBox.Show(ex.Message, "Chyba pri mazaní dát"); 
			} 
			finally {
			//update of the data in the DataGridView
			dset.Tables["Lekar"].Clear(); 
			adapter.Fill(dset, "Lekar"); 
					}
			 
		}

		private void tbDatumNas_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			InsLekar frmInsLekar = new InsLekar(spojenie);

			frmInsLekar.ShowDialog();

			dset.Tables["Lekar"].Clear();
			adapter.Fill(dset, "Lekar");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			/*UptLekar frmUptLekar = new UptLekar(spojenie);

			frmUptLekar.ShowDialog();

			dset.Tables["Lekar"].Clear();
			adapter.Fill(dset, "Lekar");
			*/

			try
			{
				// findig ID of the employee
				int idLekara = Convert.ToInt32(tbID.Text);

				// opening the form for updating the employee
				UptLekar frmUptLekar = new UptLekar(spojenie, idLekara);

				// if the form is closed with OK, the data are updated
				if (frmUptLekar.ShowDialog() == DialogResult.OK)
				{
					// update of the data in the DataGridView
					dset.Tables["Lekar"].Clear();
					adapter.Fill(dset, "Lekar");
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("ID lekára musí byť číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
