using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingControler : MonoBehaviour
{

    //run 10 steps and jump a box
    public float StepOffset;
    public float StepDuration;
    public float numberOfCyclesAtStart; //must be a whole number
    public GameObject YellowBox;
    public Animator CharactorAnimator;
    public AnimationClip FastRun;
    public float MainTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //get the loop duration
        //StepDuration = CharactorAnimator.GetCurrentAnimatorClipInfo(0).fr;
        float loopDuration = FastRun.averageDuration;
        StepOffset = FastRun.events[0].time;
        StepDuration = loopDuration * 0.5f;
        
        // We have correct!!! step offset and duration. 

        // calculate the time of the 11th step

        // add variable for box speed

        // calculate box position and let's go!


    }

    // Update is called once per frame
    void Update()
    {
        //StepOffset = FastRun.events[0].time;
    }
}
