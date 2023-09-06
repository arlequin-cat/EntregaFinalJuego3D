using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMovement : MonoBehaviour
{
    public int layerIndex=0;
    public float flowSpeed;
    private Terrain terrain;
    private TerrainLayer lavaLayer;

    private void Start()
    {
         terrain = GetComponent<Terrain>();
         lavaLayer = terrain.terrainData.terrainLayers[layerIndex];
    }

    private void Update()
    {
        lavaLayer.tileOffset += Vector2.one*Time.deltaTime*flowSpeed;
    }
}
