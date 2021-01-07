namespace TxtEditor
{
    partial class TxtForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceMenuItem_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LookForHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RightClickMenuItem_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RightClickMenuItem_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickMenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickMenuItem_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.RightClickMenuItem_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.RightClickMenuItem_LeftToRight = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickMenuItem_SearchInBing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.RightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStrip,
            this.EditorMenuStrip,
            this.FormatMenuStrip,
            this.HelpMenuStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.toolStripSeparator1,
            this.ExitMenuItem});
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.FileMenuStrip.Size = new System.Drawing.Size(58, 21);
            this.FileMenuStrip.Text = "文件(F)";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.ShortcutKeyDisplayString = "";
            this.NewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewMenuItem.Size = new System.Drawing.Size(165, 22);
            this.NewMenuItem.Text = "新建(N)";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.ShortcutKeyDisplayString = "";
            this.OpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenuItem.Size = new System.Drawing.Size(165, 22);
            this.OpenMenuItem.Text = "打开(O)";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.ShortcutKeyDisplayString = "";
            this.SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuItem.Size = new System.Drawing.Size(165, 22);
            this.SaveMenuItem.Text = "保存(S)";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.ShortcutKeyDisplayString = "";
            this.ExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ExitMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ExitMenuItem.Text = "退出(X)";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // EditorMenuStrip
            // 
            this.EditorMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoMenuItem,
            this.CutMenuItem,
            this.CopyMenuItem,
            this.PasteMenuItem,
            this.DeleteMenuItem,
            this.toolStripSeparator2,
            this.SearchMenuItem,
            this.ReplaceMenuItem_Click,
            this.SelectAllMenuItem});
            this.EditorMenuStrip.Name = "EditorMenuStrip";
            this.EditorMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.EditorMenuStrip.Size = new System.Drawing.Size(59, 21);
            this.EditorMenuStrip.Text = "编辑(E)";
            // 
            // UndoMenuItem
            // 
            this.UndoMenuItem.Name = "UndoMenuItem";
            this.UndoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoMenuItem.Size = new System.Drawing.Size(162, 22);
            this.UndoMenuItem.Text = "撤销";
            this.UndoMenuItem.Click += new System.EventHandler(this.UndoMenuItem_Click);
            // 
            // CutMenuItem
            // 
            this.CutMenuItem.Name = "CutMenuItem";
            this.CutMenuItem.ShortcutKeyDisplayString = "";
            this.CutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutMenuItem.Size = new System.Drawing.Size(162, 22);
            this.CutMenuItem.Text = "剪切(X)";
            this.CutMenuItem.Click += new System.EventHandler(this.CutMenuItem_Click);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.ShortcutKeyDisplayString = "";
            this.CopyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyMenuItem.Size = new System.Drawing.Size(162, 22);
            this.CopyMenuItem.Text = "复制(C)";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.ShortcutKeyDisplayString = "";
            this.PasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteMenuItem.Size = new System.Drawing.Size(162, 22);
            this.PasteMenuItem.Text = "粘贴(V)";
            this.PasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.ShortcutKeyDisplayString = "";
            this.DeleteMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteMenuItem.Size = new System.Drawing.Size(162, 22);
            this.DeleteMenuItem.Text = "删除(L)";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // SearchMenuItem
            // 
            this.SearchMenuItem.Name = "SearchMenuItem";
            this.SearchMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.SearchMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SearchMenuItem.Text = "查找(F)";
            this.SearchMenuItem.Click += new System.EventHandler(this.SearchMenuItem_Click);
            // 
            // ReplaceMenuItem_Click
            // 
            this.ReplaceMenuItem_Click.Name = "ReplaceMenuItem_Click";
            this.ReplaceMenuItem_Click.ShortcutKeyDisplayString = "";
            this.ReplaceMenuItem_Click.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ReplaceMenuItem_Click.Size = new System.Drawing.Size(162, 22);
            this.ReplaceMenuItem_Click.Text = "替换(R)";
            this.ReplaceMenuItem_Click.Click += new System.EventHandler(this.ReplaceMenuItem_Click_Click);
            // 
            // SelectAllMenuItem
            // 
            this.SelectAllMenuItem.Name = "SelectAllMenuItem";
            this.SelectAllMenuItem.ShortcutKeyDisplayString = "";
            this.SelectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SelectAllMenuItem.Text = "全选(A)";
            this.SelectAllMenuItem.Click += new System.EventHandler(this.SelectAllMenuItem_Click);
            // 
            // FormatMenuStrip
            // 
            this.FormatMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordWrapMenuItem,
            this.FontMenuItem});
            this.FormatMenuStrip.Name = "FormatMenuStrip";
            this.FormatMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.FormatMenuStrip.Size = new System.Drawing.Size(62, 21);
            this.FormatMenuStrip.Text = "格式(O)";
            // 
            // WordWrapMenuItem
            // 
            this.WordWrapMenuItem.Name = "WordWrapMenuItem";
            this.WordWrapMenuItem.Size = new System.Drawing.Size(144, 22);
            this.WordWrapMenuItem.Text = "自动换行(W)";
            this.WordWrapMenuItem.Click += new System.EventHandler(this.WordWrapMenuItem_Click);
            // 
            // FontMenuItem
            // 
            this.FontMenuItem.Name = "FontMenuItem";
            this.FontMenuItem.Size = new System.Drawing.Size(144, 22);
            this.FontMenuItem.Text = "字体(F)";
            this.FontMenuItem.Click += new System.EventHandler(this.FontMenuItem_Click);
            // 
            // HelpMenuStrip
            // 
            this.HelpMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LookForHelpMenuItem});
            this.HelpMenuStrip.Name = "HelpMenuStrip";
            this.HelpMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.HelpMenuStrip.Size = new System.Drawing.Size(61, 21);
            this.HelpMenuStrip.Text = "帮助(H)";
            // 
            // LookForHelpMenuItem
            // 
            this.LookForHelpMenuItem.Name = "LookForHelpMenuItem";
            this.LookForHelpMenuItem.ShortcutKeyDisplayString = "";
            this.LookForHelpMenuItem.Size = new System.Drawing.Size(141, 22);
            this.LookForHelpMenuItem.Text = "查看帮助(H)";
            this.LookForHelpMenuItem.Click += new System.EventHandler(this.LookForHelpMenuItem_Click);
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainRichTextBox.DetectUrls = false;
            this.MainRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainRichTextBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainRichTextBox.Location = new System.Drawing.Point(0, 25);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(784, 536);
            this.MainRichTextBox.TabIndex = 1;
            this.MainRichTextBox.Text = "";
            this.MainRichTextBox.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            this.MainRichTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainRichTextBox_MouseUp);
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightClickMenuItem_Undo,
            this.toolStripSeparator3,
            this.RightClickMenuItem_Cut,
            this.RightClickMenuItem_Copy,
            this.RightClickMenuItem_Paste,
            this.RightClickMenuItem_Delete,
            this.toolStripSeparator4,
            this.RightClickMenuItem_SelectAll,
            this.toolStripSeparator5,
            this.RightClickMenuItem_LeftToRight,
            this.RightClickMenuItem_SearchInBing});
            this.RightClickMenu.Name = "RightClickMenu";
            this.RightClickMenu.Size = new System.Drawing.Size(185, 198);
            // 
            // RightClickMenuItem_Undo
            // 
            this.RightClickMenuItem_Undo.Name = "RightClickMenuItem_Undo";
            this.RightClickMenuItem_Undo.Size = new System.Drawing.Size(184, 22);
            this.RightClickMenuItem_Undo.Text = "撤销";
            this.RightClickMenuItem_Undo.Click += new System.EventHandler(this.RightClickMenuItem_Undo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // RightClickMenuItem_Cut
            // 
            this.RightClickMenuItem_Cut.Name = "RightClickMenuItem_Cut";
            this.RightClickMenuItem_Cut.Size = new System.Drawing.Size(184, 22);
            this.RightClickMenuItem_Cut.Text = "剪切";
            this.RightClickMenuItem_Cut.Click += new System.EventHandler(this.RightClickMenuItem_Cut_Click);
            // 
            // RightClickMenuItem_Copy
            // 
            this.RightClickMenuItem_Copy.Name = "RightClickMenuItem_Copy";
            this.RightClickMenuItem_Copy.Size = new System.Drawing.Size(184, 22);
            this.RightClickMenuItem_Copy.Text = "复制";
            this.RightClickMenuItem_Copy.Click += new System.EventHandler(this.RightClickMenuItem_Copy_Click);
            // 
            // RightClickMenuItem_Paste
            // 
            this.RightClickMenuItem_Paste.Name = "RightClickMenuItem_Paste";
            this.RightClickMenuItem_Paste.Size = new System.Drawing.Size(184, 22);
            this.RightClickMenuItem_Paste.Text = "粘贴";
            this.RightClickMenuItem_Paste.Click += new System.EventHandler(this.RightClickMenuItem_Paste_Click);
            // 
            // RightClickMenuItem_Delete
            // 
            this.RightClickMenuItem_Delete.Name = "RightClickMenuItem_Delete";
            this.RightClickMenuItem_Delete.Size = new System.Drawing.Size(184, 22);
            this.RightClickMenuItem_Delete.Text = "删除";
            this.RightClickMenuItem_Delete.Click += new System.EventHandler(this.RightClickMenuItem_Delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // RightClickMenuItem_SelectAll
            // 
            this.RightClickMenuItem_SelectAll.Name = "RightClickMenuItem_SelectAll";
            this.RightClickMenuItem_SelectAll.Size = new System.Drawing.Size(184, 22);
            this.RightClickMenuItem_SelectAll.Text = "全选";
            this.RightClickMenuItem_SelectAll.Click += new System.EventHandler(this.RightClickMenuItem_SelectAll_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(181, 6);
            // 
            // RightClickMenuItem_LeftToRight
            // 
            this.RightClickMenuItem_LeftToRight.Name = "RightClickMenuItem_LeftToRight";
            this.RightClickMenuItem_LeftToRight.Size = new System.Drawing.Size(184, 22);
            this.RightClickMenuItem_LeftToRight.Text = "从右到左的阅读顺序";
            this.RightClickMenuItem_LeftToRight.Click += new System.EventHandler(this.RightClickMenuItem_LeftToRight_Click);
            // 
            // RightClickMenuItem_SearchInBing
            // 
            this.RightClickMenuItem_SearchInBing.Name = "RightClickMenuItem_SearchInBing";
            this.RightClickMenuItem_SearchInBing.Size = new System.Drawing.Size(184, 22);
            this.RightClickMenuItem_SearchInBing.Text = "用bing搜索";
            this.RightClickMenuItem_SearchInBing.Click += new System.EventHandler(this.RightClickMenuItem_SearchInBing_Click);
            // 
            // TxtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainRichTextBox);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(300, 50);
            this.Name = "TxtForm";
            this.ShowIcon = false;
            this.Text = "TxtForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TxtForm_FormClosing);
            this.Load += new System.EventHandler(this.TxtForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.RightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FormatMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SelectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordWrapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontMenuItem;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.ToolStripMenuItem SearchMenuItem;
        public System.Windows.Forms.RichTextBox MainRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem UndoMenuItem;
        private System.Windows.Forms.ContextMenuStrip RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem RightClickMenuItem_Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem RightClickMenuItem_Cut;
        private System.Windows.Forms.ToolStripMenuItem RightClickMenuItem_Copy;
        private System.Windows.Forms.ToolStripMenuItem RightClickMenuItem_Paste;
        private System.Windows.Forms.ToolStripMenuItem RightClickMenuItem_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem RightClickMenuItem_SelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem RightClickMenuItem_LeftToRight;
        private System.Windows.Forms.ToolStripMenuItem RightClickMenuItem_SearchInBing;
        private System.Windows.Forms.ToolStripMenuItem LookForHelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplaceMenuItem_Click;
    }
}

