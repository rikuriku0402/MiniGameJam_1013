using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigSmall : MonoBehaviour
{
    [SerializeField]
    [Header("1,巨乳で高身長2,貧乳で高身長3,巨乳で低身長4,貧乳で低身長")]
    List<Image> _iamges = new List<Image>();

    /// <summary>
    /// 巨乳で高身長
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
    /// 貧乳で高身長
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
    /// 巨乳で低身長
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
    /// 貧乳で低身長
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
