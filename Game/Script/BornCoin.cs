using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BornCoin : MonoBehaviour {
    public GameObject Jinbi;//定义一个金币
   
	// Use this for initialization
	void Start () {
		 for(int i=1;i<=10;i++){
        Born();
}
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.I))//每按下一次按键生成一个金币
        {
            Born();
        }
	}
    void Born()//自动生成金币
    {
        float x = Random.Range(-107f, 92f);//x轴边界坐标
        float z = Random.Range(-114f, 87f);//y轴边界坐标
        GameObject.Instantiate(Jinbi, new Vector3(x, 4, z), Jinbi.transform.rotation);//生成金币的范围
    }
}
