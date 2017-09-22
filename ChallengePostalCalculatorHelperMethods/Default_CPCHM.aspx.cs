using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default_CPCHM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                inputHeightBox.Text = string.Empty;
                inputLengthBox.Text = string.Empty;
                inputWidthBox.Text = string.Empty;
            }
        }
        
        protected void InputWidthBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void InputHeightBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void InputLengthBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        protected void RadioBtnGround_CheckedChanged(object sender, EventArgs e)
        {
            CalculateVolume();
            CalculatePost(.15);
        }

        protected void RadioBtnAir_CheckedChanged(object sender, EventArgs e)
        {
            CalculateVolume();
            CalculatePost(.25);
        }

        protected void RadioBtnOvernight_CheckedChanged(object sender, EventArgs e)
        {
            CalculateVolume();
            CalculatePost(.45);
            //shipmentTotalOutput.Text = CalculatePost();
        }

        //=================================================
        //  Method to calculate volume  - CalculateVolume()
        //=================================================

        public double CalculateVolume()
        {
            double totalVolume;

            if (inputLengthBox.Text.Trim().Length == 0)
            {
                totalVolume = double.Parse(inputWidthBox.Text);
                totalVolume = totalVolume * (double.Parse(inputHeightBox.Text));
                
                //shipmentTotalOutput.Text = totalVolume.ToString();
                return totalVolume;
            }
            else
            //else if (!String.IsNullOrEmpty(inputLengthBox.Text))
            {
                totalVolume = double.Parse(inputWidthBox.Text);
                totalVolume = totalVolume * (double.Parse(inputHeightBox.Text));
                totalVolume = totalVolume * (double.Parse(inputLengthBox.Text));
                
                shipmentTotalOutput.Text = totalVolume.ToString();
                return totalVolume;
            }
            //return NewMethod(totalVolume);
            //object totalvolume = null;

            //return CalculatePost(totalVolume);

        }

        //=================================================
        // Method to calculate postage - CalculatePost();
        //=================================================
        
        /*public double CalculatePost(Action calculateVolume, double multiplier)
        {
            if (calculateVolume == null)
            {
                throw new ArgumentNullException(nameof(calculateVolume));
            }
            */
        public double CalculatePost(double multiplier)
        {
            double totalPostage;
            double totalVolume = CalculateVolume(); //variable = output from method

            if (radioBtnGround.Checked)
            {
                totalPostage = totalVolume * multiplier;
                shipmentTotalOutput.Text = string.Format("Your Parcel will cost {0:C} to ship.", totalPostage);
                //shipmentTotalOutput.Text = totalPostage.ToString();
                return totalPostage;
            }

            else if (radioBtnAir.Checked)
            {
                totalPostage = totalVolume * multiplier;
                shipmentTotalOutput.Text = string.Format("Your Parcel will cost {0:C} to ship.", totalPostage);
                //shipmentTotalOutput.Text = string.Format("{0:C}", totalPostage);
                return totalPostage;
            }

            else if (radioBtnOvernight.Checked)
            {
                totalPostage = totalVolume * multiplier;
                shipmentTotalOutput.Text = string.Format("Your Parcel will cost {0:C} to ship.", totalPostage);
                return totalPostage;
            }
            else
                return 0;
        }
        

        /*
        public double CalculatePost()//double totalPostage, double totalVolume)
        {

            if (radioBtnGround.Checked)
            {
                totalPostage = totalVolume * .15;
                return totalPostage;
            }

            else if (radioBtnAir.Checked)
            {
                totalPostage = totalVolume * .25;
                return totalPostage;
            }

            else if (radioBtnOvernight.Checked)
            {
                totalPostage = totalVolume * .45;
            }
            else
                return totalPostage;

            shipmentTotalOutput.Text = totalPostage.ToString();
        }
        */

        /*

        double totalPostage = totalVolume * multiplier;
        
        protected void RadioBtnGround_CheckedChanged(object sender, EventArgs e)
        CalculatePost(.25);
        
        protected void RadioBtnAir_CheckedChanged(object sender, EventArgs e)
        CalculatePost(.35);
        
        protected void RadioBtnOvernight_CheckedChanged(object sender, EventArgs e)
        CalculatePost(.40);
        */

        /*
        if (radioBtnGround.Checked) return .15;
        else if (radioBtnAir.Checked) return .25;
        else if (radioBtnOvernight.Checked) return .45;
        else return 0;






        //shipmentTotalOutput.Text = totalVolume.ToString();


        //shipmentTotalOutput.Text = "Your Parcel will cost " + totalPostage.ToString() + " to ship";

        //Your parcel will cost $xx to ship.



        */

    }


}

