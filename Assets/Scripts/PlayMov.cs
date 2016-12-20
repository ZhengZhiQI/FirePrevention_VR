using UnityEngine;
using System.Collections;

public class PlayMov : MonoBehaviour
{

    //电影纹理
    public MovieTexture movTexture;
    public AudioSource audioSource;


    void Start()
    {
       


    }

    
    void OnGUI()
    {
        if (!movTexture.isPlaying)
        {
            movTexture.Play();
        }
        if(Input.GetKeyDown(KeyCode.A)){

                                        //设置当前对象的主纹理为电影纹理
            GetComponent<Renderer>().material.mainTexture = movTexture;
            //设置电影纹理播放模式为循环
            movTexture.loop = false;
            GetComponent<AudioSource>().Play();
        }
    }
}
