using System;
using System.Collections.Generic;
using RimWorld;
using UnityEngine;
using Verse;
using MU;
using UnityEngine;
using Verse;

namespace MechBlinkUpgrade
{
    public class UpgradeComp_AddHediffLite : UpgradeComp
    {
        public bool active = true;
        [Unsaved(false)]
        private Texture2D activateTex;
        public UpgradeComp_AddHediffLite Props
        {
            get
            {
                return (UpgradeComp_AddHediffLite)this.props;
            }
        }

        public override void PostExposeData()
		{
			base.PostExposeData();
			Scribe_Values.Look<bool>(ref this.active, "active", true, false);
		}
    }
}
