// Iskander Taniyev     11/30/2024 2:24 validation completed

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineDLL
{
    public class Hunter : Character
    {
        public bool HasSword { get; private set; }

        private Sword _currentSword; 

        public Hunter()
        {
            Strength = 0; 
            HasSword = false;
        }

        public void FindSword()
        {
            if (!HasSword)
            {
                _currentSword = new Sword();

                Strength += _currentSword.Strength; // add strength with sword
                HasSword = true;
            }
        }

        public void EncounterMonster()
        {
            if (HasSword && _currentSword != null)
            {
                if (_currentSword.Use())
                {
                    HasSword = false;

                    Strength -= _currentSword.Strength; // Decrease Strength
                    _currentSword = null; // Remove sword
                }
            }
        }
    }
}
