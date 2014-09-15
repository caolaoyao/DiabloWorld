using UnityEngine;
using System.Collections;

public class ErrorBtn : MonoBehaviour {
    void OnClick()
    {
        Destroy(transform.parent.gameObject);
        
    }
}


