# ✅ TileMania — Student Progress Checklist
## CS 4700: Game Design Studio | Unity 6 + C#

**Name:** _______________________________  
**Date Started:** _______________________  
**Date Submitted:** _____________________

---

## How to Use This Checklist
- Check each box **as you complete it** — don't pre-check!
- Use the ⚠️ column to mark things you're stuck on and need help with
- Review the **Reflection Questions** at the end before submitting

---

## 📁 Section 1 — Project Setup

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ✅ | ☐ | Created Unity 6 project with **2D URP** template |
| ✅ | ☐ | Installed **Cinemachine** package |
| ✅ | ☐ | Installed **2D Tilemap Extras** (for Rule Tiles) |
| ✅ | ☐ | Created folder structure: Art/, Scripts/, Prefabs/, Audio/, Scenes/ |
| ✅ | ☐ | Imported or created placeholder sprites |
| ✅ | ☐ | Configured sprites: Filter Mode = Point, PPU = 16 |

**Section Notes:** _______________________________________________

---

## 🗺️ Section 2 — Tilemap World Building

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ✅ | ☐ | Created `Grid` with at least 3 Tilemap children (Ground, Hazards, Background) |
| ✅ | ☐ | Created a **Rule Tile** for the ground |
| ✅ | ☐ | Added at least 5 rules to the Rule Tile (edges, corners, center) |
| ✅ | ☐ | Painted a level with platforms, gaps, and elevation changes |
| ✅ | ☐ | Added **Tilemap Collider 2D** to Ground |
| ✅ | ☐ | Added **Composite Collider 2D** and enabled "Used By Composite" |
| ✅ | ☐ | Hazard Tilemap has collider with **Is Trigger: true** |
| ✅ | ☐ | Background Tilemap has Order in Layer = -1 |

**Section Notes:** _______________________________________________

---

## 🏃 Section 3 — Player Movement & Physics

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ✅ | ☐ | Player has: SpriteRenderer, Rigidbody2D, CapsuleCollider2D, Animator |
| ✅ | ☐ | Rigidbody2D: Collision Detection = Continuous, Freeze Rotation Z = true |
| ✅ | ☐ | `PlayerMovement.cs` attached and compiles without errors |
| ✅ | ☐ | `GroundCheck` child object created at bottom of player |
| ✅ | ☐ | Player moves left/right with A/D or arrow keys |
| ✅ | ☐ | Player jumps with Space and only when grounded |
| ✅ | ☐ | Sprite flips direction when moving |
| ✅ | ☐ | Better jump physics applied (fall feels snappy, tap = short jump) |

**Section Notes:** _______________________________________________

---

## 🎬 Section 4 — Player Animation

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ✅ | ☐ | `Player_Idle` animation clip created |
| ✅ | ☐ | `Player_Run` animation clip created |
| ✅ | ☐ | `Player_Jump` animation clip created |
| ✅ | ☐ | `Player_Fall` animation clip created |
| ✅ | ☐ | `Player_Death` animation clip created |
| ✅ | ☐ | Animator parameters set: `isRunning`, `isGrounded`, `yVelocity`, `die` |
| ✅ | ☐ | All transitions wired correctly (no floating states) |
| ✅ | ☐ | "Has Exit Time" unchecked on all movement transitions |
| ✅ | ☐ | Animations play correctly in Play Mode |

**Section Notes:** _______________________________________________

---

## 📷 Section 5 — Camera

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ✅ | ☐ | Cinemachine Virtual Camera added to scene |
| ✅ | ☐ | Camera follows player smoothly |
| ✅| ☐ | Camera confined to level bounds (CinemachineConfiner2D) |
| ✅| ☐ | Camera shake implemented in `CameraShake.cs` |
| ✅ | ☐ | Camera shakes when player takes damage |

**Section Notes:** _______________________________________________

---

## 🔲 Section 6 — Layers & Collision Matrix

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ✅ | ☐ | Created layers: Ground, Player, Enemy, Hazard, PlayerProjectile, EnemyProjectile |
| ✅ | ☐ | Ground Tilemap assigned to Ground layer |
| ✅ | ☐ | Player assigned to Player layer |
| ✅ | ☐ | Layer Collision Matrix configured (PlayerProjectile ✗ Player, Enemy ✗ Enemy) |
| ✅ | ☐ | PlayerMovement Ground Check uses correct layer mask |

**Section Notes:** _______________________________________________

---

## 👾 Section 7 — Enemy AI

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ✅ | ☐ | Enemy prefab created with Rigidbody2D, CapsuleCollider2D, Animator |
| ✅ | ☐ | Enemy assigned to Enemy layer |
| ✅ | ☐ | `EnemyPatrol.cs` attached, enemy moves left and right |
| ✅ | ☐ | Enemy turns at waypoint boundaries |
| ✅| ☐ | Enemy turns at ledges (no ground detected) |
| ✅ | ☐ | Enemy sprite flips direction correctly |
| ✅| ☐ | `EnemyHurt.cs` — touching enemy damages player |
| ✅ | ☐ | Enemy `Die()` plays animation and removes GameObject |
| ✅ | ☐ | At least **2 enemies** placed in the level |

**Section Notes:** _______________________________________________

---

## 🏹 Section 8 — Shooting System

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ✅ | ☐ | Arrow prefab created with Rigidbody2D (gravity 0), BoxCollider2D (trigger) |
| ✅ | ☐ | Arrow assigned to PlayerProjectile layer |
| ✅ | ☐ | `Arrow.cs` moves in correct direction |
| ✅ | ☐ | Arrow destroys on hitting an enemy |
| ✅ | ☐ | Arrow destroys on hitting ground |
| ✅ | ☐ | Arrow has max lifetime (auto-destroys after 3s) |
| ✅ | ☐ | `PlayerShooter.cs` fires on left-click (Fire1) |
| ✅ | ☐ | Fire rate limit prevents spam |
| ✅ | ☐ | Arrows fire in the direction the player faces |
|✅ | ☐ | `FirePoint` child object positioned correctly |

