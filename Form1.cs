using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WinFormsApp1 {
    public partial class Form1 : Form {


        Bitmap image1;
        int[] heights;

        int map_size_x;
        int map_size_y;

        int shift_x = 1;
        int shift_y = 1;

        public Form1()
        {
            InitializeComponent();
            do_stuff();

            this.FormBorderStyle = FormBorderStyle.None;

            //initialiseFormEdge();

            txtL.Text = String.Format("{0:0.00}", L);
            txtS.Text = String.Format("{0:0.00}", S);
            txtH.Text = H.ToString();

            txt_shift_y.Text = shift_y.ToString();
            txt_shift_x.Text = shift_x.ToString();

            //forced stuff
            btnCenter.Select();
            lbl_empty.Focus();
            splitContainer1.Cursor = DefaultCursor;
        }

        public void Move_MapBox(int x = 0, int y = 0)
        {
            shift_x += x;
            shift_y += y;

            txt_shift_x.Text = shift_x.ToString();
            txt_shift_y.Text = shift_y.ToString();

            picboxMap.Location = new System.Drawing.Point(picboxMap.Location.X + x, picboxMap.Location.Y + y);

            lbl_empty.Focus();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files_paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files_paths.Length != 1)
            {
                MessageBox.Show("Only Drop 1 File");
                return;
            }

            var ext = System.IO.Path.GetExtension(files_paths[0]);
            if (!ext.Equals(".json", StringComparison.CurrentCultureIgnoreCase))
            {
                MessageBox.Show("Map Format Invalid");
                return;
            }
            Retrieve_MapData(files_paths[0]);
        }

        int H = 16;
        float S = 0.91F;
        float L = 0.48F;

        float zoom_level = 3F;

        private void Retrieve_MapData(string filepath)
        {
            Root tm = JsonSerializer.Deserialize<Root>(File.ReadAllText(filepath));

            // getting map size
            map_size_x = tm.Singletons.MapSize.Size.X; //(MIN: 4x4, MAX: 256x256)
            map_size_y = tm.Singletons.MapSize.Size.Y;

            image1 = new Bitmap(map_size_x, map_size_y);

            heights = tm.Singletons.TerrainMap.Heights.Array.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Class1.Draw(ref heights, ref image1, H, S, L);
            Bitmap image1_zoomed = Class1.Zoom(image1, zoom_level);

            picboxMap.Size = image1_zoomed.Size;
            Move_MapBox();

            picboxMap.Image = image1_zoomed;
        }

        private void Change_MapColors()
        {
            Class1.Draw(ref heights, ref image1, H, S, L);
            Bitmap image1_zoomed = Class1.Zoom(image1, zoom_level);

            picboxMap.Image = image1_zoomed;
            picboxMap.Size = image1_zoomed.Size;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_size_x.Text))
            {
                string coord_x = txt_size_x.Text;
            }
        }
        private void LUp_Click(object sender, EventArgs e)
        {
            L += 0.03F;
            txtL.Text = String.Format("{0:0.00}", L);
            Change_MapColors();
        }
        private void LDown_Click(object sender, EventArgs e)
        {
            L -= 0.03F;
            txtL.Text = String.Format("{0:0.00}", L);
            Change_MapColors();
        }
        private void SUp_Click(object sender, EventArgs e)
        {
            S += 0.03F;
            txtS.Text = String.Format("{0:0.00}", S);
            Change_MapColors();
        }
        private void SDown_Click(object sender, EventArgs e)
        {
            S -= 0.03F;
            txtS.Text = String.Format("{0:0.00}", S);
            Change_MapColors();
        }
        private void HueSUp_Click(object sender, EventArgs e)
        {
            H += 1;
            txtH.Text = H.ToString();
            Change_MapColors();
        }
        private void HueSDown_Click(object sender, EventArgs e)
        {
            H -= 1;
            txtH.Text = H.ToString();
            Change_MapColors();
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            Move_MapBox(0, -1);
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            Move_MapBox(1, 0);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            Move_MapBox(0, 1);
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            Move_MapBox(-1, 0);
        }
        private void btnCenter_Click(object sender, EventArgs e)
        {
            Move_MapBox(shift_x + pictureBox1.Location.X + (pictureBox1.Size.Width / 2), shift_y + pictureBox1.Location.Y + (pictureBox1.Size.Height / 2));
        }

        string txtL_default = string.Empty;

        private void txtL_Enter(object sender, EventArgs e)
        {
            txtL_default = txtL.Text;
            txtL.Text = string.Empty;
            txtL.Focus();
        }
        private void txtL_Leave(object sender, EventArgs e)
        {
            txtL.Text = txtL_default;
        }
        private void txtL_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtL.Text, out float temp))
            {
                if (temp > 1F)
                    L = 1F;
                else if (temp < 0F)
                    L = 0F;
                else
                    L = temp;
                txtL.Text = L.ToString();
            }
            else
                MessageBox.Show("L value is not float");
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            btnCenter.Select();
            lbl_empty.Focus();
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

            //MessageBox.Show("hi");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(MousePosition.X - lastLocation.X, MousePosition.Y - lastLocation.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private Point lastlocation_drag;
        private System.Drawing.Size lastSize;

        private void panel_NW_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastlocation_drag = MousePosition;
            lastSize = this.Size;
        }

        private void panel_NW_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(MousePosition.X, MousePosition.Y);

                this.Size = new System.Drawing.Size(lastSize.Width + ((lastlocation_drag.X - MousePosition.X) + e.X), lastSize.Height + ((lastlocation_drag.Y - MousePosition.Y) + e.Y));

                this.Update();
            }
        }

        private void panel_NW_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        protected void do_stuff()
        {
            int resizeWidth = 8;
            bool mouseDown = false;
            Point lastlocation_drag;
            /*
            this.MouseDown += new MouseEventHandler(form_MouseDown);
            this.MouseMove += new MouseEventHandler(form_MouseMove);
            this.MouseUp += delegate (object sender, MouseEventArgs e)
            {
                mouseDown = false;
            };
            */

            // SE
            UserControl Resize_SE = new UserControl()
            {
                Anchor = (AnchorStyles.Bottom | AnchorStyles.Right),
                Height = resizeWidth,
                Width = resizeWidth,
                Left = this.Width - resizeWidth,
                Top = this.Height - resizeWidth,
                BackColor = Color.RoyalBlue,
                Cursor = Cursors.SizeNWSE
            };
            Resize_SE.MouseDown += form_MouseDown;
            Resize_SE.MouseUp += form_MouseMove;
            Resize_SE.MouseMove += form_MouseUp;

            Resize_SE.BringToFront();

            this.Controls.Add(Resize_SE);


            void form_MouseDown(object sender, MouseEventArgs e)
            {
                mouseDown = true;
                lastlocation_drag = MousePosition;
                lastSize = this.Size;
            }

            void form_MouseMove(object sender, MouseEventArgs e)
            {
                if (mouseDown)
                {
                    this.Location = new Point(MousePosition.X, MousePosition.Y);

                    this.Size = new System.Drawing.Size(lastSize.Width + ((lastlocation_drag.X - MousePosition.X) + e.X), lastSize.Height + ((lastlocation_drag.Y - MousePosition.Y) + e.Y));

                    this.Update();
                }
            }

            void form_MouseUp(object sender, MouseEventArgs e)
            {
                mouseDown = false;
            }
        }

    /*
        protected bool isDragging = false;
        protected Rectangle lastRectangle = new Rectangle();


        protected void initialiseFormEdge()
        {
            int resizeWidth = 5;

            this.MouseDown += new MouseEventHandler(form_MouseDown);
            this.MouseMove += new MouseEventHandler(form_MouseMove);
            this.MouseUp += delegate (object sender, MouseEventArgs e)
            {
                isDragging = false;
            };

            // bottom
            UserControl uc1 = new UserControl()
            {
                Anchor = (AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right),
                Height = resizeWidth,
                Width = this.DisplayRectangle.Width - (resizeWidth * 2),
                Left = resizeWidth,
                Top = this.DisplayRectangle.Height - resizeWidth,
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeNS
            };
            uc1.MouseDown += form_MouseDown;
            uc1.MouseUp += form_MouseUp;
            uc1.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    this.Size = new System.Drawing.Size(lastRectangle.Width, e.Y - lastRectangle.Y + this.Height);
                }
            };
            uc1.BringToFront();

            this.Controls.Add(uc1);

            // right
            UserControl uc2 = new UserControl()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom),
                Height = this.DisplayRectangle.Height - (resizeWidth * 2),
                Width = resizeWidth,
                Left = this.DisplayRectangle.Width - resizeWidth,
                Top = resizeWidth,
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeWE
            };
            uc2.MouseDown += form_MouseDown;
            uc2.MouseUp += form_MouseUp;
            uc2.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    this.Size = new System.Drawing.Size(e.X - lastRectangle.X + this.Width, lastRectangle.Height);
                }
            };
            uc2.BringToFront();

            this.Controls.Add(uc2);

            // bottom-right
            UserControl uc3 = new UserControl()
            {
                Anchor = (AnchorStyles.Bottom | AnchorStyles.Right),
                Height = resizeWidth,
                Width = resizeWidth,
                Left = this.DisplayRectangle.Width - resizeWidth,
                Top = this.DisplayRectangle.Height - resizeWidth,
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeNWSE
            };
            uc3.MouseDown += form_MouseDown;
            uc3.MouseUp += form_MouseUp;
            uc3.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    this.Size = new System.Drawing.Size((e.X - lastRectangle.X + this.Width), (e.Y - lastRectangle.Y + this.Height));
                }
            };
            uc3.BringToFront();

            this.Controls.Add(uc3);

            // top-right
            UserControl uc4 = new UserControl()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Right),
                Height = resizeWidth,
                Width = resizeWidth,
                Left = this.DisplayRectangle.Width - resizeWidth,
                Top = 0,
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeNESW
            };
            uc4.MouseDown += form_MouseDown;
            uc4.MouseUp += form_MouseUp;
            uc4.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    int diff = (e.Location.Y - lastRectangle.Y);
                    int y = (this.Location.Y + diff);

                    this.Location = new Point(this.Location.X, y);
                    this.Size = new System.Drawing.Size(e.X - lastRectangle.X + this.Width, (this.Height + (diff * -1)));
                }
            };
            uc4.BringToFront();
            //uc4.BackColor = Color.Firebrick;

            this.Controls.Add(uc4);

            // top
            UserControl uc5 = new UserControl()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right),
                Height = resizeWidth,
                Width = this.DisplayRectangle.Width - (resizeWidth * 2),
                Left = resizeWidth,
                Top = 0,
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeNS
            };
            uc5.MouseDown += form_MouseDown;
            uc5.MouseUp += form_MouseUp;
            uc5.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    int diff = (e.Location.Y - lastRectangle.Y);
                    int y = (this.Location.Y + diff);

                    this.Location = new Point(this.Location.X, y);
                    this.Size = new System.Drawing.Size(lastRectangle.Width, (this.Height + (diff * -1)));
                }
            };
            uc5.BringToFront();

            this.Controls.Add(uc5);

            // left
            UserControl uc6 = new UserControl()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom),
                Height = this.DisplayRectangle.Height - (resizeWidth * 2),
                Width = resizeWidth,
                Left = 0,
                Top = resizeWidth,
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeWE
            };
            uc6.MouseDown += form_MouseDown;
            uc6.MouseUp += form_MouseUp;
            uc6.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    int diff = (e.Location.X - lastRectangle.X);
                    int x = (this.Location.X + diff);

                    this.Location = new Point(x, this.Location.Y);
                    this.Size = new System.Drawing.Size((this.Width + (diff * -1)), this.Height);
                }
            };
            uc6.BringToFront();

            this.Controls.Add(uc6);

            // bottom-left
            UserControl uc7 = new UserControl()
            {
                Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
                Height = resizeWidth,
                Width = resizeWidth,
                Left = 0,
                Top = this.DisplayRectangle.Height - resizeWidth,
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeNESW
            };
            uc7.MouseDown += form_MouseDown;
            uc7.MouseUp += form_MouseUp;
            uc7.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    int diff = (e.Location.X - lastRectangle.X);
                    int x = (this.Location.X + diff);

                    this.Location = new Point(x, this.Location.Y);
                    this.Size = new System.Drawing.Size((this.Width + (diff * -1)), (e.Y - lastRectangle.Y + this.Height));
                }
            };
            uc7.BringToFront();

            this.Controls.Add(uc7);

            // bottom-left
            UserControl uc8 = new UserControl()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Left),
                Height = resizeWidth,
                Width = resizeWidth,
                Left = 0,
                Top = 0,
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeNWSE
            };
            uc8.MouseDown += form_MouseDown;
            uc8.MouseUp += form_MouseUp;
            uc8.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    int dX = (e.Location.X - lastRectangle.X);
                    int dY = (e.Location.Y - lastRectangle.Y);
                    int x = (this.Location.X + dX);
                    int y = (this.Location.Y + dY);

                    this.Location = new Point(x, y);
                    this.Size = new System.Drawing.Size((this.Width + (dX * -1)), (this.Height + (dY * -1)));
                }
            };
            uc8.BringToFront();

            this.Controls.Add(uc8);
        }

        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastRectangle = new Rectangle(e.Location.X, e.Location.Y, this.Width, this.Height);
            }
        }

        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int x = (this.Location.X + (e.Location.X - lastRectangle.X));
                int y = (this.Location.Y + (e.Location.Y - lastRectangle.Y));

                this.Location = new Point(x, y);
            }
            this.Update();
        }

        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        */
    }
}
