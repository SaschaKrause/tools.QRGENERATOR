﻿using System;
using System.Windows.Forms;

namespace TestWizard
{
	public partial class CustomWizardTemplate : Form
	{
		public CustomWizardTemplate()
		{
			InitializeComponent();
		}

		private void wizardPageContainer1_Finished(object sender, EventArgs e)
		{
			this.Close();
		}

		private void wizardPageContainer1_SelectedPageChanged(object sender, EventArgs e)
		{
			headingControl.Text = wizardPageContainer1.SelectedPage.Text;
		}
	}
}
