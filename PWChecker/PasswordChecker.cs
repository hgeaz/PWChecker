namespace PwChecker;

public class PasswordChecker
{

    private readonly String _password;
    
    private readonly String _specialCharacters = "!@#$%^&*()";
    
    public PasswordChecker(String password)
    {
        this._password = password;
    }

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