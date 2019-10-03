using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> Items = new List<Item>();

    public void AddItem(Item item)
    {
        Items.Add(item);
        Debug.Log("Item added: " + item.Name);
    }

    public bool HasItem(Item itemToBeChecked)
    {
        foreach (var item in Items)
        {
            if (item.Name.Equals(itemToBeChecked.Name))
            {
                return true;
            }
        }

        return false;
    }

    public int ItemCount(Item itemToBeChecked)
    {
        int count = 0;

        foreach (var item in Items)
        {
            if (item.Name.Equals(itemToBeChecked.Name))
            {
                count++;
            }
        }

        return count;
    }
}
