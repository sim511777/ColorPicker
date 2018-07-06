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
         this.pbxCap = new System.Windows.Forms.PictureBox();
         this.tbxHex = new System.Windows.Forms.TextBox();
         this.tbxRgb = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pbxCap)).BeginInit();
         this.SuspendLayout();
         // 
         // pbxCap
         // 
         this.pbxCap.BackColor = System.Drawing.Color.Black;
         this.pbxCap.Location = new System.Drawing.Point(12, 12);
         this.pbxCap.Name = "pbxCap";
         this.pbxCap.Size = new System.Drawing.Size(256, 256);
         this.pbxCap.TabIndex = 0;
         this.pbxCap.TabStop = false;
         this.pbxCap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxCap_MouseMove);
         // 
         // tbxHex
         // 
         this.tbxHex.BackColor = System.Drawing.SystemColors.Window;
         this.tbxHex.Location = new System.Drawing.Point(198, 274);
         this.tbxHex.Name = "tbxHex";
         this.tbxHex.ReadOnly = true;
         this.tbxHex.Size = new System.Drawing.Size(70, 21);
         this.tbxHex.TabIndex = 2;
         // 
         // tbxRgb
         // 
         this.tbxRgb.BackColor = System.Drawing.SystemColors.Window;
         this.tbxRgb.Location = new System.Drawing.Point(53, 274);
         this.tbxRgb.Name = "tbxRgb";
         this.tbxRgb.ReadOnly = true;
         this.tbxRgb.Size = new System.Drawing.Size(90, 21);
         this.tbxRgb.TabIndex = 2;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(149, 277);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(43, 12);
         this.label2.TabIndex = 1;
         this.label2.Text = "HTML:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 277);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(34, 12);
         this.label1.TabIndex = 1;
         this.label1.Text = "RGB:";
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(280, 303);
         this.Controls.Add(this.tbxRgb);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.tbxHex);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pbxCap);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormMain";
         this.Text = "Color Picker - Drag big box!!!";
         ((System.ComponentModel.ISupportInitialize)(this.pbxCap)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pbxCap;
      private System.Windows.Forms.TextBox tbxHex;
      private System.Windows.Forms.TextBox tbxRgb;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}

