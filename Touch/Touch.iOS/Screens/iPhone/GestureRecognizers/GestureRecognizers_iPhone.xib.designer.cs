// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_Touch.Screens.iPhone.GestureRecognizers {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("GestureRecognizers_iPhone")]
	public partial class GestureRecognizers_iPhone {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIImageView __mt_imgDragMe;
		
		private MonoTouch.UIKit.UIImageView __mt_imgTapMe;
		
		private MonoTouch.UIKit.UILabel __mt_lblGestureStatus;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("imgDragMe")]
		private MonoTouch.UIKit.UIImageView imgDragMe {
			get {
				this.__mt_imgDragMe = ((MonoTouch.UIKit.UIImageView)(this.GetNativeField("imgDragMe")));
				return this.__mt_imgDragMe;
			}
			set {
				this.__mt_imgDragMe = value;
				this.SetNativeField("imgDragMe", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("imgTapMe")]
		private MonoTouch.UIKit.UIImageView imgTapMe {
			get {
				this.__mt_imgTapMe = ((MonoTouch.UIKit.UIImageView)(this.GetNativeField("imgTapMe")));
				return this.__mt_imgTapMe;
			}
			set {
				this.__mt_imgTapMe = value;
				this.SetNativeField("imgTapMe", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblGestureStatus")]
		private MonoTouch.UIKit.UILabel lblGestureStatus {
			get {
				this.__mt_lblGestureStatus = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblGestureStatus")));
				return this.__mt_lblGestureStatus;
			}
			set {
				this.__mt_lblGestureStatus = value;
				this.SetNativeField("lblGestureStatus", value);
			}
		}
	}
}
