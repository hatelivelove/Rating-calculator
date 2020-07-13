using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester
{
    public partial class PredmetControl : UserControl
    {
        public PredmetControl()
        {
            InitializeComponent();
        }
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; textBoxPredmet.Text = value; }
        }
        private string _ball1;

        public string Ball1
        {
            get { return textBoxBall1.Text; }
            set { _ball1 = value; textBoxBall1.Text = value; }
        }
        private string _ball2;

        public string Ball2
        {
            get { return textBoxBall2.Text; }
            set { _ball2 = value; textBoxBall2.Text = value; }
        }
        private string _hours;

        public string Hours
        {
            get { return comboBox1.Text; }
            set { _hours = value; comboBox1.Text = value; }
        }
        private bool _lock;

        public bool Lock
        {
            get { return checkBox1.Checked; }
            set { _lock = value; checkBox1.Checked = value; }
        }
        private bool _visibleBall2;

        public bool VisibleBall2
        {
            get { return textBoxBall2.Visible; }
            set { _visibleBall2 = value; textBoxBall2.Visible = value; textBoxBall2.Enabled = value; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
