import sys
import subprocess
cmd = ['nmap', '-sn', '192.168.43.0/24']
proc = subprocess.Popen(cmd,  stdout=subprocess.PIPE)

while True:
    line = proc.stdout.readline()
    if line != '':
	if line.startswith('Nmap scan report for'):
            ip = line.replace('Nmap scan report for ', '')
            print ''
            print ip.rstrip() + '|',
            sys.stdout.flush()
	elif line.startswith('MAC Address: '):
            mac = line.replace('MAC Address: ', '').split()[0]
            print mac.rstrip(),
            sys.stdout.flush()
    else:
        break
