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
    public partial class FormEntry : Form
    {
        private const int k_MinAmountOfRows = 4;
        private int m_AmountOfRows = k_MinAmountOfRows;

        public int AmountOfRows
        {
            get
            {
                return m_AmountOfRows;
            }

            set
            {
                if (m_AmountOfRows < 10)
                {
                    m_AmountOfRows = value;
                }
                else
                {
                    m_AmountOfRows = k_MinAmountOfRows;
                }
            }
        }

        public FormEntry()
        {
            InitializeComponent();

        }

        private void ButtonStart_Click(object i_Sender, EventArgs i_)
        {
            this.Hide();
            Form gameForm = new FormGame(this.AmountOfRows);
            gameForm.ShowDialog();
            this.Close();
        }

        private void ButtonNumOfChances_Click(object i_Sender, EventArgs i_)
        {
            Button theSender = i_Sender as Button;
            this.AmountOfRows++;
            theSender.Text = string.Format("Number of chances: {0}", this.AmountOfRows);
        }

    }
}
