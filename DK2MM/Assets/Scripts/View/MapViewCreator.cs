using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <para>MapViewCreator - Nathaniel Ford</para>
/// MapViewCreator is a unity class, used to generate the 3D view of a map.
/// It uses the various registries to place the appropriate prefabs from the map.
/// </summary>
public class MapViewCreator : MonoBehaviour
{

    [Header("Unity Refs")]
    public TerrainRegistry terrainRegistry;
    public TileSelector tileSelector;

    // Start is called before the first frame update
    void Start()
    {
        Terrain[,] t = new Terrain[64, 64];
        for (int x = 0; x < t.GetLength(1); x++)
        {
            for (int y = 0; y < t.GetLength(0); y++)
            {
                t[x, y] = (Terrain)Random.Range(0, 23);
            }
        }
        DK2Map m = new DK2Map();
        m.terrain = t;
        tileSelector.setActiveMap(m);
        GenerateTerrainForMap(m, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /// <summary>
    /// Generates a 3D terrain from a map's terrain array.
    /// </summary>
    void GenerateTerrainForMap(DK2Map map, Transform parent)
    {
        for (int x = 0; x < map.terrain.GetLength(1); x++)
        {
            for (int y = 0; y < map.terrain.GetLength(0); y++)
            {
                Instantiate(terrainRegistry.GetPrefabFromTerrain(map.terrain[y, x]), new Vector3(x, 0, y), Quaternion.identity, parent);
            }
        }
    }

}
