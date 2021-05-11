using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformThreadApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            

            Thread th = new Thread(() => {
                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(50); // 50ms 걸리는 처리할 일이 있음
                }
            }); //익명 메소드를 람다식으로 표현.    메소드를 만들어서 Thread에 넣는게 아니라
            //즉석에서 중괄호 안에 내가 실행하고 싶은 코드(메소드 역할)를 작성
            th.IsBackground = true; // 백그라운드로 실행할지 여부
            th.Start();
        }
    }
}
