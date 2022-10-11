using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour
{
    [ContextMenu("動かす")]
    private void MoveGround()
    {
        float seed = Random.value;
        TerrainData terrainData = GetComponent<Terrain>().terrainData;
        var heights = new float[terrainData.heightmapResolution, terrainData.heightmapResolution];

        for (int i = 0; i < terrainData.heightmapResolution; i++)
        {
            for (int j = 0; j < terrainData.heightmapResolution; j++)
            {
                //高さを決める
                heights[i, j] = Mathf.PerlinNoise(i * 0.01f + seed, j * 0.01f + seed) * 0.5f;
                //一定の高さ未満なら一律の高さにする
                if (heights[i, j] < 0.2f)
                {
                    heights[i, j] = 0.2f;
                }
            }
        }
        terrainData.SetHeights(0, 0, heights);
    }
}