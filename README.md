# Arduino-CSharp-Bluetooth-Control
The repository includes a "UserInterface" developed with C# programming language that controls an Arduino connected to a Bluetooth module. 
The repository also includes control of the Arduino's Bluetooth module.

"UserInterface" interface:

The "UserInterface" interface, coded in C# programming language, sends data to an Arduino connected via a Bluetooth module. The "UserInterface" includes a button to connect to the Arduino through Bluetooth, three radio buttons, and two trackbars.

1. If the "0+" radio button is selected, the first LED connected to the Arduino will turn on according to the value of trackbar-1, and the second LED will turn off.

2. If the "20+" radio button is selected, the first LED will turn off, and the second LED will turn on according to the value of trackbar-2.

3. If the "=20" radio button is selected, both the first and second LEDs will turn off.

Programming Language: C# Programming Language

Framework: .NET Framework 4.6.1

IDE: Visual Studio 2019

"BluetoothControl" application:

An Arduino is connected to a Bluetooth (HC-05) module and two LEDs. The "BluetoothControl" application controls the two connected LEDs based on the data received via Bluetooth. 
The data is sent by the "UserInterface" interface.

Programming Language: C/C++ Programming Language

IDE: Arduino IDE Version - 2.2.0

Arduino Used: Arduino Uno, Arduino Mega

Arduino Bluetooth Module: HC-05 Bluetooth Module