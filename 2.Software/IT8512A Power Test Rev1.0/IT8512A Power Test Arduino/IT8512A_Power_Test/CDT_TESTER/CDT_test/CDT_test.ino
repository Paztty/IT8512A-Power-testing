
#include <avr/wdt.h>

//define constant
#define         enable          1
#define         disable         0
#define         connected       1
#define         disconnected    0        
#define         chanel_DONE     1
#define         chanel_TEST     0  

//define pin
#define          Buzzer_ON       1
#define          Buzzer_OFF      0
#define          Buzzer_Pin      9
    uint32_t Buzzer_counter;
    uint8_t Buzzer_Enable = disable;
    uint8_t Buzzer_Status = disable;

#define          Relay_ON        1
#define          Relay_OFF       0
#define          Relay_Pin       8

//address of arduino
#define             arduino_address 1

// communicate func_code define
#define             online_check    0
#define             read_data       1
#define             status          2
#define             chanel_set      3
#define             ready_test      4
#define             RBStatus        5
#define             RBSet           6

// communicate data define
//read data : $ + arduino_address + read_data + chanel1_sellect + response_data // or user RESPONSE function
    #define             chanel1_sellect     1
    #define             chanel2_sellect     2
// Status:
    #define             two_chanel_NG       00
    #define             chanelA_OK          10
    #define             chanelB_OK          01
    #define             two_chanel_OK       11
//set number of chanel to meansuare voltage. $ + arduino_address + chanel_set + set_1_chanel + check_sum // or user SET_CHANEL function 
    #define             set_1_chanel        1
    #define             set_2_chanel        2
// status for testing: $ + arduino_address + ready_test + ready_for_test/no_connect_battery + check_sum //or user READY_TEST function 
#define             ready_for_test      11
#define             no_connect_battery  00
#define             lost_input_1        01
#define             lost_input_2        10

#define             relay_fail           2                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        1
#define             buzzer_fail          3

// timer for sevice
#define PRESCALER                     64
#define TIMER                         100              //unit: milliseconds
#define START_COUNTER                 (65536 - (TIMER * 16 *(unsigned long)1000/PRESCALER))


uint32_t turn_test_counter;  //retry test counter

uint8_t cmd[] = { 0xaa, 0x00, 0x5f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09 };
uint8_t rcm[26] = {};
uint8_t retry_loop = 4;
uint8_t set_number_of_chanel = set_2_chanel;
uint8_t input_status;
// command from soft
uint8_t control_command[5] = "";

uint8_t chanel_fist_test = 0, check_connection_status = 0, check_connection_last_status = 0;

// sevice
    uint32_t check_connection_counter = 0;
    uint32_t loop_test_counter = 0;
// sevice interval
    uint32_t check_connection_interval = 10;
    uint32_t loop_test_interval = 10;

void setup()
{
    wdt_enable(WDTO_500MS);

    pinMode(Relay_Pin, OUTPUT);
    digitalWrite(Relay_Pin, Relay_OFF);

    Serial.begin(115200);
    Serial.setTimeout(100);
    Serial1.begin(9600);
    Serial1.setTimeout(400);

// timer settup
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
// end timer settup
// try connect with IT8512A
    Serial.println("connect with Charger DC tester Box");
    check_online();

//set inout
    pinMode(2, INPUT_PULLUP); // chanel A sensor
    pinMode(3, INPUT_PULLUP); // chanel B sensor

    pinMode(Buzzer_Pin, OUTPUT);
    digitalWrite(Buzzer_Pin, Buzzer_OFF);
    for(int i = 0; i <= 8; i++)
    {
        digitalWrite(Buzzer_Pin, !digitalRead(Buzzer_Pin));
        delay(150);
        wdt_reset();
    }
    digitalWrite(Buzzer_Pin, Buzzer_OFF);


    //attachInterrupt(digitalPinToInterrupt(3), connect_check, RISING);
    //attachInterrupt(digitalPinToInterrupt(2), connect_check, FALLING);
}

void loop()
{
   wdt_reset();
}

// nhân lệnh 
void serialEvent(){  //serialEvent
    String buffer = "";
    char start_byte = Serial.read(); 
    while(start_byte != '$')
    {
        start_byte = Serial.read();
    }
    buffer = '$';
    buffer += Serial.readStringUntil('\r');
    splitString(buffer,'|');
    if(((36 + control_command[1] + control_command[2] + control_command[3]) % 256 == control_command[4]))
    {
    main_activity();
    for (uint8_t i = 0; i < sizeof(control_command); i++)
        {
           control_command[i] = 0;
        }
    }
    else
        {
            Serial.println("check sum fail");
        }         
}
 // giai ma lenh
