using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TxtEditor
{
    public partial class TxtForm : Form
    {
        public TxtForm()
        {
            InitializeComponent();
        }

        private void TxtForm_Load(object sender, EventArgs e)
        {
            this.Text = "无标题";
#if DEBUG
            // AutoFont | DualFont
            MainRichTextBox.LanguageOption = RichTextBoxLanguageOptions.AutoFontSizeAdjust;
            MainRichTextBox.LoadFile("test.rtf", RichTextBoxStreamType.RichText);
#endif
            MainRichTextBox.AllowDrop = true;
            MainRichTextBox.DragEnter += new DragEventHandler(MainRichTextBox_DragEnter);
            MainRichTextBox.DragDrop += new DragEventHandler(MainRichTextBox_DragDrop);
        }

        private bool IsSave = false;
        // FileMenutStrip
        #region FileMenuStrip
        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "无标题";
            this.Font = DefaultFont;
            MainRichTextBox.ResetText();
            OpenedFilePath = string.Empty;
            this.Text = "无标题";

        }

        private string OpenedFilePath = string.Empty;
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            IsSave = true;
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "rtf|*.rtf";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OpenedFilePath = openFileDialog.FileName;
                    MainRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                    // MainRichTextBox.LoadFile(Filename, RichTextBoxStreamType.RichText);
                 
                    this.Text = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf(@"\") + 1,
                        openFileDialog.FileName.Length - openFileDialog.FileName.LastIndexOf(@"\") - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(OpenedFilePath == string.Empty)
                {
                    ShowSaveDialog();
                }
                else
                {
                    MainRichTextBox.SaveFile(OpenedFilePath, RichTextBoxStreamType.RichText);
                    RemoveUnSaveSymbol();
                }
                RemoveUnSaveSymbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(-1);
        }
        #endregion

        #region Tools
        private bool CheckSaved()
        {
            if(IsSave)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ShowSaveDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "rtf|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var FilePath = saveFileDialog.FileName;
                MainRichTextBox.SaveFile(FilePath, RichTextBoxStreamType.RichText);
                OpenedFilePath = FilePath;
                this.Text = FilePath.Substring(FilePath.LastIndexOf(@"\") + 1, FilePath.Length - FilePath.LastIndexOf(@"\") - 1);
            }
            RemoveUnSaveSymbol();
        }
        #endregion

        #region MainFormClick
        private void WordWrapMenuItem_Click(object sender, EventArgs e)
        {
            if (WordWrapMenuItem.Checked)
            {
                WordWrapMenuItem.Checked = false;
                MainRichTextBox.WordWrap = false;
            }
            else
            {
                WordWrapMenuItem.Checked = true;
                MainRichTextBox.WordWrap = true;
            }
        }

        private void FontMenuItem_Click(object sender, EventArgs e)
        {
            if (FontDialog.ShowDialog() != DialogResult.Cancel)
            {
                MainRichTextBox.Font = FontDialog.Font;
            }
        }

       
        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.StartsWith("*"))
            {
                IsSave = false;
                return;
            }
            this.Text = "*" + this.Text;
            IsSave = false;
        }

        private void RemoveUnSaveSymbol()
        {
            if (this.Text.StartsWith("*"))
            {
                this.Text = this.Text.Substring(1);
            }
                // this.Text.Remove(0, 1);
        }

        private void SearchMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchAndReplaceForm = new SearchForm();
            searchAndReplaceForm.Show(this);
        }


        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Copy();
        }

        private void CutMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Cut();
        }

        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Paste();
        }

        private void UndoMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Undo();
        }

        private void SelectAllMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectAll();
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectedText = "";
        }

        private void MainRichTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    RightClickMenu.Show(MousePosition.X, MousePosition.Y);
                    break;
            }
        }

        #endregion

        #region RightClickMenu
        private void RightClickMenuItem_Undo_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Undo();
        }

        private void RightClickMenuItem_Cut_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Cut();
        }

        private void RightClickMenuItem_Copy_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Copy();
        }

        private void RightClickMenuItem_Paste_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Paste();
        }

        private void RightClickMenuItem_Delete_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectedText = "";
        }

        private void RightClickMenuItem_SelectAll_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectAll();
        }

        private void RightClickMenuItem_LeftToRight_Click(object sender, EventArgs e)
        {
            if (MainRichTextBox.RightToLeft == RightToLeft.No)
            {
                MainRichTextBox.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                MainRichTextBox.RightToLeft = RightToLeft.No;
            }
        }

        private void RightClickMenuItem_SearchInBing_Click(object sender, EventArgs e)
        {
            string url = $"https://www.bing.com/search?q=" +  MainRichTextBox.SelectedText;

            Process.Start(url);
        }
        #endregion;

        private void LookForHelpMenuItem_Click(object sender, EventArgs e)
        {
            // 启动README.md

        }

        private void ReplaceMenuItem_Click_Click(object sender, EventArgs e)
        {
            ReplaceForm replaceForm = new ReplaceForm();
            replaceForm.Show(this);
        }


        #region MainRichTextBoxFunction
        private void MainRichTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainRichTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".rtf")  //判断文件类型，只接受txt文件
                {
                    MainRichTextBox.LoadFile(file, RichTextBoxStreamType.RichText);
                    // MainRichTextBox.LoadFile(Filename, RichTextBoxStreamType.RichText);

                    this.Text = file.Substring(file.LastIndexOf(@"\") + 1,
                        file.Length - file.LastIndexOf(@"\") - 1);
                }
            }
        }
        #endregion

        private void TxtForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!IsSave)
            {
                DialogResult dr = MessageBox.Show("你还有没有保存？是否保存", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }else if(dr == DialogResult.Yes)
                {
                    ShowSaveDialog();
                }
            }
        }



        // https://www.cnblogs.com/masonlu/p/9339669.html
        // https://www.cnblogs.com/imlions/p/3189773.html

    }
}
