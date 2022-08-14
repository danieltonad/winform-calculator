using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql
{
    class solver
    {
        public static void Solve(TextBox box)
        {
            string temp = null;char op = ' ';
            double _temp = 0, solu = 0;
            int length = box.TextLength;
            char[] a = box.Text.ToCharArray();

            for (int i = 0; i < length; i++)
            {
                //number
                if (solver.Numb_check(a[i]))
                {
                    if(op !=' ')
                    {
                        temp += a[i].ToString();
                        if (i + 1 == length)
                        {
                          solu = solver.Do(op, _temp,temp);  
                        }
                        
                    }
                    else
                    {
                        
                        temp += a[i].ToString();

                        if (i + 1 == length)
                        {
                            solu = double.Parse(temp);
                        }
                    }
                }
                //operator
                else if (solver.Op_check(a[i]))
                {
                    if (op != ' ')
                    {
                        solu = solver.Do(op, _temp, temp);
                        op = a[i];
                        temp = " ";
                        _temp = solu;
                    }
                    else
                    {
                        op = a[i];
                        _temp = double.Parse(temp);
                        temp = null;
                    }
                }
                    
                
            }
            box.Text = solu.ToString();
            
        }
        
        private static bool Numb_check(char no)
        {
            
            bool result = false;
            int a = 0;
            if (int.TryParse(no.ToString(), out a))
                result = true;
            else result = false;

            return result;
        }

        private static bool Decimal_check(char no)
        {

            bool result = false;
            double a = 0;
            if (double.TryParse(no.ToString(), out a))
                result = true;
            else result = false;

            return result;
        }

        private static bool Op_check(char no)
        {
            bool result = false;
            switch(no)
            {
                case '+':
                    result = true;
                    break;
                case '-':
                    result = true;
                    break;
                case 'x':
                    result = true;
                    break;
                case '^':
                    result = true;
                    break;
                case '*':
                    result = true;
                    break;
                case '/':
                    result = true;
                    break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

        private static Double Do(char op,double temp,string _temp)
        {
            double no = double.Parse(_temp);
            switch(Convert.ToChar(op))
            {
                case '+':
                    temp += no;
                    break;
                case '-':
                    temp -= no;
                    break;
                case '*':
                    temp *= no;
                    break;
                case '^':
                    temp = Math.Pow(temp, no);
                    break;
                case '/':
                    temp /= no;
                    break;
            }
            

            return temp;
            
        }
        public static string Backspace(string text)
        {
            var food = "";
            var textArr = text.ToCharArray();
            var len = textArr.Length;
            var backed = len - 1;
            for (int i = 0; i < backed; i++)
            {
                food += textArr[i];
            }

            if (food.Length < 1)
                food = "0";
            return food;
        }

        public static string signInverse(string text)
        {
            int a = 0;
            string food;
            if (!int.TryParse(text, out a))
                food = text;
            else
            {
            int inverse = -(Convert.ToInt32(text));
                food = inverse.ToString();
            }

            return food;
        }

    }

    
}
