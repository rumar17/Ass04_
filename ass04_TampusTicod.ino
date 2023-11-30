int speed;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(3, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() > 0){

    speed = Serial.parseInt();
    
    if (Serial.read() == '\n') {
      // If a newline character is received, indicating the end of the integer
      analogWrite(3, speed);
    }
    //analogWrite(3, 255);
  }
}
