﻿using System;
using System.Collections.Generic;
using System.Linq;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;
using SampSharp.Streamer.Definitions;
using SampSharp.Streamer.Natives;

namespace SampSharp.Streamer.World
{
    public class DynamicArea : DynamicWorldObject<DynamicArea>
    {
        public DynamicArea(int id)
        {
            Id = id;
        }

        #region Factories

        public static DynamicArea CreateCircle(float x, float y, float size, int worldid = -1, int interiorid = -1,
            GtaPlayer player = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicCircle(x, y, size, worldid, interiorid,
                    player == null ? -1 : player.Id));
        }

        public static DynamicArea CreateCircleEx(float x, float y, float size, int[] worlds = null,
            int[] interiors = null,
            GtaPlayer[] players = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicCircleEx(x, y, size, worlds, interiors,
                    players == null ? null : players.Select(p => p.Id).ToArray()));
        }

        public static DynamicArea CreateCube(float minx, float miny, float minz, float maxx, float maxy, float maxz,
            int worldid = -1, int interiorid = -1, GtaPlayer player = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicCube(minx, miny, minz, maxx, maxy, maxz, worldid, interiorid,
                    player == null ? -1 : player.Id));
        }


        public static DynamicArea CreateCube(Vector min, Vector max, int worldid = -1, int interiorid = -1,
            GtaPlayer player = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicCube(min.X, min.Y, min.Z, max.X, max.Y, max.Z, worldid,
                    interiorid, player == null ? -1 : player.Id));
        }

        public static DynamicArea CreateCubeEx(float minx, float miny, float minz, float maxx, float maxy, float maxz,
            int[] worlds = null, int[] interiors = null, GtaPlayer[] players = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicCubeEx(minx, miny, minz, maxx, maxy, maxz, worlds,
                    interiors, players == null ? null : players.Select(p => p.Id).ToArray()));
        }

        public static DynamicArea CreateCubeEx(Vector min, Vector max, int[] worlds = null, int[] interiors = null,
            GtaPlayer[] players = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicCubeEx(min.X, min.Y, min.Z, max.X, max.Y, max.Z, worlds,
                    interiors, players == null ? null : players.Select(p => p.Id).ToArray()));
        }

        public static DynamicArea CreatePolygon(float[] points, float minz = float.NegativeInfinity,
            float maxz = float.PositiveInfinity, int worlid = -1, int interiorid = -1, GtaPlayer player = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicPolygon(points, minz, maxz, points.Length, worlid, interiorid,
                    player == null ? -1 : player.Id));
        }

        public static DynamicArea CreatePolygon(Vector[] points, float minz, float maxz, int worlid = -1,
            int interiorid = -1, GtaPlayer player = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicPolygon(points.SelectMany(p => new[] {p.X, p.Y}).ToArray(),
                    minz, maxz, points.Length * 2, worlid, interiorid, player == null ? -1 : player.Id));
        }

        public static DynamicArea CreatePolygon(Vector[] points, int worlid = -1, int interiorid = -1,
            GtaPlayer player = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicPolygon(points.SelectMany(p => new[] {p.X, p.Y}).ToArray(),
                    points.Min(p => p.Z), points.Max(p => p.Z), points.Length * 2, worlid, interiorid, player == null ? -1 : player.Id));
        }

        public static DynamicArea CreatePolygonEx(float[] points, float minz = float.NegativeInfinity,
            float maxz = float.PositiveInfinity, int[] worlds = null, int[] interiors = null, GtaPlayer[] players = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicPolygonEx(points, minz, maxz, points.Length, worlds, interiors,
                    players == null ? null : players.Select(p => p.Id).ToArray()));
        }

        public static DynamicArea CreatePolygonEx(Vector[] points, float minz = float.NegativeInfinity,
            float maxz = float.PositiveInfinity, int[] worlds = null, int[] interiors = null, GtaPlayer[] players = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicPolygonEx(points.SelectMany(p => new[] {p.X, p.Y}).ToArray(),
                    minz, maxz, points.Length * 2, worlds, interiors, players == null ? null : players.Select(p => p.Id).ToArray()));
        }

        public static DynamicArea CreatePolygonEx(Vector[] points, int[] worlds = null, int[] interiors = null,
            GtaPlayer[] players = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicPolygonEx(points.SelectMany(p => new[] {p.X, p.Y}).ToArray(),
                    points.Min(p => p.Z), points.Max(p => p.Z), points.Length * 2, worlds, interiors,
                    players == null ? null : players.Select(p => p.Id).ToArray()));
        }

        public static DynamicArea CreateRectangle(float minx, float miny, float maxx, float maxy, int worldid = -1,
            int interiorid = -1, GtaPlayer player = null)
        {
            return FindOrCreate(StreamerNative.CreateDynamicRectangle(minx, miny, maxx, maxy, worldid, interiorid,
                player == null ? -1 : player.Id));
        }

        public static DynamicArea CreateRectangleEx(float minx, float miny, float maxx, float maxy, int[] worlds = null,
            int[] interiors = null, GtaPlayer[] players = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicRectangleEx(minx, miny, maxx, maxy, worlds, interiors,
                    players == null ? null : players.Select(p => p.Id).ToArray()));
        }

        public static DynamicArea CreateSphere(Vector pos, float size, int worldid = -1, int interiorid = -1,
            GtaPlayer player = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicSphere(pos.X, pos.Y, pos.Z, size, worldid, interiorid,
                    player == null ? -1 : player.Id));
        }

        public static DynamicArea CreateSphereEx(Vector pos, float size, int[] worlds = null, int[] interiors = null,
            GtaPlayer[] players = null)
        {
            return
                FindOrCreate(StreamerNative.CreateDynamicSphereEx(pos.X, pos.Y, pos.Z, size, worlds, interiors,
                    players == null ? null : players.Select(p => p.Id).ToArray()));
        }

        #endregion

        public bool IsValid
        {
            get { return StreamerNative.IsValidDynamicArea(Id); }
        }

        public override StreamType StreamType
        {
            get { return StreamType.Area; }
        }

        public event EventHandler<PlayerEventArgs> Enter;
        public event EventHandler<PlayerEventArgs> Leave;

        public void AttachTo(IGameObject obj)
        {
            AssertNotDisposed();

            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            if (!(obj is IIdentifiable))
            {
                throw new ArgumentException("obj must be IIdentifiable");
            }

            int playerid = GtaPlayer.InvalidId;
            int objectid = (obj as IIdentifiable).Id;
            var type = StreamerObjectType.Global;

            if (obj is IOwnable<GtaPlayer>)
            {
                playerid = (obj as IOwnable<GtaPlayer>).Owner.Id;
            }
            if (obj is PlayerObject)
            {
                type = StreamerObjectType.Player;
            }
            if (obj is DynamicObject)
            {
                type = StreamerObjectType.Dynamic;
            }

            StreamerNative.AttachDynamicAreaToObject(Id, objectid, type, playerid);
        }

        public void AttachTo(GtaPlayer player)
        {
            AssertNotDisposed();

            if (player == null)
            {
                throw new ArgumentNullException("player");
            }

            StreamerNative.AttachDynamicAreaToPlayer(Id, player.Id);
        }

        public void AttachTo(GtaVehicle vehicle)
        {
            AssertNotDisposed();

            if (vehicle == null)
            {
                throw new ArgumentNullException("vehicle");
            }

            StreamerNative.AttachDynamicAreaToVehicle(Id, vehicle.Id);
        }

        public bool IsInArea(GtaPlayer player, bool recheck = false)
        {
            AssertNotDisposed();

            if (player == null)
            {
                throw new ArgumentNullException("player");
            }

            return StreamerNative.IsPlayerInDynamicArea(player.Id, Id, recheck);
        }

        public bool IsInArea(IWorldObject obj)
        {
            AssertNotDisposed();

            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            return StreamerNative.IsPointInDynamicArea(Id, obj.Position.X, obj.Position.Y, obj.Position.Z);
        }

        public bool IsInArea(Vector point)
        {
            AssertNotDisposed();

            return StreamerNative.IsPointInDynamicArea(Id, point.X, point.Y, point.Z);
        }

        public bool IsAnyPlayerInArea(bool recheck = false)
        {
            AssertNotDisposed();

            return StreamerNative.IsAnyPlayerInDynamicArea(Id, recheck);
        }

        public static bool IsPlayerInAnyArea(GtaPlayer player, bool recheck = false)
        {
            if (player == null)
            {
                throw new ArgumentNullException("player");
            }

            return StreamerNative.IsPlayerInAnyDynamicArea(player.Id, recheck);
        }

        public static bool IsAnyPlayerInAnyArea(bool recheck = false)
        {
            return StreamerNative.IsAnyPlayerInAnyDynamicArea(recheck);
        }

        public static int GetAreaCountForPlayer(GtaPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentNullException("player");
            }

            return StreamerNative.GetPlayerNumberDynamicAreas(player.Id);
        }

        public static IEnumerable<DynamicArea> GetAreasForPlayer(GtaPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentNullException("player");
            }

            int[] areas;
            StreamerNative.GetPlayerDynamicAreas(player.Id, out areas, GetAreaCountForPlayer(player));

            return areas == null ? null : areas.Select(FindOrCreate);
        }

        public void ToggleForPlayer(GtaPlayer player, bool toggle)
        {
            AssertNotDisposed();

            if (player == null)
            {
                throw new ArgumentNullException("player");
            }

            StreamerNative.TogglePlayerDynamicArea(player.Id, Id, toggle);
        }

        public static void ToggleAllForPlayer(GtaPlayer player, bool toggle)
        {
            if (player == null)
            {
                throw new ArgumentNullException("player");
            }

            StreamerNative.TogglePlayerAllDynamicAreas(player.Id, toggle);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            StreamerNative.DestroyDynamicArea(Id);
        }

        public virtual void OnEnter(PlayerEventArgs e)
        {
            if (Enter != null)
                Enter(this, e);
        }

        public virtual void OnLeave(PlayerEventArgs e)
        {
            if (Leave != null)
                Leave(this, e);
        }
    }
}