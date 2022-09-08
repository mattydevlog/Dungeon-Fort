using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    public GameObject player;
    public GameObject groundCheck;

    [SerializeField]
    public float movementSpeed;
    public float jumpHeight;

    bool isGroundCheck;

    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey("space"))
        {
            transform.Translate(Vector3.up * Time.deltaTime * jumpHeight);
        }
      

    }

}
