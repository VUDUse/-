// See https://aka.ms/new-console-template for more information
static int DvizhStrok(int strok, int x)
{
    Random rnd = new Random(); //
    int value = rnd.Next(1, 3); // Генерация действия

    switch (value)
    {
        case 1:
            if (strok < x && x > 0)
            {
                strok++;
            }
            else
            {
                strok--;
            }
            break;

        case 2:
            if (strok <= x && x > 0 && strok != 0)
            {
                strok--;
            }
            break;
    }

    return strok;
}

static int DvizhStolb(int stolb, int y)
{
    Random rnd = new Random(); //
    int value = rnd.Next(1, 3); // Генерация действия

    switch (value)
    {
        case 1:
            if (stolb < y && y > 0)
            {
                stolb++;

            }
            else
            {
                stolb--;
            }
            break;

        case 2:
            if (stolb <= y && y > 0 && stolb != 0)
            {
                stolb--;
            }
            break;
    }
    return stolb;
}

static void Pole(int strok, int stolb, int s, string[,] array, string Pust, string Klet, int x, int y)
{
    //Console.WriteLine(strok);
    //Console.WriteLine(stolb);

    #region Поле

    for (int i = 0; i <= x; i++)
    {
        if (i == strok && s == stolb)
        {
            array[strok, stolb] = Klet; // Первичное присвоение нолика
            Console.Write(array[strok, stolb]); // Первичное рисование нолика
            i++;
        }

        array[i, s] = " ";
        Console.Write(array[i, s]);

        if (i == x - 1)
        {
            Console.WriteLine();
            s++;
            i = -1;
        }

        if (s == y)
        {
            break;

        }


    } //Рисует поле



    #endregion
}

int x = 20; // Ширина поля
int y = 20; // Высота поля

string Pust = " "; // Пустая единица
string Klet = "O"; // Нолик

int strok = 1; // Координата широты нолика
int stolb = 1; // Координата высоты нолика

int s = 0; // Показатель высоты поля

string[,] array = new string[x, y]; // Массив образующий поле

for (int i = 0; true; i++)
{
    if (i % 100000000 == 0)
    {
        strok = DvizhStrok(strok, x);
        stolb = DvizhStolb(stolb, y);
        Console.Clear();
        Pole(strok, stolb, s, array, Pust, Klet, x, y);
    }

}

Console.ReadKey();
