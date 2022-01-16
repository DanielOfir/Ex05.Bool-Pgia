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
        private int m_AmountOfRows;
        //private static List<Color> m_AIColorsSelection;
        private List<Color> m_AIColorsSelection;
        private int currentActiveControl = 1;

        public FormGame(int i_AmountOfRows)
        {
            m_AmountOfRows = i_AmountOfRows;
            InitializeComponent();
            ChangeFormSizeByAmountOfRows(i_AmountOfRows);
            initializeFormGameControlBar();
            startGame();
        }

        private void ChangeFormSizeByAmountOfRows(int i_amountOfRows)
        {
            this.ClientSize = new System.Drawing.Size(286, i_amountOfRows * 50 + 45);
        }

        public int AmountOfRows
        {
            get
            {
                return m_AmountOfRows;
            }
        }


        public List<Color> AIColorsSelection
        {
            get
            {
                return m_AIColorsSelection;
            }
        }

        public int CurrentActiveControl
        {
            get
            {
                return currentActiveControl;
            }

            set
            {
                currentActiveControl = value;
            }
        }

        private void startGame()
        {
            Game game = new Game();
            m_AIColorsSelection = new List<Color>();
            foreach (Color color in game.AISelectedColors)
            {
                m_AIColorsSelection.Add(color);
            }
        }

        public void showAISelections()
        {
           ButtonAISelection1.BackColor = m_AIColorsSelection[0];
           ButtonAISelection2.BackColor = m_AIColorsSelection[1];
           ButtonAISelection3.BackColor = m_AIColorsSelection[2];
           ButtonAISelection4.BackColor = m_AIColorsSelection[3];
        }

        private void initializeFormGameControlBar()
        {
            FormGameControlBar prevControlsRow = new FormGameControlBar();
            for (int i = 0; i < m_AmountOfRows; i++)
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

            //m_currentActiveControl = topRowControls;

        }
    }
}
