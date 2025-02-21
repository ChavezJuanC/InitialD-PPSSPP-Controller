InitialD-PPSSPP-Controller

This is a fun little project I put together to use an Arduino Uno as a custom controller for the PPSSPP emulator, specifically with Initial D, my favorite racing game! 🚗💨

The Arduino sends signals through a serial port, which a C# script captures and remaps into keystrokes for the game. Everything is wrapped in a Windows Forms GUI to make it easy to use.
How It Works

    An Arduino Uno is connected and flashed with the correct firmware.
    The Arduino sends input signals through a serial connection.
    A C# script reads these signals and translates them into keystrokes.
    The emulator receives the mapped keys, letting you play Initial D with your custom setup.

Getting Started
1. Install Dependencies

    Windows
    .NET Framework 4.7.2 (or later)
    Arduino Uno with the correct firmware uploaded
    PPSSPP Emulator
    USB Connection to Arduino

2. Setting Up the Project

    Clone the repository:

git clone https://github.com/ChavezJuanC/InitialD-PPSSPP-Controller.git  

Navigate to the project folder and open ControllerGUI.sln in Visual Studio.

Edit the Serial Port Setting:

    Go to:

InitialD-PPSSPP-Controller/ControllerGUI/ControllerGUI/KeyStrokesMapper.cs  

Find this line:

        private const string comPort = "COM4";  

        Change "COM4" to match the correct COM port for your Arduino.

    Build and run the project from Visual Studio.

Running the GUI

Once the Windows Forms app is running:

    Make sure the Arduino is connected and on the correct COM port.

    Open PPSSPP and go to Control Settings.

    Ensure that the keybinds in the GUI match the keybinds you’ve set in PPSSPP.
        The GUI lets you define which keystrokes are sent when the Arduino detects inputs.
        Make sure these keystrokes match what PPSSPP expects (e.g., if PPSSPP is set to use Arrow Keys for steering, the GUI should send those keys).

    Start racing in Initial D using your custom Arduino setup!

Circuit Setup

Check out the photos folder for wiring and setup images.
Just for Fun

This was a simple but fun project—tinkering with things like this is what I love about programming. It’s not perfect, but it works, and it was a blast to put together! If you love Initial D like I do, you might enjoy giving it a try. 😃
