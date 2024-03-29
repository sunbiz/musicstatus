﻿using System;

namespace MusicStatus
{
    class JetAudio6_API
    {
        public const int WM_APP = 0x8000;

        //////////////////////////////////////////////////////////////////////////
        // Change current mode
        // wParam : CMP_CDP (Disc Mode), CMP_DGA (File Mode)
        // lParam : None
        // -> SendMessage(m_hWndJetAudio, WM_REMOCON_CHANGE_COMPONENT, CMP_DGA, 0); // change to file mode
        public const int CMP_CDP = 2;
        public const int CMP_DGA = 3;

        public const int WM_REMOCON_CHANGE_COMPONENT = WM_APP + 750;

        #region Constants
        public const int MAX_REVERB_MODE = 4;
        public const int MAX_EQ_MODE = 14;
        public const int MAX_REPEAT_METHOD = 3;
        public const int MAX_RANDOM_METHOD = 3;
        public const int MAX_TIME_METHOD = 2;
        #endregion

        #region Primary Control Commands
        //////////////////////////////////////////////////////////////////////////
        // Command
        //////////////////////////////////////////////////////////////////////////
        // Message for command.
        // wParam : currently not used
        // lParam : refer to Action commands below
        public const int WM_REMOCON_SENDCOMMAND = WM_APP + 741;

        //////////////////////////////////////////////////////////////////////////
        //
        // Action command
        // 
        // Usage -> SendMessage(m_hWndJetAudio, WM_REMOCON_SENDCOMMAND, 0, MAKELPARAM(command, para));
        //
        //////////////////////////////////////////////////////////////////////////

        // Stop Playback
        // Para : not used
        // Return : N/A
        public const int JRC_ID_STOP = 5102;

        // Start playback
        // Para : Track Number ( >= 1 ). Use 0 for normal play/pause.
        // Return : N/A
        public const int JRC_ID_PLAY = 5104;

        // Start playback or Resume
        // Para : Track Number ( >= 1 ). Use 0 for normal playback.
        public const int JRC_ID_PLAY_RESUME = 5105;

        // Play previous track
        // Para : not used 
        // Return : N/A
        public const int JRC_ID_PREV_TRACK = 5107;

        // Play next track 
        // Para : not used
        // Return : N/A
        public const int JRC_ID_NEXT_TRACK = 5108;

        // RepeatMethod 
        // Para : desired repeat mode (1 - 3) or 0 for next repeat mode
        // Return : current repeat mode
        public const int JRC_ID_REPEATMODE = 5112;

        // Move 10 seconds backward. 
        // Para : not used
        // Return : N/A
        public const int JRC_ID_BACKWARD = 5115;

        // Move 10 seconds forward
        // Para : not used 
        // Return : N/A
        public const int JRC_ID_FORWARD = 5116;

        // RandomMode
        // Para : desired random mode (1 - 3) or 0 for next random mode
        // Return : current random mode
        public const int JRC_ID_RANDOMMODE = 5117;

        // Slower playback.
        // Para : not used 
        // Return : N/A
        public const int JRC_ID_PLAY_SLOW = 5128;

        // Faster playback.
        // Para : not used
        // Return : N/A
        public const int JRC_ID_PLAY_FAST = 5129;

        // Volume down. 
        // Para : not used
        // Return : current volume (0 - 32)
        public const int JRC_ID_VOL_DOWN = 5134;

        // Volume up.
        // Para : not used 
        // Return : current volume (0 - 32)
        public const int JRC_ID_VOL_UP = 5135;

        // This command is not used anymore. 
        public const int JRC_ID_VIDEOCD = 5168;

        // Exit Jet-Audio.
        // Para : not used 
        // Return : N/A
        public const int JRC_ID_EXIT = 5171;

        // Mute sound
        // Para : 0(Toggle), 1(ON), -1(OFF) 
        // Return : current mute status
        public const int JRC_ID_ATT = 5172;

        // Change main volume.
        // Para : Volume Value (0 - 100)
        // Return : current volume
        public const int JRC_ID_SET_VOLUME = 5180;

        #endregion

        #region Secondary Control Commands
        // Change timer.
        // Para : second (0 is timer off)
        // Return : N/A
        public const int JRC_ID_SET_TIMER = 5181;

