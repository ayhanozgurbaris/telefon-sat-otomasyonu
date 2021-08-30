using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class frmAnaSayfa : Form
	{
		public frmAnaSayfa()
		{
			InitializeComponent();
		}

		private void FormGetir(Form frm)
		{
			panelSayfalar.Controls.Clear();
			frm.MdiParent = this;
			frm.FormBorderStyle = FormBorderStyle.None;
			frm.Dock = DockStyle.Left;
			panelSayfalar.Controls.Add(frm);
			frm.Show();
		}

		private void frmAnaSayfa_Load(object sender, EventArgs e)
		{

		}
	}
}
