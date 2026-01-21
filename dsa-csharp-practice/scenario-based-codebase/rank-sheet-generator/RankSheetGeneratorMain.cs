using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Rank_Sheet_Generator
{
    internal class RankSheetGeneratorMain
    {
        public static void Main(string[] args)
        {
            RankSheetGenertorMenu menu = new RankSheetGenertorMenu();
            menu.ShowMenu();
        }
    }
}
