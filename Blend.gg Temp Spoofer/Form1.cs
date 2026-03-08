using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blend.gg_Temp_Spoofer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Start();
            string version = Environment.OSVersion.VersionString;
            string registry = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            string vername = Registry.GetValue(registry, "productName", "").ToString();
            string localname = Environment.UserName;


            guna2TextBox1.Text = "[+] Welcome to Blend.gg!";
            guna2TextBox1.AppendText(Environment.NewLine + $"[+] User: {localname}");
            guna2TextBox1.AppendText(Environment.NewLine + $"[+] OS Version: {vername}");
            guna2TextBox1.AppendText(Environment.NewLine + $"[+] Waiting for user input...");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2Button1.Checked == true)
            {
                guna2Panel1.Visible = true;
                guna2Panel2.Visible = false;
            }
            else
            {
                guna2Panel1.Visible = false;
                guna2Panel2.Visible = true;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string mainpath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
            string driverpath = Path.Combine(mainpath, "AoVMS6EX.sys");
            string mapperpath = Path.Combine(mainpath, "ulfJkjq3.exe");
            WebClient wc = new WebClient();
            wc.DownloadFile("https://raw.githubusercontent.com/sincerelyryan/spoofstuff/refs/heads/main/orodriver.bin", driverpath);
            wc.DownloadFile("https://raw.githubusercontent.com/sincerelyryan/spoofstuff/refs/heads/main/saturn.bin", mapperpath);
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c {mapperpath} {driverpath}",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            ProcessStartInfo startInfo2 = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c net stop winmgmt /y",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            ProcessStartInfo startInfo3 = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c net start winmgmt /y",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process.Start(startInfo).WaitForExit();
            guna2TextBox1.AppendText(Environment.NewLine + "[+] Almost Done!");
            Process.Start(startInfo2);
            Process.Start(startInfo3);
            Thread.Sleep(400);
            guna2TextBox1.Text = "";
            guna2TextBox1.AppendText("[+] Spoofing Complete.");
            File.Delete(driverpath);
            File.Delete(mapperpath);

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string mainpath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
            string cleanerpath = Path.Combine(mainpath, "cleaner.bat");
            ProcessStartInfo cleanerprocess = new ProcessStartInfo
            {
                FileName = cleanerpath,
                UseShellExecute = false,
                CreateNoWindow = true,
                Verb = "runas",
                
            };
            
            WebClient wc = new WebClient();
            wc.DownloadFile("https://raw.githubusercontent.com/sincerelyryan/spoofstuff/refs/heads/main/clean.bat", cleanerpath);
            guna2TextBox1.AppendText(Environment.NewLine + "[+] Cleaning! Please wait for cleaning to finish, can take 1-2 minutes.");
            Process.Start(cleanerprocess).WaitForExit();
            guna2TextBox1.AppendText(Environment.NewLine + "[+] Cleaning has completed! Please restart your computer.");
            File.Delete(cleanerpath);






        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string mainpath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
            string driverpath = Path.Combine(mainpath, "zopbcnia.sys");
            string mapperpath = Path.Combine(mainpath, "vuxrxafn.exe");
            WebClient wc = new WebClient();
            wc.DownloadFile("https://raw.githubusercontent.com/sincerelyryan/spoofstuff/refs/heads/main/disk.bin", driverpath);
            wc.DownloadFile("https://raw.githubusercontent.com/sincerelyryan/spoofstuff/refs/heads/main/saturn.bin", mapperpath);
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c {mapperpath} {driverpath}",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            ProcessStartInfo startInfo2 = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c net stop winmgmt /y",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            ProcessStartInfo startInfo3 = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c net start winmgmt /y",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process.Start(startInfo).WaitForExit();
            guna2TextBox1.AppendText(Environment.NewLine + "[+] Almost Done!");
            Process.Start(startInfo2);
            Process.Start(startInfo3);
            Thread.Sleep(400);
            guna2TextBox1.Text = "";
            guna2TextBox1.AppendText("[+] Spoofing Complete.");
            File.Delete(driverpath);
            File.Delete(mapperpath);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // disks
            ProcessStartInfo startcmd = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c wmic diskdrive get serialnumber",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startcmd })
            {
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                guna2TextBox2.AppendText("[+] Disk Serials: " + (output.Remove(0, 12).Trim()));
                

            }

            // motherboard
            ProcessStartInfo startcmd2 = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c wmic baseboard get serialnumber",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process2 = new Process { StartInfo = startcmd2 })
            {
                process2.Start();
                string output = process2.StandardOutput.ReadToEnd();
                process2.WaitForExit();
                guna2TextBox2.AppendText(Environment.NewLine);
                guna2TextBox2.AppendText(Environment.NewLine + "[+] Motherboard: " + (output.Remove(0, 12).Trim()));

            }

            // bios
            ProcessStartInfo startcmd3 = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c wmic csproduct get uuid",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process3 = new Process { StartInfo = startcmd3 })
            {
                process3.Start();
                string output = process3.StandardOutput.ReadToEnd();
                process3.WaitForExit();
                guna2TextBox2.AppendText(Environment.NewLine);
                guna2TextBox2.AppendText(Environment.NewLine + "[+] SMBIOS: " + (output.Remove(0, 4).Trim()));

            }

            // cpu
            ProcessStartInfo startcmd4 = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c wmic cpu get processorid",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process4 = new Process { StartInfo = startcmd4 })
            {
                process4.Start();
                string output = process4.StandardOutput.ReadToEnd();
                process4.WaitForExit();
                guna2TextBox2.AppendText(Environment.NewLine);
                guna2TextBox2.AppendText(Environment.NewLine + "[+] CPU: " + (output.Remove(0, 11).Trim()));

            }

            // mac
            ProcessStartInfo startcmd5 = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c wmic path Win32_NetworkAdapter where \"PNPDeviceID like '%%PCI%%' AND NetConnectionStatus=2 AND AdapterTypeID='0'\" get MacAddress",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process5 = new Process { StartInfo = startcmd5 })
            {
                process5.Start();
                string output = process5.StandardOutput.ReadToEnd();
                process5.WaitForExit();
                if (output.Contains("MACAddress"))
                {
                    guna2TextBox2.AppendText(Environment.NewLine);
                    guna2TextBox2.AppendText(Environment.NewLine + "[+] MAC Address: " + (output.Remove(0, 12).Trim()));
                }
                else
                {
                    guna2TextBox2.AppendText(Environment.NewLine);
                    guna2TextBox2.AppendText(Environment.NewLine + "[+] MAC Address Not Found");
                }


            }
            timer3.Stop();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string serials = guna2TextBox2.Text;
            string path = Environment.CurrentDirectory;
            File.WriteAllText(Path.Combine(path, "serials.txt"), serials);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Text = "";
            timer3.Start();
        }
    }
}
