using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Vast.Processor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.nexage.sourcekit.vast.processor']/interface[@name='VASTMediaPicker']"
	[Register ("org/nexage/sourcekit/vast/processor/VASTMediaPicker", "", "Org.Nexage.Sourcekit.Vast.Processor.IVASTMediaPickerInvoker")]
	public partial interface IVASTMediaPicker : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.processor']/interface[@name='VASTMediaPicker']/method[@name='pickVideo' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("pickVideo", "(Ljava/util/List;)Lorg/nexage/sourcekit/vast/model/VASTMediaFile;", "GetPickVideo_Ljava_util_List_Handler:Org.Nexage.Sourcekit.Vast.Processor.IVASTMediaPickerInvoker, AppodealXamarinPlugin")]
		global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile PickVideo (global::System.Collections.IList p0);

	}

	[global::Android.Runtime.Register ("org/nexage/sourcekit/vast/processor/VASTMediaPicker", DoNotGenerateAcw=true)]
	internal class IVASTMediaPickerInvoker : global::Java.Lang.Object, IVASTMediaPicker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/nexage/sourcekit/vast/processor/VASTMediaPicker");
		IntPtr class_ref;

		public static IVASTMediaPicker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVASTMediaPicker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.nexage.sourcekit.vast.processor.VASTMediaPicker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVASTMediaPickerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVASTMediaPickerInvoker); }
		}

		static Delegate cb_pickVideo_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetPickVideo_Ljava_util_List_Handler ()
		{
			if (cb_pickVideo_Ljava_util_List_ == null)
				cb_pickVideo_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PickVideo_Ljava_util_List_);
			return cb_pickVideo_Ljava_util_List_;
		}

		static IntPtr n_PickVideo_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Processor.IVASTMediaPicker __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Processor.IVASTMediaPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PickVideo (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_pickVideo_Ljava_util_List_;
		public unsafe global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile PickVideo (global::System.Collections.IList p0)
		{
			if (id_pickVideo_Ljava_util_List_ == IntPtr.Zero)
				id_pickVideo_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "pickVideo", "(Ljava/util/List;)Lorg/nexage/sourcekit/vast/model/VASTMediaFile;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __ret = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (JNIEnv.CallObjectMethod (Handle, id_pickVideo_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
