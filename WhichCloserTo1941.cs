int clock1, clock2 , clock3 , constclock , closer;

constclock = 1941;
clock1 = 1315;
clock2 = 1654;
clock3 = 2212;

closer = constclock;
closer = (constclock - clock2) < (clock3 - constclock) ? clock2 : closer;
closer = (constclock - clock1) < (clock3 - constclock) ? clock1 : closer; 

Console.WriteLine("2212 is closer to : " + closer);
Console.ReadLine();
