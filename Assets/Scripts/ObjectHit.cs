using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.cyan;
        Debug.Log("Collided with:" + other.gameObject.name);
    }

}
