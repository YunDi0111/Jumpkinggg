using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = player.transform.position;
        transform.position = new Vector3(a.x, a.y + 1f, transform.position.z);
    }
}
