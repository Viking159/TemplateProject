using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class PickerInfoBase : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI _title;
    [SerializeField] protected Image _objImage;
    [SerializeField] protected TextMeshProUGUI[] _statsValueText;
    [SerializeField] protected ItemSOBase[] _items;
    [SerializeField] protected Image[] _itemsImage;

    protected int _itemIndex;

    public virtual void Init()
    {
        _itemIndex = 0;
        for (int i = 0; i < _items.Length; i++)
        {
            _itemsImage[i].sprite = _items[i].Icon;
        }
        UpdateStats();
    }

    protected abstract void UpdateStats();

    public void ChangeIndex(int newIndex)
    {
        _itemIndex = newIndex;
        UpdateStats();
    }

    public void IncreaseIndex()
    {
        if (_itemIndex == _items.Length - 1)
            ChangeIndex(0);
        else
            ChangeIndex(_itemIndex + 1);
    }

    public void DecreaseIndex()
    {
        if (_itemIndex == 0)
            ChangeIndex(_items.Length - 1);
        else
            ChangeIndex(_itemIndex - 1);
    }

}
