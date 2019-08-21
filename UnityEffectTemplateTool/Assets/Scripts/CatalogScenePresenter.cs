using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> CatalogScene Presenter </summary>
public class CatalogScenePresenter : MonoBehaviour
{
    [SerializeField] private List<GameObject> _effectList = new List<GameObject>();

    void Start()
    {
        _effectList.ForEach(x => x.SetActive(false));
    }
}
