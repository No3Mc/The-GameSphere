using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gameshop1
{
    public partial class AddG : Form
    {

		private Game game;

		public AddG()
		{
			InitializeComponent();
			//the constructor
			//
			//the key idea here is to pass an animal object 
			//to the constructor. This is a reference, even though you see passed
			//by value as all objects are accessed by reference - what this means
			//is that a copy of the reference is made - it will still refer to the
			//same object as the one created in the MainForm class
			//
			//because we are looking at the same object. and changed we make here
			//will be visible to the mainForm. this avoids having to use a public
			//variable

			//we also need to pass the classificationList to this form, so the user can choose
			//what type of animal this is.

			//store the  reference to the animal
			//this.game = game;


			//btnOK.Enabled = false;

		}


        private void btnOK_Click(object sender, EventArgs e)
        {
            game.Consol = textBox1.Text.ToLower();
        }

        private void AddG_Load(object sender, EventArgs e)
        {

        }
    }
}
