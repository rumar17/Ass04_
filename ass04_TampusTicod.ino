int speed;
byte temp;
int longTemp;

int timeDelay = 1000;
byte sensorValue;
long currTime;

void setup() {
  // put your setup code here, to run once:
  analogReference(INTERNAL);
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

    /*if (millis() - currTime == timeDelay){

      currTime = millis();

      int sensorValue = analogRead(A0);

      Serial.println(sensorValue);
    }*/

    

  }




  if (millis() - currTime >= timeDelay){

    Serial.flush();

    currTime = millis();

    sensorValue = (analogRead(A0) >> 2);

    Serial.println(sensorValue);
  }


  // Read the analog value from LM35 sensor
  //int sensorValue = analogRead(A0);

  // Convert the analog value to temperature in Celsius
  /*float temperature = (sensorValue * 0.00488) * 100.0;

  // Display temperature on Serial Monitor
  Serial.print(sensorValue);
  Serial.print(" | ");
  Serial.print("Temperature: ");
  Serial.print(temperature);
  Serial.println(" °C");*/

}
