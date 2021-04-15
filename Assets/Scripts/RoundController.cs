using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundController : MonoBehaviour
{
    float rotSpeed = 0;  //旋转速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*当鼠标按下时旋转，速度在5至10之间，随机数只包含下限，不包含上限*/
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = Random.Range(100f, 200f);
        }

        transform.Rotate(0, 0, this.rotSpeed);  //将旋转速度添加到对象

        this.rotSpeed *= 0.99f;  //给转速添加衰减系数
    }
}
