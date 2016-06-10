using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Vast.Processor {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.vast.processor']/class[@name='VASTProcessor']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/vast/processor/VASTProcessor", DoNotGenerateAcw=true)]
	public sealed partial class VASTProcessor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/vast/processor/VASTProcessor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VASTProcessor); }
		}

		internal VASTProcessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_nexage_sourcekit_vast_processor_VASTMediaPicker_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.vast.processor']/class[@name='VASTProcessor']/constructor[@name='VASTProcessor' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.vast.processor.VASTMediaPicker']]"
		[Register (".ctor", "(Lorg/nexage/sourcekit/vast/processor/VASTMediaPicker;)V", "")]
		public unsafe VASTProcessor (global::Org.Nexage.Sourcekit.Vast.Processor.IVASTMediaPicker p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VASTProcessor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/nexage/sourcekit/vast/processor/VASTMediaPicker;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/nexage/sourcekit/vast/processor/VASTMediaPicker;)V", __args);
					return;
				}

				if (id_ctor_Lorg_nexage_sourcekit_vast_processor_VASTMediaPicker_ == IntPtr.Zero)
					id_ctor_Lorg_nexage_sourcekit_vast_processor_VASTMediaPicker_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/nexage/sourcekit/vast/processor/VASTMediaPicker;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_nexage_sourcekit_vast_processor_VASTMediaPicker_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_nexage_sourcekit_vast_processor_VASTMediaPicker_, __args);
			} finally {
			}
		}

		static IntPtr id_getModel;
		public unsafe global::Org.Nexage.Sourcekit.Vast.Model.VASTModel Model {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.processor']/class[@name='VASTProcessor']/method[@name='getModel' and count(parameter)=0]"
			[Register ("getModel", "()Lorg/nexage/sourcekit/vast/model/VASTModel;", "GetGetModelHandler")]
			get {
				if (id_getModel == IntPtr.Zero)
					id_getModel = JNIEnv.GetMethodID (class_ref, "getModel", "()Lorg/nexage/sourcekit/vast/model/VASTModel;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTModel> (JNIEnv.CallObjectMethod  (Handle, id_getModel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_process_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.processor']/class[@name='VASTProcessor']/method[@name='process' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("process", "(Ljava/lang/String;)I", "")]
		public unsafe int Process (string p0)
		{
			if (id_process_Ljava_lang_String_ == IntPtr.Zero)
				id_process_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "process", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_process_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
