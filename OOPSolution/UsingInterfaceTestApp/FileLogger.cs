using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    //메모장(Text파일)에 모든 사건 입력.
    class FileLogger : ILogger
    {
        private StreamWriter writer;
        
        public FileLogger(string path)
        {
            writer = File.CreateText(path); // 파일 만들기
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine($"FileLog {DateTime.Now}\t>>>>> {message}");
        }
    }
}
