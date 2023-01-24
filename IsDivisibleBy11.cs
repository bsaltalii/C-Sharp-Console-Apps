int myNumber = 126;

int firstDigit = (myNumber / 100);
myNumber -= (firstDigit * 100);

int secondDigit = (myNumber / 10);
myNumber -= (secondDigit * 10);

int thirdDigit = myNumber;

int result = (firstDigit + thirdDigit - secondDigit) % 11;


Console.WriteLine(result == 0 ? "11 ile tam bölünür" : "11 ile tam bölünmez");

