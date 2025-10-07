StaticFields
A C# console app to practice OOP encapsulation and static members. Each branch focuses on a specific C# feature, with game-themed classes like inventory items, achievements, and enemies.

# 📖 About
StaticFields is a learning project to master C# OOP concepts. The static-members branch focuses on static fields and methods using a game-inspired Enemy class. It tracks enemies (like Zombies and Skeletons) with a static counter, mimicking Minecraft-style mechanics.

# 🚀 Features

Enemy Class: Represents game enemies with name, health, and damage mechanics.

Name: Read-only property for enemy name (e.g., "Zombie").

Health: Property with validation (0–100 HP).

TakeDamage: Deals 30 damage to Zombies, ~20 to Skeletons (30 × 0.66).

TotalEnemies: Static property tracking the number of created enemies.

GetEnemyCount: Static method to display the total enemy count.

Input Validation: Ensures non-empty names and valid health range.

Game Vibe: Minecraft-inspired with Zombies, Skeletons, and custom damage logic.

# 🛠️ How It Works

The Enemy class uses a static field _totalEnemies to count all enemies.

Each enemy spawns with 100 HP, takes damage based on type (Zombie/Skeleton), and tracks status (Alive/Dead).

Static property TotalEnemies and method GetEnemyCount provide global enemy stats.

Run in the static-members branch to see it in action.

# 💻 Installation

1 - Clone the repo: ``` git clone https://github.com/AwaIIenceCode/StaticFields.git ```
2 - Open in your IDE (Visual Studio, Rider, etc.).
3 - Run in a C# environment (.NET Core or later).
