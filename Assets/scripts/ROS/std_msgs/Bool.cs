using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;

namespace ROS {
	namespace std_msgs {
		public class Bool : ROSBridgeMsg {
			private bool _data;
			
			public Bool(JSONNode msg) {
				_data = Convert.ToBoolean(msg["data"]);
			}
			
			public Bool(bool data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/Bool";
			}
			
			public bool GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "Bool [data=" + _data .ToString()+ "]";
			}
			
			public override string ToYAMLString() {
				return "{data : "+ _data.ToString() + "}";
			}
		}
	}
}