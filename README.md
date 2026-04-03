# Roll A Ball Game - Midterm Project
**Developer:** SELMAN ERDOĞDU

## Development Diary & Steps
1. **Setting Up:** I started by creating the basic scene, setting up folders (Scripts, Scenes, Materials), and pushing the initial commits.
2. **Level Design (Bonus):** I designed a custom, multi-stage level to make the game more interesting:
   - Added a stairs section where the player collects 1 coin.
   - Created a long path section.
   - Built an obstacle course with 4 rotating objects where the player collects 7 coins.
   - Finally, I implemented an elevator mechanism that takes the player to the top to collect 1 giant coin!
3. **Visuals (Bonus):** I customized the materials for the obstacles, changed the ground colors, and updated the Skybox to give the game a unique and polished atmosphere.
4. **Mechanics & UI:** Wrote the C# scripts for player movement, camera tracking, and object rotation. Added a UI text to track the collected coins on the screen.

## What I Learned
During this project, I learned how to structure a Unity project properly and manage version control using Git and GitHub. I learned how to download assets and use them in Unity. I improved my C# skills by writing custom mechanics like rotating obstacles and moving platforms. I also learned how to use Triggers to collect items and how to manipulate Materials and the Skybox to change the game's mood.

## Challenges & Bug Fixes
- **Bug:** While testing the collectibles, the player ball was just passing through the coins without collecting them or increasing the score.
- **Fix:** I realized I forgot to check the "Is Trigger" box on the coin prefabs' Collider component and properly assign the tags. Once I checked "Is Trigger" and updated the script logic, it worked perfectly.

## AI Usage (Gemini)
I used AI (Gemini) as a brainstorming partner. I received help to logically plan my GitHub commit sequence so that my commit history is meaningful. I also got suggestions on how to structure this README file as a development diary, and received ideas for improving the visual environment (material colors and skybox settings) for extra points.
