using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.Bool_Pgia
{
    public partial class FormGameControlBar : Form
    {
        private const int k_AmountOfUserGuessButtons = 4;
        private List<Color> buttonColorsList = new List<Color>(); // Maybe create property
        private Dictionary<int, Color> colorHitMapping = new Dictionary<int, Color>() // TODO: Need a better way
                                                             {
                                                                 {-1, SystemColors.Control},
                                                                 {0, Color.Yellow},
                                                                 {1, Color.Black}
                                                             };

        public List<Color> SelectedColorList
        {
            get
            {
                return buttonColorsList;
            }
            set
            {
                buttonColorsList = value;
            }
        }


        public FormGameControlBar()
        {
            InitializeComponent();
        }



        private void ButtonUserGuess_Click(object i_Sender, EventArgs i_)
        {
            Button senderButton = i_Sender as Button;
            SelectedColorList.Remove(senderButton.BackColor); // If color already selected for the button and user wants to change
            Form colorForm = new FormColorSelection(i_Sender, SelectedColorList);
            colorForm.ShowDialog();
        }

        private void ButtonUserGuess_OnBackColorChanged(object i_Sender, EventArgs i_)
        {
            Button senderButton = i_Sender as Button;
            ButtonFinishUserGuess.Enabled = (ButtonUserGuess1.BackColor != SystemColors.Control && // Default color
                                             ButtonUserGuess2.BackColor != SystemColors.Control &&
                                             ButtonUserGuess3.BackColor != SystemColors.Control &&
                                             ButtonUserGuess4.BackColor != SystemColors.Control);

            buttonColorsList.Add(senderButton.BackColor);

        }


        private void Controls_Load(object i_Sender, EventArgs i_)
        {

        }


        private void ButtonFinishUserGuess_Click(object i_Sender, EventArgs i_)
        {
            FormGame parentForm = this.Parent as FormGame;
            

            Color[] userSelectedColors = new Color[] // Maybe save as member
                                             {
                                                 ButtonUserGuess1.BackColor ,
                                                 ButtonUserGuess2.BackColor,
                                                 ButtonUserGuess3.BackColor,
                                                 ButtonUserGuess4.BackColor
                                             };
            int[] userHits = GameLogicHandler.GetUserHits(userSelectedColors, parentForm.AIColorsSelection);


            ButtonUserResult1.BackColor = colorHitMapping[userHits[0]];
            ButtonUserResult2.BackColor = colorHitMapping[userHits[1]];
            ButtonUserResult3.BackColor = colorHitMapping[userHits[2]];
            ButtonUserResult4.BackColor = colorHitMapping[userHits[3]];

            ButtonUserResult1.Enabled = false;
            ButtonUserResult2.Enabled = false;
            ButtonUserResult3.Enabled = false;
            ButtonUserResult4.Enabled = false;

            

            if (GameLogicHandler.CheckWin(userHits))
            {
                parentForm.showAISelections();
            }

            else
            {
                if(parentForm.CurrentActiveControl == parentForm.AmountOfRows)
                {
                    // Last guess, no win
                    parentForm.showAISelections();
                }
                else
                {
                    parentForm.Controls[string.Format("GameControlPanel{0}", ++parentForm.CurrentActiveControl)]
                        .Enabled = true; // Enable next controlbar
                    
                }
            }

            buttonColorsList.Clear();
            this.Enabled = false;




        }
    }
}
