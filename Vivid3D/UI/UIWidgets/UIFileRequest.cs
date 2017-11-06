using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.App;
using Vivid.Texture;

namespace Vivid.UI.UIWidgets
{
    public class UIFileRequest : UIWindow
    {
        public List<String> Exts = new List<string>();
        public string StartPath = "";
        public UIList Contents;
        public UITextEntryLine File;
        public UIButton OK, Cancel;
        public UITreeView Folders = null;
        public UIFileRequest(string path,string title="Select File") : base(AppInfo.W/2-230,AppInfo.H/2-260,460,520,title,null)
        {
            Folders = new UITreeView(34, 35, 132, 390, "Folders", this);
            Contents = new UIList(180, 35, 240, 390,"Files", this);
            File = new UITextEntryLine(34, 435, 380, "", this);
            OK = new UIButton(34, 470, 100, 30, "OK", this);
            Cancel = new UIButton(160, 470, 100, 30, "Cancel", this);
            Folders.AddItem(new UIItem("Drives")).Add(new UIItem("c:/"));

        }
    }
}
