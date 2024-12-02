using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineDLL
{
    public class Character
    {
        //Constants
        const int MAX_NAME_CHARACTERS = 20;
        const int MAX_HP = 30;
        const int MAX_Strength = 7;


        // Variables
        public string sValidationError = "";
        public string sName = "";
        public bool ValidationErrorsOccurred = false; // to use in console validation
        public int currentHP = MAX_HP;
        public int Strength = 3;

        //two properties to hold X and Y
        public int X = 0;
        public int Y = 0;

        // Property for validation error message
        public string ValidationError
        {
            get
            {
                // Simply return the validation error (if any).
                return sValidationError;
            }
        }

        public string Name
        {
            get
            {
                return sName;
            }
            set
            {
                try
                {
                    // Clear previous error message
                    sValidationError = "";

                    // Trim input to remove any surrounding spaces
                    value = value.Trim();

                    // Validate if the name is empty
                    if (string.IsNullOrEmpty(value))
                    {
                        sValidationError = "The name cannot be empty!";
                        ValidationErrorsOccurred = true; // Set flag to true when validation fails
                    }
                    // Validate if the name is too long
                    else if (value.Length > MAX_NAME_CHARACTERS)
                    {
                        sValidationError = $"The name must be no more than {MAX_NAME_CHARACTERS} characters!";
                        ValidationErrorsOccurred = true; // Set flag to true when validation fails
                    }
                    else
                    {
                        // If validation passes, set the name and clear validation errors
                        sName = value;
                        ValidationErrorsOccurred = false;
                    }
                }
                catch (Exception e)
                {
                    // Unexpected error; rethrow with additional details
                    throw new Exception("An error occurred while setting the name.", e);
                }
            }
        }



        //METHODS

        //if the character is dead
        public bool IsDead()
        {
            return currentHP <= 0;
        }

        //If taking damage method
        public void TakeDamage(int damage)
        {
            currentHP -= damage;
            // Ensure HP doesn't go below zero
            if (currentHP < 0)
            {
                currentHP = 0;
            }
        }
    }
}
