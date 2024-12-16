using UnityEngine;

public class Mover : MonoBehaviour
{
    private const string HORIZONTAL_AXIS = "Horizontal";
    private const string VERTICAL_AXIS = "Vertical";

    [SerializeField] private float moveSpeed = 10f;

    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        float xMovement = Input.GetAxis(HORIZONTAL_AXIS) * Time.deltaTime * moveSpeed;
        float zMovement = Input.GetAxis(VERTICAL_AXIS) * Time.deltaTime * moveSpeed;
        transform.Translate(xMovement, 0f, zMovement);
    }
}
