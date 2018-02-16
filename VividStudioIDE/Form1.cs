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
using WeifenLuo.WinFormsUI.Docking;
using WeifenLuo.WinFormsUI;

namespace VividStudioIDE
{
    public partial class Form1 : Form 
    {
        public Syncfusion.Windows.Forms.Tools.DockingManager VDock = null;
        public Panel t1 = null;
        public Panel DScene = null;
        public Panel DContent = null;
        public Panel D3DView = null;
        public DockPanel DP = null;
        public ContentViewer VContent = null;
        public MainView VMain = null;
        public SceneView VScene = null;
    
        public Form1()
        {
            InitializeComponent();
            this.Hide();
        
           
            this.Text = "Vivid3D - Project:" + LoadArg.LoadPath;
            DP = new DockPanel();
            this.Controls.Add(DP);
            DP.Dock = DockStyle.Fill;



        

            VContent = new ContentViewer();

            VContent.Show(DP, DockState.DockBottom);

            VContent.Activate();
            VMain = new MainView();
            VMain.Size = new Size(400, 77);
            VMain.Show(DP, DockState.Document);
            VMain.Size = new Size(400, 77);

            VScene = new SceneView();
            VScene.Show(DP, DockState.DockLeft);
          

          
        }

        private void SplashT_Tick1(object sender, EventArgs e)
        {
         
        }

        private void SplashT_Tick(object sender, EventArgs e)
        {
          
        }

        private Timer SplashT = null;
        private void ddoui(object sender, EventArgs e)
        {
            DContent.Location = new Point(0, D3DView.Height + 5);
            
        }
        public Timer uit = new Timer();
        public void DoUI()
        {

        }
        private void ribbonControlAdv1_OfficeMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(-1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
      
            SplashT = new Timer();
            SplashT.Interval = 50;
            SplashT.Tick += SplashT_Tick1;
            SplashT.Enabled = true;
            SplashT.Start();
        }
    }
}
