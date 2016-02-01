using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mraid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler']"
	[global::Android.Runtime.Register ("com/mopub/mraid/MraidNativeCommandHandler", DoNotGenerateAcw=true)]
	public partial class MraidNativeCommandHandler : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler']/field[@name='ANDROID_CALENDAR_CONTENT_TYPE']"
		[Register ("ANDROID_CALENDAR_CONTENT_TYPE")]
		public const string AndroidCalendarContentType = (string) "vnd.android.cursor.item/event";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler.DownloadImageAsyncTask']"
		[global::Android.Runtime.Register ("com/mopub/mraid/MraidNativeCommandHandler$DownloadImageAsyncTask", DoNotGenerateAcw=true)]
		public partial class DownloadImageAsyncTask : global::Android.OS.AsyncTask {

			// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidNativeCommandHandler.DownloadImageAsyncTask.DownloadImageAsyncTaskListener']"
			[Register ("com/mopub/mraid/MraidNativeCommandHandler$DownloadImageAsyncTask$DownloadImageAsyncTaskListener", "", "Com.Mopub.Mraid.MraidNativeCommandHandler/DownloadImageAsyncTask/IDownloadImageAsyncTaskListenerInvoker")]
			public partial interface IDownloadImageAsyncTaskListener : IJavaObject {

				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidNativeCommandHandler.DownloadImageAsyncTask.DownloadImageAsyncTaskListener']/method[@name='onFailure' and count(parameter)=0]"
				[Register ("onFailure", "()V", "GetOnFailureHandler:Com.Mopub.Mraid.MraidNativeCommandHandler/DownloadImageAsyncTask/IDownloadImageAsyncTaskListenerInvoker, AppodealXamarinPlugin")]
				void OnFailure ();

				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidNativeCommandHandler.DownloadImageAsyncTask.DownloadImageAsyncTaskListener']/method[@name='onSuccess' and count(parameter)=0]"
				[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Mopub.Mraid.MraidNativeCommandHandler/DownloadImageAsyncTask/IDownloadImageAsyncTaskListenerInvoker, AppodealXamarinPlugin")]
				void OnSuccess ();

			}

			[global::Android.Runtime.Register ("com/mopub/mraid/MraidNativeCommandHandler$DownloadImageAsyncTask$DownloadImageAsyncTaskListener", DoNotGenerateAcw=true)]
			internal class IDownloadImageAsyncTaskListenerInvoker : global::Java.Lang.Object, IDownloadImageAsyncTaskListener {

				static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mraid/MraidNativeCommandHandler$DownloadImageAsyncTask$DownloadImageAsyncTaskListener");
				IntPtr class_ref;

				public static IDownloadImageAsyncTaskListener GetObject (IntPtr handle, JniHandleOwnership transfer)
				{
					return global::Java.Lang.Object.GetObject<IDownloadImageAsyncTaskListener> (handle, transfer);
				}

				static IntPtr Validate (IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
						throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
									JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mraid.MraidNativeCommandHandler.DownloadImageAsyncTask.DownloadImageAsyncTaskListener"));
					return handle;
				}

				protected override void Dispose (bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
						JNIEnv.DeleteGlobalRef (this.class_ref);
					this.class_ref = IntPtr.Zero;
					base.Dispose (disposing);
				}

				public IDownloadImageAsyncTaskListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
				{
					IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
					this.class_ref = JNIEnv.NewGlobalRef (local_ref);
					JNIEnv.DeleteLocalRef (local_ref);
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (IDownloadImageAsyncTaskListenerInvoker); }
				}

				static Delegate cb_onFailure;
#pragma warning disable 0169
				static Delegate GetOnFailureHandler ()
				{
					if (cb_onFailure == null)
						cb_onFailure = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFailure);
					return cb_onFailure;
				}

				static void n_OnFailure (IntPtr jnienv, IntPtr native__this)
				{
					global::Com.Mopub.Mraid.MraidNativeCommandHandler.DownloadImageAsyncTask.IDownloadImageAsyncTaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidNativeCommandHandler.DownloadImageAsyncTask.IDownloadImageAsyncTaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					__this.OnFailure ();
				}
#pragma warning restore 0169

				IntPtr id_onFailure;
				public unsafe void OnFailure ()
				{
					if (id_onFailure == IntPtr.Zero)
						id_onFailure = JNIEnv.GetMethodID (class_ref, "onFailure", "()V");
					JNIEnv.CallVoidMethod (Handle, id_onFailure);
				}

				static Delegate cb_onSuccess;
#pragma warning disable 0169
				static Delegate GetOnSuccessHandler ()
				{
					if (cb_onSuccess == null)
						cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
					return cb_onSuccess;
				}

				static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
				{
					global::Com.Mopub.Mraid.MraidNativeCommandHandler.DownloadImageAsyncTask.IDownloadImageAsyncTaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidNativeCommandHandler.DownloadImageAsyncTask.IDownloadImageAsyncTaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					__this.OnSuccess ();
				}
#pragma warning restore 0169

				IntPtr id_onSuccess;
				public unsafe void OnSuccess ()
				{
					if (id_onSuccess == IntPtr.Zero)
						id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
					JNIEnv.CallVoidMethod (Handle, id_onSuccess);
				}

			}

			[global::Android.Runtime.Register ("mono/com/mopub/mraid/MraidNativeCommandHandler_DownloadImageAsyncTask_DownloadImageAsyncTaskListenerImplementor")]
			internal sealed partial class IDownloadImageAsyncTaskListenerImplementor : global::Java.Lang.Object, IDownloadImageAsyncTaskListener {

				object sender;

				public IDownloadImageAsyncTaskListenerImplementor (object sender)
					: base (
						global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mraid/MraidNativeCommandHandler_DownloadImageAsyncTask_DownloadImageAsyncTaskListenerImplementor", "()V"),
						JniHandleOwnership.TransferLocalRef)
				{
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					this.sender = sender;
				}

#pragma warning disable 0649
				public EventHandler OnFailureHandler;
#pragma warning restore 0649

				public void OnFailure ()
				{
					var __h = OnFailureHandler;
					if (__h != null)
						__h (sender, new EventArgs ());
				}
#pragma warning disable 0649
				public EventHandler OnSuccessHandler;
#pragma warning restore 0649

				public void OnSuccess ()
				{
					var __h = OnSuccessHandler;
					if (__h != null)
						__h (sender, new EventArgs ());
				}

				internal static bool __IsEmpty (IDownloadImageAsyncTaskListenerImplementor value)
				{
					return value.OnFailureHandler == null && value.OnSuccessHandler == null;
				}
			}


			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mraid/MraidNativeCommandHandler$DownloadImageAsyncTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DownloadImageAsyncTask); }
			}

			protected DownloadImageAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Lcom_mopub_mraid_MraidNativeCommandHandler_DownloadImageAsyncTask_DownloadImageAsyncTaskListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler.DownloadImageAsyncTask']/constructor[@name='MraidNativeCommandHandler.DownloadImageAsyncTask' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mraid.MraidNativeCommandHandler.DownloadImageAsyncTask.DownloadImageAsyncTaskListener']]"
			[Register (".ctor", "(Landroid/content/Context;Lcom/mopub/mraid/MraidNativeCommandHandler$DownloadImageAsyncTask$DownloadImageAsyncTaskListener;)V", "")]
			public unsafe DownloadImageAsyncTask (global::Android.Content.Context p0, global::Com.Mopub.Mraid.MraidNativeCommandHandler.DownloadImageAsyncTask.IDownloadImageAsyncTaskListener p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (DownloadImageAsyncTask)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/mopub/mraid/MraidNativeCommandHandler$DownloadImageAsyncTask$DownloadImageAsyncTaskListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/mopub/mraid/MraidNativeCommandHandler$DownloadImageAsyncTask$DownloadImageAsyncTaskListener;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_Lcom_mopub_mraid_MraidNativeCommandHandler_DownloadImageAsyncTask_DownloadImageAsyncTaskListener_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_Lcom_mopub_mraid_MraidNativeCommandHandler_DownloadImageAsyncTask_DownloadImageAsyncTaskListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mopub/mraid/MraidNativeCommandHandler$DownloadImageAsyncTask$DownloadImageAsyncTaskListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_mraid_MraidNativeCommandHandler_DownloadImageAsyncTask_DownloadImageAsyncTaskListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_mraid_MraidNativeCommandHandler_DownloadImageAsyncTask_DownloadImageAsyncTaskListener_, __args);
				} finally {
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Object_ == null)
					cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
				return cb_doInBackground_arrayLjava_lang_Object_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mraid.MraidNativeCommandHandler.DownloadImageAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidNativeCommandHandler.DownloadImageAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler.DownloadImageAsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
			[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
			protected override unsafe global::Java.Lang.Object DoInBackground (global::Java.Lang.Object[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Object __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_String_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_String_ == null)
					cb_doInBackground_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_String_);
				return cb_doInBackground_arrayLjava_lang_String_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mraid.MraidNativeCommandHandler.DownloadImageAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidNativeCommandHandler.DownloadImageAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler.DownloadImageAsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
			[Register ("doInBackground", "([Ljava/lang/String;)Ljava/lang/Boolean;", "GetDoInBackground_arrayLjava_lang_String_Handler")]
			protected virtual unsafe global::Java.Lang.Boolean DoInBackground (string[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_String_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/String;)Ljava/lang/Boolean;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Boolean __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/String;)Ljava/lang/Boolean;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_onPostExecute_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetOnPostExecute_Ljava_lang_Boolean_Handler ()
			{
				if (cb_onPostExecute_Ljava_lang_Boolean_ == null)
					cb_onPostExecute_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Boolean_);
				return cb_onPostExecute_Ljava_lang_Boolean_;
			}

			static void n_OnPostExecute_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mraid.MraidNativeCommandHandler.DownloadImageAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidNativeCommandHandler.DownloadImageAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPostExecute (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPostExecute_Ljava_lang_Boolean_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler.DownloadImageAsyncTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("onPostExecute", "(Ljava/lang/Boolean;)V", "GetOnPostExecute_Ljava_lang_Boolean_Handler")]
			protected virtual unsafe void OnPostExecute (global::Java.Lang.Boolean p0)
			{
				if (id_onPostExecute_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_onPostExecute_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler.MoPubMediaScannerConnectionClient']"
		[global::Android.Runtime.Register ("com/mopub/mraid/MraidNativeCommandHandler$MoPubMediaScannerConnectionClient", DoNotGenerateAcw=true)]
		public partial class MoPubMediaScannerConnectionClient : global::Java.Lang.Object, global::Android.Media.MediaScannerConnection.IMediaScannerConnectionClient {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mraid/MraidNativeCommandHandler$MoPubMediaScannerConnectionClient", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MoPubMediaScannerConnectionClient); }
			}

			protected MoPubMediaScannerConnectionClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onMediaScannerConnected;
#pragma warning disable 0169
			static Delegate GetOnMediaScannerConnectedHandler ()
			{
				if (cb_onMediaScannerConnected == null)
					cb_onMediaScannerConnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMediaScannerConnected);
				return cb_onMediaScannerConnected;
			}

			static void n_OnMediaScannerConnected (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mraid.MraidNativeCommandHandler.MoPubMediaScannerConnectionClient __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidNativeCommandHandler.MoPubMediaScannerConnectionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMediaScannerConnected ();
			}
#pragma warning restore 0169

			static IntPtr id_onMediaScannerConnected;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler.MoPubMediaScannerConnectionClient']/method[@name='onMediaScannerConnected' and count(parameter)=0]"
			[Register ("onMediaScannerConnected", "()V", "GetOnMediaScannerConnectedHandler")]
			public virtual unsafe void OnMediaScannerConnected ()
			{
				if (id_onMediaScannerConnected == IntPtr.Zero)
					id_onMediaScannerConnected = JNIEnv.GetMethodID (class_ref, "onMediaScannerConnected", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onMediaScannerConnected);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMediaScannerConnected", "()V"));
				} finally {
				}
			}

			static Delegate cb_onScanCompleted_Ljava_lang_String_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetOnScanCompleted_Ljava_lang_String_Landroid_net_Uri_Handler ()
			{
				if (cb_onScanCompleted_Ljava_lang_String_Landroid_net_Uri_ == null)
					cb_onScanCompleted_Ljava_lang_String_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnScanCompleted_Ljava_lang_String_Landroid_net_Uri_);
				return cb_onScanCompleted_Ljava_lang_String_Landroid_net_Uri_;
			}

			static void n_OnScanCompleted_Ljava_lang_String_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Mraid.MraidNativeCommandHandler.MoPubMediaScannerConnectionClient __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidNativeCommandHandler.MoPubMediaScannerConnectionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnScanCompleted (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onScanCompleted_Ljava_lang_String_Landroid_net_Uri_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler.MoPubMediaScannerConnectionClient']/method[@name='onScanCompleted' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.net.Uri']]"
			[Register ("onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V", "GetOnScanCompleted_Ljava_lang_String_Landroid_net_Uri_Handler")]
			public virtual unsafe void OnScanCompleted (string p0, global::Android.Net.Uri p1)
			{
				if (id_onScanCompleted_Ljava_lang_String_Landroid_net_Uri_ == IntPtr.Zero)
					id_onScanCompleted_Ljava_lang_String_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onScanCompleted_Ljava_lang_String_Landroid_net_Uri_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidNativeCommandHandler.MraidCommandFailureListener']"
		[Register ("com/mopub/mraid/MraidNativeCommandHandler$MraidCommandFailureListener", "", "Com.Mopub.Mraid.MraidNativeCommandHandler/IMraidCommandFailureListenerInvoker")]
		public partial interface IMraidCommandFailureListener : IJavaObject {

		}

		[global::Android.Runtime.Register ("com/mopub/mraid/MraidNativeCommandHandler$MraidCommandFailureListener", DoNotGenerateAcw=true)]
		internal class IMraidCommandFailureListenerInvoker : global::Java.Lang.Object, IMraidCommandFailureListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mraid/MraidNativeCommandHandler$MraidCommandFailureListener");
			IntPtr class_ref;

			public static IMraidCommandFailureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMraidCommandFailureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mraid.MraidNativeCommandHandler.MraidCommandFailureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMraidCommandFailureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMraidCommandFailureListenerInvoker); }
			}

		}

		[global::Android.Runtime.Register ("mono/com/mopub/mraid/MraidNativeCommandHandler_MraidCommandFailureListenerImplementor")]
		internal sealed partial class IMraidCommandFailureListenerImplementor : global::Java.Lang.Object, IMraidCommandFailureListener {

			public IMraidCommandFailureListenerImplementor ()
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mraid/MraidNativeCommandHandler_MraidCommandFailureListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			}


			internal static bool __IsEmpty (IMraidCommandFailureListenerImplementor value)
			{
				return true;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mraid/MraidNativeCommandHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidNativeCommandHandler); }
		}

		protected MraidNativeCommandHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler']/constructor[@name='MraidNativeCommandHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MraidNativeCommandHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MraidNativeCommandHandler)) {
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

		static IntPtr id_isStorePictureSupported_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidNativeCommandHandler']/method[@name='isStorePictureSupported' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isStorePictureSupported", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsStorePictureSupported (global::Android.Content.Context p0)
		{
			if (id_isStorePictureSupported_Landroid_content_Context_ == IntPtr.Zero)
				id_isStorePictureSupported_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isStorePictureSupported", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isStorePictureSupported_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
