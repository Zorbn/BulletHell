﻿using System.Collections.ObjectModel;

namespace Common;

public class WeaponStats
{
    private const float LowCooldownTier1 = 0.35f;
    private const float MediumCooldownTier1 = 0.4f;
    private const float HighCooldownTier1 = 0.6f;
    private const float LowCooldownTier2 = 0.25f;
    private const float MediumCooldownTier2 = 0.35f;
    private const float HighCooldownTier2 = 0.5f;
    private const float LowCooldownTier3 = 0.15f;
    private const float MediumCooldownTier3 = 0.3f;
    private const float HighCooldownTier3 = 0.4f;

    private const float LowSpeedTier1 = 0.9f;
    private const float MediumSpeedTier1 = 1.1f;
    private const float HighSpeedTier1 = 1.4f;
    private const float LowSpeedTier2 = 1.0f;
    private const float MediumSpeedTier2 = 1.2f;
    private const float HighSpeedTier2 = 1.6f;
    private const float LowSpeedTier3 = 1.1f;
    private const float MediumSpeedTier3 = 1.3f;
    private const float HighSpeedTier3 = 1.8f;

    public static readonly Dictionary<WeaponType, WeaponStats?> Registry = new()
    {
        // TODO: Consider adding a default punch attack (used when the player isn't carrying anything).
        { WeaponType.None, null }
    };

