using Memory;
using System.ComponentModel;

namespace WaWSpoofer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mem m = new Mem();
        private static Random random = new Random();
        string processName = "CoDWaWmp";
        bool ProcOpen = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            button1.PerformClick();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess(processName);
            if (!ProcOpen)
            {
                Thread.Sleep(1500);

                return;
            }
            Thread.Sleep(1500);

            backgroundWorker1.ReportProgress(0);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                gameStatusLabel.ForeColor = Color.SeaGreen;
                gameStatusLabel.Text = "Game Found!";
                m.OpenProcess(processName);
            }
        }

        public static string RandomString(int length) => new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length).Select<string, char>((Func<string, char>)(s => s[Form1.random.Next(s.Length)])).ToArray<char>());

        public static string RandomString2(int length) => new string(Enumerable.Repeat<string>("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length).Select<string, char>((Func<string, char>)(s => s[Form1.random.Next(s.Length)])).ToArray<char>());



        private void enableOnlineToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (enableOnlineToggle.Checked)
            {
                m.WriteMemory("0x0049E992", "byte", "0xEB");
                m.WriteMemory("0x0049E940", "byte", "0xEB");
            }
            else
            {
                m.WriteMemory("0x0049E992", "byte", "0x75");
                m.WriteMemory("0x0049E940", "byte", "0x75");
            }

        }


        public void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox1.Text = Form1.RandomString(20);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            m.OpenProcess(processName);
            m.WriteMemory("0x0049E992", "byte", "0xEB");
            m.WriteMemory("0x0049E940", "byte", "0xEB");
            m.WriteMemory("0x008CE6A0", "string", textBox1.Text);
            m.WriteMemory("0x008CE70C", "string", textBox1.Text.GetLast(4));
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                m.OpenProcess(processName);
                string currentKey = m.ReadString("0x008CE6A0");
                label2.Text = currentKey;
                string currentName = m.ReadString("0xF66B974");
                label3.Text = currentName;
            }
            catch { }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.WriteMemory("0x00F66B974", "string", textBox2.Text + "\0");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Form1.RandomString2(15);
        }

    }
}