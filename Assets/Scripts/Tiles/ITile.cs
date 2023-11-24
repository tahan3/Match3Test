using Items;
using UnityEngine;

namespace Tiles
{
    public interface ITile
    {
        public Item Item { get; set; }
        public TileType Type { get; }
        public Vector2 Position { get; }
    }
}