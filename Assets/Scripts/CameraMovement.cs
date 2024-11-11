using UnityEngine;

public class CameraMovement:MonoBehaviour
{
    [SerializeField] private float _Speed;
    Vector2 _Movement;
    
    private void FixedUpdate()
    {
        OnMovement(InputSync.Input.Player.Movement.ReadValue<Vector2>());
    }

    private void OnMovement(Vector2 movement)
    {
        transform.position += new Vector3(movement.x, movement.y) * _Speed * Time.deltaTime;
    }

}
