using System.Collections;
using SimpleJSON;


namespace ROSBridge {
	public class ROSBridgeSubscriber<T> where T: ROSBridgeMsg {

		public static string GetMessageTopic() {
			return null;
		}  

		public static string GetMessageType() {
			return null;
		}

		public static T ParseMessage(JSONNode msg) {
			return null;
		}

		public static void CallBack(T msg) {
		}
	}
}

