namespace TxtEditor
{
    partial class SearchForm
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
            this.Btn_SearchNextOne = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_SerachContent = new System.Windows.Forms.Label();
            this.RichTextBox_SearchContent = new System.Windows.Forms.RichTextBox();
            this.CheckBox_ClassifyLower = new System.Windows.Forms.CheckBox();
            this.CheckBox_loop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_SearchNextOne
            // 
            this.Btn_SearchNextOne.Enabled = false;
            this.Btn_SearchNextOne.Location = new System.Drawing.Point(430, 78);
            this.Btn_SearchNextOne.Name = "Btn_SearchNextOne";
            this.Btn_SearchNextOne.Size = new System.Drawing.Size(75, 23);
            this.Btn_SearchNextOne.TabIndex = 0;
            this.Btn_SearchNextOne.Text = "查找下一个(F)";
            this.Btn_SearchNextOne.UseVisualStyleBackColor = true;
            this.Btn_SearchNextOne.Click += new System.EventHandler(this.Btn_SearchNextOne_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(430, 119);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 1;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // lbl_SerachContent
            // 
            this.lbl_SerachContent.AutoSize = true;
            this.lbl_SerachContent.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SerachContent.Location = new System.Drawing.Point(12, 78);
            this.lbl_SerachContent.Name = "lbl_SerachContent";
            this.lbl_SerachContent.Size = new System.Drawing.Size(82, 23);
            this.lbl_SerachContent.TabIndex = 2;
            this.lbl_SerachContent.Text = "查找内容:";
            // 
            // RichTextBox_SearchContent
            // 
            this.RichTextBox_SearchContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_SearchContent.Location = new System.Drawing.Point(107, 80);
            this.RichTextBox_SearchContent.Name = "RichTextBox_SearchContent";
            this.RichTextBox_SearchContent.Size = new System.Drawing.Size(305, 21);
            this.RichTextBox_SearchContent.TabIndex = 3;
            this.RichTextBox_SearchContent.Text = "";
            this.RichTextBox_SearchContent.TextChanged += new System.EventHandler(this.RichTextBox_SearchContent_TextChanged);
            // 
            // CheckBox_ClassifyLower
            // 
            this.CheckBox_ClassifyLower.AutoSize = true;
            this.CheckBox_ClassifyLower.Location = new System.Drawing.Point(12, 217);
            this.CheckBox_ClassifyLower.Name = "CheckBox_ClassifyLower";
            this.CheckBox_ClassifyLower.Size = new System.Drawing.Size(84, 16);
            this.CheckBox_ClassifyLower.TabIndex = 4;
            this.CheckBox_ClassifyLower.Text = "区分大小写";
            this.CheckBox_ClassifyLower.UseVisualStyleBackColor = true;
            this.CheckBox_ClassifyLower.Visible = false;
            this.CheckBox_ClassifyLower.CheckedChanged += new System.EventHandler(this.CheckBox_ClassifyLower_CheckedChanged);
            // 
            // CheckBox_loop
            // 
            this.CheckBox_loop.AutoSize = true;
            this.CheckBox_loop.Location = new System.Drawing.Point(12, 180);
            this.CheckBox_loop.Name = "CheckBox_loop";
            this.CheckBox_loop.Size = new System.Drawing.Size(48, 16);
            this.CheckBox_loop.TabIndex = 5;
            this.CheckBox_loop.Text = "循环";
            this.CheckBox_loop.UseVisualStyleBackColor = true;
            this.CheckBox_loop.Click += new System.EventHandler(this.CheckBox_loop_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 258);
            this.Controls.Add(this.CheckBox_loop);
            this.Controls.Add(this.CheckBox_ClassifyLower);
            this.Controls.Add(this.RichTextBox_SearchContent);
            this.Controls.Add(this.lbl_SerachContent);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_SearchNextOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.Text = "查找";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SearchNextOne;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label lbl_SerachContent;
        private System.Windows.Forms.RichTextBox RichTextBox_SearchContent;
        private System.Windows.Forms.CheckBox CheckBox_ClassifyLower;
        private System.Windows.Forms.CheckBox CheckBox_loop;
    }
}