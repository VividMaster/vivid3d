#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace VividProjectManager
{
    public partial class NewProject : Syncfusion.Windows.Forms.MetroForm
    {
        public NewProject()
        {
            InitializeComponent();
        }

        private void buttonEditChildButton1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            this.Close();
            ProjectManager.PM.WinNewProj = null;
        }

        private void NewProject_Load(object sender, EventArgs e)
        {

        }
        // Browse Project Path
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            var r=projb.ShowDialog();

            switch (r)
            {
                case DialogResult.OK:
                case DialogResult.Yes:
                    TProjPath.Text = projb.DirectoryPath;
                    break;
                default:
                    break;
            }

        }

        //Create Project
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            if(TProjName.Text.Length<1)
            {
                MessageBox.Show("New Project", "Project must have a name.");
                return;
            }
            if(new DirectoryInfo(TProjPath.Text).Exists==false)
            {
                Directory.CreateDirectory(TProjPath.Text);
                if(new DirectoryInfo(TProjPath.Text).Exists == false)
                {
                    MessageBox.Show("New Project", "Invalid Project path - please choose another location.");
                    return;
                }
            }
            ProjectManager.PM.CreateProject(TProjPath.Text, TProjName.Text, TProjInfo.Text);
            this.Close();
            ProjectManager.PM.WinNewProj = null;
        }
    }
}
