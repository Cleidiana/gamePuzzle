using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Para_video : MonoBehaviour {
    public GameObject menuCanvas;
    VideoPlayer meuVideo;
	void Start () {
        menuCanvas.SetActive(false);
        meuVideo = GetComponent<VideoPlayer>();
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            meuVideo.Stop();
            menuCanvas.SetActive(true);
        }
    }
}

