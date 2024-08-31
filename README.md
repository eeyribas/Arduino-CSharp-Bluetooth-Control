# Arduino-CSharp-Bluetooth-Control
Arduino-CSharp user interface is an example of Bluetooth control. The user interface, programmed in C#, sends data to an Arduino connected with a Bluetooth module. Based on the received data, the Arduino controls two LEDs, turning them on or off.
In the C# user interface, there is a button to connect to the Arduino Bluetooth module. The interface includes three radio buttons and two trackbars.
If the "0+" radio button is selected, the LEDs connected to the Arduino will turn off according to the value of trackbar-1.
If the "20+" radio button is selected, the first LED will turn off and the second LED will turn on according to the value of trackbar-2.
If the "=20" radio button is selected, the first LED will turn on and the second LED will turn off.

C# IDE: Visual Studio 2019

C# Framework: .NET Framework 4.6.1

Arduino Used: Arduino Uno, Arduino Mega

Arduino IDE Version: 2.2.0

Arduino Bluetooth Module: HC-05 Bluetooth Module