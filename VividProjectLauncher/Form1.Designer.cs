namespace VividProjectLauncher
{
    partial class Projects
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
            this.label1 = new System.Windows.Forms.Label();
            this.infoBox1 = new VividConLib.InfoBox();
            this.box1 = new VividConLib.Box();
            this.label2 = new System.Windows.Forms.Label();
            this.box2 = new VividConLib.Box();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vivid3D Projects";
            // 
            // infoBox1
            // 
            this.infoBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.infoBox1.Header = "Vivid3D Projects";
            this.infoBox1.Info = "Welcome to Vivid3D Studio - The Next Gen Game IDE.";
            this.infoBox1.Location = new System.Drawing.Point(572, 12);
            this.infoBox1.Name = "infoBox1";
            this.infoBox1.Size = new System.Drawing.Size(225, 104);
            this.infoBox1.TabIndex = 0;
            // 
            // box1
            // 
            this.box1.BackCol = System.Drawing.SystemColors.WindowFrame;
            this.box1.Location = new System.Drawing.Point(424, 152);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(373, 454);
            this.box1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Projects";
            // 
            // box2
            // 
            this.box2.BackCol = System.Drawing.SystemColors.WindowFrame;
            this.box2.Location = new System.Drawing.Point(12, 152);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(373, 402);
            this.box2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Latest News";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(105, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "New Project";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(364, 152);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 402);
            this.vScrollBar1.TabIndex = 7;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(776, 152);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(21, 454);
            this.vScrollBar2.TabIndex = 8;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(809, 618);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoBox1);
            this.Name = "Projects";
            this.Text = "Vivid Projects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VividConLib.InfoBox infoBox1;
        private System.Windows.Forms.Label label1;
        private VividConLib.Box box1;
        private System.Windows.Forms.Label label2;
        private VividConLib.Box box2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
    }
}

