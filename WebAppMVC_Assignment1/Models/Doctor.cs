using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC_Assignment1.Models
{
    public class Doctor
    {
        private double bodyTemp;
        
        public double BodyTemp { get; set; }

        public static string giveRecomendation(double patientTemp) 
        {
            string msg;

            if (patientTemp <= 80 || patientTemp >= 110)
            {
                msg = "Cannot provide any Recommendation. Please enter a valid temperature";
            }
            
            if (patientTemp > 98 && patientTemp < 110)
            {
                msg = "Recorded body temperature is "+ patientTemp+". You seem to have a fever. Consult a real Doctor!";
            }
            else 
            {
                msg = "Recorded body temperature is " + patientTemp + ". You do not have a fever";
            }

            return msg;
        }
    }
}
