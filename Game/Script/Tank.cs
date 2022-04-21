using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {
    public int moveSpeed = 20;
    private int rotateSpeed = 80;
    public delegate void PlayerScore(int temp);
    public event PlayerScore GetScore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if(v!=0||h!=0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * v * moveSpeed, Space.Self);
            transform.Rotate(0, h * Time.deltaTime * rotateSpeed, 0, Space.Self);
        }
	}
   public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("jinbi"))
        {
           
                GetScore(1);
            
        } 
    }
}
 