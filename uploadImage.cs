using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApp3
{
    class uploadImage
    {
        public string[] downloadArrayimg = new string[15];
        public string filename = " ";
        public void DownloadFile(string pathFile)
        {
            // получение разрещения файла 
            System.Drawing.Image img = System.Drawing.Image.FromFile(pathFile);
            //MessageBox.Show("Width: " + img.Width + ", Height: " + img.Height);

            int wid = img.Width / 4;
            int hgt = img.Height / 4;

            // Get the inputs.
            Bitmap bm = LoadUnlocked(pathFile);

            // Start splitting the Bitmap.
            string piece_name = Path.GetFileNameWithoutExtension(pathFile);
            Bitmap piece = new Bitmap(wid, hgt);
            Rectangle dest_rect = new Rectangle(0, 0, wid, hgt);
            using (Graphics gr = Graphics.FromImage(piece))
            {
                int num_rows = bm.Height / hgt;
                int num_cols = bm.Width / wid;
                Rectangle source_rect = new Rectangle(0, 0, wid, hgt);
                for (int row = 0; row < num_rows; row++)
                {
                    source_rect.X = 0;
                    for (int col = 0; col < num_cols; col++)
                    {
                        // Copy the piece of the image.
                        gr.DrawImage(bm, dest_rect, source_rect, GraphicsUnit.Pixel);

                        piece_name = "";
                        string filename = piece_name +
                            row.ToString("00") +
                            col.ToString("00") + ".bmp";
                        // Save the piece.                    
                        /*  string filename = piece_name +
                              row.ToString("00") +
                              col.ToString("00") + ".bmp";*/
                        piece.Save(filename, ImageFormat.Bmp);
                        string path = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\bin\Debug\"+ filename;
                        string newPath = @"C:\Users\Tagir Kasimov\Desktop\WindowsFormsApp3\WindowsFormsApp3\Resources\" + filename;
                        FileInfo fileInf = new FileInfo(path);
                        if (fileInf.Exists)
                        {
                           
                           fileInf.CopyTo(newPath);
                           
                        }
                       // else {  fileInf.Delete();  }
                            // Move to the next column.
                            source_rect.X += wid;
                    }
                    
                    source_rect.Y += hgt;
                }
                MessageBox.Show("Created " + num_rows * num_cols + " files",
                    "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        // Load a Bitmap without locking its file.
        private Bitmap LoadUnlocked(string file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                return new Bitmap(bm);
            }
        }
    }
}
