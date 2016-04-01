using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar8
{
    public partial class Form1 : Form
    {
        private Shape[] shapes = new Shape[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shapes[0] = new Circle("Circle1", 2.0);
            shapes[1] = new Circle("Circle2", 4.5);
            shapes[2] = new Square("Square1", 2.5);
            shapes[3] = new Square("Square2", 5.0);
            shapes[4] = new Rectangle("Rectangle1", 2.0, 5.0);
            shapes[5] = new Rectangle("Rectangle2", 12.5, 5.0);
            shapes[6] = new House("House1", 2.0, 10.5, 14.0);
            shapes[7] = new House("House2", 1.0, 2.0, 2.5);

            for(int i = 0; i < shapes.Length; i++)
            {
                shapeListBox.Items.Add(shapes[i].Name);
            }
        }

        private void shapeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dimensionOutputLabel.Text = shapes[shapeListBox.SelectedIndex].dimensions();

            areaOutputLabel.Text = shapes[shapeListBox.SelectedIndex].area().ToString();

            perimierOutputLabel.Text = shapes[shapeListBox.SelectedIndex].perimeter().ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
