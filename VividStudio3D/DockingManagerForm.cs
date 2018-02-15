#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace VividStudio3D
{
    public partial class DockingManagerForm : MetroForm
    {

        #region Constructor
        public DockingManagerForm()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"..\\..\\\VS.ico"));
                this.Icon = ico;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.BorderThickness = 12;
            this.BorderColor = ColorTranslator.FromHtml("#d6dbe9");
            this.ShowIcon = true;
            this.MetroColor = ColorTranslator.FromHtml("#d6dbe9");
            this.editControl1.ApplyConfiguration("C#");
            this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\DockingManagerForm.cs");
            this.dockingManager1.DragProviderStyle = DragProviderStyle.VS2010;
            this.dockingManager1.SetAsMDIChild(this.dockingClientPanel1, true);
            this.bar1.DrawBackground += bar1_DrawBackground;
            this.dockingManager1.SetAutoHideMode(this.panel5, true);
            this.treeViewAdv1.FullRowSelect = true;
            this.treeViewAdv1.MouseMove += new MouseEventHandler(treeViewAdv1_MouseMove);
            this.treeViewAdv1.MouseLeave += new EventHandler(treeViewAdv1_MouseLeave);
            this.dockingManager1.SetAutoHideOnLoad(this.panel3, true);
            this.Load += new EventHandler(DockingManagerForm_Load);
            this.comboBoxBarItem1.ListBox = new ListBox();
            this.comboBoxBarItem1.ListBox.Items.AddRange(new string[]{"Debug", "Release", "ConfiguartionManager"});
            this.comboBoxBarItem1.TextBoxValue = "Debug";
            this.AddTreeNode();
            this.AddMainFrameBarManagerItem();
            this.AddItemsUnderFile();
            this.AddItemsUnderEdit();
            this.AddItemsUnderView();
            this.AddItemsUnderProject();
            this.AddItemsUnderBuild();
            this.AddItemsUnderDebug();
            this.AddItemsUnderTeam();
            this.AddItemsUnderFormat();
            this.AddItemsUnderTools();
            this.AddItemsUnderTest();
            this.AddItemsUnderAnalyze();
            this.AddItemsUnderWindows();
            this.AddItemsUnderHelp();

            this.comboBoxBarItem1.SizeToFit = true;
            this.comboBoxBarItem1.MinWidth = 75;
            this.comboBoxBarItem1.ListBox.ItemHeight = 50;
            this.comboBoxBarItem1.ListBox.ItemHeight = 100;

            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                       | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                       | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                       | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow)));
           
        }
        #endregion

        #region Variables
        SolutionExplorerView panel5 = null;
        /// <summary>
        /// DropDownItems
        /// </summary>
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem Backward;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem NewProj;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem UndoItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem4;
        
        /// <summary>
        /// BarItems
        /// </summary>
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem nxtButton;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem redoButton;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem simulate;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem findFile;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem displayInfo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem toggleSuggestion;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem commentline;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem uncommentline;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem toggleBookMark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem previousbookMark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem nextBookMark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem removeAllBookMark;
        /// <summary>
        /// ParentBarItems
        /// </summary>
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem viewItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem projectItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem buildItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem debugItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem teamItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem formatItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem toolsItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem testItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem analyzeItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem windowItem;   

        /// <summary>
        /// ComboBoxBarItems
        /// </summary>
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem2;
        /// <summary>
        /// Bars
        /// </summary>
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar3;
        #endregion

        #region Add Items to MainFrameBarManager and TreeViewAdv

        #region Add Items To Bars
        public void AddMainFrameBarManagerItem()
        {
            // 
            // dropDownBarItem1
            // 
            this.Backward = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.Backward.BarName = "BackButton";
            this.Backward.CategoryIndex = 0;
            this.Backward.ID = "BackButton";
            this.Backward.ImageList = this.imageList2;
            this.Backward.ImageIndex = 0;
            this.Backward.ShowToolTipInPopUp = false;
            this.Backward.SizeToFit = true;
            this.Backward.Text = "Navigate Backward(Ctrl+-)";            
           
            // 
            // nxtButton
            // 
            this.nxtButton = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.nxtButton.BarName = "Next";
            this.nxtButton.CategoryIndex = 1;
            this.nxtButton.ID = "";
            this.nxtButton.ImageList = this.imageList2;
            this.nxtButton.ImageIndex = 1;
            this.nxtButton.ShowToolTipInPopUp = false;
            this.nxtButton.SizeToFit = true;
            this.nxtButton.Text = "Navigate Forward(Ctrl+Shift+-)";

            // 
            // dropDownBarItem2
            // 
            this.NewProj = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.NewProj.BarName = "BackButton";
            this.NewProj.CategoryIndex = 0;
            this.NewProj.ID = "FirstItem";
            this.NewProj.ImageList = this.imageList2;
            this.NewProj.ImageIndex = 2;
            this.NewProj.ShowToolTipInPopUp = false;
            this.NewProj.SizeToFit = true;
            this.NewProj.Text = "New Project(Ctrl+Shift+N)";

            //Open
            this.m_open.ImageList = this.imageList2;
            this.m_open.ImageIndex = 3;
            this.m_open.Text = "Open File(Ctrl+O)";
            //Save
            this.m_Save.ImageList = this.imageList2;
            this.m_Save.ImageIndex = 4;
            this.m_Save.Text = "Save(Ctrl+S)";
            //Save All
            this.m_SaveAll.ImageList = this.imageList2;
            this.m_SaveAll.ImageIndex = 5;
            this.m_SaveAll.Text = "Save All(Ctrl+Shift+S)";
            //Undo
            // 
            // dropDownBarItem3
            // 
            this.UndoItem = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.UndoItem.BarName = "Undo";
            this.UndoItem.CategoryIndex = 0;
            this.UndoItem.ID = "UndoItem";
            this.UndoItem.ImageList = this.imageList2;
            this.UndoItem.ImageIndex = 6;
            this.UndoItem.ShowToolTipInPopUp = false;
            this.UndoItem.SizeToFit = true;
            this.UndoItem.Text = "Undo (Ctrl+Z)";
            // 
            // redoButton
            // 
            this.redoButton = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.redoButton.BarName = "Redo";
            this.redoButton.CategoryIndex = 1;
            this.redoButton.ID = "";
            this.redoButton.ImageList = this.imageList2;
            this.redoButton.ImageIndex = 7;
            this.redoButton.ShowToolTipInPopUp = false;
            this.redoButton.SizeToFit = true;
            this.redoButton.Text = "Redo (Ctrl+Y)";
            //Start
            this.m_Start.ImageList = this.imageList2;
            this.m_Start.ImageIndex = 8;
            this.m_Start.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            //Browser Link

            // 
            // dropDownBarItem2
            // 
            this.dropDownBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.dropDownBarItem4.BarName = "BackButton";
            this.dropDownBarItem4.CategoryIndex = 0;
            this.dropDownBarItem4.ID = "FirstItem";
            this.dropDownBarItem4.ImageList = this.imageList2;
            this.dropDownBarItem4.ImageIndex = 9;
            this.dropDownBarItem4.ShowToolTipInPopUp = false;
            this.dropDownBarItem4.SizeToFit = true;
            this.dropDownBarItem4.Text = "Browser Link";
            //ComboBoxBarItem2
            this.comboBoxBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.comboBoxBarItem2.ListBox = new ListBox();
            this.comboBoxBarItem2.ListBox.Items.AddRange(new string[] { "Any CPU", "Configuration Manager"});
            this.comboBoxBarItem2.TextBoxValue = "Any CPU";             
            this.comboBoxBarItem2.BarName = "comboBoxBarItem1";
            this.comboBoxBarItem2.CategoryIndex = 1;
            this.comboBoxBarItem2.ID = "Debug";
            this.comboBoxBarItem2.ShowToolTipInPopUp = false;
            this.comboBoxBarItem2.SizeToFit = true;
            this.comboBoxBarItem2.MinWidth = 100;
            // 
            // Simulate button
            // 
            this.simulate = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.simulate.BarName = "Simulation";
            this.simulate.CategoryIndex = 1;
            this.simulate.ID = "";
            this.simulate.ImageList = this.imageList2;
            this.simulate.ImageIndex = 10;
            this.simulate.ShowToolTipInPopUp = false;
            this.simulate.SizeToFit = true;
            this.simulate.Text = "Simulation Dashboard";
            // 
            // Find Files
            // 
            this.findFile = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.findFile.BarName = "Find";
            this.findFile.CategoryIndex = 11;
            this.findFile.ID = "";
            this.findFile.ImageList = this.imageList2;
            this.findFile.ImageIndex = 11;
            this.findFile.ShowToolTipInPopUp = false;
            this.findFile.SizeToFit = true;
            this.findFile.Text = "Find in Files(Ctrl+Shift+F)";

            // DisplayQuickInfo
            // 
            this.displayInfo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.displayInfo.BarName = "DisplayInfo";
            this.displayInfo.CategoryIndex = 1;
            this.displayInfo.ID = "";
            this.displayInfo.ImageList = this.imageList2;
            this.displayInfo.ImageIndex = 12;
            this.displayInfo.ShowToolTipInPopUp = false;
            this.displayInfo.SizeToFit = true;
            this.displayInfo.Text = "Display Quick Info";
            // Toggle Suggestions
            // 
            this.toggleSuggestion = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.toggleSuggestion.BarName = "ToggleSuggestion";
            this.toggleSuggestion.CategoryIndex = 1;
            this.toggleSuggestion.ID = "";
            this.toggleSuggestion.ImageList = this.imageList2;
            this.toggleSuggestion.ImageIndex = 13;
            this.toggleSuggestion.ShowToolTipInPopUp = false;
            this.toggleSuggestion.SizeToFit = true;
            this.toggleSuggestion.Text = "Toggle between suggestion and standard compilation Mode";

            // commentLine
            // 
            this.commentline = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.commentline.BarName = "Next";
            this.commentline.CategoryIndex = 1;
            this.commentline.ID = "";
            this.commentline.ImageList = this.imageList2;
            this.commentline.ImageIndex = 14;
            this.commentline.ShowToolTipInPopUp = false;
            this.commentline.SizeToFit = true;
            this.commentline.Text = "Comment out the selected lines.";
            // uncommentline
            // 
            this.uncommentline = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.uncommentline.BarName = "Uncommentline";
            this.uncommentline.CategoryIndex = 1;
            this.uncommentline.ID = "";
            this.uncommentline.ImageList = this.imageList2;
            this.uncommentline.ImageIndex = 15;
            this.uncommentline.ShowToolTipInPopUp = false;
            this.uncommentline.SizeToFit = true;
            this.uncommentline.Text = "Uncomment the selected lines.";
            // BookMark
            // 
            this.toggleBookMark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.toggleBookMark.BarName = "toggleBookMark";
            this.toggleBookMark.CategoryIndex = 1;
            this.toggleBookMark.ID = "";
            this.toggleBookMark.ImageList = this.imageList2;
            this.toggleBookMark.ImageIndex = 16;
            this.toggleBookMark.ShowToolTipInPopUp = false;
            this.toggleBookMark.SizeToFit = true;
            this.toggleBookMark.Text = "Toggle a bookmark on current line.";

            // PreviousBookMark
            // 
            this.previousbookMark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.previousbookMark.BarName = "PreviousBookMark";
            this.previousbookMark.CategoryIndex = 1;
            this.previousbookMark.ID = "";
            this.previousbookMark.ImageList = this.imageList2;
            this.previousbookMark.ImageIndex = 17;
            this.previousbookMark.ShowToolTipInPopUp = false;
            this.previousbookMark.SizeToFit = true;
            this.previousbookMark.Text = "Move the caret to the previous bookmark. (Ctrl+K, Ctrl+P)";

            // nxtBookMark
            // 
            this.nextBookMark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.nextBookMark.BarName = "NextBookMark";
            this.nextBookMark.CategoryIndex = 1;
            this.nextBookMark.ID = "";
            this.nextBookMark.ImageList = this.imageList2;
            this.nextBookMark.ImageIndex = 18;
            this.nextBookMark.ShowToolTipInPopUp = false;
            this.nextBookMark.SizeToFit = true;
            this.nextBookMark.Text = "Move the caret to the next bookmark.(Ctrl+K, Ctrl+N)";

            // removeBookMarl
            // 
            this.removeAllBookMark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.removeAllBookMark.BarName = "RemoveBookMark";
            this.removeAllBookMark.CategoryIndex = 1;
            this.removeAllBookMark.ID = "";
            this.removeAllBookMark.ImageList = this.imageList2;
            this.removeAllBookMark.ImageIndex = 19;
            this.removeAllBookMark.ShowToolTipInPopUp = false;
            this.removeAllBookMark.SizeToFit = true;
            this.removeAllBookMark.Text = "Clear all bookmark in all files.";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.Backward,
            this.nxtButton,
            this.NewProj,
            this.m_open,
            this.m_Save,
            this.m_SaveAll,
            this.UndoItem,
            this.redoButton,
            this.m_Start,
            this.comboBoxBarItem1,
            this.dropDownBarItem4,
            this.comboBoxBarItem2,
            this.simulate});

            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Icons");
            // 
            // bar2
            // 
            this.bar2.BarName = "Icons";
            this.bar2.Caption = "Icons";
            this.bar2.Manager = this.mainFrameBarManager1;
            this.mainFrameBarManager1.Bars.Add(this.bar2);

            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.Backward,
            this.nxtButton,
            this.NewProj,
            this.m_open,
            this.m_Save,
            this.m_SaveAll,
            this.UndoItem,
            this.redoButton,
            this.m_Start,
            this.dropDownBarItem4,
            this.comboBoxBarItem1,
            this.comboBoxBarItem2,
            this.simulate,
            this.findFile
            });
            

            // 
            // bar3
            // 
            this.bar3 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Text Editor");
            this.bar3.BarName = "Text Editor";
            this.bar3.Caption = "Text Editor";
            this.bar3.Manager = this.mainFrameBarManager1;
            this.mainFrameBarManager1.Bars.Add(this.bar3);
            this.bar3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.displayInfo,
            this.toggleSuggestion,
            this.commentline,
            this.uncommentline,
            this.toggleBookMark,
            this.nextBookMark,
            this.previousbookMark,
            this.removeAllBookMark
            });
            this.bar2.SeparatorIndices.AddRange(new int[] {
            2,6,8,12,13});
            this.bar3.SeparatorIndices.AddRange(new int[] {
            2,4});
        }
        #endregion

        #region Add Nodes To TreeViewAdv
        public void AddTreeNode()
        {
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv25 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv26 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv27 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv28 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv29 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv30 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv31 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv32 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv33 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv34 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();

            this.viewItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.projectItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.buildItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.debugItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.teamItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.formatItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.testItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.toolsItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.testItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.analyzeItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.windowItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();

            treeNodeAdv25.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv25.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.LeftImageIndices = new int[] { 5 };
            treeNodeAdv25.MultiLine = true;
            treeNodeAdv25.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv25.ShowLine = true;
            treeNodeAdv25.Text = "EditControl";
            treeNodeAdv26.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv26.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.LeftImageIndices = new int[] { 6 };
            treeNodeAdv26.MultiLine = true;
            treeNodeAdv26.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv26.ShowLine = true;
            treeNodeAdv26.Text = "RadialGauge";
            treeNodeAdv27.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv27.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.LeftImageIndices = new int[] { 7 };
            treeNodeAdv27.MultiLine = true;
            treeNodeAdv27.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv27.ShowLine = true;
            treeNodeAdv27.Text = "RadialGauge";
            treeNodeAdv28.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv28.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.LeftImageIndices = new int[] { 0 };
            treeNodeAdv28.MultiLine = true;
            treeNodeAdv28.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv28.ShowLine = true;
            treeNodeAdv28.Text = "DigitalGauge";
            treeNodeAdv29.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv29.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.LeftImageIndices = new int[] { 1 };
            treeNodeAdv29.MultiLine = true;
            treeNodeAdv29.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv29.ShowLine = true;
            treeNodeAdv29.Text = "LinearGauge";
            treeNodeAdv30.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv30.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.LeftImageIndices = new int[] { 2 };
            treeNodeAdv30.MultiLine = true;
            treeNodeAdv30.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv30.ShowLine = true;
            treeNodeAdv30.Text = "HTMLUIControl";
            treeNodeAdv31.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv31.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.LeftImageIndices = new int[] { 3 };
            treeNodeAdv31.MultiLine = true;
            treeNodeAdv31.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv31.ShowLine = true;
            treeNodeAdv31.Text = "GridControl";

            this.treeViewAdv1.Nodes[1].Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            
            treeNodeAdv25,
            treeNodeAdv26,
            treeNodeAdv27,
        treeNodeAdv28,
            treeNodeAdv29,
            treeNodeAdv30});
            // 
            // viewItem
            // 
            this.viewItem.BarName = "viewItem";
            this.viewItem.CategoryIndex = 0;
            this.viewItem.ID = "View";
            this.viewItem.ShowToolTipInPopUp = false;
            this.viewItem.SizeToFit = true;
            this.viewItem.Text = "&VIEW";
            // 
            // buildItem
            // 
            this.buildItem.BarName = "buildItem";
            this.buildItem.CategoryIndex = 0;
            this.buildItem.ID = "BUILD";
            this.buildItem.ShowToolTipInPopUp = false;
            this.buildItem.SizeToFit = true;
            this.buildItem.Text = "&BUILD";
            // 
            // debugItem
            // 
            this.debugItem.BarName = "debugItem";
            this.debugItem.CategoryIndex = 0;
            this.debugItem.ID = "DEBUG";
            this.debugItem.ShowToolTipInPopUp = false;
            this.debugItem.SizeToFit = true;
            this.debugItem.Text = "&DEBUG";
            // 
            // teamItem
            // 
            this.teamItem.BarName = "TeamItem";
            this.teamItem.CategoryIndex = 0;
            this.teamItem.ID = "Team";
            this.teamItem.ShowToolTipInPopUp = false;
            this.teamItem.SizeToFit = true;
            this.teamItem.Text = "TEA&M";
            // 
            // formatItem
            // 
            this.formatItem.BarName = "FORMATiTEM";
            this.formatItem.CategoryIndex = 0;
            this.formatItem.ID = "FORMAT";
            this.formatItem.ShowToolTipInPopUp = false;
            this.formatItem.SizeToFit = true;
            this.formatItem.Text = "F&ORMAT";
            
            // 
            // ToolsItem
            // 
            this.toolsItem.BarName = "toolsItem";
            this.toolsItem.CategoryIndex = 0;
            this.toolsItem.ID = "Tools";
            this.toolsItem.ShowToolTipInPopUp = false;
            this.toolsItem.SizeToFit = true;
            this.toolsItem.Text = "&TOOLS";
            // 
            // TestItem
            // 
            this.testItem.BarName = "testItem";
            this.testItem.CategoryIndex = 0;
            this.testItem.ID = "TEST";
            this.testItem.ShowToolTipInPopUp = false;
            this.testItem.SizeToFit = true;
            this.testItem.Text = "TE&ST";
            // 
            // AnalyzeItem
            // 
            this.analyzeItem.BarName = "analyzeItem";
            this.analyzeItem.CategoryIndex = 0;
            this.analyzeItem.ID = "Analyze";
            this.analyzeItem.ShowToolTipInPopUp = false;
            this.analyzeItem.SizeToFit = true;
            this.analyzeItem.Text = "&ANALYZE";
            // 
            // debugItem
            // 
            this.debugItem.BarName = "debugItem";
            this.debugItem.CategoryIndex = 0;
            this.debugItem.ID = "DEBUG";
            this.debugItem.ShowToolTipInPopUp = false;
            this.debugItem.SizeToFit = true;
            this.debugItem.Text = "&DEBUG";
            // 
            // projectItem
            // 
            this.projectItem.BarName = "projectItem";
            this.projectItem.CategoryIndex = 0;
            this.projectItem.ID = "PROJECT";
            this.projectItem.ShowToolTipInPopUp = false;
            this.projectItem.SizeToFit = true;
            this.projectItem.Text = "&PROJECT";

            // 
            // viewItem
            // 
            this.viewItem.BarName = "viewItem";
            this.viewItem.CategoryIndex = 0;
            this.viewItem.ID = "View";
            this.viewItem.ShowToolTipInPopUp = false;
            this.viewItem.SizeToFit = true;
            this.viewItem.Text = "&VIEW";
            // 
            // buildItem
            // 
            this.buildItem.BarName = "buildItem";
            this.buildItem.CategoryIndex = 0;
            this.buildItem.ID = "BUILD";
            this.buildItem.ShowToolTipInPopUp = false;
            this.buildItem.SizeToFit = true;
            this.buildItem.Text = "&BUILD";
            // 
            // debugItem
            // 
            this.debugItem.BarName = "debugItem";
            this.debugItem.CategoryIndex = 0;
            this.debugItem.ID = "DEBUG";
            this.debugItem.ShowToolTipInPopUp = false;
            this.debugItem.SizeToFit = true;
            this.debugItem.Text = "&DEBUG";

            // 
            // ToolsItem
            // 
            this.toolsItem.BarName = "toolsItem";
            this.toolsItem.CategoryIndex = 0;
            this.toolsItem.ID = "Tools";
            this.toolsItem.ShowToolTipInPopUp = false;
            this.toolsItem.SizeToFit = true;
            this.toolsItem.Text = "&TOOLS";         
            // 
            // debugItem
            // 
            this.debugItem.BarName = "debugItem";
            this.debugItem.CategoryIndex = 0;
            this.debugItem.ID = "DEBUG";
            this.debugItem.ShowToolTipInPopUp = false;
            this.debugItem.SizeToFit = true;
            this.debugItem.Text = "&DEBUG";
            // 
            // projectItem
            // 
            this.projectItem.BarName = "projectItem";
            this.projectItem.CategoryIndex = 0;
            this.projectItem.ID = "PROJECT";
            this.projectItem.ShowToolTipInPopUp = false;
            this.projectItem.SizeToFit = true;
            this.projectItem.Text = "&PROJECT";

            this.treeViewAdv1.Nodes[1].Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
           
            treeNodeAdv25,
            treeNodeAdv26,
            treeNodeAdv27,
        treeNodeAdv28,
            treeNodeAdv29,
            treeNodeAdv30});

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.viewItem,
            this.projectItem,
            this.buildItem,
            this.debugItem,
            this.barItem3,
            this.formatItem,
            this.toolsItem,
            this.testItem,
            this.analyzeItem,            
            this.windowItem
            });

            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
          
            this.viewItem,             
            this.projectItem,
            this.buildItem,
            this.debugItem,            
            this.teamItem,
            this.formatItem,
            this.toolsItem,            
            this.testItem,
            this.analyzeItem,
            this.barItem4,
            this.barItem5});
        }
        #endregion


        #region Items under FilebarItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem m_new;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem m_openFile;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem addToSourceCotrol;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem saveAll;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Exit;
        
        public void AddItemsUnderFile()
        {
            // 
            // parentBarItem1
            // 
            this.m_new = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.m_new.BarName = "parentBarItem1";
            this.m_new.CategoryIndex = 0;
            this.m_new.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_new.ID = "New";
            this.m_new.ImageIndex = 96;
            this.m_new.ImageList = this.imageList1;

            this.m_new.ShowToolTipInPopUp = false;
            this.m_new.SizeToFit = true;
            this.m_new.Text = "&New";
            this.m_new.ImageList = this.imageList3;
            this.m_new.ImageIndex = 96;

            // 
            // parentBarItem2
            // 
            this.m_openFile = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.m_openFile.BarName = "parentBarItem2";
            this.m_openFile.CategoryIndex = 0;
            this.m_openFile.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_openFile.ID = "New";
            this.m_openFile.ImageIndex = 96;
            this.m_openFile.ImageList = this.imageList1;
            this.m_openFile.ShowToolTipInPopUp = false;
            this.m_openFile.SizeToFit = true;
            this.m_openFile.Text = "&Open";

            // 
            // addToSourceCotrol
            // 
            this.addToSourceCotrol = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.addToSourceCotrol.BarName = "addToSourceCotrol";
            this.addToSourceCotrol.CategoryIndex = 1;
            this.addToSourceCotrol.ID = "";
            this.addToSourceCotrol.ShowToolTipInPopUp = false;
            this.addToSourceCotrol.SizeToFit = true;
            this.addToSourceCotrol.Text = "Add To Source Control";
            this.addToSourceCotrol.ImageList = this.imageList3;
            this.addToSourceCotrol.ImageIndex = 56;
            ///
            /// Save All
            ///
            this.saveAll = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.saveAll.BarName = "SaveAll";
            this.saveAll.CategoryIndex = 1;
            this.saveAll.ID = "";
            this.saveAll.ShowToolTipInPopUp = false;
            this.saveAll.SizeToFit = true;
            this.saveAll.Text = "Save All            (Ctrl+Shift+S)";
            this.saveAll.ImageList = this.imageList2;
            this.saveAll.ImageIndex = 5;

            ///
            /// Exit 
            ///
            this.Exit = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Exit.BarName = "Exit";
            this.Exit.CategoryIndex = 1;
            this.Exit.ID = "";
            this.Exit.ShowToolTipInPopUp = false;
            this.Exit.SizeToFit = true;
            this.Exit.Text = "Exit                   (Alt+F4)";
            this.Exit.Click += new EventHandler(Exit_Click);

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.m_new,
            this.m_openFile,
            this.addToSourceCotrol,
            this.saveAll,
            this.Exit});

            this.FileItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
                this.m_new,
                this.m_openFile,
            this.addToSourceCotrol,
            this.saveAll,
            this.Exit});

            this.FileItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");

        }

        void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Items under EditbarItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem undo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem redo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem cut;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem copy;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem pasteSpecial;

        public void AddItemsUnderEdit()
        {
            // 
            // undo
            // 
            this.undo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.undo.BarName = "Undo";
            this.undo.CategoryIndex = 1;            
            this.undo.ID = "Undo";
            this.undo.ShowToolTipInPopUp = false;
            this.undo.SizeToFit = true;
            this.undo.Text = "&Undo";
            this.undo.ImageList = this.imageList2;
            this.undo.ImageIndex = 6;
            // 
            // redo
            // 
            this.redo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.redo.BarName = "Redo";
            this.redo.CategoryIndex = 1;           
            this.redo.ID = "Redo";
            this.redo.ShowToolTipInPopUp = false;
            this.redo.SizeToFit = true;
            this.redo.Text = "&Redo";
            this.redo.ImageList = this.imageList2;
            this.redo.ImageIndex = 7;
            // 
            // Cut
            // 
            this.cut = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.cut.BarName = "addToSourceCotrol";
            this.cut.CategoryIndex = 1;
            this.cut.ID = "";
            this.cut.ShowToolTipInPopUp = false;
            this.cut.SizeToFit = true;
            this.cut.Text = "Cut";
            this.cut.ImageList = this.imageList4;
            this.cut.ImageIndex = 39;

            ///
            /// Copy
            ///
            this.copy = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.copy.BarName = "SaveAll";
            this.copy.CategoryIndex = 1;
            this.copy.ID = "";
            this.copy.ShowToolTipInPopUp = false;
            this.copy.SizeToFit = true;
            this.copy.Text = "Copy           (Ctrl+Shift+S)";
            this.copy.ImageList = this.imageList4;
            this.copy.ImageIndex = 35;
            ///
            /// Paste 
            ///
            this.pasteSpecial = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.pasteSpecial.BarName = "Exit";
            this.pasteSpecial.CategoryIndex = 1;
            this.pasteSpecial.ID = "";
            this.pasteSpecial.ShowToolTipInPopUp = false;
            this.pasteSpecial.SizeToFit = true;
            this.pasteSpecial.Text = "Paste Special           (Alt+F4)";
            this.pasteSpecial.ImageList = this.imageList4;
            this.pasteSpecial.ImageIndex = 25;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.undo,
            this.redo,
            this.cut,
            this.copy,
            this.pasteSpecial});

            this.EditItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
                this.undo,
            this.redo,
            this.cut,
            this.copy,
            this.pasteSpecial}); ;

            this.EditItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under View barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Code;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Designer;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Open;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SolutionExplorer;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem TeamExplorer;

        public void AddItemsUnderView()
        {
            // 
            // Code
            // 
            this.Code = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Code.BarName = "Undo";
            this.Code.CategoryIndex = 1;
            this.Code.ID = "Undo";
            this.Code.ShowToolTipInPopUp = false;
            this.Code.SizeToFit = true;
            this.Code.Text = "Code";

            // 
            // Designer
            // 
            this.Designer = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Designer.BarName = "Redo";
            this.Designer.CategoryIndex = 1;
            this.Designer.ID = "Redo";
            this.Designer.ShowToolTipInPopUp = false;
            this.Designer.SizeToFit = true;
            this.Designer.Text = "Designer";

            // 
            // Open
            // 
            this.Open = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Open.BarName = "addToSourceCotrol";
            this.Open.CategoryIndex = 1;
            this.Open.ID = "";
            this.Open.ShowToolTipInPopUp = false;
            this.Open.SizeToFit = true;
            this.Open.Text = "Open";
            this.Open.ImageList = this.imageList2;
            this.Open.ImageIndex = 3;

            ///
            /// SolutionExplorer
            ///
            this.SolutionExplorer = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.SolutionExplorer.BarName = "SolutionExplorer";
            this.SolutionExplorer.CategoryIndex = 1;
            this.SolutionExplorer.ID = "";
            this.SolutionExplorer.ShowToolTipInPopUp = false;
            this.SolutionExplorer.SizeToFit = true;
            this.SolutionExplorer.Text = "SolutionExplorer        (Ctrl+Shift+S)";
            this.SolutionExplorer.ImageIndex = 60;
            this.SolutionExplorer.ImageList = this.imageList3;

            ///
            /// Team Explorer 
            ///
            this.TeamExplorer = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.TeamExplorer.BarName = "TeamExplorer";
            this.TeamExplorer.CategoryIndex = 1;
            this.TeamExplorer.ID = "";
            this.TeamExplorer.ShowToolTipInPopUp = false;
            this.TeamExplorer.SizeToFit = true;
            this.TeamExplorer.Text = "TeamExplorer         (Alt+F4)";
            this.TeamExplorer.ImageIndex = 58;
            this.TeamExplorer.ImageList = this.imageList3;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.Code,
            this.Designer,
            this.Open,
            this.SolutionExplorer,
            this.TeamExplorer});

            this.viewItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
             this.Code,
            this.Designer,
            this.Open,
            this.SolutionExplorer,
            this.TeamExplorer}); ;

            this.viewItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Project barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem WindowsForms;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem UserControl;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Component;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem addclass;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem newDataSource;

        public void AddItemsUnderProject()
        {
            // 
            // WindowsForms
            // 
            this.WindowsForms = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.WindowsForms.BarName = "WindowsForms";
            this.WindowsForms.CategoryIndex = 1;
            this.WindowsForms.ID = "WindowsForms";
            this.WindowsForms.ShowToolTipInPopUp = false;
            this.WindowsForms.SizeToFit = true;
            this.WindowsForms.Text = "Add Windows Forms...";
            this.WindowsForms.ImageIndex = 69;
            this.WindowsForms.ImageList = this.imageList3;
            // 
            // UserControl
            // 
            this.UserControl = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.UserControl.BarName = "Redo";
            this.UserControl.CategoryIndex = 1;
            this.UserControl.ID = "Redo";
            this.UserControl.ShowToolTipInPopUp = false;
            this.UserControl.SizeToFit = true;
            this.UserControl.Text = "Add User Control...";
            this.UserControl.ImageIndex = 68;
            this.UserControl.ImageList = this.imageList3;

            // 
            // Component
            // 
            this.Component = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Component.BarName = "addToSourceCotrol";
            this.Component.CategoryIndex = 1;
            this.Component.ID = "";
            this.Component.ShowToolTipInPopUp = false;
            this.Component.SizeToFit = true;
            this.Component.Text = "Add Component...";
            this.Component.ImageIndex = 65;
            this.Component.ImageList = this.imageList3;
            ///
            /// addclass
            ///
            this.addclass = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.addclass.BarName = "addclass";
            this.addclass.CategoryIndex = 1;
            this.addclass.ID = "";
            this.addclass.ShowToolTipInPopUp = false;
            this.addclass.SizeToFit = true;
            this.addclass.Text = "Add Class...";
            this.addclass.ImageIndex = 64;
            this.addclass.ImageList = this.imageList3;

            ///
            /// newDataSource
            ///
            this.newDataSource = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.newDataSource.BarName = "TeamExplorer";
            this.newDataSource.CategoryIndex = 1;
            this.newDataSource.ID = "";
            this.newDataSource.ShowToolTipInPopUp = false;
            this.newDataSource.SizeToFit = true;
            this.newDataSource.Text = "Add New Data Source...";
            

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.WindowsForms,
            this.UserControl,
            this.Component,
            this.addclass,
            this.newDataSource});

            this.projectItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.WindowsForms,
            this.UserControl,
            this.Component,
            this.addclass,
            this.newDataSource}); ;

            this.projectItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Build barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem build;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem rebuild;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem clean;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem batchbuild;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem configManager;

        public void AddItemsUnderBuild()
        {
            // 
            // build
            // 
            this.build = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.build.BarName = "build";
            this.build.CategoryIndex = 1;
            this.build.ID = "build";
            this.build.ShowToolTipInPopUp = false;
            this.build.SizeToFit = true;
            this.build.Text = "Build Solution                          Ctrl+Shift+B";
            this.build.ImageIndex = 72;
            this.build.ImageList = this.imageList3;
            // 
            // rebuild
            // 
            this.rebuild = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.rebuild.BarName = "rebuild";
            this.rebuild.CategoryIndex = 1;
            this.rebuild.ID = "rebuild";
            this.rebuild.ShowToolTipInPopUp = false;
            this.rebuild.SizeToFit = true;
            this.rebuild.Text = "Rebuild Solution";

            // 
            // Clean
            // 
            this.clean = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.clean.BarName = "clean";
            this.clean.CategoryIndex = 1;
            this.clean.ID = "";
            this.clean.ShowToolTipInPopUp = false;
            this.clean.SizeToFit = true;
            this.clean.Text = "Clean Solution";

            ///
            /// batchbuild
            ///
            this.batchbuild = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.batchbuild.BarName = "batchbuild";
            this.batchbuild.CategoryIndex = 1;
            this.batchbuild.ID = "";
            this.batchbuild.ShowToolTipInPopUp = false;
            this.batchbuild.SizeToFit = true;
            this.batchbuild.Text = "Batch Build...";
            this.batchbuild.ImageIndex = 72;
            this.batchbuild.ImageList = this.imageList3;

            ///
            /// configManager
            ///
            this.configManager = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.configManager.BarName = "configManager";
            this.configManager.CategoryIndex = 1;
            this.configManager.ID = "configManager";
            this.configManager.ShowToolTipInPopUp = false;
            this.configManager.SizeToFit = true;
            this.configManager.Text = "Configuration Manager";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.build,
            this.rebuild,
            this.clean,
            this.batchbuild,
            this.configManager});

            this.buildItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.build,
            this.rebuild,
            this.clean,
            this.batchbuild,
            this.configManager}); ;

            this.buildItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Debug barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem startdebug;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem WoDebug;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem attachtoprocess;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem othertarget;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem breakonclr;

        public void AddItemsUnderDebug()
        {
            // 
            // startdebug
            // 
            this.startdebug = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.startdebug.BarName = "Undo";
            this.startdebug.CategoryIndex = 1;
            this.startdebug.ID = "Undo";
            this.startdebug.ShowToolTipInPopUp = false;
            this.startdebug.SizeToFit = true;
            this.startdebug.Text = "Start Debugging";
            this.startdebug.ImageIndex = 113;
            this.startdebug.ImageList = this.imageList3;
            // 
            // WoDebug
            // 
            this.WoDebug = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.WoDebug.BarName = "Redo";
            this.WoDebug.CategoryIndex = 1;
            this.WoDebug.ID = "Redo";
            this.WoDebug.ShowToolTipInPopUp = false;
            this.WoDebug.SizeToFit = true;
            this.WoDebug.Text = "Start Without Debugging";
            this.WoDebug.ImageIndex = 81;
            this.WoDebug.ImageList = this.imageList3;
            // 
            // attachtoprocess
            // 
            this.attachtoprocess = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.attachtoprocess.BarName = "addToSourceCotrol";
            this.attachtoprocess.CategoryIndex = 1;
            this.attachtoprocess.ID = "";
            this.attachtoprocess.ShowToolTipInPopUp = false;
            this.attachtoprocess.SizeToFit = true;
            this.attachtoprocess.Text = "Attach to Process...";
            this.attachtoprocess.ImageIndex = 74;
            this.attachtoprocess.ImageList = this.imageList3;

            ///
            /// othertarget
            ///
            this.othertarget = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.othertarget.BarName = "othertarget";
            this.othertarget.CategoryIndex = 1;
            this.othertarget.ID = "";
            this.othertarget.ShowToolTipInPopUp = false;
            this.othertarget.SizeToFit = true;
            this.othertarget.Text = "Other Debug Targets";

            ///
            /// breakonclr
            ///
            this.breakonclr = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.breakonclr.BarName = "breakonclr";
            this.breakonclr.CategoryIndex = 1;
            this.breakonclr.ID = "";
            this.breakonclr.ShowToolTipInPopUp = false;
            this.breakonclr.SizeToFit = true;
            this.breakonclr.Text = "Break On All CLR Exceptions";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.startdebug,
            this.WoDebug,
            this.attachtoprocess,
            this.othertarget,
            this.breakonclr});

            this.debugItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.startdebug,
            this.WoDebug,
            this.attachtoprocess,
            this.othertarget,
            this.breakonclr}); ;

            this.debugItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Team barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem connectTeam;

        public void AddItemsUnderTeam()
        {
            // 
            // connectTeam
            // 
            this.connectTeam = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.connectTeam.BarName = "connectTeam";
            this.connectTeam.CategoryIndex = 1;
            this.connectTeam.ID = "connectTeam";
            this.connectTeam.ShowToolTipInPopUp = false;
            this.connectTeam.SizeToFit = true;
            this.connectTeam.Text = "Connect to Team Foundation Server...";
            this.connectTeam.ImageIndex = 91;
            this.connectTeam.ImageList = this.imageList3;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.connectTeam});

            this.teamItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.connectTeam}); ;

            this.teamItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Format barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem align;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem samesize;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem hzlSpacing;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem verticalspacing;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem lckControls;

        public void AddItemsUnderFormat()
        {
            // 
            // align
            // 
            this.align = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.align.BarName = "align";
            this.align.CategoryIndex = 1;
            this.align.ID = "align";
            this.align.ShowToolTipInPopUp = false;
            this.align.SizeToFit = true;
            this.align.Text = "Align";

            // 
            // samesize
            // 
            this.samesize = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.samesize.BarName = "samesize";
            this.samesize.CategoryIndex = 1;
            this.samesize.ID = "samesize";
            this.samesize.ShowToolTipInPopUp = false;
            this.samesize.SizeToFit = true;
            this.samesize.Text = "Make Same Size";

            // 
            // hzlSpacing
            // 
            this.hzlSpacing = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.hzlSpacing.BarName = "hzlSpacing";
            this.hzlSpacing.CategoryIndex = 1;
            this.hzlSpacing.ID = "hzlSpacing";
            this.hzlSpacing.ShowToolTipInPopUp = false;
            this.hzlSpacing.SizeToFit = true;
            this.hzlSpacing.Text = "Horizontal Spacing";

            ///
            /// verticalspacing
            ///
            this.verticalspacing = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.verticalspacing.BarName = "verticalspacing";
            this.verticalspacing.CategoryIndex = 1;
            this.verticalspacing.ID = "verticalspacing";
            this.verticalspacing.ShowToolTipInPopUp = false;
            this.verticalspacing.SizeToFit = true;
            this.verticalspacing.Text = "Vertical Spacing";

            ///
            /// lckControls
            ///
            this.lckControls = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.lckControls.BarName = "lckControls";
            this.lckControls.CategoryIndex = 1;
            this.lckControls.ID = "lckControls";
            this.lckControls.ShowToolTipInPopUp = false;
            this.lckControls.SizeToFit = true;
            this.lckControls.Text = "Lock Controls";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.align,
            this.samesize,
            this.hzlSpacing,
            this.verticalspacing,
            this.lckControls});

            this.formatItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.align,
            this.samesize,
            this.hzlSpacing,
            this.verticalspacing,
            this.lckControls}); ;

            this.formatItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Tools barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem WinPhone;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem attachprocess;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem conectDB;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem connectserver;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem addsharept;

        public void AddItemsUnderTools()
        {
            // 
            // WinPhone
            // 
            this.WinPhone = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.WinPhone.BarName = "Undo";
            this.WinPhone.CategoryIndex = 1;
            this.WinPhone.ID = "Undo";
            this.WinPhone.ShowToolTipInPopUp = false;
            this.WinPhone.SizeToFit = true;
            this.WinPhone.Text = "Windows Phone 8.1";

            // 
            // attachprocess
            // 
            this.attachprocess = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.attachprocess.BarName = "attachprocess";
            this.attachprocess.CategoryIndex = 1;
            this.attachprocess.ID = "attachprocess";
            this.attachprocess.ShowToolTipInPopUp = false;
            this.attachprocess.SizeToFit = true;
            this.attachprocess.Text = "Attach to Process                            Ctrl+Alt+P";

            // 
            // conectDB
            // 
            this.conectDB = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.conectDB.BarName = "conectDB";
            this.conectDB.CategoryIndex = 1;
            this.conectDB.ID = "";
            this.conectDB.ShowToolTipInPopUp = false;
            this.conectDB.SizeToFit = true;
            this.conectDB.Text = "Connect to Database...";

            ///
            /// connectserver
            ///
            this.connectserver = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.connectserver.BarName = "connectserver";
            this.connectserver.CategoryIndex = 1;
            this.connectserver.ID = "";
            this.connectserver.ShowToolTipInPopUp = false;
            this.connectserver.SizeToFit = true;
            this.connectserver.Text = "Connect to Server...";

            ///
            /// addsharept
            ///
            this.addsharept = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.addsharept.BarName = "addsharept";
            this.addsharept.CategoryIndex = 1;
            this.addsharept.ID = "";
            this.addsharept.ShowToolTipInPopUp = false;
            this.addsharept.SizeToFit = true;
            this.addsharept.Text = "Add SharePoint Connections...";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.WinPhone,
            this.attachprocess,
            this.conectDB,
            this.connectserver,
            this.addsharept});

            this.toolsItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.WinPhone,
            this.attachprocess,
            this.conectDB,
            this.connectserver,
            this.addsharept}); ;

            this.toolsItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Test barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem run;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem debug;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem playlist;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem setting;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem profiletest;

        public void AddItemsUnderTest()
        {
            // 
            // run
            // 
            this.run = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.run.BarName = "Undo";
            this.run.CategoryIndex = 1;
            this.run.ID = "Undo";
            this.run.ShowToolTipInPopUp = false;
            this.run.SizeToFit = true;
            this.run.Text = "Run";

            // 
            // debug
            // 
            this.debug = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.debug.BarName = "Redo";
            this.debug.CategoryIndex = 1;
            this.debug.ID = "Redo";
            this.debug.ShowToolTipInPopUp = false;
            this.debug.SizeToFit = true;
            this.debug.Text = "Debug";

            // 
            // playlist
            // 
            this.playlist = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.playlist.BarName = "addToSourceCotrol";
            this.playlist.CategoryIndex = 1;
            this.playlist.ID = "";
            this.playlist.ShowToolTipInPopUp = false;
            this.playlist.SizeToFit = true;
            this.playlist.Text = "Playlist";

            ///
            /// setting
            ///
            this.setting = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.setting.BarName = "setting";
            this.setting.CategoryIndex = 1;
            this.setting.ID = "";
            this.setting.ShowToolTipInPopUp = false;
            this.setting.SizeToFit = true;
            this.setting.Text = "Testsettings";

            ///
            /// Profiletest
            ///
            this.profiletest = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.profiletest.BarName = "TeamExplorer";
            this.profiletest.CategoryIndex = 1;
            this.profiletest.ID = "";
            this.profiletest.ShowToolTipInPopUp = false;
            this.profiletest.SizeToFit = true;
            this.profiletest.Text = "Profile Test";
            this.profiletest.Enabled = false;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.run,
            this.debug,
            this.playlist,
            this.setting,
            this.profiletest});

            this.testItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.run,
            this.debug,
            this.playlist,
            this.setting,
            this.profiletest}); ;

            this.teamItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Analyze barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem performance;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem profiler;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem codeMatrices;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem codeMatricessolution;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem analyzesolution;

        public void AddItemsUnderAnalyze()
        {
            // 
            // performance
            // 
            this.performance = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.performance.BarName = "Performance";
            this.performance.CategoryIndex = 1;
            this.performance.ID = "Performance";
            this.performance.ShowToolTipInPopUp = false;
            this.performance.SizeToFit = true;
            this.performance.Text = "Performance and Diagnostics                   Alt+F2";

            // 
            // profiler
            // 
            this.profiler = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.profiler.BarName = "profiler";
            this.profiler.CategoryIndex = 1;
            this.profiler.ID = "profiler";
            this.profiler.ShowToolTipInPopUp = false;
            this.profiler.SizeToFit = true;
            this.profiler.Text = "Profiler";

            // 
            // codeMatrices
            // 
            this.codeMatrices = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.codeMatrices.BarName = "codemetricesolution";
            this.codeMatrices.CategoryIndex = 1;
            this.codeMatrices.ID = "";
            this.codeMatrices.ShowToolTipInPopUp = false;
            this.codeMatrices.SizeToFit = true;
            this.codeMatrices.Text = "Calculate Code Metrices for Selected Project(s)";

            ///
            /// codeMatricessolution
            ///
            this.codeMatricessolution = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.codeMatricessolution.BarName = "codemetrice";
            this.codeMatricessolution.CategoryIndex = 1;
            this.codeMatricessolution.ID = "";
            this.codeMatricessolution.ShowToolTipInPopUp = false;
            this.codeMatricessolution.SizeToFit = true;
            this.codeMatricessolution.Text = "Calculate Code Metrices for Solution";
            
            ///
            /// analyzesolution
            ///
            this.analyzesolution = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.analyzesolution.BarName = "analyze";
            this.analyzesolution.CategoryIndex = 1;
            this.analyzesolution.ID = "";
            this.analyzesolution.ShowToolTipInPopUp = false;
            this.analyzesolution.SizeToFit = true;
            this.analyzesolution.Text = "Analyze Solution for Code Clones";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.performance,
            this.profiler,
            this.codeMatrices,
            this.codeMatricessolution,
            this.analyzesolution});

            this.analyzeItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.performance,
            this.profiler,
            this.codeMatrices,
            this.codeMatricessolution,
            this.analyzesolution}); ;

            this.analyzeItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Windows barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem newwindow;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem split;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem floating;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem dock;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem autohide;

        public void AddItemsUnderWindows()
        {
            // 
            // newwindow
            // 
            this.newwindow = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.newwindow.BarName = "New Window";
            this.newwindow.CategoryIndex = 1;
            this.newwindow.ID = "newwindow";
            this.newwindow.ShowToolTipInPopUp = false;
            this.newwindow.SizeToFit = true;
            this.newwindow.Text = "Cascade";
            this.newwindow.ImageIndex = 50;
            this.newwindow.ImageList = this.imageList3;
            // 
            // split
            // 
            this.split = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.split.BarName = "Split";
            this.split.CategoryIndex = 1;
            this.split.ID = "Redo";
            this.split.ShowToolTipInPopUp = false;
            this.split.SizeToFit = true;
            this.split.Text = "New Horizontal Tabgroup";
            this.split.ImageIndex = 53;
            this.split.ImageList = this.imageList3;
            // 
            // floating
            // 
            this.floating = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.floating.BarName = "Float";
            this.floating.CategoryIndex = 1;
            this.floating.ID = "";
            this.floating.ShowToolTipInPopUp = false;
            this.floating.SizeToFit = true;
            this.floating.Text = "New Vertical Tabgroup";
            this.floating.ImageIndex = 88;
            this.floating.ImageList = this.imageList3;

            ///
            /// dock
            ///
            this.dock = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dock.BarName = "Dock";
            this.dock.CategoryIndex = 1;
            this.dock.ID = "";
            this.dock.ShowToolTipInPopUp = false;
            this.dock.SizeToFit = true;
            this.dock.Text = "Close All Winodws";
            this.dock.ImageIndex = 84;
            this.dock.ImageList = this.imageList3;
            ///
            /// autohide
            ///
            this.autohide = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.autohide.BarName = "TeamExplorer";
            this.autohide.CategoryIndex = 1;
            this.autohide.ID = "";
            this.autohide.ShowToolTipInPopUp = false;
            this.autohide.SizeToFit = true;
            this.autohide.Text = "AssemblyInfo.cs";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.newwindow,
            this.split,
            this.floating,
            this.dock,
            this.autohide});

            this.barItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
             this.newwindow,
            this.split,
            this.floating,
            this.dock,
            this.autohide}); ;

            this.barItem4.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Help barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem viewhelp;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem addandremove;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem customerfeedback;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem registerproduct;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem techsupport;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem about;

        public void AddItemsUnderHelp()
        {
            // 
            // viewhelp
            // 
            this.viewhelp = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.viewhelp.BarName = "viewhelp";
            this.viewhelp.CategoryIndex = 1;
            this.viewhelp.ID = "viewhelp";
            this.viewhelp.ShowToolTipInPopUp = false;
            this.viewhelp.SizeToFit = true;
            this.viewhelp.Text = "View Help                                     Ctrl+F1";

            // 
            // addandremove
            // 
            this.addandremove = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.addandremove.BarName = "Redo";
            this.addandremove.CategoryIndex = 1;
            this.addandremove.ID = "Redo";
            this.addandremove.ShowToolTipInPopUp = false;
            this.addandremove.SizeToFit = true;
            this.addandremove.Text = "Add and Remove Help Content    Ctrl+Alt+F1";

            // 
            // customerfeedback
            // 
            this.customerfeedback = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.customerfeedback.BarName = "addToSourceCotrol";
            this.customerfeedback.CategoryIndex = 1;
            this.customerfeedback.ID = "";
            this.customerfeedback.ShowToolTipInPopUp = false;
            this.customerfeedback.SizeToFit = true;
            this.customerfeedback.Text = "Customer Feedback options...";

            ///
            /// registerproduct
            ///
            this.registerproduct = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.registerproduct.BarName = "registerproduct";
            this.registerproduct.CategoryIndex = 1;
            this.registerproduct.ID = "";
            this.registerproduct.ShowToolTipInPopUp = false;
            this.registerproduct.SizeToFit = true;
            this.registerproduct.Text = "Register Products";

            ///
            /// techsupport
            ///
            this.techsupport = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.techsupport.BarName = "TeamExplorer";
            this.techsupport.CategoryIndex = 1;
            this.techsupport.ID = "";
            this.techsupport.ShowToolTipInPopUp = false;
            this.techsupport.SizeToFit = true;
            this.techsupport.Text = "Technical Support";
            
            ///
            /// About
            ///
            this.about = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.about.BarName = "TeamExplorer";
            this.about.CategoryIndex = 1;
            this.about.ID = "";
            this.about.ShowToolTipInPopUp = false;
            this.about.SizeToFit = true;
            this.about.Text = "About Syncfusion Visual Studio";
            this.about.ImageIndex = 45;
            this.about.ImageList = this.imageList3;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.viewhelp,
            this.addandremove,
            this.customerfeedback,
            this.registerproduct,
            this.techsupport,
            this.about});

            this.barItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{            
            this.about}); ;

            this.barItem5.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #endregion

        #region Events
        void DockingManagerForm_Load(object sender, EventArgs e)
        {
              this.panel5 = new SolutionExplorerView();
            this.dockingManager1.SetDockLabel(this.panel5, "Solution Explorer");

            //Me.dockingManager1.SetEnableDocking(Me.panel5, True)
            this.dockingManager1.DockControl(this.panel5, this, DockingStyle.Right, 250);

            this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[0];
        }

        void treeViewAdv1_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as TreeViewAdv) == this.treeViewAdv1)
            {
                //this.treeViewAdv1.Nodes[0].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                for (int i = 0; i < this.treeViewAdv1.Nodes.Count; i++)
                {
                    foreach (TreeNodeAdv item in this.treeViewAdv1.Nodes[i].Nodes)
                    {
                        item.Background = new Syncfusion.Drawing.BrushInfo(Color.White);

                        foreach (TreeNodeAdv node in item.Nodes)
                        {
                            node.Background = new Syncfusion.Drawing.BrushInfo(Color.White);
                        }
                    }
                }

            }   
        }

        void treeViewAdv1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((sender as TreeViewAdv) == this.treeViewAdv1)
            {
                for (int i = 0; i < this.treeViewAdv1.Nodes.Count; i++)
                {
                    //this.treeViewAdv1.Nodes[i].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                    foreach (TreeNodeAdv item in this.treeViewAdv1.Nodes[i].Nodes)
                    {
                        item.Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                    }
                }
                if (this.treeViewAdv1.GetNodeAtPoint(new Point(e.X, e.Y)) != null)
                {
                    TreeNodeAdv node = this.treeViewAdv1.GetNodeAtPoint(new Point(e.X, e.Y));
                    if (!this.treeViewAdv1.Nodes.Contains(node))
                        node.Background = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#fdf4bf"));
                }
            } 
        }


        void bar1_DrawBackground(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(219, 223, 249)), e.ClipRectangle);
        }
        #endregion

        #region Get Form Icon
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #endregion

    }
}
