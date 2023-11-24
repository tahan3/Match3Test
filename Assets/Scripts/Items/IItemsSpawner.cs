using Tiles;

namespace Items
{
    public interface IItemsSpawner
    {
        public Item[,] SpawnItems(ITile[,] tiles);
    }
}