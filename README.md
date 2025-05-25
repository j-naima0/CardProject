# CardProject

A C# console application that simulates dealing cards to multiple players using a standard deck of cards.

## Description

This program demonstrates basic card dealing mechanics by:
- Creating a standard deck of cards (without shuffling)
- Dealing cards to 4 players in proper order
- Giving some players additional cards
- Displaying each player's hand

## How It Works

1. **Deck Creation**: Creates a new deck using the Cards2 library
2. **Card Dealing**: 
   - Deals 2 cards to each of 4 players (proper dealing order)
   - Gives 1 additional card to Player 2 and Player 3
3. **Card Display**: Shows all cards face-up for each player

## Final Card Distribution
- **Player 1**: 2 cards
- **Player 2**: 3 cards  
- **Player 3**: 3 cards
- **Player 4**: 2 cards

## Requirements

- .NET Core/Framework
- Cards2 library (included in project)
- C# development environment (Visual Studio, VS Code, etc.)

## How to Run

1. Clone this repository
2. Open the project in your C# development environment
3. Build and run the project
4. Enter any input when prompted
5. View the dealt cards in the console output

## Sample Output

```
Player 1:
Ace of Spades
Two of Spades

Player 2:
Three of Spades
Four of Spades
Five of Spades

Player 3:
Six of Spades
Seven of Spades
Eight of Spades

Player 4:
Nine of Spades
Ten of Spades
```

## Technologies Used

- C#
- .NET
- Cards2 Library
- Console Application

## Learning Objectives

This project demonstrates:
- Working with external libraries
- Object-oriented programming concepts
- Basic game logic implementation
- Console input/output operations
- Variable declaration and management

## Author

Created as part of a C# programming course assignment.

## License

This project is for educational purposes.
