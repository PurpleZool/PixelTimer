# PixelTimer
Compact support component for game development, facilitating/showcasing possible management of day-night cycles with customizable day, month, and year duration.

# MainForm
Simple control that consumes the Engine.dll library, allowing the configuration of customizable values for the application, such as day duration in seconds, month duration in days, and year duration in months. 
The form displays the values given by the objects of the library, representing a small image in pixel format, applying transparency to a blue layer to represent night, and calculating the real and in-game date based on the given parameters.

Also manages different kind of schedulableObjects depending on their settings and in-game time by a scalable interface ISchedulable.

![image](https://user-images.githubusercontent.com/25660829/221896159-9a4d7327-bdd9-45af-8037-3dab04b790db.png)

# Engine
This library contains the necessary components to manage in-game time, as well as the month and year, depending on the applied time configuration. The GameTimer object allows for controlling time, as well as cycles and time-dependent objects such as streetlights or different businesses,IE.

```
            //Easy use
            GameTimer gameTimer = new GameTimer(dayLapse,monthLapse,yearLapse);             
            
            // Control scheduled objects 
            gameTimer.AddSchedulable(new BussinesClass1("Mill", millOpenHour, millCloseHour));
            gameTimer.AddSchedulable(new BussinesClass2("Thiefs", 19, 8));

            // Run
            gameTimer.StartTimer();
            
```            

# v0.0.1 Initial Development
Added initial basic functionalities for the representation of real-time and in-game time.

* MainCycles object for time control.
* GameTimer object for calculating time according to the configured time and for controlling timers and objects.
* ISchedulableObject for managing time-dependent objects.
