using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;

    /*

    private List<Items> itemsList;

    public Inventory()
    {
        itemsList = new List<Items>();

        AddItem(new Items { itemType = Items.ItemType.key, amount = 1 });
        AddItem(new Items { itemType = Items.ItemType.book, amount = 1 });
    }
    public void AddItem(Items item)
    {
        itemsList.Add(item);
    }
    public List<Items> GetItemsList ()
    {
        return itemsList;

    } */
}
