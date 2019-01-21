using System;
using System.Collections.Generic;
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

namespace SimpleGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<TextBox> lines = new List<TextBox>();
        public MainWindow()
        {
            InitializeComponent();
            lines.Add(Line1);
            lines.Add(Line2);
            lines.Add(Line3);
            lines.Add(Line4);

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            foreach(TextBox box in lines) {
                box.Text = String.Empty;
            }
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            string oldText, newText;
            newText = lines[1].Text;
            string firstText = lines[0].Text;

            for (int i = 0; i < lines.Count; i++) {
                oldText = lines[i].Text;
                lines[i].Text = newText;

                if (i + 2 < lines.Count) {
                    newText = lines[i + 2].Text;
                } else {
                    newText = firstText;
                }
                
            }

        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            string oldText, newText;
            oldText = lines[0].Text;
            newText = lines[lines.Count - 1].Text;
            for (int i = 0; i < lines.Count; i++) {
                oldText = lines[i].Text;
                lines[i].Text = newText;
                newText = oldText;
            }
        }
    }
}
