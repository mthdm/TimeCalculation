using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //初始化显示的时间
            DateTime StarDt = DateTime.Now;
            TimeShow.Text = StarDt.ToString("yyyy年MM月dd日");

            //初始化下拉列表框
            string[] items = new string[] { "后", "前" };
            comboBox1.Items.AddRange(items); // 添加两项文本
            comboBox1.SelectedIndex = 0; //默认选中“后”
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string Score_string = textBox1.Text;  //读入文本框内容
            string TimeTxt;
            int Score_int;
            int Choose = comboBox1.SelectedIndex; //读入当前选项

            if (!(int.TryParse(Score_string, out Score_int))) //判断是否含整数数据并赋值
            {
                MessageBox.Show("请输入有效天数");
                return;
            }
            if(Choose == 1) //当选择“前”时
            {
                Score_int = -Score_int;
            }
            DateTime Dt = DateTime.Now.AddDays(+Score_int);
            TimeTxt = Dt.ToString("yyyy年MM月dd日");
            //MessageBox.Show(Score_int + "天: " + TimeTxt); //调试输出
            TimeShow.Text = TimeTxt;



        }
    }
}
