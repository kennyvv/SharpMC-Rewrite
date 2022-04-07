﻿using System;
using System.ComponentModel;
using System.IO;
using System.Numerics;
using SharpMC.Enums;

namespace SharpMC.Core.Utils
{
	public class HealthManager
	{
		public HealthManager(Entities.Entity entity)
		{
			Entity = entity;
			ResetHealth();
			IsInvulnerable = false;
		}

		public Entities.Entity Entity { get; set; }
		public int Health { get; set; }
		public short Air { get; set; }
		public short Food { get; set; }
		public short FoodTick { get; set; }
		public bool IsDead { get; set; }
		public int FireTick { get; set; }
		public bool IsOnFire { get; set; }
		public DamageCause LastDamageCause { get; set; }
		public Player LastDamageSource { get; set; }
		private int FallDamage { get; set; }
		private int FallTick { get; set; }
		private int RegenTick { get; set; }
		public bool IsInvulnerable { get; set; }

		public byte[] Export()
		{
			byte[] buffer;
			using (var stream = new MemoryStream())
			{
				var writer = new NbtBinaryWriter(stream, false);
				writer.Write(Health);
				writer.Write(Air);
				writer.Write(FireTick);
				writer.Write(IsOnFire);
				buffer = stream.GetBuffer();
			}
			return buffer;
		}

		public void Import(byte[] data)
		{
			using (var stream = new MemoryStream(data))
			{
				var reader = new NbtBinaryReader(stream, false);
				Health = reader.ReadInt32();
				Air = reader.ReadInt16();
				FireTick = reader.ReadInt32();
				IsOnFire = reader.ReadBoolean();
			}
		}

		public void TakeHit(Player source, int damage = 1, DamageCause cause = DamageCause.Unknown)
		{
			if (LastDamageCause == DamageCause.Unknown) LastDamageCause = cause;

			LastDamageSource = source;

			Health -= damage;

			if (Entity == null) return;

			var player = Entity as Player;
			if (player != null)
			{
				player.SendHealth();
				player.PlayerAnimation(Animations.TakeDamage);
			}
		}

		public void Kill()
		{
			if (IsDead) return;

			IsDead = true;
		}

		public void ResetHealth()
		{
			Health = 20;
			Air = 300;
			Food = 20;
			FoodTick = 0;
			IsOnFire = false;
			FireTick = 0;
			IsDead = false;
			LastDamageCause = DamageCause.Unknown;
			RegenTick = 0;
		}

		public void OnTick()
		{
			var player = Entity as Player;
			if (IsDead) return;

			if (IsInvulnerable) Health = 200;

			if (Health <= 0)
			{
				IsDead = true;
				if (player != null)
				{
					/*Entity.Level.BroadcastChat("§e" +
					                           GetDescription(LastDamageCause)
						                           .Replace("{0}", player.Username)
						                           .Replace("{1}", LastDamageSource.Username));*/
					//TODO: replace with offical death packet
				}
				return;
			}

			if (Food > 16 && Health < 20 && !IsOnFire)
			{
				//Regenerate health.
				if (RegenTick >= 80)
				{
					Health++;
					if (player != null)
					{
						player.SendHealth();
					}
					RegenTick = 0;
				}
				else RegenTick++;
			}

			if (FoodTick == 300)
			{
				if (Food > 0)
				{
					Food--;
				}
				else
				{
					Health--;
				}
				if (player != null)
				{
					player.SendHealth();
				}
				FoodTick = 0;
			}
			else FoodTick += 1;


			//TODO: Add Falldamage check

			if (Health <= 0)
			{
				Kill();
				return;
			}

			if (player != null)
			{
				if (player.KnownPosition.Y < 0 && !IsDead)
				{
					TakeHit(player, 20, DamageCause.Void);
					return;
				}


				if (IsInWater(player.KnownPosition.ToVector3()))
				{
					Air--;
					if (Air <= 0)
					{
						if (Math.Abs(Air)%10 == 0)
						{
							TakeHit(player, 1, DamageCause.Drowning);
						}
					}

					if (IsOnFire)
					{
						IsOnFire = false;
						FireTick = 0;
					}
				}
				else
				{
					Air = 300;
				}

				if (!IsOnFire && IsInLava(player.KnownPosition.ToVector3()))
				{
					FireTick = 300;
					IsOnFire = true;
				}

				if (IsOnFire)
				{
					FireTick--;
					if (FireTick <= 0)
					{
						IsOnFire = false;
					}

					if (Math.Abs(FireTick)%20 == 0)
					{
						TakeHit(player, 1, DamageCause.Fire);
					}
				}
			}
		}

		private bool IsInWater(Vector3 playerPosition)
		{
			playerPosition.Y ++; //We want to check at 'head' height
			var block = Entity.Level.GetBlock(playerPosition);
			return block.Id == 8 || block.Id == 9;
		}

		private bool IsInLava(Vector3 playerPosition)
		{
			var block = Entity.Level.GetBlock(playerPosition);
			return block.Id == 10 || block.Id == 11;
		}

		public static string GetDescription(Enum value)
		{
			var fi = value.GetType().GetField(value.ToString());
			var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof (DescriptionAttribute), false);
			if (attributes.Length > 0)
				return attributes[0].Description;
			return value.ToString();
		}
	}
}