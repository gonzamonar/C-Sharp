using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    internal static class Validation
    {
        internal static class Input
        {
        //Cmb Input
            public static bool IsCmbSelected(ComboBox cmb)
            {
                return IsCmbSelected(cmb, -1);
            }

            public static bool IsCmbSelected(ComboBox cmb, bool hasEmptyOption)
            {
                return (hasEmptyOption) ? IsCmbSelected(cmb, -1) && IsCmbSelected(cmb, 0) : IsCmbSelected(cmb, -1);
            }

            private static bool IsCmbSelected(ComboBox cmb, int index)
            {
                return (cmb.SelectedIndex != index);
            }

            //Dgv Input
            public static bool IsDgvRowSelected(DataGridView dgv)
            {
                return (dgv.SelectedRows.Count >= 1);
            }

        //Rdo Input
            public static bool IsRdoSelected(RadioButton rdo1, RadioButton rdo2, RadioButton rdo3)
            {
                return (rdo1.Checked || rdo2.Checked || rdo3.Checked);
            }

        //Txt Input
            public static bool IsNotEmptyNullOrWhiteSpace(string str)
            {
                return !(string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str));
            }

            public static bool IsWithinLengthRange(string str, int minLength, int maxLength)
            {
                return (str.Length >= minLength && str.Length <= maxLength);
            }

            public static bool IsAlphabetical(string str)
            {
                bool isValid = true;

                if(str is not null)
                {
                    foreach (char c in str)
                    {
                        if (!Char.IsLetter(c))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                return isValid;
            }

            public static bool IsAlphabeticalOrWhiteSpace(string str)
            {
                bool isValid = true;

                if (str is not null)
                {
                    foreach (char c in str)
                    {
                        if (!Char.IsLetter(c) && !Char.IsWhiteSpace(c))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                return isValid;
            }

            public static bool IsNumerical(string str)
            {
                bool isValid = true;

                if (str is not null)
                {
                    foreach (char c in str)
                    {
                        if (!Char.IsDigit(c))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                return isValid;
            }

            public static bool IsAlphanumerical(string str)
            {
                bool isValid = true;

                if(str is not null)
                {
                    foreach (char c in str)
                    {
                        if (!Char.IsLetterOrDigit(c))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }

                return isValid;
            }

            public static bool IsAPassword(string password, int minLength, int maxLength)
            {
                return (IsNotEmptyNullOrWhiteSpace(password) && IsWithinLengthRange(password, minLength, maxLength) && IsAlphanumerical(password));
            }

            public static bool IsAProperName(string properName)
            {
                return (IsNotEmptyNullOrWhiteSpace(properName) && IsWithinLengthRange(properName, 2, 40) && IsAlphabeticalOrWhiteSpace(properName));
            }

            public static bool IsInMinRange(int num, int min)
            {
                return (num >= min);
            }
            public static bool IsInMinRange(double num, double min)
            {
                return (num >= min);
            }

            public static bool IsInMaxRange(int num, int max)
            {
                return (num <= max);
            }
            public static bool IsInMaxRange(double num, double max)
            {
                return (num <= max);
            }

            public static bool IsBetweenRange(string num, int min, int max)
            {
                int input;
                bool isValid = IsANumber(num, out input) && IsBetweenRange(input, min, max);
                return isValid;
            }
            public static bool IsBetweenRange(int num, int min, int max)
            {
                return (num >= min && num <= max);
            }
            public static bool IsBetweenRange(double num, double min, double max)
            {
                return (num >= min && num <= max);
            }

            public static bool IsANumber(string num)
            {
                return int.TryParse(num, out int input);
            }
            public static bool IsANumber(string num, out double input)
            {
                return double.TryParse(num, out input);
            }
            public static bool IsANumber(string num, out int input)
            {
                return int.TryParse(num, out input);
            }

        }
    }
}
