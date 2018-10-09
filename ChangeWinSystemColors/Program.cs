using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SystemColorCustom
{
    //Created as a way to manually change the tooltip colors in Windows 10 to work around the lack of UI.
    //Total list of other color options that can be changed in the comments.
    class Program
    {
        [DllImport("user32.dll")]
        static extern int SetSysColors(int cElements, Int32[] lpaElements, Int32[] lpaRgbValues);

        [DllImport("user32.dll")]
        static extern uint GetSysColor(int nIndex);

        /// <summary>
        /// SetSysColors
        /// Registry Order System color Description
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
        /// </summary>
        /// <param name="cElements"></param>
        /// <param name="lpaElements"></param>
        /// <param name="lpaRgbValues"></param>
        /// <returns></returns>
        

        static void Main(string[] args)
        {
            //Display previous values
            Console.WriteLine(GetSysColor(23));
            Console.WriteLine(GetSysColor(24));

            //# of elements, # from list in an array, new color being assigned in an array
            SetSysColors(1, new int[]{ 23 }, new int[]{ 0x00ffffff });
            SetSysColors(1, new int[]{ 24 }, new int[]{ 0x00000000 });
            //Hex are in format 0TRRGGBB, first byte left blank since the function expects unsigned int for color
            //T: Transparency
            //R: Red
            //G: Green
            //B: Blue

            //Confirm colors were changed
            Console.WriteLine(GetSysColor(23));
            Console.WriteLine(GetSysColor(24));

        }
    }
}