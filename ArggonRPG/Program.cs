// See https://aka.ms/new-console-template for more information

using ArggonRPG;

Menu.CreateMenu("Menu Principal", [
    new MenuOptions(1, "Crear Personaje"),
    new MenuOptions(2, "Seleccionar Personaje"),
    new MenuOptions(3, "Salir")
]);
var goblin = new Enemy("Goblin", 10, 2);
var continuar = true;

Console.WriteLine($"{DateTime.Now} - Starting ArggonRPG");

while (continuar)
{
    var selectedOption = HandleMenu("Menu Principal");

    if (selectedOption == 2)
    {
        continuar = false;
        Console.WriteLine("¡Gracias por jugar ArggonRPG!");
    }
}

return;

int HandleMenu(string menuTitle)
{
    var menu = Menu.GetMenu(menuTitle);
    var selectedOption = Menu.SelectOption(menu);
    switch (menuTitle)
    {
        case "Menu Principal":
            switch (selectedOption)
            {
                case 1:
                    Menu.CreateMenu("Crear Personaje", [
                        new MenuOptions(1, "Guerrero"),
                        new MenuOptions(2, "Salir")
                    ]);
                    HandleMenu("Crear Personaje");
                    break;
            }
            break;
        
        case "Crear Personaje":
            switch (selectedOption)
            {
                case 1:
                    Console.WriteLine("Creando personaje Guerrero...");
                    Console.Write("Ingrese el nombre del personaje: ");
                    var newCharacter = new Character(Console.ReadLine() ?? "Guerrero", CharacterClass.Warrior);
                    Console.WriteLine($"El {newCharacter.Class} {newCharacter.Name} ha sido creado con éxito.");
                    var listOfCharacters = Character.GetAllCharacters();
                    var menuOptions = new List<MenuOptions>();
                    foreach (var character in listOfCharacters)
                    {
                        menuOptions.Add(new MenuOptions(menuOptions.Count + 1, character.Name));
                    }
                    Menu.CreateMenu("Seleccionar Personaje", menuOptions);
                    HandleMenu("Seleccionar Personaje");
                    break;
                case 2:
                    HandleMenu("Menu Principal");
                    break;
            }
            break;
        
        // case "Seleccionar Personaje":
        //     switch (selectedOption)
        //     {
        //     }
    }

    return selectedOption;
}