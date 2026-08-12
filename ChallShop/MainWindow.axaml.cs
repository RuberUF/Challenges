using Avalonia.Controls;
namespace ChallShop;

public partial class MainWindow : Window{
    double saldo=5.00;
    Producto producto = new Producto();
    public MainWindow(){
        InitializeComponent();
        CargarProductos();
    }
    public void CargarProductos(){
      Saldo.Text="Saldo : S/"+saldo.ToString();

      producto.Nombre="Polera";
      producto.Precio=10.00;
      Producto1.Text=producto.Nombre.ToString();
      Precio1.Text=producto.Precio.ToString();

      producto.Nombre="Polera2";
      producto.Precio=10.00;
      Producto2.Text=producto.Nombre.ToString();
      Precio2.Text=producto.Precio.ToString();

      producto.Nombre="Polera3";
      producto.Precio=10.00;
      Producto3.Text=producto.Nombre.ToString();
      Precio3.Text=producto.Precio.ToString();

      producto.Nombre="Polera4";
      producto.Precio=10.00;
      Producto4.Text=producto.Nombre.ToString();
      Precio4.Text=producto.Precio.ToString();

      producto.Nombre="Poler5";
      producto.Precio=10.00;
      Producto5.Text=producto.Nombre.ToString();
      Precio5.Text=producto.Precio.ToString();

      producto.Nombre="Flag";
      producto.Precio=10.00;
      Producto6.Text=producto.Nombre.ToString();
      Precio6.Text=producto.Precio.ToString();

    }
    public void Comprar(object sender,Avalonia.Interactivity.RoutedEventArgs e){
      FlagWindow Flag = new FlagWindow();
      if(saldo >= producto.Precio){
        Flag.ShowDialog(this);
        saldo-=producto.Precio;
      }else{
        Flag.ShowDialog(this);
      }
    }
}
