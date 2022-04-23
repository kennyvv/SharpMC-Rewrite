﻿using MyEntity = SharpMC.Entities.MiEntity;

namespace SharpMC.Entities.Auto
{
    public static class KnownEntities
    {
        public static readonly MyEntity AreaEffectCloud = new MyEntity { Id = 0, Type = EntityType.Other, DisplayName = "Area Effect Cloud", Name = "area_effect_cloud", Width = 6, Height = 0.5, };
        public static readonly MyEntity ArmorStand = new MyEntity { Id = 1, Type = EntityType.Living, DisplayName = "Armor Stand", Name = "armor_stand", Width = 0.5, Height = 1.975, };
        public static readonly MyEntity Arrow = new MyEntity { Id = 2, Type = EntityType.Projectile, DisplayName = "Arrow", Name = "arrow", Width = 0.5, Height = 0.5, };
        public static readonly MyEntity Axolotl = new MyEntity { Id = 3, Type = EntityType.Animal, DisplayName = "Axolotl", Name = "axolotl", Width = 0.75, Height = 0.42, };
        public static readonly MyEntity Bat = new MyEntity { Id = 4, Type = EntityType.Ambient, DisplayName = "Bat", Name = "bat", Width = 0.5, Height = 0.9, };
        public static readonly MyEntity Bee = new MyEntity { Id = 5, Type = EntityType.Animal, DisplayName = "Bee", Name = "bee", Width = 0.7, Height = 0.6, };
        public static readonly MyEntity Blaze = new MyEntity { Id = 6, Type = EntityType.Hostile, DisplayName = "Blaze", Name = "blaze", Width = 0.6, Height = 1.8, };
        public static readonly MyEntity Boat = new MyEntity { Id = 7, Type = EntityType.Other, DisplayName = "Boat", Name = "boat", Width = 1.375, Height = 0.5625, };
        public static readonly MyEntity Cat = new MyEntity { Id = 8, Type = EntityType.Animal, DisplayName = "Cat", Name = "cat", Width = 0.6, Height = 0.7, };
        public static readonly MyEntity CaveSpider = new MyEntity { Id = 9, Type = EntityType.Hostile, DisplayName = "Cave Spider", Name = "cave_spider", Width = 0.7, Height = 0.5, };
        public static readonly MyEntity ChestMinecart = new MyEntity { Id = 51, Type = EntityType.Other, DisplayName = "Minecart with Chest", Name = "chest_minecart", Width = 0.98, Height = 0.7, };
        public static readonly MyEntity Chicken = new MyEntity { Id = 10, Type = EntityType.Animal, DisplayName = "Chicken", Name = "chicken", Width = 0.4, Height = 0.7, };
        public static readonly MyEntity Cod = new MyEntity { Id = 11, Type = EntityType.WaterCreature, DisplayName = "Cod", Name = "cod", Width = 0.5, Height = 0.3, };
        public static readonly MyEntity CommandBlockMinecart = new MyEntity { Id = 52, Type = EntityType.Other, DisplayName = "Minecart with Command Block", Name = "command_block_minecart", Width = 0.98, Height = 0.7, };
        public static readonly MyEntity Cow = new MyEntity { Id = 12, Type = EntityType.Animal, DisplayName = "Cow", Name = "cow", Width = 0.9, Height = 1.4, };
        public static readonly MyEntity Creeper = new MyEntity { Id = 13, Type = EntityType.Hostile, DisplayName = "Creeper", Name = "creeper", Width = 0.6, Height = 1.7, };
        public static readonly MyEntity Dolphin = new MyEntity { Id = 14, Type = EntityType.WaterCreature, DisplayName = "Dolphin", Name = "dolphin", Width = 0.9, Height = 0.6, };
        public static readonly MyEntity Donkey = new MyEntity { Id = 15, Type = EntityType.Animal, DisplayName = "Donkey", Name = "donkey", Width = 1.39648, Height = 1.5, };
        public static readonly MyEntity DragonFireball = new MyEntity { Id = 16, Type = EntityType.Projectile, DisplayName = "Dragon Fireball", Name = "dragon_fireball", Width = 1, Height = 1, };
        public static readonly MyEntity Drowned = new MyEntity { Id = 17, Type = EntityType.Hostile, DisplayName = "Drowned", Name = "drowned", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity Egg = new MyEntity { Id = 89, Type = EntityType.Projectile, DisplayName = "Thrown Egg", Name = "egg", Width = 0.25, Height = 0.25, };
        public static readonly MyEntity ElderGuardian = new MyEntity { Id = 18, Type = EntityType.Hostile, DisplayName = "Elder Guardian", Name = "elder_guardian", Width = 1.9975, Height = 1.9975, };
        public static readonly MyEntity EndCrystal = new MyEntity { Id = 19, Type = EntityType.Other, DisplayName = "End Crystal", Name = "end_crystal", Width = 2, Height = 2, };
        public static readonly MyEntity EnderDragon = new MyEntity { Id = 20, Type = EntityType.Mob, DisplayName = "Ender Dragon", Name = "ender_dragon", Width = 16, Height = 8, };
        public static readonly MyEntity Enderman = new MyEntity { Id = 21, Type = EntityType.Hostile, DisplayName = "Enderman", Name = "enderman", Width = 0.6, Height = 2.9, };
        public static readonly MyEntity Endermite = new MyEntity { Id = 22, Type = EntityType.Hostile, DisplayName = "Endermite", Name = "endermite", Width = 0.4, Height = 0.3, };
        public static readonly MyEntity EnderPearl = new MyEntity { Id = 90, Type = EntityType.Projectile, DisplayName = "Thrown Ender Pearl", Name = "ender_pearl", Width = 0.25, Height = 0.25, };
        public static readonly MyEntity Evoker = new MyEntity { Id = 23, Type = EntityType.Hostile, DisplayName = "Evoker", Name = "evoker", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity EvokerFangs = new MyEntity { Id = 24, Type = EntityType.Other, DisplayName = "Evoker Fangs", Name = "evoker_fangs", Width = 0.5, Height = 0.8, };
        public static readonly MyEntity ExperienceBottle = new MyEntity { Id = 91, Type = EntityType.Projectile, DisplayName = "Thrown Bottle o' Enchanting", Name = "experience_bottle", Width = 0.25, Height = 0.25, };
        public static readonly MyEntity ExperienceOrb = new MyEntity { Id = 25, Type = EntityType.Other, DisplayName = "Experience Orb", Name = "experience_orb", Width = 0.5, Height = 0.5, };
        public static readonly MyEntity EyeOfEnder = new MyEntity { Id = 26, Type = EntityType.Other, DisplayName = "Eye of Ender", Name = "eye_of_ender", Width = 0.25, Height = 0.25, };
        public static readonly MyEntity FallingBlock = new MyEntity { Id = 27, Type = EntityType.Other, DisplayName = "Falling Block", Name = "falling_block", Width = 0.98, Height = 0.98, };
        public static readonly MyEntity Fireball = new MyEntity { Id = 43, Type = EntityType.Projectile, DisplayName = "Fireball", Name = "fireball", Width = 1, Height = 1, };
        public static readonly MyEntity FireworkRocket = new MyEntity { Id = 28, Type = EntityType.Projectile, DisplayName = "Firework Rocket", Name = "firework_rocket", Width = 0.25, Height = 0.25, };
        public static readonly MyEntity FishingBobber = new MyEntity { Id = 112, Type = EntityType.Projectile, DisplayName = "Fishing Bobber", Name = "fishing_bobber", Width = 0.25, Height = 0.25, };
        public static readonly MyEntity Fox = new MyEntity { Id = 29, Type = EntityType.Animal, DisplayName = "Fox", Name = "fox", Width = 0.6, Height = 0.7, };
        public static readonly MyEntity FurnaceMinecart = new MyEntity { Id = 53, Type = EntityType.Other, DisplayName = "Minecart with Furnace", Name = "furnace_minecart", Width = 0.98, Height = 0.7, };
        public static readonly MyEntity Ghast = new MyEntity { Id = 30, Type = EntityType.Mob, DisplayName = "Ghast", Name = "ghast", Width = 4, Height = 4, };
        public static readonly MyEntity Giant = new MyEntity { Id = 31, Type = EntityType.Hostile, DisplayName = "Giant", Name = "giant", Width = 3.6, Height = 12, };
        public static readonly MyEntity GlowItemFrame = new MyEntity { Id = 32, Type = EntityType.Other, DisplayName = "Glow Item Frame", Name = "glow_item_frame", Width = 0.5, Height = 0.5, };
        public static readonly MyEntity GlowSquid = new MyEntity { Id = 33, Type = EntityType.WaterCreature, DisplayName = "Glow Squid", Name = "glow_squid", Width = 0.8, Height = 0.8, };
        public static readonly MyEntity Goat = new MyEntity { Id = 34, Type = EntityType.Animal, DisplayName = "Goat", Name = "goat", Width = 0.9, Height = 1.3, };
        public static readonly MyEntity Guardian = new MyEntity { Id = 35, Type = EntityType.Hostile, DisplayName = "Guardian", Name = "guardian", Width = 0.85, Height = 0.85, };
        public static readonly MyEntity Hoglin = new MyEntity { Id = 36, Type = EntityType.Animal, DisplayName = "Hoglin", Name = "hoglin", Width = 1.39648, Height = 1.4, };
        public static readonly MyEntity HopperMinecart = new MyEntity { Id = 54, Type = EntityType.Other, DisplayName = "Minecart with Hopper", Name = "hopper_minecart", Width = 0.98, Height = 0.7, };
        public static readonly MyEntity Horse = new MyEntity { Id = 37, Type = EntityType.Animal, DisplayName = "Horse", Name = "horse", Width = 1.39648, Height = 1.6, };
        public static readonly MyEntity Husk = new MyEntity { Id = 38, Type = EntityType.Hostile, DisplayName = "Husk", Name = "husk", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity Illusioner = new MyEntity { Id = 39, Type = EntityType.Hostile, DisplayName = "Illusioner", Name = "illusioner", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity IronGolem = new MyEntity { Id = 40, Type = EntityType.Mob, DisplayName = "Iron Golem", Name = "iron_golem", Width = 1.4, Height = 2.7, };
        public static readonly MyEntity Item = new MyEntity { Id = 41, Type = EntityType.Other, DisplayName = "Item", Name = "item", Width = 0.25, Height = 0.25, };
        public static readonly MyEntity ItemFrame = new MyEntity { Id = 42, Type = EntityType.Other, DisplayName = "Item Frame", Name = "item_frame", Width = 0.5, Height = 0.5, };
        public static readonly MyEntity LeashKnot = new MyEntity { Id = 44, Type = EntityType.Other, DisplayName = "Leash Knot", Name = "leash_knot", Width = 0.375, Height = 0.5, };
        public static readonly MyEntity LightningBolt = new MyEntity { Id = 45, Type = EntityType.Other, DisplayName = "Lightning Bolt", Name = "lightning_bolt", Width = 0, Height = 0, };
        public static readonly MyEntity Llama = new MyEntity { Id = 46, Type = EntityType.Animal, DisplayName = "Llama", Name = "llama", Width = 0.9, Height = 1.87, };
        public static readonly MyEntity LlamaSpit = new MyEntity { Id = 47, Type = EntityType.Projectile, DisplayName = "Llama Spit", Name = "llama_spit", Width = 0.25, Height = 0.25, };
        public static readonly MyEntity MagmaCube = new MyEntity { Id = 48, Type = EntityType.Mob, DisplayName = "Magma Cube", Name = "magma_cube", Width = 2.04, Height = 2.04, };
        public static readonly MyEntity Marker = new MyEntity { Id = 49, Type = EntityType.Other, DisplayName = "Marker", Name = "marker", Width = 0, Height = 0, };
        public static readonly MyEntity Minecart = new MyEntity { Id = 50, Type = EntityType.Other, DisplayName = "Minecart", Name = "minecart", Width = 0.98, Height = 0.7, };
        public static readonly MyEntity Mooshroom = new MyEntity { Id = 58, Type = EntityType.Animal, DisplayName = "Mooshroom", Name = "mooshroom", Width = 0.9, Height = 1.4, };
        public static readonly MyEntity Mule = new MyEntity { Id = 57, Type = EntityType.Animal, DisplayName = "Mule", Name = "mule", Width = 1.39648, Height = 1.6, };
        public static readonly MyEntity Ocelot = new MyEntity { Id = 59, Type = EntityType.Animal, DisplayName = "Ocelot", Name = "ocelot", Width = 0.6, Height = 0.7, };
        public static readonly MyEntity Painting = new MyEntity { Id = 60, Type = EntityType.Other, DisplayName = "Painting", Name = "painting", Width = 0.5, Height = 0.5, };
        public static readonly MyEntity Panda = new MyEntity { Id = 61, Type = EntityType.Animal, DisplayName = "Panda", Name = "panda", Width = 1.3, Height = 1.25, };
        public static readonly MyEntity Parrot = new MyEntity { Id = 62, Type = EntityType.Animal, DisplayName = "Parrot", Name = "parrot", Width = 0.5, Height = 0.9, };
        public static readonly MyEntity Phantom = new MyEntity { Id = 63, Type = EntityType.Mob, DisplayName = "Phantom", Name = "phantom", Width = 0.9, Height = 0.5, };
        public static readonly MyEntity Pig = new MyEntity { Id = 64, Type = EntityType.Animal, DisplayName = "Pig", Name = "pig", Width = 0.9, Height = 0.9, };
        public static readonly MyEntity Piglin = new MyEntity { Id = 65, Type = EntityType.Hostile, DisplayName = "Piglin", Name = "piglin", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity PiglinBrute = new MyEntity { Id = 66, Type = EntityType.Hostile, DisplayName = "Piglin Brute", Name = "piglin_brute", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity Pillager = new MyEntity { Id = 67, Type = EntityType.Hostile, DisplayName = "Pillager", Name = "pillager", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity Player = new MyEntity { Id = 111, Type = EntityType.Player, DisplayName = "Player", Name = "player", Width = 0.6, Height = 1.8, };
        public static readonly MyEntity PolarBear = new MyEntity { Id = 68, Type = EntityType.Animal, DisplayName = "Polar Bear", Name = "polar_bear", Width = 1.4, Height = 1.4, };
        public static readonly MyEntity Potion = new MyEntity { Id = 92, Type = EntityType.Projectile, DisplayName = "Potion", Name = "potion", Width = 0.25, Height = 0.25, };
        public static readonly MyEntity Pufferfish = new MyEntity { Id = 70, Type = EntityType.WaterCreature, DisplayName = "Pufferfish", Name = "pufferfish", Width = 0.7, Height = 0.7, };
        public static readonly MyEntity Rabbit = new MyEntity { Id = 71, Type = EntityType.Animal, DisplayName = "Rabbit", Name = "rabbit", Width = 0.4, Height = 0.5, };
        public static readonly MyEntity Ravager = new MyEntity { Id = 72, Type = EntityType.Hostile, DisplayName = "Ravager", Name = "ravager", Width = 1.95, Height = 2.2, };
        public static readonly MyEntity Salmon = new MyEntity { Id = 73, Type = EntityType.WaterCreature, DisplayName = "Salmon", Name = "salmon", Width = 0.7, Height = 0.4, };
        public static readonly MyEntity Sheep = new MyEntity { Id = 74, Type = EntityType.Animal, DisplayName = "Sheep", Name = "sheep", Width = 0.9, Height = 1.3, };
        public static readonly MyEntity Shulker = new MyEntity { Id = 75, Type = EntityType.Mob, DisplayName = "Shulker", Name = "shulker", Width = 1, Height = 1, };
        public static readonly MyEntity ShulkerBullet = new MyEntity { Id = 76, Type = EntityType.Projectile, DisplayName = "Shulker Bullet", Name = "shulker_bullet", Width = 0.3125, Height = 0.3125, };
        public static readonly MyEntity Silverfish = new MyEntity { Id = 77, Type = EntityType.Hostile, DisplayName = "Silverfish", Name = "silverfish", Width = 0.4, Height = 0.3, };
        public static readonly MyEntity Skeleton = new MyEntity { Id = 78, Type = EntityType.Hostile, DisplayName = "Skeleton", Name = "skeleton", Width = 0.6, Height = 1.99, };
        public static readonly MyEntity SkeletonHorse = new MyEntity { Id = 79, Type = EntityType.Animal, DisplayName = "Skeleton Horse", Name = "skeleton_horse", Width = 1.39648, Height = 1.6, };
        public static readonly MyEntity Slime = new MyEntity { Id = 80, Type = EntityType.Mob, DisplayName = "Slime", Name = "slime", Width = 2.04, Height = 2.04, };
        public static readonly MyEntity SmallFireball = new MyEntity { Id = 81, Type = EntityType.Projectile, DisplayName = "Small Fireball", Name = "small_fireball", Width = 0.3125, Height = 0.3125, };
        public static readonly MyEntity Snowball = new MyEntity { Id = 83, Type = EntityType.Projectile, DisplayName = "Snowball", Name = "snowball", Width = 0.25, Height = 0.25, };
        public static readonly MyEntity SnowGolem = new MyEntity { Id = 82, Type = EntityType.Mob, DisplayName = "Snow Golem", Name = "snow_golem", Width = 0.7, Height = 1.9, };
        public static readonly MyEntity SpawnerMinecart = new MyEntity { Id = 55, Type = EntityType.Other, DisplayName = "Minecart with Spawner", Name = "spawner_minecart", Width = 0.98, Height = 0.7, };
        public static readonly MyEntity SpectralArrow = new MyEntity { Id = 84, Type = EntityType.Projectile, DisplayName = "Spectral Arrow", Name = "spectral_arrow", Width = 0.5, Height = 0.5, };
        public static readonly MyEntity Spider = new MyEntity { Id = 85, Type = EntityType.Hostile, DisplayName = "Spider", Name = "spider", Width = 1.4, Height = 0.9, };
        public static readonly MyEntity Squid = new MyEntity { Id = 86, Type = EntityType.WaterCreature, DisplayName = "Squid", Name = "squid", Width = 0.8, Height = 0.8, };
        public static readonly MyEntity Stray = new MyEntity { Id = 87, Type = EntityType.Hostile, DisplayName = "Stray", Name = "stray", Width = 0.6, Height = 1.99, };
        public static readonly MyEntity Strider = new MyEntity { Id = 88, Type = EntityType.Animal, DisplayName = "Strider", Name = "strider", Width = 0.9, Height = 1.7, };
        public static readonly MyEntity Tnt = new MyEntity { Id = 69, Type = EntityType.Other, DisplayName = "Primed TNT", Name = "tnt", Width = 0.98, Height = 0.98, };
        public static readonly MyEntity TntMinecart = new MyEntity { Id = 56, Type = EntityType.Other, DisplayName = "Minecart with TNT", Name = "tnt_minecart", Width = 0.98, Height = 0.7, };
        public static readonly MyEntity TraderLlama = new MyEntity { Id = 94, Type = EntityType.Animal, DisplayName = "Trader Llama", Name = "trader_llama", Width = 0.9, Height = 1.87, };
        public static readonly MyEntity Trident = new MyEntity { Id = 93, Type = EntityType.Projectile, DisplayName = "Trident", Name = "trident", Width = 0.5, Height = 0.5, };
        public static readonly MyEntity TropicalFish = new MyEntity { Id = 95, Type = EntityType.WaterCreature, DisplayName = "Tropical Fish", Name = "tropical_fish", Width = 0.5, Height = 0.4, };
        public static readonly MyEntity Turtle = new MyEntity { Id = 96, Type = EntityType.Animal, DisplayName = "Turtle", Name = "turtle", Width = 1.2, Height = 0.4, };
        public static readonly MyEntity Vex = new MyEntity { Id = 97, Type = EntityType.Hostile, DisplayName = "Vex", Name = "vex", Width = 0.4, Height = 0.8, };
        public static readonly MyEntity Villager = new MyEntity { Id = 98, Type = EntityType.Passive, DisplayName = "Villager", Name = "villager", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity Vindicator = new MyEntity { Id = 99, Type = EntityType.Hostile, DisplayName = "Vindicator", Name = "vindicator", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity WanderingTrader = new MyEntity { Id = 100, Type = EntityType.Passive, DisplayName = "Wandering Trader", Name = "wandering_trader", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity Witch = new MyEntity { Id = 101, Type = EntityType.Hostile, DisplayName = "Witch", Name = "witch", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity Wither = new MyEntity { Id = 102, Type = EntityType.Hostile, DisplayName = "Wither", Name = "wither", Width = 0.9, Height = 3.5, };
        public static readonly MyEntity WitherSkeleton = new MyEntity { Id = 103, Type = EntityType.Hostile, DisplayName = "Wither Skeleton", Name = "wither_skeleton", Width = 0.7, Height = 2.4, };
        public static readonly MyEntity WitherSkull = new MyEntity { Id = 104, Type = EntityType.Projectile, DisplayName = "Wither Skull", Name = "wither_skull", Width = 0.3125, Height = 0.3125, };
        public static readonly MyEntity Wolf = new MyEntity { Id = 105, Type = EntityType.Animal, DisplayName = "Wolf", Name = "wolf", Width = 0.6, Height = 0.85, };
        public static readonly MyEntity Zoglin = new MyEntity { Id = 106, Type = EntityType.Hostile, DisplayName = "Zoglin", Name = "zoglin", Width = 1.39648, Height = 1.4, };
        public static readonly MyEntity Zombie = new MyEntity { Id = 107, Type = EntityType.Hostile, DisplayName = "Zombie", Name = "zombie", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity ZombieHorse = new MyEntity { Id = 108, Type = EntityType.Animal, DisplayName = "Zombie Horse", Name = "zombie_horse", Width = 1.39648, Height = 1.6, };
        public static readonly MyEntity ZombieVillager = new MyEntity { Id = 109, Type = EntityType.Hostile, DisplayName = "Zombie Villager", Name = "zombie_villager", Width = 0.6, Height = 1.95, };
        public static readonly MyEntity ZombifiedPiglin = new MyEntity { Id = 110, Type = EntityType.Hostile, DisplayName = "Zombified Piglin", Name = "zombified_piglin", Width = 0.6, Height = 1.95, };

        public static readonly MyEntity[] All = { AreaEffectCloud, ArmorStand, Arrow, Axolotl, Bat, Bee, Blaze, Boat, Cat, CaveSpider, ChestMinecart, Chicken, Cod, CommandBlockMinecart, Cow, Creeper, Dolphin, Donkey, DragonFireball, Drowned, Egg, ElderGuardian, EndCrystal, EnderDragon, Enderman, Endermite, EnderPearl, Evoker, EvokerFangs, ExperienceBottle, ExperienceOrb, EyeOfEnder, FallingBlock, Fireball, FireworkRocket, FishingBobber, Fox, FurnaceMinecart, Ghast, Giant, GlowItemFrame, GlowSquid, Goat, Guardian, Hoglin, HopperMinecart, Horse, Husk, Illusioner, IronGolem, Item, ItemFrame, LeashKnot, LightningBolt, Llama, LlamaSpit, MagmaCube, Marker, Minecart, Mooshroom, Mule, Ocelot, Painting, Panda, Parrot, Phantom, Pig, Piglin, PiglinBrute, Pillager, Player, PolarBear, Potion, Pufferfish, Rabbit, Ravager, Salmon, Sheep, Shulker, ShulkerBullet, Silverfish, Skeleton, SkeletonHorse, Slime, SmallFireball, Snowball, SnowGolem, SpawnerMinecart, SpectralArrow, Spider, Squid, Stray, Strider, Tnt, TntMinecart, TraderLlama, Trident, TropicalFish, Turtle, Vex, Villager, Vindicator, WanderingTrader, Witch, Wither, WitherSkeleton, WitherSkull, Wolf, Zoglin, Zombie, ZombieHorse, ZombieVillager, ZombifiedPiglin };
    }
}