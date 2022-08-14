using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            err.Clear();
            if (screen.Text == "0")
            {
                screen.Clear();
                err.Clear();
            }
            Button button = (Button)sender;
            screen.Text = screen.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            err.Clear();
            if (screen.Text == "0")
            {
                screen.Text = "0";
                err.Clear();
            }
            else
            {
                Button button = (Button)sender;
                screen.Text = screen.Text + button.Text;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // try
            //{
            solver.Solve(screen);
          
            //}
            //catch(Exception a)
            //{
               // MessageBox.Show(a.Message);
           // }
           
        }

        private void button22_Click(object sender, EventArgs e)
        {
            err.Clear();
            screen.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                double ans, pre_ans;
                pre_ans = Convert.ToDouble(screen.Text);
                ans = Math.Sin(pre_ans);
                ans = Math.Round(ans, 4);
                screen.Text = Convert.ToString(ans);
            }
            catch (Exception)
            {
                err.Text = "Math Error";
                
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            err.Clear();
            try
            {
                double num = Convert.ToDouble(screen.Text);
                double percent = num / 100;
                screen.Text = Convert.ToString(percent);
            }

            catch (Exception)
            {
                err.Text = "Math Error";
            }
        }

        private void point_click(object sender, EventArgs e)
        {
            err.Clear();
            try
            {
                if (screen.Text == "0")
                {
                    Button button = (Button)sender;
                    screen.Text = screen.Text + button.Text;
                }
                else
                {
                    Button button = (Button)sender;
                screen.Text = screen.Text + button.Text;
                }
            }
            catch (Exception)
            {
                err.Text = "Math Error";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            err.Clear();
            try
            {
                double ans, pre_ans;
                pre_ans = Convert.ToDouble(screen.Text);
                ans = Math.Cos(pre_ans);
                ans = Math.Round(ans, 4);
                screen.Text = Convert.ToString(ans);
            }
            catch (Exception)
            {
                err.Text = "Math Error";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            err.Clear();
            try
            {
                double ans, pre_ans;
                pre_ans = Convert.ToDouble(screen.Text);
                ans = Math.Tan(pre_ans);
                ans = Math.Round(ans, 4);
                screen.Text = Convert.ToString(ans);
            }
            catch (Exception)
            {
                err.Text = "Math Error";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
           try
            {
                double num = Convert.ToDouble(screen.Text);
                double ans = Math.Round(1 / num,9);
                screen.Text = Convert.ToString(ans);
            }
            catch (Exception )
            {
                err.Text = "Math Error";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            err.Clear();
            try
            {
                double num = Convert.ToDouble(screen.Text);
                double ans = Math.Round(num * num,9);
                screen.Text = Convert.ToString(ans);
            }
            catch (Exception )
            {
                err.Text = "Math Error";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                err.Clear();
                double num = Convert.ToDouble(screen.Text);
                double ans = Math.Round(Math.Sqrt(num),9);
                screen.Text = Convert.ToString(ans);
            }
            catch (Exception)
            {
                err.Text = "Math Error";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0" )
            {
               
            }
            else
            {
                Button button = (Button)sender;
                screen.Text = screen.Text + "^";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            // backspace
            screen.Text = solver.Backspace(screen.Text);
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //sign inverse
            screen.Text = solver.signInverse(screen.Text);
        }

    }

}
    

