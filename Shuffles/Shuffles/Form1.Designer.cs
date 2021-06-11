namespace Shuffles
{
    partial class Form_Face
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
            this.components = new System.ComponentModel.Container();
            this.FY = new System.Windows.Forms.Button();
            this.TBCount1 = new System.Windows.Forms.TextBox();
            this.Permutations = new System.Windows.Forms.Button();
            this.Rand_Throw = new System.Windows.Forms.Button();
            this.RC_4 = new System.Windows.Forms.Button();
            this.TBCount2 = new System.Windows.Forms.TextBox();
            this.TBCount4 = new System.Windows.Forms.TextBox();
            this.TBCount3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ZedGrath = new ZedGraph.ZedGraphControl();
            this.Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FY
            // 
            this.FY.Location = new System.Drawing.Point(12, 31);
            this.FY.Name = "FY";
            this.FY.Size = new System.Drawing.Size(100, 50);
            this.FY.TabIndex = 0;
            this.FY.Text = "Фишер - Йетс";
            this.FY.UseVisualStyleBackColor = true;
            this.FY.Click += new System.EventHandler(this.FY_Click);
            // 
            // TBCount1
            // 
            this.TBCount1.Location = new System.Drawing.Point(133, 47);
            this.TBCount1.Name = "TBCount1";
            this.TBCount1.Size = new System.Drawing.Size(100, 20);
            this.TBCount1.TabIndex = 2;
            // 
            // Permutations
            // 
            this.Permutations.Location = new System.Drawing.Point(12, 87);
            this.Permutations.Name = "Permutations";
            this.Permutations.Size = new System.Drawing.Size(100, 50);
            this.Permutations.TabIndex = 3;
            this.Permutations.Text = "Перестановки";
            this.Permutations.UseVisualStyleBackColor = true;
            this.Permutations.Click += new System.EventHandler(this.Permutations_Click);
            // 
            // Rand_Throw
            // 
            this.Rand_Throw.Location = new System.Drawing.Point(12, 143);
            this.Rand_Throw.Name = "Rand_Throw";
            this.Rand_Throw.Size = new System.Drawing.Size(100, 50);
            this.Rand_Throw.TabIndex = 4;
            this.Rand_Throw.Text = "Перекидывание";
            this.Rand_Throw.UseVisualStyleBackColor = true;
            this.Rand_Throw.Click += new System.EventHandler(this.Rand_Throw_Click);
            // 
            // RC_4
            // 
            this.RC_4.Location = new System.Drawing.Point(12, 199);
            this.RC_4.Name = "RC_4";
            this.RC_4.Size = new System.Drawing.Size(100, 50);
            this.RC_4.TabIndex = 5;
            this.RC_4.Text = "RC 4";
            this.RC_4.UseVisualStyleBackColor = true;
            this.RC_4.Click += new System.EventHandler(this.RC_4_Click);
            // 
            // TBCount2
            // 
            this.TBCount2.Location = new System.Drawing.Point(133, 103);
            this.TBCount2.Name = "TBCount2";
            this.TBCount2.Size = new System.Drawing.Size(100, 20);
            this.TBCount2.TabIndex = 7;
            // 
            // TBCount4
            // 
            this.TBCount4.Location = new System.Drawing.Point(133, 215);
            this.TBCount4.Name = "TBCount4";
            this.TBCount4.Size = new System.Drawing.Size(100, 20);
            this.TBCount4.TabIndex = 11;
            // 
            // TBCount3
            // 
            this.TBCount3.Location = new System.Drawing.Point(133, 159);
            this.TBCount3.Name = "TBCount3";
            this.TBCount3.Size = new System.Drawing.Size(100, 20);
            this.TBCount3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Размер массива";
            // 
            // ZedGrath
            // 
            this.ZedGrath.Location = new System.Drawing.Point(239, 10);
            this.ZedGrath.Name = "ZedGrath";
            this.ZedGrath.ScrollGrace = 0D;
            this.ZedGrath.ScrollMaxX = 0D;
            this.ZedGrath.ScrollMaxY = 0D;
            this.ZedGrath.ScrollMaxY2 = 0D;
            this.ZedGrath.ScrollMinX = 0D;
            this.ZedGrath.ScrollMinY = 0D;
            this.ZedGrath.ScrollMinY2 = 0D;
            this.ZedGrath.Size = new System.Drawing.Size(596, 286);
            this.ZedGrath.TabIndex = 15;
            this.ZedGrath.UseExtendedPrintDialog = true;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(239, 273);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(96, 23);
            this.Refresh.TabIndex = 16;
            this.Refresh.Text = "Построение";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // Form_Face
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.ZedGrath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCount4);
            this.Controls.Add(this.TBCount3);
            this.Controls.Add(this.TBCount2);
            this.Controls.Add(this.RC_4);
            this.Controls.Add(this.Rand_Throw);
            this.Controls.Add(this.Permutations);
            this.Controls.Add(this.TBCount1);
            this.Controls.Add(this.FY);
            this.Name = "Form_Face";
            this.Text = "Face";
            this.Load += new System.EventHandler(this.Form_Face_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FY;
        private System.Windows.Forms.TextBox TBCount1;
        private System.Windows.Forms.Button Permutations;
        private System.Windows.Forms.Button Rand_Throw;
        private System.Windows.Forms.Button RC_4;
        private System.Windows.Forms.TextBox TBCount2;
        private System.Windows.Forms.TextBox TBCount4;
        private System.Windows.Forms.TextBox TBCount3;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl ZedGrath;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

