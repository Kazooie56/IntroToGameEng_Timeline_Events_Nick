using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.TextCore.Text;

public class TriggerTimeline : MonoBehaviour
{
    public PlayableDirector timeline;

void OnTriggerEnter(Collider other)
    {
        timeline.Play();
        Destroy(this.gameObject);
    }
}


