using System;
using System.Windows;

namespace SimpleCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int result = num1 + num2;
            MessageBox.Show("התוצאה היא: " + result);
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int result = num1 - num2;
            MessageBox.Show("התוצאה היא: " + result);
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int result = num1 * num2;
            MessageBox.Show("התוצאה היא: " + result);
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            if (num2 == 0)
            {
                MessageBox.Show("חלוקה באפס אינה מותרת");
            }
            else
            {
                int result = num1 / num2;
                MessageBox.Show("התוצאה היא: " + result);
            }
        }
    }
}
