const int zelena = 7;
const int zuta = 8;
const int crvena = 13;
String command;

void setup() {
  Serial.begin(9600);
  pinMode(zelena, OUTPUT);
  pinMode(zuta, OUTPUT);
  pinMode(crvena, OUTPUT);
  digitalWrite(zelena, LOW);
  digitalWrite(zuta, LOW);
  digitalWrite(crvena, LOW);
  command = "";
  
}

void loop() {
  while(Serial.available()) {
    command += (char)Serial.read();
  }
  if(command == "ledsOff")
    SetLedsOff();
  else if(command == "win")
    SetLedOn(zelena);
  else if(command == "draw")
    SetLedOn(zuta);
  else if(command == "lose")
    SetLedOn(crvena);

  command = "";
}

void SetLedOn(int led) {

  switch(led) {
    case zelena :
      digitalWrite(zelena, HIGH);
      digitalWrite(zuta, LOW);
      digitalWrite(crvena, LOW);
      break;
    case zuta :
      digitalWrite(zelena, LOW);
      digitalWrite(zuta, HIGH);
      digitalWrite(crvena, LOW);
      break;
    default :
      digitalWrite(zelena, LOW);
      digitalWrite(zuta, LOW);
      digitalWrite(crvena, HIGH);
      break;
  }
}

//
// Turn off the leds
//
void SetLedsOff() {  
  digitalWrite(zelena, LOW);
  digitalWrite(zuta, LOW);
  digitalWrite(crvena, LOW);
}
