using System;
using System.Threading;
using System.Collections.Generic;

namespace FHackerMan
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEFINICE PŮVODNÍCH HODNOT
            Random r = new Random();
            Console.ForegroundColor = ConsoleColor.Yellow;
            TimeSpan interval = new TimeSpan(0, 0, 0);
            TimeSpan credits = new TimeSpan(0, 0, 0);
            int speedNumber = 10;
            int decNum = -1;
            int menuSelNum = -1;
            int widthNum = 4;
            int heightNum = 45;
            int numberONumbersInt = 8;
            int randomOrngInt = 2;
            int colorPInt;
            string Speed;
            string dec;
            string menuSel;
            string widthString;
            string heightString;
            string spaceSymbolString = ".";
            string numberONumbersString;
            string randomOrngString;
            string colorPString;


            //BOOLEANS
            bool speed = false;
            bool error = false;
            bool width = false;
            bool height = false;
            bool settings = false;
            bool whatS = false;
            bool start = false;
            bool mainMenu = true;
            bool Menu = false;
            bool creditsScreen = false;
            bool spaceSymbol = false;
            bool numberONumbers = false;
            bool randomOrng = false;
            bool colorP = false;

            //COLOR BOOLEANS
                bool black = true;
                bool gray = true;
                bool blue = true;
                bool darkBlue = true;
                bool green = true;
                bool darkGreen = true;
                bool cyan = true;
                bool darkCyan = true;
                bool red = true;
                bool darkRed = true;
                bool magenta = true;
                bool darkMagenta = true;
                bool yellow = true;
                bool darkYellow = true;
                bool White = true;
                bool Rainbow = true;

            while (true)
            {
                //MAIN MENU
                while (mainMenu == true)
                {
                    Console.Clear();
                    decNum = -1;
                    menuSelNum = -1;
                    Menu = true;
                    while (Menu == true)
                    {
                        if (error == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Try again");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        Menu = false;

                        //převod hodnoty z typu string na int
                        try
                        {
                            Console.WriteLine("FHackerMan version.3.0.1");
                            Console.WriteLine("Your own fully customizable HackerMan screen!");
                            Console.WriteLine("");
                            Console.WriteLine("-- MAIN MENU --");
                            Console.WriteLine("0 - Start");
                            Console.WriteLine("1 - Credits");
                            Console.WriteLine("2 - Settings");
                            menuSel = Console.ReadLine();
                            menuSelNum = int.Parse(menuSel);
                            Menu = false;
                            error = false;
                            if (menuSelNum < 0 | menuSelNum > 2)
                            {
                                Menu = true;
                                error = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            whatS = true;
                            error = true;
                        }

                        //menu výběr
                        switch (menuSelNum)
                        {
                            case 0:
                                start = true;
                                Menu = false;
                                mainMenu = false;
                                break;
                            case 1:
                                creditsScreen = true;
                                Menu = false;
                                mainMenu = false;
                                break;
                            case 2:
                                settings = true;
                                Menu = false;
                                mainMenu = false;
                                break;
                            default:
                                break;
                        }
                        Console.Clear();
                    }
                }

                //CREDITS
                while (creditsScreen == true)
                {
                    Console.WriteLine("FHackerMan version.3.0.1");
                    Console.WriteLine("Your own fully customizable HackerMan screen!");
                    Console.WriteLine("");
                    Console.WriteLine("-- CREDITS --");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Code by");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("F");
                    Thread.Sleep(credits.Milliseconds + 500);
                    Console.Write("r");
                    Thread.Sleep(credits.Milliseconds + 500);
                    Console.Write("i");
                    Thread.Sleep(credits.Milliseconds + 500);
                    Console.Write("x");
                    Thread.Sleep(credits.Milliseconds + 500);
                    Console.Write("6");
                    Thread.Sleep(credits.Milliseconds + 500);
                    Console.Write("3");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Press any button to return to main menu");
                    Console.ReadKey();
                    creditsScreen = false;
                    mainMenu = true;
                }

                //nastavení
                while (settings == true)
                {
                    whatS = true;
                    while (whatS == true)
                    {
                        if (error == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Try again");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        whatS = false;

                        //převod hodnoty z typu string na int
                        try
                        {
                            Console.WriteLine("FHackerMan version.3.0.1");
                            Console.WriteLine("Your own fully customizable HackerMan screen!");
                            Console.WriteLine("");
                            Console.WriteLine("-- SETTINGS --");
                            Console.WriteLine("0 - layer speed");
                            Console.WriteLine("1 - number of lines");
                            Console.WriteLine("2 - number of columns");
                            Console.WriteLine("3 - space symbol");
                            Console.WriteLine("4 - number of numbers in column");
                            Console.WriteLine("5 - range of number generation");
                            Console.WriteLine("6 - Colors");
                            Console.WriteLine("");
                            Console.WriteLine("7 - return to main menu");
                            dec = Console.ReadLine();
                            decNum = int.Parse(dec);
                            whatS = false;
                            error = false;
                            if (decNum < 0 | decNum > 7)
                            {
                                settings = true;
                                whatS = true;
                                error = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            whatS = true;
                            error = true;
                        }
                        Console.Clear();
                    }

                    //nastavení - výběr
                    switch (decNum)
                    {
                        case 0:
                            speed = true;
                            break;
                        case 1:
                            height = true;
                            break;
                        case 2:
                            width = true;
                            break;
                        case 3:
                            spaceSymbol = true;
                            break;
                        case 4:
                            numberONumbers = true;
                            break;
                        case 5:
                            randomOrng = true;
                            break;
                        case 6:
                            colorP = true;
                            break;
                        case 7:
                            settings = false;
                            whatS = false;
                            mainMenu = true;
                            break;

                        default:
                            break;
                    }

                    //NASTAVENÍ RYCHLOSTI
                    while (speed == true)
                    {
                        if (error == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Try again");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        speed = false;

                        //převod hodnoty z typu string na int
                        try
                        {
                            Console.WriteLine("FHackerMan version.3.0.1");
                            Console.WriteLine("Your own fully customizable HackerMan screen!");
                            Console.WriteLine("");
                            Console.WriteLine("Set the speed of layer generating(100 = 1s interval)");
                            Speed = Console.ReadLine();
                            speedNumber = int.Parse(Speed);
                            interval = new TimeSpan(0, 0, speedNumber);
                            speed = false;
                            error = false;
                            if (speedNumber < 0)
                            {
                                speed = true;
                                error = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            speed = true;
                            error = true;
                        }
                        Console.Clear();
                    }

                    //NASTAVENÍ VÝŠKY
                    while (height == true)
                    {
                        if (error == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Try again");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        height = false;

                        //převod hodnoty z typu string na int
                        try
                        {
                            Console.WriteLine("FHackerMan version.3.0.1");
                            Console.WriteLine("Your own fully customizable HackerMan screen!");
                            Console.WriteLine("");
                            Console.WriteLine("Set the number of lines (1 or more)");
                            heightString = Console.ReadLine();
                            heightNum = int.Parse(heightString);
                            height = false;
                            error = false;
                            if (heightNum < 1)
                            {
                                height = true;
                                error = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            height = true;
                            error = true;
                        }
                        Console.Clear();
                    }

                    //NASTAVENÍ ČÍSEL V SLOUPCI
                    while (numberONumbers == true)
                    {
                        if (error == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Try again");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        numberONumbers = false;

                        //převod hodnoty z typu string na int
                        try
                        {
                            Console.WriteLine("FHackerMan version.3.0.1");
                            Console.WriteLine("Your own fully customizable HackerMan screen!");
                            Console.WriteLine("");
                            Console.WriteLine("Set the number of numbers in columns");
                            numberONumbersString = Console.ReadLine();
                            numberONumbersInt = int.Parse(numberONumbersString);
                            numberONumbers = false;
                            error = false;
                            if (numberONumbersInt < 0)
                            {
                                numberONumbers = true;
                                error = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            numberONumbers = true;
                            error = true;
                        }
                        Console.Clear();
                    }

                    //NASTAVENÍ RNG
                    while (randomOrng == true)
                    {
                        if (error == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Try again");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        randomOrng = false;

                        //převod hodnoty z typu string na int
                        try
                        {
                            Console.WriteLine("FHackerMan version.3.0.1");
                            Console.WriteLine("Your own fully customizable HackerMan screen!");
                            Console.WriteLine("");
                            Console.WriteLine("Set the range of number generation... (example 9 = 0 - 9 | min. 1)");
                            randomOrngString = Console.ReadLine();
                            randomOrngInt = int.Parse(randomOrngString);
                            randomOrng = false;
                            error = false;
                            if (randomOrngInt < 1 | randomOrngInt > 9)
                            {
                                randomOrng = true;
                                error = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            randomOrng = true;
                            error = true;
                        }
                        Console.Clear();
                    }

                    //NASTAVENÍ MEZISYMBOLU
                    while (spaceSymbol == true)
                    {
                        Console.WriteLine("FHackerMan version.3.0.1");
                        Console.WriteLine("Your own fully customizable HackerMan screen!");
                        Console.WriteLine("");
                        Console.WriteLine("Set the symbol between columns");
                        try
                        {
                            spaceSymbolString = Console.ReadLine();
                            spaceSymbol = false;
                        }
                        catch (Exception e)
                        {
                            spaceSymbol = true;
                            Console.WriteLine(e.Message);
                            throw;
                        }
                    }


                    //NASTAVENÍ BARVY
                    while (colorP == true)
                    {
                        if (error == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Try again");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        colorP = false;

                        //převod hodnoty z typu string na int
                        try
                        {
                            Console.WriteLine("FHackerMan version.3.0.1");
                            Console.WriteLine("Your own fully customizable HackerMan screen!");
                            Console.WriteLine("");
                            Console.WriteLine("COLORS!!!");
                            Console.WriteLine("");


                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("0  - ");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("black");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("1  - gray");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("2  - blue");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("3  - darkBlue");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("4  - green");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("5  - darkGreen");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("6  - cyan");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("7  - darkCyan");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("8  - red");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("9  - darkRed");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("10 - magenta");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("11 - darkMagenta");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("12 - yellow");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("13 - darkYellow");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("14 - White");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("15 - R");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("a");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("i");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("b");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("o");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("w");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("  (Changes color after each page)");
                            Console.WriteLine();

                            colorPString = Console.ReadLine();
                            colorPInt = int.Parse(colorPString);

                             black = false;
                             gray = false;
                             blue = false;
                             darkBlue = false;
                             green = false;
                             darkGreen = false;
                             cyan = false;
                             darkCyan = false;
                             red = false;
                             darkRed = false;
                             magenta = false;
                             darkMagenta = false;
                             yellow = false;
                             darkYellow = false;
                             White = false;
                             Rainbow = false;

                            switch (colorPInt)
                            {
                                case 0:
                                    black = true;
                                    break;
                                case 1:
                                    gray = true;
                                    break;
                                case 2:
                                    blue = true;
                                    break;
                                case 3:
                                    darkBlue = true;
                                    break;
                                case 4:
                                    green = true;
                                    break;
                                case 5:
                                    darkGreen = true;
                                    break;
                                case 6:
                                    cyan = true;
                                    break;
                                case 7:
                                    darkCyan = true;
                                    break;
                                case 8:
                                    red = true;
                                    break;
                                case 9:
                                    darkRed = true;
                                    break;
                                case 10:
                                    magenta = true;
                                    break;
                                case 11:
                                    darkMagenta = true;
                                    break;
                                case 12:
                                    yellow = true;
                                    break;
                                case 13:
                                    darkYellow = true;
                                    break;
                                case 14:
                                    White = true;
                                    break;
                                case 15:
                                    Rainbow = true;
                                    break;
                                default:
                                    yellow = true;
                                    break;
                            }

                            colorP = false;
                            error = false;
                            if (colorPInt < 0 | colorPInt > 15)
                            {
                                colorP = true;
                                error = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            colorP = true;
                            error = true;
                        }
                        Console.Clear();
                    }


                    //NASTAVENÍ ŠÍŘKY
                    while (width == true)
                    {
                        if (error == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Try again");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        width = false;

                        //převod hodnoty z typu string na int
                        try
                        {
                            Console.WriteLine("FHackerMan version.3.0.1");
                            Console.WriteLine("Your own fully customizable HackerMan screen!");
                            Console.WriteLine("");
                            Console.WriteLine("Set the number of columns (1 or more)");
                            widthString = Console.ReadLine();
                            widthNum = int.Parse(widthString);
                            width = false;
                            error = false;
                            if (widthNum < 1)
                            {
                                width = true;
                                error = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            width = true;
                            error = true;
                        }
                        Console.Clear();
                    }
                }

                Random rnd = new Random();

                //SAMOTNÁ GENERACE ČÍSLIC
                while (start == true)
                {
                    if (Rainbow == true)
                    {
                        Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                        if (Console.ForegroundColor == ConsoleColor.Black)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    else if (black == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if (gray == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (green == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (darkGreen == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (cyan == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (darkCyan == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                    }
                    else if (red == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (darkRed == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    else if (magenta == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (darkMagenta == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                    else if (yellow == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (darkYellow == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (White == true)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (darkBlue == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else if (blue == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    for (int d = 0; d < heightNum; d++)
                    {
                        for (int i = 0; i < widthNum - 1; i++)
                        {
                            for (int q = 0; q < numberONumbersInt; q++)
                            {
                                Console.Write(rnd.Next(randomOrngInt + 1));
                            }
                            Console.Write(spaceSymbolString);
                        }
                        for (int b = 0; b < numberONumbersInt; b++)
                        {
                            Console.Write(rnd.Next(randomOrngInt + 1));
                        }
                        Console.WriteLine("");
                        Thread.Sleep(interval.Milliseconds + speedNumber * 10);
                    }
                    Console.Clear();
                }
            }
        }
    }
}







/*
 * To do list:
 * 3.0.1
 * add to do list :D
 * make a range of rng nums >>done
 * number of numbers inside >>done
 * choose color >>done
 * 
 * 4.0.0
 * random numbers or random letters? or everything? will take some time--- :(
*/