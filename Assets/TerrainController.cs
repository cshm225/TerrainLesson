using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour
{

    [ContextMenu("動かす")]
    private void MoveGround()
    {
        TerrainData terrainData = GetComponent<Terrain>().terrainData;
        var heights = new float[terrainData.heightmapResolution, terrainData.heightmapResolution];
        for (int i = 0; i < terrainData.heightmapResolution; i++)
        {
            for (int j = 0; j < terrainData.heightmapResolution; j++)
            {
                heights[i,j]=Random.Range(0.0f,1.0f);
            }
        }
        terrainData.SetHeights(0, 0, heights);
    }
}
