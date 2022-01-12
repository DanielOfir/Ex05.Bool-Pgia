using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Ex05.Bool_Pgia
{
    public static class GameLogicHandler
    {

        public static bool IsColorAlreadySelected(object i_Sender)
        {
            Button senderButton = i_Sender as Button;
            foreach (Color color in FormGameControlBar.buttonColorsList)
            {
                if (senderButton.BackColor == color)
                {
                    string message = "This color is already selected!\nPlease select a different color";
                    string caption = "Color Selection Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                    return true;
                }
            }

            return false;
        }

        public static int[] GetUserHits(Color[] i_userSelectedColors)
        {
            int[] hitFlags = new int[i_userSelectedColors.Length];

            for (int i = 0; i < i_userSelectedColors.Length; i++)
            {
                if (i_userSelectedColors[i] == FormGame.AIColorsSelection[i])
                {
                    hitFlags[i] = 1; // Hit on location
                }
                else
                {
                    int zeroFlag = 0;
                    for (int j = 0; j < i_userSelectedColors.Length; j++)
                    {
                        if (FormGame.AIColorsSelection[j] == i_userSelectedColors[i])
                        {
                            hitFlags[i] = 0; // Hit
                            zeroFlag = 1;
                        }
                    }

                    if (zeroFlag == 0)
                    {
                        hitFlags[i] = -1; // No hit
                    }
                }
            }

            Array.Sort(hitFlags);
            Array.Reverse(hitFlags);

            return hitFlags;
        }

    }

}
