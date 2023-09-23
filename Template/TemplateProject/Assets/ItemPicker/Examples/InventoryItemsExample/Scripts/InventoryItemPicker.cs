using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemPicker : PickerInfoBase
{

    private InventoryItemSO _currentItem;

    protected override void UpdateStats()
    {
        if ((_items[_itemIndex] is InventoryItemSO) == false)
        {
            Debug.LogError($"Type Error: Item[{_itemIndex}] is not MapSO type!");
            return;
        }
        _currentItem = _items[_itemIndex] as InventoryItemSO;
        _title.text = _currentItem.Name;
        _objImage.sprite = _currentItem.Icon;
        _statsValueText[0].text = _currentItem.Quantity.ToString();
        _statsValueText[1].text = _currentItem.Rareness;
    }
}
