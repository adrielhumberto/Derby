﻿using SampSharp.GameMode.Natives;

namespace SampSharp.Streamer.Natives
{
    public static partial class StreamerNative
    {
        public static int CreateDynamicCP(float x, float y, float z, float size, int worldid = -1, int interiorid = -1,
            int playerid = -1, float streamdistance = 100.0f)
        {
            return Native.CallNative("CreateDynamicCP",
                __arglist(x, y, z, size, worldid, interiorid, playerid, streamdistance));
        }

        public static int DestroyDynamicCP(int checkpointid)
        {
            return Native.CallNative("DestroyDynamicCP", __arglist(checkpointid));
        }

        public static bool IsValidDynamicCP(int checkpointid)
        {
            return Native.CallNativeAsBool("IsValidDynamicCP", __arglist(checkpointid));
        }

        public static int TogglePlayerDynamicCP(int playerid, int checkpointid, bool toggle)
        {
            return Native.CallNative("TogglePlayerDynamicCP", __arglist(playerid, checkpointid, toggle));
        }

        public static int TogglePlayerAllDynamicCPs(int playerid, bool toggle)
        {
            return Native.CallNative("TogglePlayerAllDynamicCPs", __arglist(playerid, toggle));
        }

        public static bool IsPlayerInDynamicCP(int playerid, int checkpointid)
        {
            return Native.CallNativeAsBool("IsPlayerInDynamicCP", __arglist(playerid, checkpointid));
        }

        public static int GetPlayerVisibleDynamicCP(int playerid)
        {
            return Native.CallNative("GetPlayerVisibleDynamicCP", __arglist(playerid));
        }
    }
}