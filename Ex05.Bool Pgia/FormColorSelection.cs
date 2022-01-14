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
    public partial class FormColorSelection : Form
    {
        private Button m_SenderButton = null;
        private List<Color> m_SelectedColors;

        public FormColorSelection(object i_Sender, List<Color> i_SelectedColors)
        {
            m_SenderButton = i_Sender as Button;
            InitializeComponent();
            m_SelectedColors = i_SelectedColors;
        }


        private void changeSenderColor(object i_Sender)
        {
            Button theSender = i_Sender as Button;
            m_SenderButton.BackColor = theSender.BackColor;
            this.Close();
        }

        private void ButtonColor_Click(object i_Sender, EventArgs i_)
        {

            if (!GameLogicHandler.IsColorAlreadySelected(i_Sender,m_SelectedColors))
            {
                changeSenderColor(i_Sender);
            }

        }
    }
}
