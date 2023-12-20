using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private Rigidbody _rigidbody;
    [SerializeField] private float _timeToWait = 5f;

    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();

        _meshRenderer.enabled = false;
        _rigidbody.useGravity = false;
    }

    void Update()
    {
        Debug.Log(Time.time);

        if (Time.time > _timeToWait)
        {
            _meshRenderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
}