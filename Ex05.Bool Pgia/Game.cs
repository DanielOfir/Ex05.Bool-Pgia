using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.Bool_Pgia
{
    class Game
    {
        private const int k_AmountOfSelections = 4;
        private List<Color> m_AIColorsSelectedList;
        private static List<Color> m_AIColorOptionsList = new List<Color>
                                                              {
                                                                  System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
                                                                  System.Drawing.Color.Red,
                                                                  System.Drawing.Color.Lime,
                                                                  System.Drawing.Color.Aqua,
                                                                  System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
                                                                  System.Drawing.Color.Yellow,
                                                                  System.Drawing.Color.Maroon,
                                                                  System.Drawing.Color.White
                                                              };

        public Game()
        {
            generateAiSelection();
        }

        public List<Color> AISelectedColors
        {
            get
            {
                return m_AIColorsSelectedList;
            }
        }

        private void generateAiSelection()
        {
            m_AIColorsSelectedList = new List<Color>();
            Random rand = new Random();
            for (int i = 0; i < k_AmountOfSelections; i++)
            {
                int selectionIndex = rand.Next(m_AIColorOptionsList.Count);
                m_AIColorsSelectedList.Add(m_AIColorOptionsList[selectionIndex]);
                m_AIColorOptionsList.RemoveAt(selectionIndex);
            }
        }
    }
}
