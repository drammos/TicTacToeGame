using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

using TicTacToe.Box;
using TicTacToe.View;
namespace TicTacToe;

public partial class StartGame : ContentPage
{
    public ObservableCollection<TicTacToeBox> TicTacToeList { get; set; } = new ObservableCollection<TicTacToeBox>();
    private TicTacToeGame TicTacToeGameInstance { get; set; }
 
    public StartGame()
    {
        InitializeComponent();
        TicTacToeGameInstance = new TicTacToeGame();
        this.BindingContext = TicTacToeGameInstance;
    }

}