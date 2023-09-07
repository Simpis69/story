Console.WriteLine("Du ser en fri prilla!, tar du den?");
string prilla = Console.ReadLine().ToLower();



if (prilla == "ja")

{
    Console.WriteLine("Ånej det va en super läskig cuba cherry!");
    Console.WriteLine("väljer du att behålla den?");
    Console.WriteLine("Ja, Nej?");
}

else if (prilla == "nej")

{
    Console.WriteLine("ha ett tråkigt liv då!");

}


string behålla = Console.ReadLine().ToLower();

if (behålla == "ja")

{
    Console.WriteLine("Du stoppar in prillan och den bränner som faan");
    Console.WriteLine("Du börjar snurra som om du har druckit blackout stout! Slänger du prillan eller behåller du han?");

}

else if (behålla == "nej")

{
    Console.WriteLine("Du får inte uppleva den underbara känslan:(");
    
}




string snurra = Console.ReadLine().ToLower();


if (snurra == "behåll")

{
    Console.WriteLine("Det blir mörkt och du svimmar, när du svimmar slår du i huvudet och dör");
    Console.WriteLine("Game Over:(");
}

else if (snurra == "släng han")

{
    Console.WriteLine("Du klarade dig för den onda prillan! Men du kommer kräva honom för resten av ditt liv");
}


 else
  {
    Console.WriteLine("Jag förstår inte, nu får du ingen prilla alls!>:(");
  }

Console.WriteLine("Tryck enter för att avsluta");

Console.ReadLine();