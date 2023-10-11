Console.Write("Представьтесь пожалуйста: ");
        string username = Console.ReadLine();
        if (username.ToLower() == "женя")
        {
            Console.WriteLine("Ура это же, Женя!");
        }
        else
        {
            Console.WriteLine("Добро пожаловать, " + username);
        }