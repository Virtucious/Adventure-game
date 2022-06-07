using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface InventoryItem
{
    string Name { get; }
    Sprite Image { get; }

    void onPickup();
}

public class InventoryEventArgs : EventArgs
{
    public InventoryEventArgs(InventoryItem item)
    {
        Item = item;
    }
    public InventoryItem Item;
}