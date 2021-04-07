#include <Arduino.h>

#define BLUE 11
#define GREEN 10
#define RED 9

void setup()
{
pinMode(RED, INPUT);
pinMode(GREEN, INPUT);
pinMode(BLUE, INPUT);
digitalWrite(RED, HIGH);
digitalWrite(GREEN, LOW);
digitalWrite(BLUE, LOW);
Serial.begin(9600);
}

// define variables
int redValue = 0;
int greenValue = 0;
int blueValue = 0;
String serialInput;
// main loop
void loop()
{
  if (Serial.available() > 0) {
    // read the incoming byte:
    serialInput = Serial.readString();

    // say what you got:
    Serial.println("I received: " + serialInput);
		//redValue = serialInput.substring(0,3).toInt();
		//greenValue = serialInput.substring(3,6).toInt();
		//blueValue = serialInput.substring(6,9).toInt();
    // Get rid of '#' and convert it to integer
    long number = strtol( &serialInput[1], NULL, 16);

// Split them up into r, g, b values
    redValue = number >> 16;
    greenValue = number >> 8 & 0xFF;
    blueValue = number & 0xFF;
    //Invert the incoming values as it appears due to being a common cathode, I have to invert the value
    redValue = 255 - redValue;
    greenValue = 255 - (greenValue/2);
    blueValue = 255 - (blueValue/2); // Had to knock the blue and green down a bit as it was overpowering the red

    Serial.println(String(redValue) + "." + String(greenValue) +"."+ String(blueValue));
  }
analogWrite(RED, redValue);
analogWrite(GREEN, greenValue);
analogWrite(BLUE, blueValue);

}

