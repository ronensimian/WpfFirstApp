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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonApply_Click(object sender, RoutedEventArgs e)
        {
            //this.textboxDescription.Content = "quak quak!";
            MessageBox.Show("The description is: " + textboxDescription.Text);
        }

        private void ButtonResetCheckboxes_Click(object sender, RoutedEventArgs e)
        {
            checkbox01.IsChecked = checkbox02.IsChecked = checkbox03.IsChecked = checkbox04.IsChecked = checkbox05.IsChecked = checkbox06.IsChecked = false;
            // OR like this:
            checkbox07.IsChecked = false;
            checkbox08.IsChecked = false;
            checkbox09.IsChecked = false;
            checkbox10.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            textboxOutput.Text += (string)((CheckBox)sender).Content + ", ";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // this condition is for the start state, before it is SET
            if (textboxOutput == null)
            {
                return;
            }

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            textboxOutput.Text = value.Content.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // this method is for inserting the value to output on first load
            ComboBox_SelectionChanged(myDropdown, null);

        }

        private void TextboxDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            textboxRead.Text = textboxDescription.Text;
            textboxDisabled.Text = textboxDescription.Text;
        }
    }
}
