using System;
using Unity.VisualScripting;

namespace Tiles
{
    public interface ITilesSwapper
    {
        public event Action<ITile> OnStartSwap;
        public event Action<ITile> OnEndSwap;
    }
}