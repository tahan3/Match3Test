using Items;
using UnityEngine;

namespace Tiles
{
    public class Tile : ITile
    {
        public Item Item { get; set; }
        public TileType Type { get; }
        public Vector2 Position { get; }

        public Tile(Vector2 position)
        {
            Type = TileType.Empty;
            Position = position;
        }
        
        public Tile(Vector2 position, TileType tileType)
        {
            Type = tileType;
            Position = position;
        }
    }
}