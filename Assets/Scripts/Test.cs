using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    string _characterName;

    private void Start()
    {
        _characterName = PlayerPrefs.GetString("�������g��");
        print(_characterName);
    }
}
