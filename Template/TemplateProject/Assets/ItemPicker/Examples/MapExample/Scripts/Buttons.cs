using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject _mapPicker;

    public void ChooseMap()
    {
        Instantiate(_mapPicker, this.transform).GetComponent<PickMap>().Init();
    }

}
