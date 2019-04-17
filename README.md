# Mobile Applications 3 in 1 Project - By Alex Cherry, G00347106

This project has been transferred from another repository as there has been some major changes.

The project is a 3 in 1 game app, where the user can pick which game they would like to go to and play! It is based on speed, accuracy and reflexes.

The target audience for this application is older people looking for brain training exercises or younger people who are just killing time between study sessions.

## Main Page

The first page allows you to input your name and age and will show a label displaying the users name. Once these are entered then the Enter Info button can be clicked and the game page buttons become available to play. This is done by using boolean values with true/false enablers. It also has 3 buttons to go to which game you would like to play. There is a "Rules" button on each of the game pages to show users how to play.

## Game One - Speed

The first game in the application is a click counter. The user will have two buttons, one to click "Start Game 1" and the next to starting clicking labeled "Click fast!". Once the "Start Game 1" button is clicked, the user will have to click the "Click fast!" button as fast as they can for 5 seconds. The button will become unclickable after 5 seconds, and text will appear and tell the user the amount of clicks they did in 5 seconds. This is done by using a timer function in the System.Diagnostics and a counter for every time the button is clicked. It also shows the amount of clicks done per second. This is a simple division function. The "Start Game 1" button will become available again and the user can try again.

## Game Two - Accuracy

The second game in the application is a typing speed test. The user will have two buttons and a text box. The "Start Game 2" button should be clicked to start the game. A random string selected from 5 strings will appear on the screen. The user will have to type the string that is given into a text box. These strings are taken from an array of strings with a randomized function. As soon as you click "Start Game 2" the timer starts, so the user must be fast. If the exact string has been typed in, then the user will get a message displaying how long it took them to type the string. This is done using a Stopwatch function in the System.Diagnostics. The button will become unavailable and the time will display on how long it took the user to type in the string. If the text is incorrect, the timer continues and the user will have to fix the string and this will slow down their time.

## Game Three - Reflex

The third game in the application is a reflex game. The user will have two buttons on the screen. The "Click Now!" button is available and this will be the only button the user can click. Once this is clicked, the "Ready Up!" button becomes available. This must be clicked and the user must be prepared to click on the text. A random Stopwatch function makes the button appear in between 3 and 10 seconds. This is done the same way as the second games Stopwatch function in the System.Diagnostics. When the button is clicked, the user will get text saying how long it took them to react.
