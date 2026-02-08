# Alphabet Drawer 🔠

A lightweight C# library for procedurally rendering ASCII art text. It uses a coordinate-based painting system to draw scalable, grid-aligned characters directly to the console buffer.

[![Documentation](https://img.shields.io/badge/Documentation-View_Site-blue?style=for-the-badge&logo=google-chrome)](https://www.malekalhafi.com/projects/alphabet.html)

**View full documentation and live examples at:** [https://www.malekalhafi.com/projects/alphabet.html](https://www.malekalhafi.com/projects/alphabet.html)

## Features
- **Procedural Rendering:** Uses mathematical logic to draw characters pixel-by-pixel.
- **Coordinate System:** Control exactly where text appears using Column Index and Row Offset.
- **Lightweight:** Single static class, zero dependencies.

## Installation
1. Download the `Alphabet.cs` file from this repository.
2. Add it to your C# Console Application project.
3. Start drawing immediately!

## Usage

### Drawing Single Letters
Call the static method for the letter you want. Pass the **Column Index** (integer) to place letters side-by-side. The library automatically calculates the pixel width (7 pixels per column).

```csharp
// Draw 'A' at the first position
Alphabet.A(0);

// Draw 'B' at the second position
Alphabet.B(1);
