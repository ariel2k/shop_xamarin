namespace Shop.UIForms.ViewModels
{
    public class MainViewModel
    {
        public LoginViewModel Login { get; set; }

        public ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            // Isn't good practice.
            this.Login = new LoginViewModel();
        }
    }
}
