#include <Servo.h>

char inData[20]; // Allocate some space for the string
char inChar=-1; // Where to store the character read
byte index = 0; // Index into array; where to store the character
int ledPin[2] = {13,8}; // the number of the LED pinServo
Servo airServo;
int airAngle = 25;
int scentAngle = 60;

void setup() {
    Serial.begin(9600);
    airServo.attach(9);
    airServo.write(90);
    pinMode(ledPin[0], OUTPUT); // set LED as output
    pinMode(ledPin[1], OUTPUT);
    digitalWrite(ledPin[0], LOW); //turn off LED
    digitalWrite(ledPin[1], LOW);
}

char Comp(char* This) {
    while (Serial.available() > 0) // Don't read unless
                                   // there you know there is data
    {
        if(index < 19) // One less than the size of the array
        {
            inChar = Serial.read(); // Read a character
            inData[index] = inChar; // Store it
            index++; // Increment where to write next
            inData[index] = '\0'; // Null terminate the string
        }
    }

    if (strcmp(inData,This)  == 0) {
        for (int i=0;i<19;i++) {
            inData[i]=0;
        }
        index=0;
        return(0);
    }
    else {
        return(1);
    }
}

void loop()
{
    if (Comp("131")==0) {
        Serial.println("LED 13 on");
        digitalWrite(ledPin[0], HIGH);
    }
    if (Comp("130")==0) {
        Serial.println("LED 13 off");
        digitalWrite(ledPin[0], LOW);
    }
    if (Comp("081")==0) {
         Serial.println("LED 8 on");
         digitalWrite(ledPin[1], HIGH);
    }
    if (Comp("080")==0) {
        Serial.println("LED 8 off");
        digitalWrite(ledPin[1], LOW);
    } 
    if (Comp("090")==0) {
      airServo.write(90);
    }
    if (Comp("091")==0) {
      airServo.write(90+airAngle);
    }
}
