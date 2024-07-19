using UnityEngine;

public class Instructions : MonoBehaviour
{
    float time = 0f;
    bool fstinst = false;
    public GameObject Instructionpanel;

    void Update()
    {
        time = Time.deltaTime + time;
        if ((time > 1.5f) && (!fstinst))
        {
            Debug.Log("got in");
            Instructionpanel.SetActive(true);
            fstinst = true;
        }
        if ((Input.GetKey(KeyCode.Space)) && (fstinst))
        {
            Instructionpanel.SetActive(false);
            Debug.Log("entered");
        }
    }
}
