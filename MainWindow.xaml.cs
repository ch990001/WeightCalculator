using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeightCalculator
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string strInput;
        double douOutput;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtG.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtMG.Text = string.Format("{0:0.##########}", _value * 1000);
            if (_kind != 2)
                txtKG.Text = string.Format("{0:0.##########}", _value / 1000);
            if (_kind != 3)
                txtT.Text = string.Format("{0:0.##########}", _value / 1000000);
            if (_kind != 4)
                txtOZ.Text = string.Format("{0:0.##########}", _value * 0.035273);
            if (_kind != 5)
                txtIB.Text = string.Format("{0:0.##########}", _value * 0.0022046226);
        }

        private void txtG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtG.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else
            {
                txtlnfo.Text = "輸入錯誤，請輸入數字";
                txtG.Text = "";
            }
        }

        private void txtMG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtMG.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput / 1000);
            }
            else
            {
                txtlnfo.Text = "輸入錯誤，請輸入數字";
                txtMG.Text = "";
            }
        }

        private void txtKG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKG.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 1000);
            }
            else
            {
                txtlnfo.Text = "輸入錯誤，請輸入數字";
                txtKG.Text = "";
            }
        }

        private void txtT_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtT.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 1000000);
            }
            else
            {
                txtlnfo.Text = "輸入錯誤，請輸入數字";
                txtT.Text = "";
            }
        }

        private void txtOZ_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtOZ.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput / 0.035273);
            }
            else
            {
                txtlnfo.Text = "輸入錯誤，請輸入數字";
                txtOZ.Text = "";
            }
        }

        private void txtIB_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIB.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput / 0.0022046226);
            }
            else
            {
                txtlnfo.Text = "輸入錯誤，請輸入數字";
                txtIB.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtMG.Text = "";
            txtG.Text = "";
            txtKG.Text = "";
            txtT.Text = "";
            txtOZ.Text = "";
            txtIB.Text = "";
        }

        
    }
}
