using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using TicTacToe.Box;

namespace TicTacToe.View
{
    public partial class TicTacToeGame : ObservableObject
    {
        public ObservableCollection<TicTacToeBox> TicTacToeList { get; set; } = new ObservableCollection<TicTacToeBox>();


        // Initialize the game Tic-Tac-Toe
        public TicTacToeGame()
        {
            this.PlayerTurn = "X";
            SetUpGame();
        }

        public String Winner
        {
            get
            {
                return "The player " + _theWinner + " is Winner!";
            }
        }

        private String _theWinner;
        public String TheWinner
        {
            get { return _theWinner; }
            set { _playerTurn = value; OnPropertyChanged("Winner"); }
        }



        // Screen Player for label
        public string ScreenPlayer
        {
            get
            {
                return "Player " + _playerTurn;
            }
        }


        // The player is 'X' or 'O'
        private string _playerTurn;
        public String PlayerTurn
        {
            get
            {
                return _playerTurn;
            }
            set
            {
                _playerTurn = value;
                OnPropertyChanged("ScreenPlayer");
            }
        }


        // SetUp the Game
        private void SetUpGame()
        {
            this.PlayerTurn = "X";
            TicTacToeList.Clear();
            for (int i = 0; i < 9; i++)
            {
                TicTacToeList.Add(new TicTacToeBox(i));
            }
        }

        [RelayCommand]
        public void SelectedItem(TicTacToeBox selectedItem)
        {

            if (selectedItem.Player != null)
            {
                return;
            }

            if (PlayerTurn == "X")
            {
                selectedItem.SelectedText = "X";
                selectedItem.Player = 0;
                this.PlayerTurn = "O";
                this._playerTurn = "O";


            }
            else
            {
                selectedItem.SelectedText = "O";
                selectedItem.Player = 1;
                this._playerTurn = "X";
                this.PlayerTurn = "X";

            }
            // Check for Winner
            CheckStateForGame();
        }


        public void CheckStateForGame()
        {

            TicTacToeBox pos0 = TicTacToeList[0];
            TicTacToeBox pos1 = TicTacToeList[1];
            TicTacToeBox pos2 = TicTacToeList[2];
            TicTacToeBox pos3 = TicTacToeList[3];
            TicTacToeBox pos4 = TicTacToeList[4];
            TicTacToeBox pos5 = TicTacToeList[5];
            TicTacToeBox pos6 = TicTacToeList[6];
            TicTacToeBox pos7 = TicTacToeList[7];
            TicTacToeBox pos8 = TicTacToeList[8];


            if (pos0.SelectedText == pos1.SelectedText && pos0.SelectedText == pos2.SelectedText && pos0.SelectedText != null)
            {
                if (pos0.Player == 0)
                {
                    this._theWinner = "X";
                    this.TheWinner = "X";
                    Console.WriteLine("Win Player X 012");
                }
                else
                {
                    this._theWinner = "O";
                    this.TheWinner = "O";
                    Console.WriteLine("Win Player O 012");
                }
            }


            if (pos3.SelectedText == pos4.SelectedText && pos3.SelectedText == pos5.SelectedText && pos3.SelectedText != null)
            {
                if (pos3.Player == 0)
                {
                    this._theWinner = "X";
                    this.TheWinner = "X";
                    Console.WriteLine("Win Player X 345");
                }
                else
                {
                    this._theWinner = "O";
                    this.TheWinner = "O";
                    Console.WriteLine("Win Player O 345");
                }
            }

            if (pos6.SelectedText == pos7.SelectedText && pos6.SelectedText == pos8.SelectedText && pos6.SelectedText != null)
            {
                if (pos6.Player == 0)
                {
                    this._theWinner = "X";
                    this.TheWinner = "X";
                    Console.WriteLine("Win Player X 678");
                }
                else
                {
                    this._theWinner = "O";
                    this.TheWinner = "O";
                    Console.WriteLine("Win Player O 678");
                }
            }


            if (pos0.SelectedText == pos3.SelectedText && pos0.SelectedText == pos6.SelectedText && pos0.SelectedText != null)
            {
                if (pos0.Player == 0)
                {
                    this._theWinner = "X";
                    this.TheWinner = "X";
                    Console.WriteLine("Win Player X 036");
                }
                else
                {
                    this._theWinner = "O";
                    this.TheWinner = "O";
                    Console.WriteLine("Win Player O 036");
                }
            }

            if (pos1.SelectedText == pos4.SelectedText && pos1.SelectedText == pos7.SelectedText && pos1.SelectedText != null)
            {
                if (pos1.Player == 0)
                {
                    this._theWinner = "X";
                    this.TheWinner = "X";
                    Console.WriteLine("Win Player X 147");
                }
                else
                {
                    this._theWinner = "O";
                    this.TheWinner = "O";
                    Console.WriteLine("Win Player O 147");
                }
            }

            if (pos2.SelectedText == pos5.SelectedText && pos2.SelectedText == pos8.SelectedText && pos2.SelectedText != null)
            {
                if (pos0.Player == 0)
                {
                    this._theWinner = "X";
                    this.TheWinner = "X";
                    Console.WriteLine("Win Player X 258");
                }
                else
                {
                    this._theWinner = "O";
                    this.TheWinner = "O";
                    Console.WriteLine("Win Player O 258");
                }
            }

            if(pos0.SelectedText == pos4.SelectedText && pos0.SelectedText == pos8.SelectedText && pos0.SelectedText != null)
            {
                if (pos0.Player == 0)
                {
                    this._theWinner = "X";
                    this.TheWinner = "X";
                    Console.WriteLine("Win Player X 048");
                }
                else
                {
                    this._theWinner = "O";
                    this.TheWinner = "O";
                    Console.WriteLine("Win Player O 048");
                }
            }

            if (pos2.SelectedText == pos4.SelectedText && pos2.SelectedText == pos6.SelectedText && pos2.SelectedText != null)
            {
                if (pos2.Player == 0)
                {
                    this._theWinner = "X";
                    this.TheWinner = "X";
                    Console.WriteLine("Win Player X 246");
                }
                else
                {
                    this._theWinner = "O";
                    this.TheWinner = "O";
                    Console.WriteLine("Win Player O 246");
                }
            }
        }
    }
}