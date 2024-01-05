using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<ItemSlot> inventoryslots;
    public void additem(Item I)
    {
        foreach (ItemSlot slot in inventoryslots)
        {
            if(slot.Isempty)
            {
                slot.UpdateSlot(I);
                break;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
