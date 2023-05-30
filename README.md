# Cube Surfer

Cube Surfer is an exciting mobile game that takes players on a captivating adventure through an obstacle-filled course. With its engaging gameplay, stunning visuals, and dynamic level design, Cube Surfer offers a thrilling experience that keeps players hooked and entertained.

In Cube Surfer, players assume the role of a cube-shaped character, embarking on a challenging journey through a world of cubes and obstacles. The objective is to collect cubes strategically while maneuvering through a variety of obstacles, including walls, spinning and moving platforms, and more. Each level presents new challenges and surprises, testing the players' reflexes, agility, and strategic thinking.
## Team Members

- Mazen Ehab Hassan Elbeik (19290872). [Github account](https://github.com/mazenbeik1)
- Ribhi Bishtawi (20290078). [Github account](https://github.com/ribhy-bishtawi)
- Ali Furkan Karaman (19290029). [Github account](https://github.com/AlifurkanKaraman)

## Installation

To play Cube Surfer, follow these steps:

1. Clone the repository.
2. Open the project in Unity 2020.3.
3. Build and run the game on your preferred platform.
* Note: Make sure you have the necessary Unity version (2020.3) and screen resolution (9:16) to ensure optimal gameplay experience.

### Gameplay

- Move character by swiping left or right on the screen
- Character moves forward at a constant speed (adjustable in the editor)
- Collect and stack cubes
- Player starts with 1 cube
- Cubes are placed on the bottom floor, stacking upwards

## Phases

### Phase 1

##### Applying phases timely:
- With the utmost speed, the task of timely implementing phases which included mailing, star repositories, and communication was completed successfully one week before the deadline.
##### Core Mechanic + input + gameplay feelings:
- Our team gave the Core Mechanic, input options, and gameplay sensations careful consideration, resulting in a unique and engaging user experience. We made sure that the Core Mechanic seamlessly matched the targeted gameplay goals by carefully smoothing it. Players were able to navigate and engage with the game with ease thanks to the use of easy input controls. Additionally, by boosting gameplay experiences like responsiveness, smoothness, and feedback, we were able to create a fascinating gameplay experience for the players we were targeting. We effectively attained a high degree of pleasure in terms of the Core Mechanic, input controls, and overall gameplay feelings through careful thought and incremental adjustments.
##### Code Quality and Keeping project tidy:
- Throughout the development process, our team paid close attention to maintaining a clean project structure and guaranteeing high code quality. Following best practices, we used a modular code design, meaningful variable and function names, and consistent coding rules. We maintained a high level of code quality, providing stable functioning and minimizing errors by following to strict code reviews. By arranging files, directories, and assets in a logical and intuitive way, we also kept the project structure tidy. This made collaboration simple and simplified ongoing maintenance and scalability. Our drive to provide a dependable, maintainable, and effective solution is shown in our attention to code quality and project organization.
##### Effects and Animations:
- Our project demonstrates careful attention to detail in the area of Effects and Animations, providing players with a fascinating and immersive experience. We gave the game's numerous components life and energy by combining visual effects, particle systems, and animations. The mood was made more engaging and visually appealing by the thoughtfully chosen and applied effects. To provide a fluid and pleasurable gameplay experience, we devoted close attention to smooth transitions, fluid animations, and clean visual feedback.
##### UI and UX flow:
- We carefully considered the UI and UX flow of Cube Surfer to provide players with a fluid and exciting experience while including multiple interactive features.
- We have a fail scenario that detects if the height of the cubes is less than the height of the wall when the player collides with it. Lower cubes cause the game to end; higher cubes cause the lower cubes to fall below the wall.
- We have a speed booster in the game to increase excitement and variety. The player's speed rises when they contact the speed booster, increasing the gameplay and providing an exciting feeling of increased speed.
- To encourage players, we have also included a scoring system. The player's score rises by one when they collide with gems, rewarding good interactions and giving them a sense of accomplishment.
- In the event of a game over, we have created a restart option that enables players to immediately start a new gaming session and carry on their quest.
- We have included a visually appealing screen that recognizes winners as they cross the finish line. In order to preserve a seamless transition between levels, this screen displays a 'Next Level' text that indicates their progression to the following level.
- We developed an engaging and dynamic gameplay experience that keeps players interested and inspired to explore the game by taking into account these UI and UX components.
##### Game Design and Level Design:
- As a result of our project's comprehensive consideration of both Game Design and Level Design, players will have a fun and varied gameplay experience. To create a difficult yet fun journey, we carefully developed the game mechanics, obstacles, and level advancement.
- We have integrated a variety of game design components that improve gaming dynamics. The immersive experience is enhanced by the use of cubes, gems, lava, walls, moving walls, spinning walls, spinning moving walls, and game boosters. Each barrier was individually created and put into place, providing the players with special difficulties and interactions. Players must modify their techniques and skills as they advance due to the variety of obstacles, which deepens and drives up the gameplay.
- The players' development and learning curve are carefully taken into account when designing our levels. Each level is carefully designed to offer a unique set of difficulties and include brand-new components. For instance, we added walls of different color to Level 2 to enhance visual variation and offer a unique gameplay experience. The placement, structure, and difficulty of obstacles are carefully planned to produce stages that get progressively more challenging. A fair challenge was intended, but we also wanted to make sure that the gameplay was still fun and rewarding.
- We have worked hard to offer a game experience that is both interesting and enjoyable through our thorough Game Design and Level Design approach. Our goal is to maintain players' immersion, motivation, and eagerness to explore each new level by carefully designing the mechanics, challenges, and level advancement.

### Note: Test Ads
Please be aware that all the photos and images used in this project, including the interstitial ads, are for testing purposes only. These test ads are not actual advertisements provided by the Huawei plugin. They have been included to demonstrate the functionality and placement of interstitial ads within the Cube Surfer game during the development and testing phases.

### Phase 2

##### Integrate EvilMindDevs/hms-unity-plugin:
  - Interstitial Ads at every end of the level:
    - |   |  |
      | ------------- | ------------- |
      |![InterAd1](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/6e308895-9aff-4aa8-a30c-a7737c0de51c)  |  ![InterAd2](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/c989aecd-430f-4f34-b0d8-47035984f6c8)|
  - Rewarded Ads for gameplay:
    - In this example, the user will have the option to resume the game at level 2 if they decide to watch the advertisement. The game will start over at level one if they choose not to view the advertisement.
    - |   |  |
      | ------------- | ------------- |
      | ![NativeAds2](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/eec755d0-6bbf-47fa-a486-dd73bfdc1fdd)| ![RewardedAd](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/3b71a7d5-48a7-49f6-af3c-989de7b39d77)|
  - Native Ads Integration:
    - |   |  | |
      | ------------- | ------------- | ------------- |
      |![NativeAds](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/2bf8e5d4-fe0f-4d73-9d76-efe94a16ab47)|![NativeAds3](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/b107cc2b-ab72-47ac-834b-9368b638791b)| ![NativeAds2](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/ce6c384a-73a2-493e-80c5-df9aae036408)|
  - Banner Ads Integration:
    - |   |  |
      | ------------- | ------------- |
      |![BannerAD](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/b0cd0399-5e31-4955-a620-d0c9c0a1f34a)| ![BannerAd2](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/1e16c869-2024-4c48-ac7c-224cd86cc220)|

##### Integrating IAP Kit: 
  - Consumable Product Integration: 
    - By providing this payment option, player can use these gems to buy cube colors or something like that in the future.
    - |   | |
      | ------------- | ------------- |
      |![IAP1](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/4c5c7ad8-03ab-44be-88a0-f38751437961)| ![gems](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/82064494/052025bb-abd0-4219-a0f4-32e92d36112f) |


  - NonConsumable Product Integration:
    - Players in the game have the choice to buy advertising permanently removal once throughout the game. Ads won't show up when they're playing after they purchase this feature. The UI of the game will alter to demonstrate the removal of adverts: one version will feature ads, while the other version won't. Additionally, to show that the user has made the purchase, a number "1" will appear next to the advertisements symbol. To prevent confusion, the player's purchase will disable the ad removal purchase button. In this manner, gamers can have uninterrupted gaming experience.
    - |   |  |
      | ------------- | ------------- |
      |![IAP1](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/475a1daa-cd7b-4926-aafe-31374076b180)|![IAP2](https://github.com/mazenbeik1/CubeSurfer-Assets/assets/30291556/a34d3976-319f-4518-bbd8-ac46ff83df69)|
##### Releasing app on App Gallery:
  - Application Store Page Quality:
  - Downloadable and Playable with all functionalities:

## References

- Documentation: [EvilMindDevs/hms-unity-plugin](https://evilminddevs.gitbook.io/hms-unity-plugin/)
- Video Tutorial: [YouTube - Unity HMS Plugin Tutorial](https://www.youtube.com/watch?v=ZskQf4quNhU&ab_channel=AlihanErsoy)
- Reference Articles: [EvilMindDevs/hms-unity-plugin - Reference Articles](https://evilminddevs.gitbook.io/hms-unity-plugin/references/reference-articles)
- Reference Project: [Bunyamin Eymen - Project](https://github.com/bunyamineymen/Lesson_DevelopingMobileGames_2022-2023_Spring/tree/main/_Project)
