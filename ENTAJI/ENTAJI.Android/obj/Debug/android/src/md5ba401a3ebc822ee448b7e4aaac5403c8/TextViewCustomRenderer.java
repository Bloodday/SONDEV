package md5ba401a3ebc822ee448b7e4aaac5403c8;


public class TextViewCustomRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.EntryRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ENTAJI.Droid.CustomRenders.TextViewCustomRenderer, ENTAJI.Android", TextViewCustomRenderer.class, __md_methods);
	}


	public TextViewCustomRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == TextViewCustomRenderer.class)
			mono.android.TypeManager.Activate ("ENTAJI.Droid.CustomRenders.TextViewCustomRenderer, ENTAJI.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public TextViewCustomRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == TextViewCustomRenderer.class)
			mono.android.TypeManager.Activate ("ENTAJI.Droid.CustomRenders.TextViewCustomRenderer, ENTAJI.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public TextViewCustomRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == TextViewCustomRenderer.class)
			mono.android.TypeManager.Activate ("ENTAJI.Droid.CustomRenders.TextViewCustomRenderer, ENTAJI.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
