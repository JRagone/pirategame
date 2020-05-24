using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float frequency = 4f;  // Speed of sine movement
    public float magnitude = 0.001f;   // Size of sine movement

    // Update is called once per frame
    void Update () {
        Vector2 scale = transform.localScale;
        transform.localScale = scale + Vector2.one * Mathf.Sin (Time.time * frequency) * magnitude;
    }
}
