using Avalonia.Controls;
namespace ChallShop;
public partial class FlagWindow : Window{
  string flag="CSU{4v4l0n1_4pp_345y??_51_51_!!!!_lol}";
  public FlagWindow(){
    InitializeComponent();
    CargarFlag();
  }
  public void CargarFlag(){
    Flag.Text=flag;
  }
}
