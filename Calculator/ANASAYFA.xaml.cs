namespace Calculator;

public partial class ANASAYFA : ContentPage
{
	public ANASAYFA()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync( new MainPage() );
    }
}