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
                    // Clear previous error 
                    sValidationError = "";

                    // Trim input 
                    value = value.Trim();

                    // name is empty
                    if (string.IsNullOrEmpty(value))
                    {
                        sValidationError = "The name cannot be empty!";
                        ValidationErrorsOccurred = true; //  when validation fails
                    }
                    // Validate if the name is too long
                    else if (value.Length > MAX_NAME_CHARACTERS)
                    {
                        sValidationError = $"The name must be no more than {MAX_NAME_CHARACTERS} characters!";
                        ValidationErrorsOccurred = true; // when validation fails
                    }
                    else
                    {
                        // If validation passes
                        sName = value;
                        ValidationErrorsOccurred = false;
                    }
                }
                catch (Exception e)
                {
                    // Unexpected error
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
