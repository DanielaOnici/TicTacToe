/* DOniciAssignment1.sln
 * 
 * PROG2370 - 22F - Sec1 - Assignment1
 * 
 * Created by Daniela Onici Student ID# 8754297
 * 
 *      Revision History
 *      Created: 2022-09-22
 *      Finished: 2022-09-22
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOniciAssignment1
{

    public partial class TicTacToe : Form
    {
        // Creating the variables for each image
        Image x = DOniciAssignment1.Properties.Resources.x;
        Image o = DOniciAssignment1.Properties.Resources.o;

        /// <summary>
        /// Default constructor of the TicTacToe class
        /// </summary>
        public TicTacToe()
        {
            InitializeComponent();
        }

        // Creating a variable to count the number of null picturebox clicks
        private int timesClicked = 0;

        /// <summary>
        /// Defines the initial mode of the game with null pictureboxes and timesClicked backs to zero
        /// </summary>
        private void init()
        {
            timesClicked = 0;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
        }

        /// <summary>
        /// Defines the image according to the number of null picturebox clicks
        /// </summary>
        /// <param name="timesClicked">number of clicks</param>
        /// <returns>image X if the number of clicks is odd or O if the number of clicks is even</returns>
        private Image DefinesTheImage(int timesClicked)
        {
            if((timesClicked % 2) == 1)
            {
                return x;
            }
            else
            {
                return o;
            }
        }

        /// <summary>
        /// If null, shows a X or O (according to the number of null picturebox clicks) and the winner or the draw (if one of the combinations are met)
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == null)
            {
                timesClicked += 1;
                pictureBox1.Image = DefinesTheImage(timesClicked);
                winner();
            }
        }

        /// <summary>
        /// If null, shows a X or O (according to the number of null picturebox clicks) and the winner or the draw (if one of the combinations are met)
        /// </summary>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Image == null)
            {
                timesClicked += 1;
                pictureBox2.Image = DefinesTheImage(timesClicked);
                winner();
            }
        }

        /// <summary>
        /// If null, shows a X or O (according to the number of null picturebox clicks) and the winner or the draw (if one of the combinations are met)
        /// </summary>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if( pictureBox3.Image == null)
            {
                timesClicked += 1;
                pictureBox3.Image = DefinesTheImage(timesClicked);
                winner();
            }
        }

        /// <summary>
        /// If null, shows a X or O (according to the number of null picturebox clicks) and the winner or the draw (if one of the combinations are met)
        /// </summary>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(pictureBox4.Image == null)
            {
                timesClicked += 1;
                pictureBox4.Image = DefinesTheImage(timesClicked);
                winner();
            }
        }

        /// <summary>
        /// If null, shows a X or O (according to the number of null picturebox clicks) and the winner or the draw (if one of the combinations are met)
        /// </summary>
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if(pictureBox6.Image == null)
            {
                timesClicked += 1;
                pictureBox6.Image = DefinesTheImage(timesClicked);
                winner();
            }
        }

        /// <summary>
        /// If null, shows a X or O (according to the number of null picturebox clicks) and the winner or the draw (if one of the combinations are met)
        /// </summary>
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if(pictureBox8.Image == null)
            {
                timesClicked += 1;
                pictureBox8.Image = DefinesTheImage(timesClicked);
                winner();
            }
        }

        /// <summary>
        /// If null, shows a X or O (according to the number of null picturebox clicks) and the winner or the draw (if one of the combinations are met)
        /// </summary>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(pictureBox5.Image == null)
            {
                timesClicked += 1;
                pictureBox5.Image = DefinesTheImage(timesClicked);
                winner();
            }
        }

        /// <summary>
        /// If null, shows a X or O (according to the number of null picturebox clicks) and the winner or the draw (if one of the combinations are met)
        /// </summary>
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if(pictureBox7.Image == null)
            {
                timesClicked += 1;
                pictureBox7.Image = DefinesTheImage(timesClicked);
                winner();
            }
        }

        /// <summary>
        /// If null, shows a X or O (according to the number of null picturebox clicks) and the winner or the draw (if one of the combinations are met)
        /// </summary>
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if(pictureBox9.Image == null)
            {
                timesClicked += 1;
                pictureBox9.Image = DefinesTheImage(timesClicked);
                winner();
            }
        }

        /// <summary>
        /// Verifies all the possibilities of winning the game and informs the user who is the winner. If no combination of three X or O, it is a DRAW
        /// After a winning or a draw, the game is automatically set to initial mode through the init() method
        /// </summary>
        private void winner()
        {
            // Combination of three X in a horizontal and vertical ways
            if (pictureBox1.Image == x && pictureBox2.Image == x && pictureBox3.Image == x || pictureBox4.Image == x && pictureBox6.Image == x && pictureBox8.Image == x || pictureBox5.Image == x && pictureBox7.Image == x && pictureBox9.Image == x || pictureBox1.Image == x && pictureBox4.Image == x && pictureBox5.Image == x || pictureBox2.Image == x && pictureBox6.Image == x && pictureBox7.Image == x || pictureBox3.Image == x && pictureBox8.Image == x && pictureBox9.Image == x)
            {
                MessageBox.Show("X is the winner!");
                init();
            }
            // Combination of three O in a horizontal and vertical ways
            if (pictureBox1.Image == o && pictureBox2.Image == o && pictureBox3.Image == o || pictureBox4.Image == o && pictureBox6.Image == o && pictureBox8.Image == o || pictureBox5.Image == o && pictureBox7.Image == o && pictureBox9.Image == o || pictureBox1.Image == o && pictureBox4.Image == o && pictureBox5.Image == o || pictureBox2.Image == o && pictureBox6.Image == o && pictureBox7.Image == o || pictureBox3.Image == o && pictureBox8.Image == o && pictureBox9.Image == o)
            {
                MessageBox.Show("O is the winner!");
                init();
            }
            // Combination of three X in a diagonal way
            if (pictureBox1.Image == x && pictureBox6.Image == x && pictureBox9.Image == x || pictureBox3.Image == x && pictureBox6.Image == x && pictureBox5.Image == x)
            {
                MessageBox.Show("X is the winner!");
                init();
            }
            // Combination of three O in a diagonal way
            if (pictureBox1.Image == o && pictureBox6.Image == o && pictureBox9.Image == o || pictureBox3.Image == o && pictureBox6.Image == o && pictureBox5.Image == o)
            {
                MessageBox.Show("O is the winner!");
                init();
            }
            // No combination is equal to DRAW
            if(!(pictureBox1.Image == null) && !(pictureBox2.Image == null) && !(pictureBox3.Image == null) && !(pictureBox4.Image == null) && !(pictureBox5.Image == null) && !(pictureBox6.Image == null) && !(pictureBox7.Image == null) && !(pictureBox8.Image == null) && !(pictureBox9.Image == null))
            {
                MessageBox.Show("DRAW!");
                init();
            }
        }

    }
}
