

using Ex1;

Szescian szescian = new Szescian(20);
Szescian szescian2 = new Szescian(12);
Szescian szescian3 = new Szescian(13);



var result = ExHelper.CheckFigures(szescian, szescian2, szescian3);


if(result)
{
    Console.WriteLine("Można ułozyć marioszkę");
}
else
{
    Console.WriteLine("Nie można ułożyć marioszki");
}
