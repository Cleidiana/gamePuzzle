using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_segue : MonoBehaviour {

    public Transform target;
    public float smoothing = 1f;

    public Vector2 maxPos;
    public Vector2 minPos;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void FixedUpdate()
    {
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, -1);

        if (transform.position != target.position) {

            targetPos.x = Mathf.Clamp(targetPos.x, minPos.x, maxPos.x);
            targetPos.y = Mathf.Clamp(targetPos.y, minPos.y, maxPos.y);

            transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
        }
    }

}
