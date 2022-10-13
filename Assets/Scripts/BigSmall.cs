using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigSmall : MonoBehaviour
{
    [SerializeField]
    [Header("1,�����ō��g��2,�n���ō��g��3,�����Œ�g��4,�n���Œ�g��")]
    List<Image> _iamges = new List<Image>();

    /// <summary>
    /// �����ō��g��
    /// </summary>
    public void BigTallButton(string scene)
    {
        _iamges[0].gameObject.SetActive(true);
        _iamges[1].gameObject.SetActive(false);
        _iamges[2].gameObject.SetActive(false);
        _iamges[3].gameObject.SetActive(false);
        SceneLoader.Instance.SceneChange(scene);
    }

    /// <summary>
    /// �n���ō��g��
    /// </summary>
    public void SmallTallButton(string scene)
    {
        _iamges[0].gameObject.SetActive(false);
        _iamges[1].gameObject.SetActive(true);
        _iamges[2].gameObject.SetActive(false);
        _iamges[3].gameObject.SetActive(false);
        SceneLoader.Instance.SceneChange(scene);
    }

    /// <summary>
    /// �����Œ�g��
    /// </summary>
    public void BigShortStatureButton(string scene)
    {
        _iamges[0].gameObject.SetActive(false);
        _iamges[1].gameObject.SetActive(false);
        _iamges[2].gameObject.SetActive(true);
        _iamges[3].gameObject.SetActive(false);
        SceneLoader.Instance.SceneChange(scene);
    }

    /// <summary>
    /// �n���Œ�g��
    /// </summary>
    public void SmallShortStature(string scene)
    {
        _iamges[0].gameObject.SetActive(false);
        _iamges[1].gameObject.SetActive(false);
        _iamges[2].gameObject.SetActive(false);
        _iamges[3].gameObject.SetActive(true);
        SceneLoader.Instance.SceneChange(scene);
    }
}
