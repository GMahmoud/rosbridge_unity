using System.Collections;
using System.Text;
using SimpleJSON;
using UnityEngine;
using ROSBridge;

namespace ROS {
	namespace std_msgs {
		public class Float32 : ROSBridgeMsg {
			private float _data;
			
			public Float32(JSONNode msg) {
				_data = float.Parse(msg["data"]);
			}
			
			public Float32(float data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/Float32";
			}
			
			public float GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "Float32 [data=" + _data.ToString() + "]";
			}
			
			public override string ToYAMLString() {
				return "{data : " + _data.ToString() + "}";
			}
		}
	}
}