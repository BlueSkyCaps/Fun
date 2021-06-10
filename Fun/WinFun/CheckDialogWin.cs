using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFun
{
    class CheckDialogWin : Form
    {
        private TextBox answerPiTextBox;
        private Button subBtn;
        private Label qTextPiLabel;
        private Label qPiLabel;

        public static string piRightAnwser;
        private static readonly string PointOfPi = global::WinFun.Properties.Resources.PointOfPi;
        private static readonly int PointOfPiCount = global::WinFun.Properties.Resources.PointOfPi.Length;
        public CheckDialogWin()
        {
            InitializeComponent();
            this.Load += CheckDialogWin_Load;
        }

        private void CheckDialogWin_Load(object sender, EventArgs e)
        {
            //无论如何ShowDialog, 都会响应，即便不创建新的CheckDialogWin对象。
            ReflashQuestion();
        }

        private void ReflashQuestion() {
            int thePiStart = new Random().Next(1, PointOfPiCount + 1); // 返回0到π小数点后的总数
            int theEndRange = new Random().Next(5, 11); // 返回5到10
            if (thePiStart + theEndRange > PointOfPiCount)
            {
                thePiStart = PointOfPiCount - theEndRange;
            }
            this.qPiLabel.Text = String.Concat("请输入π小数点后第", thePiStart, "位到第", thePiStart + theEndRange, "位的连续数字.");
            piRightAnwser = PointOfPi.Substring(thePiStart - 1, theEndRange);
        }
        private void InitializeComponent()
        {
            this.answerPiTextBox = new System.Windows.Forms.TextBox();
            this.subBtn = new System.Windows.Forms.Button();
            this.qTextPiLabel = new System.Windows.Forms.Label();
            this.qPiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerPiTextBox
            // 
            this.answerPiTextBox.Location = new System.Drawing.Point(108, 116);
            this.answerPiTextBox.Name = "answerPiTextBox";
            this.answerPiTextBox.Size = new System.Drawing.Size(100, 30);
            this.answerPiTextBox.TabIndex = 0;
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(226, 116);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(75, 29);
            this.subBtn.TabIndex = 1;
            this.subBtn.Text = "验证";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // qTextPiLabel
            // 
            this.qTextPiLabel.AutoSize = true;
            this.qTextPiLabel.Font = new System.Drawing.Font("微软雅黑", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.qTextPiLabel.Location = new System.Drawing.Point(29, 22);
            this.qTextPiLabel.Name = "qTextPiLabel";
            this.qTextPiLabel.Size = new System.Drawing.Size(294, 20);
            this.qTextPiLabel.TabIndex = 2;
            this.qTextPiLabel.Text = "为了验证你是正常人，请完成圆周率验证。";
            // 
            // qPiLabel
            // 
            this.qPiLabel.AutoSize = true;
            this.qPiLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qPiLabel.Location = new System.Drawing.Point(11, 65);
            this.qPiLabel.Name = "qPiLabel";
            this.qPiLabel.Size = new System.Drawing.Size(0, 21);
            this.qPiLabel.TabIndex = 3;
            // 
            // CheckDialogWin
            // 
            this.ClientSize = new System.Drawing.Size(368, 158);
            this.Controls.Add(this.qTextPiLabel);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.answerPiTextBox);
            this.Controls.Add(this.qPiLabel);
            this.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CheckDialogWin";
            this.ShowInTaskbar = false;
            this.Text = "超级验证派。";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (piRightAnwser == this.answerPiTextBox.Text.Trim())
            {
                this.DialogResult = DialogResult.Yes;
            }
            this.Close();
        }
    }
}
