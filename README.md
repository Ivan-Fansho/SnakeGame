# SnakeGame

## Console-Based Snake Game

This is a simple console-based Snake game implemented in C#. The objective is to control a snake using the arrow keys to eat the apple (`@`) that appears on the grid. 

## How to Play

- Use the **arrow keys** to move the snake:
    - **Left Arrow**: Move left
    - **Up Arrow**: Move up
    - **Right Arrow**: Move right
    - **Down Arrow**: Move down
- The goal is to eat the apple (`@`) that appears randomly on the grid.
- Each time the snake eats an apple, it grows longer, and the score increases by one point.
- If the snake collides with the grid's boundary or its own body, the game resets, and the score returns to zero.

## Game Features

- Simple and easy-to-understand gameplay.
- Randomly generated apple positions within the grid.
- Score display at the top of the screen.
- Snake movement in four directions using arrow keys.
- Automatic game reset upon collision with boundaries or self.

## Requirements

- [.NET Core](https://dotnet.microsoft.com/download) or [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) installed on your machine.
- A console window to run the game.

## Getting Started

1. Clone the repository to your local machine:
   ```sh
   git clone https://github.com/yourusername/SnakeGame.git

2. Navigate to the project directory:
    ```sh
    cd SnakeGame
    ```
3. Build and run the game using your preferred IDE or command line:
    ```sh
   dotnet run
   ```