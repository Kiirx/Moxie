﻿using Sys = Cosmos.System;
using Cosmos.System.ScanMaps;
using System;

namespace SkippleOS.Shell.Cmds.Console
{
    internal class cKeyboardMap
    {
        private static ShellManager shell = new ShellManager();

        public static void SetKeyboardMap()
        {
            shell.Write("Keymap: ", ConsoleColor.Gray);
            var input = System.Console.ReadLine();

            switch(input)
            {
                case "en_US":
                    if(ShellInfo.langSelected != "en_US")
                    {
                        Sys.KeyboardManager.SetKeyLayout(new US_Standard());
                        ShellInfo.langSelected = "en_US";
                    } else
                    {
                        shell.WriteLine("The Keyboard mapping is already on en_US.",type: 3);
                    }
                    break;

                case "fr_FR":
                    if(ShellInfo.langSelected != "fr_FR")
                    {
                        Sys.KeyboardManager.SetKeyLayout(new FR_Standard());
                        ShellInfo.langSelected = "fr_FR";
                    }
                    else
                    {
                        shell.WriteLine("The Keyboard mapping is already on fr_FR.", type: 3);
                    }
                    break;

                case "en_DE":
                    if (ShellInfo.langSelected != "en_DE")
                    {
                        Sys.KeyboardManager.SetKeyLayout(new DE_Standard());
                        ShellInfo.langSelected = "en_DE";
                    }
                    else
                    {
                        shell.WriteLine("The Keyboard mapping is already on en_DE.", type: 3);
                    }
                    break;

                default:
                    shell.Write("Please enter a valid keyboard language. Example: \"en_US\"", type: 3);
                    break;
            }
        }
    }
}
