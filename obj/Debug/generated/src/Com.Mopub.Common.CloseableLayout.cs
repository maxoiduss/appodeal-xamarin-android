using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout']"
	[global::Android.Runtime.Register ("com/mopub/common/CloseableLayout", DoNotGenerateAcw=true)]
	public partial class CloseableLayout : global::Android.Widget.FrameLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.ClosePosition']"
		[global::Android.Runtime.Register ("com/mopub/common/CloseableLayout$ClosePosition", DoNotGenerateAcw=true)]
		public sealed partial class ClosePosition : global::Java.Lang.Enum {


			static IntPtr BOTTOM_CENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.ClosePosition']/field[@name='BOTTOM_CENTER']"
			[Register ("BOTTOM_CENTER")]
			public static global::Com.Mopub.Common.CloseableLayout.ClosePosition BottomCenter {
				get {
					if (BOTTOM_CENTER_jfieldId == IntPtr.Zero)
						BOTTOM_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_CENTER", "Lcom/mopub/common/CloseableLayout$ClosePosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOTTOM_CENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.ClosePosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BOTTOM_LEFT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.ClosePosition']/field[@name='BOTTOM_LEFT']"
			[Register ("BOTTOM_LEFT")]
			public static global::Com.Mopub.Common.CloseableLayout.ClosePosition BottomLeft {
				get {
					if (BOTTOM_LEFT_jfieldId == IntPtr.Zero)
						BOTTOM_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_LEFT", "Lcom/mopub/common/CloseableLayout$ClosePosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOTTOM_LEFT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.ClosePosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BOTTOM_RIGHT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.ClosePosition']/field[@name='BOTTOM_RIGHT']"
			[Register ("BOTTOM_RIGHT")]
			public static global::Com.Mopub.Common.CloseableLayout.ClosePosition BottomRight {
				get {
					if (BOTTOM_RIGHT_jfieldId == IntPtr.Zero)
						BOTTOM_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_RIGHT", "Lcom/mopub/common/CloseableLayout$ClosePosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOTTOM_RIGHT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.ClosePosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.ClosePosition']/field[@name='CENTER']"
			[Register ("CENTER")]
			public static global::Com.Mopub.Common.CloseableLayout.ClosePosition Center {
				get {
					if (CENTER_jfieldId == IntPtr.Zero)
						CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CENTER", "Lcom/mopub/common/CloseableLayout$ClosePosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.ClosePosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOP_CENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.ClosePosition']/field[@name='TOP_CENTER']"
			[Register ("TOP_CENTER")]
			public static global::Com.Mopub.Common.CloseableLayout.ClosePosition TopCenter {
				get {
					if (TOP_CENTER_jfieldId == IntPtr.Zero)
						TOP_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_CENTER", "Lcom/mopub/common/CloseableLayout$ClosePosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOP_CENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.ClosePosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOP_LEFT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.ClosePosition']/field[@name='TOP_LEFT']"
			[Register ("TOP_LEFT")]
			public static global::Com.Mopub.Common.CloseableLayout.ClosePosition TopLeft {
				get {
					if (TOP_LEFT_jfieldId == IntPtr.Zero)
						TOP_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_LEFT", "Lcom/mopub/common/CloseableLayout$ClosePosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOP_LEFT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.ClosePosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOP_RIGHT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.ClosePosition']/field[@name='TOP_RIGHT']"
			[Register ("TOP_RIGHT")]
			public static global::Com.Mopub.Common.CloseableLayout.ClosePosition TopRight {
				get {
					if (TOP_RIGHT_jfieldId == IntPtr.Zero)
						TOP_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_RIGHT", "Lcom/mopub/common/CloseableLayout$ClosePosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOP_RIGHT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.ClosePosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/CloseableLayout$ClosePosition", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ClosePosition); }
			}

			internal ClosePosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.ClosePosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/CloseableLayout$ClosePosition;", "")]
			public static unsafe global::Com.Mopub.Common.CloseableLayout.ClosePosition ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/CloseableLayout$ClosePosition;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.CloseableLayout.ClosePosition __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.ClosePosition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.ClosePosition']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/CloseableLayout$ClosePosition;", "")]
			public static unsafe global::Com.Mopub.Common.CloseableLayout.ClosePosition[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/CloseableLayout$ClosePosition;");
				try {
					return (global::Com.Mopub.Common.CloseableLayout.ClosePosition[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.CloseableLayout.ClosePosition));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.common']/interface[@name='CloseableLayout.OnCloseListener']"
		[Register ("com/mopub/common/CloseableLayout$OnCloseListener", "", "Com.Mopub.Common.CloseableLayout/IOnCloseListenerInvoker")]
		public partial interface IOnCloseListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='CloseableLayout.OnCloseListener']/method[@name='onClose' and count(parameter)=0]"
			[Register ("onClose", "()V", "GetOnCloseHandler:Com.Mopub.Common.CloseableLayout/IOnCloseListenerInvoker, AppodealXamarinPlugin")]
			void OnClose ();

		}

		[global::Android.Runtime.Register ("com/mopub/common/CloseableLayout$OnCloseListener", DoNotGenerateAcw=true)]
		internal class IOnCloseListenerInvoker : global::Java.Lang.Object, IOnCloseListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/common/CloseableLayout$OnCloseListener");
			IntPtr class_ref;

			public static IOnCloseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCloseListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.common.CloseableLayout.OnCloseListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCloseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnCloseListenerInvoker); }
			}

			static Delegate cb_onClose;
#pragma warning disable 0169
			static Delegate GetOnCloseHandler ()
			{
				if (cb_onClose == null)
					cb_onClose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClose);
				return cb_onClose;
			}

			static void n_OnClose (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.CloseableLayout.IOnCloseListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.IOnCloseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnClose ();
			}
#pragma warning restore 0169

			IntPtr id_onClose;
			public unsafe void OnClose ()
			{
				if (id_onClose == IntPtr.Zero)
					id_onClose = JNIEnv.GetMethodID (class_ref, "onClose", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onClose);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mopub/common/CloseableLayout_OnCloseListenerImplementor")]
		internal sealed partial class IOnCloseListenerImplementor : global::Java.Lang.Object, IOnCloseListener {

			object sender;

			public IOnCloseListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/common/CloseableLayout_OnCloseListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnClose ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnCloseListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.UnsetPressedState']"
		[global::Android.Runtime.Register ("com/mopub/common/CloseableLayout$UnsetPressedState", DoNotGenerateAcw=true)]
		public sealed partial class UnsetPressedState : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/CloseableLayout$UnsetPressedState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UnsetPressedState); }
			}

			internal UnsetPressedState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout.UnsetPressedState']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "")]
			public unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_run);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/CloseableLayout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloseableLayout); }
		}

		protected CloseableLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout']/constructor[@name='CloseableLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CloseableLayout (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CloseableLayout)) {
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

		static Delegate cb_isCloseVisible;
#pragma warning disable 0169
		static Delegate GetIsCloseVisibleHandler ()
		{
			if (cb_isCloseVisible == null)
				cb_isCloseVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCloseVisible);
			return cb_isCloseVisible;
		}

		static bool n_IsCloseVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.CloseableLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CloseVisible;
		}
#pragma warning restore 0169

		static Delegate cb_setCloseVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetCloseVisible_ZHandler ()
		{
			if (cb_setCloseVisible_Z == null)
				cb_setCloseVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCloseVisible_Z);
			return cb_setCloseVisible_Z;
		}

		static void n_SetCloseVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Common.CloseableLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseVisible = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCloseVisible;
		static IntPtr id_setCloseVisible_Z;
		public virtual unsafe bool CloseVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout']/method[@name='isCloseVisible' and count(parameter)=0]"
			[Register ("isCloseVisible", "()Z", "GetIsCloseVisibleHandler")]
			get {
				if (id_isCloseVisible == IntPtr.Zero)
					id_isCloseVisible = JNIEnv.GetMethodID (class_ref, "isCloseVisible", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCloseVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCloseVisible", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout']/method[@name='setCloseVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCloseVisible", "(Z)V", "GetSetCloseVisible_ZHandler")]
			set {
				if (id_setCloseVisible_Z == IntPtr.Zero)
					id_setCloseVisible_Z = JNIEnv.GetMethodID (class_ref, "setCloseVisible", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCloseVisible_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCloseVisible", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_applyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetApplyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_Handler ()
		{
			if (cb_applyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_ == null)
				cb_applyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ApplyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_);
			return cb_applyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_;
		}

		static void n_ApplyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Common.CloseableLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.CloseableLayout.ClosePosition p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.ClosePosition> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ApplyCloseRegionBounds (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_applyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout']/method[@name='applyCloseRegionBounds' and count(parameter)=3 and parameter[1][@type='com.mopub.common.CloseableLayout.ClosePosition'] and parameter[2][@type='android.graphics.Rect'] and parameter[3][@type='android.graphics.Rect']]"
		[Register ("applyCloseRegionBounds", "(Lcom/mopub/common/CloseableLayout$ClosePosition;Landroid/graphics/Rect;Landroid/graphics/Rect;)V", "GetApplyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_Handler")]
		public virtual unsafe void ApplyCloseRegionBounds (global::Com.Mopub.Common.CloseableLayout.ClosePosition p0, global::Android.Graphics.Rect p1, global::Android.Graphics.Rect p2)
		{
			if (id_applyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_applyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "applyCloseRegionBounds", "(Lcom/mopub/common/CloseableLayout$ClosePosition;Landroid/graphics/Rect;Landroid/graphics/Rect;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_applyCloseRegionBounds_Lcom_mopub_common_CloseableLayout_ClosePosition_Landroid_graphics_Rect_Landroid_graphics_Rect_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyCloseRegionBounds", "(Lcom/mopub/common/CloseableLayout$ClosePosition;Landroid/graphics/Rect;Landroid/graphics/Rect;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_;
#pragma warning disable 0169
		static Delegate GetSetClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_Handler ()
		{
			if (cb_setClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_ == null)
				cb_setClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_);
			return cb_setClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_;
		}

		static void n_SetClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.CloseableLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.CloseableLayout.ClosePosition p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.ClosePosition> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClosePosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout']/method[@name='setClosePosition' and count(parameter)=1 and parameter[1][@type='com.mopub.common.CloseableLayout.ClosePosition']]"
		[Register ("setClosePosition", "(Lcom/mopub/common/CloseableLayout$ClosePosition;)V", "GetSetClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_Handler")]
		public virtual unsafe void SetClosePosition (global::Com.Mopub.Common.CloseableLayout.ClosePosition p0)
		{
			if (id_setClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_ == IntPtr.Zero)
				id_setClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_ = JNIEnv.GetMethodID (class_ref, "setClosePosition", "(Lcom/mopub/common/CloseableLayout$ClosePosition;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setClosePosition_Lcom_mopub_common_CloseableLayout_ClosePosition_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClosePosition", "(Lcom/mopub/common/CloseableLayout$ClosePosition;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_Handler ()
		{
			if (cb_setOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_ == null)
				cb_setOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_);
			return cb_setOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_;
		}

		static void n_SetOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.CloseableLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.CloseableLayout.IOnCloseListener p0 = (global::Com.Mopub.Common.CloseableLayout.IOnCloseListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.IOnCloseListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCloseListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CloseableLayout']/method[@name='setOnCloseListener' and count(parameter)=1 and parameter[1][@type='com.mopub.common.CloseableLayout.OnCloseListener']]"
		[Register ("setOnCloseListener", "(Lcom/mopub/common/CloseableLayout$OnCloseListener;)V", "GetSetOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_Handler")]
		public virtual unsafe void SetOnCloseListener (global::Com.Mopub.Common.CloseableLayout.IOnCloseListener p0)
		{
			if (id_setOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_ == IntPtr.Zero)
				id_setOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_ = JNIEnv.GetMethodID (class_ref, "setOnCloseListener", "(Lcom/mopub/common/CloseableLayout$OnCloseListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnCloseListener_Lcom_mopub_common_CloseableLayout_OnCloseListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCloseListener", "(Lcom/mopub/common/CloseableLayout$OnCloseListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mopub.Common.CloseableLayout.IOnCloseListener"
		public event EventHandler Close {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Common.CloseableLayout.IOnCloseListener, global::Com.Mopub.Common.CloseableLayout.IOnCloseListenerImplementor>(
						ref weak_implementor_SetOnCloseListener,
						__CreateIOnCloseListenerImplementor,
						SetOnCloseListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Common.CloseableLayout.IOnCloseListener, global::Com.Mopub.Common.CloseableLayout.IOnCloseListenerImplementor>(
						ref weak_implementor_SetOnCloseListener,
						global::Com.Mopub.Common.CloseableLayout.IOnCloseListenerImplementor.__IsEmpty,
						__v => SetOnCloseListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCloseListener;

		global::Com.Mopub.Common.CloseableLayout.IOnCloseListenerImplementor __CreateIOnCloseListenerImplementor ()
		{
			return new global::Com.Mopub.Common.CloseableLayout.IOnCloseListenerImplementor (this);
		}
#endregion
	}
}
