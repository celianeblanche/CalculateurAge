using CalculateurAge.Views;
namespace CalculateurAge
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalculerClicked(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(entryNom.Text))
            {
                DisplayAlert("Erreur", "Entrez un nom", "OK");
                return;
            }

            DateTime d = pickerDate.Date;
            int age = DateTime.Today.Year - d.Year;

            if (d.Date > DateTime.Today.AddYears(-age)) age--;

            await Shell.Current.GoToAsync(
                $"{nameof(ResultatPage)}?nom={entryNom.Text}&age={age}");

        }
    }
}
