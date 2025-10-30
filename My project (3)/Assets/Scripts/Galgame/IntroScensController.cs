using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;
using Unity.VisualScripting;

[RenamedFrom("IntroScensCo")]
public class IntroScensController : MonoBehaviour
{
    FlowerSystem fs;
    void Start()
    {
        fs = FlowerManager.Instance.CreateFlowerSystem("default",false);
        fs.SetupDialog();
        fs.ReadTextFromResource("intro");
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            fs.Next();
        }
    }
}
