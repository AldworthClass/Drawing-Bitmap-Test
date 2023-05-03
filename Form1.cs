using Drawing_Bitmap_Test.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Bitmap_Test
{
    public partial class Form1 : Form
    {
        Bitmap corn, plate, cabbage; // These are all of the toppings that can be drawn
      
        // Stores the toppings that are 'on/in' the dish and need to be currently drawn
        List<Bitmap> toppings; 

        public Form1()
        {
            InitializeComponent();
            toppings = new List<Bitmap>();
            corn = new Bitmap(Resources.corn3);
            cabbage = new Bitmap(Resources.cabbage3);
            plate = new Bitmap(Resources.essential_dinner_plate, new Size(imgPlate.Width, imgPlate.Height)); // The plate is scaled to fit the picturebox
        }

        private void btnAddCorn_Click(object sender, EventArgs e)
        {
            if (toppings.Contains(corn))  // Checks to see if corn is already in the dish
                toppings.Remove(corn);// User removes corn if it is already there
            else
                toppings.Add(corn);  // User adds corn

            this.Refresh(); // Calls the Paint() method which re-draws the image on the Picturebox
        }


        // This is called when Windows Forms decides that imgPain needs to be redrawn
        private void imgPlate_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            canvas.Clear(Color.White);  // Clears the Picturebox
            canvas.DrawImage(plate, 0, 0); // Draws the plate
            foreach (Bitmap topping in toppings) // Loops through all of the toppings that have been added and draws them
            {
                canvas.DrawImage(topping, 0, 0);
            }
        }

        private void btnAddCabbage_Click(object sender, EventArgs e)
        {
            if (toppings.Contains(cabbage)) // Checks to see if cabbage is already in the dish
                toppings.Remove(cabbage);  // Removes cabbage if it is already in the dish
            else
                toppings.Add(cabbage);  // User adds cabbage
            
            this.Refresh(); // Calls the Paint() method which re-draws the image on the Picturebox
        }

        
    }
}
