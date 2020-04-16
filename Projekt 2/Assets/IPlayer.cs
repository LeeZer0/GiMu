using UnityEngine;

public interface IPlayer
{

    Camera Cam { get; set; }
    float HealthValue { get; set; }
    bool IsRunning { get; set; }

}