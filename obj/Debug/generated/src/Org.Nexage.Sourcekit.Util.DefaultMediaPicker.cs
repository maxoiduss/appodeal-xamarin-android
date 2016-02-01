using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='DefaultMediaPicker']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/util/DefaultMediaPicker", DoNotGenerateAcw=true)]
	public partial class DefaultMediaPicker : global::Java.Lang.Object, global::Org.Nexage.Sourcekit.Vast.Processor.IVASTMediaPicker {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='DefaultMediaPicker.AreaComparator']"
		[global::Android.Runtime.Register ("org/nexage/sourcekit/util/DefaultMediaPicker$AreaComparator", DoNotGenerateAcw=true)]
		public partial class AreaComparator : global::Java.Lang.Object, global::Java.Util.IComparator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/nexage/sourcekit/util/DefaultMediaPicker$AreaComparator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AreaComparator); }
			}

			protected AreaComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler ()
			{
				if (cb_compare_Ljava_lang_Object_Ljava_lang_Object_ == null)
					cb_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Ljava_lang_Object_Ljava_lang_Object_);
				return cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
			}

			static int n_Compare_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Nexage.Sourcekit.Util.DefaultMediaPicker.AreaComparator __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Util.DefaultMediaPicker.AreaComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Compare (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='DefaultMediaPicker.AreaComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
			[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler")]
			public virtual unsafe int Compare (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				if (id_compare_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod  (Handle, id_compare_Ljava_lang_Object_Ljava_lang_Object_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_compare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_;
#pragma warning disable 0169
			static Delegate GetCompare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Handler ()
			{
				if (cb_compare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_ == null)
					cb_compare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_);
				return cb_compare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_;
			}

			static int n_Compare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Nexage.Sourcekit.Util.DefaultMediaPicker.AreaComparator __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Util.DefaultMediaPicker.AreaComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile p1 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Compare (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='DefaultMediaPicker.AreaComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='org.nexage.sourcekit.vast.model.VASTMediaFile'] and parameter[2][@type='org.nexage.sourcekit.vast.model.VASTMediaFile']]"
			[Register ("compare", "(Lorg/nexage/sourcekit/vast/model/VASTMediaFile;Lorg/nexage/sourcekit/vast/model/VASTMediaFile;)I", "GetCompare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Handler")]
			public virtual unsafe int Compare (global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile p0, global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile p1)
			{
				if (id_compare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_ == IntPtr.Zero)
					id_compare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_ = JNIEnv.GetMethodID (class_ref, "compare", "(Lorg/nexage/sourcekit/vast/model/VASTMediaFile;Lorg/nexage/sourcekit/vast/model/VASTMediaFile;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod  (Handle, id_compare_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_Lorg_nexage_sourcekit_vast_model_VASTMediaFile_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compare", "(Lorg/nexage/sourcekit/vast/model/VASTMediaFile;Lorg/nexage/sourcekit/vast/model/VASTMediaFile;)I"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/util/DefaultMediaPicker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultMediaPicker); }
		}

		protected DefaultMediaPicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='DefaultMediaPicker']/constructor[@name='DefaultMediaPicker' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DefaultMediaPicker (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DefaultMediaPicker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='DefaultMediaPicker']/constructor[@name='DefaultMediaPicker' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe DefaultMediaPicker (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DefaultMediaPicker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
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
			global::Org.Nexage.Sourcekit.Util.DefaultMediaPicker __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Util.DefaultMediaPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PickVideo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_pickVideo_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='DefaultMediaPicker']/method[@name='pickVideo' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("pickVideo", "(Ljava/util/List;)Lorg/nexage/sourcekit/vast/model/VASTMediaFile;", "GetPickVideo_Ljava_util_List_Handler")]
		public virtual unsafe global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile PickVideo (global::System.Collections.IList p0)
		{
			if (id_pickVideo_Ljava_util_List_ == IntPtr.Zero)
				id_pickVideo_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "pickVideo", "(Ljava/util/List;)Lorg/nexage/sourcekit/vast/model/VASTMediaFile;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (JNIEnv.CallObjectMethod  (Handle, id_pickVideo_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pickVideo", "(Ljava/util/List;)Lorg/nexage/sourcekit/vast/model/VASTMediaFile;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
