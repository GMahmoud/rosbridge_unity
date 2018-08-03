using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ROS {
	namespace std_msgs {
		public class Int32MultiArray : ROSBridgeMsg {
			private MultiArrayLayout _layout;
			private List<int> _data;
			
			public Int32MultiArray(JSONNode msg) 
			{
				JSONArray data = (JSONArray) msg["data"];
				List<int> list = new List<int> ();
				for(int i=0; i<data.Count; i++)
				{ 
					list.Add(Convert.ToInt32(data[i]));
				}
				_data = list;
				_layout = new MultiArrayLayout(msg["layout"]);
			}
			
			public Int32MultiArray(MultiArrayLayout layout, List<int> data)
			{
			 	_layout = layout;
				_data = data;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/Int32MultiArray";
			}
			
			public MultiArrayLayout GetLayout() 
			{
				return _layout;
			}

			public List<int> GetData() 
			{
				return _data;
			}
			
			public override string ToString() 
			{
				string str;
                str="[";
				for(int i=0; i<_data.Count; i++)
				{ 
					str = str + _data[i].ToString();
					if(i != _data.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";

				return "Int32MultiArray [layout=" + _layout.ToString() + ",data=" + str + "]";
			}
			
			public override string ToYAMLString() 
			{
				string str;
                str="[";
				for(int i=0; i<_data.Count; i++)
				{ 
					str = str + _data[i].ToString();
					if(i != _data.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";
				
				return "{layout : " + _layout.ToYAMLString() + ",data : " +str + "}";
			}
		}
	}
}