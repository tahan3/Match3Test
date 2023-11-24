using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using Items;
using Tiles;
using UnityEngine;

namespace Trash
{
    public class TestGameInstaller : MonoBehaviour
    {
        [SerializeField] private ItemsSpawner itemsSpawner;

        private TilesGenerator _tilesGenerator;
        
        private void Start()
        {
            _tilesGenerator = new TilesGenerator();
            
            var tiles = _tilesGenerator.GenerateTiles();
            itemsSpawner.SpawnItems(tiles);
            
            if (Camera.main != null)
            {
                var cameraTransform = Camera.main.transform;
                var center = tiles[tiles.GetLength(0) / 2,
                    tiles.GetLength(1) / 2].Position;
            }
        }
    }
}
