# Visual Basic Timer

### Description
------
This is a re-creation of a program I wrote in Visual Basic 6 in approximately 1999-2000.  I worked in a Tech Support call center and we had down time on a regular basis.  Amazingly enough we had access to an installation of Visual Basic 6 and the ability to save txt files to our user directories.  I wanted to learn VB and so I made a program that tracked my break/lunch times and length of calls. 

I have since lost the source code and the executable but I remembered the basic ideas behind the program so I decided to give it a go and see if I could do it in VB.NET.  

### What I've done so far.
------
I'm using Visual Studio 2017 Community Edition.  
Currently I have the GUI setup for the Break and Lunch Timers with labels, buttons and timers.  I setup a future DateTime variable that adds 15/30 minutes to the time the button was pushed in the click event for that button. It then hides the break/lunch buttons and shows the stop button.  And the timer starts. Then I am using timespan in the timer tick to calculate the difference between the future time from when the button was pushed to the current time and formatting that in mm:ss.  And finally an alert window pops up when the countdown is over to notify you that your time is up. When you click OK on the alert button it stops the timers and reverses the show/hide methods for the button and then resets the labels to default.
I have clocks for reference, in both standard and 24hr. times for now, that will be changed to one single clock in the final program.  Although the program opens in the lower right of the desktop I added in the ability to click/drag on the program window itself to move it around the desktop and removed the Title Bar to make it cleaner.

I have now added two variables: isBreak and isLunch and created an a select-case structure to set which count to use for the timer.  Then added if-else statements under each case to handle the timing count all within the timer's tick event.  

I've added the isCall variable, btnCall button and added the isCall case to the timer.  I'm using the Stopwatch method to get the time elapsed from when the Stopwatch is started to the next tick of the Timer.  

I removed the 24 hour clock and have cleaned up the interface a little.


### Things still to do:
------
-I will need to add the Call Timer next and then I will add the ability for the program to Log the button presses to a file for future reference. I will add a call start label and a call length label (part of the same label for breaks and lunches).  Both will reset when the user presses the stop button.  
** I'm not going to do this** -My original program at this point kept counting to show you how long you went over and you had to hit a reset button for it to stop.  I'm not sure if I'll add that for now.
-DONE * Also I may move the break/lunch/call timers all to 1 label to tighten up the interface.
-DONE * Also thinking about ways to setup boolean variables within the button click events to initialize the timer and every tick have the timer check those variables in a loop.  That would allow me to only have one timer handling all 4 timer tasks:
-Need to get current path where exe is being run from. Save that into a variable. Then check to see if the save file exists and create it if it doesn't.  

``` Dim dataDirectory As String = String.Format("{0}\Data\", Environment.CurrentDirectory)
    Dim SavePath as string = system.io.path.combine(dataDirectory, Filename)
    if system.io.file.exists(savePath) then
   'The file exists so open file for writing
else 
    'the file doesn't exist so create the file and then open the file for writing.
end if
' Below is generic to create file .
Imports System
Imports System.IO
Imports System.Text

Module Module1

    Sub Main()
        Dim path As String = "c:\temp\MyTest.txt"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("This is some text in the file.")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

End Module

```
 Decided to use Select-Case instead of the below structure.  I believe this is cleaner.
 ```
 if iscall true and isbreak AND islunch = false then call and clock
 elseif isbreak is true and islunch and iscall false then break and clock
 elseif islunch is true and isbreak and iscall false then lunch and clock.
 else all 3 are false then only clock.
 ```
