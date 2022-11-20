 #include<SPI.h>
#include<MFRC522.h>

#define RST_PIN 9
#define SS_PIN 10
int UID[4],i; 
MFRC522 mfrc522(SS_PIN,RST_PIN);
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
SPI.begin();
mfrc522.PCD_Init(); // cho doc the 
}

void loop() {
  // put your main code here, to run repeatedly:
if(! mfrc522.PICC_IsNewCardPresent())
{return;}
if(! mfrc522.PICC_ReadCardSerial())
{return;}

 Serial.print(' ');

for(byte i=0;i< mfrc522.uid.size;i++)
{
  Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : "");
  UID[i]=mfrc522.uid.uidByte[i];
  Serial.print(UID[i],DEC);
  }
  Serial.println();

  // Dung doc the 
  mfrc522.PICC_HaltA();
  mfrc522.PCD_StopCrypto1();

}