void main_activity()
{
    if ( control_command[1] == arduino_address )
    {
        switch ( control_command[2] )
        {
        case read_data:
        {
            wdt_reset();
            read_data_func(control_command[3]);
            break;
        }
        case status:
        {
            chanel_fist_test = 100;
            digitalWrite(Relay_Pin,Relay_OFF);
            if( control_command[3] == two_chanel_NG)
                {
                    Buzzer_Enable = enable;
                    break;
                }
            if( control_command[3] == two_chanel_OK)
                {
                    digitalWrite(Buzzer_Pin, Buzzer_ON);
                    delay(10);
                    digitalWrite(Buzzer_Pin, Buzzer_OFF);
                    Buzzer_Enable = disable;
                    break;
                }
            if( control_command[3] == chanelA_OK)
                {
                    break;
                }
            if( control_command[3] == chanelB_OK)
                {
                    break;
                }
            delay(500);
            RESPONSE(1,4,no_connect_battery,rcm);

        }
        case chanel_set:
        {
            set_number_of_chanel = control_command[3];
            RESPONSE(arduino_address, chanel_set, set_number_of_chanel,rcm);
            break;
        }
           
        case online_check:
        {
            wdt_reset();
            check_online();
            break;
        }

        case RBStatus:
        {
            RESPONSE(arduino_address, RBStatus, digitalRead(Relay_Pin)*10 + digitalRead(Buzzer_Pin),rcm);
            break;
        }
        case RBSet:
        {
            digitalWrite(Relay_Pin, control_command[3]/10);
            Buzzer_Enable = control_command[3]%10;
            RESPONSE(arduino_address, RBStatus, digitalRead(Relay_Pin)*10 + digitalRead(Buzzer_Pin),rcm);
            break;
        }
        default:
            break;
        }
    }
    
}


void connect_check()
{
    if(set_number_of_chanel == set_1_chanel)
    {
        if( digitalRead(2) == HIGH)
        {
            if(input_status != ready_for_test )
            {
                RESPONSE(1,4,ready_for_test,rcm);
                input_status = ready_for_test;
            }
        }
    }
    else if(set_number_of_chanel == set_2_chanel )
    {
        if( digitalRead(2) == HIGH && digitalRead(3) == LOW)
        {
            if(input_status != ready_for_test)
            {
                RESPONSE(1,4,ready_for_test,rcm);
                input_status = ready_for_test;
            }
        }

        if( digitalRead(2) == LOW && digitalRead(3) == LOW)
        {
            if(input_status !=  lost_input_1)
            {
                Buzzer_Enable = disable;
                digitalWrite(Buzzer_Pin, Buzzer_OFF);
                RESPONSE(1,4,lost_input_1,rcm);
                input_status = lost_input_1;
            }
            
        }

        if( digitalRead(2) == HIGH && digitalRead(3) == HIGH)
        {
            if(input_status != lost_input_2)
            {
                RESPONSE(1,4,lost_input_2,rcm);
                input_status = lost_input_2;
            }
        }

        if( digitalRead(2) == LOW && digitalRead(3) == HIGH)
        {
            if(input_status != no_connect_battery)
            {
                Buzzer_Enable = disable;
                digitalWrite(Buzzer_Pin, Buzzer_OFF);
                RESPONSE(1,4,no_connect_battery,rcm);
                input_status = no_connect_battery;
            }
        }
    }

}

void read_data_func(uint8_t chanel)
{
        if(chanel == chanel1_sellect)
        {
                digitalWrite(Relay_Pin, Relay_OFF);
                if(chanel != chanel_fist_test)
                {
                    chanel_fist_test = chanel ;
                    delay(300);
                    wdt_reset();
                }
                else
                {
                    delay(50);
                }
                
        }
            
        if(chanel == chanel2_sellect)
        {
            digitalWrite(Relay_Pin, Relay_ON);
                if(chanel != chanel_fist_test)
                {
                    chanel_fist_test = chanel ;
                    delay(100);
                    wdt_reset();
                }
                else
                {
                    delay(50);
                }
        }
            
    get_voltage(chanel);
}

uint8_t check_online()
{
    delete_Frame();
    RESPONSE(1,0,1,rcm);
    // uint8_t retry_loop_counter = 0;
    // re_try:
    // retry_loop_counter++;
    // uint8_t k;
    // serial1Flush();
    // for (int i = 0; i < sizeof(cmd); i++)
    //     {
    //         Serial1.write(cmd[i]);
    //     }

    // uint64_t start_wait = millis();
    // k = 0;
    // while(!Serial1.available())
    // {
    //     if(millis() - start_wait > 500)
    //     {
    //         RESPONSE(1,0,0,rcm);
    //         break;
    //     }
    //     if(millis() - start_wait > 200)
    //     {
    //         wdt_reset();
    //     }       
    // }
    // while (Serial1.available())
    // { 
    //     rcm[k] = Serial1.read();
    //     k++;
    // }

    // if ( check_sum(rcm) == 0x00)
    // {
    //         if(retry_loop_counter < 3)
    //             goto re_try;
    //         delete_Frame();
    // }
    // else if (check_sum(rcm) == 0xff)
    // {
    //     if(rcm[0] == 0xAA)
    //     {
    //         RESPONSE(1,0,1,rcm);
    //     }
    //     else
    //     {
    //     if(retry_loop_counter < 3)
    //         {
    //         goto re_try;
    //         RESPONSE(1,0,0,rcm);
    //         }
    //     }
    // }
    // Serial.println(convert_value(rcm));
}

