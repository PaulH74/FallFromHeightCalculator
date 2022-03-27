using System;
using System.Collections.Generic;

namespace FallFromHeightCalculator
{
    class FallCalculator
    {
        private List<double> _GravityValues;

        public FallCalculator()
        {
            InitialiseGravity();
        }

        private void InitialiseGravity()
        {
            _GravityValues = new List<double>
            {
                9.81d,      // Earth
                1.62d,      // Moon
                3.711d      // Mars
            };
        }
        
        public string CalculateFallTime(double height, int gravity)
        {
            // Formula for time to fall from a set height (metres):
            // sqrt ( 2 * height / gravity )

            return Math.Round((decimal)Math.Sqrt(2 * height / _GravityValues[gravity]), 2).ToString();
        }

        public string CalculateVelocityAtImpact(double height, int gravity, bool metresPerSec)
        {
            // Formula for time to fall from a set height (metres):
            // sqrt ( 2 * g * height )

            if (metresPerSec)
            {
                return Math.Round((decimal)Math.Sqrt(2 * height * _GravityValues[gravity]), 2).ToString();      // Meters per sec
            }
            else
            {
                return Math.Round((decimal)Math.Sqrt(2 * height * _GravityValues[gravity]) * 3.6m, 2).ToString();      // Km/hr
            }
            
            
        }

        public string CalculateEnergyAtImpact(double height, int gravity, double mass)
        {
            // Formula for impact force
            // mass * gravity * height / distance travelled
            // 1/2 * mass * velocity2 = mass * g * height
            double velocity = 2 * height * _GravityValues[gravity];

            //return (0.5d * weight * velocity * velocity).ToString();

            return (mass * _GravityValues[gravity] * height).ToString();
        }

        //public string ChangeUnit(string velocity, bool metrespersec)
        //{
        //    const double CONVERSION_FACTOR = 3.6d;
            
        //    if (metrespersec)
        //    {
        //        return (double.Parse(velocity) / CONVERSION_FACTOR).ToString();
        //    }
        //    else
        //    {
        //        return (double.Parse(velocity) * CONVERSION_FACTOR).ToString();
        //    }
        //}
    }
}