        // Set screen size as 1x.
        // Para : not used 
        // Return : N/A
        public const int JRC_ID_SCREEN_1X = 5188;

        // Set screen size as 2x.
        // Para : not used 
        // Return : N/A
        public const int JRC_ID_SCREEN_2X = 5189;

        // Set screen to full screen mode.
        // Para : not used 
        // Return : N/A
        public const int JRC_ID_SCREEN_FULL = 5190;

        // Change equalizer mode.
        // Para : desired eq mode (0 - 13) or -1 for next eq
        // Return : current eq mode
        public const int JRC_ID_CHANGE_EQ = 5191;

        // Move playback position.
        // Para : New position (second)
        // Return : N/A
        public const int JRC_ID_SEEK = 5192;

        // Change Reverb mode
        // Para : desired reverb mode (0 - 3) or -1 for next reverb mode
        //        To turn off/on, send current reverb mode as parameter
        // Return : current reverb mode (0 - 3) or -1 if turned off
        public const int JRC_ID_CHANGE_SFX_REVERB = 5200;

        // GoUp/Return (for VideoCD/DVD)
        // Para : not used
        // Return : N/A
        public const int JRC_ID_GOUP = 5202;

        // Toggle screen mode between windowed / full screen mode
        // Para : not used
        // Return : 1 if full screen, 0 if windowed mode
        public const int JRC_ID_CHANGE_SCREEN_SIZE = 5205;

        // Change Album sequentially
        // Para : 1 (next album) or -1 (previous album)
        //        For disc mode, change drive 
        // Return : N/A
        // Note : sends WM_COPYDATA message (JRC_COPYDATA_ID_ALBUMNAME or JRC_COPYDATA_ID_DRIVENAME)
        public const int JRC_ID_CHANGE_ALBUM = 5206;

        // Minimize/Restore Jet-Audio
        // Para : not used
        // Return : 0:minimized or hidden, 1:normal 
        public const int JRC_ID_MINIMIZE = 5701;

        // Change Wide mode 
        // Para : 0(Toggle), 1(ON), -1(OFF)
        // Return : current status
        public const int JRC_ID_CHANGE_SFX_WIDE = 6000;

        // Change XBass mode 
        // Para : 0(Toggle), 1(ON), -1(OFF)
        // Return : current status
        public const int JRC_ID_CHANGE_SFX_XBASS = 6001;

        // Change BBE mode 
        // Para : 0(Toggle), 1(ON), -1(OFF)
        // Return : current status
        public const int JRC_ID_CHANGE_SFX_BBE = 6002;

        // Change B3D(BBE ViVA) mode 
        // Para : 0(Toggle), 1(ON), -1(OFF)
        // Return : current status
        public const int JRC_ID_CHANGE_SFX_B3D = 6003;

        // Show Open dialog box
        // Para : not used
        // Return : N/A
        public const int JRC_ID_OPEN_FILES = 6004;

        // Eject current CD-ROM drive
        // Para : not used
        // Return : N/A
        public const int JRC_ID_EJECT_DRIVE = 6005;

        // Change current CD-ROM drive
        // Para : drive letter
        // Return : N/A
        public const int JRC_ID_SELECT_DRIVE = 6006;

        // Change to tray-only mode
        // Para : not used
        // Return : N/A
        public const int JRC_ID_GOTO_TRAY = 6007;

        // Load album
        // Para : album index
        // Return : N/A
        public const int JRC_ID_SELECT_ALBUM = 6008;

        // Refresh contents of current album
        // Para : not used
        // Return : N/A
        public const int JRC_ID_ALBUM_REFRESH = 6009;

        // Sort contents of current album
        // Para : not used
        // Return : N/A
        public const int JRC_ID_ALBUM_SORT = 6010;

        // Change Crossfade mode 
        // Para : 0(Toggle), 1(ON), -1(OFF)
        // Return : current status
        public const int JRC_ID_CHANGE_SFX_XFADE = 6011;

        // Change X-Surround mode 
        // Para : 0(Toggle), 1(ON), -1(OFF)
        // Return : current status
        public const int JRC_ID_CHANGE_SFX_XSR = 6012;
        #endregion

