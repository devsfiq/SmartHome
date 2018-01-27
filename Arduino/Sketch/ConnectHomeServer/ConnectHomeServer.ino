#include "Timer.h"

#include <Bridge.h>
#include <BridgeServer.h>
#include <BridgeClient.h>
#include <FileIO.h>
#include <HttpClient.h>

const char* HOME_SERVER_IP = "192.168.43.173";
const int HOME_SERVER_PORT = 3000;

Timer t;
String numDevicesInNetwork;

BridgeServer server;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Bridge.begin();
  while(!Serial);
  
  Serial.println("Starting SmartHome Services..");
  
  server.listenOnLocalhost();
  server.begin();
  
  t.every(15000, scanNetwork);
  scanNetwork();
}
  
void loop() {
  BridgeClient client = server.accept();
  if (client) {
    process(client);
    client.stop();
  }
  delay(50);
  t.update();
}

void process(BridgeClient client) {
//  String command = client.readStringUntil('/');
  String command = client.readStringUntil('\r');
  if(command == "scan") {
    getNetworkScanInfo(client);
  }
}

void getNetworkScanInfo(BridgeClient client) {
  Serial.println("Retrieving network scan info");
  
  Process p;
  p.begin("sh");
  p.addParameter("/usr/bin/automation/scan-network-results.sh");
  p.run();

  while(p.available()) {
    client.print((char)p.read());
  }

  
  Serial.println("Returning network scan info");
}

void scanNetwork() {
  String tmp = startScanNetworkScript();

  if(numDevicesInNetwork != tmp) {
    Serial.println("There is a change in the network");
    informHomeServer();
    numDevicesInNetwork = tmp;
  }
}

void informHomeServer() {
  BridgeClient client;

  if(client.connect(HOME_SERVER_IP, HOME_SERVER_PORT)) {
    client.println("NETWORK_CHANGED");
  }
}

String startScanNetworkScript() {
  Serial.println();
  Serial.println("Scanning network..");
  
  Process p;
  p.begin("sh");
  p.addParameter("/usr/bin/automation/scan-network.sh");
  p.run();

  String results = "";
  
  while(p.available()) {
    results += (char)p.read();  
  }

  Serial.println("Scanning complete..");
  return results;
}

