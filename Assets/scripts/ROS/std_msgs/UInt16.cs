using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;

namespace ROS {
	namespace std_msgs {
		public class UInt16 : ROSBridgeMsg {
			private ushort _data;
			
			public UInt16(JSONNode msg) {
				_data = Convert.ToUInt16(msg["data"]);
			}
			
			public UInt16(byte data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/UInt16";
			}
			
			public ushort GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "UInt16 [data=" + _data .ToString()+ "]";
			}
			
			public override string ToYAMLString() {
				return "{data : "+ _data.ToString() + "}";
			}
		}
	}
}