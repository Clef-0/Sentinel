﻿using System.Collections.Generic;
using Blam.Common;
using Blam.Tags;
using Blam.Objects;

namespace Blam.Units
{
    [TagDefinition(Name = "unit", Group = "unit", Size = 0x2C8)]
	public abstract class Unit : GameObject
	{
		public uint FlagsWarningHalo4Values;
		public DefaultTeamValue DefaultTeam;
		public ConstantSoundVolumeValue ConstantSoundVolume;
		public TagInstance HologramUnit;
		public List<MetagameProperty> MetagameProperties;
		public TagInstance IntegratedLightToggle;
		public Angle CameraFieldOfView;
		public float CameraStiffness;
		public short Flags2;
		public short Unknown6;
		public StringID CameraMarkerName;
		public StringID CameraSubmergedMarkerName;
		public Angle PitchAutoLevel;
		public Angle PitchRangeMin;
		public Angle PitchRangeMax;
		public List<CameraTrack> CameraTracks;
		public Angle Unknown7;
		public Angle Unknown8;
		public Angle Unknown9;
		public List<UnknownBlock> Unknown10;
		public short Flags3;
		public short Unknown11;
		public StringID CameraMarkerName2;
		public StringID CameraSubmergedMarkerName2;
		public Angle PitchAutoLevel2;
		public Angle PitchRangeMin2;
		public Angle PitchRangeMax2;
		public List<CameraTrack2> CameraTracks2;
		public Angle Unknown12;
		public Angle Unknown13;
		public Angle Unknown14;
		public List<UnknownBlock2> Unknown15;
		public TagInstance AssassinationResponse;
		public TagInstance AssassinationWeapon;
		public StringID AssasinationToolStowAnchor;
		public StringID AssasinationToolHandMarker;
		public StringID AssasinationToolMarker;
		public float AccelerationRangeI;
		public float AccelerationRangeJ;
		public float AccelerationRangeK;
		public float AccelerationActionScale;
		public float AccelerationAttachScale;
		public float SoftPingThreshold;
		public float SoftPingInterruptTime;
		public float HardPingThreshold;
		public float HardPingInterruptTime;
		public float FeignDeathThreshold;
		public float FeignDeathTime;
		public float DistanceOfEvadeAnimation;
		public float DistanceOfDiveAnimation;
		public float StunnedMovementThreshold;
		public float FeignDeathChance;
		public float FeignRepeatChance;
		public TagInstance SpawnedTurretCharacter;
		public short SpawnedActorCountMin;
		public short SpawnedActorCountMax;
		public float SpawnedVelocity;
		public Angle AimingVelocityMaximum;
		public Angle AimingAccelerationMaximum;
		public float CasualAimingModifier;
		public Angle LookingVelocityMaximum;
		public Angle LookingAccelerationMaximum;
		public StringID RightHandNode;
		public StringID LeftHandNode;
		public StringID PreferredGunNode;
		public TagInstance MeleeDamage;
		public TagInstance BoardingMeleeDamage;
		public TagInstance BoardingMeleeResponse;
		public TagInstance EjectionMeleeDamage;
		public TagInstance EjectionMeleeResponse;
		public TagInstance LandingMeleeDamage;
		public TagInstance FlurryMeleeDamage;
		public TagInstance ObstacleSmashMeleeDamage;
		public TagInstance ShieldPopDamage;
		public TagInstance AssassinationDamage;
		public MotionSensorBlipSizeValue MotionSensorBlipSize;
		public ItemScaleValue ItemScale;
		public List<Posture> Postures;
		public List<HudInterface> HudInterfaces;
		public List<DialogueVariant> DialogueVariants;
		public uint Unknown16;
		public uint Unknown17;
		public uint Unknown18;
		public uint Unknown19;
		public float GrenadeVelocity;
		public GrenadeTypeValue GrenadeType;
		public short GrenadeCount;
		public List<PoweredSeat> PoweredSeats;
		public List<Weapon> Weapons;
		public List<TargetTrackingBlock> TargetTracking;
		public List<Seat> Seats;
		public float EmpRadius;
		public TagInstance EmpEffect;
		public TagInstance BoostCollisionDamage;
		public float BoostPeakPower;
		public float BoostRisePower;
		public float BoostPeakTime;
		public float BoostFallPower;
		public float BoostDeadTime;
		public float LipsyncAttackWeight;
		public float LipsyncDecayWeight;
		public TagInstance DetachDamage;
		public TagInstance DetachedWeapon;

		public enum DefaultTeamValue : short
		{
			Default,
			Player,
			Human,
			Covenant,
			Flood,
			Sentinel,
			Heretic,
			Prophet,
			Guilty,
			Unused9,
			Unused10,
			Unused11,
			Unused12,
			Unused13,
			Unused14,
			Unused15,
		}

		public enum ConstantSoundVolumeValue : short
		{
			Silent,
			Medium,
			Loud,
			Shout,
			Quiet,
		}

		[TagDefinition(Size = 0x8)]
		public class MetagameProperty
		{
			public byte Flags;
			public UnitValue Unit;
			public ClassificationValue Classification;
			public sbyte Unknown;
			public short Points;
			public short Unknown2;

			public enum UnitValue : sbyte
			{
				Brute,
				Grunt,
				Jackal,
				Marine,
				Bugger,
				Hunter,
				FloodInfection,
				FloodCarrier,
				FloodCombat,
				FloodPureform,
				Sentinel,
				Elite,
				Turret,
				Mongoose,
				Warthog,
				Scorpion,
				Hornet,
				Pelican,
				Shade,
				Watchtower,
				Ghost,
				Chopper,
				Mauler,
				Wraith,
				Banshee,
				Phantom,
				Scarab,
				Guntower,
				Engineer,
				EngineerRechargeStation,
			}

