using UnityEngine;
using System.Collections;

public class CgCtrl : MonoBehaviour {
    float delay = 2f;
    string[] guilds = { "guild_1", "guild_2", "guild_3", "guild_4"};
    int index = 0;
    UISprite uis;
    //键值对儿的形式保存iTween所用到的参数
    Hashtable args = new Hashtable();

    private GameObject UserInfo;

	// Use this for initialization
	void Start () {
        uis = transform.GetComponent<UISprite>();
        uis.spriteName = guilds[index];
     
        //直线移动
        args.Add("easeType", iTween.EaseType.linear);

        //移动的整体时间
        args.Add("time", 3f);
        args.Add("y", 0.1f);

        //移动结束时调用，参数和上面类似
        args.Add("oncomplete", "MoveEnd");
        args.Add("oncompletetarget", gameObject);

        UserInfo = GameObject.Find("UserInfo");
	}
	
	// Update is called once per frame
	void Update () {
        delay -= Time.deltaTime;
        if (delay < 0)
        {
            if (index < 3)
            {
                index += 1;
                uis.spriteName = guilds[index];
                delay = 2f;
                if (index == 3)
                {
                    iTween.MoveTo(GameObject.Find("world"), args); 
                }              
            }

            if (delay < -10)
            {
                delay = -1;
            }
        }
        Debug.Log(uis.spriteName);
	}

    void MoveEnd()
    {
        Debug.Log("移动结束");
        if (GameObject.Find("cg").gameObject)
        {
            Destroy(GameObject.Find("cg").gameObject);
            DontDestroyOnLoad(UserInfo);
            Application.LoadLevel("main");
        }
    }
}
