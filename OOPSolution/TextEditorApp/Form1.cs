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

namespace TextEditorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Test\Help\PFRO.log"; //
            byte[] result; //byte는 부호없는 8비트 정수를 나타냄.

            using (FileStream stream = File.Open(filename, FileMode.Open))
            {
                result = new byte[stream.Length]; // 파일 크기만큼 byte[] 배열생성
                stream.Read(result, 0, (int)stream.Length);
                // await stream.ReadAsync(result, 0, (int)stream.Length);
                // 이렇게 하고 위에 private async void button1_Click(~)
                // 이렇게 하면 async await를 이용해서 훨씬 빠르게 가능
                //stream.Close(); // using이라는 키워드가 close() 알아서 해줘서 필요 없대.
            }
            richTextBox1.Text = Encoding.Unicode.GetString(result);

        }
    }
}
