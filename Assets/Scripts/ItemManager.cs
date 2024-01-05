using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public List<Item> basicitems = new List<Item>();
    public Inventory inventory;
    public void addbasicitem(int id)
    {
        inventory.additem(basicitems[id]);
    }
}
