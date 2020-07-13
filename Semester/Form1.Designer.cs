namespace Semester
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.predmetControl1 = new Semester.PredmetControl();
            this.labelZachets = new System.Windows.Forms.Label();
            this.labelExams = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.predmetControl2 = new Semester.PredmetControl();
            this.buttonAddZ = new System.Windows.Forms.Button();
            this.buttonDelZ = new System.Windows.Forms.Button();
            this.buttonDelEx = new System.Windows.Forms.Button();
            this.buttonAddEx = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxLockRating = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.predmetControl1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(412, 196);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // predmetControl1
            // 
            this.predmetControl1.Ball1 = "";
            this.predmetControl1.Ball2 = "";
            this.predmetControl1.Hours = "";
            this.predmetControl1.Location = new System.Drawing.Point(3, 3);
            this.predmetControl1.Lock = false;
            this.predmetControl1.Name = "predmetControl1";
            this.predmetControl1.Size = new System.Drawing.Size(388, 32);
            this.predmetControl1.TabIndex = 0;
            this.predmetControl1.Title = null;
            this.predmetControl1.VisibleBall2 = true;
            // 
            // labelZachets
            // 
            this.labelZachets.AutoSize = true;
            this.labelZachets.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZachets.Location = new System.Drawing.Point(163, 9);
            this.labelZachets.Name = "labelZachets";
            this.labelZachets.Size = new System.Drawing.Size(88, 26);
            this.labelZachets.TabIndex = 11;
            this.labelZachets.Text = "Зачёты";
            // 
            // labelExams
            // 
            this.labelExams.AutoSize = true;
            this.labelExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExams.Location = new System.Drawing.Point(581, 9);
            this.labelExams.Name = "labelExams";
            this.labelExams.Size = new System.Drawing.Size(118, 26);
            this.labelExams.TabIndex = 13;
            this.labelExams.Text = "Экзамены";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.predmetControl2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(430, 40);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(412, 196);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // predmetControl2
            // 
            this.predmetControl2.Ball1 = "";
            this.predmetControl2.Ball2 = "";
            this.predmetControl2.Hours = "";
            this.predmetControl2.Location = new System.Drawing.Point(3, 3);
            this.predmetControl2.Lock = false;
            this.predmetControl2.Name = "predmetControl2";
            this.predmetControl2.Size = new System.Drawing.Size(388, 32);
            this.predmetControl2.TabIndex = 0;
            this.predmetControl2.Title = null;
            this.predmetControl2.VisibleBall2 = true;
            // 
            // buttonAddZ
            // 
            this.buttonAddZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddZ.Location = new System.Drawing.Point(185, 242);
            this.buttonAddZ.Name = "buttonAddZ";
            this.buttonAddZ.Size = new System.Drawing.Size(75, 23);
            this.buttonAddZ.TabIndex = 14;
            this.buttonAddZ.Text = "Добавить";
            this.buttonAddZ.UseVisualStyleBackColor = true;
            this.buttonAddZ.Click += new System.EventHandler(this.buttonAddZ_Click);
            // 
            // buttonDelZ
            // 
            this.buttonDelZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelZ.Location = new System.Drawing.Point(266, 242);
            this.buttonDelZ.Name = "buttonDelZ";
            this.buttonDelZ.Size = new System.Drawing.Size(75, 23);
            this.buttonDelZ.TabIndex = 15;
            this.buttonDelZ.Text = "Удалить";
            this.buttonDelZ.UseVisualStyleBackColor = true;
            this.buttonDelZ.Click += new System.EventHandler(this.buttonDelZ_Click);
            // 
            // buttonDelEx
            // 
            this.buttonDelEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelEx.Location = new System.Drawing.Point(705, 242);
            this.buttonDelEx.Name = "buttonDelEx";
            this.buttonDelEx.Size = new System.Drawing.Size(75, 23);
            this.buttonDelEx.TabIndex = 17;
            this.buttonDelEx.Text = "Удалить";
            this.buttonDelEx.UseVisualStyleBackColor = true;
            this.buttonDelEx.Click += new System.EventHandler(this.buttonDelEx_Click);
            // 
            // buttonAddEx
            // 
            this.buttonAddEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEx.Location = new System.Drawing.Point(624, 242);
            this.buttonAddEx.Name = "buttonAddEx";
            this.buttonAddEx.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEx.TabIndex = 16;
            this.buttonAddEx.Text = "Добавить";
            this.buttonAddEx.UseVisualStyleBackColor = true;
            this.buttonAddEx.Click += new System.EventHandler(this.buttonAddEx_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(360, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 31);
            this.textBox1.TabIndex = 18;
            // 
            // checkBoxLockRating
            // 
            this.checkBoxLockRating.AutoSize = true;
            this.checkBoxLockRating.Location = new System.Drawing.Point(479, 390);
            this.checkBoxLockRating.Name = "checkBoxLockRating";
            this.checkBoxLockRating.Size = new System.Drawing.Size(75, 17);
            this.checkBoxLockRating.TabIndex = 19;
            this.checkBoxLockRating.Text = "Известен";
            this.checkBoxLockRating.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(374, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(349, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Курсовая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(767, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Помощь";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 464);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxLockRating);
            this.Controls.Add(this.buttonDelEx);
            this.Controls.Add(this.buttonAddEx);
            this.Controls.Add(this.buttonDelZ);
            this.Controls.Add(this.buttonAddZ);
            this.Controls.Add(this.labelExams);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.labelZachets);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Semester";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private PredmetControl predmetControl1;
        private System.Windows.Forms.Label labelZachets;
        private System.Windows.Forms.Label labelExams;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonAddZ;
        private System.Windows.Forms.Button buttonDelZ;
        private System.Windows.Forms.Button buttonDelEx;
        private System.Windows.Forms.Button buttonAddEx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxLockRating;
        private System.Windows.Forms.Button button1;
        private PredmetControl predmetControl2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

