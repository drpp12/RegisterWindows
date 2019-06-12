using Microsoft.Win32;

public class RegistryWindowsGetAdd
{
    ///Declare Var 
    const string userRoot = "HKEY_CURRENT_USER";
    const string subkey = "KeyNameXX";
        const string keyName = userRoot + "\\" + subkey;

    //Get Value
    private string GetKeys()
    {
        string Key = "";
        string KeyNameXX = (string)Registry.GetValue(keyName, "KeyNameXX", "null");
        if (KeyNameXX != null)
        {
            Key = KeyNameXX;
        }
        return Key;
    }

    //Add or Edit Value
    private void SetRegister(string TD)
    {
        string KeyNameXX = (string)Registry.GetValue(keyName, "KeyNameXX", "null");
        if (KeyNameXX == null)
        {
            Registry.SetValue(keyName, "KeyNameXX", TD);
        }
    }

}
