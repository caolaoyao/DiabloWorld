using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {
    private UIInput userName;
    private UIInput userPassword;
    private GameObject UserInfo;

    void Start()
    {
        userName = GameObject.Find("userName").GetComponent<UIInput>();
        userPassword = GameObject.Find("passWord").GetComponent<UIInput>();
        UserInfo = GameObject.Find("UserInfo");
    }

    void OnClick()
    {
        if (userName.value == "")
        {
            userName.value = "用户名不能为空";
            return;
        }
        if (userName.value != "")
        {
            UserInfo.GetComponent<PlayerManger>().userName = userName.value;
            DontDestroyOnLoad(UserInfo);
            Application.LoadLevel("cg");
            Debug.Log("可登录:" + userName.value);
        }       
    }
}
