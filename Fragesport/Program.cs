﻿Console.WriteLine("Welcome to the best gameshow ever you will awenser a few simple questions if you get one wrong you will be tourcherd;)");

Console.Clear(); String name;

int rightanswers = 0;

Console.WriteLine("Write your name: ");

name = Console.ReadLine();

string nameFirstLetter = name.Substring(0, 1).ToUpper();
string nameTheRestOfTheLetters = name.Substring(1).ToLower();

name = nameFirstLetter + nameTheRestOfTheLetters;

while (name == "")
{
    Console.WriteLine("please write your name or i will kill you");
    name = Console.ReadLine();
}
Console.Clear();

Console.WriteLine($"Here we go {name}!");

Thread.Sleep(2000);

Console.Clear();


Console.WriteLine("What country dosent have any water?.\n a) Egypt    b)Nigeria   c)Atlantis    ");
string Svar1 = Console.ReadLine().ToLower();

if (Svar1 == "a")
{
    rightanswers++;
    Console.WriteLine("Congratiolations you got it right! But dont let your gard down, Here you go the next question!");
}

else if (Svar1 == "egypt")
{
    rightanswers++;
    Console.WriteLine("Congratiolations you got it right! But dont let your gard down, Here you go the next question!");
}

else
{
    Console.WriteLine("You got it wrong!!!! you will suffer at the end, Here you go the next question!");
}

Thread.Sleep(2000);

Console.Clear();


Console.WriteLine("What is the name of the Indian Guy in TE23C in NTI odenplan?.\n a) Haroon    b)John   c)Mostafa    ");
string Svar2 = Console.ReadLine().ToLower();

if (Svar2 == "a")
{
    rightanswers++;
    Console.WriteLine("Congratiolations you got it right! But dont let your gard down, Here you go the next question!");
}
else if (Svar2 == "haroon")
{
    rightanswers++;
    Console.WriteLine("Congratiolations you got it right! But dont let your gard down, Here you go the next question!");
}
else
{
    Console.WriteLine("You got it wrong!!!! you will suffer at the end, Here you go the next question!");
}

Thread.Sleep(2000);

Console.Clear();


Console.WriteLine("How is the fattest guy in the whole world.\n a) Kevin    b)Calin   c)Mostafa    ");
string Svar3 = Console.ReadLine().ToLower();

if (Svar3 == "c")
{
    rightanswers++;
    Console.WriteLine("Congratiolations you got it right!");
}
else if (Svar3 == "mostafa")
{
    rightanswers++;
    Console.WriteLine("Congratiolations you got it right!");
}
else
{
    Console.WriteLine("You got it wrong!!!!");
}

Thread.Sleep(2000);

Console.Clear();


if (rightanswers == 3)
{
    Console.WriteLine($"Congratiolations! You got {rightanswers} points you are free this time!");

}
else if (rightanswers == 2)
{
    Console.WriteLine($"Congratiolations! You got {rightanswers} points but you were only 1 point away from going home unharmed. You will be skinned and then you are free!");

}
else
{
    Console.WriteLine($"Congratiolations! You got {rightanswers} points how dumb are you your genes are notgoing to spread you will be skinned and burned at the same time");

}
Console.WriteLine("Press any key to exit");

Console.ReadLine();