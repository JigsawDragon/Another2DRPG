using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Item itemwithin;
    public bool Isempty = true;
    public Image icon;

    public void UpdateSlot(Item I)
    {
        itemwithin = I;
        icon.sprite = I.inventoryIcon;
        Isempty = false;
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
