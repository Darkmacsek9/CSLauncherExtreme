using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        string user = System.Environment.GetEnvironmentVariable("USERPROFILE");
        bool superhide = false;
        int r = 0;
        string path, raw, name, renderer, resolution, screensize, server;

        public Form1()
        {

            InitializeComponent();



        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            name = nameInput.Text.ToString();
            string nameFinal = " +name " + "\"" + name + "\"";

            if (renRadio2.Checked)
            {
                renderer = " -d3d";
            }
            else
            {
                renderer = " -soft";
            }

            if (fullscreenBox.Checked)
            {
                screensize = " -full";
            }

            else
            {
                screensize = " -window";
            }

            if (!srvBox.Checked)
            {
                server = "";
            }
            else
            {
                server = " +connect 10.111.111.221:27015";
            }

            if (superhide)
            {
                MessageBox.Show("Superhide");
                //Process.Start(Environment.CurrentDirectory + @"\Counter-Strike 1.6\superhide.exe");
            }

            MessageBox.Show(Environment.CurrentDirectory + @"\Counter-Strike 1.6\cstrike.exe" + nameFinal + resolution + renderer + screensize + server);
            //Process.Start(Environment.CurrentDirectory + @"\Counter-Strike 1.6\cstrike.exe" + nameFinal + resolution + renderer + screensize + server);


            File.WriteAllText(path, name + ";" + renderer + ";" + resolution + ";" + screensize + ";" + server);

            Close();

        }

        private void nameInput_Click(object sender, EventArgs e)
        {
            nameInput.Text = "";
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void resolutionBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (resolutionBox.SelectedIndex)
            {
                case 0: resolution = " -w 800 -h 600";
                    break;
                case 1: resolution = " -w 1024 -h 768";
                    break;
                default: resolution = " -w 1280 -h 1024";
                    break;
            }
        }

        private void hiddenPanel_Click(object sender, EventArgs e)
        {
            if (superhide == false)
            {
                superhide = true;
                hiddenLabel.Visible = true;
            }
            else
            {
                superhide = false;
                hiddenLabel.Visible = false;
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Valve\Half-Life\Settings", "ValveKey", "5RP2E-EPH3K-BR3LG-KMGTE-FN8PY");

            path = user + @"\AppData\Roaming\csle.conf";

            if (File.Exists(path))
            {
                raw = File.ReadAllText(path);
            }
            else
            {
                File.Create(path);
                raw = "Nickname; -soft; -w 1280 -h 1024; -full;";
            }

            List<string> options = raw.Split(';').ToList<string>();

            name = options[0];
            renderer = options[1];
            resolution = options[2];
            screensize = options[3];
            server = options[4];

            MessageBox.Show(name + resolution + renderer + screensize + server);

            if (renderer == " -soft")
            {
                renRadio1.Checked = true;
            }
            else
            {
                renRadio2.Checked = true;
            }

            switch (resolution)
            {
                case " -w 800 -h 600": r = 0;
                    break;
                case " -w 1024 -h 768": r = 1;
                    break;
                default: r = 2;
                    break;
            }

            resolutionBox.SelectedIndex = r;

            if (screensize == " -full")
            {
                fullscreenBox.Checked = true;
            }

            if (server != "")
            {
                srvBox.Checked = true;
            }

            nameInput.Text = name;
        }

    }
}
