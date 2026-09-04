# Chain Bound

A 2D physics-platformer game built with Unity for **The Very Serious Juniper Dev Game Jam**. 

Spin and launch a heavy ball chained to a blue spirit to navigate lethal dungeon hazards and find the escape.

---

## Jam Results & Recognition

Out of **3,504 submissions** and ~69.5k community ratings:
- **Creativity & Theme:** Ranked **#542** (Score: 3.887)
- **Visuals:** Ranked **#860** (Score: 3.613)
- **Overall Placement:** Ranked **#1105** (Score: 3.300)

**Playable Web / Download:** [Chain Bound on itch.io](https://phymoss.itch.io/)

---

## Core Mechanics & Features

- **2D Physics-Driven Locomotion:** Movement and jumping rely on angular momentum, inertia, and 2D physics constraints attached to a heavy chained ball.
- **Precision Hazard Navigation:** Obstacle-heavy dungeon layouts designed around fast reflexes, impulse redirection, and instant restart loops.
- **Tilemap Collision Systems:** Layered 2D environments combining grid-aligned hazard triggers with dynamic physical materials (`Platform.physicsMaterial2D`).
- **Input System:** Modern Unity Input System implementation (`Input.inputactions`) handling responsive directional commands and momentum release.

---

## Tech Stack

| Layer          | Technology                                   |
|----------------|----------------------------------------------|
| Engine         | Unity                                        |
| Language       | C#                                           |
| Physics        | Unity 2D Physics Engine (Rigidbodies, Joints)|
| Input          | Unity New Input System                       |
| Environment    | 2D Tilemap Systems                           |

---

## Project Structure

```text
chain-bound/
├── Assets/
│   ├── Scripts/               # Player movement, momentum & restart logic
│   ├── Prefabs/               # Traps, dungeon props & dynamic objects
│   ├── Scenes/                # Level layouts & gameplay flow
│   ├── Tilemaps/              # Environment tiles & collision meshes
│   ├── My Assets/             # Custom sprites, textures & audio files
│   ├── Imported Assets/       # Utility packages & external assets
│   ├── Settings/              # Render pipeline & project configurations
│   ├── TextMesh Pro/          # UI typography assets
│   └── Input.inputactions     # Input system bindings
└── ProjectSettings/
```


---

## Preview

<img width="315" height="250" alt="dQ9hmt" src="https://github.com/user-attachments/assets/6ffba781-176b-49fd-b760-2fe60619f803" />  <img width="1732" height="731" alt="t0sRRP" src="https://github.com/user-attachments/assets/fccec129-7773-44fe-b58a-9160879d3652" />

