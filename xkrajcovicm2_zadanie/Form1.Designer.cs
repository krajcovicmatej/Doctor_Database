namespace xkrajcovicm2_zadanie
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
			this.components = new System.ComponentModel.Container();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.súborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zobraziťToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adnimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.súborToolStripMenuItem,
            this.zobraziťToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// súborToolStripMenuItem
			// 
			this.súborToolStripMenuItem.Name = "súborToolStripMenuItem";
			this.súborToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.súborToolStripMenuItem.Text = "Súbor";
			// 
			// zobraziťToolStripMenuItem
			// 
			this.zobraziťToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adnimToolStripMenuItem});
			this.zobraziťToolStripMenuItem.Name = "zobraziťToolStripMenuItem";
			this.zobraziťToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.zobraziťToolStripMenuItem.Text = "Zobraziť";
			// 
			// adnimToolStripMenuItem
			// 
			this.adnimToolStripMenuItem.Name = "adnimToolStripMenuItem";
			this.adnimToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.adnimToolStripMenuItem.Text = "Lekár";
			this.adnimToolStripMenuItem.Click += new System.EventHandler(this.adnimToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1148, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "OracleApp";
			this.Shown += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem súborToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zobraziťToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adnimToolStripMenuItem;
	}
}

