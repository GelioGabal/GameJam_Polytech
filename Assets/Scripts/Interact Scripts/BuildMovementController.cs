using UnityEngine;
using UnityEngine.InputSystem;

public class BuildMovementController:MonoBehaviour
{
    [SerializeField] bool ColiderEnter = false;
    SpriteRenderer spriter;
    Color startColor;
    void Start()
    {
        spriter = GetComponent<SpriteRenderer>();
        startColor = spriter.color;
        InputSync.Input.Player.Place.performed += PlaceObject;
    }
    void OnDisable()
    {
        InputSync.Input.Player.Place.performed -= PlaceObject;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Building")) ColiderEnter = true;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Building")) ColiderEnter = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Building")) ColiderEnter = false;
    }
    void PlaceObject(InputAction.CallbackContext ctx)
    {
        if (!ColiderEnter)
        {
            Destroy(this);
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            spriter.color = startColor;
        }
        else
        {
            Debug.Log("тут нельзя строить");
        }
    }

    void FixedUpdate()
    {
        transform.position = InputSync.MousePosition;
        spriter.color = (ColiderEnter) ? Color.red : Color.green;
    }
}
