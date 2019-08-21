using UnityEngine;

/// <summary> 竜巻タイプのエフェクト用コントローラー </summary>
public class TornadoEffectController : MonoBehaviour
{
    [SerializeField] private Transform _root;
    [SerializeField] private float _speed;

    void Update()
    {
        _root.Rotate((new Vector3(0, 90.0f, 0) * Time.deltaTime * _speed), Space.World);
    }
}
