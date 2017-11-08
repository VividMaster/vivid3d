using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.App;
using Vivid.Texture;
using System.IO;
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
        public UIFileRequest(string path,string title="Select File") : base(AppInfo.W/2-330,AppInfo.H/2-260,660,520,title,null)
        {
            Folders = new UITreeView(34, 35, 262, 390, "Folders", this);
            Folders.Open = (UIItem n) =>
            {
                if (n.Name == "Drives")
                { }
                else
                {
                    if(n.Sub.Count>0)
                    {
                        n.Sub.Clear();
                    }
                    DirectoryInfo f = new DirectoryInfo(n.Name);
                    Console.WriteLine("Reading Folder:" + n.Name);
                    foreach(var of in f.GetDirectories())
                    {
                        UIItem nf = new UIItem();
                        nf.Name = of.FullName;
                        nf.Open = false;
                        n.Add(nf);
                    }
                    
                }

            };
            Contents = new UIList(315, 35, 300, 390,"Files", this);
            File = new UITextEntryLine(34, 435, 380, "", this);
            OK = new UIButton(34, 470, 100, 30, "OK", this);
            Cancel = new UIButton(160, 470, 100, 30, "Cancel", this);
            Folders.AddItem(new UIItem("Drives")).Add(new UIItem("c:/"));

        }
    }
}
