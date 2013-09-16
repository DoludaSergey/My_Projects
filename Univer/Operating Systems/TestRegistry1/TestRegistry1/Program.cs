using System;
using Microsoft.Win32;
using System.Security.Permissions;

class Reg
{
    public static void Main()
    {

        //// Create a RegistryKey, which will access the HKEY_USERS
        //// key in the registry of this machine.
        //RegistryKey rk = Registry.Users;          //1 вариант ))

        //// Print out the keys.
        //PrintKeys(rk);



        //// The name of the key must include a valid root.  //2 вариант
        //const string userRoot = "HKEY_CURRENT_USER";
        //const string subkey = "RegistrySetValueExample";
        //const string keyName = userRoot + "\\" + subkey;

        //// An int value can be stored without specifying the
        //// registry data type, but long values will be stored
        //// as strings unless you specify the type. Note that
        //// the int is stored in the default name/value
        //// pair.
        //Registry.SetValue(keyName, "", 5280);
        //Registry.SetValue(keyName, "TestLong", 12345678901234,
        //    RegistryValueKind.QWord);

        //// Strings with expandable environment variables are
        //// stored as ordinary strings unless you specify the
        //// data type.
        //Registry.SetValue(keyName, "TestExpand", "My path: %path%");
        //Registry.SetValue(keyName, "TestExpand2", "My path: %path%",
        //    RegistryValueKind.ExpandString);

        //// Arrays of strings are stored automatically as 
        //// MultiString. Similarly, arrays of Byte are stored
        //// automatically as Binary.
        //string[] strings = { "One", "Two", "Three" };
        //Registry.SetValue(keyName, "TestArray", strings);

        //// Your default value is returned if the name/value pair
        //// does not exist.
        //string noSuch = (string)Registry.GetValue(keyName,
        //    "NoSuchName",
        //    "Return this default if NoSuchName does not exist.");
        //Console.WriteLine("\r\nNoSuchName: {0}", noSuch);

        //// Retrieve the int and long values, specifying 
        //// numeric default values in case the name/value pairs
        //// do not exist. The int value is retrieved from the
        //// default (nameless) name/value pair for the key.
        //int tInteger = (int)Registry.GetValue(keyName, "", -1);
        //Console.WriteLine("(Default): {0}", tInteger);
        //long tLong = (long)Registry.GetValue(keyName, "TestLong",
        //    long.MinValue);
        //Console.WriteLine("TestLong: {0}", tLong);

        //// When retrieving a MultiString value, you can specify
        //// an array for the default return value. 
        //string[] tArray = (string[])Registry.GetValue(keyName,
        //    "TestArray",
        //    new string[] { "Default if TestArray does not exist." });
        //for (int i = 0; i < tArray.Length; i++)
        //{
        //    Console.WriteLine("TestArray({0}): {1}", i, tArray[i]);
        //}

        //// A string with embedded environment variables is not
        //// expanded if it was stored as an ordinary string.
        //string tExpand = (string)Registry.GetValue(keyName,
        //     "TestExpand",
        //     "Default if TestExpand does not exist.");
        //Console.WriteLine("TestExpand: {0}", tExpand);

        //// A string stored as ExpandString is expanded.
        //string tExpand2 = (string)Registry.GetValue(keyName,
        //    "TestExpand2",
        //    "Default if TestExpand2 does not exist.");
        //Console.WriteLine("TestExpand2: {0}...",
        //    tExpand2.Substring(0, 40));

        //Console.WriteLine("\r\nUse the registry editor to examine the key.");
        //Console.WriteLine("Press the Enter key to delete the key.");
        //Console.ReadLine();
        //Registry.CurrentUser.DeleteSubKey(subkey);
        //
        // This code example produces output similar to the following:
        //
        //NoSuchName: Return this default if NoSuchName does not exist.
        //(Default): 5280
        //TestLong: 12345678901234
        //TestArray(0): One
        //TestArray(1): Two
        //TestArray(2): Three
        //TestExpand: My path: %path%
        //TestExpand2: My path: D:\Program Files\Microsoft.NET\...
        //
        //Use the registry editor to examine the key.
        //Press the Enter key to delete the key.



        //RegistryKey saveKey = Registry.CurrentUser.CreateSubKey("software\\Microsoft\\Internet Explorer\\Main");
        //saveKey.SetValue("Start Page","http://www.google.com/");
        //saveKey.Close();

        RegistryKey test9999 = Registry.CurrentUser;
        using (RegistryKey
            testSettings = test9999.OpenSubKey("Software", true))
        {
            Console.WriteLine("There are {0} subkeys under {1}.",
            test9999.SubKeyCount.ToString(), testSettings.Name);
            foreach (string subKeyName in testSettings.GetSubKeyNames())
            {
                using (RegistryKey
                    tempKey = testSettings.OpenSubKey(subKeyName))
                {
                    Console.WriteLine("\nThere are {0} values for {1}.",
                        tempKey.ValueCount.ToString(), tempKey.Name);
                    foreach (string valueName in tempKey.GetValueNames())
                    {
                        Console.WriteLine("{0,-8}: {1}", valueName,
                            tempKey.GetValue(valueName).ToString());
                    }
                }
            }
        }

//        protected override void Dispose(bool disposing)
//{
            
/////////////////////// Вот это добавили //////////////////////////////////////
//   try
//   {
//    RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true); 
//// Открыли папку , true означает - хотим ли мы записывать в этот раздел 
//// реестра ?
//      RegistryKey wKey = key.CreateSubKey("RegistryTesting"); 
//// Создали новую папку в реестре
//wKey.SetValue("FormWidth", this.Size.Width);
//wKey.SetValue("FormHeight", this.Size.Height);
//// Здесь мы создали 2 ключа в которых сохранили размер формы
//      // MessageBox.Show("Параметры сохранены .");
//    }
//    catch(System.Exception err)
//    {
//MessageBox.Show("Произошла ошибка при сохранении параметров : " + err.Message);
//    }
//////////////////////////////////////////////////////////////////////////////
//    if (disposing && (components != null))
//     {
//          components.Dispose();
//     }
     
//base.Dispose(disposing);





//        private void frmMain_Load(object sender, EventArgs e)
//{
//try
//      {
//          RegistryKey key = Registry.CurrentUser;
//          key = key.OpenSubKey("Software\\RegistryTesting");
//          System.Object w = key.GetValue("FormWidth");
//          System.Object h = key.GetValue("FormHeight");
//          // Получили значения ключей и теперь применяем их к форме
//          this.Width = (int)w;
//          this.Height = (int)h;
//          // MessageBox.Show("Форма восстановлена .");
//       }
//    catch(System.Exception err)
//    {
//MessageBox.Show("Произошла ошибка при загрузке параметров "+err.Message);
//    }
//}
//}
        //RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
        //key.DeleteSubKey("RegistryTesting");


    //    // Create a subkey named Test9999 under HKEY_CURRENT_USER.  //3 вариант
    //    RegistryKey test9999 =
    //        Registry.CurrentUser.CreateSubKey("Test9999");
        
        
    //    // Create two subkeys under HKEY_CURRENT_USER\Test9999. The
    //    // keys are disposed when execution exits the using statement.
    //    using (RegistryKey
    //        testName = test9999.CreateSubKey("TestName"),
    //        testSettings = test9999.CreateSubKey("TestSettings"))
    //    {
    //        // Create data for the TestSettings subkey.
    //        testSettings.SetValue("Language", "French");
    //        testSettings.SetValue("Level", "Intermediate");
    //        testSettings.SetValue("ID", 123);
    //    }

        //// Print the information from the Test9999 subkey.
        //Console.WriteLine("There are {0} subkeys under {1}.",
        //    test9999.SubKeyCount.ToString(), test9999.Name);
        //foreach (string subKeyName in test9999.GetSubKeyNames())
        //{
        //    using (RegistryKey
        //        tempKey = test9999.OpenSubKey(subKeyName))
        //    {
        //        Console.WriteLine("\nThere are {0} values for {1}.",
        //            tempKey.ValueCount.ToString(), tempKey.Name);
        //        foreach (string valueName in tempKey.GetValueNames())
        //        {
        //            Console.WriteLine("{0,-8}: {1}", valueName,
        //                tempKey.GetValue(valueName).ToString());
        //        }
        //    }
        //}

    //    using (RegistryKey
    //        testSettings = test9999.OpenSubKey("TestSettings", true))
    //    {
    //        // Delete the ID value.
    //        testSettings.DeleteValue("id");

    //        // Verify the deletion.
    //        Console.WriteLine((string)testSettings.GetValue(
    //            "id", "ID not found."));
    //    }

    //    // Delete or close the new subkey.
    //    Console.Write("\nDelete newly created registry key? (Y/N) ");
    //    if (Char.ToUpper(Convert.ToChar(Console.Read())) == 'Y')
    //    {
    //        Registry.CurrentUser.DeleteSubKeyTree("Test9999");
    //        Console.WriteLine("\nRegistry key {0} deleted.",
    //            test9999.Name);
    //    }
    //    else
    //    {
    //        Console.WriteLine("\nRegistry key {0} closed.",
    //            test9999.ToString());
    //        test9999.Close();
    //    }

        Console.ReadKey();
    }

    static void PrintKeys(RegistryKey rkey)
    {

        // Retrieve all the subkeys for the specified key.
        String[] names = rkey.GetSubKeyNames();

        int icount = 0;

        Console.WriteLine("Subkeys of " + rkey.Name);
        Console.WriteLine("-----------------------------------------------");

        // Print the contents of the array to the console.
        foreach (String s in names)
        {
            Console.WriteLine(s);

            // The following code puts a limit on the number
            // of keys displayed.  Comment it out to print the
            // complete list.
            icount++;
            if (icount >= 20)
                break;
        }
    }
}