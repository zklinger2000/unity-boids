using UnityEngine;

public class GoalObject : MonoBehaviour {
    public float RotationSpeed = 180.0f;

    // Update is called once per frame
    private void Update () {
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * RotationSpeed);
    }
}
