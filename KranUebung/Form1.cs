namespace KranUebung
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private bool nachRechtsGedreht = false;
		private void CmdHakenRaus_Click(object sender, EventArgs e)
		{
			PanelHaken.Size = new Size(PanelHaken.Width, PanelHaken.Height + 20);
		}

		private void CmdHakenRein_Click(object sender, EventArgs e)
		{
			if ((PanelHaken.Height - 20) > 0)
				PanelHaken.Size = new Size(PanelHaken.Width, PanelHaken.Height - 20);
		}

		private void CmdAuslegerRaus_Click(object sender, EventArgs e)
		{
			if (nachRechtsGedreht == false)
			{
				PanelAusleger.Size = new Size(PanelAusleger.Width + 20, PanelAusleger.Height);
				PanelAusleger.Location = new Point(PanelAusleger.Location.X - 20, PanelAusleger.Location.Y);
				PanelHaken.Location = new Point(PanelHaken.Location.X - 20, PanelHaken.Location.Y);
			}
			else
			{
				PanelAusleger.Size = new Size(PanelAusleger.Width + 20, PanelAusleger.Height);
				PanelHaken.Location = new Point(PanelHaken.Location.X + 20, PanelHaken.Location.Y);
			}
		}

		private void CmdAuslegerRein_Click(object sender, EventArgs e)
		{
			if (nachRechtsGedreht == false)
			{
				if ((PanelAusleger.Size.Width - 20) > 20)
				{
					PanelAusleger.Size = new Size(PanelAusleger.Width - 20, PanelAusleger.Height);
					PanelAusleger.Location = new Point(PanelAusleger.Location.X + 20, PanelAusleger.Location.Y);
					PanelHaken.Location = new Point(PanelHaken.Location.X + 20, PanelHaken.Location.Y);
				}
			}
			else
			{
				if ((PanelAusleger.Size.Width - 20) > 20)
				{
					PanelAusleger.Size = new Size(PanelAusleger.Width - 20, PanelAusleger.Height);
					PanelHaken.Location = new Point(PanelHaken.Location.X - 20, PanelHaken.Location.Y);
				}
			}
		}

		private void CmdKranRaus_Click(object sender, EventArgs e)
		{
			//if () //HIER FEHLT CODE
			PanelKran.Size = new Size(PanelKran.Width, PanelKran.Height + 20);
			PanelKran.Location = new Point(PanelKran.Location.X, PanelKran.Location.Y - 20);
			PanelAusleger.Location = new Point(PanelAusleger.Location.X, PanelAusleger.Location.Y - 20);
			PanelHaken.Location = new Point(PanelHaken.Location.X, PanelHaken.Location.Y - 20);
		}

		private void CmdKranRein_Click(object sender, EventArgs e)
		{
			if ((PanelKran.Size.Height - 20) >= 40)
			{
				PanelKran.Size = new Size(PanelKran.Width, PanelKran.Height - 20);
				PanelKran.Location = new Point(PanelKran.Location.X, PanelKran.Location.Y + 20);
				PanelAusleger.Location = new Point(PanelAusleger.Location.X, PanelAusleger.Location.Y + 20);
				PanelHaken.Location = new Point(PanelHaken.Location.X, PanelHaken.Location.Y + 20);
			}
		}

		private void CmdKranRechts_Click(object sender, EventArgs e)
		{
			if (nachRechtsGedreht == false)
			{
				PanelAusleger.Location = new Point(PanelAusleger.Location.X + PanelAusleger.Width - PanelKran.Width, PanelAusleger.Location.Y);
				PanelHaken.Location = new Point(PanelHaken.Location.X + PanelAusleger.Width * 2, PanelHaken.Location.Y);
				nachRechtsGedreht = true;
			}
		}

		private void CmdKranLinks_Click(object sender, EventArgs e)
		{
			if (nachRechtsGedreht == true)
			{
				PanelAusleger.Location = new Point(PanelAusleger.Location.X - PanelAusleger.Width + PanelKran.Width, PanelAusleger.Location.Y);
				PanelHaken.Location = new Point(PanelHaken.Location.X - PanelAusleger.Width * 2, PanelHaken.Location.Y);
				nachRechtsGedreht = false;
			}
		}
	}
}
