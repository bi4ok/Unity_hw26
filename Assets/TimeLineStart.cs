using UnityEngine;
using UnityEngine.Playables;

public class TimeLineStart : MonoBehaviour
{
    private PlayableDirector _timeLine;

    private void Start()
    {
        _timeLine = GetComponent<PlayableDirector>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _timeLine.Play();
        }
    }
}
