namespace KranUebung
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			CmdHakenRaus = new Button();
			CmdHakenRein = new Button();
			CmdAuslegerRaus = new Button();
			CmdAuslegerRein = new Button();
			CmdKranRaus = new Button();
			CmdKranRein = new Button();
			CmdKranRechts = new Button();
			CmdKranLinks = new Button();
			PanelHaken = new Panel();
			PanelAusleger = new Panel();
			PanelKran = new Panel();
			PanelFuss = new Panel();
			SuspendLayout();
			// 
			// CmdHakenRaus
			// 
			CmdHakenRaus.Location = new Point(610, 70);
			CmdHakenRaus.Name = "CmdHakenRaus";
			CmdHakenRaus.Size = new Size(141, 23);
			CmdHakenRaus.TabIndex = 0;
			CmdHakenRaus.Text = "Haken raus";
			CmdHakenRaus.UseVisualStyleBackColor = true;
			CmdHakenRaus.Click += CmdHakenRaus_Click;
			// 
			// CmdHakenRein
			// 
			CmdHakenRein.Location = new Point(610, 107);
			CmdHakenRein.Name = "CmdHakenRein";
			CmdHakenRein.Size = new Size(141, 23);
			CmdHakenRein.TabIndex = 1;
			CmdHakenRein.Text = "Haken rein";
			CmdHakenRein.UseVisualStyleBackColor = true;
			CmdHakenRein.Click += CmdHakenRein_Click;
			// 
			// CmdAuslegerRaus
			// 
			CmdAuslegerRaus.Location = new Point(610, 144);
			CmdAuslegerRaus.Name = "CmdAuslegerRaus";
			CmdAuslegerRaus.Size = new Size(141, 23);
			CmdAuslegerRaus.TabIndex = 2;
			CmdAuslegerRaus.Text = "Ausleger raus";
			CmdAuslegerRaus.UseVisualStyleBackColor = true;
			CmdAuslegerRaus.Click += CmdAuslegerRaus_Click;
			// 
			// CmdAuslegerRein
			// 
			CmdAuslegerRein.Location = new Point(610, 181);
			CmdAuslegerRein.Name = "CmdAuslegerRein";
			CmdAuslegerRein.Size = new Size(141, 23);
			CmdAuslegerRein.TabIndex = 3;
			CmdAuslegerRein.Text = "Ausleger rein";
			CmdAuslegerRein.UseVisualStyleBackColor = true;
			CmdAuslegerRein.Click += CmdAuslegerRein_Click;
			// 
			// CmdKranRaus
			// 
			CmdKranRaus.Location = new Point(610, 218);
			CmdKranRaus.Name = "CmdKranRaus";
			CmdKranRaus.Size = new Size(141, 23);
			CmdKranRaus.TabIndex = 4;
			CmdKranRaus.Text = "Kran raus";
			CmdKranRaus.UseVisualStyleBackColor = true;
			CmdKranRaus.Click += CmdKranRaus_Click;
			// 
			// CmdKranRein
			// 
			CmdKranRein.Location = new Point(610, 255);
			CmdKranRein.Name = "CmdKranRein";
			CmdKranRein.Size = new Size(141, 23);
			CmdKranRein.TabIndex = 5;
			CmdKranRein.Text = "Kran rein";
			CmdKranRein.UseVisualStyleBackColor = true;
			CmdKranRein.Click += CmdKranRein_Click;
			// 
			// CmdKranRechts
			// 
			CmdKranRechts.Location = new Point(610, 292);
			CmdKranRechts.Name = "CmdKranRechts";
			CmdKranRechts.Size = new Size(141, 23);
			CmdKranRechts.TabIndex = 6;
			CmdKranRechts.Text = "Kran rechts";
			CmdKranRechts.UseVisualStyleBackColor = true;
			CmdKranRechts.Click += CmdKranRechts_Click;
			// 
			// CmdKranLinks
			// 
			CmdKranLinks.Location = new Point(610, 329);
			CmdKranLinks.Name = "CmdKranLinks";
			CmdKranLinks.Size = new Size(141, 23);
			CmdKranLinks.TabIndex = 7;
			CmdKranLinks.Text = "Kran links";
			CmdKranLinks.UseVisualStyleBackColor = true;
			CmdKranLinks.Click += CmdKranLinks_Click;
			// 
			// PanelHaken
			// 
			PanelHaken.BackColor = Color.Red;
			PanelHaken.Location = new Point(249, 243);
			PanelHaken.Name = "PanelHaken";
			PanelHaken.Size = new Size(20, 20);
			PanelHaken.TabIndex = 8;
			// 
			// PanelAusleger
			// 
			PanelAusleger.BackColor = Color.LawnGreen;
			PanelAusleger.Location = new Point(269, 243);
			PanelAusleger.Name = "PanelAusleger";
			PanelAusleger.Size = new Size(60, 20);
			PanelAusleger.TabIndex = 0;
			// 
			// PanelKran
			// 
			PanelKran.BackColor = Color.MidnightBlue;
			PanelKran.Location = new Point(309, 260);
			PanelKran.Name = "PanelKran";
			PanelKran.Size = new Size(20, 60);
			PanelKran.TabIndex = 0;
			// 
			// PanelFuss
			// 
			PanelFuss.BackColor = Color.Goldenrod;
			PanelFuss.Location = new Point(289, 320);
			PanelFuss.Name = "PanelFuss";
			PanelFuss.Size = new Size(60, 20);
			PanelFuss.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(PanelAusleger);
			Controls.Add(PanelKran);
			Controls.Add(PanelFuss);
			Controls.Add(PanelHaken);
			Controls.Add(CmdKranLinks);
			Controls.Add(CmdKranRechts);
			Controls.Add(CmdKranRein);
			Controls.Add(CmdKranRaus);
			Controls.Add(CmdAuslegerRein);
			Controls.Add(CmdAuslegerRaus);
			Controls.Add(CmdHakenRein);
			Controls.Add(CmdHakenRaus);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button CmdHakenRaus;
		private Button CmdHakenRein;
		private Button CmdAuslegerRaus;
		private Button CmdAuslegerRein;
		private Button CmdKranRaus;
		private Button CmdKranRein;
		private Button CmdKranRechts;
		private Button CmdKranLinks;
		private Panel PanelHaken;
		private Panel PanelAusleger;
		private Panel PanelKran;
		private Panel PanelFuss;
	}
}
