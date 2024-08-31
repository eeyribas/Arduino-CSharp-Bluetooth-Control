#include <SoftwareSerial.h>

SoftwareSerial bluetooth(1, 0);

int input_pin_1 = 8;
int input_pin_2 = 9;

void setup() 
{
  bluetooth.begin(9600);
  pinMode(input_pin_1, OUTPUT);
  pinMode(input_pin_2, OUTPUT);
}

void loop() 
{
  if (bluetooth.available()) {
    int data = bluetooth.read();

    if (data > 0) {
      if (data == 20) {
        digitalWrite(input_pin_1, LOW);
        digitalWrite(input_pin_2, LOW);
      } else if (data > 0 && data < 20) {
        digitalWrite(input_pin_1, HIGH);
        digitalWrite(input_pin_2, LOW);
      } else {
        digitalWrite(input_pin_1, LOW);
        digitalWrite(input_pin_2, HIGH);
      }
    }
  }
}