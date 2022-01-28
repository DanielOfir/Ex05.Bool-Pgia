using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.Bool_Pgia
{
    internal class Game
    {
        private const int k_AmountOfSelections = 4;
        private static readonly List<Color> sr_AiColorOptionsList = new List<Color>
                                                                       {
                                                                           Color.Purple,
                                                                           Color.Red,
                                                                           Color.Lime,
                                                                           Color.Aqua,
                                                                           Color.Blue,
                                                                           Color.Yellow,
                                                                           Color.Maroon,
                                                                           Color.White,
                                                                       };

        private List<Color> m_AiColorsSelectedList;

        public Game()
        {
            generateAiSelection();
        }

        public List<Color> AiSelectedColors
        {
            get
            {
                return m_AiColorsSelectedList;
            }
        }

        private void generateAiSelection()
        {
            m_AiColorsSelectedList = new List<Color>();
            Random rand = new Random();
            for (int i = 0; i < k_AmountOfSelections; i++)
            {
                int selectionIndex = rand.Next(sr_AiColorOptionsList.Count);
                m_AiColorsSelectedList.Add(sr_AiColorOptionsList[selectionIndex]);
                sr_AiColorOptionsList.RemoveAt(selectionIndex);
            }
        }
    }
}
