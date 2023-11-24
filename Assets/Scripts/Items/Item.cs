using UnityEngine;

namespace Items
{
    public class Item : MonoBehaviour, IItem
    {
        [SerializeField] private ItemType itemType;

        public ItemType Type => itemType;
    }
}