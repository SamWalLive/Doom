                Palette And ColourMap UTility (PACMUT)
                            version 1.0b
                         (c) 1997 Jereth Kok
                   email: jereth@alphalink.com.au

--------------------------------------------------------------------------------
INTRODUCTION:

PACMUT is an easy-to-use program which lets you edit Dark Forces PAL and
CMP files. Using it you will be able to modify the colours in your level's
Palette, as well as the appearance of colours under various lighting levels.

Note: PACMUT is a Windows 95 application.

More Important Note: PACMUT should be used with Hi-color (65536 colours) or
greater. Using it in 256 colour mode will result in dithering.

--------------------------------------------------------------------------------
INSTALL INSTRUCTIONS:

PACMUT consists of only two files:  PACMUT.EXE - the application
                                    README.TXT - this readme file

Place both of these in one directory (folder) on your hard drive. You may
create a shortcut to PACMUT by following these steps:

1) Right click anywhere on your desktop
2) Select New > Shortcut
3) Type in the command line for the program, or click on Browse to find
   the application using a dialog box
4) Click Next
5) Enter "PACMUT" as the shortcut's name
6) Click Finish

--------------------------------------------------------------------------------
INSTRUCTIONS FOR USE:

Editing a PAL file:
-------------------
You may open a PAL file by selecting "Open" from the PAL menu. When you have
selected a PAL file and opened it, the PAL colours will show in the display
box on the left.

Select a colour to modify by clicking on it in the display box. Then, use
the Red, Green and Blue spin-editors to change the component intensities
as desired. When done, click on Commit.

To save your PAL file, select "Save" from the PAL menu. To save it under a
different name, select "Save As" and then type in the new name for the file.
To close the PAL file, select "Close" from the PAL menu.

Note: You will be unable to close a PAL file while you have a CMP file open.



Editing a CMP file:
-------------------
If you have a PAL file open, you may open a CMP file by selecting "Open"
from the CMP menu. When you have selected the CMP file you want to open,
click OK.

The open CMP is shown in the display box on the right, as an array of colours
under a particular light level. You can change the light level with the
"Current light level" spin-editor. The light levels range from 0 to 31 in
Dark Forces.

To change the way a particular colour appears under a particular light level,
first go to the desired light level as outlined above. Then, select the
colour you want to change by clicking the colour in the CMP (right) display
box. Next, select the colour from the PAL that you want your selected colour
to appear as under the chosen light level, by clicking on it in the PAL
(left) display box. When satisfied, click Commit.

To save your CMP file, select "Save" from the CMP menu. To save it under a
different name, select "Save As" and then type in the new name for the file.
To close the CMP file, select "Close" from the CMP menu.



--------------------------------------------------------------------------------
FILE FORMATS:

The file formats of PAL and CMP do not need to be understood to use PACMUT.
They are here for technical reference only.

All of this info was collected by Yves Borckmans, Peter Klassen, and myself.


PAL file format:
----------------

PAL_File IS
{
 colors : array[0..255] of RGB_Color  // 256 colors from 0 to 255
}


Where:

RGB_Color Is
{
 R : byte    // Red intensity
 G : byte    // Green intensity
 B : byte    // Blue intensity
}

These intensities range from 0 to 63 (limit of VGA mode 0x13).

Note that colours 24-31 (hex 18-1F) in each PAL are used by the Dark Forces
engine to indicate health, shields and battery levels in your Status Display.
[Thanks to Peter Klassen for this info].



CMP file format:
----------------

CMP_File IS
{
 ColorMapInfo : array[0..31] of LightLevel     // light levels from 0 to 31
 ShadingInfo  : array[0..127] of byte
}

Where:

LightLevel IS
{
 array[0..255] of byte  // 256 colours, each an index into the PAL file
}


The 128 ShadingInfo bytes at the end of the CMP file (generally forming a
slow gradient from 0x00 to 0x1F) serve to modify light values when you use
the headlight, or fire a weapon. The first of the 128 bytes controls the
area right next to you and each one after that controls an area progressively
further away. 0x00 is the maximum illumination while 0x1F is minimum for the
headlight. Values above 0x1F and up to 0x27 serve to suppress the weapon
lighting effect too.

The only practical use for these 128 bytes is to modify the headlight's power.
For instance, you could make it weaker, so that it illuminates your
surroundings less, or more powerful, so that it gives stronger illumination.



--------------------------------------------------------------------------------
LEGAL BULLSHIT:

Disclaimer:
-----------
(i.e. ass-covering)

There is no way I could see this simple application harming your PC. But in
the infintesimally unlikely event that it does cause some damage, I, Jereth
Kok am not responsible. In other words, you can't sue the pants off me :)


Permissions:
------------
You may not decompile or modify the program without my permission.


Distribution:
-------------
PACMUT is to be distributed for FREE. In other words, don't try and make
money out of my work, all you scavengers and scoundels out there! :)


--------------------------------------------------------------------------------
FINAL WORD:

Please mail all comments, suggestions and criticisms of PACMUT to me:
jereth@alphalink.com.au

thankyou!

Good luck with your Dark Forces levels, and MTFBWY!
