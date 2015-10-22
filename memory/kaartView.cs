using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory
{
    public partial class KaartView : UserControl
    {
        // member die de controller onthoudt --> verbinding tss view en model 
        private KaartController controller;

            // Constructor die de dependency injection van de controller opvangt
        public KaartView(KaartController kaartController)
        {
            InitializeComponent();

            // Ken de controller injection toe aan de member
            controller = kaartController;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                clickedLabel.ForeColor = Color.Black;
            }
        }

        private void kaartView_Load(object sender, EventArgs e)
        {

        }
    }
}
