using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExeceptionHandlingUserRegistrartion
{
    public class Pattern
    {
        public bool ValidateFirstName(string FirstName)
        {
            try
            {
                string ValidFirstName = "^[A-Z]{1}";
                if (Regex.IsMatch(FirstName, ValidFirstName))
                {
                    Console.WriteLine("valid first name");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return false;
        }
    }
}
