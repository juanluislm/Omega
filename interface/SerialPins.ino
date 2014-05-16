int ledPin[2] = {13,8}; // the number of the LED pin
//int ledPin = 13;
void setup() {
  Serial.begin(9600); // set serial speed
  pinMode(ledPin[0], OUTPUT); // set LED as output
  pinMode(ledPin[1], OUTPUT);
  digitalWrite(ledPin[0], LOW); //turn off LED
  digitalWrite(ledPin[1], LOW);
}


void loop(){
  while(Serial.available() == 0);
  int val = Serial.read() - '0';
  if(val == 3){
    Serial.println("LED 13 on");
    digitalWrite(ledPin[1], HIGH);
  }else if(val==2){
    Serial.println("LED 13 off");
    digitalWrite(ledPin[1], LOW);
  }else if(val == 1){
    Serial.println("LED 13 on");
    digitalWrite(ledPin[0], HIGH);
  }else if(val==0){
    Serial.println("LED 13 off");
    digitalWrite(ledPin[0], LOW);
  }else{ // if not one of above command, do nothing
    val = val;
  }
  Serial.println(val);
  Serial.flush();
  /*while (Serial.available() == 0); // do nothing if nothing sent
  int val = Serial.read() - '0'; // deduct ascii value of '0' to find numeric value of sent number

  if (val == 1) { // test for command 1 then turn on LED
    Serial.println("LED on");
    digitalWrite(ledPin, HIGH); // turn on LED
  }else if (val == 0) {// test for command 0 then turn off LED
    Serial.println("LED OFF");
    digitalWrite(ledPin, LOW); // turn off LED
  }else{ // if not one of above command, do nothing
    val = val;
  }
  Serial.println(val);
  Serial.flush(); // clear serial port*/
}
