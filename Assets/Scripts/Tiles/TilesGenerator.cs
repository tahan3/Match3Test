using System.Data;
using UnityEngine;

namespace Tiles
{
    public class TilesGenerator : ITileGenerator
    {
        public ITile[,] GenerateTiles()
        {
            int rows = GameSettings.LVL_DATA.GetLength(0);
            int cols = GameSettings.LVL_DATA.GetLength(1);
            
            ITile[,] tilesMatrix = new ITile[rows, cols];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    tilesMatrix[i, j] = new Tile(new Vector2
                        (i * GameSettings.TILE_SIZE, j * GameSettings.TILE_SIZE), 
                        (TileType)GameSettings.LVL_DATA[i, j]);
                }
            }

            return tilesMatrix;
        }
    }
}