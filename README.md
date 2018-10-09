# ChangeWinSysColors
A small .NET command line program to manually change color options not accessible from the UI.

Originally wrote this to solve my own pain with the lack of tooltip color support in Windows 10, and figured this would be useful to others as well.  

#### Colors you can change (also in code comments)
```
        /// 0 COLOR_SCROLLBAR Color of the gray area of a scroll bar.
        /// 1 COLOR_BACKGROUND Background color of the desktop window.
        /// 2 COLOR_ACTIVECAPTION Color of the title bar of an active window.
        /// 3 COLOR_INACTIVECAPTION Color of the title bar of an inactive window.
        /// 4 COLOR_MENU Background color of a menu.
        /// 5 COLOR_WINDOW Background color of a window.
        /// 6 COLOR_WINDOWFRAME Color of a window frame.
        /// 7 COLOR_MENUTEXT Color of the text in a menu.
        /// 8 COLOR_WINDOWTEXT Color of the text in a window.
        /// 9 COLOR_CAPTIONTEXT Color of the text in a title bar and of the size box and scroll bar arrow box.
        /// 10 COLOR_ACTIVEBORDER Color of the border of an active window.
        /// 11 COLOR_INACTIVEBORDER Color of the border of an inactive window.
        /// 12 COLOR_APPWORKSPACE Background color of multiple document interface (MDI) applications.
        /// 13 COLOR_HIGHLIGHT Color of an item selected in a control.
        /// 14 COLOR_HIGHLIGHTTEXT Color of the text of an item selected in a control.
        /// 15 COLOR_BTNFACE Color of the face of a button.
        /// 16 COLOR_BTNSHADOW Shadow color of buttons for edges that face away from the light source.
        /// 17 COLOR_GRAYTEXT Color of shaded text. This color is set to 0 if the current display driver does not support a solid gray color.
        /// 18 COLOR_BTNTEXT Color of the text for push buttons.
        /// 19 COLOR_INACTIVECAPTIONTEXT Color of the text in the title bar of an inactive window.
        /// 20 COLOR_BTNHIGHLIGHT Highlight color of buttons for edges that face the light source.
        /// 21 COLOR_3DDKSHADOW Color of the dark shadow for three-dimensional display elements.
        /// 22 COLOR_3DLIGHT Highlight color of three-dimensional display elements for edges that face the light source.
        /// 23 COLOR_INFOTEXT Color of the text for ToolTip controls.
        /// 24 COLOR_INFOBK Background color for ToolTip controls.
        /// 25 COLOR_STATIC Background color for static controls and dialog boxes. Supported in Windows CE 2.0 and later.
        /// 26 COLOR_STATICTEXT Color of the text for static controls. Supported in Windows CE 2.0 and later.
        /// 27 COLOR_GRADIENTACTIVECAPTION Color of the title bar of an active window that is filled with a color gradient.
        /// 28 COLOR_GRADIENTINACTIVECAPTION Color of the title bar of an inactive window that is filled with a color gradient.
```
