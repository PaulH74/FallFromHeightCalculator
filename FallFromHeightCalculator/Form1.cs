using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FallFromHeightCalculator
{
    public partial class Form1 : Form
    {
        private FallCalculator _FallCalculator;
        private List<RadioButton> _GravityRadioButtons;

        public Form1()
        {
            InitializeComponent();
            InitialiseGravityRadioButtons();
            _FallCalculator = new FallCalculator();
        }

        private void InitialiseGravityRadioButtons()
        {
            // Instantiate Arrays
            _GravityRadioButtons = new List<RadioButton>
            {
                // Assign Values
                radioButtonEarth,
                radioButtonMoon,
                radioButtonMars
            };
        }




        private int GetGravityChoice()
        {
            int index = 0;
            
            for (int i = 0; i < _GravityRadioButtons.Count; i++)
            {
                if (_GravityRadioButtons[i].Checked)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private bool VerifyValidInput(string input)
        {
            bool isVerified = false;
            double number = 0d;

            // Check if input is empty
            if (!string.IsNullOrEmpty(input))
            {
                // Check input is a valid number
                if (double.TryParse(input, out number))
                {
                    if (number >= 0d)
                    {
                        isVerified = true;
                    }
                }
            }

            return isVerified;
        }

        /// <summary>
        /// Performs the calculations to determine the fall time, velocity at impact, and energy at impact
        /// </summary>
        /// <param name="gravity"></param>
        private void RunCalculation(int gravity)
        {
            if (VerifyValidInput(textBoxInputHeight.Text) && VerifyValidInput(textBoxWeight.Text))
            {
                double height = double.Parse(textBoxInputHeight.Text);
                double mass = double.Parse(textBoxWeight.Text);

                textBoxOutputFallTime.Text = _FallCalculator.CalculateFallTime(height, gravity);
                textBoxImpactForce.Text = _FallCalculator.CalculateEnergyAtImpact(height, gravity, mass);

                // Calculate Impact Velocity
                if (radioButtonMPS.Checked)
                {
                    textBoxImpactVelocity.Text = _FallCalculator.CalculateVelocityAtImpact(height, gravity, true);
                }
                else
                {
                    textBoxImpactVelocity.Text = _FallCalculator.CalculateVelocityAtImpact(height, gravity, false);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid, positive height (in metres)", "INPUT ERROR");
            }
        }

        #region Form Events
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            RunCalculation(GetGravityChoice());
        }

        private void OnGravityRadioButtonChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            // Re-run Calculation if Radio Button has changed, applying new gravity value
            if (rb.Checked)
            {
                RunCalculation(GetGravityChoice());
            }
        }

        private void OnUnitsRadioButtonChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            // TO DO: Need to calculate Impact Velocity according to which radio button is selected.

            if (rb.Checked)
            {
                RunCalculation(GetGravityChoice());
            }
        }
        #endregion

        
    }
}
