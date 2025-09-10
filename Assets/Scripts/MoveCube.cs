using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private float speed = 10.0f;
    private float move;
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        move = Input.GetAxis("Horizontal");
        transform.position = new Vector3(pos.x + (speed * Time.deltaTime * move), pos.y, pos.z);
    }
}
