using UnityEngine;
using System.Collections;

public class Skip_btn : MonoBehaviour {
    private GameObject UserInfo;

    void Start()
    {
        UserInfo = GameObject.Find("UserInfo");
    }

    void OnClick()
    {
        if (transform.gameObject.name == "skip_btn")
        {
            if (GameObject.Find("cg").gameObject)
            {
                Destroy(GameObject.Find("cg").gameObject);
                DontDestroyOnLoad(UserInfo);
                Application.LoadLevel("main");
            }
        }
    }
}
