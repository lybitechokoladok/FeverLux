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

namespace FeverluxApp.WPF.Controls
{
    /// <summary>
    /// Логика взаимодействия для EyedCheckBox.xaml
    /// </summary>
    public partial class EyedCheckBox : UserControl
    {
        private bool? _checked;

        public bool? IsChecked
        {
            get => _checked;
            set => _checked= value;
 
        }


        public EyedCheckBox()
        {
            InitializeComponent();
        }

        private void CheckBoxEye_Checked(object sender, RoutedEventArgs e)
        {
            IsChecked = checkBoxEye.IsChecked;
        }

        private void checkBoxEye_Unchecked(object sender, RoutedEventArgs e)
        {
            IsChecked= checkBoxEye.IsChecked;
        }
    }
}
