using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 */
/// <summary>
/// <para>TerrainRegistry - Nathaniel Ford</para>
/// The terrain registry is used to store prefabs of all terrain types.
/// Functions are made to easily get the prefab from the terrain type.
/// This class is serializable so that we can access it easily from the Unity Inspector.
/// </summary>
[System.Serializable]
public class TerrainRegistry
{

    [Header("Prefabs")]
    public GameObject waterPrefab;
    public GameObject lavaPrefab;
    public GameObject solidRockPrefab;
    public GameObject rockPrefab;
    public GameObject goldPrefab;
    public GameObject gemPrefab;
    public GameObject pathPrefab;
    public GameObject heroLairPrefab;
    public GameObject nonEditSolidRockPrefab;
    public GameObject manaVaultPrefab;
    public GameObject manaVaultP1Prefab;
    public GameObject manaVaultP2Prefab;
    public GameObject manaVaultP3Prefab;
    public GameObject manaVaultP4Prefab;
    public GameObject claimedPathP1Prefab;
    public GameObject claimedPathP2Prefab;
    public GameObject claimedPathP3Prefab;
    public GameObject claimedPathP4Prefab;
    public GameObject claimedPathGoodPrefab;
    public GameObject claimedWallP1Prefab;
    public GameObject claimedWallP2Prefab;
    public GameObject claimedWallP3Prefab;
    public GameObject claimedWallP4Prefab;
    public GameObject claimedWallGoodPrefab;

    /// <summary>
    /// Returns the appropriate registered prefab from the terrain value.
    /// </summary>
    public GameObject GetPrefabFromTerrain(Terrain t)
    {
        if (t == Terrain.WATER) return waterPrefab;
        if (t == Terrain.LAVA) return lavaPrefab;
        if (t == Terrain.SOLID_ROCK) return solidRockPrefab;
        if (t == Terrain.ROCK) return rockPrefab;
        if (t == Terrain.GOLD) return goldPrefab;
        if (t == Terrain.GEM) return gemPrefab;
        if (t == Terrain.PATH) return pathPrefab;
        if (t == Terrain.HERO_LAIR) return heroLairPrefab;
        if (t == Terrain.MANA_VAULT) return manaVaultPrefab;
        if (t == Terrain.MANA_VAULT_P1) return manaVaultP1Prefab;
        if (t == Terrain.MANA_VAULT_P2) return manaVaultP2Prefab;
        if (t == Terrain.MANA_VAULT_P3) return manaVaultP3Prefab;
        if (t == Terrain.MANA_VAULT_P4) return manaVaultP4Prefab;
        if (t == Terrain.CLAIMED_PATH_P1) return claimedPathP1Prefab;
        if (t == Terrain.CLAIMED_PATH_P2) return claimedPathP2Prefab;
        if (t == Terrain.CLAIMED_PATH_P3) return claimedPathP3Prefab;
        if (t == Terrain.CLAIMED_PATH_P4) return claimedPathP4Prefab;
        if (t == Terrain.CLAIMED_PATH_GOOD) return claimedPathGoodPrefab;
        if (t == Terrain.CLAIMED_WALL_P1) return claimedWallP1Prefab;
        if (t == Terrain.CLAIMED_WALL_P2) return claimedWallP2Prefab;
        if (t == Terrain.CLAIMED_WALL_P3) return claimedWallP3Prefab;
        if (t == Terrain.CLAIMED_WALL_P4) return claimedWallP4Prefab;
        if (t == Terrain.CLAIMED_WALL_GOOD) return claimedWallGoodPrefab;

        //No prefab found for the terrain. Should be impossible.
        throw new System.Exception("Invalid terrain found when retrieving prefab. Terrain: " + (int)t);
    }

}
