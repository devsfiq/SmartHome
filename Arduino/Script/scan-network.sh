#!/bin/bash

ip=$(ifconfig | awk '/wlan0/{x=1}x&&/inet addr:/{split($2,a,":"); split(a[2],ip,"."); print ip[1] "." ip[2] "." ip[3] ".0" };')
nmap -sn $ip/24 -oX network-scan.xml > /dev/null 
cat network-scan.xml | grep '<host>' | wc -l

