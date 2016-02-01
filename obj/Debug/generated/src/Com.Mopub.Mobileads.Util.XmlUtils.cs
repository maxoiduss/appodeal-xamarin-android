using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/util/XmlUtils", DoNotGenerateAcw=true)]
	public partial class XmlUtils : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads.util']/interface[@name='XmlUtils.NodeProcessor']"
		[Register ("com/mopub/mobileads/util/XmlUtils$NodeProcessor", "", "Com.Mopub.Mobileads.Util.XmlUtils/INodeProcessorInvoker")]
		public partial interface INodeProcessor : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/interface[@name='XmlUtils.NodeProcessor']/method[@name='process' and count(parameter)=1 and parameter[1][@type='org.w3c.dom.Node']]"
			[Register ("process", "(Lorg/w3c/dom/Node;)Ljava/lang/Object;", "GetProcess_Lorg_w3c_dom_Node_Handler:Com.Mopub.Mobileads.Util.XmlUtils/INodeProcessorInvoker, AppodealXamarinPlugin")]
			global::Java.Lang.Object Process (global::Org.W3c.Dom.INode p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/util/XmlUtils$NodeProcessor", DoNotGenerateAcw=true)]
		internal class INodeProcessorInvoker : global::Java.Lang.Object, INodeProcessor {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/util/XmlUtils$NodeProcessor");
			IntPtr class_ref;

			public static INodeProcessor GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INodeProcessor> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.util.XmlUtils.NodeProcessor"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INodeProcessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INodeProcessorInvoker); }
			}

			static Delegate cb_process_Lorg_w3c_dom_Node_;
#pragma warning disable 0169
			static Delegate GetProcess_Lorg_w3c_dom_Node_Handler ()
			{
				if (cb_process_Lorg_w3c_dom_Node_ == null)
					cb_process_Lorg_w3c_dom_Node_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Process_Lorg_w3c_dom_Node_);
				return cb_process_Lorg_w3c_dom_Node_;
			}

			static IntPtr n_Process_Lorg_w3c_dom_Node_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.Util.XmlUtils.INodeProcessor __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.XmlUtils.INodeProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.W3c.Dom.INode p0 = (global::Org.W3c.Dom.INode)global::Java.Lang.Object.GetObject<global::Org.W3c.Dom.INode> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Process (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_process_Lorg_w3c_dom_Node_;
			public unsafe global::Java.Lang.Object Process (global::Org.W3c.Dom.INode p0)
			{
				if (id_process_Lorg_w3c_dom_Node_ == IntPtr.Zero)
					id_process_Lorg_w3c_dom_Node_ = JNIEnv.GetMethodID (class_ref, "process", "(Lorg/w3c/dom/Node;)Ljava/lang/Object;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_process_Lorg_w3c_dom_Node_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/util/XmlUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XmlUtils); }
		}

		protected XmlUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAttributeValue_Lorg_w3c_dom_Node_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getAttributeValue' and count(parameter)=2 and parameter[1][@type='org.w3c.dom.Node'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAttributeValue", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetAttributeValue (global::Org.W3c.Dom.INode p0, string p1)
		{
			if (id_getAttributeValue_Lorg_w3c_dom_Node_Ljava_lang_String_ == IntPtr.Zero)
				id_getAttributeValue_Lorg_w3c_dom_Node_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAttributeValue", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAttributeValue_Lorg_w3c_dom_Node_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getAttributeValueAsInt_Lorg_w3c_dom_Node_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getAttributeValueAsInt' and count(parameter)=2 and parameter[1][@type='org.w3c.dom.Node'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAttributeValueAsInt", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer GetAttributeValueAsInt (global::Org.W3c.Dom.INode p0, string p1)
		{
			if (id_getAttributeValueAsInt_Lorg_w3c_dom_Node_Ljava_lang_String_ == IntPtr.Zero)
				id_getAttributeValueAsInt_Lorg_w3c_dom_Node_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAttributeValueAsInt", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Ljava/lang/Integer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAttributeValueAsInt_Lorg_w3c_dom_Node_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getFirstMatchFromDocument_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_mobileads_util_XmlUtils_NodeProcessor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getFirstMatchFromDocument' and count(parameter)=5 and parameter[1][@type='org.w3c.dom.Document'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.mopub.mobileads.util.XmlUtils.NodeProcessor']]"
		[Register ("getFirstMatchFromDocument", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/mobileads/util/XmlUtils$NodeProcessor;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetFirstMatchFromDocument (global::Org.W3c.Dom.IDocument p0, string p1, string p2, string p3, global::Com.Mopub.Mobileads.Util.XmlUtils.INodeProcessor p4)
		{
			if (id_getFirstMatchFromDocument_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_mobileads_util_XmlUtils_NodeProcessor_ == IntPtr.Zero)
				id_getFirstMatchFromDocument_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_mobileads_util_XmlUtils_NodeProcessor_ = JNIEnv.GetStaticMethodID (class_ref, "getFirstMatchFromDocument", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/mobileads/util/XmlUtils$NodeProcessor;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFirstMatchFromDocument_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_mobileads_util_XmlUtils_NodeProcessor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getFirstMatchingChildNode_Lorg_w3c_dom_Node_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getFirstMatchingChildNode' and count(parameter)=2 and parameter[1][@type='org.w3c.dom.Node'] and parameter[2][@type='java.lang.String']]"
		[Register ("getFirstMatchingChildNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Lorg/w3c/dom/Node;", "")]
		public static unsafe global::Org.W3c.Dom.INode GetFirstMatchingChildNode (global::Org.W3c.Dom.INode p0, string p1)
		{
			if (id_getFirstMatchingChildNode_Lorg_w3c_dom_Node_Ljava_lang_String_ == IntPtr.Zero)
				id_getFirstMatchingChildNode_Lorg_w3c_dom_Node_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFirstMatchingChildNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Lorg/w3c/dom/Node;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Org.W3c.Dom.INode __ret = global::Java.Lang.Object.GetObject<global::Org.W3c.Dom.INode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFirstMatchingChildNode_Lorg_w3c_dom_Node_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getFirstMatchingChildNode_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getFirstMatchingChildNode' and count(parameter)=4 and parameter[1][@type='org.w3c.dom.Node'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List']]"
		[Register ("getFirstMatchingChildNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Lorg/w3c/dom/Node;", "")]
		public static unsafe global::Org.W3c.Dom.INode GetFirstMatchingChildNode (global::Org.W3c.Dom.INode p0, string p1, string p2, global::System.Collections.IList p3)
		{
			if (id_getFirstMatchingChildNode_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_getFirstMatchingChildNode_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "getFirstMatchingChildNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Lorg/w3c/dom/Node;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				global::Org.W3c.Dom.INode __ret = global::Java.Lang.Object.GetObject<global::Org.W3c.Dom.INode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFirstMatchingChildNode_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getFirstMatchingStringData_Lorg_w3c_dom_Document_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getFirstMatchingStringData' and count(parameter)=2 and parameter[1][@type='org.w3c.dom.Document'] and parameter[2][@type='java.lang.String']]"
		[Register ("getFirstMatchingStringData", "(Lorg/w3c/dom/Document;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFirstMatchingStringData (global::Org.W3c.Dom.IDocument p0, string p1)
		{
			if (id_getFirstMatchingStringData_Lorg_w3c_dom_Document_Ljava_lang_String_ == IntPtr.Zero)
				id_getFirstMatchingStringData_Lorg_w3c_dom_Document_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFirstMatchingStringData", "(Lorg/w3c/dom/Document;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFirstMatchingStringData_Lorg_w3c_dom_Document_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getFirstMatchingStringData_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getFirstMatchingStringData' and count(parameter)=4 and parameter[1][@type='org.w3c.dom.Document'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getFirstMatchingStringData", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFirstMatchingStringData (global::Org.W3c.Dom.IDocument p0, string p1, string p2, string p3)
		{
			if (id_getFirstMatchingStringData_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getFirstMatchingStringData_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFirstMatchingStringData", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFirstMatchingStringData_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getListFromDocument_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_mobileads_util_XmlUtils_NodeProcessor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getListFromDocument' and count(parameter)=5 and parameter[1][@type='org.w3c.dom.Document'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.mopub.mobileads.util.XmlUtils.NodeProcessor']]"
		[Register ("getListFromDocument", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/mobileads/util/XmlUtils$NodeProcessor;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.IList GetListFromDocument (global::Org.W3c.Dom.IDocument p0, string p1, string p2, string p3, global::Com.Mopub.Mobileads.Util.XmlUtils.INodeProcessor p4)
		{
			if (id_getListFromDocument_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_mobileads_util_XmlUtils_NodeProcessor_ == IntPtr.Zero)
				id_getListFromDocument_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_mobileads_util_XmlUtils_NodeProcessor_ = JNIEnv.GetStaticMethodID (class_ref, "getListFromDocument", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/mobileads/util/XmlUtils$NodeProcessor;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getListFromDocument_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_mobileads_util_XmlUtils_NodeProcessor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getMatchingChildNodes_Lorg_w3c_dom_Node_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getMatchingChildNodes' and count(parameter)=2 and parameter[1][@type='org.w3c.dom.Node'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMatchingChildNodes", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.IList GetMatchingChildNodes (global::Org.W3c.Dom.INode p0, string p1)
		{
			if (id_getMatchingChildNodes_Lorg_w3c_dom_Node_Ljava_lang_String_ == IntPtr.Zero)
				id_getMatchingChildNodes_Lorg_w3c_dom_Node_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getMatchingChildNodes", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMatchingChildNodes_Lorg_w3c_dom_Node_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getMatchingChildNodes_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getMatchingChildNodes' and count(parameter)=4 and parameter[1][@type='org.w3c.dom.Node'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List']]"
		[Register ("getMatchingChildNodes", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.IList GetMatchingChildNodes (global::Org.W3c.Dom.INode p0, string p1, string p2, global::System.Collections.IList p3)
		{
			if (id_getMatchingChildNodes_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_getMatchingChildNodes_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "getMatchingChildNodes", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMatchingChildNodes_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getNodeValue_Lorg_w3c_dom_Node_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getNodeValue' and count(parameter)=1 and parameter[1][@type='org.w3c.dom.Node']]"
		[Register ("getNodeValue", "(Lorg/w3c/dom/Node;)Ljava/lang/String;", "")]
		public static unsafe string GetNodeValue (global::Org.W3c.Dom.INode p0)
		{
			if (id_getNodeValue_Lorg_w3c_dom_Node_ == IntPtr.Zero)
				id_getNodeValue_Lorg_w3c_dom_Node_ = JNIEnv.GetStaticMethodID (class_ref, "getNodeValue", "(Lorg/w3c/dom/Node;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNodeValue_Lorg_w3c_dom_Node_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNodesWithElementAndAttribute_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getNodesWithElementAndAttribute' and count(parameter)=4 and parameter[1][@type='org.w3c.dom.Document'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getNodesWithElementAndAttribute", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.IList GetNodesWithElementAndAttribute (global::Org.W3c.Dom.IDocument p0, string p1, string p2, string p3)
		{
			if (id_getNodesWithElementAndAttribute_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getNodesWithElementAndAttribute_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getNodesWithElementAndAttribute", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNodesWithElementAndAttribute_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getStringDataAsList_Lorg_w3c_dom_Document_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getStringDataAsList' and count(parameter)=2 and parameter[1][@type='org.w3c.dom.Document'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringDataAsList", "(Lorg/w3c/dom/Document;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.IList GetStringDataAsList (global::Org.W3c.Dom.IDocument p0, string p1)
		{
			if (id_getStringDataAsList_Lorg_w3c_dom_Document_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringDataAsList_Lorg_w3c_dom_Document_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStringDataAsList", "(Lorg/w3c/dom/Document;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStringDataAsList_Lorg_w3c_dom_Document_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getStringDataAsList_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='getStringDataAsList' and count(parameter)=4 and parameter[1][@type='org.w3c.dom.Document'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getStringDataAsList", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.IList GetStringDataAsList (global::Org.W3c.Dom.IDocument p0, string p1, string p2, string p3)
		{
			if (id_getStringDataAsList_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringDataAsList_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStringDataAsList", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStringDataAsList_Lorg_w3c_dom_Document_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_nodeMatchesAttributeFilter_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='XmlUtils']/method[@name='nodeMatchesAttributeFilter' and count(parameter)=3 and parameter[1][@type='org.w3c.dom.Node'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List']]"
		[Register ("nodeMatchesAttributeFilter", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/util/List;)Z", "")]
		public static unsafe bool NodeMatchesAttributeFilter (global::Org.W3c.Dom.INode p0, string p1, global::System.Collections.IList p2)
		{
			if (id_nodeMatchesAttributeFilter_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_nodeMatchesAttributeFilter_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "nodeMatchesAttributeFilter", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/util/List;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_nodeMatchesAttributeFilter_Lorg_w3c_dom_Node_Ljava_lang_String_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
