﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

public static partial class Interop
{
    public static partial class Ole32
    {
        public enum OLECMDID : uint
        {
            OPEN = 1,
            NEW = 2,
            SAVE = 3,
            SAVEAS = 4,
            SAVECOPYAS = 5,
            PRINT = 6,
            PRINTPREVIEW = 7,
            PAGESETUP = 8,
            SPELL = 9,
            PROPERTIES = 10,
            CUT = 11,
            COPY = 12,
            PASTE = 13,
            PASTESPECIAL = 14,
            UNDO = 15,
            REDO = 16,
            SELECTALL = 17,
            CLEARSELECTION = 18,
            ZOOM = 19,
            GETZOOMRANGE = 20,
            UPDATECOMMANDS = 21,
            REFRESH = 22,
            STOP = 23,
            HIDETOOLBARS = 24,
            SETPROGRESSMAX = 25,
            SETPROGRESSPOS = 26,
            SETPROGRESSTEXT = 27,
            SETTITLE = 28,
            SETDOWNLOADSTATE = 29,
            STOPDOWNLOAD = 30,
            ONTOOLBARACTIVATED = 31,
            FIND = 32,
            DELETE = 33,
            HTTPEQUIV = 34,
            HTTPEQUIV_DONE = 35,
            ENABLE_INTERACTION = 36,
            ONUNLOAD = 37,
            PROPERTYBAG2 = 38,
            PREREFRESH = 39,
            SHOWSCRIPTERROR = 40,
            SHOWMESSAGE = 41,
            SHOWFIND = 42,
            SHOWPAGESETUP = 43,
            SHOWPRINT = 44,
            CLOSE = 45,
            ALLOWUILESSSAVEAS = 46,
            DONTDOWNLOADCSS = 47,
            UPDATEPAGESTATUS = 48,
            PRINT2 = 49,
            PRINTPREVIEW2 = 50,
            SETPRINTTEMPLATE = 51,
            GETPRINTTEMPLATE = 52,
            PAGEACTIONBLOCKED = 55,
            PAGEACTIONUIQUERY = 56,
            FOCUSVIEWCONTROLS = 57,
            FOCUSVIEWCONTROLSQUERY = 58,
            SHOWPAGEACTIONMENU = 59,
            ADDTRAVELENTRY = 60,
            UPDATETRAVELENTRY = 61,
            UPDATEBACKFORWARDSTATE = 62,
            OPTICAL_ZOOM = 63,
            OPTICAL_GETZOOMRANGE = 64,
            WINDOWSTATECHANGED = 65,
            ACTIVEXINSTALLSCOPE = 66,
            UPDATETRAVELENTRY_DATARECOVERY = 67,
            SHOWTASKDLG = 68,
            POPSTATEEVENT = 69,
            VIEWPORT_MODE = 70,
            LAYOUT_VIEWPORT_WIDTH = 71,
            VISUAL_VIEWPORT_EXCLUDE_BOTTOM = 72,
            USER_OPTICAL_ZOOM = 73,
            PAGEAVAILABLE = 74,
            GETUSERSCALABLE = 75,
            UPDATE_CARET = 76,
            ENABLE_VISIBILITY = 77,
            MEDIA_PLAYBACK = 78,
            SETFAVICON = 79,
            SET_HOST_FULLSCREENMODE = 80,
            EXITFULLSCREEN = 81,
            SCROLLCOMPLETE = 82,
            ONBEFOREUNLOAD = 83,
            SHOWMESSAGE_BLOCKABLE = 84,
            SHOWTASKDLG_BLOCKABLE = 85
        }
    }
}