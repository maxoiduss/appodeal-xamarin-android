using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/DiskBasedCache", DoNotGenerateAcw=true)]
	public partial class DiskBasedCache : global::Java.Lang.Object, global::Com.Mopub.Volley.ICache {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CacheHeader']"
		[global::Android.Runtime.Register ("com/mopub/volley/toolbox/DiskBasedCache$CacheHeader", DoNotGenerateAcw=true)]
		public partial class CacheHeader : global::Java.Lang.Object {


			static IntPtr etag_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CacheHeader']/field[@name='etag']"
			[Register ("etag")]
			public string Etag {
				get {
					if (etag_jfieldId == IntPtr.Zero)
						etag_jfieldId = JNIEnv.GetFieldID (class_ref, "etag", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, etag_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (etag_jfieldId == IntPtr.Zero)
						etag_jfieldId = JNIEnv.GetFieldID (class_ref, "etag", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, etag_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr key_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CacheHeader']/field[@name='key']"
			[Register ("key")]
			public string Key {
				get {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, key_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, key_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr responseHeaders_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CacheHeader']/field[@name='responseHeaders']"
			[Register ("responseHeaders")]
			public global::System.Collections.IDictionary ResponseHeaders {
				get {
					if (responseHeaders_jfieldId == IntPtr.Zero)
						responseHeaders_jfieldId = JNIEnv.GetFieldID (class_ref, "responseHeaders", "Ljava/util/Map;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, responseHeaders_jfieldId);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (responseHeaders_jfieldId == IntPtr.Zero)
						responseHeaders_jfieldId = JNIEnv.GetFieldID (class_ref, "responseHeaders", "Ljava/util/Map;");
					IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, responseHeaders_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr serverDate_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CacheHeader']/field[@name='serverDate']"
			[Register ("serverDate")]
			public long ServerDate {
				get {
					if (serverDate_jfieldId == IntPtr.Zero)
						serverDate_jfieldId = JNIEnv.GetFieldID (class_ref, "serverDate", "J");
					return JNIEnv.GetLongField (Handle, serverDate_jfieldId);
				}
				set {
					if (serverDate_jfieldId == IntPtr.Zero)
						serverDate_jfieldId = JNIEnv.GetFieldID (class_ref, "serverDate", "J");
					try {
						JNIEnv.SetField (Handle, serverDate_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr size_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CacheHeader']/field[@name='size']"
			[Register ("size")]
			public long Size {
				get {
					if (size_jfieldId == IntPtr.Zero)
						size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "J");
					return JNIEnv.GetLongField (Handle, size_jfieldId);
				}
				set {
					if (size_jfieldId == IntPtr.Zero)
						size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "J");
					try {
						JNIEnv.SetField (Handle, size_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr softTtl_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CacheHeader']/field[@name='softTtl']"
			[Register ("softTtl")]
			public long SoftTtl {
				get {
					if (softTtl_jfieldId == IntPtr.Zero)
						softTtl_jfieldId = JNIEnv.GetFieldID (class_ref, "softTtl", "J");
					return JNIEnv.GetLongField (Handle, softTtl_jfieldId);
				}
				set {
					if (softTtl_jfieldId == IntPtr.Zero)
						softTtl_jfieldId = JNIEnv.GetFieldID (class_ref, "softTtl", "J");
					try {
						JNIEnv.SetField (Handle, softTtl_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr ttl_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CacheHeader']/field[@name='ttl']"
			[Register ("ttl")]
			public long Ttl {
				get {
					if (ttl_jfieldId == IntPtr.Zero)
						ttl_jfieldId = JNIEnv.GetFieldID (class_ref, "ttl", "J");
					return JNIEnv.GetLongField (Handle, ttl_jfieldId);
				}
				set {
					if (ttl_jfieldId == IntPtr.Zero)
						ttl_jfieldId = JNIEnv.GetFieldID (class_ref, "ttl", "J");
					try {
						JNIEnv.SetField (Handle, ttl_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/volley/toolbox/DiskBasedCache$CacheHeader", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CacheHeader); }
			}

			protected CacheHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CacheHeader']/constructor[@name='DiskBasedCache.CacheHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.volley.Cache.Entry']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/mopub/volley/Cache$Entry;)V", "")]
			public unsafe CacheHeader (string p0, global::Com.Mopub.Volley.CacheEntry p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (CacheHeader)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/mopub/volley/Cache$Entry;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/mopub/volley/Cache$Entry;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/mopub/volley/Cache$Entry;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_toCacheEntry_arrayB;
#pragma warning disable 0169
			static Delegate GetToCacheEntry_arrayBHandler ()
			{
				if (cb_toCacheEntry_arrayB == null)
					cb_toCacheEntry_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToCacheEntry_arrayB);
				return cb_toCacheEntry_arrayB;
			}

			static IntPtr n_ToCacheEntry_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.Toolbox.DiskBasedCache.CacheHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.DiskBasedCache.CacheHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToCacheEntry (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_toCacheEntry_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CacheHeader']/method[@name='toCacheEntry' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("toCacheEntry", "([B)Lcom/mopub/volley/Cache$Entry;", "GetToCacheEntry_arrayBHandler")]
			public virtual unsafe global::Com.Mopub.Volley.CacheEntry ToCacheEntry (byte[] p0)
			{
				if (id_toCacheEntry_arrayB == IntPtr.Zero)
					id_toCacheEntry_arrayB = JNIEnv.GetMethodID (class_ref, "toCacheEntry", "([B)Lcom/mopub/volley/Cache$Entry;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Volley.CacheEntry __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.CacheEntry> (JNIEnv.CallObjectMethod  (Handle, id_toCacheEntry_arrayB, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.CacheEntry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toCacheEntry", "([B)Lcom/mopub/volley/Cache$Entry;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_writeHeader_Ljava_io_OutputStream_;
#pragma warning disable 0169
			static Delegate GetWriteHeader_Ljava_io_OutputStream_Handler ()
			{
				if (cb_writeHeader_Ljava_io_OutputStream_ == null)
					cb_writeHeader_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_WriteHeader_Ljava_io_OutputStream_);
				return cb_writeHeader_Ljava_io_OutputStream_;
			}

			static bool n_WriteHeader_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.Toolbox.DiskBasedCache.CacheHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.DiskBasedCache.CacheHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.WriteHeader (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_writeHeader_Ljava_io_OutputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CacheHeader']/method[@name='writeHeader' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
			[Register ("writeHeader", "(Ljava/io/OutputStream;)Z", "GetWriteHeader_Ljava_io_OutputStream_Handler")]
			public virtual unsafe bool WriteHeader (global::System.IO.Stream p0)
			{
				if (id_writeHeader_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_writeHeader_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeHeader", "(Ljava/io/OutputStream;)Z");
				IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_writeHeader_Ljava_io_OutputStream_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeHeader", "(Ljava/io/OutputStream;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache.CountingInputStream']"
		[global::Android.Runtime.Register ("com/mopub/volley/toolbox/DiskBasedCache$CountingInputStream", DoNotGenerateAcw=true)]
		public partial class CountingInputStream : global::Java.IO.FilterInputStream {

			protected CountingInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/DiskBasedCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiskBasedCache); }
		}

		protected DiskBasedCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache']/constructor[@name='DiskBasedCache' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/io/File;I)V", "")]
		public unsafe DiskBasedCache (global::Java.IO.File p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DiskBasedCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_I == IntPtr.Zero)
					id_ctor_Ljava_io_File_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache']/constructor[@name='DiskBasedCache' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe DiskBasedCache (global::Java.IO.File p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DiskBasedCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_ == IntPtr.Zero)
					id_ctor_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_, __args);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Toolbox.DiskBasedCache __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.DiskBasedCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.DiskBasedCache __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.DiskBasedCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/mopub/volley/Cache$Entry;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mopub.Volley.CacheEntry Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/mopub/volley/Cache$Entry;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mopub.Volley.CacheEntry __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.CacheEntry> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.CacheEntry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Lcom/mopub/volley/Cache$Entry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getFileForKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFileForKey_Ljava_lang_String_Handler ()
		{
			if (cb_getFileForKey_Ljava_lang_String_ == null)
				cb_getFileForKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFileForKey_Ljava_lang_String_);
			return cb_getFileForKey_Ljava_lang_String_;
		}

		static IntPtr n_GetFileForKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.DiskBasedCache __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.DiskBasedCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFileForKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFileForKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache']/method[@name='getFileForKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileForKey", "(Ljava/lang/String;)Ljava/io/File;", "GetGetFileForKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.IO.File GetFileForKey (string p0)
		{
			if (id_getFileForKey_Ljava_lang_String_ == IntPtr.Zero)
				id_getFileForKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFileForKey", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.IO.File __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getFileForKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileForKey", "(Ljava/lang/String;)Ljava/io/File;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Initialize);
			return cb_initialize;
		}

		static void n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Toolbox.DiskBasedCache __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.DiskBasedCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Initialize ();
		}
#pragma warning restore 0169

		static IntPtr id_initialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "GetInitializeHandler")]
		public virtual unsafe void Initialize ()
		{
			if (id_initialize == IntPtr.Zero)
				id_initialize = JNIEnv.GetMethodID (class_ref, "initialize", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initialize);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "()V"));
			} finally {
			}
		}

		static Delegate cb_invalidate_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetInvalidate_Ljava_lang_String_ZHandler ()
		{
			if (cb_invalidate_Ljava_lang_String_Z == null)
				cb_invalidate_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_Invalidate_Ljava_lang_String_Z);
			return cb_invalidate_Ljava_lang_String_Z;
		}

		static void n_Invalidate_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Mopub.Volley.Toolbox.DiskBasedCache __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.DiskBasedCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_invalidate_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache']/method[@name='invalidate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("invalidate", "(Ljava/lang/String;Z)V", "GetInvalidate_Ljava_lang_String_ZHandler")]
		public virtual unsafe void Invalidate (string p0, bool p1)
		{
			if (id_invalidate_Ljava_lang_String_Z == IntPtr.Zero)
				id_invalidate_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "invalidate", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_invalidate_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidate", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ == null)
				cb_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_);
			return cb_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_;
		}

		static void n_Put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.Toolbox.DiskBasedCache __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.DiskBasedCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.CacheEntry p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.CacheEntry> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.volley.Cache.Entry']]"
		[Register ("put", "(Ljava/lang/String;Lcom/mopub/volley/Cache$Entry;)V", "GetPut_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_Handler")]
		public virtual unsafe void Put (string p0, global::Com.Mopub.Volley.CacheEntry p1)
		{
			if (id_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Lcom/mopub/volley/Cache$Entry;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Lcom/mopub/volley/Cache$Entry;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.DiskBasedCache __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.DiskBasedCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='DiskBasedCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_remove_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
