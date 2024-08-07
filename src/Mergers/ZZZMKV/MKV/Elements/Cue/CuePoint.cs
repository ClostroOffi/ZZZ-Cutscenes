﻿using ZZZCutscenes.Mergers.ZZZMKV.MKV.Generics;

namespace ZZZCutscenes.Mergers.ZZZMKV.MKV.Elements.Cue
{
    internal class CuePoint : MKVContainerElement
    {
        public MKVElement<int> CueTime;
        public CueTrackPositions Positions;

        public CuePoint(int time, int track, long clusterPosition, long relativePosition, int? duration = null) : base(Signatures.CuePoint)
        {
            CueTime = new MKVElement<int>(Signatures.CueTime, time);
            Positions = new CueTrackPositions(track, clusterPosition, relativePosition, duration);
        }
    }
}
