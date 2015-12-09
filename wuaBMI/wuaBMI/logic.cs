using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMORRIS4Lab2BMI
{
    public class logic
    {
        public double bmi = 0;
        public string metric(double h, double weight)
            {  
            double height = h / 100;
            bmi = weight /(height * height);
            //return resultBuild(bmi) + " " + height + " " + weight;//debug
            return resultBuild(bmi);

        }
        public string imperial(double height, double weight)
        {
            bmi = (weight / (height * height)) * 703;
            //return resultBuild(bmi) + " " + height + " " + weight; //debug
            return resultBuild(bmi);
        }
        private String resultBuild(double bmi)
        {
            String msg = "";
            double chk3 = 18.5;

            if (bmi < 15)
                    msg = "Very severely underweight";
                else if (bmi < 16)
                    msg = "Severely underweight";
                else if (bmi < chk3)
                    msg = "Underweight";
                else if (bmi < 25)
                    msg = "Normal (healthy weight)";
                else if (bmi < 30)
                    msg = "Overweight";
                else if (bmi < 35)
                    msg = "Obese Class I (Moderately obese)";
                else if (bmi < 40)
                    msg = "Obese Class II (Severely obese)";
                else
                    msg = "Obese Class III (Very severely obese)";
            double bmir = Math.Round(bmi, 2);
            String result = msg + " ( " + bmir + " BMI)";
            return result;
        }
    }
}

/*

                    double height = Convert.ToInt32(lblHeight.Text);
                double weight = Convert.ToInt32(lblWeight.Text);
                double bmi = 0;
                string msg = "";
                if (type == "KG")
                {
                    height = height / 100;
                    bmi = weight /(height * height);
                }
                else
                {
                    bmi = (weight / (height * height)) * 703;
                }

                //double comparison for decimal number
                double chk3 = 18.5;

                if (bmi < 15)
                    msg = "Very severely underweight";
                else if (bmi < 16)
                    msg = "Severely underweight";
                else if (bmi < chk3)
                    msg = "Underweight";
                else if (bmi < 25)
                    msg = "Normal (healthy weight)";
                else if (bmi < 30)
                    msg = "Overweight";
                else if (bmi < 35)
                    msg = "Obese Class I (Moderately obese)";
                else if (bmi < 40)
                    msg = "Obese Class II (Severely obese)";
                else
                    msg = "Obese Class III (Very severely obese)";

                txtResultString.Text = Convert.ToString(msg);
                txtResultNumber.Text = Convert.ToString(Math.Round(bmi, 2));

*/
