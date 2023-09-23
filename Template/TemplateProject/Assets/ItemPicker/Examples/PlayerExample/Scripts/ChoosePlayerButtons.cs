using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlayerButtons : MonoBehaviour
{
    [SerializeField] private GameObject _playerPickerFrame;
    public void ChoosePlayerFrame()
    {
        Instantiate(_playerPickerFrame, this.transform).GetComponent<PickerInfoBase>().Init();
    }

}
