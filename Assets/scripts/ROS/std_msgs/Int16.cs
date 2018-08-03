using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;

namespace ROS {
	namespace std_msgs {
		public class Int16 : ROSBridgeMsg {
			private short _data;
			
			public Int16(JSONNode msg) {
				_data = Convert.ToInt16(msg["data"]);
			}
			
			public Int16(byte data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/Int16";
			}
			
			public short GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "Int16 [data=" + _data .ToString()+ "]";
			}
			
			public override string ToYAMLString() {
				return "{data : "+ _data.ToString() + "}";
			}
		}
	}
}