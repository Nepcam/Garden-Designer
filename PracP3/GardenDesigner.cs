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
        /// You need to change this method, so that it checks whether there 
        /// already is a plant at the position of this event
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
            //MessageBox.Show(plants[0].Name);
            // set variables + total cost var
            // make file get the writer 
            StreamWriter writer;
            // create a text file to write to
            string filename = "output.txt";
            // for every plant in List<Plant> plants
            for (int i = 0; i <= plants.Count; i++)
            {
                if (!File.Exists(filename))
                {
                    // write to the text file
                    using (writer = File.AppendText(filename))
                    {
                        // write to file from user textbox input
                        writer.Write(plants[i].Name.PadRight(10));
                        writer.Write(plants[i].Size.ToString().PadRight(10));
                        writer.Write(plants[i].Price.ToString());
                        writer.Close();
                        MessageBox.Show("File \"" + filename + "\"");
                    }
                }
            }
     
            //{
            //    
            //    if (!File.Exists(filename))
            //    {
            //        // write to the output text file
            //        using (writer = File.AppendText(filename))
            //        {
            //            // write to file using input from textboxes 
            //            writer.Write(plant.Name.ToString().PadRight(15));
            //            writer.Write(plant.Size.ToString().PadRight(10));
            //            writer.Write(plant.Price.ToString());
            //            
            //            
            //        }
            //        //plants.Add(plant);
            //    }
            //}           
            // print total cost
            // close file

            // open textfile to read from
            using (StreamReader sr = File.OpenText(filename))
            {
                string text = File.ReadAllText("output.txt");
                while ((text = sr.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                }
            }

            // and the total cost
            // Use the ToString() of the plant object to output the plant information in the correct format.
        }
    }
}
