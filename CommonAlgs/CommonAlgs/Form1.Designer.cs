namespace CommonAlgs
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.Button();
            this.textOut = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 0;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(313, 29);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(75, 23);
            this.Max.TabIndex = 1;
            this.Max.Text = "Мах";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Max_MouseClick);
            // 
            // textOut
            // 
            this.textOut.Location = new System.Drawing.Point(502, 30);
            this.textOut.Name = "textOut";
            this.textOut.Size = new System.Drawing.Size(182, 22);
            this.textOut.TabIndex = 2;
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(394, 29);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(73, 23);
            this.Min.TabIndex = 3;
            this.Min.Text = "Min";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Min_MouseClick);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(313, 59);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(154, 44);
            this.Sort.TabIndex = 4;
            this.Sort.Text = "Сортировка по убыванию";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Sort_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(313, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "По возрастанию";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 154);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.TextBox textOut;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

