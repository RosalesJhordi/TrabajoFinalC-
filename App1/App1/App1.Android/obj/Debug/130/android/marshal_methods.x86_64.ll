; ModuleID = 'obj\Debug\130\android\marshal_methods.x86_64.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


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
@assembly_image_cache_hashes = local_unnamed_addr constant [234 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 53
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 12
	i64 210515253464952879, ; 2: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 42
	i64 232391251801502327, ; 3: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 80
	i64 295915112840604065, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 81
	i64 316157742385208084, ; 5: Xamarin.AndroidX.Core.Core.Ktx.dll => 0x46337caa7dc1b14 => 47
	i64 456145817121827372, ; 6: App1.dll => 0x6548e343353aa2c => 5
	i64 569564398114481256, ; 7: Microsoft.TestPlatform.CoreUtilities => 0x7e77fcd6a52a468 => 9
	i64 634308326490598313, ; 8: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 65
	i64 702024105029695270, ; 9: System.Drawing.Common => 0x9be17343c0e7726 => 110
	i64 720058930071658100, ; 10: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 58
	i64 737318085524959015, ; 11: NuGet.Frameworks => 0xa3b7ae46e2faf27 => 14
	i64 870603111519317375, ; 12: SQLitePCLRaw.lib.e_sqlite3.android => 0xc1500ead2756d7f => 18
	i64 872800313462103108, ; 13: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 52
	i64 940822596282819491, ; 14: System.Transactions => 0xd0e792aa81923a3 => 108
	i64 996343623809489702, ; 15: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 94
	i64 1000557547492888992, ; 16: Mono.Security.dll => 0xde2b1c9cba651a0 => 116
	i64 1120440138749646132, ; 17: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 96
	i64 1301485588176585670, ; 18: SQLitePCLRaw.core => 0x120fce3f338e43c6 => 17
	i64 1315114680217950157, ; 19: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 37
	i64 1425944114962822056, ; 20: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 4
	i64 1518315023656898250, ; 21: SQLitePCLRaw.provider.e_sqlite3 => 0x151223783a354eca => 19
	i64 1624659445732251991, ; 22: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 35
	i64 1628611045998245443, ; 23: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 67
	i64 1636321030536304333, ; 24: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 59
	i64 1672383392659050004, ; 25: Microsoft.Data.Sqlite.dll => 0x17357fd5bfb48e14 => 8
	i64 1743969030606105336, ; 26: System.Memory.dll => 0x1833d297e88f2af8 => 24
	i64 1795316252682057001, ; 27: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 36
	i64 1836611346387731153, ; 28: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 80
	i64 1875917498431009007, ; 29: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 33
	i64 1981742497975770890, ; 30: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 66
	i64 2064708342624596306, ; 31: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x1ca7514c5eecb152 => 101
	i64 2136356949452311481, ; 32: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 71
	i64 2165725771938924357, ; 33: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 40
	i64 2262844636196693701, ; 34: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 52
	i64 2284400282711631002, ; 35: System.Web.Services => 0x1fb3d1f42fd4249a => 114
	i64 2304837677853103545, ; 36: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0x1ffc6da80d5ed5b9 => 79
	i64 2329709569556905518, ; 37: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 62
	i64 2337758774805907496, ; 38: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 28
	i64 2455121377850707897, ; 39: NuGet.Frameworks.dll => 0x221257e2a7424fb9 => 14
	i64 2470498323731680442, ; 40: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 46
	i64 2479423007379663237, ; 41: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 86
	i64 2497223385847772520, ; 42: System.Runtime => 0x22a7eb7046413568 => 29
	i64 2547086958574651984, ; 43: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 32
	i64 2592350477072141967, ; 44: System.Xml.dll => 0x23f9e10627330e8f => 30
	i64 2624866290265602282, ; 45: mscorlib.dll => 0x246d65fbde2db8ea => 13
	i64 2694427813909235223, ; 46: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 75
	i64 2783046991838674048, ; 47: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 28
	i64 2787234703088983483, ; 48: Xamarin.AndroidX.Startup.StartupRuntime => 0x26ae3f31ef429dbb => 82
	i64 2960931600190307745, ; 49: Xamarin.Forms.Core => 0x2917579a49927da1 => 92
	i64 3017704767998173186, ; 50: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 96
	i64 3289520064315143713, ; 51: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 61
	i64 3303437397778967116, ; 52: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 34
	i64 3311221304742556517, ; 53: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 26
	i64 3344514922410554693, ; 54: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 104
	i64 3493805808809882663, ; 55: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 84
	i64 3522470458906976663, ; 56: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 83
	i64 3531994851595924923, ; 57: System.Numerics => 0x31042a9aade235bb => 25
	i64 3571415421602489686, ; 58: System.Runtime.dll => 0x319037675df7e556 => 29
	i64 3716579019761409177, ; 59: netstandard.dll => 0x3393f0ed5c8c5c99 => 106
	i64 3727469159507183293, ; 60: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 78
	i64 3772598417116884899, ; 61: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 53
	i64 3845980214428618329, ; 62: Microsoft.VisualStudio.TestPlatform.ObjectModel.resources => 0x355faaa0ce32ce59 => 1
	i64 3966267475168208030, ; 63: System.Memory => 0x370b03412596249e => 24
	i64 4201423742386704971, ; 64: Xamarin.AndroidX.Core.Core.Ktx => 0x3a4e74a233da124b => 47
	i64 4337444564132831293, ; 65: SQLitePCLRaw.batteries_v2.dll => 0x3c31b2d9ae16203d => 16
	i64 4525561845656915374, ; 66: System.ServiceModel.Internals => 0x3ece06856b710dae => 105
	i64 4636684751163556186, ; 67: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 88
	i64 4759461199762736555, ; 68: Xamarin.AndroidX.Lifecycle.Process.dll => 0x420d00be961cc5ab => 64
	i64 4782108999019072045, ; 69: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 39
	i64 4794310189461587505, ; 70: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 32
	i64 4795410492532947900, ; 71: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 83
	i64 5129462924058778861, ; 72: Microsoft.Data.Sqlite => 0x472f835a350f5ced => 8
	i64 5142919913060024034, ; 73: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 93
	i64 5203618020066742981, ; 74: Xamarin.Essentials => 0x4836f704f0e652c5 => 91
	i64 5205316157927637098, ; 75: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 69
	i64 5348796042099802469, ; 76: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 70
	i64 5376510917114486089, ; 77: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 86
	i64 5408338804355907810, ; 78: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 85
	i64 5415938286181081424, ; 79: Microsoft.VisualStudio.TestPlatform.ObjectModel => 0x4b29472d2942e150 => 11
	i64 5451019430259338467, ; 80: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 45
	i64 5507995362134886206, ; 81: System.Core.dll => 0x4c705499688c873e => 22
	i64 5692067934154308417, ; 82: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 90
	i64 5757522595884336624, ; 83: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 43
	i64 5814345312393086621, ; 84: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 75
	i64 5896680224035167651, ; 85: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 63
	i64 5917160574407189813, ; 86: App1 => 0x521dfa31247ca535 => 5
	i64 6085203216496545422, ; 87: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 94
	i64 6086316965293125504, ; 88: FormsViewGroup.dll => 0x5476f10882baef80 => 6
	i64 6183170893902868313, ; 89: SQLitePCLRaw.batteries_v2 => 0x55cf092b0c9d6f59 => 16
	i64 6319713645133255417, ; 90: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 65
	i64 6401687960814735282, ; 91: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 62
	i64 6504860066809920875, ; 92: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 40
	i64 6548213210057960872, ; 93: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 50
	i64 6591024623626361694, ; 94: System.Web.Services.dll => 0x5b7805f9751a1b5e => 114
	i64 6659513131007730089, ; 95: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 58
	i64 6876862101832370452, ; 96: System.Xml.Linq => 0x5f6f85a57d108914 => 31
	i64 6894844156784520562, ; 97: System.Numerics.Vectors => 0x5faf683aead1ad72 => 26
	i64 7036436454368433159, ; 98: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 60
	i64 7103753931438454322, ; 99: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 57
	i64 7135772949214115721, ; 100: Microsoft.TestPlatform.PlatformAbstractions => 0x63075bb0bbbfb789 => 10
	i64 7488575175965059935, ; 101: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 31
	i64 7608871685949591681, ; 102: Microsoft.TestPlatform.CoreUtilities.resources.dll => 0x6998247c1e8d9081 => 0
	i64 7635363394907363464, ; 103: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 92
	i64 7637365915383206639, ; 104: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 91
	i64 7654504624184590948, ; 105: System.Net.Http => 0x6a3a4366801b8264 => 3
	i64 7735352534559001595, ; 106: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 100
	i64 7820441508502274321, ; 107: System.Data => 0x6c87ca1e14ff8111 => 107
	i64 7836164640616011524, ; 108: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 35
	i64 8044118961405839122, ; 109: System.ComponentModel.Composition => 0x6fa2739369944712 => 113
	i64 8083354569033831015, ; 110: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 61
	i64 8103644804370223335, ; 111: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 109
	i64 8167236081217502503, ; 112: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 7
	i64 8187640529827139739, ; 113: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 103
	i64 8398329775253868912, ; 114: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 44
	i64 8400181818043915251, ; 115: Microsoft.TestPlatform.CoreUtilities.resources => 0x749370db8133dbf3 => 0
	i64 8400357532724379117, ; 116: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 74
	i64 8426919725312979251, ; 117: Xamarin.AndroidX.Lifecycle.Process => 0x74f26ed7aa033133 => 64
	i64 8518412311883997971, ; 118: System.Collections.Immutable => 0x76377add7c28e313 => 21
	i64 8598790081731763592, ; 119: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x77550a055fc61d88 => 55
	i64 8601935802264776013, ; 120: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 85
	i64 8626175481042262068, ; 121: Java.Interop => 0x77b654e585b55834 => 7
	i64 8639588376636138208, ; 122: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 73
	i64 8648495978913578441, ; 123: Microsoft.Win32.Registry.dll => 0x7805a1456889bdc9 => 115
	i64 8684531736582871431, ; 124: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 112
	i64 8727204506373749864, ; 125: Microsoft.TestPlatform.PlatformAbstractions.dll => 0x791d424284987c68 => 10
	i64 8853378295825400934, ; 126: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 99
	i64 8951477988056063522, ; 127: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0x7c3a09cd9ccf5e22 => 77
	i64 9312692141327339315, ; 128: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 90
	i64 9324707631942237306, ; 129: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 36
	i64 9662334977499516867, ; 130: System.Numerics.dll => 0x8617827802b0cfc3 => 25
	i64 9678050649315576968, ; 131: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 46
	i64 9711637524876806384, ; 132: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 70
	i64 9808709177481450983, ; 133: Mono.Android.dll => 0x881f890734e555e7 => 12
	i64 9825649861376906464, ; 134: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 43
	i64 9834056768316610435, ; 135: System.Transactions.dll => 0x8879968718899783 => 108
	i64 9836529246295212050, ; 136: System.Reflection.Metadata => 0x88825f3bbc2ac012 => 27
	i64 9907349773706910547, ; 137: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x897dfa20b758db53 => 55
	i64 9998632235833408227, ; 138: Mono.Security => 0x8ac2470b209ebae3 => 116
	i64 10038780035334861115, ; 139: System.Net.Http.dll => 0x8b50e941206af13b => 3
	i64 10226222362177979215, ; 140: Xamarin.Kotlin.StdLib.Jdk7 => 0x8dead70ebbc6434f => 101
	i64 10229024438826829339, ; 141: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 50
	i64 10321854143672141184, ; 142: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 98
	i64 10376576884623852283, ; 143: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 84
	i64 10406448008575299332, ; 144: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 104
	i64 10430153318873392755, ; 145: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 48
	i64 10847732767863316357, ; 146: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 37
	i64 11023048688141570732, ; 147: System.Core => 0x98f9bc61168392ac => 22
	i64 11037814507248023548, ; 148: System.Xml => 0x992e31d0412bf7fc => 30
	i64 11162124722117608902, ; 149: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 89
	i64 11340910727871153756, ; 150: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 49
	i64 11392833485892708388, ; 151: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 76
	i64 11529969570048099689, ; 152: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 89
	i64 11578238080964724296, ; 153: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 60
	i64 11580057168383206117, ; 154: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 33
	i64 11591352189662810718, ; 155: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0xa0dcc167234c525e => 82
	i64 11597940890313164233, ; 156: netstandard => 0xa0f429ca8d1805c9 => 106
	i64 11672361001936329215, ; 157: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 57
	i64 11739066727115742305, ; 158: SQLite-net.dll => 0xa2e98afdf8575c61 => 15
	i64 11806260347154423189, ; 159: SQLite-net => 0xa3d8433bc5eb5d95 => 15
	i64 12102847907131387746, ; 160: System.Buffers => 0xa7f5f40c43256f62 => 20
	i64 12137774235383566651, ; 161: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 87
	i64 12269460666702402136, ; 162: System.Collections.Immutable.dll => 0xaa45e178506c9258 => 21
	i64 12279246230491828964, ; 163: SQLitePCLRaw.provider.e_sqlite3.dll => 0xaa68a5636e0512e4 => 19
	i64 12451044538927396471, ; 164: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 56
	i64 12466513435562512481, ; 165: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 68
	i64 12487638416075308985, ; 166: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 51
	i64 12538491095302438457, ; 167: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 41
	i64 12550732019250633519, ; 168: System.IO.Compression => 0xae2d28465e8e1b2f => 111
	i64 12700543734426720211, ; 169: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 42
	i64 12828192437253469131, ; 170: Xamarin.Kotlin.StdLib.Jdk8.dll => 0xb206e50e14d873cb => 102
	i64 12963446364377008305, ; 171: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 110
	i64 13129914918964716986, ; 172: Xamarin.AndroidX.Emoji2.dll => 0xb636d40db3fe65ba => 54
	i64 13370592475155966277, ; 173: System.Runtime.Serialization => 0xb98de304062ea945 => 4
	i64 13401370062847626945, ; 174: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 87
	i64 13404347523447273790, ; 175: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 44
	i64 13447930857737371653, ; 176: Microsoft.TestPlatform.CoreUtilities.dll => 0xbaa0a5dd6b734005 => 9
	i64 13454009404024712428, ; 177: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 97
	i64 13465488254036897740, ; 178: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 100
	i64 13491513212026656886, ; 179: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 38
	i64 13572454107664307259, ; 180: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 78
	i64 13647894001087880694, ; 181: System.Data.dll => 0xbd670f48cb071df6 => 107
	i64 13828521679616088467, ; 182: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 99
	i64 13959074834287824816, ; 183: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 56
	i64 13967638549803255703, ; 184: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 93
	i64 13977061573113476558, ; 185: Microsoft.VisualStudio.TestPlatform.ObjectModel.dll => 0xc1f87f727530f5ce => 11
	i64 14124974489674258913, ; 186: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 41
	i64 14172845254133543601, ; 187: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 71
	i64 14245281962029974950, ; 188: App1.Android.dll => 0xc5b16878401385a6 => 2
	i64 14261073672896646636, ; 189: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 76
	i64 14486659737292545672, ; 190: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 63
	i64 14495724990987328804, ; 191: Xamarin.AndroidX.ResourceInspection.Annotation => 0xc92b2913e18d5d24 => 79
	i64 14644440854989303794, ; 192: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 69
	i64 14792063746108907174, ; 193: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 97
	i64 14852515768018889994, ; 194: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 49
	i64 14987728460634540364, ; 195: System.IO.Compression.dll => 0xcfff1ba06622494c => 111
	i64 14988210264188246988, ; 196: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 51
	i64 15150743910298169673, ; 197: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xd2424150783c3149 => 77
	i64 15279429628684179188, ; 198: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 103
	i64 15370334346939861994, ; 199: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 48
	i64 15582737692548360875, ; 200: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 67
	i64 15609085926864131306, ; 201: System.dll => 0xd89e9cf3334914ea => 23
	i64 15710114879900314733, ; 202: Microsoft.Win32.Registry => 0xda058a3f5d096c6d => 115
	i64 15777549416145007739, ; 203: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 81
	i64 15810740023422282496, ; 204: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 95
	i64 15989880706848381038, ; 205: App1.Android => 0xdde777c8ec91d86e => 2
	i64 16154507427712707110, ; 206: System => 0xe03056ea4e39aa26 => 23
	i64 16330368091231878554, ; 207: Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll => 0xe2a11f41c93ffd9a => 1
	i64 16423015068819898779, ; 208: Xamarin.Kotlin.StdLib.Jdk8 => 0xe3ea453135e5c19b => 102
	i64 16565028646146589191, ; 209: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 113
	i64 16621146507174665210, ; 210: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 45
	i64 16677317093839702854, ; 211: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 74
	i64 16755018182064898362, ; 212: SQLitePCLRaw.core.dll => 0xe885c843c330813a => 17
	i64 16822611501064131242, ; 213: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 109
	i64 16833383113903931215, ; 214: mscorlib => 0xe99c30c1484d7f4f => 13
	i64 17024911836938395553, ; 215: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 34
	i64 17031351772568316411, ; 216: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 72
	i64 17037200463775726619, ; 217: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 59
	i64 17544493274320527064, ; 218: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 39
	i64 17704177640604968747, ; 219: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 68
	i64 17710060891934109755, ; 220: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 66
	i64 17838668724098252521, ; 221: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 20
	i64 17882897186074144999, ; 222: FormsViewGroup => 0xf82cd03e3ac830e7 => 6
	i64 17891337867145587222, ; 223: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 98
	i64 17892495832318972303, ; 224: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 95
	i64 17928294245072900555, ; 225: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 112
	i64 18116111925905154859, ; 226: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 38
	i64 18121036031235206392, ; 227: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 72
	i64 18129453464017766560, ; 228: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 105
	i64 18260797123374478311, ; 229: Xamarin.AndroidX.Emoji2 => 0xfd6b623bde35f3e7 => 54
	i64 18305135509493619199, ; 230: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 73
	i64 18370042311372477656, ; 231: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0xfeef80274e4094d8 => 18
	i64 18380184030268848184, ; 232: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 88
	i64 18439108438687598470 ; 233: System.Reflection.Metadata.dll => 0xffe4df6e2ee1c786 => 27
], align 16
@assembly_image_cache_indices = local_unnamed_addr constant [234 x i32] [
	i32 53, i32 12, i32 42, i32 80, i32 81, i32 47, i32 5, i32 9, ; 0..7
	i32 65, i32 110, i32 58, i32 14, i32 18, i32 52, i32 108, i32 94, ; 8..15
	i32 116, i32 96, i32 17, i32 37, i32 4, i32 19, i32 35, i32 67, ; 16..23
	i32 59, i32 8, i32 24, i32 36, i32 80, i32 33, i32 66, i32 101, ; 24..31
	i32 71, i32 40, i32 52, i32 114, i32 79, i32 62, i32 28, i32 14, ; 32..39
	i32 46, i32 86, i32 29, i32 32, i32 30, i32 13, i32 75, i32 28, ; 40..47
	i32 82, i32 92, i32 96, i32 61, i32 34, i32 26, i32 104, i32 84, ; 48..55
	i32 83, i32 25, i32 29, i32 106, i32 78, i32 53, i32 1, i32 24, ; 56..63
	i32 47, i32 16, i32 105, i32 88, i32 64, i32 39, i32 32, i32 83, ; 64..71
	i32 8, i32 93, i32 91, i32 69, i32 70, i32 86, i32 85, i32 11, ; 72..79
	i32 45, i32 22, i32 90, i32 43, i32 75, i32 63, i32 5, i32 94, ; 80..87
	i32 6, i32 16, i32 65, i32 62, i32 40, i32 50, i32 114, i32 58, ; 88..95
	i32 31, i32 26, i32 60, i32 57, i32 10, i32 31, i32 0, i32 92, ; 96..103
	i32 91, i32 3, i32 100, i32 107, i32 35, i32 113, i32 61, i32 109, ; 104..111
	i32 7, i32 103, i32 44, i32 0, i32 74, i32 64, i32 21, i32 55, ; 112..119
	i32 85, i32 7, i32 73, i32 115, i32 112, i32 10, i32 99, i32 77, ; 120..127
	i32 90, i32 36, i32 25, i32 46, i32 70, i32 12, i32 43, i32 108, ; 128..135
	i32 27, i32 55, i32 116, i32 3, i32 101, i32 50, i32 98, i32 84, ; 136..143
	i32 104, i32 48, i32 37, i32 22, i32 30, i32 89, i32 49, i32 76, ; 144..151
	i32 89, i32 60, i32 33, i32 82, i32 106, i32 57, i32 15, i32 15, ; 152..159
	i32 20, i32 87, i32 21, i32 19, i32 56, i32 68, i32 51, i32 41, ; 160..167
	i32 111, i32 42, i32 102, i32 110, i32 54, i32 4, i32 87, i32 44, ; 168..175
	i32 9, i32 97, i32 100, i32 38, i32 78, i32 107, i32 99, i32 56, ; 176..183
	i32 93, i32 11, i32 41, i32 71, i32 2, i32 76, i32 63, i32 79, ; 184..191
	i32 69, i32 97, i32 49, i32 111, i32 51, i32 77, i32 103, i32 48, ; 192..199
	i32 67, i32 23, i32 115, i32 81, i32 95, i32 2, i32 23, i32 1, ; 200..207
	i32 102, i32 113, i32 45, i32 74, i32 17, i32 109, i32 13, i32 34, ; 208..215
	i32 72, i32 59, i32 39, i32 68, i32 66, i32 20, i32 6, i32 98, ; 216..223
	i32 95, i32 112, i32 38, i32 72, i32 105, i32 54, i32 73, i32 18, ; 224..231
	i32 88, i32 27 ; 232..233
], align 16

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
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
], align 16; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
