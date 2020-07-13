namespace Semester
{
    partial class PredmetControl
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
            this.textBoxPredmet = new System.Windows.Forms.TextBox();
            this.textBoxBall1 = new System.Windows.Forms.TextBox();
            this.textBoxBall2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxPredmet
            // 
            this.textBoxPredmet.Location = new System.Drawing.Point(3, 3);
            this.textBoxPredmet.Name = "textBoxPredmet";
            this.textBoxPredmet.Size = new System.Drawing.Size(146, 20);
            this.textBoxPredmet.TabIndex = 0;
            // 
            // textBoxBall1
            // 
            this.textBoxBall1.Location = new System.Drawing.Point(155, 3);
            this.textBoxBall1.Name = "textBoxBall1";
            this.textBoxBall1.Size = new System.Drawing.Size(44, 20);
            this.textBoxBall1.TabIndex = 1;
            // 
            // textBoxBall2
            // 
            this.textBoxBall2.Location = new System.Drawing.Point(205, 3);
            this.textBoxBall2.Name = "textBoxBall2";
            this.textBoxBall2.Size = new System.Drawing.Size(43, 20);
            this.textBoxBall2.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(301, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Известен";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "72",
            "108",
            "144"});
            this.comboBox1.Location = new System.Drawing.Point(254, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PredmetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxBall2);
            this.Controls.Add(this.textBoxBall1);
            this.Controls.Add(this.textBoxPredmet);
            this.Name = "PredmetControl";
            this.Size = new System.Drawing.Size(388, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPredmet;
        private System.Windows.Forms.TextBox textBoxBall1;
        private System.Windows.Forms.TextBox textBoxBall2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
