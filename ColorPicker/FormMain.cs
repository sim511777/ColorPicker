using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// crosshair blending
// change DrawPicturebox
// change to WmPaint

namespace ColorPicker {
   public partial class FormMain : Form {
      private int zoom;
      private Bitmap bmp;
      Color colPick;// = Color.Black;

      public FormMain() {
         InitializeComponent();
         this.zoom = 4;
         this.bmp = new Bitmap(this.pbxCap.Width / zoom, this.pbxCap.Height / zoom);
      }

      private void CaptureScreen(Point pt) {
         var ptCap = pt - new Size(this.bmp.Width / 2, this.bmp.Height / 2);
         var g = Graphics.FromImage(this.bmp);
         g.FillRectangle(Brushes.Gray, 0, 0, this.bmp.Width, this.bmp.Height);
         g.CopyFromScreen(ptCap, Point.Empty, this.bmp.Size);
         g.Dispose();
      }

      private void GetColor() {
         colPick = bmp.GetPixel(bmp.Width / 2, bmp.Height / 2);
      }

      private void DrawCrosshairToBmp() {
         int size = 2;
         Point[] pt4 = {
            new Point(bmp.Width / 2 - size, bmp.Height / 2),
            new Point(bmp.Width / 2, bmp.Height / 2 - size),
            new Point(bmp.Width / 2 + size, bmp.Height / 2),
            new Point(bmp.Width / 2, bmp.Height / 2 + size)
         };
         foreach (var pt in pt4) {
            Color colBg = bmp.GetPixel(pt.X, pt.Y);
            Color col = Color.Fuchsia;
            float f = 0.7f;
            int r = (int)(col.R * f + colBg.R * (1-f));
            int g = (int)(col.G * f + colBg.G * (1-f));
            int b = (int)(col.B * f + colBg.B * (1-f));
            Color colNew = Color.FromArgb(r, g, b);
            bmp.SetPixel(pt.X, pt.Y, colNew);
         }
      }

      private void DrawBmpToPictureBox(Graphics g) {
         // draw capture rectangle
         Rectangle rectCap = this.pbxCap.DisplayRectangle;
         g.InterpolationMode = InterpolationMode.NearestNeighbor;
         g.DrawImage(bmp, rectCap);
         g.DrawRectangle(Pens.Black, rectCap);

         // draw color rectangle
         var rectColor = new Rectangle(0, 0, 90, 90);
         var br = new SolidBrush(colPick);
         g.FillRectangle(br, rectColor);
         br.Dispose();
         g.DrawRectangle(Pens.Black, rectColor);
      }

      private void DisplayColorValue() {
         this.tbxRgb.Text = $"({this.colPick.R}, {this.colPick.G}, {this.colPick.B})";
         this.tbxHtml.Text = ColorTranslator.ToHtml(this.colPick);
         this.tbxRgb.Refresh();
         this.tbxHtml.Refresh();
      }

      private void pbxCap_MouseMove(object sender, MouseEventArgs e) {
         if (Control.MouseButtons != MouseButtons.Left)
            return;

         this.CaptureScreen(this.pbxCap.PointToScreen(e.Location));
         this.GetColor();
         this.pbxCap.Refresh();
         this.DisplayColorValue();
      }

      private void pbxCap_Paint(object sender, PaintEventArgs e) {
         this.DrawCrosshairToBmp();
         this.DrawBmpToPictureBox(e.Graphics);
      }
   }
}
