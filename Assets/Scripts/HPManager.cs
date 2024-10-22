using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManager : MonoBehaviour
{
    public Text HPCountText;
    public static int totalHP;

    void Update(){
        HPCountText.text = totalHP.ToString();

    }

}