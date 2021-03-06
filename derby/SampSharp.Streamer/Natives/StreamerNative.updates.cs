﻿using SampSharp.GameMode.Natives;
using SampSharp.Streamer.Definitions;

namespace SampSharp.Streamer.Natives
{
    public static partial class StreamerNative
    {
        public static int ProcessActiveItems()
        {
            return Native.CallNative("Streamer_ProcessActiveItems");
        }

        public static int ToggleIdleUpdate(int playerid, bool toggle)
        {
            return Native.CallNative("Streamer_ToggleIdleUpdate", __arglist(playerid, toggle));
        }

        public static int ToggleItemUpdate(int playerid, StreamType type, bool toggle)
        {
            return Native.CallNative("Streamer_ToggleItemUpdate", __arglist(playerid, (int) type, toggle));
        }

        public static int Update(int playerid)
        {
            return Native.CallNative("Streamer_Update", __arglist(playerid));
        }

        public static int Update(int playerid, StreamType type)
        {
            return Native.CallNative("Streamer_Update", __arglist(playerid, (int) type));
        }

        public static int UpdateEx(int playerid, float x, float y, float z, int worldid = -1, int interiorid = -1)
        {
            return Native.CallNative("Streamer_UpdateEx", __arglist(playerid, x, y, z, worldid, interiorid));
        }

        public static int UpdateEx(int playerid, float x, float y, float z, int worldid = -1, int interiorid = -1,
            StreamType type = StreamType.All)
        {
            return Native.CallNative("Streamer_UpdateEx", __arglist(playerid, x, y, z, worldid, interiorid, (int) type));
        }
    }
}