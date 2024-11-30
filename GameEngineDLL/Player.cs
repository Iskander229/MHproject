// Iskander Taniyev     11/30/2024 2:24 validation completed

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineDLL
{
    public class Player
    {
        // Constants
        const int MAX_NAME_CHARACTERS = 25;
        const int SQUARE_SIZE = 50;

        // Variables
        private string sValidationError = "";
        private string sName = "";
        private bool validationErrorsOccurred = false; // to use in console validation

        public int X = 0;
        public int Y = 0;

        // Property for validation error message
        public string ValidationError
        {
            get
            {
                try
                {
                    return sValidationError;
                }
                catch (Exception e)
                {
                    throw new Exception("An error occurred in DLL (ValidationError)", e);
                }
            }
        }

        // Property for validation status
        public bool ValidationErrorsOccurred
        {
            get { return validationErrorsOccurred; }
        }

        // Name property with validation
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
                    // Clear previous error messages
                    sValidationError = "";
                    validationErrorsOccurred = false; // Reset validation 

                    // Trim spaces
                    value = value.Trim();

                    if (string.IsNullOrEmpty(value))
                    {
                        validationErrorsOccurred = true;
                        sValidationError = "The name cannot be empty!";
                    }
                    else if (value.Length > MAX_NAME_CHARACTERS)
                    {
                        validationErrorsOccurred = true;
                        sValidationError = "The name must be no more than " + MAX_NAME_CHARACTERS + " characters!";
                    }

                    // Only set sName if validation passes
                    if (!validationErrorsOccurred)
                    {
                        sName = value;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("An error occurred in DLL (Name)", e);
                }
            }
        }
    }
}
