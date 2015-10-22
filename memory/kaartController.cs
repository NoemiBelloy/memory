using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memory
{
    public  class KaartController
    {
        private KaartView view;
        private KaartModel model;

        // Constructor
        public KaartController()
        {
            // Maak instanties van model en view aan
            model = new KaartModel();

            /* 
                Injecteer huidige instante (=controller) zodat de view kan communiceren
                wanneer er een bepaald event heeft plaatsgevonden
            */
            view = new KaartView(this);
        }
    }
}
