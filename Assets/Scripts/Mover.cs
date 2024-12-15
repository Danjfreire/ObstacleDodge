using UnityEngine;

public class Mover : MonoBehaviour
{

    private void Start()
    {
    }

    private void Update()
    {
        transform.Translate(0.01f, 0f, 0f);
    }

}
