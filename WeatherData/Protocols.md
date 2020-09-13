///////// ----- RECEIVING ------ /////////

This program receives STRING-type data from serial port (measuring device).
Every new string is at new line.
String examples: 
ST0243H0541P7556B0807C1204S0440M0091L0012I0507E

SB0807P7556T0243C1204H0541E

ZP7556B0807E

S - start of default data string. E marks end of string. If those missing, string ignored as wrong or corrupted
Z - start string of data, that can be updated faster than 10s (for example, brightness), will be shown but not recorded.

Every string contains data substring in format TNNNN. 
Lengtn of string equal 2(S,E) + 5*n, where n is integer number, count of substring, from 1 and up.
Strings with incorrect length will be ignored

Type of substring shows first char - letter of this substring (T), value is 4-digit (NNNN).
Substring examples:
H0245
I0290

Data substrings letters, types and parsing examples:

T - temperature				T1234 means 123.4øC
H - relative humidity		H1234 means 123.4% RH
P - atmospheric pressure	P1234 means 123.4 mmHG
B - brightness				B1234 means 1234 lux
C - air CO2 level			C1234 means 1234 ppm
S - dust sensor value		S1234 means 1234 pm10 standart units - <10mkm
M - dust sensor value		M1234 means 1234 pm25 standart units - <2.5 mkm
L - dust sensor value		L1234 means 1234 pm100 standart units
I - ion level					----

Substrings with wrong letters will be ignored
Substrings may come in any order
String can contain more than one substring of same type, only the last value will be stored

Those letters (17) still free to be used as substring type:
Q W E R Y U O A D F G J K Z X N V




//////// ----- SENDING ----- ////////

This program sends STRING-type data to serial port (measuring device).
Every new string is at new line
String examples:
CHA1103
CTB0010

First letter select action to perform
Available actions:
C - update calibrating



Calibrating format: CXXYYYY

Second letter - select data type
T - temperature				
H - relative humidity		
P - atmospheric pressure	
B - brightness					
C - air CO2 level				
S - dust sensor value		
M - dust sensor value		
L - dust sensor value		
I - ion level					

newVal = (oldVal * A) + B

Third char - what coefficient you want to edit
A - change multiplier, default is float 1.0
B - change the added value, default is float 0.0

Calibrating values stored in EEPROM inside device, this means 
1) you mustn't re-set them after every reload of device;
2) you have a limited number of rewrites of these numbers (up to ~10000).
