using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WeifenLuo.WinFormsUI;
namespace VividStudioIDE
{
    public partial class ContentViewer : DockContent
    {
        public ContentViewer()
        {
            InitializeComponent();
            Text = "Content Explorer";
        }
    }
}
