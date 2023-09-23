using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private KeyCode _prevIndex;
    [SerializeField] private KeyCode _nextIndex;

    private PickerInfoBase _picker;

    private void Start()
    {
        _picker = GetComponent<PickerInfoBase>();
    }

    void Update()
    {
        if (Input.GetKeyDown(_nextIndex))
            _picker.IncreaseIndex();

        if (Input.GetKeyDown(_prevIndex))
            _picker.DecreaseIndex();
    }
}
