# Project Description
This project is a virtual reconstruction of a Stockholm subway station. It will be used in a reasearch project that aims to understand how people react to different elements in enclosed spaces such as subway stations. 
The reconstruction of the subway station is based of Rådmansgatans subway station in Stockholm, but various elements have been added to alter the appearance, so it isn't an exact replica. See below:

![image]([https://github.com/JulianLey/MetropedInteractive/assets/146943186/d078cfb4-b84c-4bf1-a09f-6e94f1f2a1de](https://github.com/DonkeyKongLeif/MetropedInteractive-main/blob/main/IngameImage1.jpg))


A menu has also been added so that various elements (such as the glass walls lining the rails) can be removed and added for comparison. In the same menu the user also has the possibility to rate the current setup, which is only used in a VR user study that I will run in November of 2024. The appearance of this menu has changed, so the image below does not exactly reflect the current menus:

![image]([https://github.com/JulianLey/MetropedInteractive/assets/146943186/d078cfb4-b84c-4bf1-a09f-6e94f1f2a1de](https://github.com/DonkeyKongLeif/MetropedInteractive-main/blob/main/pvkmeny.jpg))


The results are then saved locally to a JSON file (The adress of this file is written out in the console when you rate and save a setup. See console for the path if you have trouble finding this file). This will look something like this (Here too there have been minor changes, but largely the same):

The participant will be able to move through the scene with the WASD keys and in VR.
There are also moving trains and a virtual crowd that move through the scene.

![image]([https://github.com/JulianLey/MetropedInteractive/assets/146943186/760bb78e-7ad5-4149-836d-aaea4105e30f](https://github.com/DonkeyKongLeif/MetropedInteractive-main/blob/main/2025-05-16%20(1).png))

# Installation Instructions
- Install Unity Hub on your computer.
- Install editor version 2022.3.18f1
- Clone the repository to your local computer
- Open the cloned project folder (MetropedInteractive) in Unity Hub using the "Add from disk" button
- Open the project with the 2022.3.18f1 editor
- In the project window navigate to "Assets" and doubleclick "FinalScenePVK" to open the scene

# Running a basic version of the project
- Press on the play button in the Editor
- Navigate to the ribbon at the top of the Game View window and make sure Display 1 is selected

# Notes to students and other people working with this model

- If you have access to the github page I suggest forking the repository as the main branch is locked for everyone except me.
- For many of you, the User interface may actually get in the way. It can safely be removed on your local device if that is the case.
  - Alternatively you can click on the 'scenario manager' and uncheck the 'Scenario Picker' script. This will prevent the different scenarios from running.
 
- To test the system initially I recommend that you **deactivate the VR and skip the scenarios** <- Important


Good luck with your projects!

<br>

Best,<br>
Julian Ley

(contact@julianley.com)

