using UnityEngine;
using System.Collections;

public class MainBtn : MonoBehaviour {
    GameObject prototype;
    void OnClick()
    {
        Debug.Log(transform.gameObject.name);
        switch (transform.gameObject.name)
        {
            case "Synthesis": //合成
                prototype = Resources.LoadAssetAtPath<GameObject>("Assets/Prefabs/synthesis.prefab");
                if (GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate != null)
                {
                    Destroy(GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate);
                }
                GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate = Instantiate(prototype, transform.position, Quaternion.identity) as GameObject;
                break;

            case "Index": //首页
                if (GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate != null)
                {
                    Destroy(GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate);
                }
                break;

            case "Friend": //好友 
                prototype = Resources.LoadAssetAtPath<GameObject>("Assets/Prefabs/error.prefab");
                if (GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate != null)
                {
                    Destroy(GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate);
                }
                GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate = Instantiate(prototype, transform.position, Quaternion.identity) as GameObject;
                break;

            case "Competitive": //竞技场
                prototype = Resources.LoadAssetAtPath<GameObject>("Assets/Prefabs/arena.prefab");
                if (GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate != null)
                {
                    Destroy(GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate);
                }
                GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate = Instantiate(prototype, transform.position, Quaternion.identity) as GameObject;
                break;

            case "Msg": //信息 
                prototype = Resources.LoadAssetAtPath<GameObject>("Assets/Prefabs/error.prefab");
                if (GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate != null)
                {
                    Destroy(GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate);
                }
                GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate = Instantiate(prototype, transform.position, Quaternion.identity) as GameObject;
                break;

            case "Recharge": //充值 
                prototype = Resources.LoadAssetAtPath<GameObject>("Assets/Prefabs/error.prefab");
                if (GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate != null)
                {
                    Destroy(GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate);
                }
                GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate = Instantiate(prototype, transform.position, Quaternion.identity) as GameObject;
                break;

            case "Personinfo": //个人信息
                prototype = Resources.LoadAssetAtPath<GameObject>("Assets/Prefabs/personinfo.prefab");
                if (GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate != null)
                {
                    Destroy(GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate);
                }
                GameObject.Find("UI Root").GetComponent<GameCtl>().gameInstantiate = Instantiate(prototype, transform.position, Quaternion.identity) as GameObject;
                break;
        }
    }
}
