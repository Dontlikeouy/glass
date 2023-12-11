class Program
{
    private static void Main(string[] args)
    {
        string? input = null;
        while (input == null)
        {
            input = Console.ReadLine();
        }

        string[] element = input.Split('/');

        int сhamberness = 0; // Камерность
        int thicknessSP = 0; // Толщина СП 
        int thicknessGlass = 0; // Толщина стекла 
        bool isGlass = true;
        //СП однокамерный или 2 камерный?
        if (element.Length == 3)
        {
            сhamberness = 1;
        }
        else if (element.Length == 5)
        {
            сhamberness = 2;
        }
        else
        {
            Console.WriteLine($"Ошибка: не соответствует шаблону Стекло\\Рамка\\Стекло или Стекло\\Рамка\\Стекло\\Рамка\\Стекло - '{input}'");
            goto exit; // или return
        }

        for (int i = 0; i < element.Length; i++)
        {
            int position = 0;
            foreach (char symbol in element[i])
            {
                // 48-57 ASCII позиция чисел 0-9
                // 48<=symbol<=57
                if (48 <= symbol && symbol <= 57)
                {
                    position++;
                }
                else
                {
                    break;
                }
            }

            if (position == 0)
            {
                Console.WriteLine($"Ошибка: не найдена толщина Стекла\\Рамки в элементе {i} - '{element[i]}'");
                goto exit; // или return
            }

            int value = Convert.ToInt32(element[i][..position]);

            //Толщина всего СП?
            thicknessSP += value;

            //Толщина  стекла в данном СП?
            if (isGlass == true)
            {
                thicknessGlass += value;
                isGlass = false;
            }
            else
            {
                isGlass = true;
            }

        }


        Console.WriteLine($"Камерность: {сhamberness} Толщина СП: {thicknessSP} Толщина стекла: {thicknessGlass}");

    exit:
        Console.ReadKey();
    }
}