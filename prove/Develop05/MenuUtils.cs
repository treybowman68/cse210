public static class MenuUtils {


    public static int GetValidInt(string prompt, int min, int max)
    {
        int value;
        bool isValid;
        do {
            Console.Write(prompt);
            isValid = int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max;

            if (!isValid) {
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
            }

        } while (!isValid);

        return value;
    }

    public static void DisplayMenu(string menuTitle, string[] menuOptions)
    {
        Console.WriteLine(menuTitle);

        for (int i = 0; i < menuOptions.Length; i++) {
            Console.WriteLine($"{i + 1}. {menuOptions[i]}");
        }
    }

    public static int GetMenuChoice(string menuTitle, string[] menuOptions, string prompt)
    {
        DisplayMenu(menuTitle, menuOptions);
        return GetValidInt(prompt, 1, menuOptions.Length);
    }
}