; ModuleID = 'obj\Debug\100\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\100\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [110 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 2
	i64 210515253464952879, ; 1: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 19
	i64 232391251801502327, ; 2: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 40
	i64 295915112840604065, ; 3: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 41
	i64 634308326490598313, ; 4: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 32
	i64 702024105029695270, ; 5: System.Drawing.Common => 0x9be17343c0e7726 => 52
	i64 720058930071658100, ; 6: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 28
	i64 872800313462103108, ; 7: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 25
	i64 1000557547492888992, ; 8: Mono.Security.dll => 0xde2b1c9cba651a0 => 53
	i64 1120440138749646132, ; 9: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 49
	i64 1315114680217950157, ; 10: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 14
	i64 1624659445732251991, ; 11: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 12
	i64 1628611045998245443, ; 12: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 34
	i64 1636321030536304333, ; 13: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 29
	i64 1795316252682057001, ; 14: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 13
	i64 1836611346387731153, ; 15: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 40
	i64 1875917498431009007, ; 16: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 11
	i64 1981742497975770890, ; 17: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 33
	i64 2136356949452311481, ; 18: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 37
	i64 2165725771938924357, ; 19: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 17
	i64 2262844636196693701, ; 20: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 25
	i64 2329709569556905518, ; 21: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 31
	i64 2470498323731680442, ; 22: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 20
	i64 2479423007379663237, ; 23: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 44
	i64 2497223385847772520, ; 24: System.Runtime => 0x22a7eb7046413568 => 8
	i64 2547086958574651984, ; 25: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 10
	i64 2592350477072141967, ; 26: System.Xml.dll => 0x23f9e10627330e8f => 9
	i64 2624866290265602282, ; 27: mscorlib.dll => 0x246d65fbde2db8ea => 3
	i64 3017704767998173186, ; 28: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 49
	i64 3289520064315143713, ; 29: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 30
	i64 3311221304742556517, ; 30: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 7
	i64 3522470458906976663, ; 31: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 42
	i64 3531994851595924923, ; 32: System.Numerics => 0x31042a9aade235bb => 6
	i64 3571415421602489686, ; 33: System.Runtime.dll => 0x319037675df7e556 => 8
	i64 3727469159507183293, ; 34: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 39
	i64 4636684751163556186, ; 35: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 46
	i64 4782108999019072045, ; 36: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 16
	i64 4794310189461587505, ; 37: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 10
	i64 4795410492532947900, ; 38: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 42
	i64 5203618020066742981, ; 39: Xamarin.Essentials => 0x4836f704f0e652c5 => 48
	i64 5205316157927637098, ; 40: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 36
	i64 5376510917114486089, ; 41: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 44
	i64 5408338804355907810, ; 42: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 43
	i64 5507995362134886206, ; 43: System.Core.dll => 0x4c705499688c873e => 4
	i64 6319713645133255417, ; 44: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 32
	i64 6401687960814735282, ; 45: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 31
	i64 6504860066809920875, ; 46: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 17
	i64 6548213210057960872, ; 47: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 23
	i64 6659513131007730089, ; 48: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 28
	i64 6894844156784520562, ; 49: System.Numerics.Vectors => 0x5faf683aead1ad72 => 7
	i64 7103753931438454322, ; 50: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 27
	i64 7637365915383206639, ; 51: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 48
	i64 7654504624184590948, ; 52: System.Net.Http => 0x6a3a4366801b8264 => 51
	i64 7836164640616011524, ; 53: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 12
	i64 8044118961405839122, ; 54: System.ComponentModel.Composition => 0x6fa2739369944712 => 54
	i64 8083354569033831015, ; 55: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 30
	i64 8167236081217502503, ; 56: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 1
	i64 8601935802264776013, ; 57: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 43
	i64 8626175481042262068, ; 58: Java.Interop => 0x77b654e585b55834 => 1
	i64 9324707631942237306, ; 59: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 13
	i64 9662334977499516867, ; 60: System.Numerics.dll => 0x8617827802b0cfc3 => 6
	i64 9678050649315576968, ; 61: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 20
	i64 9808709177481450983, ; 62: Mono.Android.dll => 0x881f890734e555e7 => 2
	i64 9998632235833408227, ; 63: Mono.Security => 0x8ac2470b209ebae3 => 53
	i64 10038780035334861115, ; 64: System.Net.Http.dll => 0x8b50e941206af13b => 51
	i64 10229024438826829339, ; 65: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 23
	i64 10430153318873392755, ; 66: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 21
	i64 10847732767863316357, ; 67: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 14
	i64 11023048688141570732, ; 68: System.Core => 0x98f9bc61168392ac => 4
	i64 11037814507248023548, ; 69: System.Xml => 0x992e31d0412bf7fc => 9
	i64 11162124722117608902, ; 70: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 47
	i64 11340910727871153756, ; 71: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 22
	i64 11392833485892708388, ; 72: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 38
	i64 11529969570048099689, ; 73: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 47
	i64 11580057168383206117, ; 74: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 11
	i64 11672361001936329215, ; 75: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 27
	i64 12137774235383566651, ; 76: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 45
	i64 12451044538927396471, ; 77: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 26
	i64 12466513435562512481, ; 78: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 35
	i64 12487638416075308985, ; 79: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 24
	i64 12538491095302438457, ; 80: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 18
	i64 12700543734426720211, ; 81: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 19
	i64 12963446364377008305, ; 82: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 52
	i64 13401370062847626945, ; 83: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 45
	i64 13454009404024712428, ; 84: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 50
	i64 13491513212026656886, ; 85: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 15
	i64 13572454107664307259, ; 86: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 39
	i64 13959074834287824816, ; 87: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 26
	i64 14124974489674258913, ; 88: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 18
	i64 14172845254133543601, ; 89: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 37
	i64 14261073672896646636, ; 90: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 38
	i64 14644440854989303794, ; 91: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 36
	i64 14792063746108907174, ; 92: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 50
	i64 14852515768018889994, ; 93: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 22
	i64 14988210264188246988, ; 94: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 24
	i64 15370334346939861994, ; 95: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 21
	i64 15582737692548360875, ; 96: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 34
	i64 15609085926864131306, ; 97: System.dll => 0xd89e9cf3334914ea => 5
	i64 15777549416145007739, ; 98: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 41
	i64 15992623534043426341, ; 99: AppXamarin => 0xddf1365f2535ee25 => 0
	i64 16154507427712707110, ; 100: System => 0xe03056ea4e39aa26 => 5
	i64 16565028646146589191, ; 101: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 54
	i64 16833383113903931215, ; 102: mscorlib => 0xe99c30c1484d7f4f => 3
	i64 17037200463775726619, ; 103: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 29
	i64 17544493274320527064, ; 104: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 16
	i64 17704177640604968747, ; 105: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 35
	i64 17710060891934109755, ; 106: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 33
	i64 18116111925905154859, ; 107: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 15
	i64 18335353984879165647, ; 108: AppXamarin.dll => 0xfe74434debc400cf => 0
	i64 18380184030268848184 ; 109: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 46
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [110 x i32] [
	i32 2, i32 19, i32 40, i32 41, i32 32, i32 52, i32 28, i32 25, ; 0..7
	i32 53, i32 49, i32 14, i32 12, i32 34, i32 29, i32 13, i32 40, ; 8..15
	i32 11, i32 33, i32 37, i32 17, i32 25, i32 31, i32 20, i32 44, ; 16..23
	i32 8, i32 10, i32 9, i32 3, i32 49, i32 30, i32 7, i32 42, ; 24..31
	i32 6, i32 8, i32 39, i32 46, i32 16, i32 10, i32 42, i32 48, ; 32..39
	i32 36, i32 44, i32 43, i32 4, i32 32, i32 31, i32 17, i32 23, ; 40..47
	i32 28, i32 7, i32 27, i32 48, i32 51, i32 12, i32 54, i32 30, ; 48..55
	i32 1, i32 43, i32 1, i32 13, i32 6, i32 20, i32 2, i32 53, ; 56..63
	i32 51, i32 23, i32 21, i32 14, i32 4, i32 9, i32 47, i32 22, ; 64..71
	i32 38, i32 47, i32 11, i32 27, i32 45, i32 26, i32 35, i32 24, ; 72..79
	i32 18, i32 19, i32 52, i32 45, i32 50, i32 15, i32 39, i32 26, ; 80..87
	i32 18, i32 37, i32 38, i32 36, i32 50, i32 22, i32 24, i32 21, ; 88..95
	i32 34, i32 5, i32 41, i32 0, i32 5, i32 54, i32 3, i32 29, ; 96..103
	i32 16, i32 35, i32 33, i32 15, i32 0, i32 46 ; 104..109
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
