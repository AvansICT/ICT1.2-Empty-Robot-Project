using Avans.StatisticalRobot;
using GyroscopeCompass.GyroscopeCompass;
using Hardware.Touchpad;
using Speaker;
using System.Device.I2c;

/* 
   Dit project kun je gebruiken als start voor je robot project.
   Voordat je aan de slag kunt moet je verbinding maken met je robot. 
   Gebruik hiervoor de Avans-StatisticalRobot extensie die je in VS code kunt installeren.

   Verbinding?
    Probeer eens wat sensoren en actuatoren en kijk wat de mogelijkheden zijn. 
   
   Klaar met experimenteren?
    Ga vervolgens aan de slag met een ontwerp van de applicatie: hoe ga jij je code structureren? 
    Dat betekent ook dat niet alles in Program.CS terecht komt. Start eens met een eenvoudige klassendiagram.
    Om te communiceren via MQTT moet je een extra package en de SimpleMQTTclient aan je project toevoegen.
    Veel succes en oh ja: het lampje mag je gerust weer weghalen :-)
*/

Console.WriteLine("Hello Robot!");

Led lampje = new Led(1); // kies wel de juiste pin!
lampje.SetOn();