void get_voltage(uint8_t chanel)
{   
    uint8_t rcm_test[] = { 0xaa, 0x00, 0x5f, 0x66, 0x66, 0x23, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09 };
    RESPONSE(1,1,chanel,rcm_test);
    // uint8_t retry_loop_counter = 0;
    // re_try:
    // retry_loop_counter++;
    // uint8_t k;
    //     serial1Flush();
    //     for (int i = 0; i < sizeof(cmd); i++)
    //     {
    //         Serial1.write(cmd[i]); 
    //     } 
    // delete_Frame();
    // uint64_t start_wait = millis();
    // k = 0;
    // while(!Serial1.available())
    // {
    //     if(millis() - start_wait > 100 || Serial1.available() );
    //         break;
    // }
    // while (Serial1.available())
    // { 
    //     rcm[k] = Serial1.read();
    //     k++;
    // }

    // if ( check_sum(rcm) == 0x00)
    // {
    //     //Serial.println(check_sum(rcm));
    //         // for ( i = 0; i <= sizeof(rcm); ++i)
    //         // {
    //         //     Serial.print(rcm[i]);
    //         //     Serial.print(' ');
    //         // }
    //         if(retry_loop_counter < retry_loop)
    //             goto re_try;
    // }
    // else if (check_sum(rcm) == 0xff)
    // {
        
    //     if(rcm[0] == 0xAA)
    //     {
    //         RESPONSE(1,1,chanel,rcm);
    //     }
    //     else
    //     {
    //     if(retry_loop_counter < 3)
    //         {
    //             goto re_try;
    //         }
    //         RESPONSE(1,0,0,rcm); 
    //     }
    //     delete_Frame();
    //     //Serial.println(convert_value(rcm));
    // }
    
    // Serial.println(convert_value(rcm));
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
    uint64_t OutData = 0;
    String  buffer_string = "";
    for (uint8_t i = 6; i > 2; i--)
    {
        buffer_string = data[i];
        OutData += buffer_string.toInt();
        if(i > 3) 
            OutData = OutData << 8;
        //Serial.print(buffer);
    }
    //Serial.println(buffer,HEX);
    //Serial.println();
    return OutData;
}

void serial1Flush(){
  String t = Serial.readString();
} 

void delete_Frame()
{
        for (int i = 0; i < sizeof(rcm); i++)
        {
            rcm[i] = 0;
        }

}

void RESPONSE(uint8_t adress, uint8_t func_code, uint8_t data_recive, uint8_t response_data[26])
    {
        uint32_t checkSum = 36 + adress + func_code + data_recive;
        Serial.print('$');
        Serial.print('|');
        Serial.print(adress);
        Serial.print('|');
        Serial.print(func_code);
        Serial.print('|');
        Serial.print(data_recive);
        Serial.print('|');   
        if(func_code == 1)
        {
            Serial.print(20952/10*10);
            checkSum += 20952/10*10;
            Serial.print('|'); 
        }
               
        Serial.print(checkSum % 256);
        Serial.println();
    }


// suport func
void splitString(String a, char b)
{
    String buffer;
    uint8_t member_array = 0;
    for (uint8_t i = 0; i < a.length(); i++)
    {
        if(a[i] == b)
            {
                control_command[member_array] = buffer.toInt();
                member_array ++;
                buffer = "";
            }  
            else
            {
                buffer += a[i];
            }
        if(i == a.length() - 1)
            control_command[member_array] = buffer.toInt();
            
    }   
}


// sevice func

ISR (TIMER1_OVF_vect)
{
  sevice_run();
  TCNT1 = START_COUNTER;
}

void sevice_run()
{
    Buzzer_counter++;
    loop_test_counter++;
    //check_connection_counter++;
    //check_connection(10);
    Buzzer_sevice(1,1);
    loop_test();
}

void check_connection( uint32_t interval)
    {
        if(check_connection_counter >= interval)
        {
            check_online();
            check_connection_counter = 0;
        }     
    }

void loop_test()
{
    if(loop_test_counter > loop_test_interval)
    {
        loop_test_counter = 0;
        RESPONSE(1,4,ready_for_test,rcm);
    }
}

void Buzzer_sevice(uint32_t t_on, uint32_t t_off)
{
    connect_check();
    if(Buzzer_Enable == enable)
    {
        //Serial.println(Buzzer_counter);
        if (Buzzer_Status == enable)
        {
            if(Buzzer_counter >= t_on)
            {
                digitalWrite(Buzzer_Pin,Buzzer_OFF);
                Buzzer_Status = disable;
                Buzzer_counter = 0;
            }
        }
        else if (Buzzer_Status == disable)
        {
            if(Buzzer_counter >= t_off)
            {
                digitalWrite(Buzzer_Pin,Buzzer_ON);
                Buzzer_Status = enable;
                Buzzer_counter = 0;
            }
        }
    }
    else if (Buzzer_Enable == false)   
    {
        digitalWrite(Buzzer_Pin,Buzzer_OFF);
    } 
}
