using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;

namespace ROS {
	namespace std_msgs {
		public class Int32 : ROSBridgeMsg {
			private int _data;
			
			public Int32(JSONNode msg) {
				_data = Convert.ToInt32(msg["data"]);
			}
			
			public Int32(byte data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/Int32";
			}
			
			public int GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "Int32 [data=" + _data .ToString()+ "]";
			}
			
			public override string ToYAMLString() {
				return "{\"data\" : "+ _data.ToString() + "}";
			}
		}
	}
}