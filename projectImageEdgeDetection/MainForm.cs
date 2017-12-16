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
        private MyImage source;
        private MyImage result;


        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonLaplacian_Click(object sender, EventArgs e)
        {
            result = view.Laplacian3x3Filter(source);
            pictureBoxNewImage.Image = (Image)result.GetBitmap();
        }

        private void ButtonOtherMethod_Click(object sender, EventArgs e)
        {
            Color color = Color.Green;
            result = view.SetColorFilter(source, 230, 110, color);
            pictureBoxNewImage.Image = (Image)result.GetBitmap();
        }

        private void ButtonLoadImage_Click(object sender, EventArgs e)
        {
            this.source = view.LoadImage();
            pictureBoxImageSource.Image = (Image)source.GetBitmap();
        }
    }
}
