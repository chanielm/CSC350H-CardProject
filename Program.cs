using Cards2;

// Exercise 1
Deck deck = new Deck();
deck.Shuffle();

Card top = deck.TakeTopCard();
Console.WriteLine($"{top.Rank} of {top.Suit}");

deck.Print();
Console.Write("\n\n");

// Exercise 2
int evens = 0;
for (int i = 0; i < 5; i++) {
    top = deck.TakeTopCard();
    Console.WriteLine((int)top.Rank + 1);
    if (((int)top.Rank + 1) % 2 == 0) evens++;
}

Console.WriteLine($"Even Cards: {evens}");
Console.WriteLine($"Odd Cards: {5 - evens}");
