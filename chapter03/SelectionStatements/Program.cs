// #region Is Operator

// object o = 3;
// int j = 4;
// if (o is int i)
// {
//   WriteLine($"{i} x {j} = {i * j}");
// }
// else
// {
//   WriteLine("o is not an int so it cannot multiply");
// }

// #endregion

// Include lower bound but exclusive upper bound

using SelectionStatements;

int number = Random.Shared.Next(minValue: 1, maxValue: 7);
WriteLine($"My random number is {number}");
switch (number)
{
  case 1:
    WriteLine("One");
    break;
  case 2:
    WriteLine("Two");
    goto case 1;
  case 3: // Multiple case section
  case 4:
    WriteLine("Three or four");
    goto case 1;
  case 5:
    goto A_label;
  default:
    WriteLine("Default");
    break;
}
WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");

WriteLine("------------HERE!---------------");

var animals = new Animal?[]
{
  new Cat {Name = "Karen", Born = new DateTime(year:2022, month: 8, day: 23), Legs = 4, IsDomestic = true},
  null,
  new Cat {Name = "Kitty", Born = new DateTime(year: 1994, month: 6, day: 12)},
  new Spider {Name = "Sid Vicious", Born = DateTime.Today, IsVenomous = true},
  new Spider {Name = "Captain Fury", Born = DateTime.Today}
};

foreach (Animal? animal in animals)
{
  string message;
  switch (animal)
  {
    case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
      message = $"The cat named {fourLeggedCat.Name} has four legs";
      break;
    case Cat wildCat when wildCat.IsDomestic == false:
      message = $"The non-domestic cat is named {wildCat.Name}";
      break;
    case Cat cat:
      message = $"The cat is named {cat.Name}";
      break;
    default: // Default here to showcase that default will be evaluated last
      message = $"{animal?.Name} is a {animal?.GetType().Name}";
      break;
    case Spider spider when spider.IsVenomous:
      message = $"The {spider.Name} spider venomous. Run!";
      break;
    case null:
      message = "The animal is null";
      break;
  }
  
  WriteLine($"switch statement: {message}");
  
  // Rewrote with switch expression
  message = animal switch
  {
    Cat fourLeggedCat when fourLeggedCat.Legs == 4 => $"The cat named {fourLeggedCat.Name} has four legs.",
    Cat wildCat when !wildCat.IsDomestic => $"The non-domestic cat is named {wildCat.Name}",
    Cat cat => $"The cat is named {cat.Name}",
    Spider spider when spider.IsVenomous => $"The {spider.Name} is venomous. Run!",
    null => "The animal is null.",
    _ => $"{animal.Name} is a {animal.GetType().Name}."
  };
  
  WriteLine($"switch expression: {message}");
}

