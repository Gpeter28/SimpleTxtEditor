using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtEditor
{
    public partial class ReplaceForm : Form
    {
        public ReplaceForm()
        {
            InitializeComponent();
        }

        private bool LoopSearching = false;
        private int SearchIndex = 0;
        TxtForm form = new TxtForm();
        // https://blog.csdn.net/admans/article/details/81560532

        private void SetForm()
        {
            form = (TxtForm)Owner;
        }

        private void Btn_SearchNextOne_Click(object sender, EventArgs e)
        {
            SearchNextOne();
        }

        private void SearchNextOne()
        {
            var SearchText = RichTextBox_SearchContent.Text.Trim();

            if (string.IsNullOrEmpty(SearchText) || string.IsNullOrEmpty(form.MainRichTextBox.Text.Trim())) return;

            var SearchResult = form.MainRichTextBox.Find(SearchText, SearchIndex, RichTextBoxFinds.None);
            if (LoopSearching)
            {
                if (SearchResult == -1)
                {
                    int SearchResult2 = form.MainRichTextBox.Find(SearchText, 0, RichTextBoxFinds.None);
                    if (SearchResult2 != -1)
                    {
                        SearchResult = SearchResult2;
                    }

                }
            }
            if (SearchResult == -1)
            {
                MessageBox.Show($"Can't Find \"{SearchText}\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Console.WriteLine(++flag);
                // Console.WriteLine("find");
                form.MainRichTextBox.Focus();
                form.MainRichTextBox.Select(SearchResult, SearchText.Length);
                SearchIndex = SearchResult + SearchText.Length;
            }
        }

        private void ReplaceForm_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void CheckBox_loop_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_loop.Checked)
            {
                LoopSearching = true;
                Console.WriteLine("InLoop: " + LoopSearching);
            }
            else
            {
                LoopSearching = false;
            }
        }

        private void SetButton(bool flag)
        {
            Btn_Replace.Enabled = flag;
            Btn_SearchNextOne.Enabled = flag;
            Btn_ReplaceAll.Enabled = flag;
        }

        private void RichTextBox_SearchContent_TextChanged(object sender, EventArgs e)
        {
            var SearchText = RichTextBox_SearchContent.Text.Trim();

            if (string.IsNullOrEmpty(SearchText) || string.IsNullOrEmpty(form.MainRichTextBox.Text.Trim()))
            {
                SetButton(false);
                return;
            }
            SetButton(true);
        }

        private void Btn_Replace_Click(object sender, EventArgs e)
        {
            var SearchText = RichTextBox_SearchContent.Text.Trim();

            if (string.IsNullOrEmpty(SearchText) || string.IsNullOrEmpty(RichTextBox_ReplaceContent.Text.Trim())) return;

            ReplaceText(RichTextBox_ReplaceContent.Text);
            SearchNextOne();
        }

        private void ReplaceText(string text)
        {
            form.MainRichTextBox.SelectedText = text;
        }

        private void Btn_ReplaceAll_Click(object sender, EventArgs e)
        {
            var SearchText = RichTextBox_SearchContent.Text.Trim();

            if (string.IsNullOrEmpty(SearchText) || string.IsNullOrEmpty(RichTextBox_ReplaceContent.Text.Trim())) return;


            var SearchResult = form.MainRichTextBox.Find(SearchText, SearchIndex, RichTextBoxFinds.None);

            if (SearchResult == -1)
                return;

            while(SearchResult != -1)
            {
                form.MainRichTextBox.Focus();
                form.MainRichTextBox.Select(SearchResult, SearchText.Length);
                ReplaceText(RichTextBox_ReplaceContent.Text);
                SearchIndex = SearchResult + SearchText.Length;
                SearchResult = form.MainRichTextBox.Find(SearchText, SearchIndex, RichTextBoxFinds.None);
            }
            SearchIndex = 0;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBox_ClassifyLower_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
