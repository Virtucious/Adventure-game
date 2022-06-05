using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_box : Collectable
{
    public Sprite emptyBox;
    public int items = 5;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyBox;
        }
    }
}