        #region DVD Control Commands
        //===============================DVD====================================//
        // Change DVD / Video Language sequentially
        // Para : 0 (Next Language), 1 ~ Num Audio (Choose the Language)
        // Return : New Audio Index (0 or 1 ~ Num Audio)
        // Note : sends WM_COPYDATA message (JRC_COPYDATA_ID_DVD_LANGUAGE)
        public const int JRC_ID_DVD_CHANGE_LANGUAGE = 7030;

        // Change DVD / Video Subtitle sequentially
        // Para : 0 (Next Subtitle), 1~ Num Subtitle (Choose the Subtitle)
        // Return : New Subtitle Index (0 or 1 ~ Num Subtitle)
        // Note : sends WM_COPYDATA message (JRC_COPYDATA_ID_DVD_SUBTITLE)
        public const int JRC_ID_DVD_CHANGE_SUBTITLE = 7031;

        // Change DVD Angle sequentially
        // Para : 0 (Next Angle), 1~ Num Angle (Choose the Angle)
        // Return : New Angle (0 or 1 ~ Num Angle)
        // Note : sends WM_COPYDATA message (JRC_COPYDATA_ID_DVD_ANGLE)
        public const int JRC_ID_DVD_CHANGE_ANGLE = 7032;

        // Change DVD / Video Subtitle Flag (ON/OFF) : (API v5)
        // Para : 0 (Toggle), 1(ON), -1(OFF)
        // Return : New Subtitle Flag
        // Note : sends WM_COPYDATA message (JRC_COPYDATA_ID_DVD_SUBTITLE)
        public const int JRC_ID_DVD_SUBTITLE_FLAG = 7033;

        // Call DVD Title Menu
        // Para : not used
        // Return : N/A
        public const int JRC_ID_DVDMENU_TITLE = 7050;

        // Call DVD Root Menu
        // Para : not used
        // Return : N/A
        public const int JRC_ID_DVDMENU_ROOT = 7051;

        // Handle Button : (API v4)
        // Para : Button Key (VK_UP, VK_DOWN, VK_LEFT, VK_RIGHT, VK_RETURN)
        public const int JRC_ID_DVD_BUTTON = 7052;
        #endregion

        #region Status
        // Message for status. wParam is not used. For lParam, refer to commands below
        public const int WM_REMOCON_GETSTATUS = WM_APP + 740;

        //////////////////////////////////////////////////////////////////////////
        // Status command
        // Usage -> return = SendMessage(m_hWndJetAudio, WM_REMOCON_GETSTATUS, hWndReturn, command);
        //////////////////////////////////////////////////////////////////////////

        public const int GET_STATUS_START = 0;	// Indicator for component commands

        // Return : MCI_MODE_PAUSE(529) or MCI_MODE_PLAY(526) or MCI_MODE_STOP(525)
        public const int GET_STATUS_STATUS = 1;

        // Return : 0:Elapsed, 1:Remaining
        public const int GET_STATUS_TIME_MODE = 2;

        // Return : 0:Normal, 1:Random, 2:Program
        public const int GET_STATUS_RANDOM_MODE = 3;

        // Return : 0:Normal, 1:Repeat This, 2:Repeat All
        public const int GET_STATUS_REPEAT_MODE = 4;

        // Get track information of current track
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_TRACK_INFO)
        public const int GET_STATUS_TRACK_INFO = 5;

        // Return : current speed
        public const int GET_STATUS_SPEED = 6;

        // Return : number of tracks in current album
        public const int GET_STATUS_MAX_TRACK = 7;

        // Return : current track number
        public const int GET_STATUS_CUR_TRACK = 8;

        // Return : current playback time
        public const int GET_STATUS_CUR_TIME = 9;

        // Return : length of current track (in msec)
        public const int GET_STATUS_MAX_TIME = 10;

