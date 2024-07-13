using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float x = 1.0f, y = 0.01f, z = 0.01f;
    [SerializeField] float moveSpeed = 0.0f;
    void Start()
    {
        PrintInstructions();
        transform.Translate(x, y, z);

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

    }

    void PrintInstructions()
    {
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xValue * moveSpeed, 0, zValue * moveSpeed);
    }
}
