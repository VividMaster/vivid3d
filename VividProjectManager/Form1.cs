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
using System.Diagnostics;
namespace VividProjectManager
{
    public partial class ProjectManager : Syncfusion.Windows.Forms.MetroForm
    {
        public List<ProjectLink> Projs = new List<ProjectLink>();
        public NewProject WinNewProj = null;
        public static ProjectManager PM = null;
        public ProjectManager()
        {
            InitializeComponent();
            PM = this;
            LoadProjectList();
        }

        // Create New Project and add to system.
        public void CreateProject(string path,string name,string info)
        {
            ProjectLink np = new ProjectLink
            {
                Name = name,
                Path = path,
                Info = info
            };
            Directory.CreateDirectory(path + "/Content/");
            Directory.CreateDirectory(path + "/Scripts/");
            Directory.CreateDirectory(path + "/Content/3D/");
            Directory.CreateDirectory(path + "/Content/2D/");
            Directory.CreateDirectory(path + "/Content/Sound/");
            Directory.CreateDirectory(path + "/Content/Movie/");
            Directory.CreateDirectory(path + "/Content/Scene/");
            Directory.CreateDirectory(path + "/Content/Material/");
            Projs.Add(np);
            SaveProjectList();
            LoadProjectList();
        }

        public void SaveProjectList()
        {
            if(new FileInfo("projects.list").Exists)
            {
                File.Delete("projects.list");
            }
            var fs = new FileStream("projects.list", FileMode.Create, FileAccess.Write);
            var w = new BinaryWriter(fs);
            w.Write((int)Projs.Count);
            foreach(var pl in Projs)
            {
                w.Write(pl.Name);
                w.Write(pl.Path);
                w.Write(pl.Info);
            }
            w.Flush();
            w.Close();
        }

        public void LoadProjectList()
        {
            if(new FileInfo("projects.list").Exists == false)
            {
                SaveProjectList();
            }
            Projs.Clear();
            var fs = new FileStream("projects.list", FileMode.Open, FileAccess.Read);
            var r = new BinaryReader(fs);
            int pc = r.ReadInt32();
            for(int i = 0; i < pc; i++)
            {
                var pl = new ProjectLink()
                {
                    Name = r.ReadString(),
                    Path = r.ReadString(),
                    Info = r.ReadString()
                };
                Projs.Add(pl);
            }
            r.Close();
            r = null;
            fs = null;

            RebuildUI();

            
        }

        public void RebuildUI()
        {
            ProjG.Controls.Clear();
            int pn = 0;
            foreach(var p in Projs)
            {
                var ib = new VividConLib.InfoBox();
                ib.Header = p.Name;
                ib.Info = p.Info;
                ib.Location = new Point(15, 25 + (pn * 110));
                pn++;
                ib.Width = ProjG.Width - 50;
                ib.Height = 100;
                ProjG.Controls.Add(ib);
                var nb = new System.Windows.Forms.Button();
                nb.Text = "Load Project";
                ib.Controls.Add(nb);
                nb.Location = new Point(5, 70);
                nb.Width = 70;
                nb.Height = 20;
                var dp = new System.Windows.Forms.Button();
                dp.Text = "Remove Project";
                ib.Controls.Add(dp);
                dp.Location = new Point(85, 70);
                dp.Width = 70;
                dp.Height = 20;
                nb.Click += new EventHandler(E_Proj);
                dp.Click += new EventHandler(E_Proj);
                p.LoadObj = nb;
                p.RemObj = dp;
            }
            ProjG.Invalidate();
        }

        public void LoadProject(ProjectLink p)
        {
            Process.Start("VividSplash.exe", p.Path);
            Environment.Exit(-1);
        }

        //Load project event

        public void E_Proj(object obj,EventArgs ev)
        {
            foreach(var p in Projs)
            {
                if (p.LoadObj == obj)
                {
                    LoadProject(p);
                }
                if(p.RemObj == obj)
                {
                    Projs.Remove(p);
                    break;
                    //RebuildUI();
                }
            }
            RebuildUI();
            SaveProjectList();
        }
           

        // Create Project
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (WinNewProj != null)
            {
                WinNewProj.Close();
                WinNewProj = null;
            }
            WinNewProj = new NewProject();
            WinNewProj.Show();
        }
    }
}
