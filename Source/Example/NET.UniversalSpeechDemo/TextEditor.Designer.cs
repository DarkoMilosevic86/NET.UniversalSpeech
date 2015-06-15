namespace TextEditor
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file_New = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.file_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.file_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tools_Customise = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeechtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speech_Speak = new System.Windows.Forms.ToolStripMenuItem();
            this.speech_StopSpeaking = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.tb_New = new System.Windows.Forms.ToolStripButton();
            this.tb_Open = new System.Windows.Forms.ToolStripButton();
            this.tb_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Cut = new System.Windows.Forms.ToolStripButton();
            this.tb_Copy = new System.Windows.Forms.ToolStripButton();
            this.tb_Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Bold = new System.Windows.Forms.ToolStripButton();
            this.tb_Italic = new System.Windows.Forms.ToolStripButton();
            this.tb_UnderLine = new System.Windows.Forms.ToolStripButton();
            this.tb_Strike = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_AlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tb_AlignCenter = new System.Windows.Forms.ToolStripButton();
            this.tb_AlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_UpperCase = new System.Windows.Forms.ToolStripButton();
            this.tb_LowerCase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tb_ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Font = new System.Windows.Forms.ToolStripComboBox();
            this.tb_FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.charCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_ZoomFactor = new System.Windows.Forms.ToolStripStatusLabel();
            this.Document = new System.Windows.Forms.RichTextBox();
            this.rcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.openWork = new System.Windows.Forms.OpenFileDialog();
            this.saveWork = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu.SuspendLayout();
            this.Tools.SuspendLayout();
            this.Status.SuspendLayout();
            this.rcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.SpeechtoolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(732, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_New,
            this.file_Open,
            this.toolStripSeparator11,
            this.file_Save,
            this.toolStripSeparator13,
            this.file_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // file_New
            // 
            this.file_New.Image = ((System.Drawing.Image)(resources.GetObject("file_New.Image")));
            this.file_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_New.Name = "file_New";
            this.file_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.file_New.Size = new System.Drawing.Size(152, 22);
            this.file_New.Text = "&New";
            // 
            // file_Open
            // 
            this.file_Open.Image = ((System.Drawing.Image)(resources.GetObject("file_Open.Image")));
            this.file_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Open.Name = "file_Open";
            this.file_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.file_Open.Size = new System.Drawing.Size(152, 22);
            this.file_Open.Text = "&Open";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(149, 6);
            // 
            // file_Save
            // 
            this.file_Save.Image = ((System.Drawing.Image)(resources.GetObject("file_Save.Image")));
            this.file_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Save.Name = "file_Save";
            this.file_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.file_Save.Size = new System.Drawing.Size(152, 22);
            this.file_Save.Text = "&Save";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(149, 6);
            // 
            // file_Exit
            // 
            this.file_Exit.Name = "file_Exit";
            this.file_Exit.Size = new System.Drawing.Size(152, 22);
            this.file_Exit.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_Undo,
            this.edit_Redo,
            this.toolStripSeparator14,
            this.edit_Cut,
            this.edit_Copy,
            this.edit_Paste,
            this.toolStripSeparator15,
            this.edit_SelectAll});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // edit_Undo
            // 
            this.edit_Undo.Name = "edit_Undo";
            this.edit_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.edit_Undo.Size = new System.Drawing.Size(152, 22);
            this.edit_Undo.Text = "&Undo";
            // 
            // edit_Redo
            // 
            this.edit_Redo.Name = "edit_Redo";
            this.edit_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.edit_Redo.Size = new System.Drawing.Size(152, 22);
            this.edit_Redo.Text = "&Redo";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(149, 6);
            // 
            // edit_Cut
            // 
            this.edit_Cut.Image = ((System.Drawing.Image)(resources.GetObject("edit_Cut.Image")));
            this.edit_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Cut.Name = "edit_Cut";
            this.edit_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.edit_Cut.Size = new System.Drawing.Size(152, 22);
            this.edit_Cut.Text = "Cu&t";
            // 
            // edit_Copy
            // 
            this.edit_Copy.Image = ((System.Drawing.Image)(resources.GetObject("edit_Copy.Image")));
            this.edit_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Copy.Name = "edit_Copy";
            this.edit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.edit_Copy.Size = new System.Drawing.Size(152, 22);
            this.edit_Copy.Text = "&Copy";
            // 
            // edit_Paste
            // 
            this.edit_Paste.Image = ((System.Drawing.Image)(resources.GetObject("edit_Paste.Image")));
            this.edit_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Paste.Name = "edit_Paste";
            this.edit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.edit_Paste.Size = new System.Drawing.Size(152, 22);
            this.edit_Paste.Text = "&Paste";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(149, 6);
            // 
            // edit_SelectAll
            // 
            this.edit_SelectAll.Name = "edit_SelectAll";
            this.edit_SelectAll.Size = new System.Drawing.Size(152, 22);
            this.edit_SelectAll.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools_Customise});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // tools_Customise
            // 
            this.tools_Customise.Name = "tools_Customise";
            this.tools_Customise.Size = new System.Drawing.Size(152, 22);
            this.tools_Customise.Text = "&Customize";
            // 
            // SpeechtoolStripMenuItem
            // 
            this.SpeechtoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speech_Speak,
            this.speech_StopSpeaking});
            this.SpeechtoolStripMenuItem.Name = "SpeechtoolStripMenuItem";
            this.SpeechtoolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.SpeechtoolStripMenuItem.Text = "&Speech";
            // 
            // speech_Speak
            // 
            this.speech_Speak.Name = "speech_Speak";
            this.speech_Speak.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.speech_Speak.Size = new System.Drawing.Size(167, 22);
            this.speech_Speak.Text = "&Speak";
            this.speech_Speak.Click += new System.EventHandler(this.speech_Speak_Click);
            // 
            // speech_StopSpeaking
            // 
            this.speech_StopSpeaking.Name = "speech_StopSpeaking";
            this.speech_StopSpeaking.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.speech_StopSpeaking.Size = new System.Drawing.Size(167, 22);
            this.speech_StopSpeaking.Text = "S&top speaking";
            this.speech_StopSpeaking.Click += new System.EventHandler(this.speech_StopSpeaking_Click);
            // 
            // Tools
            // 
            this.Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_New,
            this.tb_Open,
            this.tb_Save,
            this.toolStripSeparator,
            this.tb_Cut,
            this.tb_Copy,
            this.tb_Paste,
            this.toolStripSeparator1,
            this.tb_Bold,
            this.tb_Italic,
            this.tb_UnderLine,
            this.tb_Strike,
            this.toolStripSeparator3,
            this.tb_AlignLeft,
            this.tb_AlignCenter,
            this.tb_AlignRight,
            this.toolStripSeparator7,
            this.tb_UpperCase,
            this.tb_LowerCase,
            this.toolStripSeparator8,
            this.tb_ZoomIn,
            this.tb_ZoomOut,
            this.toolStripSeparator9,
            this.tb_Font,
            this.tb_FontSize,
            this.toolStripSeparator2});
            this.Tools.Location = new System.Drawing.Point(0, 24);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(732, 25);
            this.Tools.TabIndex = 1;
            this.Tools.Text = "toolStrip1";
            // 
            // tb_New
            // 
            this.tb_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_New.Image = ((System.Drawing.Image)(resources.GetObject("tb_New.Image")));
            this.tb_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_New.Name = "tb_New";
            this.tb_New.Size = new System.Drawing.Size(23, 22);
            this.tb_New.Text = "&New";
            // 
            // tb_Open
            // 
            this.tb_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Open.Image = ((System.Drawing.Image)(resources.GetObject("tb_Open.Image")));
            this.tb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Open.Name = "tb_Open";
            this.tb_Open.Size = new System.Drawing.Size(23, 22);
            this.tb_Open.Text = "&Open";
            // 
            // tb_Save
            // 
            this.tb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Save.Image = ((System.Drawing.Image)(resources.GetObject("tb_Save.Image")));
            this.tb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Save.Name = "tb_Save";
            this.tb_Save.Size = new System.Drawing.Size(23, 22);
            this.tb_Save.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Cut
            // 
            this.tb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tb_Cut.Image")));
            this.tb_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Cut.Name = "tb_Cut";
            this.tb_Cut.Size = new System.Drawing.Size(23, 22);
            this.tb_Cut.Text = "C&ut";
            // 
            // tb_Copy
            // 
            this.tb_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Copy.Image = ((System.Drawing.Image)(resources.GetObject("tb_Copy.Image")));
            this.tb_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Copy.Name = "tb_Copy";
            this.tb_Copy.Size = new System.Drawing.Size(23, 22);
            this.tb_Copy.Text = "&Copy";
            // 
            // tb_Paste
            // 
            this.tb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tb_Paste.Image")));
            this.tb_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Paste.Name = "tb_Paste";
            this.tb_Paste.Size = new System.Drawing.Size(23, 22);
            this.tb_Paste.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Bold
            // 
            this.tb_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_Bold.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bold.Image = ((System.Drawing.Image)(resources.GetObject("tb_Bold.Image")));
            this.tb_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Bold.Name = "tb_Bold";
            this.tb_Bold.Size = new System.Drawing.Size(23, 22);
            this.tb_Bold.Text = "B";
            this.tb_Bold.ToolTipText = "Bold";
            // 
            // tb_Italic
            // 
            this.tb_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_Italic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Italic.Image = ((System.Drawing.Image)(resources.GetObject("tb_Italic.Image")));
            this.tb_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Italic.Name = "tb_Italic";
            this.tb_Italic.Size = new System.Drawing.Size(23, 22);
            this.tb_Italic.Text = "I";
            this.tb_Italic.ToolTipText = "Italic";
            // 
            // tb_UnderLine
            // 
            this.tb_UnderLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_UnderLine.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UnderLine.Image = ((System.Drawing.Image)(resources.GetObject("tb_UnderLine.Image")));
            this.tb_UnderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_UnderLine.Name = "tb_UnderLine";
            this.tb_UnderLine.Size = new System.Drawing.Size(23, 22);
            this.tb_UnderLine.Text = "U";
            this.tb_UnderLine.ToolTipText = "Underline";
            // 
            // tb_Strike
            // 
            this.tb_Strike.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_Strike.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Strike.Image = ((System.Drawing.Image)(resources.GetObject("tb_Strike.Image")));
            this.tb_Strike.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Strike.Name = "tb_Strike";
            this.tb_Strike.Size = new System.Drawing.Size(23, 22);
            this.tb_Strike.Text = "S";
            this.tb_Strike.ToolTipText = "Strikethrough";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_AlignLeft
            // 
            this.tb_AlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_AlignLeft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tb_AlignLeft.Image")));
            this.tb_AlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AlignLeft.Name = "tb_AlignLeft";
            this.tb_AlignLeft.Size = new System.Drawing.Size(23, 22);
            this.tb_AlignLeft.Text = "L";
            this.tb_AlignLeft.ToolTipText = "Align Left";
            // 
            // tb_AlignCenter
            // 
            this.tb_AlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_AlignCenter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tb_AlignCenter.Image")));
            this.tb_AlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AlignCenter.Name = "tb_AlignCenter";
            this.tb_AlignCenter.Size = new System.Drawing.Size(23, 22);
            this.tb_AlignCenter.Text = "C";
            this.tb_AlignCenter.ToolTipText = "Align Center";
            // 
            // tb_AlignRight
            // 
            this.tb_AlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_AlignRight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tb_AlignRight.Image")));
            this.tb_AlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AlignRight.Name = "tb_AlignRight";
            this.tb_AlignRight.Size = new System.Drawing.Size(23, 22);
            this.tb_AlignRight.Text = "R";
            this.tb_AlignRight.ToolTipText = "Align Right";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_UpperCase
            // 
            this.tb_UpperCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_UpperCase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UpperCase.Image = ((System.Drawing.Image)(resources.GetObject("tb_UpperCase.Image")));
            this.tb_UpperCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_UpperCase.Name = "tb_UpperCase";
            this.tb_UpperCase.Size = new System.Drawing.Size(23, 22);
            this.tb_UpperCase.Text = "A";
            this.tb_UpperCase.ToolTipText = "Uppercase";
            // 
            // tb_LowerCase
            // 
            this.tb_LowerCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_LowerCase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LowerCase.Image = ((System.Drawing.Image)(resources.GetObject("tb_LowerCase.Image")));
            this.tb_LowerCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_LowerCase.Name = "tb_LowerCase";
            this.tb_LowerCase.Size = new System.Drawing.Size(23, 22);
            this.tb_LowerCase.Text = "a";
            this.tb_LowerCase.ToolTipText = "Lowercase";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_ZoomIn
            // 
            this.tb_ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_ZoomIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tb_ZoomIn.Image")));
            this.tb_ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_ZoomIn.Name = "tb_ZoomIn";
            this.tb_ZoomIn.Size = new System.Drawing.Size(23, 22);
            this.tb_ZoomIn.Text = "+";
            this.tb_ZoomIn.ToolTipText = "Zoom In";
            // 
            // tb_ZoomOut
            // 
            this.tb_ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_ZoomOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tb_ZoomOut.Image")));
            this.tb_ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_ZoomOut.Name = "tb_ZoomOut";
            this.tb_ZoomOut.Size = new System.Drawing.Size(23, 22);
            this.tb_ZoomOut.Text = "-";
            this.tb_ZoomOut.ToolTipText = "Zoom Out";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Font
            // 
            this.tb_Font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_Font.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tb_Font.Name = "tb_Font";
            this.tb_Font.Size = new System.Drawing.Size(200, 25);
            // 
            // tb_FontSize
            // 
            this.tb_FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_FontSize.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tb_FontSize.Name = "tb_FontSize";
            this.tb_FontSize.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charCount,
            this.toolStripStatusLabel2,
            this.status_ZoomFactor});
            this.Status.Location = new System.Drawing.Point(0, 413);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(732, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "statusStrip1";
            // 
            // charCount
            // 
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(63, 17);
            this.charCount.Text = "charCount";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(615, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // status_ZoomFactor
            // 
            this.status_ZoomFactor.Name = "status_ZoomFactor";
            this.status_ZoomFactor.Size = new System.Drawing.Size(39, 17);
            this.status_ZoomFactor.Text = "Zoom";
            // 
            // Document
            // 
            this.Document.ContextMenuStrip = this.rcMenu;
            this.Document.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Document.Location = new System.Drawing.Point(0, 49);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(732, 364);
            this.Document.TabIndex = 3;
            this.Document.Text = "";
            this.Document.TextChanged += new System.EventHandler(this.Document_TextChanged);
            // 
            // rcMenu
            // 
            this.rcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1,
            this.toolStripSeparator10,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1});
            this.rcMenu.Name = "rcMenu";
            this.rcMenu.Size = new System.Drawing.Size(104, 120);
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem1.Text = "Undo";
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem1.Text = "Redo";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(100, 6);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            // 
            // openWork
            // 
            this.openWork.FileName = "openFileDialog1";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 435);
            this.Controls.Add(this.Document);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(748, 473);
            this.Name = "TextEditor";
            this.ShowIcon = false;
            this.Text = "NET.UniversalSpeech Demo";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.rcMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripButton tb_New;
        private System.Windows.Forms.ToolStripButton tb_Open;
        private System.Windows.Forms.ToolStripButton tb_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tb_Cut;
        private System.Windows.Forms.ToolStripButton tb_Copy;
        private System.Windows.Forms.ToolStripButton tb_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tb_Font;
        private System.Windows.Forms.ToolStripComboBox tb_FontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tb_Bold;
        private System.Windows.Forms.ToolStripButton tb_Strike;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel charCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel status_ZoomFactor;
        private System.Windows.Forms.RichTextBox Document;
        private System.Windows.Forms.ToolStripButton tb_Italic;
        private System.Windows.Forms.ToolStripButton tb_UnderLine;
        private System.Windows.Forms.ToolStripButton tb_AlignLeft;
        private System.Windows.Forms.ToolStripButton tb_AlignCenter;
        private System.Windows.Forms.ToolStripButton tb_AlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tb_UpperCase;
        private System.Windows.Forms.ToolStripButton tb_LowerCase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tb_ZoomIn;
        private System.Windows.Forms.ToolStripButton tb_ZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ContextMenuStrip rcMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit_Undo;
        private System.Windows.Forms.ToolStripMenuItem edit_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem edit_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem edit_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tools_Customise;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file_New;
        private System.Windows.Forms.ToolStripMenuItem file_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem file_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem file_Exit;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.OpenFileDialog openWork;
        private System.Windows.Forms.SaveFileDialog saveWork;
        private System.Windows.Forms.ToolStripMenuItem SpeechtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speech_Speak;
        private System.Windows.Forms.ToolStripMenuItem speech_StopSpeaking;
    }
}

