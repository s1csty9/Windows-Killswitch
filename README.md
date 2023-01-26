# ForceBSOD
A program that makes your computer BSOD forcely and safely.

**Code difficulty:** Easy

Some people might think it will kill **svchost.exe** or **csrss.exe** or **wininit.exe**. 
But no, csrss.exe killing only works on Windows 7, wininit.exe killing only works on Windows 7/8/8.1, svchost.exe killing only works on Windows 10/11.
This program compatible with any windows versions.

**How does it work?**
This program generates BSOD very quietly and quickly.
First, it will set itself as a critical process.
Then, it will get the PID (Process ID) of itself.
Then, it will just kill itself using **taskkill.exe** and you will get **CRITICAL_PROCESS_DIED**.

**Is this safe?**
Yes, you can run this program on your host machine.

**How do I download this?**
Go to **bin/release** then download the **ForceBSOD.exe**.

**You can use this to prank your friends. But remember, you have to save their works or else you are a bad friend :)**
