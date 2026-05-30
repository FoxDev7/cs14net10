WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();

try
{
  int age = int.Parse(input!);
  WriteLine($"You are {age} years old");
}
catch (OverflowException)
{
  WriteLine("Your age is a valid number format but it is either too big or small.");
}

catch (FormatException)
{
  WriteLine("The age you entered is not a valid number format.");
}

catch (Exception ex)
{
  WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After parsing");


Write("Enter an amount: ");
string amount = ReadLine()!;
if (string.IsNullOrEmpty(amount)) return;
try
{
  decimal amountValue = decimal.Parse(amount);
  WriteLine($"Amount formatted as currency: {amountValue:C}");
}
catch (FormatException) when (amount.Contains('$'))
{
  WriteLine("Amount cannot use the dollar sign!");
}
catch (FormatException)
{
  WriteLine("Amount must only contains digits!");
}

// Throwing overflow exceptions with the checked statement
try
{
  checked
  {
    int x = int.MaxValue - 1;
    WriteLine($"Initial value: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
  }
}
catch (OverflowException)
{
  WriteLine("The code overflowed but I caught the exception.");
}

unchecked
{
  int y = int.MaxValue + 1;
  WriteLine($"Initial value");
}