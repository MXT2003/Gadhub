using GadHubMAUI.Views;

namespace GadHubMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Thiết lập trang đăng nhập là trang khởi động
            MainPage = new LoginPage();
        }
    }
}