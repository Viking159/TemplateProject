using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PickMap : PickerInfoBase
{

    private MapSO _currentMap;

    protected override void UpdateStats()
    {
        if ((_items[_itemIndex] is MapSO) == false)
        {
            Debug.LogError($"Type Error: Item[{_itemIndex}] is not MapSO type!");
            return;
        }
        _currentMap = _items[_itemIndex] as MapSO;
        _title.text = _currentMap.Name;
        _objImage.sprite = _currentMap.MapImage;
        _statsValueText[0].text = _currentMap.ID.ToString();
        _statsValueText[1].text = _currentMap.Discription;
    }
}
