using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']"
	[global::Android.Runtime.Register ("com/mopub/common/CacheService", DoNotGenerateAcw=true)]
	public partial class CacheService : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.common']/interface[@name='CacheService.DiskLruCacheGetListener']"
		[Register ("com/mopub/common/CacheService$DiskLruCacheGetListener", "", "Com.Mopub.Common.CacheService/IDiskLruCacheGetListenerInvoker")]
		public partial interface IDiskLruCacheGetListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='CacheService.DiskLruCacheGetListener']/method[@name='onComplete' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
			[Register ("onComplete", "(Ljava/lang/String;[B)V", "GetOnComplete_Ljava_lang_String_arrayBHandler:Com.Mopub.Common.CacheService/IDiskLruCacheGetListenerInvoker, AppodealXamarinPlugin")]
			void OnComplete (string p0, byte[] p1);

		}

		[global::Android.Runtime.Register ("com/mopub/common/CacheService$DiskLruCacheGetListener", DoNotGenerateAcw=true)]
		internal class IDiskLruCacheGetListenerInvoker : global::Java.Lang.Object, IDiskLruCacheGetListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/common/CacheService$DiskLruCacheGetListener");
			IntPtr class_ref;

			public static IDiskLruCacheGetListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDiskLruCacheGetListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.common.CacheService.DiskLruCacheGetListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDiskLruCacheGetListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDiskLruCacheGetListenerInvoker); }
			}

			static Delegate cb_onComplete_Ljava_lang_String_arrayB;
