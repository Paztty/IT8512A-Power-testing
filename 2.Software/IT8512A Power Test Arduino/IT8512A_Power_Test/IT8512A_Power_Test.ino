
#include <SoftwareSerial.h>

#define PRESCALER                     64
#define TIMER                         10              //unit: milliseconds
#define START_COUNTER                 (65536 - (TIMER * 16 *(unsigned long)1000/PRESCALER))
int counter;
// Flag 
unsigned char cmd_fl = 0, size_of_response = 0;

// cmd
uint8_t cmd[] = { 0xaa, 0x00, 0x5f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09 };
uint8_t rcm[26] = {};
uint8_t retry_loop = 4;
String statusLabel = "stop";

SoftwareSerial mySerial(2, 3); // RX, TX

uint8_t check_turn;

void setup()
{

// Serial
Serial.begin(9600);
mySerial.begin(9600);
pinMode(13, OUTPUT);
digitalWrite(13, LOW);
//
  cli();                                // tắt ngắt toàn cục

  /* Reset Timer/Counter1 */
  TCCR1A = 0;
  TCCR1B = 0;
  TIMSK1 = 0;

  /* Setup Timer/Counter1 */
  TCCR1B |= (0 << CS12) | (1 << CS11) | (1 << CS10);  // prescale = 64
  TCNT1 = 0;
  TIMSK1 = (1 << TOIE1);               // overflow interrupt enable

  sei();
//



while(!Serial.available())
    {
    Serial.println("IDE");
    delay(100); 
    }
while(Serial.available())
    {
        if(Serial.read() == 'S')
            for (uint8_t i = 0; i < retry_loop; i++)
            {
                statusLabel = "start";
            }  
    }

}

void loop()
{
while(Serial.available())
{
    char command = Serial.read();
        if(command == 'S')
            {
               statusLabel = "run";
            } 
        if(command == 'E')
            {
                statusLabel = "stop";
            }

    if(statusLabel == "run")
    {
        if( command == 'A')
        {
            Serial.println("StartA");
            digitalWrite(13, LOW);
            delay(200);
            Serial.println("StartA");
            for (uint8_t i = 0; i < retry_loop; i++)
            {
                get_voltage();
            }
            Serial.println("DoneA");
        }
  
        if( command == 'B')
        {
            Serial.println("StartB");
            digitalWrite(13, HIGH);
            delay(200);
            Serial.println("StartB");
            for (uint8_t i = 0; i < retry_loop; i++)
            {
                get_voltage();
            }
            Serial.println("DoneB");
        }
    }
}

while(!Serial.available())
        {
        if(counter >= 500)
        {
            counter = 0;
            Serial.println(statusLabel);
            Serial.println("start");
        }      
    }
}

void get_voltage()
{
    re_try:
    uint8_t i;
    // Serial.print("Request :");
    if (cmd_fl == 0)
    {
        for (i = 0; i < sizeof(cmd); i++)
        {
            mySerial.write(cmd[i]);
        } 
    }

    delay(50);
    // Serial.println();
    // Serial.print("Recive :");
    i = 0;
    while (mySerial.available())
    {
        rcm[i] = mySerial.read();
        i++;
    }

    // for ( i = 0; i < sizeof(rcm); i++)
    //     {
    //         Serial.print(rcm[i],HEX);
    //         Serial.print(' ');
    //     }

    if ( check_sum(rcm) == 0x00)
    {
        //Serial.println(check_sum(rcm));
            // for ( i = 0; i <= sizeof(rcm); ++i)
            // {
            //     Serial.print(rcm[i]);
            //     Serial.print(' ');
            // }
        goto re_try;
    }
    else if (check_sum(rcm) == 0xff)
    {
        for ( i = 0; i < sizeof(rcm); ++i)
            {
            if(rcm[i] < 10)
                {
                    Serial.print('0');
                    Serial.print(rcm[i],HEX);               
                }
            else
                Serial.print(rcm[i],HEX);
            }

    }
    
    // Serial.println(convert_value(rcm));
     Serial.println(']');

}


uint8_t check_sum(uint8_t data[26])
{
    uint8_t i = 0;
    unsigned int sum = 0;
        for ( i = 0; i < 26 - 1; i++)
        {
            // Serial.print(data[i]);
            // Serial.print(' ');
            sum = sum + data[i];
        }
        // Serial.println();
        // Serial.println(sum,HEX);
        // Serial.println(sum % 256,HEX); 
        // Serial.println(data[25],HEX);               
        if (sum < 0xff )
        {
            if ( sum == data[25])
            {
            // Serial.println("check_sum OK");
            return 0xff;
            }
            else
            {
            // Serial.println("check_sum FAIL");
            return 0x00;
            }
            
        }
        else
        {
            if ( sum % 256 == data[25])
            {
            // Serial.println("check_sum OK");
            return 0xff;
            }
            else
            {
            // Serial.println("check_sum FAIL");
            return 0x00;
            }
        }
}


uint32_t convert_value(uint8_t data[26])
{
uint32_t OutData;
uint32_t buffer;
for (uint8_t i = 3; i < 9; i++)
{
    buffer = data[i];
    buffer = buffer >> (i-2)*8;
    //Serial.print(buffer);
    OutData = OutData + buffer;
}
//Serial.println(buffer,HEX);
//Serial.println();
return OutData;
}



ISR (TIMER1_OVF_vect)
{
  counter++;
  TCNT1 = START_COUNTER;
}
