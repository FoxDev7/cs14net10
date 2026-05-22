// int x = 0;
// while (x < 10)
// {
//   WriteLine(x);
//   x++;
// }

// Do while loop
// const string? actualPassword = "Pa$$w0rd";
// const int MAX_RETRIES = 3;
// int retry = 0;
//
// string? password;
// do
// {
//   Write("Enter your password: ");
//   password = ReadLine();
//   retry += 1;
// } while (password != actualPassword && retry < MAX_RETRIES);
//
// if (retry >= MAX_RETRIES)
// {
//   WriteLine("Failed");
//   return;
// }
// WriteLine("Correct!");

// For loop
for (int y = 0; y <= 10; y++)
{
  WriteLine(y);
}

for (int y = 0; y <= 10; y +=3)
{
  WriteLine(y);
}

// Foreach loop
List<string> names = ["Adam", "Barry", "Charlie"];
foreach (string name in names)
{
  WriteLine($"{name} has {name.Length} characters");
}

