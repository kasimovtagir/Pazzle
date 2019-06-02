using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string colorBlack = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + 0 + ".bmp";

        string pic2 = ""; string pic3 = ""; string pic4 = ""; string pic5 = "";
        string pic6 = ""; string pic7 = ""; string pic8 = ""; string pic9 = "";
        string pic10 = ""; string pic11 = ""; string pic12 = ""; string pic13 = "";
        string pic14 = ""; string pic15 = ""; string pic16 = ""; string pic17 = "";
        // string qwe = "";
        Random rndImgNumb = new Random();
        ArrayList myArray = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        public void Clearing()
        {
            pictureBox1.Dispose();
            pictureBox2.Dispose(); pictureBox3.Dispose(); pictureBox4.Dispose(); pictureBox5.Dispose();
            pictureBox6.Dispose(); pictureBox7.Dispose(); pictureBox8.Dispose(); pictureBox9.Dispose();
            pictureBox10.Dispose(); pictureBox11.Dispose(); pictureBox12.Dispose(); pictureBox13.Dispose();
            pictureBox14.Dispose(); pictureBox15.Dispose(); pictureBox16.Dispose(); pictureBox17.Dispose();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo deletefile = new DirectoryInfo(@"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\");
            if (File.Exists(@"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\"))
            {
                Clearing();
            }
            else
            {
                foreach (FileInfo item in deletefile.GetFiles("*.bmp"))
                {
                    item.Delete();
                }

            }

            // выбор файла 
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string pathFile = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(pathFile);

            // оригинальная картинка
            uploadImage newImage = new uploadImage();
            newImage.DownloadFile(pathFile);

            int count1 = 1;
            IEnumerable<FileInfo> filesToRename = Directory.GetFiles(@"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources").Select(f => new FileInfo(f));
            foreach (FileInfo file in filesToRename)
            {
                string newFileName = $@"{count1++}.bmp";
                string newFileFullPath = Path.Combine(file.DirectoryName, newFileName);
                /*  if (File.Exists(newFileFullPath))
                  {
                      File.Delete(newFileFullPath);
                  }
                  else {
                  File.Move(file.FullName, newFileFullPath); }*/
                File.Move(file.FullName, newFileFullPath);
            }
            FileInfo eew = new FileInfo(@"C: \Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\0.bmp");
            eew.CopyTo(@"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\0.bmp");

            
            int count = 0;
            pic2 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[count] + ".bmp";
            pictureBox2.Image = Image.FromFile(pic2);

            pic3 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox3.Image = Image.FromFile(pic3);

            pic4 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox4.Image = Image.FromFile(pic4);

            pic5 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox5.Image = Image.FromFile(pic5);

            pic6 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox6.Image = Image.FromFile(pic6);

            pic7 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox7.Image = Image.FromFile(pic7);

            pic8 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox8.Image = Image.FromFile(pic8);

            pic9 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox9.Image = Image.FromFile(pic9);

            pic10 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox10.Image = Image.FromFile(pic10);

            pic11 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox11.Image = Image.FromFile(pic11);

            pic12 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox12.Image = Image.FromFile(pic12);

            pic13 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox13.Image = Image.FromFile(pic13);

            pic14 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox14.Image = Image.FromFile(pic14);

            pic15 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox15.Image = Image.FromFile(pic15);

            pic16 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox16.Image = Image.FromFile(pic16);

            pic17 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
            pictureBox17.Image = Image.FromFile(pic17);

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            // qwe = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\bin\Debug\4619543570000.bmp";
            //pictureBox2.Image = Image.FromFile(qwe);

            Random r = new Random();
            // добавление неповторяющихся элементов
            for (int i = 0; i < 100; i++)
            {
                int temp = r.Next(0, 16);
                if (!myArray.Contains(temp))
                    myArray.Add(temp);
            }
            // вывод на экран
            /*foreach (int i in myArray)
                label1.Text += $"{i} ";*/
            //int rndchance = r.Next(1, 17);
            /*
            if (!File.Exists(@"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\"))
            {
                int count = 0;
                pic2 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[count] + ".bmp";
                pictureBox2.Image = Image.FromFile(pic2);

                pic3 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox3.Image = Image.FromFile(pic3);

                pic4 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox4.Image = Image.FromFile(pic4);

                pic5 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox5.Image = Image.FromFile(pic5);

                pic6 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox6.Image = Image.FromFile(pic6);

                pic7 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox7.Image = Image.FromFile(pic7);

                pic8 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox8.Image = Image.FromFile(pic8);

                pic9 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox9.Image = Image.FromFile(pic9);

                pic10 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox10.Image = Image.FromFile(pic10);

                pic11 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox11.Image = Image.FromFile(pic11);

                pic12 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox12.Image = Image.FromFile(pic12);

                pic13 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox13.Image = Image.FromFile(pic13);

                pic14 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox14.Image = Image.FromFile(pic14);

                pic15 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox15.Image = Image.FromFile(pic15);

                pic16 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox16.Image = Image.FromFile(pic16);

                pic17 = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + myArray[++count] + ".bmp";
                pictureBox17.Image = Image.FromFile(pic17);
            }*/
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (pic3 == colorBlack)
            {
                //pictureBox3.Image = pictureBox2.Image;
                pictureBox3.Image = Image.FromFile(pic2);
                pic3 = pic2;
                pictureBox2.Image = Image.FromFile(colorBlack);
                pic2 = colorBlack;
            }
            else if (pic6 == colorBlack)
            {
                // pictureBox6.Image = pictureBox2.Image;
                pictureBox6.Image = Image.FromFile(pic2);
                pic6 = pic2;
                pictureBox2.Image = Image.FromFile(colorBlack);
                pic2 = colorBlack;
            }
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (pic4 == colorBlack)
            {
                //pictureBox4.Image = pictureBox3.Image;
                pictureBox4.Image = Image.FromFile(pic3);
                pic4 = pic3;
                pictureBox3.Image = Image.FromFile(colorBlack);
                pic3 = colorBlack;
            }
            else if (pic7 == colorBlack)
            {
                // pictureBox7.Image = pictureBox3.Image;
                pictureBox7.Image = Image.FromFile(pic3);
                pic7 = pic3;
                pictureBox3.Image = Image.FromFile(colorBlack);
                pic3 = colorBlack;
            }
            else if (pic2 == colorBlack)
            {
                // pictureBox2.Image = pictureBox3.Image;
                pictureBox2.Image = Image.FromFile(pic3);
                pic2 = pic3;
                pictureBox3.Image = Image.FromFile(colorBlack);
                pic3 = colorBlack;
            }

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (pic3 == colorBlack)
            {
                //pictureBox3.Image = pictureBox4.Image;
                pictureBox3.Image = Image.FromFile(pic4);
                pic3 = pic4;
                pictureBox4.Image = Image.FromFile(colorBlack);
                pic4 = colorBlack;
            }
            else if (pic5 == colorBlack)
            {
                // pictureBox5.Image = pictureBox4.Image;
                pictureBox5.Image = Image.FromFile(pic4);
                pic5 = pic4;
                pictureBox4.Image = Image.FromFile(colorBlack);
                pic4 = colorBlack;
            }
            else if (pic8 == colorBlack)
            {
                //pictureBox8.Image = pictureBox4.Image;
                pictureBox8.Image = Image.FromFile(pic4);
                pic8 = pic4;
                pictureBox4.Image = Image.FromFile(colorBlack);
                pic4 = colorBlack;
            }
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (pic4 == colorBlack)
            {
                //pictureBox4.Image = pictureBox5.Image;
                pictureBox4.Image = Image.FromFile(pic5);
                pic4 = pic5;
                pictureBox5.Image = Image.FromFile(colorBlack);
                pic5 = colorBlack;
            }
            else if (pic9 == colorBlack)
            {
                //pictureBox9.Image = pictureBox5.Image;
                pictureBox9.Image = Image.FromFile(pic5);
                pic9 = pic5;
                pictureBox5.Image = Image.FromFile(colorBlack);
                pic5 = colorBlack;
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            if (pic2 == colorBlack)
            {
                //pictureBox2.Image = pictureBox6.Image;
                pictureBox2.Image = Image.FromFile(pic6);
                pic2 = pic6;
                pictureBox6.Image = Image.FromFile(colorBlack);
                pic6 = colorBlack;
            }
            else if (pic7 == colorBlack)
            {
                //pictureBox7.Image = pictureBox6.Image;
                pictureBox7.Image = Image.FromFile(pic6);
                pic7 = pic6;
                pictureBox6.Image = Image.FromFile(colorBlack);
                pic6 = colorBlack;
            }
            else if (pic10 == colorBlack)
            {
                //pictureBox10.Image = pictureBox6.Image;
                pictureBox10.Image = Image.FromFile(pic6);
                pic10 = pic6;
                pictureBox6.Image = Image.FromFile(colorBlack);
                pic6 = colorBlack;
            }
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            if (pic3 == colorBlack)
            {
                //pictureBox3.Image = pictureBox7.Image;
                pictureBox3.Image = Image.FromFile(pic7);
                pic3 = pic7;
                pictureBox7.Image = Image.FromFile(colorBlack);
                pic7 = colorBlack;
            }
            else if (pic6 == colorBlack)
            {
                //pictureBox6.Image = pictureBox7.Image;
                pictureBox6.Image = Image.FromFile(pic7);
                pic6 = pic7;
                pictureBox7.Image = Image.FromFile(colorBlack);
                pic7 = colorBlack;
            }
            else if (pic8 == colorBlack)
            {
                //pictureBox8.Image = pictureBox7.Image;
                pictureBox8.Image = Image.FromFile(pic7);
                pic8 = pic7;
                pictureBox7.Image = Image.FromFile(colorBlack);
                pic7 = colorBlack;
            }
            else if (pic11 == colorBlack)
            {
                //pictureBox11.Image = pictureBox7.Image;
                pictureBox11.Image = Image.FromFile(pic7);
                pic11 = pic7;
                pictureBox7.Image = Image.FromFile(colorBlack);
                pic7 = colorBlack;
            }
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            if (pic4 == colorBlack)
            {
                //pictureBox4.Image = pictureBox8.Image;
                pictureBox4.Image = Image.FromFile(pic8);
                pic4 = pic8;
                pictureBox8.Image = Image.FromFile(colorBlack);
                pic8 = colorBlack;

            }
            else if (pic7 == colorBlack)
            {
                //pictureBox7.Image = pictureBox8.Image;
                pictureBox7.Image = Image.FromFile(pic8);
                pic7 = pic8;
                pictureBox8.Image = Image.FromFile(colorBlack);
                pic8 = colorBlack;
            }
            else if (pic9 == colorBlack)
            {
                //pictureBox9.Image = pictureBox8.Image;
                pictureBox9.Image = Image.FromFile(pic8);
                pic9 = pic8;
                pictureBox8.Image = Image.FromFile(colorBlack);
                pic8 = colorBlack;
            }
            else if (pic12 == colorBlack)
            {
                //pictureBox12.Image = pictureBox8.Image;
                pictureBox12.Image = Image.FromFile(pic8);
                pic12 = pic8;
                pictureBox8.Image = Image.FromFile(colorBlack);
                pic8 = colorBlack;

            }
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            if (pic5 == colorBlack)
            {
                //pictureBox5.Image = pictureBox9.Image;
                pictureBox5.Image = Image.FromFile(pic9);
                pic5 = pic9;
                pictureBox9.Image = Image.FromFile(colorBlack);
                pic9 = colorBlack;
            }
            else if (pic8 == colorBlack)
            {
                // pictureBox8.Image = pictureBox9.Image;
                pictureBox8.Image = Image.FromFile(pic9);
                pic8 = pic9;
                pictureBox9.Image = Image.FromFile(colorBlack);
                pic9 = colorBlack;
            }
            else if (pic13 == colorBlack)
            {
                //pictureBox13.Image = pictureBox9.Image;
                pictureBox13.Image = Image.FromFile(pic9);
                pic13 = pic9;
                pictureBox9.Image = Image.FromFile(colorBlack);
                pic9 = colorBlack;
            }
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            if (pic6 == colorBlack)
            {
                pictureBox6.Image = Image.FromFile(pic10);
                pic6 = pic10;
                pictureBox10.Image = Image.FromFile(colorBlack);
                pic10 = colorBlack;
            }
            else if (pic11 == colorBlack)
            {

                pictureBox11.Image = Image.FromFile(pic10);
                pic11 = pic10;
                pictureBox10.Image = Image.FromFile(colorBlack);
                pic10 = colorBlack;
            }
            else if (pic14 == colorBlack)
            {
                pictureBox14.Image = Image.FromFile(pic10);
                pic14 = pic10;
                pictureBox10.Image = Image.FromFile(colorBlack);
                pic10 = colorBlack;
            }
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            if (pic7 == colorBlack)
            {
                pictureBox7.Image = Image.FromFile(pic11);
                pic7 = pic11;
                pictureBox11.Image = Image.FromFile(colorBlack);
                pic11 = colorBlack;
            }
            else if (pic10 == colorBlack)
            {

                pictureBox10.Image = Image.FromFile(pic11);
                pic10 = pic11;
                pictureBox11.Image = Image.FromFile(colorBlack);
                pic11 = colorBlack;
            }
            else if (pic12 == colorBlack)
            {
                pictureBox12.Image = Image.FromFile(pic11);
                pic12 = pic11;
                pictureBox11.Image = Image.FromFile(colorBlack);
                pic11 = colorBlack;
            }
            else if (pic15 == colorBlack)
            {
                pictureBox15.Image = Image.FromFile(pic11);
                pic15 = pic11;
                pictureBox11.Image = Image.FromFile(colorBlack);
                pic11 = colorBlack;
            }
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            if (pic8 == colorBlack)
            {
                pictureBox8.Image = Image.FromFile(pic12);
                pic8 = pic12;
                pictureBox12.Image = Image.FromFile(colorBlack);
                pic12 = colorBlack;
            }
            else if (pic11 == colorBlack)
            {

                pictureBox11.Image = Image.FromFile(pic12);
                pic11 = pic12;
                pictureBox12.Image = Image.FromFile(colorBlack);
                pic12 = colorBlack;
            }
            else if (pic13 == colorBlack)
            {
                pictureBox13.Image = Image.FromFile(pic12);
                pic13 = pic12;
                pictureBox12.Image = Image.FromFile(colorBlack);
                pic12 = colorBlack;
            }
            else if (pic16 == colorBlack)
            {
                pictureBox16.Image = Image.FromFile(pic12);
                pic16 = pic12;
                pictureBox12.Image = Image.FromFile(colorBlack);
                pic12 = colorBlack;
            }
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            if (pic9 == colorBlack)
            {
                pictureBox9.Image = Image.FromFile(pic13);
                pic9 = pic13;
                pictureBox13.Image = Image.FromFile(colorBlack);
                pic13 = colorBlack;
            }
            else if (pic12 == colorBlack)
            {

                pictureBox12.Image = Image.FromFile(pic13);
                pic12 = pic13;
                pictureBox13.Image = Image.FromFile(colorBlack);
                pic13 = colorBlack;
            }
            else if (pic17 == colorBlack)
            {
                pictureBox17.Image = Image.FromFile(pic13);
                pic17 = pic13;
                pictureBox13.Image = Image.FromFile(colorBlack);
                pic13 = colorBlack;
            }
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            if (pic10 == colorBlack)
            {
                pictureBox10.Image = Image.FromFile(pic14);
                pic10 = pic14;
                pictureBox14.Image = Image.FromFile(colorBlack);
                pic14 = colorBlack;
            }
            else if (pic15 == colorBlack)
            {

                pictureBox15.Image = Image.FromFile(pic14);
                pic15 = pic14;
                pictureBox14.Image = Image.FromFile(colorBlack);
                pic14 = colorBlack;
            }
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            if (pic11 == colorBlack)
            {
                pictureBox11.Image = Image.FromFile(pic15);
                pic11 = pic15;
                pictureBox15.Image = Image.FromFile(colorBlack);
                pic15 = colorBlack;
            }
            else if (pic14 == colorBlack)
            {
                pictureBox14.Image = Image.FromFile(pic15);
                pic14 = pic15;
                pictureBox15.Image = Image.FromFile(colorBlack);
                pic15 = colorBlack;
            }
            else if (pic16 == colorBlack)
            {
                pictureBox16.Image = Image.FromFile(pic15);
                pic16 = pic15;
                pictureBox15.Image = Image.FromFile(colorBlack);
                pic15 = colorBlack;
            }
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            if (pic12 == colorBlack)
            {
                pictureBox12.Image = Image.FromFile(pic16);
                pic12 = pic16;
                pictureBox16.Image = Image.FromFile(colorBlack);
                pic16 = colorBlack;
            }
            else if (pic15 == colorBlack)
            {
                pictureBox15.Image = Image.FromFile(pic16);
                pic15 = pic16;
                pictureBox16.Image = Image.FromFile(colorBlack);
                pic16 = colorBlack;
            }
            else if (pic17 == colorBlack)
            {
                pictureBox17.Image = Image.FromFile(pic16);
                pic17 = pic16;
                pictureBox16.Image = Image.FromFile(colorBlack);
                pic16 = colorBlack;
            }
        }
        private void PictureBox17_Click(object sender, EventArgs e)
        {
            if (pic13 == colorBlack)
            {
                pictureBox13.Image = Image.FromFile(pic17);
                pic13 = pic17;
                pictureBox17.Image = Image.FromFile(colorBlack);
                pic17 = colorBlack;
            }
            else if (pic16 == colorBlack)
            {
                pictureBox16.Image = Image.FromFile(pic17);
                pic16 = pic17;
                pictureBox17.Image = Image.FromFile(colorBlack);
                pic17 = colorBlack;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           // Clearing();
           Process.Start(Application.ExecutablePath);
            Close();
            /*button1.PerformClick();
            DirectoryInfo deletefile = new DirectoryInfo(@"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\");
            foreach (FileInfo item in deletefile.GetFiles("0.bmp"))
            {
                item.Delete();
            }*/

        }


        /* private void Label1_Click(object sender, EventArgs e)
         {
             string[] qwe = new string[15];
             //qwe = System.IO.Directory.GetFiles(@"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\bin\Debug");

             label1.Text = "";
             string namefileblat = "";
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\bin\Debug");
             foreach (FileInfo item in dir.GetFiles("*.bmp"))
             {
                 label1.Text += item.Name + "\n";
                 namefileblat += item.Name + ",";
             }

             /*for (int i = 0; i <= dir.Name.Length-1; i++)
              {
                  qwe[i] = dir.Name;
              }

             foreach (var item in qwe)
             {
                 label1.Text += item;
             }*/
        //qwe = dir.GetFiles("*.bmp");
        /*
        foreach (FileInfo  item in dir.GetFiles("*.bmp"))
        {
            label1.Text += item.Name+"\n";

        }
        label1.Text = qwe[5].ToString();
        string eee = label1.Text;
        label1.Text = "";
        for (int i = 75; i <= eee.Length-1; i++)
        {
            label1.Text += eee[i].ToString();
        }
        //"C:\\Users\\Tagir Kasimov\\Desktop\\WindowsFormsApp3\\WindowsFormsApp3\\bin\\Debug\\4619543570101.bmp"
        //label1.Text = Convert.ToString( label1.Text.Length);
        //label1.Text = label1.Text;
       /* foreach (var item in qwe)
        {
            label1.Text += item;
        }
    }*/
    }
}