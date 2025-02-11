using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;

    private float speed2;

    [SerializeField]
    private float speed3;

    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");

        //Debug.Log($"MovementX = {movementX}, MovementY = {movementY}");

        Vector3 movement = new Vector3(movementX, movementY,0);

        transform.Translate(movement * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            Debug.Log("Il a bien le tag finish");
        }
        
    }
}
