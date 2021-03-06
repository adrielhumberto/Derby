﻿using System;
using System.Collections.Generic;
using System.Linq;
using SampSharp.GameMode.Pools;
using SampSharp.GameMode.World;
using SampSharp.Streamer.Definitions;

namespace SampSharp.Streamer.World
{
    public abstract class DynamicWorldObject<T> : IdentifiedPool<T>, IIdentifiable, IWorldObject
        where T : DynamicWorldObject<T>
    {
        public abstract StreamType StreamType { get; }

        public virtual int Interior
        {
            get { return GetInteger(StreamerDataType.InteriorId); }
            set { SetInteger(StreamerDataType.InteriorId, value); }
        }

        public virtual IEnumerable<int> Interiors
        {
            get { return GetArray(StreamerDataType.InteriorId, 1024).Where(v => v != int.MinValue); }
            set
            {
                if (value == null)
                {
                    SetArray(StreamerDataType.InteriorId, new[] {-1});
                    return;
                }
                SetArray(StreamerDataType.InteriorId, value.ToArray());
            }
        }

        public virtual int World
        {
            get { return GetInteger(StreamerDataType.WorldId); }
            set { SetInteger(StreamerDataType.WorldId, value); }
        }

        public virtual IEnumerable<int> Worlds
        {
            get { return GetArray(StreamerDataType.WorldId, 1024).Where(v => v != int.MinValue); }
            set
            {
                if (value == null)
                {
                    SetArray(StreamerDataType.WorldId, new[] {-1});
                    return;
                }
                SetArray(StreamerDataType.WorldId, value.ToArray());
            }
        }

        public virtual GtaPlayer Player
        {
            get { return GtaPlayer.FindOrCreate(GetInteger(StreamerDataType.PlayerId)); }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                SetInteger(StreamerDataType.PlayerId, value.Id);
            }
        }

        public virtual IEnumerable<GtaPlayer> Players
        {
            get
            {
                return
                    GetArray(StreamerDataType.PlayerId, 1024)
                        .Where(v => v != int.MinValue)
                        .Select(GtaPlayer.FindOrCreate);
            }
            set
            {
                if (value == null)
                {
                    SetArray(StreamerDataType.PlayerId, new[] {-1});
                    return;
                }
                SetArray(StreamerDataType.PlayerId, value.Select(p => p == null ? -1 : p.Id).ToArray());
            }
        }

        public virtual float StreamDistance
        {
            get { return GetFloat(StreamerDataType.StreamDistance); }
            set { SetFloat(StreamerDataType.StreamDistance, value); }
        }

        public int Id { get; protected set; }

        public virtual Vector Position
        {
            get
            {
                return new Vector(GetFloat(StreamerDataType.X),
                    GetFloat(StreamerDataType.Y),
                    GetFloat(StreamerDataType.Z));
            }
            set
            {
                SetFloat(StreamerDataType.X, value.X);
                SetFloat(StreamerDataType.Y, value.Y);
                SetFloat(StreamerDataType.Z, value.Z);
            }
        }

        public virtual bool IsVisibleForPlayer(GtaPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentNullException("player");
            }

            return IsInArray(StreamerDataType.PlayerId, player.Id);
        }

        public virtual void ShowForPlayer(GtaPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentNullException("player");
            }

            AppendToArray(StreamerDataType.PlayerId, player.Id);
        }

        public virtual void HideForPlayer(GtaPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentNullException("player");
            }

            RemoveArrayData(StreamerDataType.PlayerId, player.Id);
        }

        public virtual bool IsVisibleInWorld(int worldid)
        {
            return IsInArray(StreamerDataType.WorldId, worldid);
        }

        public void ShowInWorld(int worlid)
        {
            AppendToArray(StreamerDataType.WorldId, worlid);
        }

        public void HideInWorld(int worlid)
        {
            RemoveArrayData(StreamerDataType.WorldId, worlid);
        }

        public virtual bool IsVisibleInInterior(int interiorid)
        {
            return IsInArray(StreamerDataType.InteriorId, interiorid);
        }

        public void ShowInInterior(int interiorid)
        {
            AppendToArray(StreamerDataType.InteriorId, interiorid);
        }

        public void HideInInterior(int interiorid)
        {
            RemoveArrayData(StreamerDataType.InteriorId, interiorid);
        }

        public void ToggleUpdate(GtaPlayer player, bool toggle)
        {
            Streamer.ItemType[StreamType].ToggleUpdate(player, toggle);
        }

        protected int GetInteger(StreamerDataType data)
        {
            return Streamer.ItemType[StreamType].GetInteger(Id, data);
        }

        protected float GetFloat(StreamerDataType data)
        {
            return Streamer.ItemType[StreamType].GetFloat(Id, data);
        }

        protected int[] GetArray(StreamerDataType data, int maxlength)
        {
            return Streamer.ItemType[StreamType].GetArray(Id, data, maxlength);
        }

        protected void AppendToArray(StreamerDataType data, int value)
        {
            Streamer.ItemType[StreamType].AppendToArray(Id, data, value);
        }

        protected void RemoveArrayData(StreamerDataType data, int value)
        {
            Streamer.ItemType[StreamType].RemoveArrayData(Id, data, value);
        }

        protected bool IsInArray(StreamerDataType data, int value)
        {
            return Streamer.ItemType[StreamType].IsInArray(Id, data, value);
        }

        protected void SetInteger(StreamerDataType data, int value)
        {
            Streamer.ItemType[StreamType].SetInteger(Id, data, value);
        }

        protected void SetFloat(StreamerDataType data, float value)
        {
            Streamer.ItemType[StreamType].SetFloat(Id, data, value);
        }

        protected void SetArray(StreamerDataType data, int[] value)
        {
            Streamer.ItemType[StreamType].SetArray(Id, data, value);
        }
    }
}