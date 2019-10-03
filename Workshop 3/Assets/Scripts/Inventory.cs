using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Inventory : MonoBehaviour
{
    public List<Item> Items = new List<Item>();

    public void AddItem(Item item)
    {
        Items.Add(item);
        Debug.Log("Item added: " + item.Name);
    }

    public bool CheckHasItems(List<Item> itemsNeeded)
    {
        foreach (var item in itemsNeeded)
        {
            var matchItems = Items.Where(i => i.Name.Equals(item.Name)).ToList();

            if (matchItems.Count >= itemsNeeded.Count)
            {
                foreach (var matchedItem in matchItems)
                {
                    Items.Remove(matchedItem);
                }
                
                return true;
            }
        }

        return false;
    }

}
