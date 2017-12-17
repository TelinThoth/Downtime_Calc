README.TXT
Verson 0.2.4
Last Edit Date: 12/17/17
***********************************************************************************************************
*Table of Contents                                                                                        *
***********************************************************************************************************

Section 1: Overview
        1.1: Normal Flow
        
Section 2: Save Data
        2.1: Save Data Outline
        2.2: The CPGN File
        2.3: The Campaign Data
        2.4: Log Files
          2.4.1: Log File Layout
          2.4.2: Header for Log File
          2.4.3: Format for Roll Lines
          2.4.4: Open/Access Line Format
          
Section 3: Accounts
        3.1: Account Types and Returns
        3.2: Return Calculations
        
Section 4: Config File
        4.1: Flags
        4.2: Account Settings
        4.3 Other Settings

Section XX: Updates
        X.0 Update 0.1
        X.1 Update 0.2
          X.1.1 Update 0.2.1
        X.2 Update to 0.2.2
        X.3 Update to 0.2.3
        X.4 Update to 0.2.4
===========================================================================================================

===========================================================================================================
Section 1: Overview 
===========================================================================================================

The idea of this program is to help manage several investments for the PCs of a campaign, or multiple
campaigns, as well as storing the history of those investments to make the process more transparent, 
and easier to understand. There should be all of the Rules as Writen (RAW) within the Ultimate Campaign
book, as well as some flags and options for house rules, common or otherwise.

Section 1.1: Normal Flow
A PC walks up to a NPC, or vice versa, and offers an investment opportunity. After a set amount of time,
usually a month or a year, the return of that investment is felt.

Within a normal return, the investment grows a set percentage.
Within a great return, or break out, the investment grows at a multiple of that percentage.
Within a failed year, the investment sits and waits another time period. After three failed investments
        the entirety of the amount is lost. 
        
In the event that a PC wishes to withdraw from the investment, partly or fully, they lose half the investment.
This assumes that they are attempting to back out before the end of the time period. 

===========================================================================================================
Section 2: Save Data
===========================================================================================================

Section 2.1 Outline for the Save Data
---------------------------
|XXXXXXXXXXX.Cpgn   (ZIP) |
---------------------------
  |-Config.csv
  |-CampaignData.xml
  |-Log Files
    |-Account 1.csv
    |-Account 2.csv
    |-...

Section 2.2: 
The Campaign File: (.cpgn)
This is a ZipFile that is Intended to break up 'Like' data.

