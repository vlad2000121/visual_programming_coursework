
namespace curs_vp
{
    partial class Конвертвал
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.конверт_валют1 = new curs_vp.Конверт_валют();
            this.SuspendLayout();
            // 
            // конверт_валют1
            // 
            this.конверт_валют1.AutoSize = true;
            this.конверт_валют1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.конверт_валют1.Location = new System.Drawing.Point(2, 0);
            this.конверт_валют1.Margin = new System.Windows.Forms.Padding(5);
            this.конверт_валют1.Name = "конверт_валют1";
            this.конверт_валют1.Size = new System.Drawing.Size(644, 321);
            this.конверт_валют1.TabIndex = 0;
            this.конверт_валют1.Load += new System.EventHandler(this.конверт_валют1_Load);
            // 
            // Конвертвал
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 335);
            this.Controls.Add(this.конверт_валют1);
            this.Name = "Конвертвал";
            this.Text = "Конвертер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Конверт_валют конверт_валют1;
    }
}