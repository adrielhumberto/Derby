﻿using System;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Natives;
using SampSharp.GameMode.World;

namespace SampSharp.Streamer.Natives
{
    public static partial class StreamerNative
    {
        public static int CreateDynamicObjectEx(int modelid, float x, float y, float z, float rx, float ry, float rz,
            float drawdistance = 0.0f, float streamdistance = 200.0f, int[] worlds = null, int[] interiors = null,
            int[] players = null, int maxworlds = -1, int maxinteriors = -1, int maxplayers = -1)
        {
            //Check defaults
            if (worlds == null) worlds = new[] {-1};
            if (interiors == null) interiors = new[] {-1};
            if (players == null) players = new[] {-1};

            if (maxworlds < 0) maxworlds = worlds.Length;
            if (maxinteriors < 0) maxinteriors = interiors.Length;
            if (maxplayers < 0) maxplayers = players.Length;

            return Native.CallNative("CreateDynamicObjectEx", new[] {12, 13, 14},
                __arglist(
                    modelid, x, y, z, rx, ry, rz, drawdistance, streamdistance, worlds, interiors, players, maxworlds,
                    maxinteriors, maxplayers));
        }

        public static int CreateDynamicPickupEx(int modelid, int type, float x, float y, float z,
            float streamdistance = 100.0f, int[] worlds = null, int[] interiors = null, int[] players = null,
            int maxworlds = -1, int maxinteriors = -1, int maxplayers = -1)
        {
            //Check defaults
            if (worlds == null) worlds = new[] {-1};
            if (interiors == null) interiors = new[] {-1};
            if (players == null) players = new[] {-1};

            if (maxworlds < 0) maxworlds = worlds.Length;
            if (maxinteriors < 0) maxinteriors = interiors.Length;
            if (maxplayers < 0) maxplayers = players.Length;

            return Native.CallNative("CreateDynamicPickupEx", new[] {9, 10, 11},
                __arglist(
                    modelid, type, x, y, z, streamdistance, worlds, interiors, players, maxworlds, maxinteriors,
                    maxplayers));
        }

        public static int CreateDynamicCPEx(float x, float y, float z, float size, float streamdistance = 100.0f,
            int[] worlds = null, int[] interiors = null, int[] players = null, int maxworlds = -1, int maxinteriors = -1,
            int maxplayers = -1)
        {
            //Check defaults
            if (worlds == null) worlds = new[] {-1};
            if (interiors == null) interiors = new[] {-1};
            if (players == null) players = new[] {-1};

            if (maxworlds < 0) maxworlds = worlds.Length;
            if (maxinteriors < 0) maxinteriors = interiors.Length;
            if (maxplayers < 0) maxplayers = players.Length;

            return Native.CallNative("CreateDynamicCPEx", new[] {8, 9, 10},
                __arglist(x, y, z, size, streamdistance, worlds, interiors, players, maxworlds, maxinteriors, maxplayers
                    ));
        }

        public static int CreateDynamicRaceCPEx(CheckpointType type, float x, float y, float z, float nextx, float nexty,
            float nextz, float size, float streamdistance = 100.0f, int[] worlds = null, int[] interiors = null,
            int[] players = null, int maxworlds = -1, int maxinteriors = -1, int maxplayers = -1)
        {
            //Check defaults
            if (worlds == null) worlds = new[] {-1};
            if (interiors == null) interiors = new[] {-1};
            if (players == null) players = new[] {-1};

            if (maxworlds < 0) maxworlds = worlds.Length;
            if (maxinteriors < 0) maxinteriors = interiors.Length;
            if (maxplayers < 0) maxplayers = players.Length;

            return Native.CallNative("CreateDynamicRaceCPEx", new[] {12, 13, 14},
                __arglist(
                    type, x, y, z, nextx, nexty, nextz, size, streamdistance, worlds, interiors, players, maxworlds,
                    maxinteriors, maxplayers));
        }

        public static int CreateDynamicMapIconEx(float x, float y, float z, int type, int color,
            MapIconType style = MapIconType.Local, float streamdistance = 100.0f, int[] worlds = null,
            int[] interiors = null, int[] players = null, int maxworlds = -1, int maxinteriors = -1, int maxplayers = -1)
        {
            //Check defaults
            if (worlds == null) worlds = new[] {-1};
            if (interiors == null) interiors = new[] {-1};
            if (players == null) players = new[] {-1};

            if (maxworlds < 0) maxworlds = worlds.Length;
            if (maxinteriors < 0) maxinteriors = interiors.Length;
            if (maxplayers < 0) maxplayers = players.Length;

            return Native.CallNative("CreateDynamicMapIconEx", new[] {10, 11, 12},
                __arglist(
                    x, y, z, type, color, (int) style, streamdistance, worlds, interiors, players, maxworlds,
                    maxinteriors, maxplayers));
        }