			public enum ClassificationValue : sbyte
			{
				Infantry,
				Leader,
				Hero,
				Specialist,
				LightVehicle,
				HeavyVehicle,
				GiantVehicle,
				StandardVehicle,
			}
		}

		[TagDefinition(Size = 0x10)]
		public class CameraTrack
		{
			public TagInstance Track;
		}

		[TagDefinition(Size = 0x4C)]
		public class UnknownBlock
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
			public uint Unknown9;
			public uint Unknown10;
			public uint Unknown11;
			public uint Unknown12;
			public uint Unknown13;
			public uint Unknown14;
			public uint Unknown15;
			public uint Unknown16;
			public uint Unknown17;
			public uint Unknown18;
			public uint Unknown19;
		}

		[TagDefinition(Size = 0x10)]
		public class CameraTrack2
		{
			public TagInstance Track;
		}

		[TagDefinition(Size = 0x4C)]
		public class UnknownBlock2
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
			public uint Unknown9;
			public uint Unknown10;
			public uint Unknown11;
			public uint Unknown12;
			public uint Unknown13;
			public uint Unknown14;
			public uint Unknown15;
			public uint Unknown16;
			public uint Unknown17;
			public uint Unknown18;
			public uint Unknown19;
		}

		public enum MotionSensorBlipSizeValue : short
		{
			Medium,
			Small,
			Large,
		}

		public enum ItemScaleValue : short
		{
			Small,
			Medium,
			Large,
			Huge,
		}

		[TagDefinition(Size = 0x10)]
		public class Posture
		{
			public StringID Name;
			public float PillOffsetI;
			public float PillOffsetJ;
			public float PillOffsetK;
		}

		[TagDefinition(Size = 0x10)]
		public class HudInterface
		{
			public TagInstance UnitHudInterface;
		}

		[TagDefinition(Size = 0x14)]
		public class DialogueVariant
		{
			public short VariantNumber;
			public short Unknown;
			public TagInstance Dialogue;
		}

		public enum GrenadeTypeValue : short
		{
			HumanFragmentation,
			CovenantPlasma,
			BruteSpike,
			Firebomb,
		}

		[TagDefinition(Size = 0x8)]
		public class PoweredSeat
		{
			public float DriverPowerupTime;
			public float DriverPowerdownTime;
		}

		[TagDefinition(Size = 0x10)]
		public class Weapon
		{
			public TagInstance Weapon2;
		}

		[TagDefinition(Size = 0x38)]
		public class TargetTrackingBlock
		{
			public List<TrackingType> TrackingTypes;
			public float AcquireTime;
			public float GraceTime;
			public float DecayTime;
			public TagInstance TrackingSound;
			public TagInstance LockedSound;

			[TagDefinition(Size = 0x4)]
			public class TrackingType
			{
				public StringID TrackingType2;
			}
		}

		[TagDefinition(Size = 0xE4)]
		public class Seat
		{
			public uint Flags;
			public StringID SeatAnimation;
			public StringID SeatMarkerName;
			public StringID EntryMarkerSName;
			public StringID BoardingGrenadeMarker;
			public StringID BoardingGrenadeString;
			public StringID BoardingMeleeString;
			public StringID DetachWeaponString;
			public float PingScale;
			public float TurnoverTime;
			public float AccelerationRangeI;
			public float AccelerationRangeJ;
			public float AccelerationRangeK;
			public float AccelerationActionScale;
			public float AccelerationAttachScale;
			public float AiScariness;
			public AiSeatTypeValue AiSeatType;
			public short BoardingSeat;
			public float ListenerInterpolationFactor;
			public float YawRateBoundsMin;
			public float YawRateBoundsMax;
			public float PitchRateBoundsMin;
			public float PitchRateBoundsMax;
			public uint Unknown;
			public float MinimumSpeedReference;
			public float MaximumSpeedReference;
			public float SpeedExponent;
			public short Unknown2;
			public short Unknown3;
			public StringID CameraMarkerName;
			public StringID CameraSubmergedMarkerName;
			public Angle PitchAutoLevel;
			public Angle PitchRangeMin;
			public Angle PitchRangeMax;
			public List<CameraTrack> CameraTracks;
			public Angle Unknown4;
			public Angle Unknown5;
			public Angle Unknown6;
			public List<UnknownBlock> Unknown7;
			public List<UnitHudInterfaceBlock> UnitHudInterface;
			public StringID EnterSeatString;
			public Angle YawRangeMin;
			public Angle YawRangeMax;
			public TagInstance BuiltInGunner;
			public float EntryRadius;
			public Angle EntryMarkerConeAngle;
			public Angle EntryMarkerFacingAngle;
			public float MaximumRelativeVelocity;
			public StringID InvisibleSeatRegion;
			public int RuntimeInvisibleSeatRegionIndex;

			public enum AiSeatTypeValue : short
			{
				None,
				Passenger,
				Gunner,
				SmallCargo,
				LargeCargo,
				Driver,
			}

			[TagDefinition(Size = 0x10)]
			public class CameraTrack
			{
				public TagInstance Track;
			}

			[TagDefinition(Size = 0x4C)]
			public class UnknownBlock
			{
				public uint Unknown;
				public uint Unknown2;
				public uint Unknown3;
				public uint Unknown4;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;
				public uint Unknown9;
				public uint Unknown10;
				public uint Unknown11;
				public uint Unknown12;
				public uint Unknown13;
				public uint Unknown14;
				public uint Unknown15;
				public uint Unknown16;
				public uint Unknown17;
				public uint Unknown18;
				public uint Unknown19;
			}

			[TagDefinition(Size = 0x10)]
			public class UnitHudInterfaceBlock
			{
				public TagInstance UnitHudInterface;
			}
		}
	}
}