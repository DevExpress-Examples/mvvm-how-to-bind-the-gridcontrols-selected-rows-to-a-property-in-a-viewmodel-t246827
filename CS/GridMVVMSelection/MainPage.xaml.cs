using System.Windows.Controls;
using Model;

namespace SLGridMVVMSelection {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }
}
