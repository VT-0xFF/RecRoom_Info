// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 219 (plus referenced enums)

// --------------------------------------------------------------------------
// ACGONBPEKDK
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.Auth]
public class ACGONBPEKDK
{
    public List<OHHMJPKLJAJ> <AMPBJLEBJKP>k__BackingField;    // 0x0x10
    public AHJBPGOPDGN <JDPHBIBLBMD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ADHBFNJDEOI
//   REQUEST  POST   api/challenge/v2/updateProgress   [Service.WWW]
public class ADHBFNJDEOI
{
    public int <PPCAMFAJOML>k__BackingField;    // 0x0x10
    public int <LMEIOKJLBGL>k__BackingField;    // 0x0x14
    public string <DLBBICCPICB>k__BackingField;    // 0x0x18
    public bool <IKBOINJGKFM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AHJBPGOPDGN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AHJBPGOPDGN
{
    Success = 0,
    HasModeratorClosedEvent = 1,
    DoesNotExist = 2,
    PlayerDoesNotExist = 3,
    RoomDoesNotExist = 4,
    StatusUnchanged = 5,
    PrivateEvent = 6,
    SomethingWentWrong = 7,
    DoesNotOwnRoom = 8,
    ResponseDoesNotExist = 9,
    PlayerAlreadyInvited = 10,
    EventDatesInvalid = 11,
    EventTooLong = 12,
    EventTooShort = 13,
    InappropriateName = 14,
    InappropriateDescription = 15,
    SomeInvitesFailed = 16,
    CannotInviteJunior = 17,
    EventCountLimitReached = 18,
    DoesNotOwnEvent = 19,
    UnregisteredOrJuniorNotAllowed = 20,
    InvalidClubPermissions = 21,
    ImageDoesNotExist = 22,
    SubRoomDoesNotExist = 23,
    DoesNotOwnSubRoom = 24,
    ModifyTagsFailed = 25,
    RoomCapacityTooLow = 26,
    BroadcastEventNotMultiInstance = 27,
    PlayerNotAllowedToCreateMultiInstanceEvents = 28,
    PlayerBannedFromEventCreation = 29,
    EventIsModerationClosed = 30,
    EventIsModerationPendingReview = 31,
    InvalidRecurringEventSchedule = 32,
    EventIsInModerationBlockedRoom = 33,
    JuniorsCannotCreateEvents = 34,
}

// --------------------------------------------------------------------------
// AHPLGAEAHAI
//   REQUEST  POST   api/customAvatarItems   [Service.Auth]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
public class AHPLGAEAHAI
{
    public LPJFHMKCNBC <LJCCLCCDKMD>k__BackingField;    // 0x0x10
    public string <LNFIPONDGNG>k__BackingField;    // 0x0x18
    public int? <GDJDNOOEPGK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AIDCCFPBGMO
//   (not directly referenced by a detected call)
public class AIDCCFPBGMO
{
    public int <LGDLJJCELFG>k__BackingField;    // 0x0x10
    public GNLHLFBJJHN <LBGEGKNDKBB>k__BackingField;    // 0x0x14
    public List<EGAIIAAGEPF> <MKECFGHBBGH>k__BackingField;    // 0x0x18
    public List<EGAIIAAGEPF> <EOOPBBIMJIJ>k__BackingField;    // 0x0x20
    public bool <AJFPCLEEBFC>k__BackingField;    // 0x0x28
    public DateTime? <EGLKBDICOIK>k__BackingField;    // 0x0x30
    public DateTime? <LBHNHBIPEEA>k__BackingField;    // 0x0x40
    public DateTime? <APLGHAMHJNL>k__BackingField;    // 0x0x50
    public bool <LEPNKCCDIDB>k__BackingField;    // 0x0x60
    public bool <BNKNAIBPDKD>k__BackingField;    // 0x0x61
}

// --------------------------------------------------------------------------
// AJOOKAHLIOB
//   RESPONSE GET    api/inventions/   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/personaldetails/{dMNHJOOHDEC}   [Service.Auth]
public class AJOOKAHLIOB
{
    public bool <KCIHBOLKKKG>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// AKALHCIPNBC
//   RESPONSE POST   api/PlayerCheer/v1/create   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v1/instantKick   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v3/create   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v3/voteToKick   [Service.Auth]
//   RESPONSE POST   api/clubreporting/v1/report   [Service.?]
//   RESPONSE POST   api/inventions/v1/report   [Service.Auth]
//   RESPONSE POST   api/playerevents/v1/report   [Service.Auth]
//   RESPONSE POST   api/relationships/sendfriendintroductions   [Service.Auth]
//   RESPONSE POST   api/rooms/v2/report   [Service.Auth]
//   RESPONSE POST   api/screensharereports/v1/report   [Service.?]
public class AKALHCIPNBC
{
    public bool <MCCJONFEFGE>k__BackingField;    // 0x0x10
    public string <IBNGLMMANGE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ANOHKHLGLDN
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.WWW]
public class ANOHKHLGLDN
{
    public int <PPCAMFAJOML>k__BackingField;    // 0x0x10
    public string <GIFJEHBOGFD>k__BackingField;    // 0x0x18
    public List<ECAMNOAGDOH> <HOJIKDIBCMJ>k__BackingField;    // 0x0x20
    public KABNEJAHOGN <IPJCCKNEALJ>k__BackingField;    // 0x0x28
    public string <CNNEOIMKINE>k__BackingField;    // 0x0x30
    public DateTime <CECDAJOPBKC>k__BackingField;    // 0x0x38
    public DateTime <LNBKKPOJNBH>k__BackingField;    // 0x0x40
    public DateTime <JAOPDAGLBMC>k__BackingField;    // 0x0x48
    public bool? <ONKCNOBGLIE>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// APKJCKDEKNH
//   RESPONSE POST   api/inventions/v1/cheer   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/delete   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/update   [Service.Auth]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.Auth]
//   RESPONSE GET    api/inventions/v3/publish   [Service.Matchmaking]
//   RESPONSE POST   api/inventions/v6/addversion   [Service.Notifications]
//   RESPONSE POST   api/inventions/v7/save   [Service.?]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.WWW]
public class APKJCKDEKNH
{
    public CGNJKENMDBP <GKJJIAJDEMJ>k__BackingField;    // 0x0x10
    public DGBANILGEPE <IIFBEKPHCHL>k__BackingField;    // 0x0x18
    public HENBMDOGANE <MPDBLPLINAM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// APNAFILAHAH
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Matchmaking]
public class APNAFILAHAH
{
    public Guid <GPPHPGDMOBL>k__BackingField;    // 0x0x10
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x20
    public string <LGIGELLKDPH>k__BackingField;    // 0x0x28
    public DateTime <CECDAJOPBKC>k__BackingField;    // 0x0x30
    public DateTime? <HBHDANJLEBC>k__BackingField;    // 0x0x38
    public List<LEPHJBAEIGO> <MGFOCMMFGJJ>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// BCOIKGBHHHA
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs   [Service.Notifications]
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems/v2   [Service.Notifications]
public class BCOIKGBHHHA
{
    public Dictionary<string, CPOGOCPFLFL> <ICPEHADFFIO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// BCOJLMKJECJ
//   REQUEST  POST   api/roomkeys/v1/awardbulk   [Service.WWW]
public class BCOJLMKJECJ
{
    public long <NHHDMBJICFB>k__BackingField;    // 0x0x10
    public int <PFAELLHPALI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BDBEIGDIOBJ
//   RESPONSE GET    api/config/v2   [Service.Auth]
public class BDBEIGDIOBJ
{
    public Dictionary<int, int> <DFBJEJFKJJH>k__BackingField;    // 0x0x10
    public List<NMJBIMCHLFG> <EOGCCFLDPFP>k__BackingField;    // 0x0x18
    public NKEONDHCGCL[][] <DBAKMOIICLN>k__BackingField;    // 0x0x20
    public EGCEDCJCACE <KGOFLNPHPOK>k__BackingField;    // 0x0x28
    public IBADOPFEFNE <NPLFJALGHIJ>k__BackingField;    // 0x0x30
    public KCAILHAGLIC <LECIPFOJIHF>k__BackingField;    // 0x0x38
    public MCNKEPHJOML <NPNIIFJKGCN>k__BackingField;    // 0x0x40
    public DHMOENGNBKM <BBHGEMIBHJD>k__BackingField;    // 0x0x48
    public string <IKFNECJMBDC>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// BFNHPOLKGEI
//   (not directly referenced by a detected call)
public class BFNHPOLKGEI
{
    public DateTime <GMLBHPGIMLP>k__BackingField;    // 0x0x10
    public string <GFFCEIONJAB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BNMJDMDMHFM
//   RESPONSE GET    api/inventions/v1/details   [Service.Auth]
public class BNMJDMDMHFM
{
    public List<KHNAEGAJPKP> <GKKLMNIJLJL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// BNNNMOMOCDJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BNNNMOMOCDJ
{
    NonPurchasedNotUsableInP2P = -2,
    NonPurchasedDefault = -1,
    SteamPurchased = 0,
    OculusPurchased = 1,
    PlayStationPurchased = 2,
    MicrosoftPurchased = 3,
    RecNetPurchased = 4,
    IOSPurchased = 5,
    GooglePlayPurchased = 6,
    PicoPurchased = 8,
    ToasterPurchased = 9,
    PlayStationNonPurchasedP2P = 100,
    NonPlayStationNonPurchasedP2P = 101,
    NonPurchasedEarnedByP2P = 1000,
    NonPurchasedEarnedByP2Pv2 = 1001,
}

// --------------------------------------------------------------------------
// BOMMDEJELFJ
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.WWW]
public class BOMMDEJELFJ
{
    public int <GFBAJMHIMIO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// Backtrace.Unity.Model.BacktraceResult
//   (not directly referenced by a detected call)
public class BacktraceResult
{
    public string message;    // 0x0x10
    public string response;    // 0x0x18
    public BacktraceResultStatus Status;    // 0x0x20
    public string _rxId;    // 0x0x28
}

// --------------------------------------------------------------------------
// BestHTTP.HTTPRequest
//   (not directly referenced by a detected call)
public class HTTPRequest
{
    public Uri <Uri>k__BackingField;    // 0x0x10
    public HTTPMethods <MethodType>k__BackingField;    // 0x0x18
    public byte[] <RawData>k__BackingField;    // 0x0x20
    public Stream <UploadStream>k__BackingField;    // 0x0x28
    public bool <DisposeUploadStream>k__BackingField;    // 0x0x30
    public bool <UseUploadStreamLength>k__BackingField;    // 0x0x31
    public OnUploadProgressDelegate OnUploadProgress;    // 0x0x38
    public int <MaxFragmentQueueLength>k__BackingField;    // 0x0x40
    public OnRequestFinishedDelegate <Callback>k__BackingField;    // 0x0x48
    public OnDownloadProgressDelegate OnProgress;    // 0x0x50
    public OnRequestFinishedDelegate OnUpgraded;    // 0x0x58
    public bool <DisableRetry>k__BackingField;    // 0x0x60
    public bool <IsRedirected>k__BackingField;    // 0x0x61
    public Uri <RedirectUri>k__BackingField;    // 0x0x68
    public HTTPResponse <Response>k__BackingField;    // 0x0x70
    public HTTPResponse <ProxyResponse>k__BackingField;    // 0x0x78
    public Exception <Exception>k__BackingField;    // 0x0x80
    public object <Tag>k__BackingField;    // 0x0x88
    public Credentials <Credentials>k__BackingField;    // 0x0x90
    public Proxy <Proxy>k__BackingField;    // 0x0x98
    public int <MaxRedirects>k__BackingField;    // 0x0xA0
    public bool <UseAlternateSSL>k__BackingField;    // 0x0xA4
    public bool <IsCookiesEnabled>k__BackingField;    // 0x0xA5
    public List<Cookie> customCookies;    // 0x0xA8
    public HTTPFormUsage <FormUsage>k__BackingField;    // 0x0xB0
    public HTTPRequestStates <State>k__BackingField;    // 0x0xB4
    public int <RedirectCount>k__BackingField;    // 0x0xB8
    public Func<HTTPRequest, X509Certificate, X509Chain, bool> CustomCertificationValidator;    // 0x0xC0
    public TimeSpan <ConnectTimeout>k__BackingField;    // 0x0xC8
    public TimeSpan <Timeout>k__BackingField;    // 0x0xD0
    public bool <EnableTimoutForStreaming>k__BackingField;    // 0x0xD8
    public bool <EnableSafeReadOnUnknownContentLength>k__BackingField;    // 0x0xD9
    public int <Priority>k__BackingField;    // 0x0xDC
    public ICertificateVerifyer <CustomCertificateVerifyer>k__BackingField;    // 0x0xE0
    public IClientCredentialsProvider <CustomClientCredentialsProvider>k__BackingField;    // 0x0xE8
    public List<string> <CustomTLSServerNameList>k__BackingField;    // 0x0xF0
    public SupportedProtocols <ProtocolHandler>k__BackingField;    // 0x0xF8
    public OnBeforeRedirectionDelegate onBeforeRedirection;    // 0x0x100
    public OnBeforeHeaderSendDelegate _onBeforeHeaderSend;    // 0x0x108
    public Action<HTTPRequest, Stream> OnSendingHeaders;    // 0x0x110
    public bool <TryToMinimizeTCPLatency>k__BackingField;    // 0x0x118
    public long <Downloaded>k__BackingField;    // 0x0x120
    public long <DownloadLength>k__BackingField;    // 0x0x128
    public bool <DownloadProgressChanged>k__BackingField;    // 0x0x130
    public long <Uploaded>k__BackingField;    // 0x0x138
    public long <UploadLength>k__BackingField;    // 0x0x140
    public bool <UploadProgressChanged>k__BackingField;    // 0x0x148
    public bool isKeepAlive;    // 0x0x149
    public bool disableCache;    // 0x0x14A
    public bool cacheOnly;    // 0x0x14B
    public int streamFragmentSize;    // 0x0x14C
    public bool useStreaming;    // 0x0x150
    public Dictionary<string, List<string>> <Headers>k__BackingField;    // 0x0x158
    public HTTPFormBase FieldCollector;    // 0x0x160
    public HTTPFormBase FormImpl;    // 0x0x168
}

// --------------------------------------------------------------------------
// BestHTTP.HTTPResponse
//   (not directly referenced by a detected call)
public class HTTPResponse
{
    public int <VersionMajor>k__BackingField;    // 0x0x10
    public int <VersionMinor>k__BackingField;    // 0x0x14
    public int <StatusCode>k__BackingField;    // 0x0x18
    public string <Message>k__BackingField;    // 0x0x20
    public bool <IsStreamed>k__BackingField;    // 0x0x28
    public bool <IsStreamingFinished>k__BackingField;    // 0x0x29
    public bool <IsFromCache>k__BackingField;    // 0x0x2A
    public HTTPCacheFileInfo <CacheFileInfo>k__BackingField;    // 0x0x30
    public bool <IsCacheOnly>k__BackingField;    // 0x0x38
    public Dictionary<string, List<string>> <Headers>k__BackingField;    // 0x0x40
    public byte[] <Data>k__BackingField;    // 0x0x48
    public int <DataLength>k__BackingField;    // 0x0x50
    public bool <IsUpgraded>k__BackingField;    // 0x0x54
    public List<Cookie> <Cookies>k__BackingField;    // 0x0x58
    public string dataAsText;    // 0x0x60
    public Texture2D texture;    // 0x0x68
    public bool <IsClosedManually>k__BackingField;    // 0x0x70
    public HTTPRequest baseRequest;    // 0x0x78
    public Stream Stream;    // 0x0x80
    public List<ValueTuple<byte[], int>> streamedFragments;    // 0x0x88
    public object SyncRoot;    // 0x0x90
    public byte[] fragmentBuffer;    // 0x0x98
    public int fragmentBufferDataLength;    // 0x0xA0
    public Stream cacheStream;    // 0x0xA8
    public int allFragmentSize;    // 0x0xB0
    public BufferPoolMemoryStream decompressorInputStream;    // 0x0xB8
    public BufferPoolMemoryStream decompressorOutputStream;    // 0x0xC0
    public GZipStream decompressorGZipStream;    // 0x0xC8
    public AutoResetEvent fragmentWaitEvent;    // 0x0xD0
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CertResponse
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class CertResponse : Asn1Encodable
{
    public DerInteger certReqId;    // 0x0x10
    public PkiStatusInfo status;    // 0x0x18
    public CertifiedKeyPair certifiedKeyPair;    // 0x0x20
    public Asn1OctetString rspInfo;    // 0x0x28
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class CertRequest : Asn1Encodable
{
    public DerInteger certReqId;    // 0x0x10
    public CertTemplate certTemplate;    // 0x0x18
    public Controls controls;    // 0x0x20
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class BasicOcspResponse : Asn1Encodable
{
    public ResponseData tbsResponseData;    // 0x0x10
    public AlgorithmIdentifier signatureAlgorithm;    // 0x0x18
    public DerBitString signature;    // 0x0x20
    public Asn1Sequence certs;    // 0x0x28
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.OcspRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class OcspRequest : Asn1Encodable
{
    public TbsRequest tbsRequest;    // 0x0x10
    public Signature optionalSignature;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.OcspResponse
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class OcspResponse : Asn1Encodable
{
    public OcspResponseStatus responseStatus;    // 0x0x10
    public ResponseBytes responseBytes;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.Request
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class Request : Asn1Encodable
{
    public CertID reqCert;    // 0x0x10
    public X509Extensions singleRequestExtensions;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.SingleResponse
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class SingleResponse : Asn1Encodable
{
    public CertID certID;    // 0x0x10
    public CertStatus certStatus;    // 0x0x18
    public DerGeneralizedTime thisUpdate;    // 0x0x20
    public DerGeneralizedTime nextUpdate;    // 0x0x28
    public X509Extensions singleExtensions;    // 0x0x30
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.TbsRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class TbsRequest : Asn1Encodable
{
    public DerInteger version;    // 0x0x10
    public GeneralName requestorName;    // 0x0x18
    public Asn1Sequence requestList;    // 0x0x20
    public X509Extensions requestExtensions;    // 0x0x28
    public bool versionSet;    // 0x0x30
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.CertificationRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class CertificationRequest : Asn1Encodable
{
    public CertificationRequestInfo reqInfo;    // 0x0x10
    public AlgorithmIdentifier sigAlgId;    // 0x0x18
    public DerBitString sigBits;    // 0x0x20
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockResult
//   (not directly referenced by a detected call)
public class IBlockResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators.DefaultSignatureResult
//   (not directly referenced by a detected call)
public class DefaultSignatureResult
{
    public ISigner mSigner;    // 0x0x10
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators.DefaultVerifierResult
//   (not directly referenced by a detected call)
public class DefaultVerifierResult
{
    public ISigner mSigner;    // 0x0x10
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.CertificateRequest
//   (not directly referenced by a detected call)
public class CertificateRequest
{
    public byte[] mCertificateTypes;    // 0x0x10
    public IList mSupportedSignatureAlgorithms;    // 0x0x18
    public IList mCertificateAuthorities;    // 0x0x20
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest
//   (not directly referenced by a detected call)
public class CertificateStatusRequest
{
    public byte mStatusType;    // 0x0x10
    public object mRequest;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.OcspStatusRequest
//   (not directly referenced by a detected call)
public class OcspStatusRequest
{
    public IList mResponderIDList;    // 0x0x10
    public X509Extensions mRequestExtensions;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.CertificationRequest
//   (not directly referenced by a detected call)
public class Pkcs10CertificationRequest : CertificationRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCertPathBuilderResult
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCertPathValidatorResult
//   (not directly referenced by a detected call)
public class PkixCertPathBuilderResult : PkixCertPathValidatorResult
{
    public PkixCertPath certPath;    // 0x0x28
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCertPathValidatorResult
//   (not directly referenced by a detected call)
public class PkixCertPathValidatorResult
{
    public TrustAnchor trustAnchor;    // 0x0x10
    public PkixPolicyNode policyTree;    // 0x0x18
    public AsymmetricKeyParameter subjectPublicKey;    // 0x0x20
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp.TimeStampRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509ExtensionBase
//   (not directly referenced by a detected call)
public class TimeStampRequest : X509ExtensionBase
{
    public TimeStampReq req;    // 0x0x10
    public X509Extensions extensions;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp.TimeStampResponse
//   (not directly referenced by a detected call)
public class TimeStampResponse
{
    public TimeStampResp resp;    // 0x0x10
    public TimeStampToken timeStampToken;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SignalRCore.Messages.NegotiationResult
//   (not directly referenced by a detected call)
public class NegotiationResult
{
    public string <ConnectionId>k__BackingField;    // 0x0x10
    public List<SupportedTransport> <SupportedTransports>k__BackingField;    // 0x0x18
    public Uri <Url>k__BackingField;    // 0x0x20
    public string <AccessToken>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// BestHTTP.WebSocket.WebSocketResponse
// base   : BestHTTP.HTTPResponse
//   (not directly referenced by a detected call)
public class WebSocketResponse : HTTPResponse
{
    public WebSocket <WebSocket>k__BackingField;    // 0x0xD8
    public Action<WebSocketResponse, string> OnText;    // 0x0xE0
    public Action<WebSocketResponse, byte[]> OnBinary;    // 0x0xE8
    public Action<WebSocketResponse, WebSocketFrameReader> OnIncompleteFrame;    // 0x0xF0
    public Action<WebSocketResponse, ushort, string> OnClosed;    // 0x0xF8
    public TimeSpan <PingFrequnecy>k__BackingField;    // 0x0x100
    public ushort <MaxFragmentSize>k__BackingField;    // 0x0x108
    public int _bufferedAmount;    // 0x0x10C
    public int <Latency>k__BackingField;    // 0x0x110
    public List<WebSocketFrameReader> IncompleteFrames;    // 0x0x118
    public List<WebSocketFrameReader> CompletedFrames;    // 0x0x120
    public List<WebSocketFrameReader> frameCache;    // 0x0x128
    public WebSocketFrameReader CloseFrame;    // 0x0x130
    public object FrameLock;    // 0x0x150
    public object SendLock;    // 0x0x158
    public List<WebSocketFrame> unsentFrames;    // 0x0x160
    public AutoResetEvent newFrameSignal;    // 0x0x168
    public bool sendThreadCreated;    // 0x0x170
    public bool closeSent;    // 0x0x171
    public bool closed;    // 0x0x172
    public DateTime lastPing;    // 0x0x178
    public DateTime lastMessage;    // 0x0x180
    public CircularBuffer<int> rtts;    // 0x0x188
}

// --------------------------------------------------------------------------
// CAEEMMEACAG
//   RESPONSE GET    api/config/v1/backtrace   [Service.Auth]
public class CAEEMMEACAG
{
    public int <KJLHDFHILFB>k__BackingField;    // 0x0x10
    public int <AGDDLOKJCND>k__BackingField;    // 0x0x14
    public float <NHIHCBHHBNP>k__BackingField;    // 0x0x18
    public int <DDMKJMGHBIC>k__BackingField;    // 0x0x1C
    public int <NHOMBNLDCAA>k__BackingField;    // 0x0x20
    public int <DLFDOICGJBA>k__BackingField;    // 0x0x24
    public int <HJKPJAHFEAN>k__BackingField;    // 0x0x28
    public string <OFNGNEEFCHP>k__BackingField;    // 0x0x30
    public string <LGAAHFOBGEG>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// CAGJDMEEOLK
//   RESPONSE POST   api/chatreport/createChatReport   [Service.?]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.WWW]
//   RESPONSE POST   api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.Auth]
//   RESPONSE DELETE api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.Auth]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.Data]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.?]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.WWW]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.WWW]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.WWW]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.WWW]
//   RESPONSE DELETE api/keepsakes   [Service.Auth]
//   RESPONSE DELETE api/keepsakes/{kODBMCEMBGH}   [Service.Auth]
//   RESPONSE POST   api/playerwarnings   [Service.Auth]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.Auth]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.WWW]
public class CAGJDMEEOLK
{
    public bool <MCCJONFEFGE>k__BackingField;    // 0x0x10
    public string <IJBKJEGKPEA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CAMKALDFMJG
//   (not directly referenced by a detected call)
public class CAMKALDFMJG
{
    public long <NHHDMBJICFB>k__BackingField;    // 0x0x10
    public Guid <EHGKJPEMIIG>k__BackingField;    // 0x0x18
    public long <AMMGFAOLMNI>k__BackingField;    // 0x0x28
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x30
    public string <NIMDKMGPONB>k__BackingField;    // 0x0x38
    public int <FPPLDFPFALA>k__BackingField;    // 0x0x40
    public Guid? <JHBCHIMILBD>k__BackingField;    // 0x0x44
    public DateTime <GMLBHPGIMLP>k__BackingField;    // 0x0x58
    public string <LGIGELLKDPH>k__BackingField;    // 0x0x60
    public JMGFFIKDGLJ <LBGEGKNDKBB>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// CCGAHCNMOGI
//   RESPONSE GET    api/config/v1/azurespeech   [Service.Auth]
public class CCGAHCNMOGI
{
    public bool <DILBMGKNOLI>k__BackingField;    // 0x0x10
    public string <HBKEGNDKJJC>k__BackingField;    // 0x0x18
    public string <FPLAOBEOFCM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CCLOFCEOEPL
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class CCLOFCEOEPL
{
    public Dictionary<Guid, OJLCCJBGJAF> <ALNOEJMNMNA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// CDINFLFNMGC
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.WWW]
public class CDINFLFNMGC
{
    public List<DKCMMBDHKFJ> <OHLDALHOJBD>k__BackingField;    // 0x0x10
    public string <JILBGFHLNDP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CEGKDIEDEMO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CEGKDIEDEMO
{
    None = -1,
    Default = 0,
    First_Activity = 1,
    Game_Drop = 2,
    All_Daily_Challenges_Complete = 3,
    All_Weekly_Challenge_Complete = 4,
    Daily_Challenge_Complete = 5,
    Weekly_Challenge_Complete = 6,
    Unassigned_Equipment = 10,
    Unassigned_Avatar = 11,
    Unassigned_Consumable = 12,
    Reacquisition = 20,
    Membership = 21,
    NUX_TokensAndDressUp = 30,
    NUX_Experiment1 = 31,
    NUX_Experiment2 = 32,
    NUX_Experiment3 = 33,
    NUX_Experiment4 = 34,
    NUX_Experiment5 = 35,
    GameRewards = 50,
    GameRewards_Tokens = 51,
    GameRewards_Tokens_Experiment_Override = 52,
    LevelUp = 100,
    Purchased_Gift_A = 500,
    Purchased_Gift_B = 501,
    Purchased_Gift_C = 502,
    Purchased_Gift_D = 503,
    Holiday = 1000,
    Contest = 1001,
    Promotion = 1002,
    LimitedTime = 1003,
    LimitedTimeEvent = 1004,
    Deprecated = 1100,
    RecRoyale = 1200,
    Friendotron_Gift = 1300,
    DEPRECATED_Paintball_ClearCut = 2000,
    DEPRECATED_Paintball_Homestead = 2001,
    DEPRECATED_Paintball_Quarry = 2002,
    DEPRECATED_Paintball_River = 2003,
    DEPRECATED_Paintball_Dam = 2004,
    DEPRECATED_Paintball_DriveIn = 2005,
    Paintball_ClearCut = 2010,
    Paintball_Homestead = 2011,
    Paintball_Quarry = 2012,
    Paintball_River = 2013,
    Paintball_Dam = 2014,
    Paintball_DriveIn = 2015,
    DEPRECATED_Discgolf_Propulsion = 3000,
    DEPRECATED_Discgolf_Lake = 3001,
    Discgolf_Propulsion = 3010,
    Discgolf_Lake = 3011,
    Discgolf_Mode_CoopCatch = 3500,
    Quest_Goblin_A = 4000,
    Quest_Goblin_B = 4001,
    Quest_Goblin_C = 4002,
    Quest_Goblin_S = 4003,
    Quest_Goblin_Consumable = 4004,
    Quest_Cauldron_A = 4010,
    Quest_Cauldron_B = 4011,
    Quest_Cauldron_C = 4012,
    Quest_Cauldron_S = 4013,
    Quest_Cauldron_Consumable = 4014,
    Quest_Pirate1_A = 4100,
    Quest_Pirate1_B = 4101,
    Quest_Pirate1_C = 4102,
    Quest_Pirate1_S = 4103,
    Quest_Pirate1_X = 4104,
    Quest_Pirate1_Consumable = 4105,
    Quest_Dracula1_A = 4200,
    Quest_Dracula1_B = 4201,
    Quest_Dracula1_C = 4202,
    Quest_Dracula1_S = 4203,
    Quest_Dracula1_X = 4204,
    Quest_Dracula1_Consumable = 4205,
    Quest_Dracula1_SS = 4206,
    Quest_SciFi_A = 4500,
    Quest_SciFi_B = 4501,
    Quest_SciFi_C = 4502,
    Quest_SciFi_S = 4503,
    Quest_Scifi_Consumable = 4504,
    DEPRECATED_Charades = 5000,
    Charades = 5001,
    DEPRECATED_Soccer = 6000,
    Soccer = 6001,
    DEPRECATED_Paddleball = 7000,
    Paddleball = 7001,
    DEPRECATED_Dodgeball = 8000,
    Dodgeball = 8001,
    DEPRECATED_Lasertag = 9000,
    Lasertag = 9001,
    DEPRECATED_Bowling = 10000,
    Bowling = 10001,
    StuntRunner_TheMainEvent_A = 11000,
    StuntRunner_TheMainEvent_B = 11001,
    StuntRunner_TheMainEvent_C = 11002,
    StuntRunner_TheMainEvent_D = 11003,
    StuntRunner_TheMainEvent_S = 11004,
    StuntRunner_TheMainEvent_X = 11005,
    StuntRunner_TheMainEvent_Consumable = 11006,
    StuntRunner_TheMainEvent_SS = 11007,
    RecRally = 12000,
    Showdown_A = 12100,
    Showdown_B = 12101,
    Showdown_C = 12102,
    ProgressionEvent = 13000,
    Store_LaserTag = 100000,
    Store_RecCenter = 100010,
    Consumable = 110000,
    Token = 110100,
    Punchcard_Challenge_Complete = 110200,
    All_Punchcard_Challenges_Complete = 110201,
    New_Player_Checklist_Item_Complete = 110300,
    Commerce_Purchase = 200000,
    Gift_Card_Redemption = 210000,
}

// --------------------------------------------------------------------------
// CGNJKENMDBP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CGNJKENMDBP
{
    Success = 0,
    InvalidParameters = 1,
    PlayerCannotUpload = 2,
    DuplicateName = 3,
    NameTooShort = 4,
    NameTooLong = 5,
    NotCreator = 6,
    DoesNotExist = 7,
    ImageDoesNotExist = 8,
    InventionLimitReached = 9,
    DescriptionTooLong = 10,
    InnapropriateName = 11,
    InnapropriateDescription = 12,
    CannotBeModified = 13,
    PlayerCannotPublish = 14,
    AlreadyPublished = 15,
    AlreadyUnpublished = 16,
    InventionUnderModerationReview = 17,
    PlayerCannotDownload = 18,
    PlayerAlreadyOwns = 19,
    DescriptionTooShort = 20,
    DoesNotHavePermission = 21,
    PermissionLevelCannotBeChanged = 22,
    AlreadyCheered = 23,
    AlreadyRemovedCheer = 24,
    ModeratorRestrictedPublishing = 25,
    PlayerCannotSell = 26,
    InvalidPrice = 27,
    PriceCannotBeChanged = 28,
    InvalidPermissionForPaidInvention = 29,
    PurchaseFailed = 30,
    CannotDownloadPaidInvention = 31,
    CannotSellUnownedLineage = 32,
    DoesNotAllowTrial = 33,
    StillOnTrialCooldown = 34,
    PlayerCannotTrial = 35,
    PaidInventionPublishingDisabled = 36,
    PaidInventionPurchasingDisabled = 37,
    OperationIsDisabled = 38,
    PlayerRestrictedFromP2PSelling = 39,
    PlayerNotRecRoomPlusMember = 40,
    InvalidInstantiationCost = 41,
    FeaturedInventionNotPublished = 42,
    FeaturedInventionNotActive = 43,
    InventionContainsBlockedFiles = 44,
    PlayerRestrictedFromP2PBuying = 45,
    ReservedWordRuleViolationInName = 46,
    ReservedWordRuleViolationInDescription = 47,
}

// --------------------------------------------------------------------------
// CHPKMKNJLGL
//   (not directly referenced by a detected call)
public class CHPKMKNJLGL
{
    public int <DONLNGOGEHL>k__BackingField;    // 0x0x10
    public DateTime? <LKHCFEBIOOA>k__BackingField;    // 0x0x18
    public DateTime? <GHOMIGBNGNP>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// CKIEGPFFEDG
//   (not directly referenced by a detected call)
public class CKIEGPFFEDG
{
    public int <DOBKMMKAGND>k__BackingField;    // 0x0x10
    public string <JGFKDOFFBKI>k__BackingField;    // 0x0x18
    public string <MJPFPLNPCPO>k__BackingField;    // 0x0x20
    public string <ACGENGEFJAM>k__BackingField;    // 0x0x28
    public string <IGGAEJPENKL>k__BackingField;    // 0x0x30
    public string <JIPFFHDOBLJ>k__BackingField;    // 0x0x38
    public Guid? <CBLHHLAEDEG>k__BackingField;    // 0x0x40
    public DAALPJJJIHN? <FEJJGBJDIOL>k__BackingField;    // 0x0x54
    public string <NKIIPEGJAJJ>k__BackingField;    // 0x0x60
    public string <PBJIMLJPKKD>k__BackingField;    // 0x0x68
    public bool <FOPOMIMHCFE>k__BackingField;    // 0x0x70
    public bool <BIFPJAAINAB>k__BackingField;    // 0x0x71
    public bool <JENIFBIMCNH>k__BackingField;    // 0x0x72
    public MGIOIPCGJCG <OJIIGIPAMMI>k__BackingField;    // 0x0x74
    public EIIOBKGCMGK <FHIEKCKAMMA>k__BackingField;    // 0x0x78
    public int <JAHAFLMDCDA>k__BackingField;    // 0x0x7C
    public NDGDNBCHDLB <JKFEKFKIBHJ>k__BackingField;    // 0x0x80
    public CEGKDIEDEMO <NECPLIJPMGF>k__BackingField;    // 0x0x84
    public int? <HPHJNHPDICL>k__BackingField;    // 0x0x88
    public string <IPFPAJIBECN>k__BackingField;    // 0x0x90
    public int? <BOJGIPKCEMO>k__BackingField;    // 0x0x98
    public int? <CCEKHLFMEHE>k__BackingField;    // 0x0xA0
}

// --------------------------------------------------------------------------
// CLCBBHGALDP
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class CLCBBHGALDP
{
    public PAFMIKCABPN <KMEFPKIOOOP>k__BackingField;    // 0x0x10
    public OCGFBIGCKPK <HLEMPLIPCGN>k__BackingField;    // 0x0x18
    public int <EPGMIFIMLIC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CMIEKCCDHLM
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.WWW]
public class CMIEKCCDHLM
{
    public int <PFAELLHPALI>k__BackingField;    // 0x0x10
    public Guid <OHNOIKHONHO>k__BackingField;    // 0x0x14
    public long <MFBIAMFEILB>k__BackingField;    // 0x0x28
    public DateTime <LJNCBINPIBF>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// CPOGOCPFLFL
//   (not directly referenced by a detected call)
public class CPOGOCPFLFL
{
    public long <NOAFLNKEOGE>k__BackingField;    // 0x0x10
    public Guid <CBLHHLAEDEG>k__BackingField;    // 0x0x18
    public Guid <DEPCPAEDOMG>k__BackingField;    // 0x0x28
    public DateTime <GMLBHPGIMLP>k__BackingField;    // 0x0x38
    public string <OJJOBNFAMLI>k__BackingField;    // 0x0x40
    public string <ANHIEKGBGOO>k__BackingField;    // 0x0x48
    public string <BIOCIHFADNA>k__BackingField;    // 0x0x50
    public string <IEJBGGPAKPI>k__BackingField;    // 0x0x58
    public string <LEENCMAAJJM>k__BackingField;    // 0x0x60
    public string <BMFMJDAPINH>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// CodeStage.AntiCheat.ObscuredTypes.ObscuredBool
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ObscuredBool : ValueType
{
    public byte currentCryptoKey;    // 0x0x0
    public int hiddenValue;    // 0x0x4
    public bool inited;    // 0x0x8
    public bool fakeValue;    // 0x0x9
    public bool fakeValueActive;    // 0x0xA
}

// --------------------------------------------------------------------------
// CodeStage.AntiCheat.ObscuredTypes.ObscuredInt
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ObscuredInt : ValueType
{
    public int currentCryptoKey;    // 0x0x0
    public int hiddenValue;    // 0x0x4
    public bool inited;    // 0x0x8
    public int fakeValue;    // 0x0xC
    public bool fakeValueActive;    // 0x0x10
}

// --------------------------------------------------------------------------
// CodeStage.AntiCheat.ObscuredTypes.ObscuredLong
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ObscuredLong : ValueType
{
    public long currentCryptoKey;    // 0x0x0
    public long hiddenValue;    // 0x0x8
    public bool inited;    // 0x0x10
    public long fakeValue;    // 0x0x18
    public bool fakeValueActive;    // 0x0x20
}

// --------------------------------------------------------------------------
// DAALPJJJIHN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DAALPJJJIHN
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// DBDLLFIDMFE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DBDLLFIDMFE
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// DEPBEDCJGHC
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.WWW]
public class DEPBEDCJGHC
{
    public long <NHHDMBJICFB>k__BackingField;    // 0x0x10
    public int <PFAELLHPALI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DGBANILGEPE
//   (not directly referenced by a detected call)
public class DGBANILGEPE
{
    public ObscuredLong <BONDFHIBIKO>k__BackingField;    // 0x0x10
    public string <EHGKJPEMIIG>k__BackingField;    // 0x0x38
    public ObscuredInt <LBBAKPJPNNA>k__BackingField;    // 0x0x40
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x58
    public string <NIMDKMGPONB>k__BackingField;    // 0x0x60
    public string <LGIGELLKDPH>k__BackingField;    // 0x0x68
    public byte <PLFEICCOIJK>k__BackingField;    // 0x0x70
    public int <EKLLHIMBNJB>k__BackingField;    // 0x0x74
    public ODGMKINPFBN <KJEOOGFLGPN>k__BackingField;    // 0x0x78
    public bool <EHLGPCGBMPB>k__BackingField;    // 0x0x7C
    public DateTime <LJNCBINPIBF>k__BackingField;    // 0x0x80
    public DateTime <GMLBHPGIMLP>k__BackingField;    // 0x0x88
    public DateTime? <NCBGKMIFBHI>k__BackingField;    // 0x0x90
    public long? <CBFOHEPKMPE>k__BackingField;    // 0x0xA0
    public int <NCFAPFDFDFM>k__BackingField;    // 0x0xB0
    public int <MMJKEJEMJBG>k__BackingField;    // 0x0xB4
    public int <NLMMBFEPMFN>k__BackingField;    // 0x0xB8
    public DLDMHOBEAHD <FJLKAJPHHBL>k__BackingField;    // 0x0xBC
    public DLDMHOBEAHD <OMIMBFHGGGL>k__BackingField;    // 0x0xC0
    public ObscuredBool <OPMFEAKJDJI>k__BackingField;    // 0x0xC4
    public ObscuredBool <GMANICBAIMJ>k__BackingField;    // 0x0xD0
    public ObscuredBool <OFMDIPFOHKL>k__BackingField;    // 0x0xDC
    public int? <FPPLDFPFALA>k__BackingField;    // 0x0xE8
    public bool <JPONFPHJMOJ>k__BackingField;    // 0x0xF0
}

// --------------------------------------------------------------------------
// DHCMELKIIIC
//   RESPONSE PUT    api/roomkeys/v1/   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Matchmaking]
public class DHCMELKIIIC
{
    public EHIOJHCPAOK <GKJJIAJDEMJ>k__BackingField;    // 0x0x10
    public CAMKALDFMJG <DBIEGMJNANC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DHMOENGNBKM
//   (not directly referenced by a detected call)
public class DHMOENGNBKM
{
    public float <DIIBLEDOPAD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DIOMNNNDMEN
//   REQUEST  POST   api/playerevents/v1/report   [Service.Auth]
public class DIOMNNNDMEN
{
    public BNEIAIPPEJJ <LJCCLCCDKMD>k__BackingField;    // 0x0x10
    public long <GNAFLLINCPA>k__BackingField;    // 0x0x18
    public string <LNFIPONDGNG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DJGBPLMCGKP
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.Auth]
public class DJGBPLMCGKP
{
    public int <DMLMNCDAIGB>k__BackingField;    // 0x0x10
    public PKBIKEGKOAK <LBGEGKNDKBB>k__BackingField;    // 0x0x14
    public KIIIJNPDDCH <NKHGECMOCKO>k__BackingField;    // 0x0x18
    public KIIIJNPDDCH <PMDACNPFOBJ>k__BackingField;    // 0x0x1C
    public KIIIJNPDDCH <AINEGBJKNDP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DKCMMBDHKFJ
//   (not directly referenced by a detected call)
public class DKCMMBDHKFJ
{
    public int <PKGMCHEOMNA>k__BackingField;    // 0x0x10
    public DateTime <GMLBHPGIMLP>k__BackingField;    // 0x0x18
    public DateTime? <KDOFCGDHAHN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DLDMHOBEAHD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DLDMHOBEAHD
{
    Unassigned = 0,
    LimitedOneUseOnly = 10,
    DisallowKeyLock = 15,
    UseOnly = 20,
    EditAndSave = 40,
    Publish = 60,
    Charge = 80,
    Unlimited = 100,
}

// --------------------------------------------------------------------------
// DMCHMCEFLFL
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.Auth]
public class DMCHMCEFLFL
{
    public int <IBGIIBDFDLN>k__BackingField;    // 0x0x10
    public int? <MFCGAMMAEHL>k__BackingField;    // 0x0x14
    public string <IOHIDEFABGH>k__BackingField;    // 0x0x20
    public string <MBECIEEJAIP>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// EBABGGDCMGA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EBABGGDCMGA
{
    Default = -1,
    FirstSessionOfDay = 1,
    AddAFriend = 2,
    PartyUp = 3,
    AllOtherChallenges = 4,
    LevelUp = 5,
    CheerAPlayer = 6,
    PointedAtPlayer = 7,
    CheerARoom = 8,
    SubscribeToPlayer = 9,
    DailyObjective1 = 10,
    DailyObjective2 = 11,
    DailyObjective3 = 12,
    AllDailyObjectives = 13,
    CompleteAnyDaily = 14,
    CompleteAnyWeekly = 15,
    OOBE_GoToLockerRoom = 20,
    OOBE_GoToActivity = 21,
    OOBE_FinishActivity = 22,
    NUX_PunchcardObjective = 25,
    NUX_AllPunchcardObjectives = 26,
    GoToRecCenter = 30,
    FinishActivity = 31,
    VisitACustomRoom = 32,
    CreateACustomRoom = 33,
    ScoreBasketInRecCenter = 35,
    UploadPhotoToRecNet = 36,
    UpdatePlayerBio = 37,
    SaveOutfitSlot = 38,
    PurchaseClothingItem = 39,
    PurchaseNonClothingItem = 40,
    DrinkWater = 41,
    ColorOnWhiteboard = 42,
    SetBasketballSkin = 43,
    ThrowBasketball = 44,
    PlaceInventionInDorm = 45,
    ChangeDormRoomSkin = 46,
    ToggleOwnedClothes = 47,
    EquipHat = 48,
    LoadOutfit = 49,
    SaveNewOutfitSlot = 50,
    SpawnCamera = 51,
    TakeSelfie = 52,
    PrintSelfie = 53,
    TakePictureOfPlayer = 54,
    PrintPictureOfPlayer = 55,
    PublishSelfieWithPlayer = 56,
    SpawnFoodWithOtherPlayers = 57,
    EmoteInRecCenter = 58,
    SendRoomChatInRecCenter = 59,
    UseFrendotron = 60,
    GoToDormRoom = 61,
    VisitSpecificRoom = 62,
    VisitPublicRRO = 63,
    VisitPublicRoomBySource = 64,
    FavoriteARoom = 65,
    TakePhotoWithFilter = 66,
    OpenYourPlayerProfile = 67,
    OpenOnlineStatusModal = 68,
    ChangeProfilePicture = 69,
    ChangePlayerDisplayName = 70,
    ChangePlayerDescriptionText = 71,
    OpenPlayerPronounsModal = 72,
    OpenOtherPlayersProfile = 73,
    VisitPlayersPortfolio = 74,
    FavoriteAFriend = 75,
    CharadesGames = 100,
    CharadesWinsPerformer = 101,
    CharadesWinsGuesser = 102,
    DiscGolfWins = 200,
    DiscGolfGames = 201,
    DiscGolfHolesUnderPar = 202,
    DodgeballWins = 300,
    DodgeballGames = 301,
    DodgeballHits = 302,
    PaddleballGames = 400,
    PaddleballWins = 401,
    PaddleballScores = 402,
    PaintballAnyModeGames = 500,
    PaintballAnyModeWins = 501,
    PaintballAnyModeHits = 502,
    PaintballCTFWins = 600,
    PaintballCTFGames = 601,
    PaintballCTFHits = 602,
    PaintballFlagCaptures = 603,
    PaintballTeamBattleWins = 700,
    PaintballTeamBattleGames = 701,
    PaintballTeamBattleHits = 702,
    PaintballFreeForAllWins = 710,
    PaintballFreeForAllGames = 711,
    PaintballFreeForAllHits = 712,
    SoccerWins = 800,
    SoccerGames = 801,
    SoccerGoals = 802,
    BowlingGames = 900,
    BowlingWins = 901,
    BowlingStrike = 902,
    QuestGames = 1000,
    QuestWins = 1001,
    QuestPlayerRevives = 1002,
    QuestEnemyKills = 1003,
    QuestGames_Goblin1 = 1010,
    QuestWins_Goblin1 = 1011,
    QuestPlayerRevives_Goblin1 = 1012,
    QuestEnemyKills_Goblin1 = 1013,
    QuestGames_Goblin2 = 1020,
    QuestWins_Goblin2 = 1021,
    QuestPlayerRevives_Goblin2 = 1022,
    QuestEnemyKills_Goblin2 = 1023,
    QuestGames_Scifi1 = 1030,
    QuestWins_Scifi1 = 1031,
    QuestPlayerRevives_Scifi1 = 1032,
    QuestEnemyKills_Scifi1 = 1033,
    QuestGames_Pirate1 = 1040,
    QuestWins_Pirate1 = 1041,
    QuestPlayerRevives_Pirate1 = 1042,
    QuestEnemyKills_Pirate1 = 1043,
    QuestGames_Dracula1 = 1050,
    QuestWins_Dracula1 = 1051,
    QuestPlayerRevives_Dracula1 = 1052,
    QuestEnemyKills_Dracula1 = 1053,
    ArenaGames = 2000,
    ArenaWins = 2001,
    ArenaPlayerRevives = 2002,
    ArenaHeroTags = 2003,
    ArenaBotTags = 2004,
    RecRoyaleGames = 3000,
    RecRoyaleWins = 3001,
    RecRoyaleTags = 3002,
    StuntRunnerGames = 4000,
    StuntRunnerWins = 4001,
    RecRallyGames = 5000,
    RecRallyWins = 5001,
}

// --------------------------------------------------------------------------
// EBNIKKLHDGL
//   REQUEST  POST   api/roomcurrencies/v1/awardCurrency/bulk   [Service.WWW]
public class EBNIKKLHDGL
{
    public Guid <OHNOIKHONHO>k__BackingField;    // 0x0x10
    public int <BMDJHJINLEP>k__BackingField;    // 0x0x20
    public long <NIILCBJBIKF>k__BackingField;    // 0x0x28
    public Guid <DGDGANBKNPI>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// ECAMNOAGDOH
//   (not directly referenced by a detected call)
public class ECAMNOAGDOH
{
    public int <LMEIOKJLBGL>k__BackingField;    // 0x0x10
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x18
    public string <DLBBICCPICB>k__BackingField;    // 0x0x20
    public string <NIMDKMGPONB>k__BackingField;    // 0x0x28
    public string <MJPFPLNPCPO>k__BackingField;    // 0x0x30
    public bool <IKBOINJGKFM>k__BackingField;    // 0x0x38
    public int <IEGOHKEIHAB>k__BackingField;    // 0x0x3C
    public IFEAHKMOAJL <CAALDCLABJI>k__BackingField;    // 0x0x40
    public PCJCDGPFBOC MPCMIKKLIJO;    // 0x0x48
    public PCJCDGPFBOC CCNAMGOPGCH;    // 0x0x50
    public PCJCDGPFBOC FENIBGBNIEP;    // 0x0x58
    public JFEJOGDGBAH FAFGHFNFGPO;    // 0x0x60
}

// --------------------------------------------------------------------------
// EGAIIAAGEPF
//   (not directly referenced by a detected call)
public class EGAIIAAGEPF
{
    public EIIOBKGCMGK <FHIEKCKAMMA>k__BackingField;    // 0x0x10
    public int <FPPLDFPFALA>k__BackingField;    // 0x0x14
    public CHPKMKNJLGL <PBECIENCKFN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EGCEDCJCACE
//   (not directly referenced by a detected call)
public class EGCEDCJCACE
{
    public int <IEJJGMCEJAP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// EGFFOONAEIC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EGFFOONAEIC
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// EGHJCMOHDGA
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.WWW]
public class EGHJCMOHDGA
{
    public int <EHHMEDDKBNB>k__BackingField;    // 0x0x10
    public bool <CBPPFDHDEEF>k__BackingField;    // 0x0x14
    public DateTime <EHDOACCBCHD>k__BackingField;    // 0x0x18
    public bool <BCKECCPEGPE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EGLJMPAPHGG
//   RESPONSE GET    api/testcasemanagement/   [Service.Auth]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{eGNLNANJFMI}   [Service.Auth]
public class EGLJMPAPHGG
{
    public uint <GJOLPFBEBGI>k__BackingField;    // 0x0x10
    public uint? <NPFAEJPBNIO>k__BackingField;    // 0x0x14
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x20
    public string <NIMDKMGPONB>k__BackingField;    // 0x0x28
    public DateTime <KELAFGEJHGO>k__BackingField;    // 0x0x30
    public DateTime? <OLDBDAONKKP>k__BackingField;    // 0x0x38
    public bool <CNCMLDFGKKM>k__BackingField;    // 0x0x48
    public List<NABMEMCEECL> <GLDICNPLDDH>k__BackingField;    // 0x0x50
    public List<string> <GKKLMNIJLJL>k__BackingField;    // 0x0x58
    public int <IDFFDGGPFLG>k__BackingField;    // 0x0x60
    public int <CBKJEAFFPGB>k__BackingField;    // 0x0x64
    public int <BAKGMPHGCKP>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// EGMLCDGLIAJ
// base   : ADGIAANBPFL
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/season/{iJCPHPPKDBP}   [Service.WWW]
public class EGMLCDGLIAJ : ADGIAANBPFL
{
    public int <EJBEKACHCOP>k__BackingField;    // 0x0x30
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x38
    public DateTime <CECDAJOPBKC>k__BackingField;    // 0x0x40
    public DateTime <LNBKKPOJNBH>k__BackingField;    // 0x0x48
    public EIIOBKGCMGK <FHIEKCKAMMA>k__BackingField;    // 0x0x50
    public AIDCCFPBGMO <OMPGFBMAHDK>k__BackingField;    // 0x0x58
    public List<PLOIOIEOEJH> <JMNGLBOPMGK>k__BackingField;    // 0x0x60
    public EJPHLFEKFFA <IMGNKNAGHCK>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// EHIOJHCPAOK
// base   : System.Enum
//   RESPONSE DELETE api/roomkeys/   [Service.WWW]
//   RESPONSE DELETE api/roomkeys/v1/delete/{mABMPPLJDBK}   [Service.WWW]
public enum EHIOJHCPAOK
{
    Success = 0,
    InvalidParameters = 1,
    DoesNotExist = 2,
    NameTooShort = 3,
    NameTooLong = 4,
    DuplicateName = 5,
    InappropriateName = 6,
    DescriptionTooShort = 7,
    DescriptionTooLong = 8,
    InappropriateDescription = 9,
    PriceIsInvalid = 10,
    PermissionDenied = 12,
    PlayerHasRoomUnderModerationReview = 13,
    JuniorStatusFail = 14,
    PlayerIsNotCoOwner = 15,
    RoomKeyLimitReached = 16,
    PlayerAlreadyOwns = 17,
    RoomUnderModerationReview = 18,
    PurchaseFailed = 19,
    RoomDoesNotExist = 20,
    PaidKeyPurchasingDisabled = 21,
    CreateOrModifyKeysDisabled = 22,
    RoomKeyUnderModerationReview = 23,
    PlayerRestrictedFromP2PSelling = 24,
    PlayerNotRecRoomPlusMember = 25,
    InvalidRoomCurrency = 26,
    RoomCurrenciesAreDisabled = 27,
    ImageDoesNotExist = 28,
    NotEnoughCurrency = 29,
    PlayerRestrictedFromP2PBuying = 30,
}

// --------------------------------------------------------------------------
// EIIOBKGCMGK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EIIOBKGCMGK
{
    Invalid = 0,
    LaserTagTickets = 1,
    RecCenterTokens = 2,
    LostSkullsGold = 100,
    DraculaSilver = 101,
    RecRoyale_Season1 = 200,
    RoomCurrency = 300,
    RoomInventoryItem = 301,
    ProgressionEvent = 400,
}

// --------------------------------------------------------------------------
// EJPHLFEKFFA
//   (not directly referenced by a detected call)
public class EJPHLFEKFFA
{
    public bool <HMLKIDKNOJB>k__BackingField;    // 0x0x10
    public ENGGLDCJGIN <NJHFPFJIELN>k__BackingField;    // 0x0x14
    public int <FCGBLLEPGJL>k__BackingField;    // 0x0x18
    public DateTime <LJNCBINPIBF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EKHGLIMEKDL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EKHGLIMEKDL
{
    Invalid = 0,
    DirectBalanceWithMultiplier = 1,
    FromGiftBox = 2,
    NUXChallenge = 10,
    AllNUXChallenges = 11,
    DailyChallenge = 100,
    AllDailyChallenges = 101,
    FinishActivity = 200,
    RecRoyaleMatchFinished = 250,
    ChecklistCredit = 303,
    WonGame = 1000,
    LostGame = 1001,
    WonGameRateLimited = 1002,
    WonGamePartial = 1003,
    LevelUp = 1100,
    Registered = 1200,
    CreatorReward = 1300,
    CommercePurchase = 1400,
    CommercePurchaseRevoked = 1401,
    Manual_Refund = 2000,
    Manual_Thanks = 2010,
    Manual_Apology = 2020,
    TestOnly = 8000,
}

// --------------------------------------------------------------------------
// ENGGLDCJGIN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ENGGLDCJGIN
{
    All = -1,
    None = 0,
    Steam = 1,
    Oculus = 2,
    PlayStation = 4,
    Xbox = 8,
    RecNet = 16,
    IOS = 32,
    GooglePlay = 64,
    Standalone = 128,
    Pico = 256,
    Toaster = 512,
}

// --------------------------------------------------------------------------
// EOHEOFGFOKE
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.Auth]
public class EOHEOFGFOKE
{
    public int? <LICDHCMCBIK>k__BackingField;    // 0x0x10
    public string <NIONPBIHDOC>k__BackingField;    // 0x0x18
    public string <CNKDPBEINNA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EasyAntiCheat.Client.HostValidationResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HostValidationResult
{
    ServerHostValidationSuccess = 0,
    ServerHostValidationFailed = 1,
    ServerHostValidationTimedOut = 2,
}

// --------------------------------------------------------------------------
// EasyAntiCheat.Client.LoadResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LoadResult
{
    InitSuccess = 0,
    LauncherInvalidParameter = 1,
    LauncherDNSError = 2,
    LauncherNetworkError = 3,
    LauncherFailure = 4,
    LauncherInstallError = 5,
    LauncherSuccessUnderWine = 6,
    InitCancelRequested = 7,
    GameClientConnected = 8,
    GameClientDisconnected = 9,
    GameClientAuthenticated = 10,
    GameClientIntegrityViolation = 11,
}

// --------------------------------------------------------------------------
// ExitGames.Client.Photon.OperationRequest
//   (not directly referenced by a detected call)
public class OperationRequest
{
    public byte OperationCode;    // 0x0x10
    public ParameterDictionary Parameters;    // 0x0x18
}

// --------------------------------------------------------------------------
// ExitGames.Client.Photon.OperationResponse
//   (not directly referenced by a detected call)
public class OperationResponse
{
    public byte OperationCode;    // 0x0x10
    public short ReturnCode;    // 0x0x12
    public string DebugMessage;    // 0x0x18
    public ParameterDictionary Parameters;    // 0x0x20
}

// --------------------------------------------------------------------------
// FAINPOCOAMP
//   REQUEST  POST   api/roomkeys/v1/owns/bulk   [Service.WWW]
public class FAINPOCOAMP
{
    public int LJCNEOABAPN;    // 0x0x10
    public long KABHLIAOMHE;    // 0x0x18
}

// --------------------------------------------------------------------------
// FIHNOPHEMND
//   RESPONSE DELETE api/roomconsumables   [Service.WWW]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{nEMMJIBJIGB}   [Service.WWW]
public class FIHNOPHEMND
{
    public KKIBPGDDHMJ <GKJJIAJDEMJ>k__BackingField;    // 0x0x10
    public OCKEFLLJOFN <IFGOGNEJCAB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FKDLOPOKDFI
//   REQUEST  POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
public class FKDLOPOKDFI
{
    public List<string> <GMJLDLBEFHK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// FMJHJGFPICI
//   (not directly referenced by a detected call)
public class FMJHJGFPICI
{
    public Guid <ADHEFFDIGKF>k__BackingField;    // 0x0x10
    public int <PFAELLHPALI>k__BackingField;    // 0x0x20
    public int <FIIJNIGNHHE>k__BackingField;    // 0x0x24
    public Guid <JAHIJCBPBPO>k__BackingField;    // 0x0x28
    public DateTime <LJNCBINPIBF>k__BackingField;    // 0x0x38
    public OCKEFLLJOFN <IFGOGNEJCAB>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// FNGPEOPELLJ
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.Auth]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.Auth]
public class FNGPEOPELLJ
{
    public AHJBPGOPDGN <JDPHBIBLBMD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// FOJCEFDJBMB
//   REQUEST  ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForCustomAvatarItemIds   [Service.Notifications]
public class FOJCEFDJBMB
{
    public List<Guid> <NLPKHHGLFDG>k__BackingField;    // 0x0x10
    public byte <DJHKEOIHBPH>k__BackingField;    // 0x0x18
    public int <AHOCBEKGAGJ>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// FPABGOGEMMF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FPABGOGEMMF
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// GBMPAMGCEDL
//   REQUEST  POST   api/messages/v1/sendMultiple   [Service.Auth]
public class GBMPAMGCEDL
{
    public List<long> <KGKIEGGEFMP>k__BackingField;    // 0x0x10
    public OOPIKCAIJDO <LBGEGKNDKBB>k__BackingField;    // 0x0x18
    public string <ALHIMBBDOGM>k__BackingField;    // 0x0x20
    public long? <AMMGFAOLMNI>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// GDFLIDPGDCI
//   REQUEST  POST   api/roomcurrencies   [Service.WWW]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.WWW]
public class GDFLIDPGDCI
{
    public Guid <DGDGANBKNPI>k__BackingField;    // 0x0x10
    public long <BMCFPOFJLDH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GGHIHEJJOMK
// base   : HMPKBNCCFBJ
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class GGHIHEJJOMK : HMPKBNCCFBJ
{
    public FPABGOGEMMF? <HGJAKLIJEHB>k__BackingField;    // 0x0x18
    public CMIEKCCDHLM <BDIINEHCBPN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GHJHJHAMOGF
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.Auth]
public class GHJHJHAMOGF
{
    public BNEIAIPPEJJ <LJCCLCCDKMD>k__BackingField;    // 0x0x10
    public int <GFBAJMHIMIO>k__BackingField;    // 0x0x14
    public long <JLKHPABKADP>k__BackingField;    // 0x0x18
    public bool <MGONLMNKLDB>k__BackingField;    // 0x0x20
    public string <IBNGLMMANGE>k__BackingField;    // 0x0x28
    public int? <PGEKNDALKEG>k__BackingField;    // 0x0x30
    public bool <HDLFBNGFGLP>k__BackingField;    // 0x0x38
    public bool <JOFINGGMJGL>k__BackingField;    // 0x0x39
    public bool <OPGGICLBALM>k__BackingField;    // 0x0x3A
    public bool <CGFBPDDKNIH>k__BackingField;    // 0x0x3B
    public string <HAOLEHHCHKJ>k__BackingField;    // 0x0x40
    public DateTime? <MMANNBHDPLF>k__BackingField;    // 0x0x48
    public string <GPIMBEAIJDH>k__BackingField;    // 0x0x58
    public float <IKHOJKFJDEC>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// GNLHLFBJJHN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GNLHLFBJJHN
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// GONKACDHNKI
// base   : JHBBCONCKJI
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class GONKACDHNKI : JHBBCONCKJI
{
    public List<KHNAEGAJPKP> <GKKLMNIJLJL>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// GOPDOABKNNI
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
public class GOPDOABKNNI
{
    public Guid? <ADHEFFDIGKF>k__BackingField;    // 0x0x10
    public long? <AMMGFAOLMNI>k__BackingField;    // 0x0x28
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x38
    public string <NIMDKMGPONB>k__BackingField;    // 0x0x40
    public string <LGIGELLKDPH>k__BackingField;    // 0x0x48
    public OCGFBIGCKPK <CHHBNFLBEBI>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// HENBMDOGANE
//   (not directly referenced by a detected call)
public class HENBMDOGANE
{
    public long <HBAFEOICIHF>k__BackingField;    // 0x0x10
    public string <EHGKJPEMIIG>k__BackingField;    // 0x0x18
    public int <KAGGFBPGMAM>k__BackingField;    // 0x0x20
    public int <FPAJBCHHFHI>k__BackingField;    // 0x0x24
    public int <IHCNDEECIJL>k__BackingField;    // 0x0x28
    public int <EPJHKELILKL>k__BackingField;    // 0x0x2C
    public int <LBEINGGMALJ>k__BackingField;    // 0x0x30
    public string <BIIBLLPHPMD>k__BackingField;    // 0x0x38
    public string <IBHLDKDFBCO>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// HFEBFLNLOAK
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems/v2   [Service.Notifications]
public class HFEBFLNLOAK
{
    public byte <DJHKEOIHBPH>k__BackingField;    // 0x0x10
    public int <AHOCBEKGAGJ>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// HJOFHGAKPFI
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{kMMLKMANHMG}/{iHKFPOAJAEC}   [Service.WWW]
public class HJOFHGAKPFI
{
    public EIIOBKGCMGK <FHIEKCKAMMA>k__BackingField;    // 0x0x10
    public EKHGLIMEKDL <BEOAJNCBBFL>k__BackingField;    // 0x0x14
    public int <HKMJDFIDICB>k__BackingField;    // 0x0x18
    public int <NJFDFHAPFAP>k__BackingField;    // 0x0x1C
    public int <FNCMKOIJKGL>k__BackingField;    // 0x0x20
    public OOPIEPJEGIH <GKHJNGOIKEO>k__BackingField;    // 0x0x24
    public bool <EHFDHEAOLNM>k__BackingField;    // 0x0x28
    public float <PPEDDKHFENM>k__BackingField;    // 0x0x2C
    public int <GGLCMJPOCBG>k__BackingField;    // 0x0x30
    public bool <KMPCBMPDFFA>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// HPICLFKDFOL
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs   [Service.Notifications]
public class HPICLFKDFOL
{
    public List<string> <LMHAIPCJOBJ>k__BackingField;    // 0x0x10
    public byte <DJHKEOIHBPH>k__BackingField;    // 0x0x18
    public int <AHOCBEKGAGJ>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// IBADOPFEFNE
//   (not directly referenced by a detected call)
public class IBADOPFEFNE
{
    public float <CPONPGLBCIF>k__BackingField;    // 0x0x10
    public float <CEKDIJPPJFA>k__BackingField;    // 0x0x14
    public float <MFNMIJCDHON>k__BackingField;    // 0x0x18
    public float <IEPBBECGLCB>k__BackingField;    // 0x0x1C
    public float <KIDOILBGKFF>k__BackingField;    // 0x0x20
    public float <KNCPGCPFBFO>k__BackingField;    // 0x0x24
    public float <KAANGIFKDGH>k__BackingField;    // 0x0x28
    public float <EGIMBNKDOLK>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// IFEAHKMOAJL
//   (not directly referenced by a detected call)
public class IFEAHKMOAJL
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// IFKDFOIHLDP
//   RESPONSE GET    api/playerevents/v1/all   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/all/{aFPGBMLCIPL}   [Service.Auth]
public class IFKDFOIHLDP
{
    public List<JHBBCONCKJI> <NFEMPLHKIKM>k__BackingField;    // 0x0x10
    public List<INILLANGPGH> <NDLDCBNNCGL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IGCFCLKMICH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IGCFCLKMICH
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// INILLANGPGH
//   (not directly referenced by a detected call)
public class INILLANGPGH
{
    public JHBBCONCKJI <OLJGHMANKOG>k__BackingField;    // 0x0x10
    public PPFGNAGBKHC <IIJEKHIIDPA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JDEEFEJFJIJ
//   REQUEST  POST   api/playerevents/v1/respond   [Service.Auth]
public class JDEEFEJFJIJ
{
    public long <GNAFLLINCPA>k__BackingField;    // 0x0x10
    public EGFFOONAEIC <LBGEGKNDKBB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JFOPBOONNON
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.WWW]
public class JFOPBOONNON
{
    public long <AMMGFAOLMNI>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <ONHLOCNBAFF>k__BackingField;    // 0x0x18
    public NHKOABHPKID <NLKGPGOFLOD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JHBBCONCKJI
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class JHBBCONCKJI
{
    public long <GNAFLLINCPA>k__BackingField;    // 0x0x10
    public int <IMGBAFIEBGI>k__BackingField;    // 0x0x18
    public long <AMMGFAOLMNI>k__BackingField;    // 0x0x20
    public long? <FPKAFOKIKHH>k__BackingField;    // 0x0x28
    public long? <NNMNCEGJLOP>k__BackingField;    // 0x0x38
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x48
    public string <NIMDKMGPONB>k__BackingField;    // 0x0x50
    public string <LGIGELLKDPH>k__BackingField;    // 0x0x58
    public DateTime <FHAIHEHMPEB>k__BackingField;    // 0x0x60
    public DateTime <PPAEEOJLJBB>k__BackingField;    // 0x0x68
    public int <HLEEHJIGIMA>k__BackingField;    // 0x0x70
    public PMFKDFGFMAF <KJEOOGFLGPN>k__BackingField;    // 0x0x74
    public bool <MLDANLMBEBM>k__BackingField;    // 0x0x78
    public bool <MKOILCGNKBA>k__BackingField;    // 0x0x79
    public IGCFCLKMICH <FBNMFBCAALC>k__BackingField;    // 0x0x7C
    public IGCFCLKMICH <FNKNOCNJCIO>k__BackingField;    // 0x0x80
    public long? <ELGJLCKMBLN>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// JKAJOGGCOLM
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.WWW]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.WWW]
public class JKAJOGGCOLM
{
    public int <HNBMPAADFIK>k__BackingField;    // 0x0x10
    public int <EHHMEDDKBNB>k__BackingField;    // 0x0x14
    public float <EBHGPGCLFCD>k__BackingField;    // 0x0x18
    public float <KFHNHBPIOKO>k__BackingField;    // 0x0x1C
    public bool <CBPPFDHDEEF>k__BackingField;    // 0x0x20
    public bool <ANNNFCLDIBP>k__BackingField;    // 0x0x21
    public bool <ELGJDADFIIB>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// JKEECNDDHOJ
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.Auth]
public class JKEECNDDHOJ
{
    public List<JHBBCONCKJI> <MNFFPOLOIAE>k__BackingField;    // 0x0x10
    public string <JILBGFHLNDP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JMGFFIKDGLJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JMGFFIKDGLJ
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// JNIFCHAIJJK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JNIFCHAIJJK
{
    None = 0,
    LaserTag = 1,
    RecCenter = 2,
    Watch = 3,
    Quest_LostSkulls = 100,
    Quest_Dracula = 101,
    Quest_GoldenTrophy = 102,
    Quest_CrimsonCauldron = 103,
    RecRoyale = 200,
    Cafe = 300,
    Paintball = 400,
    Paintball_River = 401,
    Paintball_Homestead = 402,
    Paintball_Quarry = 403,
    Paintball_ClearCut = 404,
    Paintball_Spillway = 405,
    Paintball_SunsetDriveIn = 406,
    Bowling = 500,
    StuntRunner = 600,
    DormMirror = 700,
    InventionStore = 800,
    RoomKeys = 900,
    Player_Profile = 1000,
    Room_Save = 1100,
    RoomCurrencies = 1200,
    Wishlist = 1300,
    Friendotron = 1400,
    RoomConsumables = 1500,
    RecRally = 1600,
    PopUpShop_1 = 1700,
    PopUpShop_2 = 1701,
    PopUpShop_3 = 1702,
    PopUpShop_4 = 1703,
    PopUpShop_5 = 1704,
    PopUpShop_6 = 1705,
    PopUpShop_7 = 1706,
    PopUpShop_8 = 1707,
    PopUpShop_9 = 1708,
    PopUpShop_10 = 1709,
    PopUpShop_11 = 1710,
    PopUpShop_12 = 1711,
    PopUpShop_13 = 1712,
    PopUpShop_14 = 1713,
    PopUpShop_15 = 1714,
    PopUpShop_16 = 1715,
    PopUpShop_17 = 1716,
    PopUpShop_18 = 1717,
    PopUpShop_19 = 1718,
    PopUpShop_20 = 1719,
    CustomAvatarItems = 1800,
    ProgressionEventPurchasableXpBoosts = 1900,
    PopUpShop_ProgressionEvent_1 = 2000,
    PopUpShop_ProgressionEvent_2 = 2001,
    PopUpShop_ProgressionEvent_3 = 2002,
    PopUpShop_ProgressionEvent_4 = 2003,
    PopUpShop_ProgressionEvent_5 = 2004,
    RoomOffers = 2100,
    MyLittleMonsters = 2200,
}

// --------------------------------------------------------------------------
// KABNEJAHOGN
//   (not directly referenced by a detected call)
public class KABNEJAHOGN
{
    public long <DOBKMMKAGND>k__BackingField;    // 0x0x10
    public string <IGGAEJPENKL>k__BackingField;    // 0x0x18
    public string <KHBEFGKBJNH>k__BackingField;    // 0x0x20
    public DAALPJJJIHN? <FEJJGBJDIOL>k__BackingField;    // 0x0x28
    public string <NKIIPEGJAJJ>k__BackingField;    // 0x0x30
    public string <PBJIMLJPKKD>k__BackingField;    // 0x0x38
    public JNIFCHAIJJK <DAPFDMGABAL>k__BackingField;    // 0x0x40
    public int <NIAFKECOPDH>k__BackingField;    // 0x0x44
    public int <OCKPMLAIHOA>k__BackingField;    // 0x0x48
    public CEGKDIEDEMO? <LEPHMDKPLPE>k__BackingField;    // 0x0x4C
    public MGIOIPCGJCG? <GPHBCOLACGE>k__BackingField;    // 0x0x54
}

// --------------------------------------------------------------------------
// KCAILHAGLIC
//   (not directly referenced by a detected call)
public class KCAILHAGLIC
{
    public int <OBHCKMJOMEC>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KCIIPHMFDGI
// base   : HMPKBNCCFBJ
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class KCIIPHMFDGI : HMPKBNCCFBJ
{
    public NIPCLFOAINL? <HGJAKLIJEHB>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <BNDOFBIEINM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KHNAEGAJPKP
//   (not directly referenced by a detected call)
public class KHNAEGAJPKP
{
    public string <HFFPPEPLLNL>k__BackingField;    // 0x0x10
    public DBDLLFIDMFE <LBGEGKNDKBB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KJMOHHGKKPI
//   REQUEST  POST   api/playerevents/v2   [Service.Auth]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.Auth]
public class KJMOHHGKKPI
{
    public long <AMMGFAOLMNI>k__BackingField;    // 0x0x10
    public long? <FPKAFOKIKHH>k__BackingField;    // 0x0x18
    public long? <NNMNCEGJLOP>k__BackingField;    // 0x0x28
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x38
    public string <NIMDKMGPONB>k__BackingField;    // 0x0x40
    public List<string> <GKKLMNIJLJL>k__BackingField;    // 0x0x48
    public string <LGIGELLKDPH>k__BackingField;    // 0x0x50
    public DateTime <FHAIHEHMPEB>k__BackingField;    // 0x0x58
    public DateTime <PPAEEOJLJBB>k__BackingField;    // 0x0x60
    public PMFKDFGFMAF <KJEOOGFLGPN>k__BackingField;    // 0x0x68
    public bool <MLDANLMBEBM>k__BackingField;    // 0x0x6C
    public bool <MKOILCGNKBA>k__BackingField;    // 0x0x6D
    public IGCFCLKMICH <FBNMFBCAALC>k__BackingField;    // 0x0x70
    public IGCFCLKMICH <FNKNOCNJCIO>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// KKIBPGDDHMJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KKIBPGDDHMJ
{
    Unknown = -1,
    Success = 0,
    FeatureDisabled = 1,
    ConsumableUnderModeration = 2,
    RoomConsumableIdMismatch = 3,
    RoomConsumableNotFound = 4,
    ImageDoesNotExist = 5,
    AccountIdInvalid = 6,
    PlayerDoesntHavePermission = 7,
    PlayerIsNotBetaMember = 8,
    PlayerIsNotRRPMember = 9,
    PlayerIsP2PSellingRestricted = 10,
    PlayerIsJuniorAccount = 11,
    PlayerUnderModeration = 12,
    MaxConsumablesInRoom = 13,
    RoomIdMismatch = 14,
    RoomIdMissing = 15,
    RoomIdInvalid = 16,
    PriceOrCurrencyMissing = 17,
    CurrencyNotFound = 18,
    PriceTooLowCurrency = 19,
    PriceTooHighCurrency = 20,
    PriceTooLowTokens = 21,
    PriceTooHighTokens = 22,
    NameTooShort = 23,
    NameTooLong = 24,
    NameHasInvalidCharacters = 25,
    DescriptionTooShort = 26,
    DescriptionTooLong = 27,
    DescriptionHasInvalidCharacters = 28,
    DuplicateName = 29,
    InappropriateName = 30,
    InappropriateDescription = 31,
    ConcurrencyCodeMismatch = 32,
    PlayerDoesNotOwnConsumable = 33,
    OwnershipLimitExceeded = 34,
    PurchaseFailed = 35,
    RoomNotFound = 36,
    RoomUnderModeration = 37,
    RequestedPriceDoesNotMatch = 38,
    RequestedCurrencyDoesNotMatch = 39,
    ConsumableCannotBePurchasedWithRoomCurrency = 40,
    ConsumableCannotBePurchasedWithTokens = 41,
    PlayerIsP2PBuyingRestricted = 42,
    AwardAmountIsInvalid = 43,
    ConsumableCannotBeAwarded = 44,
    PlayerHasReachedAwardLimit = 45,
    AwardLimitIsInvalid = 46,
}

// --------------------------------------------------------------------------
// LAKFPAIDBLE
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.WWW]
public class LAKFPAIDBLE
{
    public List<int> <GAECEEJOIHH>k__BackingField;    // 0x0x10
    public string <JILBGFHLNDP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LEPHJBAEIGO
//   (not directly referenced by a detected call)
public class LEPHJBAEIGO
{
    public Guid <JPDIEOLJCGP>k__BackingField;    // 0x0x10
    public Guid <IPAHJGKKCEM>k__BackingField;    // 0x0x20
    public DateTime <CECDAJOPBKC>k__BackingField;    // 0x0x30
    public List<CKIEGPFFEDG> <NCABKHLIOKA>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// LFDBKIMOFLO
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class LFDBKIMOFLO
{
    public Dictionary<Guid, OLENBCPOBJL> <ICGAPHBFBPM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MCNKEPHJOML
//   (not directly referenced by a detected call)
public class MCNKEPHJOML
{
    public int <CKAAFDMJJIP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MGIOIPCGJCG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MGIOIPCGJCG
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// MGJKABDBCEO
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.WWW]
//   RESPONSE POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
//   RESPONSE GET    api/avatar/v4/items   [Service.WWW]
public class MGJKABDBCEO
{
    public DAALPJJJIHN <FEJJGBJDIOL>k__BackingField;    // 0x0x10
    public string <PICOIPFNECH>k__BackingField;    // 0x0x18
    public string <JGFKDOFFBKI>k__BackingField;    // 0x0x20
    public string <MJPFPLNPCPO>k__BackingField;    // 0x0x28
    public MGIOIPCGJCG <OJIIGIPAMMI>k__BackingField;    // 0x0x30
    public string <ACGENGEFJAM>k__BackingField;    // 0x0x38
    public int <BOJGIPKCEMO>k__BackingField;    // 0x0x40
    public bool <MMCALENOCBD>k__BackingField;    // 0x0x44
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncHandshakeRequest
// base   : Mono.Net.Security.AsyncProtocolRequest
//   (not directly referenced by a detected call)
public class AsyncHandshakeRequest : AsyncProtocolRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncProtocolRequest
//   (not directly referenced by a detected call)
public class AsyncProtocolRequest
{
    public MobileAuthenticatedStream <Parent>k__BackingField;    // 0x0x10
    public bool <RunSynchronously>k__BackingField;    // 0x0x18
    public int <UserResult>k__BackingField;    // 0x0x1C
    public int Started;    // 0x0x20
    public int RequestedSize;    // 0x0x24
    public int WriteRequested;    // 0x0x28
    public object locker;    // 0x0x30
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncProtocolResult
//   (not directly referenced by a detected call)
public class AsyncProtocolResult
{
    public int <UserResult>k__BackingField;    // 0x0x10
    public ExceptionDispatchInfo <Error>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncReadOrWriteRequest
// base   : Mono.Net.Security.AsyncProtocolRequest
//   (not directly referenced by a detected call)
public class AsyncReadOrWriteRequest : AsyncProtocolRequest
{
    public BufferOffsetSize <UserBuffer>k__BackingField;    // 0x0x38
    public int <CurrentSize>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncReadRequest
// base   : Mono.Net.Security.AsyncReadOrWriteRequest
//   (not directly referenced by a detected call)
public class AsyncReadRequest : AsyncReadOrWriteRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncWriteRequest
// base   : Mono.Net.Security.AsyncReadOrWriteRequest
//   (not directly referenced by a detected call)
public class AsyncWriteRequest : AsyncReadOrWriteRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Mono.Security.Interface.ValidationResult
//   (not directly referenced by a detected call)
public class ValidationResult
{
    public bool trusted;    // 0x0x10
    public bool user_denied;    // 0x0x11
    public int error_code;    // 0x0x14
    public MonoSslPolicyErrors? policy_errors;    // 0x0x18
}

// --------------------------------------------------------------------------
// Mono.Security.Protocol.Ntlm.ChallengeResponse
//   (not directly referenced by a detected call)
public class ChallengeResponse
{
    public bool _disposed;    // 0x0x10
    public byte[] _challenge;    // 0x0x18
    public byte[] _lmpwd;    // 0x0x20
    public byte[] _ntpwd;    // 0x0x28
}

// --------------------------------------------------------------------------
// NABMEMCEECL
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.Auth]
public class NABMEMCEECL
{
    public string <GJOLPFBEBGI>k__BackingField;    // 0x0x10
    public string <HBKEGNDKJJC>k__BackingField;    // 0x0x18
    public string <IMCKHIIPOAI>k__BackingField;    // 0x0x20
    public string <NIMDKMGPONB>k__BackingField;    // 0x0x28
    public string <NIONPBIHDOC>k__BackingField;    // 0x0x30
    public OPPIAFJFMBA <GKJJIAJDEMJ>k__BackingField;    // 0x0x38
    public List<string> <OGCONDOOIFC>k__BackingField;    // 0x0x40
    public List<string> <GKKLMNIJLJL>k__BackingField;    // 0x0x48
    public string <CLIOOMAHPNK>k__BackingField;    // 0x0x50
    public List<BFNHPOLKGEI> <FLMLFLDGJFF>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// NAJFFAPIHCC
//   RESPONSE ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForCustomAvatarItemIds   [Service.Notifications]
public class NAJFFAPIHCC
{
    public Dictionary<Guid, CPOGOCPFLFL> <GOKBFBEBMPP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// NCDMHIGDCPF
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/checklist/v1/complete   [Service.WWW]
//   RESPONSE POST   api/progressionEvents   [Service.Auth]
//   RESPONSE POST   api/progressionEvents/collect/{fEHFONEBDKD}/{kLPJFLDODHB}   [Service.Auth]
public class NCDMHIGDCPF
{
    public long? <GJOLPFBEBGI>k__BackingField;    // 0x0x10
    public int <ADLIKFIIJFK>k__BackingField;    // 0x0x20
    public int? <JHNBAJJPBMB>k__BackingField;    // 0x0x24
    public string <IGGAEJPENKL>k__BackingField;    // 0x0x30
    public DAALPJJJIHN? <FEJJGBJDIOL>k__BackingField;    // 0x0x38
    public string <JIPFFHDOBLJ>k__BackingField;    // 0x0x40
    public Guid? <CBLHHLAEDEG>k__BackingField;    // 0x0x48
    public string <NKIIPEGJAJJ>k__BackingField;    // 0x0x60
    public string <PBJIMLJPKKD>k__BackingField;    // 0x0x68
    public EIIOBKGCMGK <FHIEKCKAMMA>k__BackingField;    // 0x0x70
    public int <JAHAFLMDCDA>k__BackingField;    // 0x0x74
    public int <NIAFKECOPDH>k__BackingField;    // 0x0x78
    public CEGKDIEDEMO <LEPHMDKPLPE>k__BackingField;    // 0x0x7C
    public MGIOIPCGJCG <GPHBCOLACGE>k__BackingField;    // 0x0x80
    public string <NHIILELFLBL>k__BackingField;    // 0x0x88
    public PLEPGDECPNI <NIHDMCGNCLM>k__BackingField;    // 0x0x90
    public ENGGLDCJGIN <HPMLDLBCEJI>k__BackingField;    // 0x0x94
    public BNNNMOMOCDJ? <HMKFIKAOMGN>k__BackingField;    // 0x0x98
    public bool <KFGEOFGLICP>k__BackingField;    // 0x0xA0
    public bool <ALFPFDOPEPB>k__BackingField;    // 0x0xA1
    public string <KPHOJJIEIAN>k__BackingField;    // 0x0xA8
    public bool <FJPCNBIMFCF>k__BackingField;    // 0x0xB0
    public bool DJFGMHIFHNN;    // 0x0xB1
}

// --------------------------------------------------------------------------
// NDGDNBCHDLB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NDGDNBCHDLB
{
    Unspecified = -1,
    XP = 0,
    OutfitItem = 1,
    Equipment = 2,
    Currency = 3,
    Consumable = 4,
    Query = 5,
    HairDye = 6,
}

// --------------------------------------------------------------------------
// NHKOABHPKID
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NHKOABHPKID
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// NINCMMIIHAA
// base   : IOMDGCJBFDF`1<ENBCFCAPAEH>
//   RESPONSE GET    api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{bHBPPGPGNLJ}   [Service.Auth]
public class NINCMMIIHAA
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// NIPCLFOAINL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NIPCLFOAINL
{
    OK = 0,
    TooManyRequests = 1,
    NotEnoughCredit = 2,
    AlreadyOwned = 3,
    NoItemAvailable = 4,
    CouponNotApplicable = 5,
    RequestedPriceDoesNotMatch = 6,
    RequestedAmountNotAllowed = 7,
    PlayerNotEligible = 8,
    RequestCannotBeRefunded = 9,
    PlayerNotApproved = 10,
}

// --------------------------------------------------------------------------
// NKEONDHCGCL
//   (not directly referenced by a detected call)
public class NKEONDHCGCL
{
    public EBABGGDCMGA ONDPMLJLNCM;    // 0x0x10
    public int PGOFDENFNOP;    // 0x0x14
}

// --------------------------------------------------------------------------
// NLMHFBOIPCB
// base   : IOMDGCJBFDF`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.Auth]
public class NLMHFBOIPCB
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// NMFLFMJGIBG
//   (not directly referenced by a detected call)
public class NMFLFMJGIBG
{
    public bool <HLDBOGFOFAC>k__BackingField;    // 0x0x10
    public CKIEGPFFEDG <EMKELEJFGFF>k__BackingField;    // 0x0x18
    public float <NHBGMFMNDHE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// NNGGBPBDHPA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NNGGBPBDHPA
{
    Success = 0,
    TooManyTags = 1,
    TagUseRestricted = 2,
    InvalidTag = 3,
    InappropriateTag = 4,
    TagTooLong = 5,
    TagNotFound = 6,
    TagAlreadyExists = 7,
    NoChange = 8,
    TagRepeated = 9,
    LacksPermission = 10,
    RoomDoesNotExist = 11,
    InventionDoesNotExist = 12,
    ReservedWordViolation = 13,
}

// --------------------------------------------------------------------------
// OCGFBIGCKPK
//   (not directly referenced by a detected call)
public class OCGFBIGCKPK
{
    public long <FPPLDFPFALA>k__BackingField;    // 0x0x10
    public Guid? <OHNOIKHONHO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OCKEFLLJOFN
//   (not directly referenced by a detected call)
public class OCKEFLLJOFN
{
    public Guid <ADHEFFDIGKF>k__BackingField;    // 0x0x10
    public long <AMMGFAOLMNI>k__BackingField;    // 0x0x20
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x28
    public string <NIMDKMGPONB>k__BackingField;    // 0x0x30
    public string <LGIGELLKDPH>k__BackingField;    // 0x0x38
    public long <FPPLDFPFALA>k__BackingField;    // 0x0x40
    public Guid? <JHBCHIMILBD>k__BackingField;    // 0x0x48
    public DateTime <LJNCBINPIBF>k__BackingField;    // 0x0x60
    public int <GICJHBNNOIC>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// ODGMKINPFBN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ODGMKINPFBN
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// OHHMJPKLJAJ
//   (not directly referenced by a detected call)
public class OHHMJPKLJAJ
{
    public int <DJLGEFHPNBO>k__BackingField;    // 0x0x10
    public AHJBPGOPDGN <JDPHBIBLBMD>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// OHNNLGDGNCB
//   RESPONSE POST   api/inventions/v1/settags   [Service.Auth]
public class OHNNLGDGNCB
{
    public NNGGBPBDHPA <JDPHBIBLBMD>k__BackingField;    // 0x0x10
    public List<string> <GKKLMNIJLJL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OJLCCJBGJAF
//   RESPONSE PUT    api/roomconsumables   [Service.WWW]
public class OJLCCJBGJAF
{
    public KKIBPGDDHMJ <GKJJIAJDEMJ>k__BackingField;    // 0x0x10
    public FMJHJGFPICI <NKBHAICOAID>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OLENBCPOBJL
//   (not directly referenced by a detected call)
public class OLENBCPOBJL
{
    public int <EPGMIFIMLIC>k__BackingField;    // 0x0x10
    public PAFMIKCABPN <KMEFPKIOOOP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ONMNEMLNKCE
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.Auth]
public class ONMNEMLNKCE
{
    public List<string> <NJDBJPJOFLN>k__BackingField;    // 0x0x10
    public List<string> <DIAIPMDFCLN>k__BackingField;    // 0x0x18
    public List<string> <HEAMJFNCJGP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OOPIEPJEGIH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OOPIEPJEGIH
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// OPOGEJDCFGF
//   REQUEST  PUT    api/customAvatarItems   [Service.Auth]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
public class OPOGEJDCFGF
{
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x10
    public string <NIMDKMGPONB>k__BackingField;    // 0x0x18
    public int? <FPPLDFPFALA>k__BackingField;    // 0x0x20
    public ODGMKINPFBN? <KJEOOGFLGPN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// OPPIAFJFMBA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OPPIAFJFMBA
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// PAFMIKCABPN
//   REQUEST  PUT    api/roomconsumables   [Service.WWW]
public class PAFMIKCABPN
{
    public Guid? <HGOCFCNNLDO>k__BackingField;    // 0x0x10
    public Guid <HOJDPNGEFEE>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// PHAEPOFKPJL
//   REQUEST  POST   api/equipment/v1/update   [Service.WWW]
public class PHAEPOFKPJL
{
    public string <JAOEGIAKBKK>k__BackingField;    // 0x0x10
    public string <BBINFIOIDOK>k__BackingField;    // 0x0x18
    public string <JGFKDOFFBKI>k__BackingField;    // 0x0x20
    public string <MJPFPLNPCPO>k__BackingField;    // 0x0x28
    public MGIOIPCGJCG <OJIIGIPAMMI>k__BackingField;    // 0x0x30
    public bool DBCLMPEIGJE;    // 0x0x34
    public bool <ELGJDADFIIB>k__BackingField;    // 0x0x35
}

// --------------------------------------------------------------------------
// PJBHIBBJPFH
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2/delete/{fEHFONEBDKD}   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2/{eventId}   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/accessibility   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/club   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/description   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/image   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/multiinstance   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/name   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/room   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/tags   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/time   [Service.Auth]
public class PJBHIBBJPFH
{
    public GONKACDHNKI <OLJGHMANKOG>k__BackingField;    // 0x0x10
    public AHJBPGOPDGN <JDPHBIBLBMD>k__BackingField;    // 0x0x18
    public OHNNLGDGNCB <PLPPGPPFJFD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PLEPGDECPNI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PLEPGDECPNI
{
    All = -1,
    Steam = 0,
    Oculus = 1,
    PlayStation = 2,
    Xbox = 3,
    RecNet = 4,
    IOS = 5,
    GooglePlay = 6,
    Standalone = 7,
    Pico = 8,
    Toaster = 9,
}

// --------------------------------------------------------------------------
// PLOIOIEOEJH
// base   : AIDCCFPBGMO
//   (not directly referenced by a detected call)
public class PLOIOIEOEJH : AIDCCFPBGMO
{
    public int <MALOKDONEGI>k__BackingField;    // 0x0x68
    public List<NMFLFMJGIBG> <NPIECFPFLOM>k__BackingField;    // 0x0x70
    public List<NMFLFMJGIBG> <MPAALIPLFOG>k__BackingField;    // 0x0x78
    public List<NMFLFMJGIBG> <FCJILKGCOCO>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// PMFKDFGFMAF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PMFKDFGFMAF
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// PPFGNAGBKHC
//   (not directly referenced by a detected call)
public class PPFGNAGBKHC
{
    public long <BPBNAMLJBFB>k__BackingField;    // 0x0x10
    public long <GNAFLLINCPA>k__BackingField;    // 0x0x18
    public int <ADLIKFIIJFK>k__BackingField;    // 0x0x20
    public DateTime <GMLBHPGIMLP>k__BackingField;    // 0x0x28
    public EGFFOONAEIC <LBGEGKNDKBB>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.Clubs]
public class AddKeepsakeInstanceRequest
{
    public long <AMMGFAOLMNI>k__BackingField;    // 0x0x10
    public long? <FPKAFOKIKHH>k__BackingField;    // 0x0x18
    public FLNOLEHFNJH <OOICDONEBMO>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddVersionInventionRequestDTO
//   REQUEST  POST   api/inventions/v6/addversion   [Service.Notifications]
public class AddVersionInventionRequestDTO
{
    public long inventionId;    // 0x0x10
    public int instantiationCost;    // 0x0x18
    public int lightsCost;    // 0x0x1C
    public int chipsCost;    // 0x0x20
    public int cloudVariablesCost;    // 0x0x24
    public int aiCost;    // 0x0x28
    public byte ugcVersion;    // 0x0x2C
    public long creationRoomId;    // 0x0x30
    public string inventionDataFilename;    // 0x0x38
    public List<long> referencedInventions;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.AppleMusicPromotionResponseDTO
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.Auth]
public class AppleMusicPromotionResponseDTO
{
    public IEIHEFPLDLO <JDPHBIBLBMD>k__BackingField;    // 0x0x10
    public string <OJJLFLOCMNP>k__BackingField;    // 0x0x18
    public string <BBKCHJIKHDG>k__BackingField;    // 0x0x20
    public string <NKPHFLDOEJD>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public EIIOBKGCMGK <CurrencyType>k__BackingField;    // 0x0x18
    public BNNNMOMOCDJ <BalanceType>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.CheerRequest
//   REQUEST  POST   api/inventions/v1/cheer   [Service.Auth]
public class CheerRequest
{
    public long InventionId;    // 0x0x10
    public bool Cheer;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.DeleteMessagesRequestDTO
//   REQUEST  POST   api/messages/v3/delete   [Service.Auth]
public class DeleteMessagesRequestDTO
{
    public List<long> MessageIds;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Events.BroadcastRoomInstanceRequest
//   REQUEST  POST   api/playerevents/v1/broadcast   [Service.Auth]
public class BroadcastRoomInstanceRequest
{
    public long <GNAFLLINCPA>k__BackingField;    // 0x0x10
    public long? <ELMLJMHIIJD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.BulkInviteRequest
//   REQUEST  POST   api/playerevents/v1/bulkInvite   [Service.Auth]
public class BulkInviteRequest
{
    public long PlayerEventId;    // 0x0x10
    public List<int> InvitedPlayerIds;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.DeleteResponseRequest
//   REQUEST  POST   api/playerevents/v1/deleteResponse   [Service.Auth]
public class DeleteResponseRequest
{
    public long PlayerEventId;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.GetNearbyScoresRequestDTO
// base   : RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetNearbyScoresRequestDTO : GetRankRequestDTO
{
    public int WindowSize;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetRankRequestDTO
{
    public int PlayerId;    // 0x0x10
    public int StatChannel;    // 0x0x14
    public long RoomId;    // 0x0x18
    public NACICJEECHA FilterType;    // 0x0x20
    public bool SortAscending;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.GetRanksRequestDTO
// base   : RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetRanksRequestDTO : GetRankRequestDTO
{
    public int RankStart;    // 0x0x28
    public int RankEnd;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCategoryConfigDTO
//   (not directly referenced by a detected call)
public class KeepsakeCategoryConfigDTO
{
    public FLNOLEHFNJH <IKKOEBGHMPM>k__BackingField;    // 0x0x10
    public string <PBDHEKBFKHN>k__BackingField;    // 0x0x18
    public int <BCBBOBIGPOI>k__BackingField;    // 0x0x20
    public int <ABKJMNGANLL>k__BackingField;    // 0x0x24
    public string <FJDFEINENJP>k__BackingField;    // 0x0x28
    public string <MDPKFIJOCAJ>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <PFAELLHPALI>k__BackingField;    // 0x0x10
    public Guid <PJCPDOICPNA>k__BackingField;    // 0x0x14
    public DateTime <FJOICEHHPBH>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.Auth]
public class KeepsakeGlobalConfigDTO
{
    public bool <EDDMMPLPPMF>k__BackingField;    // 0x0x10
    public int <CBOOMPAGINB>k__BackingField;    // 0x0x14
    public bool <FEPMHONJLHF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <PJCPDOICPNA>k__BackingField;    // 0x0x10
    public FLNOLEHFNJH <CLILCHAJJPE>k__BackingField;    // 0x0x20
    public int <BEDMAOOJIOG>k__BackingField;    // 0x0x24
    public long <AMMGFAOLMNI>k__BackingField;    // 0x0x28
    public long? <FPKAFOKIKHH>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.Auth]
//   RESPONSE GET    api/keepsakes/events/{eFDCNAHAIBL}   [Service.Auth]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <KIIDKDKKCPJ>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <EIALBEHIIKG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <CKLCCEMOCAE>k__BackingField;    // 0x0x10
    public long <AMMGFAOLMNI>k__BackingField;    // 0x0x18
    public long <PCKFAEACFIG>k__BackingField;    // 0x0x20
    public IBIOAHKMIPG <LBGEGKNDKBB>k__BackingField;    // 0x0x28
    public int <GELJOHKKAPE>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <AMMGFAOLMNI>k__BackingField;    // 0x0x10
    public List<Guid> <JHAKMHGLPBK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <KIIDKDKKCPJ>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <EIALBEHIIKG>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <NNJACFCCEAM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <PCKFAEACFIG>k__BackingField;    // 0x0x10
    public long <NEOGCNHGPHO>k__BackingField;    // 0x0x18
    public int? <KKCKLDILPJH>k__BackingField;    // 0x0x20
    public int? <PEEGKFEGKNP>k__BackingField;    // 0x0x28
    public long? <BOIHKJGHNGN>k__BackingField;    // 0x0x30
    public long <PHIIHBOGDKB>k__BackingField;    // 0x0x40
    public long <DCCKHHFBAME>k__BackingField;    // 0x0x48
    public int <LONDBALNACA>k__BackingField;    // 0x0x50
    public IBIOAHKMIPG <DMGBCLDBDGP>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <KEEBIMALGHJ>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.KickPlayerDTO
//   REQUEST  POST   api/PlayerReporting/v1/instantKick   [Service.Auth]
public class KickPlayerDTO
{
    public long GameSessionId;    // 0x0x10
    public List<int> PlayerIds;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ModifyTagsRequest
//   REQUEST  POST   api/inventions/v1/settags   [Service.Auth]
public class ModifyTagsRequest
{
    public long InventionId;    // 0x0x10
    public List<string> AutoTags;    // 0x0x18
    public List<string> CustomTags;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.MultiRecipientFreeGiftRequestDTO
//   REQUEST  POST   api/freegifts/v1/sendmultiple   [Service.?]
public class MultiRecipientFreeGiftRequestDTO
{
    public List<int> <ToPlayerIds>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public CEGKDIEDEMO <GiftContext>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.NewInventionRequestDTO
//   REQUEST  POST   api/inventions/v7/save   [Service.?]
public class NewInventionRequestDTO
{
    public string name;    // 0x0x10
    public string description;    // 0x0x18
    public string imageName;    // 0x0x20
    public int instantiationCost;    // 0x0x28
    public int lightsCost;    // 0x0x2C
    public int chipsCost;    // 0x0x30
    public int cloudVariablesCost;    // 0x0x34
    public int aiCost;    // 0x0x38
    public byte ugcVersion;    // 0x0x3C
    public long creationRoomId;    // 0x0x40
    public string inventionDataFilename;    // 0x0x48
    public List<long> referencedInventions;    // 0x0x50
    public CDGDFMGKCOP creatorAccountRole;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public IJGAMLLIHPF <OKFFBAJLILI>k__BackingField;    // 0x0x10
    public EGNNLENPPIO <IEILGPOLKKI>k__BackingField;    // 0x0x14
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x18
    public string <NIMDKMGPONB>k__BackingField;    // 0x0x20
    public bool <BBGDDOJONLL>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<IJGAMLLIHPF> <EJHKGGBGEDJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/event/{fEHFONEBDKD}   [Service.Auth]
public class ProgressionEventDTO
{
    public long <NEOGCNHGPHO>k__BackingField;    // 0x0x10
    public string <MDMEOLHDHPJ>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <FCJILKGCOCO>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <JLFCCKAJCGJ>k__BackingField;    // 0x0x28
    public DateTime <FHAIHEHMPEB>k__BackingField;    // 0x0x30
    public DateTime <PPAEEOJLJBB>k__BackingField;    // 0x0x38
    public DateTime <EOJMPHKKNOG>k__BackingField;    // 0x0x40
    public bool <BLHCLDBNNBM>k__BackingField;    // 0x0x48
    public int <AOHLPLNMOCH>k__BackingField;    // 0x0x4C
    public float <IMBEKHLHJCI>k__BackingField;    // 0x0x50
    public Guid? <INFHLNFGLPB>k__BackingField;    // 0x0x54
    public string <BKIEFELACPO>k__BackingField;    // 0x0x68
    public string <FONFIJEPIPF>k__BackingField;    // 0x0x70
    public string <CNCDKHHBCBL>k__BackingField;    // 0x0x78
    public string <CPBPCAHLHII>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <KIALACKHNJF>k__BackingField;    // 0x0x10
    public int <OJDKIBGPAMO>k__BackingField;    // 0x0x20
    public int <EGFPMGEMGPE>k__BackingField;    // 0x0x24
    public int <CJOKAGAINBP>k__BackingField;    // 0x0x28
    public long <FHMIIDFGMAI>k__BackingField;    // 0x0x30
    public long <JGJMODKBFMN>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.Auth]
public class ProgressionEventRecordDTO
{
    public int <PFAELLHPALI>k__BackingField;    // 0x0x10
    public int <NIAFKECOPDH>k__BackingField;    // 0x0x14
    public int <GFKNDINOPON>k__BackingField;    // 0x0x18
    public int <FKKPBEAIKOE>k__BackingField;    // 0x0x1C
    public int <EHPEDKICMMC>k__BackingField;    // 0x0x20
    public DateTime? <JCNNOGEBMAB>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <HNBJFEFJJOE>k__BackingField;    // 0x0x10
    public int <DOBKMMKAGND>k__BackingField;    // 0x0x18
    public string <LGIGELLKDPH>k__BackingField;    // 0x0x20
    public int <NIAFKECOPDH>k__BackingField;    // 0x0x28
    public int <AALMLBOEPLB>k__BackingField;    // 0x0x2C
    public bool <GNJCKCMHEIC>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.Auth]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public PNEGHGGHJML ReportCategory;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.SetStatRequestDTO
//   (not directly referenced by a detected call)
public class SetStatRequestDTO
{
    public int <StatChannel>k__BackingField;    // 0x0x10
    public long <RoomId>k__BackingField;    // 0x0x18
    public int <StatValue>k__BackingField;    // 0x0x20
    public int? <CurrentStatValue>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.UpdatePriceRequest
//   REQUEST  POST   api/inventions/v1/updateprice   [Service.Auth]
public class UpdatePriceRequest
{
    public long InventionId;    // 0x0x10
    public int Price;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.Debugging.AutocompleteResult
// base   : UnityEngine.MonoBehaviour
//   (not directly referenced by a detected call)
public class AutocompleteResult : MonoBehaviour
{
    public RawImage backgroundImage;    // 0x0x18
    public TMP_Text text;    // 0x0x20
    public bool EOHCOOMMJAI;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class SA_Result
{
    public SA_Error m_error;    // 0x0x10
    public string m_requestId;    // 0x0x18
    public string m_stringData;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.Foundation.Templates.SA_iResult
//   (not directly referenced by a detected call)
public class SA_iResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.Contacts.ISN_CNContactsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_CNContactsResult : SA_Result
{
    public List<ISN_CNContact> m_Contacts;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.Social.ISN_MessageComposeResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ISN_MessageComposeResult
{
    Cancelled = 0,
    Sent = 1,
    Failed = 2,
    NotSupportedByDevice = 3,
}

// --------------------------------------------------------------------------
// SA.iOS.Social.ISN_UIActivityViewControllerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIActivityViewControllerResult : SA_Result
{
    public string m_ActivityType;    // 0x0x28
    public bool m_Completed;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKProductsResponse
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_SKProductsResponse : SA_Result
{
    public List<ISN_SKProduct> m_Products;    // 0x0x28
    public List<string> m_InvalidProductIdentifiers;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKReceiptRefreshRequest
// base   : SA.iOS.StoreKit.ISN_SKRequest
//   (not directly referenced by a detected call)
public class ISN_SKReceiptRefreshRequest : ISN_SKRequest
{
    public ISN_SKReceiptDictionary m_Properties;    // 0x0x10
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKRequest
//   (not directly referenced by a detected call)
public class ISN_SKRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIPickerControllerRequest
//   (not directly referenced by a detected call)
public class ISN_UIPickerControllerRequest
{
    public List<string> m_MediaTypes;    // 0x0x10
    public float m_ImageCompressionRate;    // 0x0x18
    public int m_MaxImageSize;    // 0x0x1C
    public ISN_UIImageCompressionFormat m_EncodingType;    // 0x0x20
    public ISN_UIModalPresentationStyle m_ModalPresentationStyle;    // 0x0x24
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIPickerControllerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIPickerControllerResult : SA_Result
{
    public string m_EncodedImage;    // 0x0x28
    public string m_MediaUrl;    // 0x0x30
    public string m_ImageUrl;    // 0x0x38
    public string m_MediaType;    // 0x0x40
    public Texture2D m_Texture;    // 0x0x48
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIRegisterRemoteNotificationsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIRegisterRemoteNotificationsResult : SA_Result
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.UserNotifications.ISN_UNNotificationRequest
//   (not directly referenced by a detected call)
public class ISN_UNNotificationRequest
{
    public string m_Identifier;    // 0x0x10
    public ISN_UNNotificationContent m_Content;    // 0x0x18
    public ISN_UNNotificationTrigger m_Trigger;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.UserNotifications.ISN_UNNotificationResponse
//   (not directly referenced by a detected call)
public class ISN_UNNotificationResponse
{
    public ISN_UNNotification m_Notification;    // 0x0x10
    public string m_ActionIdentifier;    // 0x0x18
}

// --------------------------------------------------------------------------
// Steamworks.CallResult
//   (not directly referenced by a detected call)
public class CallResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Steamworks.EResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EResult
{
    k_EResultNone = 0,
    k_EResultOK = 1,
    k_EResultFail = 2,
    k_EResultNoConnection = 3,
    k_EResultInvalidPassword = 5,
    k_EResultLoggedInElsewhere = 6,
    k_EResultInvalidProtocolVer = 7,
    k_EResultInvalidParam = 8,
    k_EResultFileNotFound = 9,
    k_EResultBusy = 10,
    k_EResultInvalidState = 11,
    k_EResultInvalidName = 12,
    k_EResultInvalidEmail = 13,
    k_EResultDuplicateName = 14,
    k_EResultAccessDenied = 15,
    k_EResultTimeout = 16,
    k_EResultBanned = 17,
    k_EResultAccountNotFound = 18,
    k_EResultInvalidSteamID = 19,
    k_EResultServiceUnavailable = 20,
    k_EResultNotLoggedOn = 21,
    k_EResultPending = 22,
    k_EResultEncryptionFailure = 23,
    k_EResultInsufficientPrivilege = 24,
    k_EResultLimitExceeded = 25,
    k_EResultRevoked = 26,
    k_EResultExpired = 27,
    k_EResultAlreadyRedeemed = 28,
    k_EResultDuplicateRequest = 29,
    k_EResultAlreadyOwned = 30,
    k_EResultIPNotFound = 31,
    k_EResultPersistFailed = 32,
    k_EResultLockingFailed = 33,
    k_EResultLogonSessionReplaced = 34,
    k_EResultConnectFailed = 35,
    k_EResultHandshakeFailed = 36,
    k_EResultIOFailure = 37,
    k_EResultRemoteDisconnect = 38,
    k_EResultShoppingCartNotFound = 39,
    k_EResultBlocked = 40,
    k_EResultIgnored = 41,
    k_EResultNoMatch = 42,
    k_EResultAccountDisabled = 43,
    k_EResultServiceReadOnly = 44,
    k_EResultAccountNotFeatured = 45,
    k_EResultAdministratorOK = 46,
    k_EResultContentVersion = 47,
    k_EResultTryAnotherCM = 48,
    k_EResultPasswordRequiredToKickSession = 49,
    k_EResultAlreadyLoggedInElsewhere = 50,
    k_EResultSuspended = 51,
    k_EResultCancelled = 52,
    k_EResultDataCorruption = 53,
    k_EResultDiskFull = 54,
    k_EResultRemoteCallFailed = 55,
    k_EResultPasswordUnset = 56,
    k_EResultExternalAccountUnlinked = 57,
    k_EResultPSNTicketInvalid = 58,
    k_EResultExternalAccountAlreadyLinked = 59,
    k_EResultRemoteFileConflict = 60,
    k_EResultIllegalPassword = 61,
    k_EResultSameAsPreviousValue = 62,
    k_EResultAccountLogonDenied = 63,
    k_EResultCannotUseOldPassword = 64,
    k_EResultInvalidLoginAuthCode = 65,
    k_EResultAccountLogonDeniedNoMail = 66,
    k_EResultHardwareNotCapableOfIPT = 67,
    k_EResultIPTInitError = 68,
    k_EResultParentalControlRestricted = 69,
    k_EResultFacebookQueryError = 70,
    k_EResultExpiredLoginAuthCode = 71,
    k_EResultIPLoginRestrictionFailed = 72,
    k_EResultAccountLockedDown = 73,
    k_EResultAccountLogonDeniedVerifiedEmailRequired = 74,
    k_EResultNoMatchingURL = 75,
    k_EResultBadResponse = 76,
    k_EResultRequirePasswordReEntry = 77,
    k_EResultValueOutOfRange = 78,
    k_EResultUnexpectedError = 79,
    k_EResultDisabled = 80,
    k_EResultInvalidCEGSubmission = 81,
    k_EResultRestrictedDevice = 82,
    k_EResultRegionLocked = 83,
    k_EResultRateLimitExceeded = 84,
    k_EResultAccountLoginDeniedNeedTwoFactor = 85,
    k_EResultItemDeleted = 86,
    k_EResultAccountLoginDeniedThrottle = 87,
    k_EResultTwoFactorCodeMismatch = 88,
    k_EResultTwoFactorActivationCodeMismatch = 89,
    k_EResultAccountAssociatedToMultiplePartners = 90,
    k_EResultNotModified = 91,
    k_EResultNoMobileDevice = 92,
    k_EResultTimeNotSynced = 93,
    k_EResultSmsCodeFailed = 94,
    k_EResultAccountLimitExceeded = 95,
    k_EResultAccountActivityLimitExceeded = 96,
    k_EResultPhoneActivityLimitExceeded = 97,
    k_EResultRefundToWallet = 98,
    k_EResultEmailSendFailure = 99,
    k_EResultNotSettled = 100,
    k_EResultNeedCaptcha = 101,
    k_EResultGSLTDenied = 102,
    k_EResultGSOwnerDenied = 103,
    k_EResultInvalidItemType = 104,
    k_EResultIPBanned = 105,
    k_EResultGSLTExpired = 106,
    k_EResultInsufficientFunds = 107,
    k_EResultTooManyPending = 108,
    k_EResultNoSiteLicensesFound = 109,
    k_EResultWGNetworkSendExceeded = 110,
    k_EResultAccountNotFriends = 111,
    k_EResultLimitedUserAccount = 112,
    k_EResultCantRemoveItem = 113,
    k_EResultAccountDeleted = 114,
    k_EResultExistingUserCancelledLicense = 115,
}

// --------------------------------------------------------------------------
// Unity.Scenes.PrefabLoadResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class PrefabLoadResult : ValueType
{
    public Entity PrefabRoot;    // 0x0x0
}

// --------------------------------------------------------------------------
// Unity.Scenes.WeakAssetPrefabLoadRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class WeakAssetPrefabLoadRequest : ValueType
{
    public EntityPrefabReference WeakReferenceId;    // 0x0x0
}

// ==========================================================================
// SYNTHESIZED request DTOs: no wire body DTO was observed;
// these are built from observed form/query params, wrapper
// params and candidate keys. Field origins: form = POST/PUT
// form field, query = URL query param, wrapper = wrapper
// signature (not observed on wire), candidate = low
// confidence key. Names derive from the route.
// ==========================================================================

// api/CampusCard/v1/UpdateAndGetSubscription  [WWW POST]
public class CampusCardV1UpdateAndGetSubscriptionRequest
{
    public string accessToken;  // wrapper
}

// api/PlayerCheer/v1/SetSelectedCheer  [Auth POST]
public class PlayerCheerV1SetSelectedCheerRequest
{
    public NCCMDFEFJMD? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [Auth POST]
public class PlayerCheerV1CreateRequest
{
    public NCCMDFEFJMD KKPHKOOLKKI;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [Auth POST]
public class PlayerReportingV1DeviceIdRequest
{
    public PLEPGDECPNI AEDJHBBNMDI;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [Auth POST]
public class PlayerReportingV1HileRequest
{
    public PPEOHELPGKG HKAKMPIMEOA;  // wrapper
    public int? DPMAKAPEEOJ;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v1/moderationBlockDetails  [Auth POST]
public class PlayerReportingV1ModerationBlockDetailsRequest
{
    public string deviceToken;  // wrapper
}

// api/PlayerReporting/v3/create  [Auth POST]
public class PlayerReportingV3CreateRequest
{
    public BNEIAIPPEJJ PNCHLKMPFGB;  // wrapper
    public float? HFAHAGJNDJI;  // wrapper
    public bool? HMDLJGJAGDG;  // wrapper
    public object IsFullBodyAvatarReport;  // candidate
    public object IsReporterFullBodyAvatar;  // candidate
    public object IsGiftingReport;  // candidate
    public object ReportCategory;  // candidate
    public object HeightReporter;  // candidate
}

// api/PlayerReporting/v3/voteToKick  [Auth POST]
public class PlayerReportingV3VoteToKickRequest
{
    public object Response;  // candidate
    public object GameSessionId;  // candidate
    public object PlayerId;  // candidate
    public object Reason;  // candidate
}

// api/avatar/v1/lockeditems  [WWW GET]
public class AvatarV1LockeditemsRequest
{
    public List<JEMEAOBLCBJ> desc;  // wrapper
}

// api/avatar/v2/gifts/generate  [WWW POST]
public class AvatarV2GiftsGenerateRequest
{
    public CEGKDIEDEMO BHFMOMNKABO;  // wrapper
    public CEGKDIEDEMO? HELAPHIBDDB;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [WWW POST]
public class AvatarV3GiftsGenerateRequest
{
    public CEGKDIEDEMO BHFMOMNKABO;  // wrapper
    public CEGKDIEDEMO? HELAPHIBDDB;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/chatreport/createChatReport  [? POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage CLBGCJICGJG;  // wrapper
    public DIEMBCHGHAF PNCHLKMPFGB;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [Notifications POST]
public class ClubreportingV1ReportRequest
{
    public BNEIAIPPEJJ PNCHLKMPFGB;  // wrapper
    public object details;  // candidate
    public object clubId;  // candidate
    public object reportCategory;  // candidate
}

// api/config/v1/backtrace  [Auth GET]
public class ConfigV1BacktraceRequest
{
    public object allocate;  // candidate
    public object platformType;  // candidate
}

// api/customAvatarItems/v1  [Auth POST]
public class CustomAvatarItemsV1Request
{
    public ODGMKINPFBN FNGANFOBOIH;  // wrapper
    public CEMBDFFDHML ACGKOLFDLLE;  // wrapper
    public IKKDFOKDDAE PGGPCDIOCJA;  // wrapper
    public IKKDFOKDDAE DBPICADCKFC;  // wrapper
    public object metadata;  // candidate
    public object thumbnailImage;  // candidate
    public object design;  // candidate
    public object file.bin;  // candidate
}

// api/customAvatarItems/v1/design  [Auth GET]
public class CustomAvatarItemsV1DesignRequest
{
    public object metadata;  // candidate
    public object design;  // candidate
    public object file.bin;  // candidate
}

// api/customAvatarItems/v1/me  [Auth GET]
public class CustomAvatarItemsV1MeRequest
{
    public object take;  // candidate
    public object skip;  // candidate
}

// api/customAvatarItems/v1/search  [Auth GET]
public class CustomAvatarItemsV1SearchRequest
{
    public object minPrice;  // candidate
    public object isOwned;  // candidate
    public object itemTypes;  // candidate
    public object isFeatured;  // candidate
    public object creatorUsername;  // candidate
}

// api/externalfriendinvite/v1/createplatforminvite  [Auth POST]
public class ExternalfriendinviteV1CreateplatforminviteRequest
{
    public string platformId;  // wrapper
}

// api/externalfriendinvite/v1/sendtextmessageinvite  [Auth POST]
public class ExternalfriendinviteV1SendtextmessageinviteRequest
{
    public object phoneNumber;  // candidate
    public object senderName;  // candidate
    public object friendCode;  // candidate
}

// api/gamerewards/v1/request  [WWW POST]
public class GamerewardsV1RequestRequest
{
    public NOPJJGHAFOM ICDOLPCMKND;  // wrapper
    public CEGKDIEDEMO? BAGBBBCOBGH;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [WWW POST]
public class GamerewardsV1SelectRequest
{
    public BKDAEODKDDA PHIILHEALNI;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/images/  [Auth GET]
public class ImagesRequest
{
    public object sort;  // candidate
    public object filter;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/images/v4/room/{roomId}  [? GET]
public class ImagesV4RoomRoomIdRequest
{
    public object filter;  // candidate
    public object sort;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/images/v5/bulk  [Auth ?]
public class ImagesV5BulkRequest
{
    public List<long> ids;  // param
}

// api/images/v5/cheered/bulk  [Auth ?]
public class ImagesV5CheeredBulkRequest
{
    public List<long> id;  // param
}

// api/images/v5/player/{playerId}  [Auth GET]
public class ImagesV5PlayerPlayerIdRequest
{
    public object sort;  // candidate
}

// api/images/v6  [Auth GET]
public class ImagesV6Request
{
    public string name;  // wrapper
}

// api/incentivizedreferrals/claim  [WWW POST]
public class IncentivizedreferralsClaimRequest
{
    public int ReferralRewardId;  // wrapper
}

// api/incentivizedreferrals/referrals  [WWW GET]
public class IncentivizedreferralsReferralsRequest
{
    public object continuationToken;  // candidate
    public object take;  // candidate
}

// api/influencerpartnerprogram/influencer  [WWW GET]
public class InfluencerpartnerprogramInfluencerRequest
{
    public int accountId;  // wrapper
}

// api/influencerpartnerprogram/influencers  [WWW GET]
public class InfluencerpartnerprogramInfluencersRequest
{
    public object continuationToken;  // candidate
    public object take;  // candidate
}

// api/influencerpartnerprogram/remove  [WWW POST]
public class InfluencerpartnerprogramRemoveRequest
{
    public int influencerAccountId;  // wrapper
}

// api/influencerpartnerprogram/support  [WWW POST]
public class InfluencerpartnerprogramSupportRequest
{
    public int influencerAccountId;  // wrapper
}

// api/inventions/v1/delete  [Auth GET]
public class InventionsV1DeleteRequest
{
    public DGBANILGEPE inventionId;  // wrapper
}

// api/inventions/v1/details  [Auth GET]
public class InventionsV1DetailsRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v1/dormskinsfromids  [Auth ?]
public class InventionsV1DormskinsfromidsRequest
{
    public List<long> ids;  // param
}

// api/inventions/v1/fulllineageowner  [Auth GET]
public class InventionsV1FulllineageownerRequest
{
    public List<long> id;  // query
}

// api/inventions/v1/unpublish  [Auth GET]
public class InventionsV1UnpublishRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v1/update  [Auth GET]
public class InventionsV1UpdateRequest
{
    public object name;  // candidate
    public object inventionId;  // candidate
    public object description;  // candidate
    public object imgName;  // candidate
    public object permission;  // candidate
}

// api/inventions/v1/versions  [Auth GET]
public class InventionsV1VersionsRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v2/batch  [Auth ?]
public class InventionsV2BatchRequest
{
    public List<long> id;  // param
}

// api/inventions/v2/search  [Auth GET]
public class InventionsV2SearchRequest
{
    public object value;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/inventions/v3/publish  [Auth GET]
public class InventionsV3PublishRequest
{
    public object price;  // candidate
    public object accessibility;  // candidate
    public object permissionLevel;  // candidate
    public object inventionId;  // candidate
}

// api/itemWishlists/v1/isonwishlist/bulk  [WWW POST]
public class ItemWishlistsV1IsonwishlistBulkRequest
{
    public List<int> accountIds;  // form
}

// api/keepsakes/{kODBMCEMBGH}/collect  [Auth POST]
public class KeepsakesKODBMCEMBGHCollectRequest
{
    public Guid KODBMCEMBGH;  // wrapper
}

// api/messages/v2/send  [Auth POST]
public class MessagesV2SendRequest
{
    public OOPIKCAIJDO GILPJEDOLIL;  // wrapper
    public long? LNOJCNCBDMF;  // wrapper
    public object ToPlayerId;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
}

// api/offlineinvite/v1/send  [? POST]
public class OfflineinviteV1SendRequest
{
    public long PlayerId;  // wrapper
}

// api/playerevents/v1/bulk  [Auth POST]
public class PlayereventsV1BulkRequest
{
    public List<long> Ids;  // form
}

// api/playerevents/v1/clubs  [Auth POST]
public class PlayereventsV1ClubsRequest
{
    public IReadOnlyCollection<long> KPKNOIGNJPD;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [Auth PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public PMFKDFGFMAF FNGANFOBOIH;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [Auth PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? IANJHEGBGKO;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [Auth PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public IGCFCLKMICH LPFDHNJBGLH;  // wrapper
    public IGCFCLKMICH KALPOCIFPLP;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [Auth PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? EIPINGDKEKJ;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [Auth PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime AINMCCGACCK;  // wrapper
    public DateTime NOHMAHIJEGB;  // wrapper
}

// api/playeritems/v1/isavataritemowned/bulk  [WWW POST]
public class PlayeritemsV1IsavataritemownedBulkRequest
{
    public List<int> accountIds;  // form
}

// api/playeritems/v1/isequipmentitemowned/bulk  [WWW POST]
public class PlayeritemsV1IsequipmentitemownedBulkRequest
{
    public List<int> accountIds;  // form
}

// api/playerwarnings  [Auth POST]
public class PlayerwarningsRequest
{
    public BNEIAIPPEJJ PNCHLKMPFGB;  // wrapper
    public object ModeratorNote;  // candidate
    public object WarnedPlayerId;  // candidate
    public object ReportCategory;  // candidate
    public object DisplayReason;  // candidate
}

// api/relationships/  [Auth POST]
public class RelationshipsRequest
{
    public object PlayerId;  // candidate
}

// api/relationships/v1/addfriendwithcode  [Auth GET]
public class RelationshipsV1AddfriendwithcodeRequest
{
    public object code;  // candidate
}

// api/roomCurrencies/v2/purchase  [? POST]
public class RoomCurrenciesV2PurchaseRequest
{
    public Guid DPLGALNDIED;  // wrapper
    public object PurchaseOfferId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedAmount;  // candidate
}

// api/roomcurrencies/v1/createCurrency  [WWW POST]
public class RoomcurrenciesV1CreateCurrencyRequest
{
    public object Color;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
    public object Shape;  // candidate
}

// api/roomcurrencies/v1/createPurchaseOffer  [WWW POST]
public class RoomcurrenciesV1CreatePurchaseOfferRequest
{
    public Guid LKBHPBNFOON;  // wrapper
    public object Price;  // candidate
    public object CurrencyId;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object Order;  // candidate
}

// api/roomcurrencies/v1/currencies  [WWW GET]
public class RoomcurrenciesV1CurrenciesRequest
{
    public object roomId;  // candidate
}

// api/roomcurrencies/v1/deletePurchaseOffer  [WWW POST]
public class RoomcurrenciesV1DeletePurchaseOfferRequest
{
    public Guid PurchaseOfferId;  // wrapper
}

// api/roomcurrencies/v1/getAllBalances  [WWW GET]
public class RoomcurrenciesV1GetAllBalancesRequest
{
    public object roomId;  // candidate
}

// api/roomcurrencies/v1/getBalance  [WWW GET]
public class RoomcurrenciesV1GetBalanceRequest
{
    public object accountId;  // candidate
    public object currencyId;  // candidate
}

// api/roomcurrencies/v1/updateCurrency  [WWW POST]
public class RoomcurrenciesV1UpdateCurrencyRequest
{
    public Guid LKBHPBNFOON;  // wrapper
    public long? CABCMGBCFCB;  // wrapper
    public byte? FICMNAPEKPJ;  // wrapper
    public int? NLKAPPNAHLI;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [WWW POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid DPLGALNDIED;  // wrapper
    public long? FDEBFBJMLFI;  // wrapper
    public long? LMGMCKPMEJJ;  // wrapper
    public int? KNLOPIKAPPL;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [WWW PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> EKJGIMBPPBA;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [WWW POST]
public class RoomkeysV1CreateRequest
{
    public JMGFFIKDGLJ HKAKMPIMEOA;  // wrapper
    public Guid? FEFCMHANKMH;  // wrapper
    public object Price;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Type;  // candidate
    public object RoomId;  // candidate
}

// api/roomkeys/v1/owns  [WWW GET]
public class RoomkeysV1OwnsRequest
{
    public object playerId;  // candidate
    public object roomKeyId;  // candidate
}

// api/rooms/v1/verifyRole  [Auth POST]
public class RoomsV1VerifyRoleRequest
{
    public object roomId;  // candidate
    public object role;  // candidate
    public object context;  // candidate
}

// api/rooms/v2/report  [Notifications POST]
public class RoomsV2ReportRequest
{
    public BNEIAIPPEJJ PNCHLKMPFGB;  // wrapper
    public long? JJEGKFPDMOH;  // wrapper
    public Guid? LNAEFMGBMDM;  // wrapper
    public int? DJEEGNEIBKA;  // wrapper
    public object RoomOfferVersion;  // candidate
    public object ReportCategory;  // candidate
    public object RoomOfferId;  // candidate
    public object RoomId;  // candidate
    public object RoomKeyId;  // candidate
}

// api/screensharereports/v1/report  [Notifications POST]
public class ScreensharereportsV1ReportRequest
{
    public object ReportedPlayerId;  // candidate
    public object RoomInstanceId;  // candidate
    public object ImageName;  // candidate
    public object RoomInstanceType;  // candidate
    public object RoomId;  // candidate
}

// api/storefronts/v1/PurchaseRoomKeyWithCurrency  [WWW POST]
public class StorefrontsV1PurchaseRoomKeyWithCurrencyRequest
{
    public Guid NJMNAKEAIJH;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [WWW POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid CEDPPNOPIAM;  // wrapper
    public object progressionEventId;  // candidate
    public object requestedPrice;  // candidate
    public object purchasableXpBoostId;  // candidate
    public object expectedXp;  // candidate
}

// api/storefronts/v1/buyPurchaseReminder  [WWW POST]
public class StorefrontsV1BuyPurchaseReminderRequest
{
    public object purchaseReminderId;  // candidate
    public object requestedPrice;  // candidate
}

// api/storefronts/v1/buyRoomKey  [WWW GET]
public class StorefrontsV1BuyRoomKeyRequest
{
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/trialInvention  [WWW POST]
public class StorefrontsV1TrialInventionRequest
{
    public long inventionId;  // wrapper
}

// api/storefronts/v2/buyInvention  [WWW GET]
public class StorefrontsV2BuyInventionRequest
{
    public object requestedPrice;  // candidate
    public object inventionId;  // candidate
}

// api/testcasemanagement/v1/testcase/  [Auth POST]
public class TestcasemanagementV1TestcaseRequest
{
    public OPPIAFJFMBA GHOBGKGBCHC;  // wrapper
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public int? pid;  // wrapper
}

