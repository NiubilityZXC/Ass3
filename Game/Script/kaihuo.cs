using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaihuo : MonoBehaviour
{
    public GameObject fire;
    public Transform firePoint;
    public float force = 500;
    public AudioSource music;
    public AudioClip Fire;
    private void Awake()
    {
        music = gameObject.AddComponent<AudioSource>();
        music.playOnAwake = false;
        Fire = Resources.Load<AudioClip>("Music/ShellExplosion");
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject go = GameObject.Instantiate(fire, firePoint.position, firePoint.transform.rotation);
            Rigidbody rig = go.GetComponent<Rigidbody>();
            if (rig)
            {
                rig.AddRelativeForce(Vector3.forward * force);
            }
            music.clip = Fire;
            music.Play();
            //            ShellExplosion.Play();
        }
    }
}
