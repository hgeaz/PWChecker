namespace PwChecker;

/// <summary>
/// This password checker takes in a user input and determines if the typed password is a strong password. A string password has at least one
/// special character, one or more letters, at least 1 number, and much be between 12 and 18 characters long!
/// </summary>
public class PasswordChecker
{
    private readonly String _password;
    private readonly String _specialCharacters = "!@#$%^&*()";
    
    /// <summary>
    /// Creates Password.
    /// </summary>
    /// <param name="password"></param>
    public PasswordChecker(String password)
    {
        this._password = password;
    }

    /// <summary>
    /// Returns a String explaining your if your password is too short, too long, needs a number, or needs a number.
    /// </summary>
    /// <returns></returns>
    public String GetStrength()
    {
        if (_password.Length < 12)
        {
            
            return "Password is too short.";
            
        }
        if (_password.Length > 18)
        {
            
            return "Password is too long.";
            
        }

        Boolean checker = false;
        foreach (Char value in _password)
        {

            if (_specialCharacters.Contains(value))
            {
                
                checker = true;
                
            }

        }

        if (!checker)
        {

            return "Password Needs at least one special character - !@#$%^&*()";

        }
        
        checker = false;
        foreach (Char value in _password)
        {

            if (double.TryParse(value.ToString(), out double _))
            {
                
                checker = true;
                
            }

        }

        if (!checker)
        {

            return "Password needs at least one number!";

        }

        return "Great password!";


    }


}