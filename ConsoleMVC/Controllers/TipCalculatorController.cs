﻿using ConsoleMVC.Model;
using ConsoleMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Controllers
{
    public class TipCalculatorController
    {
        private Tip tip;
        private Display display;
        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipAndtotal();
        }
    }
}
