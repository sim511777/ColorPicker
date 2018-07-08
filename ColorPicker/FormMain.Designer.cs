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
         this.label1 = new System.Windows.Forms.Label();
         this.tbxRgb = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.tbxHtml = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.pbxCap)).BeginInit();
         this.SuspendLayout();
         // 
         // pbxCap
         // 
         this.pbxCap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.pbxCap.Location = new System.Drawing.Point(12, 12);
         this.pbxCap.Name = "pbxCap";
         this.pbxCap.Size = new System.Drawing.Size(255, 255);
         this.pbxCap.TabIndex = 0;
         this.pbxCap.TabStop = false;
         this.pbxCap.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCap_Paint);
         this.pbxCap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxCap_MouseMove);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(10, 276);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(34, 12);
         this.label1.TabIndex = 1;
         this.label1.Text = "RGB:";
         // 
         // tbxRgb
         // 
         this.tbxRgb.Location = new System.Drawing.Point(50, 273);
         this.tbxRgb.Name = "tbxRgb";
         this.tbxRgb.Size = new System.Drawing.Size(86, 21);
         this.tbxRgb.TabIndex = 2;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(142, 276);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(43, 12);
         this.label2.TabIndex = 1;
         this.label2.Text = "HTML:";
         // 
         // tbxHtml
         // 
         this.tbxHtml.Location = new System.Drawing.Point(191, 273);
         this.tbxHtml.Name = "tbxHtml";
         this.tbxHtml.Size = new System.Drawing.Size(76, 21);
         this.tbxHtml.TabIndex = 2;
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(280, 303);
         this.Controls.Add(this.tbxHtml);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.tbxRgb);
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
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tbxRgb;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox tbxHtml;
   }
}

