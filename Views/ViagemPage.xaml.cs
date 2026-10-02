using ProjetoViagem.ViewsModels;

namespace ProjetoViagem.Views;

public partial class ViagemPage : ContentPage
{
	public ViagemPage(ViagemViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}