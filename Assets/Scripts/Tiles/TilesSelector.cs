using System;

namespace Tiles
{
    public class TilesSelector
    {
        private ITile _selectedTile;

        private bool TryToSwapTiles(ITile tileToSwap)
        {
            return false;
        }

        private bool CompareTiles(ITile xTile, ITile yTile)
        {
            var xPosition = yTile.Item.transform.position;
            var yPosition = xTile.Item.transform.position;
            
            return Math.Abs(xPosition.x - yPosition.x) < 0f &&
                   Math.Abs(xPosition.y - yPosition.y) < 0f;
        }
    }
}