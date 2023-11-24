using System;

namespace Tiles
{
    public interface ITilesSelector
    {
        public event Action<ITile> OnTileSelected;
        public event Action<ITile> OnTileDeselected;
    }
}