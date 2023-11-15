/* MOIC - Medium Orbit Ion Cannon
 * Released to the public domain
 * Enjoy getting v&, kids.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MOIC
{
	public partial class frmEULA : Form
	{
		public frmEULA()
		{
			InitializeComponent();

			txtEULA.Clear();
			txtEULA.ReadOnly = true;
			txtEULA.Rtf = global::MOIC.Properties.Resources.EULA;

			BringToFront();
		}

		private void chkEULA_CheckedChanged(object sender, EventArgs e)
		{
			btnAccept.Enabled = chkEULA.Checked;
		}
	}
}