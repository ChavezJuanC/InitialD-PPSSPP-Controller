int joyPin1 = A0;
int joyPin2 = A1;

int accelerationPin = 7;
int brakePin = 8;

int value1 = 0;
int value2 = 0;
int accelerationRead = LOW;
int brakeRead = LOW;


void setup() {
  // put your setup code here, to run once:
  pinMode(accelerationPin, INPUT);
  pinMode(brakePin, INPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  value1 = analogRead(joyPin1);
  delay(100);
  value2 = analogRead(joyPin2);

  accelerationRead = digitalRead(accelerationPin);
  brakeRead = digitalRead(brakePin);

  if (value1 < 526) {
    Serial.println("8");  // up
  } else if (value1 > 528) {
    Serial.println("9");
  }

  if (value2 < 514) {  //GOING RIGHT
    if (accelerationRead && brakeRead) {
      Serial.println("0");  //accelarate + brake + right
    } else if (accelerationRead) {
      Serial.println("1");  //accelarate + right

    } else if (brakeRead) {
      Serial.println("2");  //brake + right
    } else {
      Serial.println("3");  // just right
    }
  } else if (value2 > 516) {
    if (accelerationRead && brakeRead) {  //GOING LEFT
      Serial.println("4");                //accelarate + brake + left
    } else if (accelerationRead) {
      Serial.println("5");  //accelarate + left

    } else if (brakeRead) {
      Serial.println("6");  //brake + left
    } else {
      Serial.println("7");  // just left
    }
  } else {
    if (accelerationRead && brakeRead) {  //GOING STRAIGHT
      Serial.println("A");                //accelarate + brake
    } else if (accelerationRead) {
      Serial.println("B");  //accelarate
    } else if (brakeRead) {
      Serial.println("C");  //brake
    } else {
      //idle
      Serial.println("I");
    }
  }
}