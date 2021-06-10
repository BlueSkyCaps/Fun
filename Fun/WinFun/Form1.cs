using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WinFun
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private static string q, a;
        private static JObject jsonObj;
        private static CheckDialogWin dialogWin;
        private void Form1_Load(object sender, EventArgs e)
        {
            string jstr;
            string basePath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            using (StreamReader streamRead = new StreamReader(Path.Combine(basePath, "qa.json")))
            {
                jstr = streamRead.ReadToEnd();
            }
            jsonObj = JObject.Parse(jstr);
            UpdateTheQuestion();
        }

        private void UpdateTheQuestion() {
            int theRandom = new Random().Next(0, jsonObj.Count);
            int index = 0;
            foreach (var item in jsonObj)
            {
                if (theRandom == index)
                {
                    q = item.Key;
                    a = item.Value.ToString();
                    break;
                }
                index++;
            }
            index = 0;
            this.QLabel.Text = "Q：" + q;
        }

        private void reQBtn_Click(object sender, EventArgs e)
        {
            UpdateTheQuestion();
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (this.anwserTextBox.Text.Trim() == "程序员终极密码：42。")
            {
                MessageBox.Show($"算你狠！不玩了！", "给创造者的回应", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.terminationFlag = true;
            }
            bool res = this.anwserTextBox.Text.Trim() == a ? true : false;
            if (!res)
            {
                MessageBox.Show($"答错啦，傻蛋一个！答案是{a}", "提示傻蛋", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTheQuestion();
                return;
            }

            if (dialogWin == null)
            {
                dialogWin = new CheckDialogWin();
            }
            DialogResult checkResult = dialogWin.ShowDialog();
            if (checkResult!=DialogResult.Yes)
            {
                MessageBox.Show($"圆周率验证错误，滚去睡觉吧！答案是{CheckDialogWin.piRightAnwser}", "提示傻蛋", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show($"这都给你算出来了，牛！我逃~", "卧槽！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.terminationFlag = true;
        }


        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
