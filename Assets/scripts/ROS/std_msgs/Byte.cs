using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;

namespace ROS {
	namespace std_msgs {
		public class Byte : ROSBridgeMsg {
			private byte _data;
			
			public Byte(JSONNode msg) {
				_data = Convert.ToByte(msg["data"]);
			}
			
			public Byte(byte data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/Byte";
			}
			
			public byte GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "Bool [data=" + _data .ToString()+ "]";
			}
			
			public override string ToYAMLString() {
				return "{\"data\" : "+ _data.ToString() + "}";
			}
		}
	}
}