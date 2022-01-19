
namespace curs_vp
{
    partial class Calc_credit
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Сумма = new System.Windows.Forms.TextBox();
            this.ПроцентBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.СрокBar2 = new System.Windows.Forms.TrackBar();
            this.КредитButton = new System.Windows.Forms.RadioButton();
            this.РассрочкаButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ПроцентBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.СрокBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // Сумма
            // 
            this.Сумма.Location = new System.Drawing.Point(23, 52);
            this.Сумма.Name = "Сумма";
            this.Сумма.Size = new System.Drawing.Size(146, 20);
            this.Сумма.TabIndex = 0;
            // 
            // ПроцентBar1
            // 
            this.ПроцентBar1.Location = new System.Drawing.Point(16, 143);
            this.ПроцентBar1.Maximum = 100;
            this.ПроцентBar1.Name = "ПроцентBar1";
            this.ПроцентBar1.Size = new System.Drawing.Size(326, 45);
            this.ПроцентBar1.TabIndex = 1;
            this.ПроцентBar1.TickFrequency = 5;
            this.ПроцентBar1.Scroll += new System.EventHandler(this.ПроцентBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(412, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сумма";
            // 
            // СрокBar2
            // 
            this.СрокBar2.Location = new System.Drawing.Point(16, 236);
            this.СрокBar2.Maximum = 50;
            this.СрокBar2.Name = "СрокBar2";
            this.СрокBar2.Size = new System.Drawing.Size(326, 45);
            this.СрокBar2.TabIndex = 6;
            this.СрокBar2.TickFrequency = 3;
            this.СрокBar2.Scroll += new System.EventHandler(this.СрокBar2_Scroll);
            // 
            // КредитButton
            // 
            this.КредитButton.AutoSize = true;
            this.КредитButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.КредитButton.Location = new System.Drawing.Point(196, 46);
            this.КредитButton.Name = "КредитButton";
            this.КредитButton.Size = new System.Drawing.Size(192, 23);
            this.КредитButton.TabIndex = 7;
            this.КредитButton.TabStop = true;
            this.КредитButton.Text = "Кредит (от 1% до 100%)";
            this.КредитButton.UseVisualStyleBackColor = true;
            this.КредитButton.CheckedChanged += new System.EventHandler(this.КредитButton_CheckedChanged);
            // 
            // РассрочкаButton
            // 
            this.РассрочкаButton.AutoSize = true;
            this.РассрочкаButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.РассрочкаButton.Location = new System.Drawing.Point(196, 76);
            this.РассрочкаButton.Name = "РассрочкаButton";
            this.РассрочкаButton.Size = new System.Drawing.Size(210, 23);
            this.РассрочкаButton.TabIndex = 8;
            this.РассрочкаButton.TabStop = true;
            this.РассрочкаButton.Text = "Рассрочка (от 0% до 100%)";
            this.РассрочкаButton.UseVisualStyleBackColor = true;
            this.РассрочкаButton.CheckedChanged += new System.EventHandler(this.РассрочкаButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вид займа:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(522, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ставка по кредиту:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Срок (мес.):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ежемесячный платеж:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(356, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Всего выплат:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(356, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Переплата:";
            // 
            // Calc_credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.РассрочкаButton);
            this.Controls.Add(this.КредитButton);
            this.Controls.Add(this.СрокBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ПроцентBar1);
            this.Controls.Add(this.Сумма);
            this.Name = "Calc_credit";
            this.Size = new System.Drawing.Size(626, 331);
            this.Load += new System.EventHandler(this.Calc_credit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ПроцентBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.СрокBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Сумма;
        private System.Windows.Forms.TrackBar ПроцентBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar СрокBar2;
        private System.Windows.Forms.RadioButton КредитButton;
        private System.Windows.Forms.RadioButton РассрочкаButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}
