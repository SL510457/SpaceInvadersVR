# Space Invaders Template (VR)

A VR Space Invaders-style game built in Unity for Meta Quest, using controller input and grab interactions.

## Demo

[![Watch the gameplay video](https://img.youtube.com/vi/19UlvniVfoo/maxresdefault.jpg)](https://www.youtube.com/watch?v=19UlvniVfoo)

## Gameplay

1. **Pick up the gun** — a green gun sits on the ground; grab it with your VR controller (you can also drop it and pick it back up).
2. **Start the game** — aim at the building in front of you and shoot it to begin.
3. **Clear the air targets** — a formation of 8 airborne "Elephant" enemies (black with yellow markings) spawns. Shoot down all of them to win.
4. **Survive the ground attack** — "Zombunny" enemies (blue glowing outline) spawn on the ground, detect your position, and walk toward you. Shoot them to avoid being attacked — but unlike the Elephants, you don't need to kill every Zombunny to win.
5. **Win the game** — once all Elephant enemies are destroyed, "You win the game!!!" is displayed.

## Features

- **VR shooting mechanics** — aim and fire using the Quest controller's index trigger, with bullets spawned and launched via physics
- **Grab interaction** — the gun (and other objects) can be picked up, held, and dropped using `OVRGrabbable`-based hand grabbing
- **Haptic feedback** — controller vibration on firing, driven by `OVRHaptics`
- **Wave-based aerial enemies** — a configurable 3D grid of "Elephant" enemies spawned at the start of each round; destroying all of them is the win condition
- **Pursuing ground enemies** — "Zombunny" enemies track the player's position and approach to attack, adding a separate threat to watch for and shoot down
- **Game state management** — Not Started → Playing → Game Over / Won, with UI text and audio feedback for each state

## Requirements

- Unity **2022.3.10f1** (or a compatible 2022.3 LTS patch)
- [Meta XR / Oculus Integration SDK](https://assetstore.unity.com/packages/tools/integration/meta-xr-all-in-one-sdk-269657) from the Unity Asset Store

## Setup

1. Clone this repo.
2. Open the project in Unity 2022.3.10f1 via Unity Hub.
3. Unity will resolve the standard packages listed in `Packages/manifest.json` automatically.
4. Download and import the **Meta XR / Oculus Integration SDK** from the Asset Store into `Assets/Oculus/`. It's a ~900MB third-party package with its own license, so it's excluded from this repo via `.gitignore` rather than redistributed — the project won't compile until it's imported.
5. Open the main scene: `Assets/SpaceInvader/SpaceInvadersGame.unity`.
6. Build/run on a Meta Quest device, or use Unity's XR simulator for testing without a headset.

## Project structure

- `Assets/SpaceInvader/` — game code, prefabs, models, and the main scene (original work)
- `Assets/Textures/`, `Assets/Models/`, `Assets/Audio/` — supporting art/audio assets
- `Assets/Oculus/` — **not tracked in git**, see setup step 4
