namespace SelectionStatements;

class Animal // Base type for all animals
{
  public string? Name;
  public DateTime Born;
  public byte Legs;
}

class Cat : Animal // Subtype of animal
{
  public bool IsDomestic;
}

class Spider : Animal
{
  public bool IsVenomous;
}