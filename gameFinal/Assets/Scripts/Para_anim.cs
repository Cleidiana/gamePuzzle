using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Para_anim : MonoBehaviour {

    VideoPlayer meuVideo;
	void Start () {
        meuVideo = GetComponent<VideoPlayer>();
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            meuVideo.Stop();
        }
    }
}

