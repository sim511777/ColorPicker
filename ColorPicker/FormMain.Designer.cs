namespace ColorPicker {
   partial class FormMain {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent() {
         this.pbxCapture = new System.Windows.Forms.PictureBox();
         this.tbxHex = new System.Windows.Forms.TextBox();
         this.tbxRgb = new System.Windows.Forms.TextBox();
         this.numZoom = new System.Windows.Forms.NumericUpDown();
         this.label3 = new System.Windows.Forms.Label();
         this.pbxColor = new System.Windows.Forms.PictureBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pbxCapture)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).BeginInit();
         this.SuspendLayout();
         // 
         // pbxCapture
         // 
         this.pbxCapture.BackColor = System.Drawing.Color.Black;
         this.pbxCapture.Location = new System.Drawing.Point(12, 12);
         this.pbxCapture.Name = "pbxCapture";
         this.pbxCapture.Size = new System.Drawing.Size(128, 128);
         this.pbxCapture.TabIndex = 0;
         this.pbxCapture.TabStop = false;
         this.pbxCapture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxCapture_MouseMove);
         // 
         // tbxHex
         // 
         this.tbxHex.BackColor = System.Drawing.SystemColors.Window;
         this.tbxHex.Location = new System.Drawing.Point(176, 91);
         this.tbxHex.Name = "tbxHex";
         this.tbxHex.ReadOnly = true;
         this.tbxHex.Size = new System.Drawing.Size(70, 21);
         this.tbxHex.TabIndex = 2;
         // 
         // tbxRgb
         // 
         this.tbxRgb.BackColor = System.Drawing.SystemColors.Window;
         this.tbxRgb.Location = new System.Drawing.Point(176, 66);
         this.tbxRgb.Name = "tbxRgb";
         this.tbxRgb.ReadOnly = true;
         this.tbxRgb.Size = new System.Drawing.Size(70, 21);
         this.tbxRgb.TabIndex = 2;
         // 
         // numZoom
         // 
         this.numZoom.Location = new System.Drawing.Point(192, 119);
         this.numZoom.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
         this.numZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.numZoom.Name = "numZoom";
         this.numZoom.Size = new System.Drawing.Size(54, 21);
         this.numZoom.TabIndex = 3;
         this.numZoom.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(144, 121);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(42, 12);
         this.label3.TabIndex = 1;
         this.label3.Text = "Zoom:";
         // 
         // pbxColor
         // 
         this.pbxColor.BackColor = System.Drawing.Color.Black;
         this.pbxColor.Location = new System.Drawing.Point(146, 12);
         this.pbxColor.Name = "pbxColor";
         this.pbxColor.Size = new System.Drawing.Size(100, 48);
         this.pbxColor.TabIndex = 0;
         this.pbxColor.TabStop = false;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(144, 94);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(31, 12);
         this.label2.TabIndex = 1;
         this.label2.Text = "Hex:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(144, 69);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(34, 12);
         this.label1.TabIndex = 1;
         this.label1.Text = "RGB:";
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(257, 152);
         this.Controls.Add(this.numZoom);
         this.Controls.Add(this.tbxRgb);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.tbxHex);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pbxColor);
         this.Controls.Add(this.pbxCapture);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormMain";
         this.Text = "Color Picker - Drag big box!!!";
         ((System.ComponentModel.ISupportInitialize)(this.pbxCapture)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pbxCapture;
      private System.Windows.Forms.TextBox tbxHex;
      private System.Windows.Forms.TextBox tbxRgb;
      private System.Windows.Forms.NumericUpDown numZoom;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.PictureBox pbxColor;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}

