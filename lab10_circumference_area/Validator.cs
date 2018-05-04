using System;
namespace lab10_circumference_area
{
    public static class Validator
    {
        public static bool NumberChecker(string input)
        {
            if (!int.TryParse(input, out int userradius))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}