#pragma warning disable 0169
			static Delegate GetOnComplete_Ljava_lang_String_arrayBHandler ()
			{
				if (cb_onComplete_Ljava_lang_String_arrayB == null)
					cb_onComplete_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnComplete_Ljava_lang_String_arrayB);
				return cb_onComplete_Ljava_lang_String_arrayB;
			}

			static void n_OnComplete_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Common.CacheService.IDiskLruCacheGetListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CacheService.IDiskLruCacheGetListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnComplete (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Ljava_lang_String_arrayB;
			public unsafe void OnComplete (string p0, byte[] p1)
			{
				if (id_onComplete_Ljava_lang_String_arrayB == IntPtr.Zero)
					id_onComplete_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/lang/String;[B)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (Handle, id_onComplete_Ljava_lang_String_arrayB, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		public partial class DiskLruCacheGetEventArgs : global::System.EventArgs {

			public DiskLruCacheGetEventArgs (string p0, byte[] p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			byte[] p1;
			public byte[] P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/common/CacheService_DiskLruCacheGetListenerImplementor")]
		internal sealed partial class IDiskLruCacheGetListenerImplementor : global::Java.Lang.Object, IDiskLruCacheGetListener {

			object sender;

			public IDiskLruCacheGetListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/common/CacheService_DiskLruCacheGetListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DiskLruCacheGetEventArgs> Handler;
#pragma warning restore 0649

			public void OnComplete (string p0, byte[] p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DiskLruCacheGetEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IDiskLruCacheGetListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService.DiskLruCacheGetTask']"
		[global::Android.Runtime.Register ("com/mopub/common/CacheService$DiskLruCacheGetTask", DoNotGenerateAcw=true)]
		public partial class DiskLruCacheGetTask : global::Android.OS.AsyncTask {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/CacheService$DiskLruCacheGetTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DiskLruCacheGetTask); }
			}

			protected DiskLruCacheGetTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Mopub.Common.CacheService.DiskLruCacheGetTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CacheService.DiskLruCacheGetTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService.DiskLruCacheGetTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
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

			static Delegate cb_doInBackground_arrayLjava_lang_Void_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Void_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Void_ == null)
					cb_doInBackground_arrayLjava_lang_Void_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Void_);
				return cb_doInBackground_arrayLjava_lang_Void_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Void_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.CacheService.DiskLruCacheGetTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CacheService.DiskLruCacheGetTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Void[] p0 = (global::Java.Lang.Void[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Void));
				IntPtr __ret = JNIEnv.NewArray (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Void_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService.DiskLruCacheGetTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Void...']]"
			[Register ("doInBackground", "([Ljava/lang/Void;)[B", "GetDoInBackground_arrayLjava_lang_Void_Handler")]
			protected virtual unsafe byte[] DoInBackground (params global:: Java.Lang.Void[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Void_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Void;)[B");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					byte[] __ret;
					if (GetType () == ThresholdType)
						__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Void_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Void;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_onPostExecute_arrayB;
#pragma warning disable 0169
			static Delegate GetOnPostExecute_arrayBHandler ()
			{
				if (cb_onPostExecute_arrayB == null)
					cb_onPostExecute_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_arrayB);
				return cb_onPostExecute_arrayB;
			}

			static void n_OnPostExecute_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.CacheService.DiskLruCacheGetTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CacheService.DiskLruCacheGetTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnPostExecute (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPostExecute_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService.DiskLruCacheGetTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("onPostExecute", "([B)V", "GetOnPostExecute_arrayBHandler")]
			protected virtual unsafe void OnPostExecute (byte[] p0)
			{
				if (id_onPostExecute_arrayB == IntPtr.Zero)
					id_onPostExecute_arrayB = JNIEnv.GetMethodID (class_ref, "onPostExecute", "([B)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_arrayB, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "([B)V"), __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService.DiskLruCachePutTask']"
		[global::Android.Runtime.Register ("com/mopub/common/CacheService$DiskLruCachePutTask", DoNotGenerateAcw=true)]
		public partial class DiskLruCachePutTask : global::Android.OS.AsyncTask {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/CacheService$DiskLruCachePutTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DiskLruCachePutTask); }
			}

			protected DiskLruCachePutTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Mopub.Common.CacheService.DiskLruCachePutTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CacheService.DiskLruCachePutTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService.DiskLruCachePutTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
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

			static Delegate cb_doInBackground_arrayLjava_lang_Void_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Void_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Void_ == null)
					cb_doInBackground_arrayLjava_lang_Void_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Void_);
				return cb_doInBackground_arrayLjava_lang_Void_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Void_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.CacheService.DiskLruCachePutTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CacheService.DiskLruCachePutTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Void[] p0 = (global::Java.Lang.Void[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Void));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Void_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService.DiskLruCachePutTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Void...']]"
			[Register ("doInBackground", "([Ljava/lang/Void;)Ljava/lang/Void;", "GetDoInBackground_arrayLjava_lang_Void_Handler")]
			protected virtual unsafe global::Java.Lang.Void DoInBackground (params global:: Java.Lang.Void[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Void_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Void;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Void __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Void_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Void;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/CacheService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CacheService); }
		}

		protected CacheService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/constructor[@name='CacheService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CacheService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CacheService)) {
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

		static IntPtr id_getDiskLruCache;
		[Obsolete (@"deprecated")]
		public static unsafe global::Com.Mopub.Common.DiskLruCache DiskLruCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='getDiskLruCache' and count(parameter)=0]"
			[Register ("getDiskLruCache", "()Lcom/mopub/common/DiskLruCache;", "GetGetDiskLruCacheHandler")]
			get {
				if (id_getDiskLruCache == IntPtr.Zero)
					id_getDiskLruCache = JNIEnv.GetStaticMethodID (class_ref, "getDiskLruCache", "()Lcom/mopub/common/DiskLruCache;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DiskLruCache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDiskLruCache), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_clearAndNullCaches;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='clearAndNullCaches' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("clearAndNullCaches", "()V", "")]
		public static unsafe void ClearAndNullCaches ()
		{
			if (id_clearAndNullCaches == IntPtr.Zero)
				id_clearAndNullCaches = JNIEnv.GetStaticMethodID (class_ref, "clearAndNullCaches", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearAndNullCaches);
			} finally {
			}
		}

		static IntPtr id_containsKeyDiskCache_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='containsKeyDiskCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsKeyDiskCache", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool ContainsKeyDiskCache (string p0)
		{
			if (id_containsKeyDiskCache_Ljava_lang_String_ == IntPtr.Zero)
				id_containsKeyDiskCache_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "containsKeyDiskCache", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsKeyDiskCache_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_createValidDiskCacheKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='createValidDiskCacheKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createValidDiskCacheKey", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CreateValidDiskCacheKey (string p0)
		{
			if (id_createValidDiskCacheKey_Ljava_lang_String_ == IntPtr.Zero)
				id_createValidDiskCacheKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createValidDiskCacheKey", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_createValidDiskCacheKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getDiskCacheDirectory_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='getDiskCacheDirectory' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDiskCacheDirectory", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetDiskCacheDirectory (global::Android.Content.Context p0)
		{
			if (id_getDiskCacheDirectory_Landroid_content_Context_ == IntPtr.Zero)
				id_getDiskCacheDirectory_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDiskCacheDirectory", "(Landroid/content/Context;)Ljava/io/File;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDiskCacheDirectory_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFilePathDiskCache_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='getFilePathDiskCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFilePathDiskCache", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFilePathDiskCache (string p0)
		{
			if (id_getFilePathDiskCache_Ljava_lang_String_ == IntPtr.Zero)
				id_getFilePathDiskCache_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFilePathDiskCache", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFilePathDiskCache_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFromDiskCache_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='getFromDiskCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFromDiskCache", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetFromDiskCache (string p0)
		{
			if (id_getFromDiskCache_Ljava_lang_String_ == IntPtr.Zero)
				id_getFromDiskCache_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFromDiskCache", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFromDiskCache_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFromDiskCacheAsync_Ljava_lang_String_Lcom_mopub_common_CacheService_DiskLruCacheGetListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='getFromDiskCacheAsync' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.common.CacheService.DiskLruCacheGetListener']]"
		[Register ("getFromDiskCacheAsync", "(Ljava/lang/String;Lcom/mopub/common/CacheService$DiskLruCacheGetListener;)V", "")]
		public static unsafe void GetFromDiskCacheAsync (string p0, global::Com.Mopub.Common.CacheService.IDiskLruCacheGetListener p1)
		{
			if (id_getFromDiskCacheAsync_Ljava_lang_String_Lcom_mopub_common_CacheService_DiskLruCacheGetListener_ == IntPtr.Zero)
				id_getFromDiskCacheAsync_Ljava_lang_String_Lcom_mopub_common_CacheService_DiskLruCacheGetListener_ = JNIEnv.GetStaticMethodID (class_ref, "getFromDiskCacheAsync", "(Ljava/lang/String;Lcom/mopub/common/CacheService$DiskLruCacheGetListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getFromDiskCacheAsync_Ljava_lang_String_Lcom_mopub_common_CacheService_DiskLruCacheGetListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_initialize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context p0)
		{
			if (id_initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_initializeDiskCache_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='initializeDiskCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initializeDiskCache", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool InitializeDiskCache (global::Android.Content.Context p0)
		{
			if (id_initializeDiskCache_Landroid_content_Context_ == IntPtr.Zero)
				id_initializeDiskCache_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initializeDiskCache", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_initializeDiskCache_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_putToDiskCache_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='putToDiskCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("putToDiskCache", "(Ljava/lang/String;[B)Z", "")]
		public static unsafe bool PutToDiskCache (string p0, byte[] p1)
		{
			if (id_putToDiskCache_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_putToDiskCache_Ljava_lang_String_arrayB = JNIEnv.GetStaticMethodID (class_ref, "putToDiskCache", "(Ljava/lang/String;[B)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_putToDiskCache_Ljava_lang_String_arrayB, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_putToDiskCache_Ljava_lang_String_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='putToDiskCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("putToDiskCache", "(Ljava/lang/String;Ljava/io/InputStream;)Z", "")]
		public static unsafe bool PutToDiskCache (string p0, global::System.IO.Stream p1)
		{
			if (id_putToDiskCache_Ljava_lang_String_Ljava_io_InputStream_ == IntPtr.Zero)
				id_putToDiskCache_Ljava_lang_String_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "putToDiskCache", "(Ljava/lang/String;Ljava/io/InputStream;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_putToDiskCache_Ljava_lang_String_Ljava_io_InputStream_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_putToDiskCacheAsync_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CacheService']/method[@name='putToDiskCacheAsync' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("putToDiskCacheAsync", "(Ljava/lang/String;[B)V", "")]
		public static unsafe void PutToDiskCacheAsync (string p0, byte[] p1)
		{
			if (id_putToDiskCacheAsync_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_putToDiskCacheAsync_Ljava_lang_String_arrayB = JNIEnv.GetStaticMethodID (class_ref, "putToDiskCacheAsync", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_putToDiskCacheAsync_Ljava_lang_String_arrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
