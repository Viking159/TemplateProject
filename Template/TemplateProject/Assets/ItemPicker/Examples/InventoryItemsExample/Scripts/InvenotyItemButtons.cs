using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenotyItemButtons : MonoBehaviour
{
    [SerializeField] private GameObject _itemPicker;

    public void ChooseItem()
    {
        Instantiate(_itemPicker, this.transform).GetComponent<InventoryItemPicker>().Init();
    }

}
