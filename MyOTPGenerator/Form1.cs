using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyOTPGenerator;

namespace MyOTPGenerator
{
    public partial class Form1 : Form
    {
        MyOTPGenerator otpgen;
        int next_time;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_gen_Click(object sender, EventArgs e)
        {
            string uri = textBox_keyuri.Text;
            if(uri != "")
            {
                try
                {
                    otpgen = new MyOTPGenerator(uri);
                    GenCode();

                    next_time = otpgen.Period - (DateTime.Now.Second % otpgen.Period);
                    label_count.Text = next_time.ToString();
                    timer_gen.Start();

                    button_gen.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void timer_gen_Tick(object sender, EventArgs e)
        {
            next_time--;
            if(next_time == 0)
            {
                GenCode();
                next_time = otpgen.Period;
            }
            label_count.Text = next_time.ToString();
        }

        private void GenCode()
        {
            string code = otpgen.Generate();
            label_code.Text = code.Substring(0, 3) + " " + code.Substring(3);
        }
    }
}
