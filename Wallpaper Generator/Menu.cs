using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Wallpaper_Generator.Classes;

namespace Wallpaper_Generator
{
    
    public partial class Menu : Form
    {
        string path;
        int staSto = 0;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            path = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Pictures","Wallpaper Generator");
            
            Access.GrantAccess(path);
            
            Info.Text=path;
        }


        public void tText(int TimeOut)
        {
            do
            {
                try
                {
                    Random r = new Random();
                    
                    Bitmap bitmap = new Bitmap(Convert.ToInt32(1920), Convert.ToInt32(1080), PixelFormat.Format32bppArgb);
                    
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        LinearGradientBrush linGrBrush = new LinearGradientBrush
                                (
                                new Point(0, 0),
                                new Point(0, 1920),
                                Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)),
                                Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256), r.Next(0, 256))
                                );
                        using (linGrBrush)
                        {
                            g.FillRectangle(linGrBrush, 0, 0, 1920, 1080);
                            
                            Thread.Sleep(30);
                            
                            bitmap.Save(path + "\\test.jpeg", ImageFormat.Jpeg);
                            
                            Display.BackgroundImage = bitmap;
                            
                            if (SetCheck.Checked)
                                SetWallpaper.Set(SetWallpaper.Style.Fill, path + "\\test.jpeg");
                        }
                    }
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Thread.Sleep(TimeOut);

            }
            while (staSto == 1);
        }
        
        private void Start_Click(object sender, EventArgs e)
        {
            int Time = Helper.ItemToInt(Czas.Text);
            Thread thread = new Thread(() => tText(Time));
            if (staSto != 1)
            {
                staSto=1;
                Start.Text = "Stop";
                thread.Start();
            }
            else if (staSto == 1)
            {
                staSto=0;
                Start.Text = "Start";
            }
        }

        //kliknięcie w obrazek (Display)
        private void Display_Click(object sender, EventArgs e)
        {
            //pseudo random
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            staSto = 0;
            Application.Exit();
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void Notify_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Notify_Click(object sender, EventArgs e)
        {

        }
        

        private void QuitNotify_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}