        // Get file name of current track 
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_TRACK_FILENAME)
        public const int GET_STATUS_TRACK_FILENAME = 11;

        // Get title info of current track 
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_TRACK_TITLE)
        public const int GET_STATUS_TRACK_TITLE = 12;

        // Get artist info of current track 
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_TRACK_ARTIST)
        public const int GET_STATUS_TRACK_ARTIST = 13;

        // Get all tracks of current album
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_TRACK_LIST)
        public const int GET_STATUS_TRACK_LIST = 14;

        // Get id of current album
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_ALBUMID)
        public const int GET_STATUS_ALBUMID = 15;

        // Return : current drive letter
        public const int GET_STATUS_CUR_DRIVE = 16;

        // Get all drive letters of CD-ROM drives
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_DRIVE_LIST)
        public const int GET_STATUS_DRIVE_LIST = 17;

        // Get all albums of jetaudio
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_ALBUM_LIST)
        public const int GET_STATUS_ALBUM_LIST = 18;

        // Get album information of current album
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_ALBUM_INFO)
        public const int GET_STATUS_ALBUM_INFO = 19;
        #endregion

        #region Secondary Status
        // for VideoCD/DVD
        // 0:Normal, 1:VCD Menu, 2:DVD Menu
        public const int GET_STATUS_MENU_MODE = 20;

        // Get all tracks of current album : (API v4)
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_TRACK_LIST_EX)
        public const int GET_STATUS_TRACK_LIST_EX = 21;


        // This command is not used anymore
        public const int GET_STATUS_RUNTIME_FLAG = 101;

        // This command is not used anymore
        public const int GET_STATUS_QUICKWINDOW = 102;

        // Get Mute status
        // Return : 0:Mute OFF, 1:Mute ON
        public const int GET_STATUS_ATT = 110;

        // Get EQ mode
        // Return : 0 - 13
        public const int GET_STATUS_EQ_MODE = 111;

        // Get Reverb status
        // Return : 0:OFF, 1:ON
        public const int GET_STATUS_REVERB_FLAG = 120;

        // Get Reverb status
        // Return : 0 - 4
        public const int GET_STATUS_REVERB_MODE = 121;

        // Get screen mode
        // Return : 0:Windowed, 1:Full screen
        public const int GET_STATUS_SCREEN_MODE = 122;

        // Get Wide status
        // Return : 0:OFF, 1:ON
        public const int GET_STATUS_WIDE_FLAG = 123;

        // Get X-Bass status
        // Return : 0:OFF, 1:ON
        public const int GET_STATUS_XBASS_FLAG = 124;

        // Get BBE status
        // Return : 0:OFF, 1:ON
        public const int GET_STATUS_BBE_FLAG = 125;

        // Get BBE ViVA status
        // Return : 0:OFF, 1:ON
        public const int GET_STATUS_B3D_FLAG = 126;

        // Get Volume
        // Return : 0 - 100
        public const int GET_STATUS_VOLUME = 127;

        // Get current mode
        // Return : 1:Disc mode, 0:File mode
        public const int GET_STATUS_PLAY_MODE = 128;

        // Get current video disc playback mode
        // for VCD/DVD
        public const int GET_STATUS_VCD_MODE = 130;	// 0:None, 1:VCD, 2:DVD

        // Get X-Surround status
        // Return : 0:OFF, 1:ON
        public const int GET_STATUS_XSR_FLAG = 131;

        // Get Crossfade status
        // Return : 0:OFF, 1:ON
        public const int GET_STATUS_XFADE_FLAG = 132;
        #endregion

        #region Streaming Status
        //////////////////////////////////////////////////////////////////////////
        // Get Current Audio Stream : (API v5)
        // Return : Audio Number (1 ~ Num Audio)
        public const int GET_STATUS_CUR_AUDIO = 140;

        // Get Number of Audio Streams : (API v5)
        // Return : Number of Audio
        public const int GET_STATUS_NUM_AUDIO = 141;

        // Get Current Subtitle Stream : (API v5)
        // Return : Subtitle Number (1 ~ Num Subtitle)
        public const int GET_STATUS_CUR_SUBTITLE = 142;

        // Get Number of Subtitle Streams : (API v5)
        // Return : Number of Subtitle
        public const int GET_STATUS_NUM_SUBTITLE = 143;

        // Get Current Subtitle Flag (On/Off) : (API v5)
        // Return : Subtitle Flag (0:OFF, 1:ON)
        public const int GET_STATUS_SUBTITLE_FLAG = 144;

        // Get Current Audio Info : (API v5)
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_DVD_LANGUAGE)
        public const int GET_STATUS_CUR_AUDIO_INFO = 145;

        // Get Current Subtitle Info : (API v5)
        // string will be returned using WM_COPYDATA message (JRC_COPYDATA_ID_DVD_SUBTITLE)
        public const int GET_STATUS_CUR_SUBTITLE_INFO = 146;
        #endregion

        //////////////////////////////////////////////////////////////////////////
        // To get notification for various status (wParam is hWnd) : (API v5)
        public const int GET_STATUS_REGISTER_NOTIFICATION = 990;

        // To get notification for various status (wParam is hWnd) : (API v5)
        public const int GET_STATUS_UNREGISTER_NOTIFICATION = 991;

        // Get JetAudio's version info
        public const int GET_STATUS_JETAUDIO_VER1 = 995;	// major version number -> 6 for 6.1.7
        public const int GET_STATUS_JETAUDIO_VER2 = 996;	// minor version number -> 1 for 6.1.7
        public const int GET_STATUS_JETAUDIO_VER3 = 997;	// build version number -> 7 for 6.1.7

        // Get JetAudio supported API version
        // 0 : FirstVersion, 
        // 1 : DVD & Album Name & Track Name supported
        // 2 : JetAudio 5
        // 3 : JetAudio 5.2 or later
        // 4 : JetAudio 7 (support remote controller)
        // 5 : JetAudio 7.1
        public const int GET_STATUS_SUPPORTED_VER = 999;



        //////////////////////////////////////////////////////////////////////////
        // WM_COPYDATA is used for receive string information from Jet-Audio
        // For more information, refer to example source code
        //////////////////////////////////////////////////////////////////////////
        public const int JRC_COPYDATA_ID_ALBUMNAME = 0x1000;
        public const int JRC_COPYDATA_ID_DRIVENAME = 0x1001;
        public const int JRC_COPYDATA_ID_GETVER = 0x1002;
        public const int JRC_COPYDATA_ID_ALBUM_CHANGED = 0x1003;
        public const int JRC_COPYDATA_ID_ALBUM_REMOVED = 0x1004;
        public const int JRC_COPYDATA_ID_ALBUM_ADDED = 0x1005;

        public const int JRC_COPYDATA_ID_TRACK_CHANGED = 0x1010;	// (API v5) send automatically when track was changed (1, 2, ..)
        public const int JRC_COPYDATA_ID_STATUS_CHANGED = 0x1011;	// (API v5) send automatically when status was changed (Play, Pause, ...)
        public const int JRC_COPYDATA_ID_PLAY_MODE_CHANGED = 0x1012;	// (API v5) send automatically when mode was changed (AudioCD, VideoCD, DVD, File)
        public const int JRC_COPYDATA_ID_MAIN_ALBUM_CHANGED = 0x1013;	// (API v5) send automatically when album of main window was changed

        public const int JRC_COPYDATA_ID_DVD_CHAPTER = 0x2000;
        public const int JRC_COPYDATA_ID_DVD_LANGUAGE = 0x2001;
        public const int JRC_COPYDATA_ID_DVD_SUBTITLE = 0x2002;
        public const int JRC_COPYDATA_ID_DVD_ANGLE = 0x2003;

        public const int JRC_COPYDATA_ID_TRACK_FILENAME = 0x3000;
        public const int JRC_COPYDATA_ID_TRACK_TITLE = 0x3001;
        public const int JRC_COPYDATA_ID_TRACK_ARTIST = 0x3002;
        public const int JRC_COPYDATA_ID_TRACK_LIST = 0x3003;
        public const int JRC_COPYDATA_ID_ALBUMID = 0x3004;
        public const int JRC_COPYDATA_ID_DRIVE_LIST = 0x3005;
        public const int JRC_COPYDATA_ID_ALBUM_LIST = 0x3006;
        public const int JRC_COPYDATA_ID_ALBUM_INFO = 0x3007;
        public const int JRC_COPYDATA_ID_TRACK_INFO = 0x3008;
        public const int JRC_COPYDATA_ID_TRACK_LIST_EX = 0x3009;	// (API v4) 

        public const int JRC_COPYDATA_ID_STRING = 0x9000;	// (API v4) 

    }
}
