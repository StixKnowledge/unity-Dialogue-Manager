# Unity Dialogue Manager

A simple and reusable dialogue system for Unity using C# and TextMeshPro.  
This system allows players to navigate dialogue using Previous, Next, and Finish buttons.

---

## Features

- Simple dialogue navigation
- Previous and Next button support
- Automatic Finish button activation
- Easy Inspector setup
- TextMeshPro support
- Beginner-friendly

---

## Requirements

- Unity 2020 or higher
- TextMeshPro Package
- Unity UI System

---

## Installation

1. Download or clone this repository.

```bash
git clone https://github.com/yourusername/unity-dialogue-manager.git
```

2. Open your Unity project.

3. Import the script into your project.

4. Import TMP Essentials:
   - Window → TextMeshPro → Import TMP Essentials

---

## Setup Guide

### 1. Create the UI

Inside your Canvas:

- Create a Panel
- Add a TextMeshPro Text object
- Add 3 Buttons:
  - Previous
  - Next
  - Finish

---

### 2. Attach the Script

1. Create an Empty GameObject
2. Rename it to `DialogueManager`
3. Attach `DialogueManager.cs`

---

### 3. Assign References

In the Inspector:

| Field | Assign |
|------|------|
| Dialogue Text | TMP Text |
| Prev Button | Previous Button |
| Next Button | Next Button |
| Finish Button | Finish Button |

---

### 4. Add Dialogue Lines

Under `Dialogue Content`, add your dialogue messages.

Example:

```text
Hello player!
Welcome to the game.
Good luck on your adventure!
```

---

## Button Functions

Assign the button OnClick events:

| Button | Function |
|------|------|
| Previous | ShowPreviousLine() |
| Next | ShowNextLine() |
| Finish | FinishDialogue() |

---

## Example Use Cases

- NPC conversations
- Tutorials
- Story dialogue
- Visual novels
- Interactive lessons

---

## Future Improvements

- Typing effect
- Dialogue portraits
- Sound effects
- Branching dialogue choices
- JSON dialogue support

---

## License

Free to use for educational and commercial projects.

---

## Author

Stix&Kno
