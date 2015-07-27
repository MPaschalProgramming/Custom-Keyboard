///Paschal, Michael A.
///24 Sept 2014
///Project 02


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project02
{
    public partial class frmProject02 : Form
    {
        public frmProject02()
        {
            InitializeComponent();
        }
      

        
        private void btnA_Click(object sender, EventArgs e)
        {

            //Declare output variable
            string output;
            //Concatenate the input and build the output string.
            if (lblOutput.Text == "")
            {
                output = btnA.Text;
            }
            else
            {
                output = lblOutput.Text + btnA.Text;
            }
            //output = lblOutput.Text + btnA.Text;
            //output = btnA.Text + " ";

            //Display the output string in a Label control.
            lblOutput.Text = output;

        }
        
        private void btn_a_Click(object sender, EventArgs e)
        {
            //Declare output variable
            string output;

            //Concatenate the input and build the output string.
            if (lblOutput.Text == "")
            {
                output = btn_a.Text;
            }
            else
            {
                output = lblOutput.Text + btn_a.Text;
            }
               
            //concatenate the input and build the output string.
            //output = lblOutput.Text + btn_a.Text;
            //output = btn_a.Text + " ";

            //Display output string in a Label control.
            lblOutput.Text = output;
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;
             
            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnAn.Text;
            }
            else
            {
                output = lblOutput.Text + btnAn.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
               


        }

        private void btn_an_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btn_an.Text;
            }
            else
            {
                output = lblOutput.Text + btn_an.Text;
            }
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnThe.Text;
            }
            else
            {
                output = lblOutput.Text + btnThe.Text;
            }
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btn_the_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btn_the.Text;
            }
            else
            {
                output = lblOutput.Text + btn_the.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnMan.Text;
            }
            else
            {
                output = lblOutput.Text + btnMan.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnWoman_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnWoman.Text;
            }
            else
            {
                output = lblOutput.Text + btnWoman.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnDog.Text;
            }
            else
            {
                output = lblOutput.Text + btnDog.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnCat.Text;
            }
            else
            {
                output = lblOutput.Text + btnCat.Text;
            }
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnCar.Text;
            }
            else
            {
                output = lblOutput.Text + btnCar.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnBicycle.Text;
            }
            else
            {
                output = lblOutput.Text + btnBicycle.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnBeautiful_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnBeautiful.Text;
            }
            else
            {
                output = lblOutput.Text + btnBeautiful.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnBig.Text;
            }
            else
            {
                output = lblOutput.Text + btnBig.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnSmall.Text;
            }
            else
            {
                output = lblOutput.Text + btnSmall.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnStrange_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnStrange.Text;
            }
            else
            {
                output = lblOutput.Text + btnStrange.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnLooked_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnLooked.Text;
            }
            else
            {
                output = lblOutput.Text + btnLooked.Text;
            }
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnRode_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnRode.Text;
            }
            else
            {
                output = lblOutput.Text + btnRode.Text;
            }
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnSpoke_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnSpoke.Text;
            }
            else
            {
                output = lblOutput.Text + btnSpoke.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnLaughed_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnLaughed.Text;
            }
            else
            {
                output = lblOutput.Text + btnLaughed.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnDrove_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            if (lblOutput.Text == "")
            {
                output = btnDrove.Text;
            }
            else
            {
                output = lblOutput.Text + btnDrove.Text;
            }
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            {
                output = lblOutput.Text + " ";
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            {
                output = lblOutput.Text + btnPeriod.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnExclimation_Click(object sender, EventArgs e)
        {
            //Declare a variable
            string output;

            //Concatinate the input and displpay the output.
            {
                output = lblOutput.Text + btnExclimation.Text;
            }
            
            //Display the output string in a label control.
            lblOutput.Text = output;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the label control
            lblOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit the form
            this.Close();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            //Determine if string has no more characters in lblOutput.Text.
            if (string.IsNullOrEmpty(lblOutput.Text))
            {
                //Display message box explaining that they can no long backspace as there are no more 
                //characters.
                MessageBox.Show("There are no more characters to backspace.");
            }
            else
            
            {
                //Declare a variable
                string btnText = lblOutput.Text;
                
                //Declare an interger variable 'x' to equal the number of characters in the string 
                //lblOutput.Text.
                int x = btnText.Length;
                
                //Use the substring method to subtract 1 character from the interger x.
                btnText = btnText.Substring(0, (x - 1));
                
                //Display the output
                lblOutput.Text = btnText;
            }
            
           
           


        }
    }
}
