int hero = 10;
int monster = 10;
Random attack = new();
int damage = 0;

do
{
    damage = attack.Next(1,11);

    Console.WriteLine($"Hero damage is {damage}");

    monster -= damage;
    switch (monster)
    {
        case > 0:
        Console.WriteLine($"Monster Health is: {monster}");
        break;
        
        case <= 0:
        Console.WriteLine("Monster Health is: 0");
        continue;
    }

    
    damage = attack.Next(1,11);
    Console.WriteLine($"Monster damage is {damage}");
    hero -= damage;
    switch (hero)
    {
        case > 0:
        Console.WriteLine($"Hero Health is: {hero}");
        break;

        case <= 0:
        Console.WriteLine("Hero Health is: 0");
        continue;
    }
  
} while ((hero > 0)&&(monster > 0));

if(hero <= 0)
Console.WriteLine("The Monster won.");

else if(monster <= 0)
Console.WriteLine("The Hero Won.");