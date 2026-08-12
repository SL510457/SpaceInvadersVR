# Space Invaders Template (VR)

A VR Space Invaders-style game built in Unity for Meta Quest, using controller input and grab interactions.

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
