string[] names = new string[20];

names[0] = "Robert";
names[1] = "Paula";
names[2] = "Roxana";
names[3] = "Roxana";
names[4] = "Paula";
names[5] = "Robert";
names[6] = "Robert";
names[7] = "Paula";
names[8] = "Paula";
names[9] = "Paula";
names[10] = "Roxana";
names[11] = "Roxana";
names[12] = "Robert";
names[13] = "Paula";
names[14] = "Paula";
names[15] = "Robert";
names[16] = "Robert";
names[17] = "Roxana";
names[18] = "Paula";
names[19] = "Paula";

Console.WriteLine($"\nDługość tablicy 'names' wynosi {names.Length} rekordów:");

int sumRobert = 0;
int sumPaula = 0;
int sumRoxana = 0;

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "Robert")
    {
        sumRobert++;        
    }
    else if (names[i] == "Paula")
    {
        sumPaula++;
    }
    else if (names[i] == "Roxana")
        sumRoxana++;
}
Console.WriteLine($"\nImię 'Robert' występuje: {sumRobert} razy.");
Console.WriteLine($"\nImię 'Paula' występuje: {sumPaula} razy.");
Console.WriteLine($"\nImię 'Roxana' występuje: {sumRoxana} razy.");
