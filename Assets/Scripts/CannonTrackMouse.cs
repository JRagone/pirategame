using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonTrackMouse : TrackMouse
{
    public float maxRotation;
    public Transform hull;

    CannonInformation cannonInfo;
    Side side;

    private void Start() {
        cannonInfo = GetComponent<CannonInformation>();
        side = cannonInfo.side;
    }

    void FixedUpdate()
    {
        LookAtMouse();
    }

    new protected void LookAtMouse() {
        Vector2 direction = new Vector2(
            mousePos.x - transform.position.x,
            mousePos.y - transform.position.y
        );
        Vector2 hullSide = hull.right;
        if (side == Side.starboard) {
            hullSide = hull.right;
        }
        else if (side == Side.port) {
            hullSide = -hull.right;
        }
        float newAngle = Vector2.Angle(direction, hullSide);
        if (newAngle < maxRotation) {
            transform.up = direction;
        }
    }
}
