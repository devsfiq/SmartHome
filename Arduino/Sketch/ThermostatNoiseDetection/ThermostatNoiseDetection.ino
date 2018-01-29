
//
//void setup()
//{
//    Serial.begin(9600);
//}
//
//void loop()
//{
//   digitalWrite(6, 1);
//   delay(1000);
//   digitalWrite(6, 0);
//   delay(1000);
//}

#include <math.h>

const int B = 4275;               // B value of the thermistor
const int R0 = 100000;            // R0 = 100k
const int pinTempSensor = A2;     // Grove - Temperature Sensor connect to A5
const int pinSoundSensor = A0;
int scounter = 0;
void setup()
{
    Serial.begin(9600);
}

void loop()
{
    int a = analogRead(pinTempSensor);
    int s = analogRead(pinSoundSensor);

    float R = 1023.0/a-1.0;
    R = R0*R;

    float temperature = 1.0/(log(R/R0)/B+1/298.15)-273.15; // convert to temperature via datasheet

    if (temperature > 30) {
      digitalWrite(3,1);
    }

    if (temperature < 26) {
      digitalWrite(3,0);
    }

    if (s > 1) {
      scounter++;
      if (scounter > 10) {
        digitalWrite(4,1);
      }
    }

    if (s == 0) {
      scounter--; 
      if (scounter = 0) {
        scounter = 0;
        digitalWrite(4,0);
      }
    }
    
    Serial.print("Temperature = ");
    Serial.println(temperature);
    Serial.print("Sound in voltage = ");
    Serial.println(s);
    Serial.print("Sound counter = ");
    Serial.println(scounter);

    delay(1000);
}

//int val;
//void setup()
//{
//    Serial.begin(9600);
//}
//
//void loop()
//{
//    delay(10);
//    val = analogRead(0);
//    Serial.println(val);
//    delay(100);
//}
