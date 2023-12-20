using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float _xAngle = 0f;
    [SerializeField] private float _yAngle = 0.5f;
    [SerializeField] private float _zAngle = 0f;

    private void Update()
    {
        transform.Rotate(_xAngle, _yAngle, _zAngle);
    }
}