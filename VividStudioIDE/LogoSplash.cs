using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VividStudioIDE
{
    public partial class LogoSplash : Syncfusion.Windows.Forms.MetroForm
    {
        public float AV = 0.0f;
        public Timer T1 = new Timer();
        public Timer T2 = new Timer();
        public static bool Done = false;
        public LogoSplash()
        {
            InitializeComponent();
            this.AllowTransparency = true;
            this.Opacity = 0.0f;
            T1.Interval = 25;
            T1.Enabled = true;
            T1.Tick += T1_Tick;
            T1.Start();
            T2.Interval = 25;
            T2.Enabled = false;
            T2.Tick += T2_Tick;

            this.Show();
        }

        private void T2_Tick(object sender, EventArgs e)
        {
            AV = AV - 0.04f;
            if (AV < 1.0f)
            {
                Opacity = AV;
            }
            if (AV < (-0.5f))
            {
               // this.Close();
                Done = true;
              //  AppForm = new Form1();
             //   AppForm.Show();
            }
        }
        private Form1 AppForm = null;
        private void T1_Tick(object sender, EventArgs e)
        {
            AV = AV + 0.02f;
            if(AV>1.5)
            {
                AV = 1.0f;
                T1.Stop();
                T1.Enabled = false;
                T2.Enabled = true;
                T2.Start();
            }
            if(AV<1.0f)
            {
                this.Opacity = AV;
            }
        }
    }
}
