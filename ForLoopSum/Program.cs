//numbrid 1-10ni
//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"i = {i + 1}");
//    //{i + 1} ei muuda i väärtust vaid on lihtsalt kuvamiseks
//}

//numbrid 10-1ni
//for (int i = 10; i > 0; i--)
//{
//    Console.WriteLine($"i = {i}");
//   }

//numbrite kokku lugemine
int sum = 0;
for(int i = 1; i < 11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum} ");
    sum = sum + i;
}
Console.WriteLine($"Final Total {sum} ");