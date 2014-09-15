using UnityEngine;
using System.Collections;

public class guild_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        animation.CrossFade("cg");
	}
	
	// Update is called once per frame
	void Update () {
        if (!animation.IsPlaying("cg"))
        {
            Destroy(transform.gameObject);
        }
	}
}
