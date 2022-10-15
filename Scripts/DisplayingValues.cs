using UnityEngine;

public class DisplayingValues: MonoBehaviour
{
    public float _distance = 1f;
    public float _speed = 1f;
    public float _time = 1f;

    private void OnGUI()
    {
        int w = Screen.width, h = Screen.height;
        GUIStyle style = new GUIStyle();

        Rect rectSliderDist = new Rect(0, 0, w/4, h*2/100);
        Rect rectTextDist = new Rect(0, 5, w / 4, h * 2 / 100);
        Rect rectSliderSp = new Rect(400, 0, w / 4, h * 2 / 100);
        Rect rectTextSp = new Rect(400, 5, w / 4, h * 2 / 100);
        Rect rectSliderTime = new Rect(800, 0, w / 4, h * 2 / 100);
        Rect rectTextTime = new Rect(800, 5, w / 4, h * 2 / 100);

        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 5 / 100;
        style.normal.textColor = Color.black;

        string textDist = _distance.ToString("Distance = " + "0.00");
        _distance = GUI.HorizontalSlider(rectSliderDist, _distance, 1f, 10f);
        GUI.Label(rectTextDist, textDist, style);
        string textSp = _speed.ToString("Speed = " + "0.00");
        _speed = GUI.HorizontalSlider(rectSliderSp, _speed, 1f, 10f);
        GUI.Label(rectTextSp, textSp, style);
        string textTime = _time.ToString("Time = " + "0.00");
        _time = GUI.HorizontalSlider(rectSliderTime, _time, 1f, 10f);
        GUI.Label(rectTextTime, textTime, style);
    }
}
