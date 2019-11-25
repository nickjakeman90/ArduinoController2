using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoController
{
    class INOGenerator
        //The plan will be for this class to generate an arduino .ino file
        //to be uploaded to the arduino to allow this program to control
        //the arduino.
    {
        //public int comPort;
        //public int baudRate;

        //always true for test
        public bool LEDS = true;

        

        private void GenerateSerial()
        {
            // void setup() {
            //  Serial.begin(baudrate);
            //  initDisplay();
            if (LEDS == true)
            {
                // for each active led
                // pinMode(LEDx ,OUTPUT);
            }
            //}
            
            //void loop() {
            
            //}
        }

        private void GenerateINO()
        {
            GenerateHeaders();
            GenerateLED();
            GenerateSerial();
            //GenerateLCD();
        }

        private void GenerateHeaders()
        {

            //Create a file to write too
            using (StreamWriter headers = new StreamWriter("test.ino"))
            {
                if (LEDS == true)
                    headers.WriteLine("#include <LiquidCrystal.h>;");

                headers.WriteLine("String inputString = \"\";");
                headers.WriteLine("String commandString = \"\";");
                headers.WriteLine("boolean stringComplete = false;");
                headers.WriteLine("boolean isConnected = false;");
            }

        }

        private void GenerateLED()
        {
            //Generate LED variables
            if (LEDS == true)
            {
                //int led1Pin = 19;
                //int led2Pin = 20;
                //int led3Pin = 21;
            }

        }

    }
        
}
