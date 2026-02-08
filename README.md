# Alphabet Drawer 🔠

A lightweight C# library for procedurally rendering ASCII art text. It uses a coordinate-based painting system to draw scalable, grid-aligned characters directly to the console buffer.

## Features
- **Procedural Rendering:** Draws characters pixel-by-pixel using `Console.SetCursorPosition`.
- **Coordinate System:** Control exactly where text appears (Row/Column).
- **Lightweight:** Single file, zero dependencies.

## Installation
1. Download `Alphabet.cs` from this repository.
2. Add it to your C# Console Project.
3. Start drawing!

## Usage

### Drawing Single Letters
Pass the column index to place letters side-by-side. Each letter is 7 pixels wide.

```csharp
// Draw 'A' at the start (Index 0)
Alphabet.A(0);

// Draw 'B' next to it (Index 1)
Alphabet.B(1);

