using System;
using Cards2;

// loop while there's more input
string input = Console.ReadLine();

// Add your code between this comment
// and the comment below. You can of
// course add more space between the
// comments as needed

// declare a deck variables and create a deck object
// DON'T SHUFFLE THE DECK
Deck gameDeck = new Deck();

// deal 2 cards each to 4 players (deal properly, dealing
// the first card to each player before dealing the
// second card to each player)

// First round of dealing - one card to each player
Card playerOneFirstCard = gameDeck.TakeTopCard();
Card playerTwoFirstCard = gameDeck.TakeTopCard();
Card playerThreeFirstCard = gameDeck.TakeTopCard();
Card playerFourFirstCard = gameDeck.TakeTopCard();

// Second round of dealing - second card to each player
Card playerOneSecondCard = gameDeck.TakeTopCard();
Card playerTwoSecondCard = gameDeck.TakeTopCard();
Card playerThreeSecondCard = gameDeck.TakeTopCard();
Card playerFourSecondCard = gameDeck.TakeTopCard();

// deal 1 more card to players 2 and 3
Card playerTwoExtraCard = gameDeck.TakeTopCard();
Card playerThreeExtraCard = gameDeck.TakeTopCard();

// flip all the cards over
playerOneFirstCard.FlipOver();
playerOneSecondCard.FlipOver();

playerTwoFirstCard.FlipOver();
playerTwoSecondCard.FlipOver();
playerTwoExtraCard.FlipOver();

playerThreeFirstCard.FlipOver();
playerThreeSecondCard.FlipOver();
playerThreeExtraCard.FlipOver();

playerFourFirstCard.FlipOver();
playerFourSecondCard.FlipOver();

// print the cards for player 1
Console.WriteLine("Player 1:");
Console.WriteLine($"{playerOneFirstCard.Rank} of {playerOneFirstCard.Suit}");
Console.WriteLine($"{playerOneSecondCard.Rank} of {playerOneSecondCard.Suit}");

// print the cards for player 2
Console.WriteLine("Player 2:");
Console.WriteLine($"{playerTwoFirstCard.Rank} of {playerTwoFirstCard.Suit}");
Console.WriteLine($"{playerTwoSecondCard.Rank} of {playerTwoSecondCard.Suit}");
Console.WriteLine($"{playerTwoExtraCard.Rank} of {playerTwoExtraCard.Suit}");

// print the cards for player 3
Console.WriteLine("Player 3:");
Console.WriteLine($"{playerThreeFirstCard.Rank} of {playerThreeFirstCard.Suit}");
Console.WriteLine($"{playerThreeSecondCard.Rank} of {playerThreeSecondCard.Suit}");
Console.WriteLine($"{playerThreeExtraCard.Rank} of {playerThreeExtraCard.Suit}");

// print the cards for player 4
Console.WriteLine("Player 4:");
Console.WriteLine($"{playerFourFirstCard.Rank} of {playerFourFirstCard.Suit}");
Console.WriteLine($"{playerFourSecondCard.Rank} of {playerFourSecondCard.Suit}");