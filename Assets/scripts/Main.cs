using UnityEngine;
using ROSBridge;

public class Main : MonoBehaviour {
  private ROSBridgeConnection ros = null;
    
  void Start() {
   
    ros = new ROSBridgeConnection ("ws://192.168.1.90", 9090);

    ros.AddSubscriber (typeof(Subscriber));
    //ros.AddPublisher (typeof(Publisher));

    ros.Connect ();
  }
  
  
  void OnApplicationQuit() {
    if(ros!=null) {
      ros.Disconnect ();
    }
  }

  void Update () {
    ros.Render ();
  }
}
