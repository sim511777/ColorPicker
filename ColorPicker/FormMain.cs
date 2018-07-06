using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace ColorPicker {
   public partial class FormMain : Form {
      public FormMain() {
         InitializeComponent();
      }

      private void pbxCapture_MouseMove(object sender, MouseEventArgs e) {
         if (Control.MouseButtons != MouseButtons.Left)
            return;

         Color pickColor;
         
         int zoom = (int)this.numZoom.Value;
         
         using (var bmp = new Bitmap(this.pbxCapture.Size.Width/zoom, this.pbxCapture.Size.Height/zoom))
         using (var bmpGfx = Graphics.FromImage(bmp)) {
            var scrPt = this.pbxCapture.PointToScreen(e.Location)-new Size(bmp.Width/2, bmp.Height/2);
            
            bmpGfx.CopyFromScreen(scrPt, Point.Empty, bmp.Size);  // capture desktop

            pickColor = bmp.GetPixel(bmp.Width/2, bmp.Height/2);  // get pick color
            
            using (Graphics gPbx = this.pbxCapture.CreateGraphics()) {
               gPbx.InterpolationMode = InterpolationMode.NearestNeighbor;
               gPbx.DrawImage(bmp, this.pbxCapture.ClientRectangle); // draw capture box
               
               // draw crosshair
               Pen pen = new Pen(Color.Yellow);
               pen.DashStyle = DashStyle.Dot;
               gPbx.DrawLine(pen, this.pbxCapture.Width/2, 0, this.pbxCapture.Width/2, this.pbxCapture.Height);
               gPbx.DrawLine(pen, 0, this.pbxCapture.Height/2, this.pbxCapture.Width, this.pbxCapture.Height/2);
               pen.Dispose();
            } 
         }

         // fill color box
         using (Brush br = new SolidBrush(pickColor))
         using (Graphics gColor = this.pbxColor.CreateGraphics()) {
            gColor.FillRectangle(br, this.pbxColor.ClientRectangle);
         }

         // display color value
         this.tbxRgb.Text = $"{pickColor.R},{pickColor.G},{pickColor.B}";
         this.tbxHex.Text = ColorTranslator.ToHtml(pickColor);
         this.tbxRgb.Refresh();
         this.tbxHex.Refresh();
      }
   }
}
