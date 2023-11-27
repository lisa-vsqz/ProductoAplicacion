using CommunityToolkit.Maui.Core;
using ProductoAplicacion.Models;

namespace ProductoAplicacion;

public partial class DetalleProductoPage : ContentPage
{
    private Producto _producto;

    public DetalleProductoPage()
	{
		InitializeComponent();
       
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _producto = BindingContext as Producto;
        Nombre.Text = _producto.Nombre;
        Cantidad.Text = _producto.Cantidad.ToString();
        Descripcion.Text = _producto.Descripcion;
    }


    private async void OnClickBorrar(object sender, EventArgs e)
    {
        Utils.Utils.listaProducto.Remove(_producto);
        await Navigation.PopAsync();
    }

    private async void OnClickEditar(object sender, EventArgs e)
    {
        var toast = CommunityToolkit.Maui.Alerts.Toast.Make(_producto.Nombre, ToastDuration.Short, 14);

        await toast.Show();
        await Navigation.PushAsync(new NuevoProductoPage() { 
            BindingContext = _producto,
       });
    }


}