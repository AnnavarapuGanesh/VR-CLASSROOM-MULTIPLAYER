using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private String input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(String s){
        input = s;
        Debug.Log(input);
    }


}
