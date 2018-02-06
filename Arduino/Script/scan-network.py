import subprocess
import re

results = subprocess.check_output(["nmap", "-sn", "192.168.43.*"]).split("\n")

ip = []
mac = []

ipRegex = r"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"
macRegex = r"([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})"

for line in results:
    m = re.search(ipRegex, line)
    if m:
        if len(ip) - len(mac) < 1: 
            ip.append(m.group())

    m = re.search(macRegex, line)
    if m:
        mac.append(m.group()) 

print("<?xml version=\"1.0\" encoding=\"UTF-8\"?>")
print("<network>")

for index, value in enumerate(ip):
   print("<host>")
   print("<ip>" + ip[index] + "</ip>")
   print("<mac>" + mac[index] + "</mac>")
   print("</host>")

print("</network>")
