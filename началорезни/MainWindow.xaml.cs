using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace началорезни
{
    enum Blocks
    {
        block1 = 1,
        block2 = 2,
        block3 = 3,
        block4 = 4,
        block5 = 5,
        block6 = 6,
        block7 = 7,
        block8 = 8,
        block9 = 9
    }
    public class Opa : MainWindow
    {
        public static int c = 1;
    }
    public partial class MainWindow : Window
    {
        static string name = null;
        public MainWindow()
        {
            InitializeComponent();
            block1.IsEnabled = false;
            block2.IsEnabled = false;
            block3.IsEnabled = false;
            block4.IsEnabled = false;
            block5.IsEnabled = false;
            block6.IsEnabled = false;
            block7.IsEnabled = false;
            block8.IsEnabled = false;
            block9.IsEnabled = false;
            o1.IsEnabled = false;
            o2.IsEnabled = false;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button[] x = new Button[] { block1, block2, block3, block4, block5, block6, block7, block8, block9 };
            block1.IsEnabled = true;
            block2.IsEnabled = true;
            block3.IsEnabled = true;
            block4.IsEnabled = true;
            block5.IsEnabled = true;
            block6.IsEnabled = true;
            block7.IsEnabled = true;
            block8.IsEnabled = true;
            block9.IsEnabled = true;
            if (Opa.c == 1)
            {
                o1.IsChecked = true;
            }
            else if (Opa.c == 2)
            {
                o2.IsChecked = true;
                bot(x);
            }
            start.IsEnabled = false;
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Button[] x = new Button[] { block1, block2, block3, block4, block5, block6, block7, block8, block9 };

            if (o1.IsChecked == true)
            {
                (sender as Button).Content = "x ";
                (sender as Button).IsEnabled = false;
                bool hodik = win_li(x);
                if (hodik != true)
                    bot(x);
                else
                    itog(x);
            }
            else if (o2.IsChecked == true)
            {
                (sender as Button).Content = "o ";
                (sender as Button).IsEnabled = false;
                bot(x);
                bool hodik = win_li(x);
                if (hodik == true)
                    itog(x);
            }

        }
        private void bot(Button[] x)
        {
            string hod = "  ";
            if (Opa.c == 1)
                hod = "o ";
            else if (Opa.c == 2)
                hod = "x ";
            int gg;
            while (true)
            {
                Random y = new Random();
                int a = y.Next(9);
                if (x[a].Content != "x " && x[a].Content != "o ")
                {
                    x[a].Content = hod;
                    x[a].IsEnabled = false;
                    break;
                }
            }
        }
        private bool win_li(Button[] x)
        {
            string k = "x ";
            string n = "o ";
            bool win = false;
            win = proverka(k);
            if (proverka(k) == false)
                win = proverka(n);
            if (proverka(n) == false && proverka(k) == false)
            {
                foreach (Button a in x)
                {
                    if (a.Content != "x " && a.Content != "o ")
                    {
                        win = false;
                        break;
                    }
                    else
                        win = true;
                }
            }
            return win;
        }
        private void itog(Button[] x)
        {
            if (name != null)
                MessageBox.Show($"Игрок по имени {name} победил!");
            else
                MessageBox.Show($"Объявлена ничья!");
            foreach (Button a in x)
            {
                a.Content = " ";
                a.IsEnabled = false;
            }
            if (Opa.c == 1)
                Opa.c = 2;
            else
                Opa.c = 1;
            start.IsEnabled = true;
            name = null;
        }
        private bool proverka(string k)
        {
            bool win = false;
            if (block1.Content == k)
            {
                if (block2.Content == k)
                {
                    if (block3.Content == k)
                    {
                        win = true;
                        if (k == "x ")
                        {
                            if (Opa.c == 1)
                                name = "Игрок";
                            else if (Opa.c == 2)
                                name = "Бот";
                        }
                        else if (k == "o ")
                        {
                            if (Opa.c == 1)
                                name = "Бот";
                            else if (Opa.c == 2)
                                name = "Игрок";
                        }
                    }
                }
                else if (block5.Content == k)
                {
                    if (block9.Content == k)
                    {
                        win = true;
                        if (k == "x ")
                        {
                            if (Opa.c == 1)
                                name = "Игрок";
                            else if (Opa.c == 2)
                                name = "Бот";
                        }
                        else if (k == "o ")
                        {
                            if (Opa.c == 1)
                                name = "Бот";
                            else if (Opa.c == 2)
                                name = "Игрок";
                        }
                    }
                }
                else if (block4.Content == k)
                {
                    if (block7.Content == k)
                    {
                        win = true;
                        if (k == "x ")
                        {
                            if (Opa.c == 1)
                                name = "Игрок";
                            else if (Opa.c == 2)
                                name = "Бот";
                        }
                        else if (k == "o ")
                        {
                            if (Opa.c == 1)
                                name = "Бот";
                            else if (Opa.c == 2)
                                name = "Игрок";
                        }
                    }
                }
            }
            else if (block2.Content == k)
            {
                if (block5.Content == k)
                {
                    if (block8.Content == k)
                    {
                        win = true;
                        if (k == "x ")
                        {
                            if (Opa.c == 1)
                                name = "Игрок";
                            else if (Opa.c == 2)
                                name = "Бот";
                        }
                        else if (k == "o ")
                        {
                            if (Opa.c == 1)
                                name = "Бот";
                            else if (Opa.c == 2)
                                name = "Игрок";
                        }
                    }
                }
            }
            else if (block3.Content == k)
            {
                if (block6.Content == k)
                {
                    if (block9.Content == k)
                    {
                        win = true;
                        if (k == "x ")
                        {
                            if (Opa.c == 1)
                                name = "Игрок";
                            else if (Opa.c == 2)
                                name = "Бот";
                        }
                        else if (k == "o ")
                        {
                            if (Opa.c == 1)
                                name = "Бот";
                            else if (Opa.c == 2)
                                name = "Игрок";
                        }
                    }
                }
                else if (block5.Content == k)
                {
                    if (block7.Content == k)
                    {
                        win = true;
                        if (k == "x ")
                        {
                            if (Opa.c == 1)
                                name = "Игрок";
                            else if (Opa.c == 2)
                                name = "Бот";
                        }
                        else if (k == "o ")
                        {
                            if (Opa.c == 1)
                                name = "Бот";
                            else if (Opa.c == 2)
                                name = "Игрок";
                        }
                    }
                }
            }
            else if (block4.Content == k)
            {
                if (block5.Content == k)
                {
                    if (block6.Content == k)
                    {
                        win = true;
                        if (k == "x ")
                        {
                            if (Opa.c == 1)
                                name = "Игрок";
                            else if (Opa.c == 2)
                                name = "Бот";
                        }
                        else if (k == "o ")
                        {
                            if (Opa.c == 1)
                                name = "Бот";
                            else if (Opa.c == 2)
                                name = "Игрок";
                        }

                    }
                }
            }
            else if (block7.Content == k)
            {
                if (block8.Content == k)
                {
                    if (block9.Content == k)
                    {
                        win = true;
                        if (k == "x ")
                        {
                            if (Opa.c == 1)
                                name = "Игрок";
                            else if (Opa.c == 2)
                                name = "Бот";
                        }
                        else if (k == "o ")
                        {
                            if (Opa.c == 1)
                                name = "Бот";
                            else if (Opa.c == 2)
                                name = "Игрок";
                        }
                    }
                }
            }
            return win;
        }
    }
}