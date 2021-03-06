﻿using System.Linq;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;
using SampSharp.Streamer.Definitions;
using SampSharp.Streamer.Natives;

namespace SampSharp.Streamer.World
{
    public class DynamicTextLabel : DynamicWorldObject<DynamicTextLabel>
    {
        public DynamicTextLabel(int id)
        {
            Id = id;
        }

        public DynamicTextLabel(string text, Color color, Vector position, float drawdistance,
            GtaPlayer attachedPlayer = null, GtaVehicle attachedVehicle = null, bool testLOS = false, int worldid = -1,
            int interiorid = -1, GtaPlayer player = null, float streamdistance = 100.0f)
        {
            Id = StreamerNative.CreateDynamic3DTextLabel(text, color, position.X, position.Y, position.Z, drawdistance,
                attachedPlayer == null ? GtaPlayer.InvalidId : attachedPlayer.Id,
                attachedVehicle == null ? GtaVehicle.InvalidId : attachedVehicle.Id, testLOS, worldid, interiorid,
                player == null ? -1 : player.Id, streamdistance);
        }

        public DynamicTextLabel(string text, Color color, Vector position,
            float drawdistance, float streamdistance, GtaPlayer attachedPlayer = null, GtaVehicle attachedVehicle = null,
            bool testLOS = false,
            int[] worlds = null, int[] interiors = null, GtaPlayer[] players = null)
        {
            Id = StreamerNative.CreateDynamic3DTextLabelEx(text, color, position.X, position.Y, position.Z, drawdistance,
                attachedPlayer == null ? GtaPlayer.InvalidId : attachedPlayer.Id,
                attachedVehicle == null ? GtaVehicle.InvalidId : attachedVehicle.Id, testLOS, streamdistance, worlds,
                interiors, players == null ? null : players.Select(p => p.Id).ToArray());
        }

        public override StreamType StreamType
        {
            get { return StreamType.TextLabel; }
        }

        public bool TestLOS
        {
            get { return GetInteger(StreamerDataType.TestLOS) != 0; }
            set { SetInteger(StreamerDataType.TestLOS, value ? 1 : 0); }
        }

        public float DrawDistance
        {
            get { return GetFloat(StreamerDataType.DrawDistance); }
            set { SetFloat(StreamerDataType.DrawDistance, value); }
        }

        public string Text
        {
            get
            {
                string value;
                StreamerNative.GetDynamic3DTextLabelText(Id, out value, 1024);
                return value;
            }
            set { StreamerNative.UpdateDynamic3DTextLabelText(Id, Color, value); }
        }

        public Color Color
        {
            get { return GetInteger(StreamerDataType.Color); }
            set { StreamerNative.UpdateDynamic3DTextLabelText(Id, value, Text); }
        }

        public bool IsValid
        {
            get { return StreamerNative.IsValidDynamic3DTextLabel(Id); }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            StreamerNative.DestroyDynamic3DTextLabel(Id);
        }
    }
}