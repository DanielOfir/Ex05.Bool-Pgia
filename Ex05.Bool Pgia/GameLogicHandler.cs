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
        public static bool CheckWin(int[] i_HitList)
        {
            int counter = 0;
            for (int i = 0; i < i_HitList.Length; i++)
            {
                if (i_HitList[i] == 1)
                {
                    counter++;
                }
            }

            if (counter == i_HitList.Length)
            {
                return true;
            }

            return false;
        }

        public static bool IsColorAlreadySelected(object i_Sender, List<Color> i_SelectedColors)
        {
            Button senderButton = i_Sender as Button;
            foreach (Color color in i_SelectedColors)
            {
                if (senderButton.BackColor == color)
                {
                    string message = "This color is already selected!" + Environment.NewLine + "Please select a different color";
                    string caption = "Color Selection Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                    return true;
                }
            }

            return false;
        }

        public static int[] GetUserHits(Color[] i_UserSelectedColors, List<Color> i_AiSelectedColors)
        {
            int[] hitFlags = new int[i_UserSelectedColors.Length];

            for (int i = 0; i < i_UserSelectedColors.Length; i++)
            {
                if (i_UserSelectedColors[i] == i_AiSelectedColors[i])
                {
                    hitFlags[i] = 1; // Hit on location
                }
                else
                {
                    int zeroFlag = 0;
                    for (int j = 0; j < i_UserSelectedColors.Length; j++)
                    {
                        if (i_AiSelectedColors[j] == i_UserSelectedColors[i])
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
