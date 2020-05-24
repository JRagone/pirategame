using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMouse : MonoBehaviour
{
    protected Vector3 mousePos;

    // Start is called before the first frame update
    void Update()
    {
        Vector3 vector = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        mousePos = Camera.main.ScreenToWorldPoint(vector);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LookAtMouse();
    }

    protected void LookAtMouse() {
        Vector2 direction = new Vector2(
            mousePos.x - transform.position.x,
            mousePos.y - transform.position.y
        );

        transform.up = direction;
    }
}
