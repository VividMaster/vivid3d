using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;
using Vivid.Input;

namespace Vivid.UI.UIWidgets
{
    public class UITextEntryLine : UIWidget
    {
        public UITextEntryLine(int x, int y, int w, string def = "", UIWidget top = null) : base(x, y, w, 25, def, top)
        {
            Name = "";
        }
        public override void Draw()
        {
            UISys.Skin().DrawBox((int)WidX, (int)WidY, (int)WidW, (int)WidH);
            UISys.Skin().DrawBoxText((int)WidX + 3, (int)WidY + 3, Name);
        }
        public override void KeyAdd(Key k, bool shift)
        {
            if (k == Key.Minus)
            {
                if (shift)
                {
                    Name += "_";
                }
                else
                {
                    Name += "-";
                }
            }
            if(k == Key.Plus)
            {
                if (shift)
                {
                    Name += "+";
                }
                else
                {
                    Name += "=";
                }
            }
            if(k == Key.Comma)
            {
                if (shift)
                {
                    Name += "<";
                    Console.WriteLine("<");
                }
                else
                {
                    Name += ",";
                }
            }
            if (k == Key.Period)
            {
                if (shift)
                {
                    Name += ">";
                }
                else
                {
                    Name += ".";
                }
            }
            
            if(k == Key.Space)
            {
                Name += " ";
                return;
            }
            if(k == Key.Tab)
            {
                Name += " ";
                return;
            }
            if (VInput.TextKey(k))
            {
                string cs = k.ToString();
                if (cs.Contains("Number"))
                {
                    Console.WriteLine("Number:" + cs);
                    string ac= cs.Substring(6, 1);
                    Console.WriteLine("AC:" + ac);
                    if (shift)
                    {
                        switch(int.Parse(ac))
                        {
                            case 1:
                                ac = "!";
                                break;
                            case 2:
                                ac = "@";
                                break;
                            case 3:
                                ac = "#";
                                break;
                            case 4:
                                ac = "$";
                                break;
                            case 5:
                                ac = "%";
                                break;
                            case 6:
                                ac = "^";
                                break;
                            case 7:
                                ac = "&";
                                break;
                            case 8:
                                ac = "*";
                                break;
                            case 9:
                                ac = "(";
                                break;
                            case 0:
                                ac = ")";
                                break;
                        }
                        Name += ac;
                        return;
                    }
                    else
                    {
                        Name += ac;
                    }
                    return;
                }
                if (shift)
                {
                    Name += k.ToString().ToUpper();
                }
                else
                {
                    Name += k.ToString().ToLower();
                }
            }
        }
        public override void KeyDel()
        {
            if (Name.Length > 1)
            {
                Name = Name.Substring(0, Name.Length - 1);

            }
            else
            {
                Name = "";
            }
                    
                    


        }
    }
}
