namespace COURT
{
    public partial class MachoireCarre : ContentPage
    {
        public MachoireCarre()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(100);
            Snow.IsAnimationPlaying = true;
        }
    }

    
}
