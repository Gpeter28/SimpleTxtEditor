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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void RichTextBox_SearchContent_TextChanged(object sender, EventArgs e)
        {
            if(RichTextBox_SearchContent.Text != string.Empty)
            {
                Btn_SearchNextOne.Enabled = true;
            }
            else
            {
                Btn_SearchNextOne.Enabled = false;
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckClassifyLower = false;
        private bool LoopSearching = false;
        private int SearchIndex = 0;
        TxtForm form = new TxtForm();
        // https://blog.csdn.net/admans/article/details/81560532

        private void SetForm()
        {
            form = (TxtForm)Owner;
        }
        int flag = 0;
        private void Btn_SearchNextOne_Click(object sender, EventArgs e)
        {
            // var form = (TxtForm)Owner;

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

        private void SearchForm_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void CheckBox_ClassifyLower_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox_loop_Click(object sender, EventArgs e)
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
    }
}
