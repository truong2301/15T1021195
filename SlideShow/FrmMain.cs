using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShow
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private bool Dragging;
        private int xPos;
        public string Path { get; set; }
        public bool IsStop { get; set; }
        private int numImage { get; set; }
        List<string> ls_Image = new List<string>();
        int dem = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            IsStop = true;
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    Path = folderBrowserDialog.SelectedPath;
                    string[] directories = Directory.GetFiles(Path);
                    if (directories.Length == 0)
                    {
                        MessageBox.Show("Không có ảnh", "Thông Báo!", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        foreach (string item in directories)
                        {
                            if (item.Contains(".png"))
                            {
                                ls_Image.Add(item);
                            }
                        }
                        Run();
                    }

                }
            }
        }
        private void Run()
        {
            if (ls_Image.Count == 0)
            {
                MessageBox.Show("Không có ảnh", "Thông Báo!", MessageBoxButtons.OK);
            }
            else
            {
                numImage = ls_Image.Count;
                picMain.Image = Image.FromFile(ls_Image[0]);
                ShowImage();
            }
        }
        private void ShowImage()
        {
            //Thread thread = new Thread(() =>
            //{
            while (IsStop)
            {
                picMain.Image = Image.FromFile(ls_Image[dem]);
                pic3.Image = Image.FromFile(ls_Image[dem]);

                Sleep(3000);
                dem++;
                if (dem == numImage)
                {
                    dem = 0;
                }
                if (dem > 0 && ls_Image.Count > 3)
                {
                    pic2.Image = Image.FromFile(ls_Image[dem - 1]);
                }
                if (dem > 1)
                {
                    pic1.Image = Image.FromFile(ls_Image[dem - 2]);

                }
                if (dem <= ls_Image.Count - 3)
                {
                    pic4.Image = Image.FromFile(ls_Image[dem + 1]);
                    pic5.Image = Image.FromFile(ls_Image[dem + 2]);
                }
                else
                {
                    pic4.Image = Image.FromFile(ls_Image[0]);
                    pic5.Image = Image.FromFile(ls_Image[1]);
                }
            }
            //});
            //thread.Start();

        }
        private void Pic3_Click(object sender, EventArgs e)
        {
            Image image = pic3.Image;
            picMain.Image = image;
        }
        private void Pic1_Click(object sender, EventArgs e)
        {
            Image image = pic1.Image;
            picMain.Image = image;
        }

        private void Pic2_Click(object sender, EventArgs e)
        {
            Image image = pic2.Image;
            picMain.Image = image;
        }
        private void Pic4_Click(object sender, EventArgs e)
        {
            Image image = pic4.Image;
            picMain.Image = image;

        }
        private void Pic5_Click(object sender, EventArgs e)
        {
            Image image = pic5.Image;
            picMain.Image = image;
        }
        private void DiChuyen()
        {
            //Control c = sender as Control;
            //int vitri = pictureBox1.Location.X;
            //if (Dragging && c != null)
            //{
            //    c.Left = e.X + c.Left - xPos;
            //    pictureBox2.Location = new Point(c.Left - 150, 3);
            //    pictureBox3.Location = new Point(c.Left + 150, 3);
            //    if (vitri > c.Left)
            //    {
            //        pictureBox1.Image = pictureBox4.Image;

            //    }
            //}
        }

        private void Pic3_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;

        }

        private void Pic3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Dragging = true;
                xPos = e.X;

            }
        }
        /// <summary>
        /// Đoạn mã này dùng để kéo lướt ảnh như trên Iphone nhưng sau 1 hồi làm thì kết quả kéo Ok nhưng ảnh kéo bị trùng.
        /// Do đó tác giả tạm để đấy sau này ai muốn thì có thể sử dụng :)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pic3_MouseMove(object sender, MouseEventArgs e)
        {
            //Control c = sender as Control;
            //int vitri = pic3.Location.X;
            //if (Dragging && c != null)
            //{
            //    Image image1 = pic1.Image;
            //    Image image2 = pic2.Image;
            //    Image image3 = pic3.Image;
            //    Image image4 = pic4.Image;
            //    Image image5 = pic5.Image;



            //    c.Left = e.X + c.Left - xPos;
            //    pic1.Left = c.Left - 220;
            //    pic2.Left = c.Left - 100;
            //    pic4.Left = c.Left + 100;
            //    pic5.Left = c.Left + 220;
            //    View();
            //}
            //timer1.Enabled = true;

        }
        private void View()
        {
            pic4.Image = pic5.Image;
            pic3.Image = pic4.Image;
        }
        /// <summary>
        /// Wait time. Can use UI
        /// </summary>
        /// <param name="milliseconds">Giây</param>
        public void Sleep(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        /// <summary>
        /// Scroll Image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBar1.Value > 0 && hScrollBar1.Value < 20)
            {
                Image image = pic5.Image;
                picMain.Image = image;
            }
            if (hScrollBar1.Value > 20 && hScrollBar1.Value < 40)
            {
                Image image = pic4.Image;
                picMain.Image = image;
            }
            if (hScrollBar1.Value > 40 && hScrollBar1.Value < 60)
            {
                Image image = pic3.Image;
                picMain.Image = image;
            }
            if (hScrollBar1.Value > 60 && hScrollBar1.Value < 80)
            {
                Image image = pic2.Image;
                picMain.Image = image;
            }
            if (hScrollBar1.Value > 80 && hScrollBar1.Value < 100)
            {
                Image image = pic1.Image;
                picMain.Image = image;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (FrmMain.ActiveForm.Size.Width < 700 && ((panelMain.Size.Width *2) < 160))
            {
                panelMain.Size = new Size(panelMain.Size.Width *2, panelMain.Size.Height * 2);
            }
            else if (FrmMain.ActiveForm.Size.Width > 700 && ((panelMain.Size.Width * 2) < (FrmMain.ActiveForm.Size.Width)))
            {
                panelMain.Size = new Size(panelMain.Size.Width * 2, panelMain.Size.Height * 2);
            }
            SetLocationMain();

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (FrmMain.ActiveForm.Size.Width < 700 && ((panelMain.Size.Width / 2) > 20))
            {
                panelMain.Size = new Size(panelMain.Size.Width / 2, panelMain.Size.Height / 2);

            }
            else if(FrmMain.ActiveForm.Size.Width > 700 && ((panelMain.Size.Width / 2) > 20))
            {
                panelMain.Size = new Size(panelMain.Size.Width / 2, panelMain.Size.Height / 2);
            }
            SetLocationMain();

        }
        /// <summary>
        /// Set Location Left of Panel
        /// </summary>
        private void SetLocationMain()
        {
            int location = FrmMain.ActiveForm.Width / 2 - panelMain.Size.Width / 2;
            panelMain.Left = location;
        }
    }
}
