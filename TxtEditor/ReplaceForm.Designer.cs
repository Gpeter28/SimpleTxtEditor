namespace TxtEditor
{
    partial class ReplaceForm
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
            this.CheckBox_loop = new System.Windows.Forms.CheckBox();
            this.CheckBox_ClassifyLower = new System.Windows.Forms.CheckBox();
            this.RichTextBox_SearchContent = new System.Windows.Forms.RichTextBox();
            this.lbl_SerachContent = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_SearchNextOne = new System.Windows.Forms.Button();
            this.lbl_ReplaceContent = new System.Windows.Forms.Label();
            this.RichTextBox_ReplaceContent = new System.Windows.Forms.RichTextBox();
            this.Btn_ReplaceAll = new System.Windows.Forms.Button();
            this.Btn_Replace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckBox_loop
            // 
            this.CheckBox_loop.AutoSize = true;
            this.CheckBox_loop.Location = new System.Drawing.Point(12, 169);
            this.CheckBox_loop.Name = "CheckBox_loop";
            this.CheckBox_loop.Size = new System.Drawing.Size(48, 16);
            this.CheckBox_loop.TabIndex = 11;
            this.CheckBox_loop.Text = "循环";
            this.CheckBox_loop.UseVisualStyleBackColor = true;
            this.CheckBox_loop.CheckedChanged += new System.EventHandler(this.CheckBox_loop_CheckedChanged);
            // 
            // CheckBox_ClassifyLower
            // 
            this.CheckBox_ClassifyLower.AutoSize = true;
            this.CheckBox_ClassifyLower.Location = new System.Drawing.Point(9, 202);
            this.CheckBox_ClassifyLower.Name = "CheckBox_ClassifyLower";
            this.CheckBox_ClassifyLower.Size = new System.Drawing.Size(84, 16);
            this.CheckBox_ClassifyLower.TabIndex = 10;
            this.CheckBox_ClassifyLower.Text = "区分大小写";
            this.CheckBox_ClassifyLower.UseVisualStyleBackColor = true;
            this.CheckBox_ClassifyLower.Visible = false;
            this.CheckBox_ClassifyLower.CheckedChanged += new System.EventHandler(this.CheckBox_ClassifyLower_CheckedChanged);
            // 
            // RichTextBox_SearchContent
            // 
            this.RichTextBox_SearchContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_SearchContent.Location = new System.Drawing.Point(112, 25);
            this.RichTextBox_SearchContent.Name = "RichTextBox_SearchContent";
            this.RichTextBox_SearchContent.Size = new System.Drawing.Size(305, 21);
            this.RichTextBox_SearchContent.TabIndex = 9;
            this.RichTextBox_SearchContent.Text = "";
            this.RichTextBox_SearchContent.TextChanged += new System.EventHandler(this.RichTextBox_SearchContent_TextChanged);
            // 
            // lbl_SerachContent
            // 
            this.lbl_SerachContent.AutoSize = true;
            this.lbl_SerachContent.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SerachContent.Location = new System.Drawing.Point(11, 23);
            this.lbl_SerachContent.Name = "lbl_SerachContent";
            this.lbl_SerachContent.Size = new System.Drawing.Size(82, 23);
            this.lbl_SerachContent.TabIndex = 8;
            this.lbl_SerachContent.Text = "查找内容:";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(438, 110);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 23);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_SearchNextOne
            // 
            this.Btn_SearchNextOne.Enabled = false;
            this.Btn_SearchNextOne.Location = new System.Drawing.Point(438, 23);
            this.Btn_SearchNextOne.Name = "Btn_SearchNextOne";
            this.Btn_SearchNextOne.Size = new System.Drawing.Size(100, 23);
            this.Btn_SearchNextOne.TabIndex = 6;
            this.Btn_SearchNextOne.Text = "查找下一个(F)";
            this.Btn_SearchNextOne.UseVisualStyleBackColor = true;
            this.Btn_SearchNextOne.Click += new System.EventHandler(this.Btn_SearchNextOne_Click);
            // 
            // lbl_ReplaceContent
            // 
            this.lbl_ReplaceContent.AutoSize = true;
            this.lbl_ReplaceContent.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ReplaceContent.Location = new System.Drawing.Point(12, 62);
            this.lbl_ReplaceContent.Name = "lbl_ReplaceContent";
            this.lbl_ReplaceContent.Size = new System.Drawing.Size(61, 23);
            this.lbl_ReplaceContent.TabIndex = 12;
            this.lbl_ReplaceContent.Text = "替换为";
            // 
            // RichTextBox_ReplaceContent
            // 
            this.RichTextBox_ReplaceContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_ReplaceContent.Location = new System.Drawing.Point(112, 67);
            this.RichTextBox_ReplaceContent.Name = "RichTextBox_ReplaceContent";
            this.RichTextBox_ReplaceContent.Size = new System.Drawing.Size(305, 21);
            this.RichTextBox_ReplaceContent.TabIndex = 13;
            this.RichTextBox_ReplaceContent.Text = "";
            // 
            // Btn_ReplaceAll
            // 
            this.Btn_ReplaceAll.Enabled = false;
            this.Btn_ReplaceAll.Location = new System.Drawing.Point(438, 81);
            this.Btn_ReplaceAll.Name = "Btn_ReplaceAll";
            this.Btn_ReplaceAll.Size = new System.Drawing.Size(100, 23);
            this.Btn_ReplaceAll.TabIndex = 14;
            this.Btn_ReplaceAll.Text = "替换全部(A)";
            this.Btn_ReplaceAll.UseVisualStyleBackColor = true;
            this.Btn_ReplaceAll.Click += new System.EventHandler(this.Btn_ReplaceAll_Click);
            // 
            // Btn_Replace
            // 
            this.Btn_Replace.Enabled = false;
            this.Btn_Replace.Location = new System.Drawing.Point(438, 52);
            this.Btn_Replace.Name = "Btn_Replace";
            this.Btn_Replace.Size = new System.Drawing.Size(100, 23);
            this.Btn_Replace.TabIndex = 15;
            this.Btn_Replace.Text = "替换(R)";
            this.Btn_Replace.UseVisualStyleBackColor = true;
            this.Btn_Replace.Click += new System.EventHandler(this.Btn_Replace_Click);
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 230);
            this.Controls.Add(this.Btn_Replace);
            this.Controls.Add(this.Btn_ReplaceAll);
            this.Controls.Add(this.RichTextBox_ReplaceContent);
            this.Controls.Add(this.lbl_ReplaceContent);
            this.Controls.Add(this.CheckBox_loop);
            this.Controls.Add(this.CheckBox_ClassifyLower);
            this.Controls.Add(this.RichTextBox_SearchContent);
            this.Controls.Add(this.lbl_SerachContent);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_SearchNextOne);
            this.Name = "ReplaceForm";
            this.ShowIcon = false;
            this.Text = "替换";
            this.Load += new System.EventHandler(this.ReplaceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_loop;
        private System.Windows.Forms.CheckBox CheckBox_ClassifyLower;
        private System.Windows.Forms.RichTextBox RichTextBox_SearchContent;
        private System.Windows.Forms.Label lbl_SerachContent;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_SearchNextOne;
        private System.Windows.Forms.Label lbl_ReplaceContent;
        private System.Windows.Forms.RichTextBox RichTextBox_ReplaceContent;
        private System.Windows.Forms.Button Btn_ReplaceAll;
        private System.Windows.Forms.Button Btn_Replace;
    }
}