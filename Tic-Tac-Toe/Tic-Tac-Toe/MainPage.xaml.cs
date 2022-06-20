using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tic_Tac_Toe
{
    public partial class MainPage : ContentPage
    {
        bool turn = true;

        public List<string> TurnOptions = new List<string>
        {
            "GameButton1",
            "GameButton2",
            "GameButton3",
            "GameButton4",
            "GameButton5",
            "GameButton6",
            "GameButton7",
            "GameButton8",
            "GameButton9"
        };
        readonly List<string> ComputerTurn = new List<string>();

        public MainPage()
        {
            InitializeComponent();
            ComputerTurn = new List<string>();
        }


        private void GameButton1_Clicked(object sender, EventArgs e)
        {
            Button GameButton = (Button)sender;
            GameButton.Text = "X";
            TurnOptions.Remove(GameButton.ClassId);
            turn = !turn;
            GameButton.IsEnabled = false;
            ComputerLogic();
            GameLogic();
        }


        public void ComputerRandom()
        {
            string ComputersMove = GetRandom(TurnOptions);

            ComputerTurn.Add(ComputersMove);
            TurnOptions.Remove(ComputersMove);
            


            switch (ComputersMove)
            {
                case "GameButton1":
                    GameButton1.Text = "O";
                    GameButton1.IsEnabled = false;
                    break;
                case "GameButton2":
                    GameButton2.Text = "O";
                    GameButton2.IsEnabled = false;
                    break;
                case "GameButton3":
                    GameButton3.Text = "O";
                    GameButton3.IsEnabled = false;
                    break;
                case "GameButton4":
                    GameButton4.Text = "O";
                    GameButton4.IsEnabled = false;
                    break;
                case "GameButton5":
                    GameButton5.Text = "O";
                    GameButton5.IsEnabled = false;
                    break;
                case "GameButton6":
                    GameButton6.Text = "O";
                    GameButton6.IsEnabled = false;
                    break;
                case "GameButton7":
                    GameButton7.Text = "O";
                    GameButton7.IsEnabled = false;
                    break;
                case "GameButton8":
                    GameButton8.Text = "O";
                    GameButton8.IsEnabled = false;
                    break;
                case "GameButton9":
                    GameButton9.Text = "O";
                    GameButton9.IsEnabled = false;
                    break;
                default:
                    break;
            }



        }


        private void ComputerLogic()
        {

            if (GameButton1.Text == "X" && GameButton2.Text == "X" && GameButton3.Text == "") /*horizontal*/
            {
                GameButton3.Text = "O";
                GameButton3.IsEnabled = false;
            }
            else if (GameButton1.Text == "X" && GameButton2.Text == "" && GameButton3.Text == "X") /*horizontal*/
            {
                GameButton2.Text = "O";
                GameButton2.IsEnabled = false;
            }
            else if (GameButton1.Text == "" && GameButton2.Text == "X" && GameButton3.Text == "X") /*horizontal*/
            {
                GameButton1.Text = "O";
                GameButton1.IsEnabled = false;
            }
            else if (GameButton4.Text == "" && GameButton5.Text == "X" && GameButton6.Text == "X") /*horizontal*/
            {
                GameButton4.Text = "O";
                GameButton4.IsEnabled = false;
            }
            else if (GameButton4.Text == "X" && GameButton5.Text == "" && GameButton6.Text == "X") /*horizontal*/
            {
                GameButton5.Text = "O";
                GameButton5.IsEnabled = false;
            }
            else if (GameButton4.Text == "X" && GameButton5.Text == "X" && GameButton6.Text == "") /*horizontal*/
            {
                GameButton6.Text = "O";
                GameButton6.IsEnabled = false;
            }
            else if (GameButton7.Text == "X" && GameButton8.Text == "X" && GameButton9.Text == "") /*horizontal*/
            {
                GameButton9.Text = "O";
                GameButton9.IsEnabled = false;
            }
            else if (GameButton7.Text == "X" && GameButton8.Text == "" && GameButton9.Text == "X") /*horizontal*/
            {
                GameButton8.Text = "O";
                GameButton8.IsEnabled = false;
            }
            else if (GameButton7.Text == "" && GameButton8.Text == "X" && GameButton9.Text == "X") /*horizontal*/
            {
                GameButton7.Text = "O";
                GameButton7.IsEnabled = false;
            }
            else if (GameButton1.Text == "X" && GameButton4.Text == "X" && GameButton7.Text == "") /*vertical*/
            {
                GameButton7.Text = "O";
                GameButton7.IsEnabled = false;
            }
            else if (GameButton1.Text == "X" && GameButton4.Text == "" && GameButton7.Text == "X") /*vertical*/
            {
                GameButton4.Text = "O";
                GameButton4.IsEnabled = false;
            }
            else if (GameButton1.Text == "" && GameButton4.Text == "X" && GameButton7.Text == "X") /*vertical*/
            {
                GameButton1.Text = "O";
                GameButton1.IsEnabled = false;
            }
            else if (GameButton2.Text == "X" && GameButton5.Text == "X" && GameButton8.Text == "") /*vertical*/
            {
                GameButton8.Text = "O";
                GameButton8.IsEnabled = false;
            }
            else if (GameButton2.Text == "X" && GameButton5.Text == "" && GameButton8.Text == "X") /*vertical*/
            {
                GameButton5.Text = "O";
                GameButton5.IsEnabled = false;
            }
            else if (GameButton2.Text == "" && GameButton5.Text == "X" && GameButton8.Text == "X") /*vertical*/
            {
                GameButton2.Text = "O";
                GameButton2.IsEnabled = false;
            }
            else if (GameButton3.Text == "X" && GameButton6.Text == "X" && GameButton9.Text == "") /*vertical*/
            {
                GameButton9.Text = "O";
                GameButton9.IsEnabled = false;
            }
            else if (GameButton3.Text == "X" && GameButton6.Text == "" && GameButton9.Text == "X") /*vertical*/
            {
                GameButton6.Text = "O";
                GameButton6.IsEnabled = false;
            }
            else if (GameButton3.Text == "" && GameButton6.Text == "X" && GameButton9.Text == "X") /*vertical*/
            {
                GameButton3.Text = "O";
                GameButton3.IsEnabled = false;
            }
            else if (GameButton1.Text == "X" && GameButton5.Text == "X" && GameButton9.Text == "") /*diagonal*/
            {
                GameButton9.Text = "O";
                GameButton9.IsEnabled = false;
            }
            else if (GameButton1.Text == "X" && GameButton5.Text == "" && GameButton9.Text == "X") /*diagonal*/
            {
                GameButton5.Text = "O";
                GameButton5.IsEnabled = false;
            }
            else if (GameButton1.Text == "" && GameButton5.Text == "X" && GameButton9.Text == "X") /*diagonal*/
            {
                GameButton1.Text = "O";
                GameButton1.IsEnabled = false;
            }
            else if (GameButton3.Text == "X" && GameButton5.Text == "X" && GameButton7.Text == "") /*diagonal*/
            {
                GameButton7.Text = "O";
                GameButton7.IsEnabled = false;
            }
            else if (GameButton3.Text == "X" && GameButton5.Text == "" && GameButton7.Text == "X") /*diagonal*/
            {
                GameButton5.Text = "O";
                GameButton5.IsEnabled = false;
            }
            else if (GameButton3.Text == "" && GameButton5.Text == "X" && GameButton7.Text == "X") /*diagonal*/
            {
                GameButton3.Text = "O";
                GameButton3.IsEnabled = false;
            }
            else
            {
                ComputerRandom();
            }

        }


        private async void GameLogic()
        {

            if ((GameButton1.Text == "X" && GameButton2.Text == "X" && GameButton3.Text == "X") || /*horizontal*/
                (GameButton4.Text == "X" && GameButton5.Text == "X" && GameButton6.Text == "X") || /*horizontal*/
                (GameButton7.Text == "X" && GameButton8.Text == "X" && GameButton9.Text == "X") || /*horizontal*/
                (GameButton1.Text == "X" && GameButton4.Text == "X" && GameButton7.Text == "X") || /*Vertical*/
                (GameButton2.Text == "X" && GameButton5.Text == "X" && GameButton8.Text == "X") || /*Vertical*/
                (GameButton3.Text == "X" && GameButton6.Text == "X" && GameButton9.Text == "X") || /*Vertical*/
                (GameButton1.Text == "X" && GameButton5.Text == "X" && GameButton9.Text == "X") || /*Diagonal*/
                (GameButton3.Text == "X" && GameButton5.Text == "X" && GameButton7.Text == "X"))   /*Diagonal*/
            {
                TicTacToe.Text = "You win! Good job";
                ButtonClickDisabled();
                await StartGameOver();
            }
            else if ((GameButton1.Text == "O" && GameButton2.Text == "O" && GameButton3.Text == "O") || /*horizontal*/
                     (GameButton4.Text == "O" && GameButton5.Text == "O" && GameButton6.Text == "O") || /*horizontal*/
                     (GameButton7.Text == "O" && GameButton8.Text == "O" && GameButton9.Text == "O") || /*horizontal*/
                     (GameButton1.Text == "O" && GameButton4.Text == "O" && GameButton7.Text == "O") || /*Vertical*/
                     (GameButton2.Text == "O" && GameButton5.Text == "O" && GameButton8.Text == "O") || /*Vertical*/
                     (GameButton3.Text == "O" && GameButton6.Text == "O" && GameButton9.Text == "O") || /*Vertical*/
                     (GameButton1.Text == "O" && GameButton5.Text == "O" && GameButton9.Text == "O") || /*Diagonal*/
                     (GameButton3.Text == "O" && GameButton5.Text == "O" && GameButton7.Text == "O"))   /*Diagonal*/
            {
                TicTacToe.Text = "You Lose! Better luck next time";
                ButtonClickDisabled();
                await StartGameOver();
            }
            else if (GameButton1.Text != "" && GameButton2.Text != "" && GameButton3.Text != "" && GameButton4.Text != "" && GameButton5.Text != ""
                && GameButton6.Text != "" && GameButton7.Text != "" && GameButton8.Text != "" && GameButton9.Text != "") /*TiedGame*/
            {
                TicTacToe.Text = "You tied! Better luck next time";
                ButtonClickDisabled();
                await StartGameOver();
            }

        }


        private async Task StartGameOver()
        {
            await Task.Delay(5000);
            GameButton1.IsEnabled = true;
            GameButton2.IsEnabled = true;
            GameButton3.IsEnabled = true;
            GameButton4.IsEnabled = true;
            GameButton5.IsEnabled = true;
            GameButton6.IsEnabled = true;
            GameButton7.IsEnabled = true;
            GameButton8.IsEnabled = true;
            GameButton9.IsEnabled = true;
            GameButton1.Text = "";
            GameButton2.Text = "";
            GameButton3.Text = "";
            GameButton4.Text = "";
            GameButton5.Text = "";
            GameButton6.Text = "";
            GameButton7.Text = "";
            GameButton8.Text = "";
            GameButton9.Text = "";
            turn = true;
        }


        private void ButtonClickDisabled()
        {
            GameButton1.IsEnabled = false;
            GameButton2.IsEnabled = false;
            GameButton3.IsEnabled = false;
            GameButton4.IsEnabled = false;
            GameButton5.IsEnabled = false;
            GameButton6.IsEnabled = false;
            GameButton7.IsEnabled = false;
            GameButton8.IsEnabled = false;
            GameButton9.IsEnabled = false;
        }


        private static readonly Random r = new Random();


        public static int Random(int num1)
        {
            return r.Next(num1);
        }


        public string GetRandom(List<string> TurnOptions)
        {
            int ComputerMove = Random(this.TurnOptions.Count);


            return TurnOptions[ComputerMove];
        }



    }
}
