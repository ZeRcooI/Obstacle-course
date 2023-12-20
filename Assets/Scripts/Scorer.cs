using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            _hits++;

            Debug.Log(_hits);
        }
    }
}