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
	[MonoTouch.Foundation.Register("CustomCheckmarkGestureRecognizer_iPhone")]
	public partial class CustomCheckmarkGestureRecognizer_iPhone {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIImageView __mt_imgCheckmark;
		
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
		
		[MonoTouch.Foundation.Connect("imgCheckmark")]
		private MonoTouch.UIKit.UIImageView imgCheckmark {
			get {
				this.__mt_imgCheckmark = ((MonoTouch.UIKit.UIImageView)(this.GetNativeField("imgCheckmark")));
				return this.__mt_imgCheckmark;
			}
			set {
				this.__mt_imgCheckmark = value;
				this.SetNativeField("imgCheckmark", value);
			}
		}
	}
}