    static WeaponStats()
    {
        Register(new WeaponStats(WeaponType.Sword, "Sword", WeaponType.Longsword, HighCooldownTier1, LowSpeedTier1,
            Sprite.Sword,
            new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownSword, Angle = 0f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownSword, Angle = 45f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownSword, Angle = 90f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownSword, Angle = 135f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownSword, Angle = 180f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownSword, Angle = 225f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownSword, Angle = 270f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownSword, Angle = 315f, RelativeToForward = false }
            }));
        Register(new WeaponStats(WeaponType.Longsword, "Longsword", WeaponType.None, HighCooldownTier2, LowSpeedTier2,
            Sprite.Longsword, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownLongsword, Angle = 0f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownLongsword, Angle = 45f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownLongsword, Angle = 90f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownLongsword, Angle = 135f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownLongsword, Angle = 180f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownLongsword, Angle = 225f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownLongsword, Angle = 270f, RelativeToForward = false },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownLongsword, Angle = 315f, RelativeToForward = false }
            }));

        Register(new WeaponStats(WeaponType.Dagger, "Dagger", WeaponType.DoubleDagger, LowCooldownTier1, HighSpeedTier1,
            Sprite.Dagger, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownDagger, Angle = 0f, RelativeToForward = true }
            }));
        Register(new WeaponStats(WeaponType.DoubleDagger, "Double Dagger", WeaponType.TripleDagger, LowCooldownTier2,
            HighSpeedTier2,
            Sprite.DoubleDagger, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownDagger, Angle = -10f, RelativeToForward = true },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownDagger, Angle = 10f, RelativeToForward = true }
            }));
        Register(new WeaponStats(WeaponType.TripleDagger, "TripleDagger", WeaponType.None, LowCooldownTier3,
            HighSpeedTier3,
            Sprite.TripleDagger, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownDagger, Angle = -15f, RelativeToForward = true },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownDagger, Angle = 0f, RelativeToForward = true },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownDagger, Angle = 15f, RelativeToForward = true }
            }));

        Register(new WeaponStats(WeaponType.Knife, "Knife", WeaponType.Machete, MediumCooldownTier1, HighSpeedTier1,
            Sprite.Knife, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownKnife, Angle = 0f, RelativeToForward = true }
            }));
        Register(new WeaponStats(WeaponType.Machete, "Machete", WeaponType.None, MediumCooldownTier2, HighSpeedTier2,
            Sprite.Machete, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownMachete, Angle = 0f, RelativeToForward = true }
            }));

        Register(new WeaponStats(WeaponType.Spear, "Spear", WeaponType.DoubleSpear, MediumCooldownTier1, MediumSpeedTier1,
            Sprite.Spear,
            new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownSpear, Angle = 0f, RelativeToForward = true }
            }));
        Register(new WeaponStats(WeaponType.DoubleSpear, "Double Spear", WeaponType.QuadSpear, MediumCooldownTier2, MediumSpeedTier2,
            Sprite.DoubleSpear,
            new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownDoubleSpear, Angle = 0f, RelativeToForward = true },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownDoubleSpear, Angle = 180f, RelativeToForward = true }
            }));
        Register(new WeaponStats(WeaponType.QuadSpear, "Quad Spear", WeaponType.None, MediumCooldownTier3, MediumSpeedTier3,
            Sprite.QuadSpear,
            new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownQuadSpear, Angle = 0f, RelativeToForward = true },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownQuadSpear, Angle = 90f, RelativeToForward = true },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownQuadSpear, Angle = -90f, RelativeToForward = true },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ThrownQuadSpear, Angle = 180f, RelativeToForward = true }
            }));

        Register(new WeaponStats(WeaponType.FireWand, "Fire Wand", WeaponType.FireStaff, HighCooldownTier1,
            LowSpeedTier1,
            Sprite.FireWand, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.Fireball, Angle = 0f, RelativeToForward = true }
            }));
        Register(new WeaponStats(WeaponType.FireStaff, "Fire Staff", WeaponType.FireCharm, HighCooldownTier2,
            LowSpeedTier2,
            Sprite.FireStaff, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.FireNova, Angle = 0f, RelativeToForward = true }
            }));
        Register(new WeaponStats(WeaponType.FireCharm, "Fire Charm", WeaponType.None, HighCooldownTier3, LowSpeedTier3,
            Sprite.FireCharm, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.FireNova, Angle = -10f, RelativeToForward = true },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.FireNova, Angle = 10f, RelativeToForward = true }
            }));

        Register(new WeaponStats(WeaponType.Crossbow, "Crossbow", WeaponType.DoubleCrossbow, MediumCooldownTier1,
            MediumSpeedTier1,
            Sprite.Crossbow, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.CrossbowBolt, Angle = 0f, RelativeToForward = true }
            }));
        Register(new WeaponStats(WeaponType.DoubleCrossbow, "Double Crossbow", WeaponType.None, MediumCooldownTier2,
            MediumSpeedTier2,
            Sprite.DoubleCrossbow, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.CrossbowBolt, Angle = -10f, RelativeToForward = true },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.CrossbowBolt, Angle = 10f, RelativeToForward = true }
            }));

        Register(new WeaponStats(WeaponType.Shortbow, "Shortbow", WeaponType.Longbow, HighCooldownTier1, LowSpeedTier1,
            Sprite.Shortbow, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.Arrow, Angle = 0f, RelativeToForward = true }
            }));
        Register(new WeaponStats(WeaponType.Longbow, "Longbow", WeaponType.None, HighCooldownTier2, LowSpeedTier2,
            Sprite.Longbow,
            new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.Arrow, Angle = 0f, RelativeToForward = true }
            }));

        Register(new WeaponStats(WeaponType.Scythe, "Scythe", WeaponType.None, MediumCooldownTier1, MediumSpeedTier1,
            Sprite.Scythe, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.ScytheBlades, Angle = 0f, RelativeToForward = true }
            }));

        Register(new WeaponStats(WeaponType.SporeBlaster, "Spore Blaster", WeaponType.None, LowCooldownTier1,
            LowSpeedTier1,
            Sprite.SporeBlaster, new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.Spores, Angle = -15f, RelativeToForward = true },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.Spores, Angle = 0f, RelativeToForward = true },
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.Spores, Angle = 15f, RelativeToForward = true }
            }));

        Register(new WeaponStats(WeaponType.Mace, "Mace", WeaponType.None, MediumCooldownTier1, LowSpeedTier1,
            Sprite.Mace,
            new[]
            {
                new ProjectileSpawnData
                    { ProjectileType = ProjectileType.SpikeBall, Angle = 0f, RelativeToForward = true }
            }));
    }

    public readonly WeaponType WeaponType;
    public readonly string DisplayName;
    public readonly WeaponType Evolution;
    public readonly float AttackCooldown;
    public readonly float SpeedMultiplier;
    public readonly Sprite Sprite;
    public readonly ReadOnlyCollection<ProjectileSpawnData> ProjectileSpawns;
    public readonly float AttackRange;

    private WeaponStats(WeaponType weaponType, string displayName, WeaponType evolution, float attackCooldown,
        float speedMultiplier, Sprite sprite, ProjectileSpawnData[] projectileSpawns)
    {
        WeaponType = weaponType;
        DisplayName = displayName;
        Evolution = evolution;
        AttackCooldown = attackCooldown;
        SpeedMultiplier = speedMultiplier;
        Sprite = sprite;
        ProjectileSpawns = new ReadOnlyCollection<ProjectileSpawnData>(projectileSpawns);

        foreach (var projectileSpawn in ProjectileSpawns)
            AttackRange = Math.Max(AttackRange, ProjectileStats.Registry[projectileSpawn.ProjectileType].Range);
    }

    private static void Register(WeaponStats weaponStats)
    {
        Registry.Add(weaponStats.WeaponType, weaponStats);
    }
}