        public static int CreateDynamic3DTextLabelEx(string text, int color, float x, float y, float z,
            float drawdistance, int attachedplayer = GtaPlayer.InvalidId, int attachedvehicle = GtaVehicle.InvalidId,
            bool testlos = false, float streamdistance = 100.0f, int[] worlds = null, int[] interiors = null,
            int[] players = null, int maxworlds = -1, int maxinteriors = -1, int maxplayers = -1)
        {
            //Check defaults
            if (worlds == null) worlds = new[] {-1};
            if (interiors == null) interiors = new[] {-1};
            if (players == null) players = new[] {-1};

            if (maxworlds < 0) maxworlds = worlds.Length;
            if (maxinteriors < 0) maxinteriors = interiors.Length;
            if (maxplayers < 0) maxplayers = players.Length;

            return Native.CallNative("CreateDynamic3DTextLabelEx", new[] {13, 14, 15},
                __arglist(
                    text, color, x, y, z, drawdistance, attachedplayer, attachedvehicle, testlos, streamdistance,
                    worlds, interiors, players, maxworlds, maxinteriors, maxplayers));
        }


        public static int CreateDynamicCircleEx(float x, float y, float size, int[] worlds = null,
            int[] interiors = null, int[] players = null, int maxworlds = -1, int maxinteriors = -1, int maxplayers = -1)
        {
            //Check defaults
            if (worlds == null) worlds = new[] {-1};
            if (interiors == null) interiors = new[] {-1};
            if (players == null) players = new[] {-1};

            if (maxworlds < 0) maxworlds = worlds.Length;
            if (maxinteriors < 0) maxinteriors = interiors.Length;
            if (maxplayers < 0) maxplayers = players.Length;

            return Native.CallNative("CreateDynamicCircleEx", new[] {6, 7, 8},
                __arglist(x, y, size, worlds, interiors, players, maxworlds, maxinteriors, maxplayers));
        }

        public static int CreateDynamicRectangleEx(float minx, float miny, float maxx, float maxy, int[] worlds = null,
            int[] interiors = null, int[] players = null, int maxworlds = -1, int maxinteriors = -1, int maxplayers = -1)
        {
            //Check defaults
            if (worlds == null) worlds = new[] {-1};
            if (interiors == null) interiors = new[] {-1};
            if (players == null) players = new[] {-1};

            if (maxworlds < 0) maxworlds = worlds.Length;
            if (maxinteriors < 0) maxinteriors = interiors.Length;
            if (maxplayers < 0) maxplayers = players.Length;

            return Native.CallNative("CreateDynamicRectangleEx", new[] {7, 8, 9},
                __arglist(minx, miny, maxx, maxy, worlds, interiors, players, maxworlds, maxinteriors, maxplayers));
        }

        public static int CreateDynamicSphereEx(float x, float y, float z, float size, int[] worlds = null,
            int[] interiors = null, int[] players = null, int maxworlds = -1, int maxinteriors = -1, int maxplayers = -1)
        {
            //Check defaults
            if (worlds == null) worlds = new[] {-1};
            if (interiors == null) interiors = new[] {-1};
            if (players == null) players = new[] {-1};

            if (maxworlds < 0) maxworlds = worlds.Length;
            if (maxinteriors < 0) maxinteriors = interiors.Length;
            if (maxplayers < 0) maxplayers = players.Length;

            return Native.CallNative("CreateDynamicSphereEx", new[] {7, 8, 9},
                __arglist(x, y, z, size, worlds, interiors, players, maxworlds, maxinteriors, maxplayers));
        }

        public static int CreateDynamicCubeEx(float minx, float miny, float minz, float maxx, float maxy, float maxz,
            int[] worlds = null, int[] interiors = null, int[] players = null, int maxworlds = -1, int maxinteriors = -1,
            int maxplayers = -1)
        {
            //Check defaults
            if (worlds == null) worlds = new[] {-1};
            if (interiors == null) interiors = new[] {-1};
            if (players == null) players = new[] {-1};

            if (maxworlds < 0) maxworlds = worlds.Length;
            if (maxinteriors < 0) maxinteriors = interiors.Length;
            if (maxplayers < 0) maxplayers = players.Length;

            return Native.CallNative("CreateDynamicCubeEx", new[] {9, 10, 11},
                __arglist(
                    minx, miny, minz, maxx, maxy, maxz, worlds, interiors, players, maxworlds, maxinteriors, maxplayers));
        }

        public static int CreateDynamicPolygonEx(float[] points, float minz = float.NegativeInfinity,
            float maxz = float.PositiveInfinity, int maxpoints = -1, int[] worlds = null, int[] interiors = null,
            int[] players = null, int maxworlds = -1, int maxinteriors = -1, int maxplayers = -1)
        {
            if (points == null)
                throw new NullReferenceException("points cannot be null");

            //Check defaults
            if (worlds == null) worlds = new[] {-1};
            if (interiors == null) interiors = new[] {-1};
            if (players == null) players = new[] {-1};

            if (maxworlds < 0) maxworlds = worlds.Length;
            if (maxinteriors < 0) maxinteriors = interiors.Length;
            if (maxplayers < 0) maxplayers = players.Length;
            if (maxpoints < 0) maxpoints = points.Length;

            return Native.CallNative("CreateDynamicPolygonEx", new[] {3, 7, 8, 9},
                __arglist(points, minz, maxz, maxpoints, worlds, interiors, players, maxworlds, maxinteriors, maxplayers
                    ));
        }
    }
}