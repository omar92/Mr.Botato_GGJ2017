# Mr. Botato 🥔

A Unity game created for the **Global Game Jam 2017**. You play as Mr. Botato — a humble potato who starts life as a rolling ball and must roam the world collecting body parts to assemble himself piece by piece.

## Gameplay

Mr. Botato begins the game as a legless, armless, eyeless sphere rolling around the environment. As he bumps into scattered body parts, he automatically picks them up and attaches them to himself, unlocking new movement abilities along the way:

| Parts Collected | Player State |
|---|---|
| No legs | Rolling ball |
| 1 leg | Hobbling on one leg |
| 2 legs | Walking & jumping |

Collectible body parts include:
- **Legs** (left & right) — unlock walking and jumping
- **Arms** (left & right)
- **Eyes** (left & right) — enable mouse-look camera
- **Ears** (left & right)
- **Nose**
- **Mouth**

## Controls

| Action | Input |
|---|---|
| Move | `W` / `A` / `S` / `D` or Arrow keys |
| Look around (requires eyes) | Mouse |
| Jump (requires two legs) | `Space` |

## Requirements

- **Unity 2017.3.0f3** or later
- Windows, macOS, or Linux desktop

## Getting Started

### Opening the Project

1. Download and install **[Unity Hub](https://unity.com/unity-hub)**.
2. In Unity Hub, click **Add** and select the root folder of this repository.
3. Make sure you have **Unity 2017.3.0f3** installed (Unity Hub will prompt you to install it if needed).
4. Open the project — Unity will import all assets automatically.

### Running the Game in the Editor

1. In the **Project** panel, navigate to `Assets/Scenes/`.
2. Double-click **MainScene** to open it.
3. Press the **Play** button (▶) in the Unity toolbar.
4. Use the controls above to roll around and collect body parts.

### Building the Game

1. Go to **File → Build Settings**.
2. Select your target platform (PC, Mac & Linux Standalone is the default).
3. Click **Add Open Scenes** to include the main scene.
4. Click **Build** and choose an output folder.
5. Run the resulting executable to play the built game.

## Project Structure

```
Assets/
├── Scenes/          # Unity scene files (MainScene)
├── Scripts/         # All C# game logic
│   ├── PlayerController.cs      # State-machine driver for the player
│   ├── CollectingParts.cs       # Trigger detection & part attachment
│   ├── GameManager.cs           # Activates / toggles interactive parts
│   ├── RollingPLayerState.cs    # Rolling (no legs) movement
│   ├── OneLegPlayerState.cs     # One-leg movement
│   ├── TwoLegPlayerState.cs     # Two-leg walking & jumping
│   ├── MouseLook.cs             # Mouse-look camera control
│   └── ...                      # Other part-specific scripts
├── Prefabs/         # Reusable prefab assets
├── Materials/       # Materials used in the scene
├── Textures/        # Texture assets
└── UI/              # UI assets
PostProcessing/      # Post-processing stack package
ProjectSettings/     # Unity project configuration
```

## Built With

- [Unity 2017.3](https://unity.com/) — game engine
- C# — scripting language

## License

This project was made during a game jam. See the repository for any licence information.
