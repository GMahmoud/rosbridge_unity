using System.Collections;
using System.Text;
using SimpleJSON;
using UnityEngine;
using ROSBridge;
using System;

namespace ROS 
{
	namespace std_msgs 
	{
		public class Header : ROSBridgeMsg 
		{
			private int _seq;
			private time _stamp;
			private string _frame_id;
			
			public Header(JSONNode msg) 
			{
				_seq = Convert.ToInt32(msg["seq"]);
				_stamp = new time(msg["stamp"]);
				_frame_id = msg["frame_id"];
			}
			
			public Header(int seq, time stamp, string frame_id) 
			{
				_seq = seq;
				_stamp = stamp;
				_frame_id = frame_id;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/Header";
			}
			
			public int GetSeq()
			{
				return _seq;
			}
			
			public time GetStamp() 
			{
				return _stamp;
			}

			public string GetFrameId() 
			{
				return _frame_id;
			}
			
			public override string ToString() 
			{
				return "Header [seq=" + _seq.ToString() + ",stamp=" + _stamp.ToString() + ",frame_id=" + _frame_id + "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{seq: " + _seq.ToString() + ",stamp: " + _stamp.ToYAMLString() + ",frame_id: " + _frame_id + "}";
			}
		}
	}
}