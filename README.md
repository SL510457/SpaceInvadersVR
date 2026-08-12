# Space Invaders Template (VR)

A VR Space Invaders-style game built in Unity for Meta Quest, using controller input and grab interactions.

## Demo

📺 [Watch the gameplay video](https://www.youtube.com/watch?v=19UlvniVfoo)

## Gameplay

Point the gun with your VR controller and pull the trigger to shoot down waves of enemies. The game spawns a 3D grid of "Space Invaders"-style enemies alongside a second enemy type ("Zombunny"); clear every enemy on screen to win, or lose if they overwhelm you first. A UI panel tracks how many enemies remain and lets you shoot it to start a new round or restart after game over.

## Features

- **VR shooting mechanics** — aim and fire using the Quest controller's index trigger, with bullets spawned and launched via physics
- **Grab interaction** — objects in the scene can be picked up and held using `OVRGrabbable`-based hand grabbing
- **Haptic feedback** — controller vibration on firing, driven by `OVRHaptics`
- **Wave-based enemy spawning** — a configurable 3D grid (rows × columns × layers) of enemies generated at the start of each round
- **Two enemy types** — classic grid-formation invaders plus a second "Zombunny" enemy with its own movement and health logic
- **Game state management** — Not Started → Playing → Game Over / Won, with UI text and audio feedback for each state

## Requirements

- Unity **2022.3.10f1** (or a compatible 2022.3 LTS patch)
- [Meta XR / Oculus Integration SDK](https://assetstore.unity.com/packages/tools/integration/meta-xr-all-in-one-sdk-269657) from the Unity Asset Store

## Setup

1. Clone this repo.
2. Open the project in Unity 2022.3.10f1 via Unity Hub.
3. Unity will resolve the standard packages listed in `Packages/manifest.json` automatically.
4. Download and import the **Meta XR / Oculus Integration SDK** from the Asset Store into `Assets/Oculus/`. This SDK is **not included** in this repo (see [Why isn't the Oculus SDK included?](#why-isnt-the-oculus-sdk-included)).
5. Open the main scene: `Assets/SpaceInvader/SpaceInvadersGame.unity`.
6. Build/run on a Meta Quest device, or use Unity's XR simulator for testing without a headset.

## Project structure

- `Assets/SpaceInvader/` — game code, prefabs, models, and the main scene (original work)
- `Assets/Textures/`, `Assets/Models/`, `Assets/Audio/` — supporting art/audio assets
- `Assets/Oculus/` — **not tracked in git**, see setup step 4

## Why isn't the Oculus SDK included?

The Meta/Oculus Integration SDK is a large (~900MB) third-party package distributed by Meta through the Unity Asset Store, with its own license terms. To keep this repo small and avoid redistributing third-party code, it's excluded via `.gitignore` — reinstall it locally following the setup steps above. Scripts such as `PlayerController.cs` and `ObjectGrabDetect.cs` depend on it (`OVRInput`, `OVRGrabbable`, `OVRHaptics`), so the project won't compile until it's imported.
