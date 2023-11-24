using System;
using System.Linq;
using Tiles;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace Items
{
    public class ItemsSpawner : MonoBehaviour, IItemsSpawner
    {
        [SerializeField] private ItemsBundle itemsBundle;
        
        public Item[,] SpawnItems(ITile[,] tiles)
        {
            var rows = tiles.GetLength(0);
            var cols = tiles.GetLength(1);
            
            var items = new Item[rows, cols];
            
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    if (tiles[i, j].Type != TileType.None)
                    {
                        var item = Instantiate(GetRandomItem(),
                            tiles[i, j].Position, Quaternion.identity);
                        items[i, j] = item;
                        tiles[i, j].Item = item;
                    }
                }
            }

            return items;
        }

        private Item GetRandomItem()
        {
            return itemsBundle.Items.ElementAt(Random.Range(0, itemsBundle.Items.Count)).Value;
        }
    }
}