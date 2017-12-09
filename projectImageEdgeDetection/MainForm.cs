using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projectImageEdgeDetection
{
    public partial class MainForm : Form
    {
        private IView view = new ViewProxy();
        private Bitmap source;


        public MainForm()
        {
            InitializeComponent();
            source = (Bitmap)pictureBoxImageSource.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap result;
            result = view.Laplacian3x3Filter(source);
            pictureBoxNewImage.Image = (Image)result;
        }

        private void buttonOtherMethod_Click(object sender, EventArgs e)
        {
            Bitmap result;
            result = view.otherMethodFilter(source);
        }
    }
}
