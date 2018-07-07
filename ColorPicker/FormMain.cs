using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorPicker {
   public partial class FormMain : Form {
      public FormMain() {
         InitializeComponent();
      }

      private void pbxCap_MouseMove(object sender, MouseEventArgs e) {
         if (Control.MouseButtons != MouseButtons.Left)
            return;

         int zoom = 4;
         var scrPt = this.pbxCap.PointToScreen(e.Location)-new Size(this.pbxCap.Width/zoom/2, this.pbxCap.Height/zoom/2);
         var bmp = new Bitmap(this.pbxCap.Width/zoom, this.pbxCap.Height/zoom);

         // capture
         var gfxBmp = Graphics.FromImage(bmp);
         gfxBmp.CopyFromScreen(scrPt, Point.Empty, bmp.Size);
         gfxBmp.Dispose();

         // get pick color
         Color pickColor = bmp.GetPixel(bmp.Width/2, bmp.Height/2);

         // draw crosshair
         bmp.SetPixel(bmp.Width/2-2, bmp.Height/2, Color.Green);
         bmp.SetPixel(bmp.Width/2, bmp.Height/2-2, Color.Green);
         bmp.SetPixel(bmp.Width/2+2, bmp.Height/2, Color.Green);
         bmp.SetPixel(bmp.Width/2, bmp.Height/2+2, Color.Green);

         // draw capture
         var gfxCap = this.pbxCap.CreateGraphics();
         gfxCap.InterpolationMode = InterpolationMode.NearestNeighbor;
         gfxCap.FillRectangle(Brushes.Gray, this.pbxCap.DisplayRectangle);
         gfxCap.DrawImage(bmp, this.pbxCap.DisplayRectangle);
         gfxCap.DrawRectangle(Pens.Black, this.pbxCap.DisplayRectangle);
         
         // draw color rectangle
         var brColor = new SolidBrush(pickColor);
         var rectColor = new Rectangle(0, 0, this.pbxCap.Width/3, this.pbxCap.Height/3);
         gfxCap.FillRectangle(brColor, rectColor);
         gfxCap.DrawRectangle(Pens.Black, rectColor);
         brColor.Dispose();

         gfxCap.Dispose();
         bmp.Dispose();

         // display color value
         this.tbxRgb.Text = $"({pickColor.R}, {pickColor.G}, {pickColor.B})";
         this.tbxHex.Text = ColorTranslator.ToHtml(pickColor);
         this.tbxRgb.Refresh();
         this.tbxHex.Refresh();
      }
   }
}
