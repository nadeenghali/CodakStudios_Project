using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioCanvas : MonoBehaviour {
    public Slider musicSlider;
    public static float music;
    public Slider speechSlider;
    public static float speech;
    public Slider effectsSlider;
    public static float effects;

    // Use this for initialization
    void Start () {
        music = musicSlider.value;
        speech = speechSlider.value;
        effects = effectsSlider.value;
    }

    // Update is called once per frame
    void Update () {
        music = musicSlider.value;
        speech = speechSlider.value;
        effects = effectsSlider.value;
    }
}
