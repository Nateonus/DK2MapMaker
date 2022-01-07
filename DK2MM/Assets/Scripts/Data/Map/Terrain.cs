/// <summary>
/// <para>Terrain - Nathaniel Ford</para>
/// The Terrain enum stores the various types of terrain.
/// These are stored in the DK2Map object, and graphics are
///   obtained from the graphics registry.
/// </summary>
[System.Serializable]
public enum Terrain
{
    WATER,
    LAVA,
    SOLID_ROCK,
    ROCK,
    GOLD,
    GEM,
    PATH,
    HERO_LAIR,
    MANA_VAULT,
    MANA_VAULT_P1,
    MANA_VAULT_P2,
    MANA_VAULT_P3,
    MANA_VAULT_P4,
    CLAIMED_PATH_P1,
    CLAIMED_PATH_P2,
    CLAIMED_PATH_P3,
    CLAIMED_PATH_P4,
    CLAIMED_PATH_GOOD,
    CLAIMED_WALL_P1,
    CLAIMED_WALL_P2,
    CLAIMED_WALL_P3,
    CLAIMED_WALL_P4,
    CLAIMED_WALL_GOOD
}
