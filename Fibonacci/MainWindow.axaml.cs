using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace Fibonacci
{
    public partial class MainWindow : Window
    {
        private int a, b, temp, cont, times;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Miamigofibo(int times)
        {
            temp = b;
            b = a + b;
            a = temp;
            cont++;
            if (cont < times)
            {
                Miamigofibo(times);
            }
        }

        private void Calcular_OnClick(object? sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(TextBox.Text, out times))
            {
                a = 0; // Initialize a and b for Fibonacci sequence
                b = 1;
                temp = 0;
                cont = 1;
                Miamigofibo(times);
            }
            else
            {
                TextBox.BorderBrush = Brushes.Red;
                return;
            }

            ResultTextBox.Text = $"el número en la posición {TextBox.Text} es {a}";
        }
    }
}