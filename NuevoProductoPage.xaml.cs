using CommunityToolkit.Maui.Core;
using ProductoAplicacion.Models;

namespace ProductoAplicacion;

public partial class NuevoProductoPage : ContentPage
{
    private Producto _producto;
	public NuevoProductoPage()
	{
		InitializeComponent();
        
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _producto = BindingContext as Producto;
        if (_producto != null)
        {
            Nombre.Text = _producto.Nombre;
            cantidad.Text = _producto.Cantidad.ToString();
            Descripcion.Text = _producto.Descripcion;
        }
    }

    private async void OnClickGuardarNuevoProducto(object sender, EventArgs e)
    {
        if (_producto != null)
        {
            _producto.Nombre=Nombre.Text;
            _producto.Cantidad = Int32.Parse(cantidad.Text);
            _producto.Descripcion = Descripcion.Text;
        }
        else
        {

            Producto producto = new Producto
            {
                IdProducto = 0,
                Nombre = Nombre.Text,
                Descripcion = Descripcion.Text,
                Cantidad = Int32.Parse(cantidad.Text)
            };

            Utils.Utils.listaProducto.Add(producto);
        }
        await Navigation.PopAsync();

    }
}