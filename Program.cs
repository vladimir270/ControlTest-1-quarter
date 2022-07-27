string [] Massiv1 = new string [4] {"1234", "1567", "-2", "computer science"};
string [] Massiv2 = new string [Massiv1.Length];
int count = 0;

void CheckingArray (string [] Massiv1, string [] Massiv2)
{
    for (int i = 0; i < Massiv1.Length; i++)
    {
        if (Massiv1[i].Length <= 3)
        {
            Massiv2[count] = Massiv1[i];
            count++;
        }
    }
}

void PrintMassiv (string [] Massiv2)
{
    for (int i = 0; i < Massiv2.Length; i++)
    {
        Console.WriteLine($"{Massiv2[i]} ");
    }
}

CheckingArray(Massiv1,Massiv2);
PrintMassiv(Massiv2);