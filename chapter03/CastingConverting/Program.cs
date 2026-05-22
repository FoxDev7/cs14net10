int a = 10;
double b = a; // An int can be safely cast into a double
WriteLine($"a is {a}, b is {b}");


// Casting double to int
double c = 9.8;
int d =  (int)c; // Compiler will throw an error if you do not explicitly cast
WriteLine($"c is {c}, d is {d}"); // d loses the .8 part.

// Cast large and small integers
long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");