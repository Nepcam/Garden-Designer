using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PracP4
{
    public partial class GardenDesigner : Form
    {
        // declare variables
        string plantName = "";
        int sizePlant = 0;
        decimal costPlant = 0;

        //####################################################################
        //# Instance Variables
        /// <summary>
        /// List of all the plants currently in the garden.
        /// </summary>
        private List<Plant> plants;

        //####################################################################
        //# Constructor
        public GardenDesigner()
        {
            plants = new List<Plant>();
            InitializeComponent();
        }

        //####################################################################
        //# Auxiliary Methods
        /// <summary>
        /// Displays all the plants in the given graohics context.
        /// </summary>
        private void DrawGarden(Graphics paper)
        {
            foreach (Plant plant in plants)
            {
                plant.Draw(paper);
            }
        }

        /// <summary>
        /// Checks whether the three text boxes contain valid input to
        /// create a plant.
        /// </summary>
        /// <returns>true if input is valid, false otherwise.</returns>
        private bool CheckInput()
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please enter a valid name.");
                return false;
            }
            int size = -1;
            try
            {
                size = Convert.ToInt32(textBoxSize.Text);
            }
            catch (FormatException)
            {
                // parse error, keep size = -1
            }
            if (size <= 0)
            {
                MessageBox.Show("Please enter a valid size.");
                return false;
            }
            decimal price = -1;
            try
            {
                price = Convert.ToDecimal(textBoxPrice.Text);
            }
            catch (FormatException)
            {
                // parse error, keep price = -1
            }
            if (price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return false;
            }
            return true;
        }

        //####################################################################
        //# Event Handler
        /// <summary>
        /// Event handler called when the form needs redrawing.
        /// Causes all the plants to be re-displayed.
        /// </summary>
        private void pictureBoxGarden_Paint(object sender, PaintEventArgs e)
        {
            Graphics paper = e.Graphics;
            paper.Clear(pictureBoxGarden.BackColor);
            DrawGarden(paper);
        }

        /// <summary>
        /// Mouse-click handler of the picture box.
        /// You need to change this method.
        /// </summary>
        private void pictureBoxGarden_MouseClick(object sender, MouseEventArgs e)
        {
            if (CheckInput())
            {
                string name = textBoxName.Text;
                int size = Convert.ToInt32(textBoxSize.Text);
                decimal price = Convert.ToDecimal(textBoxPrice.Text);
                int x = e.X;
                int y = e.Y;
                Plant plant = new Plant(name, size, price, x, y);
                plants.Add(plant);
                /// *** IMPORTANT ***
                /// Use this call after any change to the list to force redraw of the picture box:
                pictureBoxGarden.Refresh();
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            // add input from textBoxes
            plantName = textBoxName.Text;
            sizePlant = int.Parse(textBoxSize.Text);
            costPlant = decimal.Parse(textBoxPrice.Text);

            // get the writer 
            StreamWriter writer;
            // create a text file to write to
            string filename = "output.txt";

            if (!File.Exists(filename))
            {
                // write to the output text file
                using (writer = File.AppendText(filename))
                {
                    // write to file using input from textboxes 
                    writer.Write(plantName.ToString().PadRight(10));
                    writer.Write(sizePlant.ToString().PadRight(5));
                    writer.Write(costPlant.ToString());
                    writer.Close();
                    MessageBox.Show("File \"" + filename + "\"");
                }
            }

            // open file to read from
            using (StreamReader sr = File.OpenText(filename))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            // and the total cost
            // Use the ToString() of the plant object to output the plant information in the correct format.
        }
    }
}
