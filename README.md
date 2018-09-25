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

### Things still to do:
------
I will need to add the Call Timer next and then I will add the ability for the program to Log the button presses to a file for future reference.  
My original program at this point kept counting to show you how long you went over and you had to hit a reset button for it to stop.  I'm not sure if I'll add that for now.
Also I may move the break/lunch/call timers all to 1 label to tighten up the interface.
Also thinking about ways to setup boolean variables within the button click events to initialize the timer and every tick have the timer check those variables in a loop.  That would allow me to only have one timer handling all 4 timer tasks:  
 
 ```
 if iscall true and isbreak AND islunch = false then call and clock
 elseif isbreak is true and islunch and iscall false then break and clock
 elseif islunch is true and isbreak and iscall false then lunch and clock.
 else all 3 are false then only clock.
 ```