**Section Notes:** _______________________________________________

---

## ❤️ Section 9 — Health & Damage

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ✅ | ☐ | `PlayerHealth.cs` tracks current / max health |
| ✅ | ☐ | UI hearts update when player takes damage |
| ✅ | ☐ | Invincibility frames work after taking damage (flashing effect) |
| ✅ | ☐ | Player death triggers game over flow |
| ✅ | ☐ | `GameSession.cs` singleton persists across scenes |
| ✅ | ☐ | Lives system: death decrements lives, reloads scene |
| ✅ | ☐ | Out of lives → loads Game Over scene |
| ✅ | ☐ | Hazard tiles damage/kill player on touch |

**Section Notes:** _______________________________________________

---

## 🎬 Section 10 — Scenes & Game States

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ✅ | ☐ | Build Settings has all scenes in correct order |
| ✅ | ☐ | Main Menu scene with Start button works |
| ✅ | ☐ | Game Over scene exists and loads correctly |
| ✅ | ☐ | Level Exit triggers next level load |
| ✅ | ☐ | Win scene or win condition implemented |

**Section Notes:** _______________________________________________

---

## 🎵 Section 11 — Audio & Polish

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ✅ | ☐ | Background music loops on AudioSource |
| ✅ | ☐ | Jump SFX plays when player jumps |
| ✅ | ☐ | Shoot SFX plays when player fires |
| ✅ | ☐ | Damage SFX plays when player is hit |
| ✅ | ☐ | At least 1 particle effect (death, hit, collect, etc.) |

**Section Notes:** _______________________________________________

---

## 🎨 Quality Standards

### Technical Quality
| ✅ | Standard |
|:---:|---|
| ✅ | No null reference errors in Console during normal play |
| ✅ | All scripts organized in correct subfolders |
| ✅ | All tweakable values use `[SerializeField]` — no magic numbers |
| ✅ | Enemies are **prefabs** (not unique scene objects) |
| ✅ | Arrow is a **prefab** |
| ✅ | GameObjects are named clearly in Hierarchy |
| ✅ | Unused GameObjects/scripts removed |

### Design Quality
| ✅ | Standard |
|:---:|---|
| ✅ | Level has a clear start and end |
| ✅ | Level has varied terrain (high platforms, low areas, gaps) |
| ✅ | Difficulty ramps up through the level |
| ✅ | Player can distinguish hazards from safe ground visually |
| ✅ | Game is playable start to finish without bugs |

---

## 🚀 Extension Features (Optional — Choose 1+)

| ✅ | Difficulty | Feature |
|:---:|:---:|---|
| ☐ | 🟢 | Double jump |
| ☐ | 🟢 | Animated collectible coins/gems |
| ☐ | 🟢 | Multiple enemy types (reskins with different speeds) |
| ☐ | 🟡 | Checkpoint system |
| ☐ | 🟡 | Moving platform |
| ☐ | 🟡 | Enemy with ranged attack |
| ☐ | 🟡 | Score system with on-screen display |
| ☐ | 🔴 | Boss enemy with health bar |
| ☐ | 🔴 | Multiple levels (3+) with scene transitions |
| ☐ | 🔴 | Save system (high score persists between sessions) |

**Extension chosen:** _______________________________________  
**Brief description of what you added:** _______________________________________

---

## 📤 Submission Checklist

| ✅ | Task |
|:---:|---|
| ☐ | Project builds without errors (File → Build Settings → Build And Run) |
| ☐ | Game is playable from Main Menu to Game Over/Win |
| ☐ | Submitted GitHub repository link on Canvas |
| ☐ | Repository is **public** or instructor has been given access |
| ☐ | All 3 tutorial documents included in repo (`Tutorial.md`, `Checklist.md`, `QuickReference.md`) |
| ☐ | Completed **Reflection Questions** (below) |

---

## 🪞 Reflection Questions

Answer these in **2–4 sentences each**. These are the same questions you'll revisit across all four projects — track how your thinking evolves!

**1. What was your rapid prototype goal for this project?**

_______________________________________________________________
_______________________________________________________________

**2. How closely did your final game match your original prototype vision? What changed and why?**

_______________________________________________________________
_______________________________________________________________

**3. What is the most technically challenging thing you implemented? How did you solve it?**

_______________________________________________________________
_______________________________________________________________

**4. If you had one more week, what would you add or change?**

_______________________________________________________________
_______________________________________________________________

**5. How does your approach to game development now compare to when you started the course?**

_______________________________________________________________
_______________________________________________________________

---

## 🆘 Stuck? Try These Steps

**Before asking for help:**
1. ☐ Read the **error message** in Console carefully — it tells you the file and line number
2. ☐ Check the **Inspector** — is every serialized field assigned?
3. ☐ Check **Tags and Layers** — are layers set correctly?
4. ☐ Checked the **Layer Collision Matrix**?
5. ☐ Searched the error message in the Unity Docs or Discord?
6. ☐ Tried rubber-duck debugging (explain the code out loud line by line)?

**If still stuck:** Post in Discord with:
- Screenshot of the **Console error**
- Screenshot of the **Inspector** for the relevant GameObject
- The **script** causing the issue

---

*TileMania Checklist | CS 4700: Game Design Studio | Unity 6 + C#*
