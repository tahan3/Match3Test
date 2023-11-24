using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using UnityEngine;

namespace Items
{
    [CreateAssetMenu(fileName = "ItemsBundle", menuName = "ItemsBundle", order = 0)]
    public class ItemsBundle : ScriptableObject
    {
        [SerializedDictionary("Item Type", "Item Prefab")]
        public SerializedDictionary<ItemType, Item> Items;
    }
}