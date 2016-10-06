using UnityEngine;
using System.Collections;

public class FadeTest : MonoBehaviour
{
    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.0f;


    private int   drawDepth = -1000;
    private float alpha     = 1.0f;
    private int   fadeDir   = -1;

    void OnGui() {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);  //?

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth; //para desenhar a tela de saída
        GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);
    }

    public float BeginFade (int direction){
        fadeDir = direction;
        return (fadeSpeed);
    }

    void OnlevelWasLoaded() {
        BeginFade(-1);

    }



}