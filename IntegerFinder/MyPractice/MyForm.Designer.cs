namespace MyPractice
{
    partial class MyForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbTable = new System.Windows.Forms.RichTextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.MainButton = new System.Windows.Forms.Button();
            this.tbEps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // rtbTable
            // 
            this.rtbTable.Location = new System.Drawing.Point(57, 40);
            this.rtbTable.Name = "rtbTable";
            this.rtbTable.Size = new System.Drawing.Size(213, 41);
            this.rtbTable.TabIndex = 0;
            this.rtbTable.Text = "";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(23, 84);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(28, 20);
            this.tbA.TabIndex = 1;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(23, 12);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(28, 20);
            this.tbB.TabIndex = 2;
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(15, 206);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(558, 53);
            this.MainButton.TabIndex = 3;
            this.MainButton.Text = "Вычислить";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // tbEps
            // 
            this.tbEps.Location = new System.Drawing.Point(15, 170);
            this.tbEps.Name = "tbEps";
            this.tbEps.Size = new System.Drawing.Size(100, 20);
            this.tbEps.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Точность ответа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 55);
            this.label4.TabIndex = 8;
            this.label4.Text = "∫";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Интеграл =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ответ = ";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(15, 129);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Точность интеграла";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "dx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Abs(X) - Модуль X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sin(X)/Cos(X) - Синус/Косинус X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Sqrt(X) - Квадратный корень из X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Pow(X,Y) - Возведение X в степень Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Log(X,Y) - Логарифм X по основанию Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(362, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Для правильной работы программы ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(362, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "X всегда указывать с большой буквы";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(353, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 182);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Помощь";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(133, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 70);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 272);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEps);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.rtbTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTable;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.TextBox tbEps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

