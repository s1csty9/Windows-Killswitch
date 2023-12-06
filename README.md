# Windows Killswitch
For when you want to kill windows for totally innocent purposes

I made this thing as a quick shortcut to kill windows on my school laptop in case I ever get caught lacking doing unrelated work by my teachers in class. To crash windows, you have to to have the script running in the background and you trigger the bsod by pressing Alt + F + 4 (make sure you press them at the same time and hold the keys if it isn't detected). It's brilliant how it works, really, and I'd have to credit that to GrumpBoatYT who I forked it from. Here's the original description.

**How does it work?**

This program generates BSOD very quietly and quickly.
First, it will set itself as a critical process.
Then, it will get the PID (Process ID) of itself.
Then, it will just kill itself using **taskkill.exe** and you will get **CRITICAL_PROCESS_DIED**.

**Is this safe?**

Yes, you can run this program on your host machine.

(s1csty9 note: it doesn't interfere with any system processes so it shouldn't cause damage when you trigger it)

