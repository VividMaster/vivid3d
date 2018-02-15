#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace VividProjectManager
{
    partial class NewProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TProjName = new System.Windows.Forms.TextBox();
            this.TProjPath = new System.Windows.Forms.TextBox();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.TProjInfo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.projb = new Syncfusion.Windows.Forms.FolderBrowser(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Path";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TProjName
            // 
            this.TProjName.Location = new System.Drawing.Point(131, 10);
            this.TProjName.Name = "TProjName";
            this.TProjName.Size = new System.Drawing.Size(398, 22);
            this.TProjName.TabIndex = 2;
            // 
            // TProjPath
            // 
            this.TProjPath.Location = new System.Drawing.Point(131, 44);
            this.TProjPath.Name = "TProjPath";
            this.TProjPath.Size = new System.Drawing.Size(398, 22);
            this.TProjPath.TabIndex = 3;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(536, 42);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv1.TabIndex = 4;
            this.buttonAdv1.Text = "Browse";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // TProjInfo
            // 
            this.TProjInfo.Location = new System.Drawing.Point(131, 91);
            this.TProjInfo.Name = "TProjInfo";
            this.TProjInfo.Size = new System.Drawing.Size(480, 122);
            this.TProjInfo.TabIndex = 5;
            this.TProjInfo.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Project Info";
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(172, 32);
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(13, 230);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(172, 32);
            this.buttonAdv2.TabIndex = 7;
            this.buttonAdv2.Text = "Create Project";
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(180, 32);
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(431, 230);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(180, 32);
            this.buttonAdv3.TabIndex = 8;
            this.buttonAdv3.Text = "Cancel";
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // projb
            // 
            this.projb.Description = "Select a empty folder for your project.";
            this.projb.StartLocation = Syncfusion.Windows.Forms.FolderBrowserFolder.MyDocuments;
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 265);
            this.Controls.Add(this.buttonAdv3);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TProjInfo);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.TProjPath);
            this.Controls.Add(this.TProjName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewProject";
            this.Text = "MetroForm1";
            this.Load += new System.EventHandler(this.NewProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TProjName;
        private System.Windows.Forms.TextBox TProjPath;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private System.Windows.Forms.RichTextBox TProjInfo;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
        public Syncfusion.Windows.Forms.FolderBrowser projb;
    }
}