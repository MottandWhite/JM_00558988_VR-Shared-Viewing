using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanoramaCapture : MonoBehaviour
{
    public Camera TargetCamera;
    public RenderTexture CubeMapLeft;
    public RenderTexture equirectRT;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Capture();
        }
    }
    void Capture()
    {
        TargetCamera.RenderToCubemap(CubeMapLeft);
        CubeMapLeft.ConvertToEquirect(equirectRT);
    }
    public void Save(RenderTexture rt)
    {
        Texture2D tex = new Texture2D(rt.width, rt.height);

        RenderTexture.active = rt;
        tex.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
        RenderTexture.active = null;

        byte[] bytes = tex.EncodeToJPG();

        string path = Application.dataPath + "/Panorama" + ".jpg";

        System.IO.File.WriteAllBytes(path, bytes);
    }
}
