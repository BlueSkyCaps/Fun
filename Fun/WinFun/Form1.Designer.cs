
using System.Windows.Forms;

namespace WinFun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.subBtn = new System.Windows.Forms.Button();
            this.QLabel = new System.Windows.Forms.Label();
            this.anwserTextBox = new System.Windows.Forms.TextBox();
            this.reQBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.TitleLabel.Location = new System.Drawing.Point(152, 65);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(612, 27);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "浏览器已被禁止使用。此次若想使用，请正确回答随机问题以解锁。";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.Snow;
            this.subBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.subBtn.Location = new System.Drawing.Point(587, 285);
            this.subBtn.Margin = new System.Windows.Forms.Padding(5);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(123, 51);
            this.subBtn.TabIndex = 2;
            this.subBtn.Text = "提交回答..";
            this.subBtn.UseVisualStyleBackColor = false;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // QLabel
            // 
            this.QLabel.BackColor = System.Drawing.Color.Transparent;
            this.QLabel.Location = new System.Drawing.Point(229, 103);
            this.QLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(435, 159);
            this.QLabel.TabIndex = 3;
            this.QLabel.Text = "Q：";
            this.QLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // anwserTextBox
            // 
            this.anwserTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.anwserTextBox.ForeColor = System.Drawing.Color.Black;
            this.anwserTextBox.Location = new System.Drawing.Point(275, 285);
            this.anwserTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.anwserTextBox.Multiline = true;
            this.anwserTextBox.Name = "anwserTextBox";
            this.anwserTextBox.PlaceholderText = "你厉害你输入答案啊...";
            this.anwserTextBox.Size = new System.Drawing.Size(292, 48);
            this.anwserTextBox.TabIndex = 4;
            // 
            // reQBtn
            // 
            this.reQBtn.BackColor = System.Drawing.Color.Transparent;
            this.reQBtn.BackgroundImage = global::WinFun.Properties.Resources.req;
            this.reQBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reQBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reQBtn.ForeColor = System.Drawing.Color.Transparent;
            this.reQBtn.Location = new System.Drawing.Point(186, 285);
            this.reQBtn.Margin = new System.Windows.Forms.Padding(5);
            this.reQBtn.Name = "reQBtn";
            this.reQBtn.Size = new System.Drawing.Size(63, 51);
            this.reQBtn.TabIndex = 5;
            this.reQBtn.UseVisualStyleBackColor = false;
            this.reQBtn.Click += new System.EventHandler(this.reQBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(152, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "浏览器已被禁止使用。此次若想使用，请正确回答随机问题以解锁。";
            this.label1.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 411);
            this.Controls.Add(this.reQBtn);
            this.Controls.Add(this.anwserTextBox);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "就是不让你用啦！";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += Form1_FormClosing;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 取消关闭，设为隐藏。
            this.Hide();
            // 更新问题。因为用户关闭了窗口之后有可能重新操作，打开窗口时不是新窗口而是显示原窗口。
            UpdateTheQuestion();
        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Label QLabel;
        private System.Windows.Forms.TextBox anwserTextBox;
        private System.Windows.Forms.Button reQBtn;
        private System.Windows.Forms.Label label1;
    }
}

