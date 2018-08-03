using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;

namespace ROS {
		public class time : ROSBridgeMsg {
			private int _secs;
			private int _nsecs;
			
			public time(JSONNode msg) 
			{
				_secs = Convert.ToInt32(msg["secs"]);
				_nsecs = Convert.ToInt32(msg["nsecs"]);
			}
			
			public time(int secs, int nsecs)
			{
				_secs = secs;
				_nsecs = nsecs;
			}
			
			public static string GetMessageType() 
			{
				return "time";
			}
			
			public int GetSecs() 
			{
				return _secs;
			}

			public int GetNsecs() 
			{
				return _nsecs;
			}
			
			public override string ToString() 
			{
				return "time [secs=" + _secs .ToString()+ ",nsecs=" + _nsecs .ToString()+ "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{secs : "+ _secs.ToString() + ",nsecs : "+ _nsecs.ToString() + "}";
			}
		}
}