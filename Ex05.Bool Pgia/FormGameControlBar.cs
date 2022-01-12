﻿using System;
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
        public static List<Color> buttonColorsList = new List<Color>();
        private Dictionary<int, Color> colorHitMapping = new Dictionary<int, Color>() // TODO: Need a better way
                                                             {
                                                                 {-1, SystemColors.Control},
                                                                 {0, Color.Yellow},
                                                                 {1, Color.Black}
                                                             };


        public FormGameControlBar()
        {
            InitializeComponent();
        }



        private void ButtonUserGuess_Click(object i_Sender, EventArgs i_)
        {
            Form colorForm = new FormColorSelection(i_Sender);
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
            Color[] userSelectedColors = new Color[] // Maybe save as member
                                             {
                                                 ButtonUserGuess1.BackColor ,
                                                 ButtonUserGuess2.BackColor,
                                                 ButtonUserGuess3.BackColor,
                                                 ButtonUserGuess4.BackColor
                                             };
            int[] userHits = GameLogicHandler.GetUserHits(userSelectedColors);
            ButtonUserResult1.BackColor = colorHitMapping[userHits[0]];
            ButtonUserResult2.BackColor = colorHitMapping[userHits[1]];
            ButtonUserResult3.BackColor = colorHitMapping[userHits[2]];
            ButtonUserResult4.BackColor = colorHitMapping[userHits[3]];

            ButtonUserResult1.Enabled = false;
            ButtonUserResult2.Enabled = false;
            ButtonUserResult3.Enabled = false;
            ButtonUserResult4.Enabled = false;

            //FormGame.CurrentActiveControl.SelectNextControl(ActiveControl, true, true, true, true);
            //FormGame.CurrentActiveControl.Enabled = true;

            Button senderButton = i_Sender as Button;
            senderButton.Enabled = false;

        }
    }
}