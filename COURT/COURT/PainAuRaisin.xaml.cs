namespace COURT
{
    public partial class PainAuRaisin : ContentPage
    {
        
        public PainAuRaisin()
        {
            InitializeComponent();

            webView.Source = new UrlWebViewSource { Url = "https://www.youtube.com/watch?v=kJQP7kiw5Fk" };
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MachoireCarre());
        }
    }
}
