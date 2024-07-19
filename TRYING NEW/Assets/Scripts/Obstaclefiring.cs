using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class Obstaclefiring : MonoBehaviour
{
    float current_time = 3f, starting_time = 3f;
    public GameObject bullet;
    GameObject fired_blt;
    public int blts_no;
    //int i = 0;
    public Transform wrt_camera, enb;
    //public float enbforce;
    //public Rigidbody2D enblt;
    void Update()
    {
        current_time -= 1 * Time.deltaTime;
        if (current_time < 0f)
        {
            current_time = starting_time;
            Fire();
        }
    }
    void Fire()
    {
        if (transform.position.y > wrt_camera.position.y - 4 && transform.position.y < (wrt_camera.position.y + 9 - 4))
        {
            fired_blt = Instantiate(bullet, transform.position, transform.rotation);
            fired_blt.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -3f);
        }

    }
    void Start()
    {
        Fire();
    }

    // void Start()
    // {
    //     if (transform.position.y < (wrt_camera.position.y + 9))
    //     {
    //         enb.position=transform.position;
    //         enblt.AddForce(new Vector2(0,-enbforce*Time.deltaTime));
    //         i++;
    //     }

    // }

    void FixedUpdate()
    {
        //-4 since camera position 4 ahead of player
        // if (transform.position.y > wrt_camera.position.y - 4 && transform.position.y < (wrt_camera.position.y + 9 - 4))
        // {
        //     Fire();
        // }

        // else if (i == 0 && transform.position.y > wrt_camera.position.y - 4 && transform.position.y < (wrt_camera.position.y + 9 - 4))
        // {


        // }
    }
    //transform.position.y>player.position.y && enb.position.y<player.position.y
    // void FixedUpdate()
    // {
    //     //-4 since camera position 4 ahead of player
    //     if (transform.position.y > wrt_camera.position.y - 4 && enb.position.y < (transform.position.y - 9) && transform.position.y < (wrt_camera.position.y + 9 - 4))
    //     {
    //         enblt.AddForce(new Vector2(0, enbforce * Time.deltaTime));
    //         enb.position = transform.position;
    //         enblt.AddForce(new Vector2(0, -enbforce * Time.deltaTime));
    //     }

    //     else if (i == 0 && transform.position.y > wrt_camera.position.y - 4 && transform.position.y < (wrt_camera.position.y + 9 - 4))
    //     {
    //         i++;
    //         enb.position = transform.position;
    //         enblt.AddForce(new Vector2(0, -enbforce * Time.deltaTime));

    //     }
    // }

}
