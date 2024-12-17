using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float dropTimer = 3f;

    private MeshRenderer meshRenderer;
    private Rigidbody rigidBody;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        rigidBody.useGravity = false;
        meshRenderer.enabled = false;
    }

    private void Start() { }

    private void Update()
    {
        if (Time.time > dropTimer)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
