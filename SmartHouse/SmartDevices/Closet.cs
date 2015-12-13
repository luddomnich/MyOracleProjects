using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
	class Closet : SmartObj, IOpenable, IHasLight 
	{
		 public Closet (string name) : base(name)
			 {

			 }


		 public bool IsOpen { get; set; }


		 public void Open()
		 {
			 IsOpen = true;
		 }
			
		 public void Close()
		 {
			IsOpen = false;
		 }

		 public bool IsLightOn
		 {
			 get;
			 set;

		 }
	}
}
