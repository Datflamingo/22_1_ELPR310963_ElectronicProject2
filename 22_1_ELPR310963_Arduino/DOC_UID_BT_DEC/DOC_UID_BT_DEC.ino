 #include<SPI.h>
#include<MFRC522.h>

#define RST_PIN 9
#define SS_PIN 10
int UID[4],i; 
int anodeLed_int = 8;
int kathodeLed_int = 7;
MFRC522 mfrc522(SS_PIN,RST_PIN);
void setup() 
{
  Serial.begin(9600);
  SPI.begin();
  mfrc522.PCD_Init(); // cho doc the 
  pinMode(anodeLed_int, OUTPUT);
  pinMode(kathodeLed_int, OUTPUT);
}

void loop() 
{
  digitalWrite(anodeLed_int, HIGH);
  digitalWrite(kathodeLed_int, LOW);
  if(! mfrc522.PICC_IsNewCardPresent())
  {
    return;
  }
  if(! mfrc522.PICC_ReadCardSerial())
  {
    return;
  }

 //Serial.print(' ');

  for(byte i=0;i< mfrc522.uid.size;i++)
  {
    Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? "0" : "");
    UID[i]=mfrc522.uid.uidByte[i];
    Serial.print(UID[i],DEC);
  }
  Serial.println();
  mfrc522.PICC_HaltA();
  mfrc522.PCD_StopCrypto1();

}
