﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace DMS
{
	public class CompPropertiesMultipleTurretGun : CompProperties
	{
		public CompPropertiesMultipleTurretGun()
		{
			this.compClass = typeof(CompMultipleTurretGun);
		}

		public List<SubTurretProperties> subTurrets;
	}

	public class SubTurretProperties
	{
		[NoTranslate]
		public string ID;
		public ThingDef turret;
		public float IdleAngleOffset;
		public float angleOffset;
		public bool autoAttack = true;
		public float warmingTime = 3f;

		public string command_ToggleFire = "ToggleFire";
		public string commandDesc_ToggleFire = "ToggleFireDesc";

		public string command_Target = "Target";
		public string commandDesc_Target = "TargetDesc";
		public string targetCommandIconPath = "";

		public List<PawnRenderNodeProperties> renderNodeProperties;
    }
}
