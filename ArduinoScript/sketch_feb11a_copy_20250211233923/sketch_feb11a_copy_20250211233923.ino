int joyPin1 = A0;
int joyPin2 = A1;

int value1 = 0;
int value2 = 0;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  value1 = analogRead(joyPin1);
  delay(100);
  value2 = analogRead(joyPin2);

  if (value1 < 526) {
    Serial.println("1"); //down
  } else if (value1 > 528) {
    Serial.println("2"); //up
  }

  Serial.println("");

    if (value2 < 514) {
    Serial.println("3"); // left
  }
  else if (value2 > 516) {
    Serial.println("4"); // right
  }
}


/* 

So the idea is to write a C# or python script that monitors a serial port continously.. 
based on serial port coms, we will turn them into "key strokes"

*/
