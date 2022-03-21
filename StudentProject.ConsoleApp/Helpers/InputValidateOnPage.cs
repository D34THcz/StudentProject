using EasyConsole;
using System;

namespace StudentProject.ConsoleApp.Helpers
{
    class InputValidateOnPage : Page
    {
        public InputValidateOnPage(string title, Program program) : base(title, program)
        {
        }

        public string ValidateStringInput(string input, bool required = false, int minLenght = 0, int? maxLenght = null)
        {
            var validName = false;
            var inputString = "";
            while (!validName)
            {

                inputString = Console.ReadLine();

                if (required && string.IsNullOrWhiteSpace(inputString))
                {
                    Input.ReadString($"Invalid {input}! (can't use empty {input})\nPress ENTER to navigate back");
                    Program.NavigateBack();
                }
                else if (inputString.Length < minLenght || inputString.Length > maxLenght)
                {
                    if (maxLenght == null)
                    {
                        Input.ReadString($"Invalid {input}! ({input} must have minimal lenght of {minLenght}!)\nPress ENTER to navigate back");
                    }
                    else
                    {
                        Input.ReadString($"Invalid {input}! ({input} must have length between {minLenght} and {maxLenght}!)\nPress ENTER to navigate back");
                    }
                    Program.NavigateBack();
                }
                else
                {
                    validName = true;
                }
            }
            return inputString;
        }

        public int ValidatePostcode(int length)
        {
            var validPostcode = false;
            var finalPostcode = 0;
            
            while (!validPostcode)
            {
                var inputPostcode = Console.ReadLine();

                if (!Int32.TryParse(inputPostcode, out finalPostcode))
                {
                    Input.ReadString("Invalid postcode! (bad format, use only integers)\nPress ENTER to navigate back");
                    Program.NavigateBack();
                }
                else if (Math.Floor(Math.Log10(finalPostcode) + 1) != length)
                {
                    Input.ReadString($"Invalid postcode! (postcode must have lenght of {length}!)\nPress ENTER to navigate back");
                    Program.NavigateBack();
                }
                else
                {
                    validPostcode = true;
                }
            }
            return finalPostcode;
        }

        public int ValidateIntInput(int min = 0)
        {
            var validInteger = false;
            var finalInteger = 0;

            while (!validInteger)
            {
                var inputInteger = Console.ReadLine();

                if (!Int32.TryParse(inputInteger, out finalInteger))
                {
                    Input.ReadString($"Input is not integer!\nPress ENTER to navigate back");
                    Program.NavigateBack();
                }
                else if (finalInteger < min)
                {
                    Input.ReadString($"Integer can not be lower then {min}!\nPress ENTER to navigate back");
                    Program.NavigateBack();
                }
                else
                {
                    validInteger = true;
                }
            }
            return finalInteger;
        }
    }
}
