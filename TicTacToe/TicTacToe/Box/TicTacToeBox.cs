using CommunityToolkit.Mvvm.ComponentModel;
namespace TicTacToe.Box
{
    public partial class TicTacToeBox : ObservableObject
    {

        public TicTacToeBox(int index) {
            this.Index = index;
        }

        public int Index { get; set; }

        [ObservableProperty]
        private string _selectedText;


        public int? Player {  get; set; }
    }
}