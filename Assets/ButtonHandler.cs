using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public IK_modified ikController;     // Reference to the IKController script
    private bool temp;

    public void StartRecording()
    {
        if (ikController != null)
        {
            temp = ikController.isRecording;
            Debug.Log(temp);
            ikController.isRecording = !temp;
            //if (temp)
            //{
            //    ikController.recordedJointStates.Clear(); // Clear previous recording data
            //}
            Debug.Log(ikController.isRecording);
        }
    }

    public void StartPlaying()
    {
        if (ikController != null)
        {
            ikController.isPlaying = true;
            Debug.Log("Playing started.");
        }
    }
}
