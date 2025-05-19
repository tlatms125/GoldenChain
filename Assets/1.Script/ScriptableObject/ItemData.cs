using UnityEngine;
[CreateAssetMenu(fileName = "ItemData", menuName = "Item/ItemData")]
public class ItemData : ScriptableObject
{
   public string itemKey;
   public string itemName; // 표기해주는 용도
   public Sprite thumnail;
   public ItemCategory itemCategory;
   public int maxCount;
   public string itemDescription;
}
public enum ItemCategory
{
   Seed,
   Etc
}


