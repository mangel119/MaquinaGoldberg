using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject fw;

    void OnCollisionEnter(Collision other) {
       if(other.gameObject.tag=="Player"){
           fw.SetActive(true);
       } 
    }
}
