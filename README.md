# Flappy Bird Clone (Unity 6)

A 2D arcade physics game built in **Unity 6** and **C#**, recreating classic *Flappy Bird* mechanics with modernized gameplay feel, dynamic physics-based animation, procedural background effects, and integrated audio management.

Developed as a personal portfolio project demonstrating core game development architecture, 2D physics integration, state management, and modern Unity workflows.

---

## 🎮 Gameplay Preview

> *Tip: Add a gameplay GIF or screenshot here by placing an image in the repository (e.g. `docs/gameplay.gif`) and linking it.*

```
+-------------------------------------------------------------+
|                                                             |
|                    [ Insert Gameplay GIF ]                  |
|                                                             |
+-------------------------------------------------------------+
```

---

## 🛠️ Tech Stack & Tools

- **Engine:** Unity 6 (6000.3.x)
- **Language:** C# (.NET)
- **Rendering:** Universal Render Pipeline (URP 2D)
- **Input System:** Modern Unity Input System (`UnityEngine.InputSystem`)
- **Audio:** Unity Audio Engine (2D Spatialization, Persistent BGM Singleton, SFX triggers)
- **UI:** Unity UI (uGUI) & TextMesh Pro
- **Version Control:** Git & GitHub

---

## ⚙️ Architecture & Technical Highlights

### 1. Velocity-Driven Kinematics & Tilt Dynamics (`BirdTilt.cs`)
- Instead of static sprite rotation, the bird calculates its pitch dynamically using its `Rigidbody2D.linearVelocity.y`.
- Smooth transitions between ascending angles (+30°) and steep diving angles (-90°) mimic real arcade feel with customizable upward and falling tilt speeds.

### 2. Event-Driven Game Loop & State Management (`LogicScript.cs` & `birdscript.cs`)
- Centralized game manager decouples gameplay entities from high-level state.
- Handles score tracking, UI updates, game over triggers, and scene reloads cleanly.
- Implements `[ContextMenu]` attributes for editor-time debugging and score simulation.
- Guarded collision handling (`isDead` flag) prevents cascading game-over loops and repeated audio events.

### 3. Audio Architecture & Cross-Scene Persistence (`musicManager.cs` & `birdscript.cs`)
- **Persistent BGM Singleton:** Uses a singleton pattern with `DontDestroyOnLoad` in `musicManager.cs` to ensure background music plays continuously across scene transitions (from `TitleScreen` to `SampleScene`) without audio drops or duplicate listeners.
- **Synchronized SFX Triggers:** Dedicated `AudioSource` components on the player handle real-time flap/jump sounds and collision/death squawk SFX synchronized with physics and animation triggers.

### 4. Procedural Obstacle Spawning & Memory Management (`PiperSpawnerScript.cs` & `MovePipe.cs`)
- Time-based generation with dynamic vertical height offsets (`Random.Range(lowestPoint, highestPoint)`).
- Automatic boundary detection with a configurable off-screen `deleteZone` to prevent memory leaks and unnecessary GameObject overhead.

### 5. Custom Particle-Driven Cloud Background (`CloudSpriteSetup.cs` / `CloudSpriteRandomizer.cs`)
- Utilizes Unity's `ParticleSystem` combined with dynamic runtime sprite swapping (`Resources.LoadAll<Sprite>`) to render randomized, non-repeating cloud backgrounds with minimal draw calls.

### 6. Multi-Scene Navigation (`TitleScreenManager.cs`)
- Structured scene flow transitioning seamlessly from the Title/Menu screen to the primary gameplay scene (`SampleScene`).

---

## 🕹️ Controls

| Action | Key / Input |
| :--- | :--- |
| **Flap / Jump** | `Spacebar` |
| **Start / Restart** | UI Buttons / Click |

---

## 🚀 Getting Started

### Prerequisites
- Unity Hub
- Unity Editor version **6000.3.x** or later

### Installation & Running Locally
1. Clone the repository:
   ```bash
   git clone https://github.com/nazirulnashriq/Flappy-Bird-Clone.git
   ```
2. Open **Unity Hub** and click **Add** > **Add project from disk**.
3. Select the cloned `Flapping Bird` directory.
4. Open the project in Unity Editor.
5. In the **Project** window, navigate to `Assets/Scenes/TitleScreen.unity` (or `SampleScene.unity`) and press **Play**.

---

## 📈 Planned Enhancements
- [ ] Persistent high-score saving with `PlayerPrefs` or JSON serialization
- [ ] WebGL build deployed to itch.io for instant browser play
- [ ] Mobile touch support via the new Input System

---

## 👤 Author
- **Nazirul Nashriq** - [GitHub Profile](https://github.com/nazirulnashriq)
