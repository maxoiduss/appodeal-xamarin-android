using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Vast.Processor {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.vast.processor']/class[@name='VASTModelPostValidator']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/vast/processor/VASTModelPostValidator", DoNotGenerateAcw=true)]
	public partial class VASTModelPostValidator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/vast/processor/VASTModelPostValidator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VASTModelPostValidator); }
		}

		protected VASTModelPostValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.vast.processor']/class[@name='VASTModelPostValidator']/constructor[@name='VASTModelPostValidator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VASTModelPostValidator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VASTModelPostValidator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_validate_Lorg_nexage_sourcekit_vast_model_VASTModel_Lorg_nexage_sourcekit_vast_processor_VASTMediaPicker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.processor']/class[@name='VASTModelPostValidator']/method[@name='validate' and count(parameter)=2 and parameter[1][@type='org.nexage.sourcekit.vast.model.VASTModel'] and parameter[2][@type='org.nexage.sourcekit.vast.processor.VASTMediaPicker']]"
		[Register ("validate", "(Lorg/nexage/sourcekit/vast/model/VASTModel;Lorg/nexage/sourcekit/vast/processor/VASTMediaPicker;)Z", "")]
		public static unsafe bool Validate (global::Org.Nexage.Sourcekit.Vast.Model.VASTModel p0, global::Org.Nexage.Sourcekit.Vast.Processor.IVASTMediaPicker p1)
		{
			if (id_validate_Lorg_nexage_sourcekit_vast_model_VASTModel_Lorg_nexage_sourcekit_vast_processor_VASTMediaPicker_ == IntPtr.Zero)
				id_validate_Lorg_nexage_sourcekit_vast_model_VASTModel_Lorg_nexage_sourcekit_vast_processor_VASTMediaPicker_ = JNIEnv.GetStaticMethodID (class_ref, "validate", "(Lorg/nexage/sourcekit/vast/model/VASTModel;Lorg/nexage/sourcekit/vast/processor/VASTMediaPicker;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_validate_Lorg_nexage_sourcekit_vast_model_VASTModel_Lorg_nexage_sourcekit_vast_processor_VASTMediaPicker_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
