using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.Bool_Pgia
{
    public partial class FormGame : Form
    {
        private readonly int r_AmountOfRows;
        private List<Color> m_AiColorsSelection;
        private int m_CurrentActiveControl = 1;

        public FormGame(int i_AmountOfRows)
        {
            r_AmountOfRows = i_AmountOfRows;
            InitializeComponent();
            changeFormSizeByAmountOfRows(i_AmountOfRows);
            initializeFormGameControlBar();
            startGame();
        }

        private void changeFormSizeByAmountOfRows(int i_AmountOfRows)
        {
            this.ClientSize = new System.Drawing.Size(286, (i_AmountOfRows * 50) + 45);
        }

        public int AmountOfRows
        {
            get
            {
                return r_AmountOfRows;
            }
        }

        public List<Color> AiColorsSelection
        {
            get
            {
                return m_AiColorsSelection;
            }
        }

        public int CurrentActiveControl
        {
            get
            {
                return m_CurrentActiveControl;
            }

            set
            {
                m_CurrentActiveControl = value;
            }
        }

        private void startGame()
        {
            Game game = new Game();
            m_AiColorsSelection = new List<Color>();
            foreach (Color color in game.AiSelectedColors)
            {
                m_AiColorsSelection.Add(color);
            }
        }

        public void ShowAiSelections()
        {
            ButtonAISelection1.BackColor = m_AiColorsSelection[0];
            ButtonAISelection2.BackColor = m_AiColorsSelection[1];
            ButtonAISelection3.BackColor = m_AiColorsSelection[2];
            ButtonAISelection4.BackColor = m_AiColorsSelection[3];
        }

        private void initializeFormGameControlBar()
        {
            FormGameControlBar prevControlsRow = new FormGameControlBar();
            for (int i = 0; i < r_AmountOfRows; i++)
            {
                FormGameControlBar controlsRow = new FormGameControlBar();
                if (i == 0)
                {
                    controlsRow.Top = ButtonAISelection1.Bottom + 10;
                    controlsRow.Left = ButtonAISelection1.Left - 1;
                    prevControlsRow = controlsRow;
                }
                else
                {
                    controlsRow.Top = prevControlsRow.Bottom + 3;
                    controlsRow.Left = prevControlsRow.Left;
                    controlsRow.Enabled = false;
                }

                controlsRow.Name = string.Format("GameControlPanel{0}", i + 1);
                controlsRow.Tag = i + 1;
                controlsRow.TopLevel = false;
                Controls.Add(controlsRow);
                controlsRow.Show();

                prevControlsRow = controlsRow;
            }
        }
    }
}
