using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;

namespace ROS {
	namespace std_msgs {
		public class String : ROSBridgeMsg {
			private string _data;
			
			public String(JSONNode msg) {
				_data = msg["data"];
			}
			
			public String(string data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/String";
			}
			
			public string GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "String [data=" + _data + "]";
			}
			
			public override string ToYAMLString() {
				return "{data : \"" + _data + "\"}";
			}
		}
	}
}