using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using System.Collections.ObjectModel;
using ProductoAplicacion.Models;

namespace ProductoAplicacion;

public partial class ProductoPage : ContentPage
{
	public ProductoPage()
	{
		InitializeComponent();
		ListaProductos.ItemsSource =Utils.Utils.listaProducto;
	}

	private async void OnClicNuevoProducto(object sender, EventArgs e)
	{
		var toast = Toast.Make("On cLick Nuevo Producto", ToastDuration.Short, 14);
		await toast.Show();
        //redirigir a pantalla nuevo producto 
        await Navigation.PushAsync(new NuevoProductoPage());
    }
    

    protected override void OnAppearing()
    {
        base.OnAppearing();
		var producto = new ObservableCollection<Producto>(Utils.Utils.listaProducto);
		ListaProductos.ItemsSource = producto;
    }


    private async void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
    {
        var toast = CommunityToolkit.Maui.Alerts.Toast.Make("Click en ver producto", ToastDuration.Short, 14);

        await toast.Show();
        Producto producto = e.SelectedItem as Producto;
        await Navigation.PushAsync(new DetalleProductoPage()
        {
            BindingContext = producto,
        });
    }
}