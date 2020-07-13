using System;
using System.Windows.Forms;

namespace Semester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Hours = 0;
        public double Summ = 0;
        private void buttonAddZ_Click(object sender, EventArgs e)
        {
            PredmetControl item = new PredmetControl();
            flowLayoutPanel1.Controls.Add(item);
        }

        private void buttonDelZ_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
        }
        private void CalculateRating (FlowLayoutPanel flp) //Вычисление среднего рейтинга
        {
            if (flp.Controls.Count > 0)
            {
                foreach (Control c in flp.Controls)
                {
                    if (c is PredmetControl subject && CheckEmptyStrings(subject) == false)
                    {
                        MessageBox.Show("Заполните баллы");
                        return;
                    }
                    if (c is PredmetControl p && p.Ball1 != "" && (p.Ball2 != "" || p.VisibleBall2 == false) && p.Hours != "")
                    {
                        if (p.VisibleBall2 == false)
                        {
                            Summ += Convert.ToDouble(p.Ball1) * Convert.ToDouble(p.Hours) ;
                            Hours += Convert.ToDouble(p.Hours);
                            Rating = Summ / Hours;
                        }
                        else
                        {
                            Summ += (Convert.ToDouble(p.Ball1) + Convert.ToDouble(p.Ball2)) / 2 * Convert.ToDouble(p.Hours);
                            Hours += Convert.ToDouble(p.Hours);
                            Rating = Summ / Hours;
                        }
                    }
                }
            }
            
        }
        private bool CheckEmptyStrings(PredmetControl subject)
        {
            if (subject.Ball1 == string.Empty || (subject.Ball2 == string.Empty 
                && subject.VisibleBall2 == true) || subject.Hours == string.Empty)
            {
                return false;
            }
            return true;
        }
        
        
        private double _rating;

        public double Rating
        {
            get { return _rating; }
            set { _rating = value; textBox1.Text = value.ToString(); }
        }
        private double Average { get; set; }
        private double Hours2 = 0;
        private double Subtr = 0;
        private void CalculateRating2()//Вычисление средних баллов для желаемого рейтинга
        {
            foreach (Control item in Controls)//Сначала суммируем количество часов
            {
                if (item is FlowLayoutPanel flp)
                {
                    if (flp.Controls.Count > 0)
                    {
                        foreach (Control c in flp.Controls)
                        {
                            if (c is PredmetControl subject && CheckEmptyStrings(subject) == false)
                            {
                                MessageBox.Show("Заполните баллы");
                                return;
                            }
                            if (c is PredmetControl p && p.Ball1 != "" && (p.Ball2 != "" || p.VisibleBall2 == false) && p.Hours != "")
                            {
                                if (p.VisibleBall2 == false)
                                {
                                    Hours = Hours + (Convert.ToDouble(p.Hours))/2;
                                }
                                else
                                {
                                    Hours += Convert.ToDouble(p.Hours);
                                }
                            }
                        }
                    }
                }
            }
            if (textBox1.Text != "")
                Summ = Hours * Convert.ToDouble(textBox1.Text); //Вычисляем произведение [все часы по дисциплинам * желаемый рейтинг].
            foreach (Control item in Controls)// Вычисляем число, которое вычтем из Summ. Это число закреплённых (известных) баллов. Они меняться не будут
            {
                if (item is FlowLayoutPanel flp)
                {
                    if (flp.Controls.Count > 0)
                    {
                        foreach (Control c in flp.Controls)
                        {
                            if (c is PredmetControl p && p.Lock == true && p.Ball1 != "" && (p.Ball2 != "" || p.VisibleBall2 == false) && p.Hours != "")
                            {
                                if (p.VisibleBall2 == false)
                                {
                                    Subtr += Convert.ToDouble(p.Ball1)/2 * Convert.ToDouble(p.Hours);
                                }
                                else
                                {
                                    Subtr += (Convert.ToDouble(p.Ball1) + Convert.ToDouble(p.Ball2)) / 2 * Convert.ToDouble(p.Hours);
                                }
                            }
                        }
                    }
                }
            }
            foreach (Control item in Controls) //Вычисляем количество часов по незакрепленным дисциплинам. 
            {
                if (item is FlowLayoutPanel flp)
                {
                    if (flp.Controls.Count > 0)
                    {
                        foreach (Control c in flp.Controls)
                        {
                            if (c is PredmetControl p && p.Lock == false && p.Ball1 != "" && (p.Ball2 != "" || p.VisibleBall2 == false) && p.Hours != "")
                            {
                                if (p.VisibleBall2 == false)
                                {
                                    Hours2 += (Convert.ToDouble(p.Hours) / 2);
                                }
                                else
                                {
                                    Hours2 += Convert.ToDouble(p.Hours);
                                }
                            }
                        }
                    }
                }
            }
            Average = (Summ - Subtr) / Hours2; // Находим средний балл, который нужно получить по незакрепленным дисциплинам.

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxLockRating.Checked == false)
            {
                foreach (Control item in Controls)
                {
                    if (item is FlowLayoutPanel flp)
                    {
                        CalculateRating(flp);
                    }
                }

                Summ = 0; Hours = 0; Hours2 = 0; Subtr = 0;
            }
            else
            {
                CalculateRating2();
                
                foreach (Control item in Controls)
                {
                    if (item is FlowLayoutPanel flp)
                    {
                        foreach (Control subject in flp.Controls)
                        {
                            if (subject is PredmetControl p && p.Lock == false && p.Ball1 != "" && (p.Ball2 != "" || p.VisibleBall2 == false) && p.Hours != "")
                            {
                                if (Average > 100)
                                {
                                    MessageBox.Show("К сожалению, получить такой рейтинг уже не возможно :(");
                                    break;
                                }
                                p.Ball1 = Average.ToString();
                                p.Ball2 = Average.ToString();
                            }
                        }
                    }
                }

                Hours = 0; Hours2 = 0; Summ = 0; Subtr = 0;
            }
        }
        private void buttonAddEx_Click(object sender, EventArgs e)
        {
            PredmetControl item = new PredmetControl();
            flowLayoutPanel2.Controls.Add(item);
        }
        private void buttonDelEx_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel2.Controls.Count > 0)
                flowLayoutPanel2.Controls.RemoveAt(flowLayoutPanel2.Controls.Count - 1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PredmetControl item = new PredmetControl() { VisibleBall2 = false };
            flowLayoutPanel1.Controls.Add(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Программа даёт возможность вычислять нужные семестровые баллы для желаемого рейтинга. \r    Выбор свойства 'Известен' позволяет вычислить баллы, которые нужно получить для достижения заданного среднего балла. Если экзамен/зачёт известен, то баллы меняться не будут");
        }
    }
}
