using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
    public float Camera_Height;
    public float Camera_Disctance;
    public Transform TankTrans;
    public Boundary boundary;
	// Use this for initialization
	void Start () {
        this.TankTrans = GameObject.FindGameObjectWithTag("Player").transform;
	}

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxis("Horizontal");
        this.transform.position = new Vector3(this.TankTrans.position.x, this.TankTrans.position.y + this.Camera_Height, this.TankTrans.position.z - this.Camera_Disctance);
        this.transform.LookAt(this.TankTrans);
        if (h != 0)
        {
            transform.Rotate(0, h * Time.deltaTime * 4, 0, Space.Self);
        }
        if (this.TankTrans != null)
        {
            this.TankTrans.position = new Vector3(Mathf.Clamp(this.TankTrans.position.x,-99, 96), Mathf.Clamp(this.TankTrans.position.y,0.6f,0.8f),
                Mathf.Clamp(this.TankTrans.position.z,-94,98));
        }
    }
}
