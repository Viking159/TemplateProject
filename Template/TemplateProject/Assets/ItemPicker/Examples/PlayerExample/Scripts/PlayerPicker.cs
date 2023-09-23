using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PlayerPicker : PickerInfoBase
{
    [SerializeField] private Transform _modelTransform;

    private GameObject _currentModelObject = null;

    private PlayerSO _currentPlayer;

    protected override void UpdateStats()
    {
        if ((_items[_itemIndex] is PlayerSO) == false)
        {
            Debug.LogError($"Type Error: Item[{_itemIndex}] is not PlayerSO type!");
            return;
        }
        _currentPlayer = _items[_itemIndex] as PlayerSO;

        _title.text = _currentPlayer.Name;
        _objImage.sprite = _currentPlayer.Icon;
        _statsValueText[0].text = _currentPlayer.Level.ToString();

        if (_currentModelObject != null)
            Destroy(_currentModelObject);
        _currentModelObject = Instantiate(_currentPlayer.Model, _modelTransform);
        _currentModelObject.transform.localScale = new Vector3(100, 100, 100);
        _currentModelObject.transform.rotation = Quaternion.Euler(-16, 21, 0);
        _currentModelObject.transform.localPosition = new Vector3(_currentModelObject.transform.localPosition.x,
            _currentModelObject.transform.localPosition.y, -1000);
    }


}
