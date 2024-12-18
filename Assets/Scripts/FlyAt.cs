using UnityEngine;

public class FlyAt : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;

    private Vector3 targetPosition;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void Start()
    {
        targetPosition = target.position;
        Debug.Log("Got target");
    }

    private void Update()
    {
        // destroy if reached target
        if (transform.position == targetPosition)
        {
            Destroy(gameObject);
        }

        // move towards target
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    public void Activate()
    {
        Debug.Log("called");
        gameObject.SetActive(true);
    }
}