Section 2.3:
The Campaign Data (xml)
This is the main storage medium for all the accounts for the program divided into accounts and Characters.
[Campaign]
  |-[Campaign ID #]
  |-[Name]
  |-[Players]
  |    |-[Player]
  |       |-[Player ID #]
  |       |-[Player Name]
  |       |-[Linked Characters]
  |          |-[Linked Character ID #]
  |-[Characters]
  |    |-[Character]
  |    |  |-[Character ID #]
  |    |  |-[Character Name]
  |    |  |-[Account Access]
  |    |     |-[Account]
  |-[Accounts]
       |-[Account]
          |-[Account ID #]
          |-[Type]
          |-[Investment Value]
          |-[Nickname]
          |-[Owner's Character ID #]

Campaign Tags:
        Campaign ID #: Used for internal Tracking. Possible Extra Data with CPGN save Format
        Name: Campaign name

Player Tags:
        Player ID: Unique ID (Per CPGN) for the Player
        Player Name: Name of the Player
        Linked Characters: Character ID # for each character that player plays. New Line per Character

Character Tags:
        Character ID #: Unique ID (per CPGN) for the Character
        Character Name: Name of Character
        Account Access: Account ID # to the Account(s) that Character can access.

Account Access Tags:
        Account: Multiple Entries for the accounts the Character has. Also used by the Log file to determine the order of the Accounts displayed
        
Account Tags:
        Account ID #: Unique ID (Per CPGN) for the account
        Type: Type of account being Tracked: 21 types for Standard, 1 Basic non-standard, and option for custom additions.
        Investment Value: Tracked in Gold. [G].[S][C] Stored as a Double. (Note: Option to store as a INT as Copper but display as a Double)
        Nickname: Display Name
        Owner's Character ID #: Character ID of the owner. Only the owner can close accounts. (Possibly Unneeded.)

Section 2.4:
Log Files

Section 2.4.1
Log File Layout

The Log is used for Display of the accounts to Humans, not the program. That said the intent isn't to provide a source of backup 
for the data. As such: none of the data here will be use for recovery.

These CSVs store the In-game date and store all the changes to the accounts with a short description as to the nature of the changes.
[Date][Type][Character][acct]
[Date] is the ingame date for the transaction accuring, the number after the date '.X' is the Update Number for that day.
[Type]: type of Transaction: Transfer, Withdrawl, deposit, Interest/Returns, open, close, update, roll, Granted Access
[Character] The Character responcible for the transaction, including the Investment, God.
[acct][Owner/Access]: The accounts assosiated with the character that have changed, Adjustable Columns Owner/Access tells the player if they own the account, or just have access

The following is an example of a logfile
--Date---, Type, Name, 01-Bank[Owner] 
12/7/4713, Open, Grug, +100
12/7/4713.1, Update, Investment, 100
12/30/4713, Roll, God, 99(2)[4%]
12/30/4713.1, Returns, Investment, +4
12/30/4713.2, Update, Investment, 104

Section 2.4.2
Header for Log File
Date, Type, Name, [Account Number]-[Account Type]-[[Owner/Access]],...,[Account Number]-[Account Type]-[[Owner/Access]]
Account Numbers are read when being used to determine the order of the accounts for a Character's Log file. They can be found within
the Character Tags of the XML.

Section 2.4.3
Format for Roll Lines
[Date], Roll, God, [D100 Result]([Roll on Breakout if Needed])[[Return%]]//Account Applied to if needed//,...
The last Section is repeated for each of the Accounts it has access to.

Section 2.4.4
Open Account Line
When an account is opened, or Granted Access, the account should be appended to the last colomn of the CSV
So the Header adds +", Account Type[Access/Owner]"
Each row that comes before the Update line adds +"----" 
And then the Open/Access line it Adds the amount in the account starting at this point.

===========================================================================================================
Section 3: Accounts
===========================================================================================================

Section 3.1:
Account Types and Returns
There are 21 types of Account Files, not including the custom Resuection Fund.

01-[Creative Arts]-------04%--31-95--2d4+1
02-[Performing Arts]-----02%--36-95--2d6+1
03-[Banking]-------------02%--11-98--1d4+1
04-[Common Crafting]-----01%--06-95--1d3+1
05-[Magical Crafting]----05%--31-95--1d8+1
06-[Millitary Crafting]--05%--16-90--1d6+1
07-[Exploration]---------02%--41-85--2d8+1
08-[Mill/Granary]--------03%--11-98--1d3+1
09-[Assassins Guild]-----05%--31-95--2d4+1
10-[Crafting Guilds]-----02%--06-98--1d3+1
11-[Merchant's Guild]----03%--11-98--1d4+1
12-[Thieve's Guild]------04%--16-90--1d8+1
13-[Exotic Imports]------05%--31-90--1d10+1
14-[Ordinary Imports]----02%--16-95--1d4+1
15-[Invention Supplies]--03%--41-90--2d6+1
16-[Protection Supplies]-03%--31-95--1d8+1
17-[Quarry Imports]------03%--21-90--1d6+1
18-[Magical Research]----05%--51-75--2d6+1
19-[Mundane Research]----03%--21-85--1d8+1
20-[Stable]--------------01%--06-98--1d3+1
21-[Tavern]--------------01%--06-98--1d4+1
22-[Resurection Funds]---No Returns

Section 3.2
Return Calculations
Roll 1d100
No returns if the Value is less than the Normal Range 
Return normal if within the Normal Range
Retrun Normal * Breakout if greater than the Normal Range.

Example: 1
03-[Banking]-------------02%--11-98--1d4+1
Roll 1d100-->10
Return no Returns

Example 2:
Roll 1d100-->50
Return of 2%

Example 3:
Roll 1d100-->100
Roll 1d4-->3
(3+1)*2
Return of 8%

===========================================================================================================
Section 4: The Config File
===========================================================================================================

Section 4.1: Flags

1--Auto Reinvest
2--Allow Returns to an Alternate Account
3--Resurection Funds
   3.1--Resurection Classes/Closest Afforded
   3.2--Allow Debt
4--Monthly/Yearly Returns
5--Allow Debt
6--Allow Loans
7--Allow Strikes

Auto Reinvest: Flags that all of the accounts automaticall take the Interest gained from the month/year and apply it back into the investment.
Allow Returns to Alternate Account: Allows the Interest to be applied to a seporate account other that the one the investment came from
Resurection Funds: Flag for Custom type of Investment for home brew
        Resurection Classes/Closest Afforded: Allow to accrue for a specific class of Resurection, or if it gets applied to a standard cost
        Allow Debt: Flag to Allow/Disallow Debts for the Resurection Fund Specifically
Monthly/Yearly Reurns: Normal Interest is accrued on the new year, as opposed to the month. False allows only for the year, True allows for the month
Allow Debts: Flag to Allow an account to go Negative
Allow Loans: Flag to Allow a character to take out a loan for personal Gain
Allow Strikes: Flag to Remove Investment after a number of failed returns.

Section 4.2 Account Settings
Format:
[Type #][Type][Return Normal][Min][Max][Breakout Die][Return Loss]
Example:
03, Bank, 2, 11, 98, 1d4, 0

Note: Since the Min<->Max Value is needed to be rolled to gain the standard Interest, the Min<->Max Range is all that is needed.
Note: Since all of the Returns have a +1 it can be applied in code
Note: Return loss is a Boolean Value.
Note: Before the end of the year/month, if the PC wants to take the money back, they can recieve half the investment back, the other half is lost, as the investee must sell things at half price to get the money to the PC.
        Turning this off more accuratly simulates things such as Banking accounts.

Section 4.3 Other Settings
1--Strike Count

Stike Count: # Strikes till Investment Failure.
        Defualt value is 3. After 3 strikes an investment can be saved by investing 2 or 3 times the investment


===========================================================================================================
Section XX: Updates
===========================================================================================================

Section X.0 Update 0.1
 --Created File

Section X.1 Update 0.2 (12/11/17)
 --Reformated
 --Updated to the new XML Format
 --Added Sections 1-2
 --New Log File Format
 --Renamed to Readme from DataFormat
        X.1.1 Update 0.2.1
         --Updated to a Revised Log Format
         --Added Section 3

Section X.2 Update to 0.2.2 (12/13/17)
 --Expanded the XML Data format to new standard.
    |--Reformatted to be inline with the XML Style Sheet provided by GitIgnored
 --Added Owner ID # to Account Data Storage
 --Added Section 3.3
 --Added Allow Strikes option in Flags
 
 Section X.3 Update to 0.2.3 (12/14/17)
  --Added Missing Tag in XML File
  --Added Possile Order for Log File
 
Section X.4 Update to 0.2.4 (12/17/17)
 --Corrected Error in Account Tags 
    |-(Owner's Player ID # --> Owner's Character ID #
 --Added Return Loss Flag to the Account Settings
 --Added New Section 1: Overview, Adjusted other sections to reflect new order to ReadMe
 --Update Log File CSV Saves.
    |-Log Files should be linked to Accounts, not the Characters. This was a correction that should have been made last update but was overlooked.
    |-There is a possibility we can have Character Display Sheets for Characters, and Players.

 
