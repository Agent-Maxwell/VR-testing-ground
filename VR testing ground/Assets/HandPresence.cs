using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    public InputDeviceCharacteristics controllerCharacteristics;
    public GameObject handModelPrefab;

    private GameObject spawnedHandModel;
    private InputDevice targetDevice;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach (var item in devices)
        {

        }

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
            spawnedHandModel = Instantiate(handModelPrefab, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);

        if (primaryButtonValue)
        {

        }

        targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);

        if (triggerValue > 0.1)
        {

        }

        targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue);

        if (primary2DAxisValue != Vector2.zero)
        {

        }
    }
}
