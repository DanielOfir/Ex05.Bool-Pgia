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
    public partial class FormColorSelection : Form
    {
        private readonly Button r_SenderButton = null;
        private readonly List<Color> r_SelectedColors;

        public FormColorSelection(object i_Sender, List<Color> i_SelectedColors)
        {
            r_SenderButton = i_Sender as Button;
            InitializeComponent();
            r_SelectedColors = i_SelectedColors;
        }

        private void changeSenderColor(object i_Sender)
        {
            Button theSender = i_Sender as Button;
            r_SenderButton.BackColor = theSender.BackColor;
            this.Close();
        }

        private void ButtonColor_Click(object i_Sender, EventArgs i_)
        {
            if (!GameLogicHandler.IsColorAlreadySelected(i_Sender, r_SelectedColors))
            {
                changeSenderColor(i_Sender);
            }
        }
    }
}
