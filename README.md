# Arduino-C-RFID-Automative-SignIn
I've created a new Arduino RFID project to automatically sign in using a SQL database, Arduino, RFID arduino attachment, and C#


Thanks For Downlaoding this Project of mine. 
This Current Version is not yet finished, If you know C# feel free to edit 
The project.

*******************************things I need to do*******************************

TODO:
Add Database
Add textbox and buttons to add new UID List to database

*********************************************************************************

**************************************SETUP**************************************
Step 1:
Setup the arduino RFID Datasheet is below.

Step 2:
Open the Arduino Code and Flash your Arduino.
Test that is worked by opening the serial monitor and scanning the card.
If it worked, it'll send you the UID of the card.

Step 3:
choose which is easier for you.
Open the C#.Net folder and run the .sln code uing Visual Studio then hit 'PLAY'
or open C#.Net\ArduinoC#Code\obj\Debug\Testing_New_Include.exe

Step 4:
Choose the Com port your arduino is on, select 9600 for the Baud rate.
Press the 'Open Port' button then scan your RFID card.
After scanning the RFID press the read button the read what the arduino read.


*************************Setting up Arduinos RFID Module*************************

SDA -- SCK -- MOSI -- MISO -- GND -- RST -- 3.3v
 ^      ^       ^      ^       ^      ^      ^
 ^      ^       ^      ^       ^      ^      ^
 ^      ^       ^      ^       ^      ^      ^
 ~10    13     ~11     12     GND    ~9     3.3v  



I hope you enjoy the project, I will update the project with a database and others that I know I need but forgot

If you have any questions feel free to contact me

Email: elliottdylan60@gmail.com






