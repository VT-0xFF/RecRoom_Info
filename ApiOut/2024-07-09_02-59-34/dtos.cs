// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 206 (plus referenced enums)

// --------------------------------------------------------------------------
// ABLFMCACELL
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs/v2   [Service.Auth]
public class ABLFMCACELL
{
    public List<string> <DHELOBNCOGL>k__BackingField;    // 0x0x10
    public byte <OKJHCKCNOAF>k__BackingField;    // 0x0x18
    public int <CNJHAOPOKNC>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// ABPOFLKOOHN
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2/delete/{mELONOGBNCF}   [Service.Auth]
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
public class ABPOFLKOOHN
{
    public GBOGPNNAIMA <EBLOIBIKLDN>k__BackingField;    // 0x0x10
    public AEGKAFBKAIF <PLHFKIEOJJK>k__BackingField;    // 0x0x18
    public BCNENIALFFD <DMINGLNMJKM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ADBHLGCNHHC
// base   : FFCANEGKDLK
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class ADBHLGCNHHC : FFCANEGKDLK
{
    public DEBCEKGKKOC? <OEDABMAGKHB>k__BackingField;    // 0x0x18
    public DILCGLNFBCF <LDNHCGIGADB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AEGKAFBKAIF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AEGKAFBKAIF
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
// AHCBKPIKOKP
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.Auth]
public class AHCBKPIKOKP
{
    public int? <MHLAEBMEBLC>k__BackingField;    // 0x0x10
    public string <JMFAGPBPBCD>k__BackingField;    // 0x0x18
    public string <NCJMPHBPAIF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AOMAGIFLPKI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AOMAGIFLPKI
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// APIDBEMOOIH
//   (not directly referenced by a detected call)
public class APIDBEMOOIH
{
    public int <GLAMMODEHKK>k__BackingField;    // 0x0x10
    public DateTime? <LLCMNKKFOAA>k__BackingField;    // 0x0x18
    public DateTime? <HPEDHMLEMPM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// BABKNOMNOMK
//   (not directly referenced by a detected call)
public class BABKNOMNOMK
{
    public Guid <NEEOIPBENFK>k__BackingField;    // 0x0x10
    public Guid <FMDHPNHGJPJ>k__BackingField;    // 0x0x20
    public DateTime <CEKCJDCDDHD>k__BackingField;    // 0x0x30
    public List<BIAOCEJKAEM> <HCJEOLKKBFL>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// BCNENIALFFD
//   RESPONSE POST   api/inventions/v1/settags   [Service.Auth]
public class BCNENIALFFD
{
    public CHCFEAJJEAN <PLHFKIEOJJK>k__BackingField;    // 0x0x10
    public List<string> <PHHIFPMFHNN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BFAEMDLKFJD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BFAEMDLKFJD
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// BIAOCEJKAEM
//   (not directly referenced by a detected call)
public class BIAOCEJKAEM
{
    public int <KKGGLFKABGF>k__BackingField;    // 0x0x10
    public string <LNKAHMCBCHB>k__BackingField;    // 0x0x18
    public string <GMKFOMDDMPM>k__BackingField;    // 0x0x20
    public string <ANANBMAFOFB>k__BackingField;    // 0x0x28
    public string <IFGLNJFGOPH>k__BackingField;    // 0x0x30
    public string <APJBOIEBNNO>k__BackingField;    // 0x0x38
    public Guid? <LMPGCPMJNCM>k__BackingField;    // 0x0x40
    public JBOOCIEJCHK? <BFGLLLPMAKL>k__BackingField;    // 0x0x54
    public string <BKJEHCCJDKM>k__BackingField;    // 0x0x60
    public string <CJJMACJPNEI>k__BackingField;    // 0x0x68
    public bool <JBPKFCENHOM>k__BackingField;    // 0x0x70
    public bool <HIKOKCPBDFH>k__BackingField;    // 0x0x71
    public bool <HEABLKGOKBE>k__BackingField;    // 0x0x72
    public KBKNIOMJPOE <GFOOEIHMDJF>k__BackingField;    // 0x0x74
    public DCBGCNMMENB <AFPGLELIILA>k__BackingField;    // 0x0x78
    public int <PKJMNNOJBAJ>k__BackingField;    // 0x0x7C
    public IONLJMILGCO <IJILEIANGPM>k__BackingField;    // 0x0x80
    public PFOAPKFADOF <DPPJOBHHDNL>k__BackingField;    // 0x0x84
    public int? <NPPFPNAKAGC>k__BackingField;    // 0x0x88
    public string <IFDFEABKMDG>k__BackingField;    // 0x0x90
    public int? <OLHLCCFIDDM>k__BackingField;    // 0x0x98
    public int? <CKINPGGFMFE>k__BackingField;    // 0x0xA0
}

// --------------------------------------------------------------------------
// BINEGJAOLIF
//   (not directly referenced by a detected call)
public class BINEGJAOLIF
{
    public bool <AGKMPNCEHNE>k__BackingField;    // 0x0x10
    public BIAOCEJKAEM <KCBDMOCMKOI>k__BackingField;    // 0x0x18
    public float <ALDIEOEIDPJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BLNOFNJOAGA
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
public class BLNOFNJOAGA
{
    public Guid? <INGAKGCBLIL>k__BackingField;    // 0x0x10
    public long? <DJFEMIFLDFL>k__BackingField;    // 0x0x28
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x38
    public string <OKIOLHMEOJN>k__BackingField;    // 0x0x40
    public string <MGBMIOJNCBD>k__BackingField;    // 0x0x48
    public FIHDKMKGBEN <JLKEPAGLMOA>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// BNHMIKGOFID
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.Auth]
public class BNHMIKGOFID
{
    public int <ADFNJBHEGLC>k__BackingField;    // 0x0x10
    public int? <PKBKLPCDJDI>k__BackingField;    // 0x0x14
    public string <GKGLBNJJDJA>k__BackingField;    // 0x0x20
    public string <KKKCMOLFJFN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// BPAAKCNIGPN
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Matchmaking]
public class BPAAKCNIGPN
{
    public Guid <BICJLIOEDIJ>k__BackingField;    // 0x0x10
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x20
    public string <MGBMIOJNCBD>k__BackingField;    // 0x0x28
    public DateTime <CEKCJDCDDHD>k__BackingField;    // 0x0x30
    public DateTime? <PACDHBACOHP>k__BackingField;    // 0x0x38
    public List<BABKNOMNOMK> <KOLADCGBJBJ>k__BackingField;    // 0x0x48
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
// CDBKIOGODGE
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.Auth]
public class CDBKIOGODGE
{
    public int <HDCCGJNDCOM>k__BackingField;    // 0x0x10
    public FPEDNFFGGMM <IKNNHNHDFJP>k__BackingField;    // 0x0x14
    public AHAAHNOKEGC <KCIKKKEMCBC>k__BackingField;    // 0x0x18
    public AHAAHNOKEGC <AANHAMJJDKJ>k__BackingField;    // 0x0x1C
    public AHAAHNOKEGC <JDOCBBILLOP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CHCFEAJJEAN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CHCFEAJJEAN
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
// CHIEMLJNADN
//   REQUEST  POST   api/playerevents/v1/report   [Service.Auth]
public class CHIEMLJNADN
{
    public GAJLOINGNBJ <BGOPIANNJAJ>k__BackingField;    // 0x0x10
    public long <JFFBELDPLEG>k__BackingField;    // 0x0x18
    public string <BFDEAIHJAAL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CKAIFMNNBKE
//   RESPONSE GET    api/inventions/v1/details   [Service.Auth]
public class CKAIFMNNBKE
{
    public List<GGKCDBJFNED> <PHHIFPMFHNN>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// CKOBDLDILON
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CKOBDLDILON
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
// CPMBNLHMCJH
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.WWW]
public class CPMBNLHMCJH
{
    public int <ILGGCHNFFEA>k__BackingField;    // 0x0x10
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
// DAHHNDLPHFE
//   RESPONSE PUT    api/roomkeys/v1/   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Matchmaking]
public class DAHHNDLPHFE
{
    public PIDGONDLECD <JFDMDBMIOAH>k__BackingField;    // 0x0x10
    public MJPLEAIBKPG <AHNHHFPKHMK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DCBGCNMMENB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DCBGCNMMENB
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
// DEBCEKGKKOC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DEBCEKGKKOC
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// DHGLHKCLGNE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DHGLHKCLGNE
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// DILCGLNFBCF
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.WWW]
public class DILCGLNFBCF
{
    public int <KCCKCPBCCPI>k__BackingField;    // 0x0x10
    public Guid <JNMJEGPIGNH>k__BackingField;    // 0x0x14
    public long <BBJBHPMHPOO>k__BackingField;    // 0x0x28
    public DateTime <BOBAHMHDNCM>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// DJEBPAONCEC
// base   : OPAFMLEELGF
//   (not directly referenced by a detected call)
public class DJEBPAONCEC : OPAFMLEELGF
{
    public int <OFKMJEMPOBK>k__BackingField;    // 0x0x68
    public List<BINEGJAOLIF> <NIANFAIPELP>k__BackingField;    // 0x0x70
    public List<BINEGJAOLIF> <JOKHMLFHAGO>k__BackingField;    // 0x0x78
    public List<BINEGJAOLIF> <JBJPMNGABEC>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// DOMMCJMKMNA
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class DOMMCJMKMNA
{
    public KNOAAFBCKLF <BBLFKLGNAAN>k__BackingField;    // 0x0x10
    public FIHDKMKGBEN <ICOMFKJCABF>k__BackingField;    // 0x0x18
    public int <CGDPHAOOGHI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DPKLJFBKNPL
//   (not directly referenced by a detected call)
public class DPKLJFBKNPL
{
    public NHFEFLJCGCO <EBLOIBIKLDN>k__BackingField;    // 0x0x10
    public JDCJMNELLGD <EFKNBANFDFG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EDCNJBINAEK
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.WWW]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.WWW]
public class EDCNJBINAEK
{
    public int <LKBPGINAHDB>k__BackingField;    // 0x0x10
    public int <DJHCEGONBOD>k__BackingField;    // 0x0x14
    public float <CIOGIJBMBEC>k__BackingField;    // 0x0x18
    public float <FFAEHCFCIOL>k__BackingField;    // 0x0x1C
    public bool <JBDGOPOEJPA>k__BackingField;    // 0x0x20
    public bool <FPDJODEMAHM>k__BackingField;    // 0x0x21
    public bool <JLHIBKMFGKN>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// EIJFCFBCFDK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EIJFCFBCFDK
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// EIPBMFPFEAD
//   RESPONSE GET    api/config/v1/backtrace   [Service.Auth]
public class EIPBMFPFEAD
{
    public int <CGMFGKHBKCO>k__BackingField;    // 0x0x10
    public int <DDGEKLEFKKB>k__BackingField;    // 0x0x14
    public float <HFLJOONHNFA>k__BackingField;    // 0x0x18
    public int <ALHOANIJJOP>k__BackingField;    // 0x0x1C
    public int <PDJOOCMCMJH>k__BackingField;    // 0x0x20
    public int <DOKIIFCNJEB>k__BackingField;    // 0x0x24
    public int <DOJIEFBEKGG>k__BackingField;    // 0x0x28
    public string <DABHCHEFKLF>k__BackingField;    // 0x0x30
    public string <MEPDDPHIFPG>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// EJKGHIHGFFD
//   REQUEST  POST   api/roomcurrencies   [Service.WWW]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.WWW]
public class EJKGHIHGFFD
{
    public Guid <MAOHBCDAGML>k__BackingField;    // 0x0x10
    public long <HCEBHDENOOI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EMCFGHOJEPP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EMCFGHOJEPP
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// EMONNAFLJIC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EMONNAFLJIC
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
    Switch = 512,
}

// --------------------------------------------------------------------------
// EPCFEBELCDJ
//   REQUEST  POST   api/equipment/v1/update   [Service.WWW]
public class EPCFEBELCDJ
{
    public string <GFJKHJEHPMK>k__BackingField;    // 0x0x10
    public string <OLHONLOJGEK>k__BackingField;    // 0x0x18
    public string <LNKAHMCBCHB>k__BackingField;    // 0x0x20
    public string <GMKFOMDDMPM>k__BackingField;    // 0x0x28
    public KBKNIOMJPOE <GFOOEIHMDJF>k__BackingField;    // 0x0x30
    public bool MFCOPFEOHFF;    // 0x0x34
    public bool <JLHIBKMFGKN>k__BackingField;    // 0x0x35
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
// FABKFPGELEF
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.Auth]
public class FABKFPGELEF
{
    public List<string> <LLJHKJHIDOJ>k__BackingField;    // 0x0x10
    public List<string> <IMDHEOFDKIO>k__BackingField;    // 0x0x18
    public List<string> <HMKEKFMOCLD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// FBIIDMAAAJO
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.WWW]
public class FBIIDMAAAJO
{
    public long <DJFEMIFLDFL>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <LJEHKNJPNFJ>k__BackingField;    // 0x0x18
    public EIJFCFBCFDK <IGIMBLIIPGG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// FCAIGOOAAJA
//   RESPONSE PUT    api/roomconsumables   [Service.WWW]
public class FCAIGOOAAJA
{
    public CKOBDLDILON <JFDMDBMIOAH>k__BackingField;    // 0x0x10
    public JADKDANHAOK <MCBODCJKEPA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FEPOFBMICJP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FEPOFBMICJP
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
    Switch = 9,
}

// --------------------------------------------------------------------------
// FGJAIMIMBOK
//   (not directly referenced by a detected call)
public class FGJAIMIMBOK
{
    public ObscuredLong <MKINOJBGCCL>k__BackingField;    // 0x0x10
    public string <DFENAGNBKEB>k__BackingField;    // 0x0x38
    public ObscuredInt <FJIBFGJGHNA>k__BackingField;    // 0x0x40
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x58
    public string <OKIOLHMEOJN>k__BackingField;    // 0x0x60
    public string <MGBMIOJNCBD>k__BackingField;    // 0x0x68
    public byte <MNOHHJKCKAF>k__BackingField;    // 0x0x70
    public int <NCAEJDEDKPB>k__BackingField;    // 0x0x74
    public EMCFGHOJEPP <MMNMJGJAOPM>k__BackingField;    // 0x0x78
    public bool <PLBHLDODJJP>k__BackingField;    // 0x0x7C
    public DateTime <BOBAHMHDNCM>k__BackingField;    // 0x0x80
    public DateTime <IPCOOLBFFJF>k__BackingField;    // 0x0x88
    public DateTime? <HDFLFOGOHPM>k__BackingField;    // 0x0x90
    public long? <NCPGCCMNLIH>k__BackingField;    // 0x0xA0
    public int <BDIHHKINPGH>k__BackingField;    // 0x0xB0
    public int <ECCMJCFOBKL>k__BackingField;    // 0x0xB4
    public int <LPGMJKBHCEC>k__BackingField;    // 0x0xB8
    public GCBLFBMGMBJ <FHJFAOADDLF>k__BackingField;    // 0x0xBC
    public GCBLFBMGMBJ <JLPOPAFOPPH>k__BackingField;    // 0x0xC0
    public ObscuredBool <ONNNBKAANEA>k__BackingField;    // 0x0xC4
    public ObscuredBool <IOLFMJDOPAD>k__BackingField;    // 0x0xD0
    public ObscuredBool <EDGBMLEOLKP>k__BackingField;    // 0x0xDC
    public ObscuredBool <EGABGOBLBMA>k__BackingField;    // 0x0xE8
    public int? <OBDKKCPBKDG>k__BackingField;    // 0x0xF4
    public bool <EHENNABKPFI>k__BackingField;    // 0x0xFC
}

// --------------------------------------------------------------------------
// FIHDKMKGBEN
//   (not directly referenced by a detected call)
public class FIHDKMKGBEN
{
    public long <OBDKKCPBKDG>k__BackingField;    // 0x0x10
    public Guid? <JNMJEGPIGNH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FILJIIJJIMD
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.Auth]
public class FILJIIJJIMD
{
    public GAJLOINGNBJ <BGOPIANNJAJ>k__BackingField;    // 0x0x10
    public int <ILGGCHNFFEA>k__BackingField;    // 0x0x14
    public long <OMANMDFJANG>k__BackingField;    // 0x0x18
    public bool <FDBKIMKLBFC>k__BackingField;    // 0x0x20
    public string <IHALGGJDELE>k__BackingField;    // 0x0x28
    public int? <OFNGCGEOMMI>k__BackingField;    // 0x0x30
    public bool <NFFKKEMMFFO>k__BackingField;    // 0x0x38
    public bool <JCHGBJFPGJP>k__BackingField;    // 0x0x39
    public bool <EEKKCBGGNOE>k__BackingField;    // 0x0x3A
    public bool <GOIHEMPFPDE>k__BackingField;    // 0x0x3B
    public string <FPBBCLKDKHB>k__BackingField;    // 0x0x40
    public DateTime? <GPPCCOBJNNE>k__BackingField;    // 0x0x48
    public string <AMOKGNIDKGH>k__BackingField;    // 0x0x58
    public float <JJFMEOIPKOE>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// FJCGJAEGDJP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FJCGJAEGDJP
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// FKGJBOCEMDD
//   REQUEST  POST   api/playerevents/v1/respond   [Service.Auth]
public class FKGJBOCEMDD
{
    public long <JFFBELDPLEG>k__BackingField;    // 0x0x10
    public BFAEMDLKFJD <IKNNHNHDFJP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FKMOEAKMNIM
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{lDMGHHJPLMG}/{nNOKIFIODKC}   [Service.WWW]
public class FKMOEAKMNIM
{
    public DCBGCNMMENB <AFPGLELIILA>k__BackingField;    // 0x0x10
    public KMODHJLAICE <OMFOGNIGHAN>k__BackingField;    // 0x0x14
    public int <GOGBHPCLIBN>k__BackingField;    // 0x0x18
    public int <JMBPMCPOLJE>k__BackingField;    // 0x0x1C
    public int <OEAOPFGJKJI>k__BackingField;    // 0x0x20
    public IALLJFAEKPI <CAAOIHGEFFD>k__BackingField;    // 0x0x24
    public bool <BMFAMEGAFOM>k__BackingField;    // 0x0x28
    public float <LEJMPBINOAD>k__BackingField;    // 0x0x2C
    public int <HPKCBIJIJHJ>k__BackingField;    // 0x0x30
    public bool <NLGJMNLBFGD>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// FODMLAPLKLE
//   RESPONSE GET    api/playerevents/v1/all   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/all/{dBNMHEADMBD}   [Service.Auth]
public class FODMLAPLKLE
{
    public List<NHFEFLJCGCO> <CIAEIONHBAP>k__BackingField;    // 0x0x10
    public List<DPKLJFBKNPL> <PLFDJOIEDDI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FOJABMDADAG
//   RESPONSE POST   api/chatreport/createChatReport   [Service.?]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.WWW]
//   RESPONSE POST   api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.Auth]
//   RESPONSE DELETE api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.Auth]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.Auth]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.WWW]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.WWW]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.WWW]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.WWW]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.WWW]
//   RESPONSE DELETE api/keepsakes   [Service.Auth]
//   RESPONSE DELETE api/keepsakes/{hHNICFJCOKP}   [Service.Auth]
//   RESPONSE POST   api/playerwarnings   [Service.Auth]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.Auth]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.WWW]
public class FOJABMDADAG
{
    public bool <GMNFINFGEOO>k__BackingField;    // 0x0x10
    public string <PIIMDLNPDAG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FPCIDJAMELI
//   REQUEST  POST   api/roomkeys/v1/owns/bulk   [Service.WWW]
public class FPCIDJAMELI
{
    public int OBPKAOKBBNJ;    // 0x0x10
    public long JPADMOJJPCK;    // 0x0x18
}

// --------------------------------------------------------------------------
// GBOGPNNAIMA
// base   : NHFEFLJCGCO
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class GBOGPNNAIMA : NHFEFLJCGCO
{
    public List<GGKCDBJFNED> <PHHIFPMFHNN>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// GCBLFBMGMBJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GCBLFBMGMBJ
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
// GCFMLGGGPKK
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems/v2   [Service.Notifications]
public class GCFMLGGGPKK
{
    public byte <OKJHCKCNOAF>k__BackingField;    // 0x0x10
    public int <CNJHAOPOKNC>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// GCOAPFHADMC
//   (not directly referenced by a detected call)
public class GCOAPFHADMC
{
    public bool <DONPFGHDNLJ>k__BackingField;    // 0x0x10
    public EMONNAFLJIC <AEEGCEEAGHJ>k__BackingField;    // 0x0x14
    public int <LIFPPBAPFFM>k__BackingField;    // 0x0x18
    public DateTime <BOBAHMHDNCM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GDHBOJEBONL
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.Auth]
public class GDHBOJEBONL
{
    public List<NHFEFLJCGCO> <OBJJNIKJNLN>k__BackingField;    // 0x0x10
    public string <NJIIAADFOKK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GEIBHGEDNGE
// base   : EEBMILNLPPE
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/season/{eILFODPHONG}   [Service.WWW]
public class GEIBHGEDNGE : EEBMILNLPPE
{
    public int <IMKHFMODFKC>k__BackingField;    // 0x0x30
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x38
    public DateTime <CEKCJDCDDHD>k__BackingField;    // 0x0x40
    public DateTime <JDGKBHPKAOM>k__BackingField;    // 0x0x48
    public DCBGCNMMENB <AFPGLELIILA>k__BackingField;    // 0x0x50
    public OPAFMLEELGF <GBHMLLJCJFC>k__BackingField;    // 0x0x58
    public List<DJEBPAONCEC> <GLPMADHGDAA>k__BackingField;    // 0x0x60
    public GCOAPFHADMC <ENKDGPPJEIG>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// GGKCDBJFNED
//   (not directly referenced by a detected call)
public class GGKCDBJFNED
{
    public string <KLJHLCCMEDN>k__BackingField;    // 0x0x10
    public FJCGJAEGDJP <IKNNHNHDFJP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GGNEIIPMAHH
// base   : AGIBHFBABDL`1<FLOGLGKMBGA>
//   RESPONSE GET    api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{pKMLPNIFKKA}   [Service.Auth]
public class GGNEIIPMAHH
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// GJGJDLNGAGB
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.Auth]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.Auth]
public class GJGJDLNGAGB
{
    public AEGKAFBKAIF <PLHFKIEOJJK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// GPJOKCEFAAA
// base   : FFCANEGKDLK
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class GPJOKCEFAAA : FFCANEGKDLK
{
    public JNLFIINNMAP? <OEDABMAGKHB>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <LKFJOGBCJJP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HHFHLKPMDBG
//   (not directly referenced by a detected call)
public class HHFHLKPMDBG
{
    public DCBGCNMMENB <AFPGLELIILA>k__BackingField;    // 0x0x10
    public int <OBDKKCPBKDG>k__BackingField;    // 0x0x14
    public APIDBEMOOIH <EBNGONMKNDA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HIDODGADNEB
//   (not directly referenced by a detected call)
public class HIDODGADNEB
{
    public int <CGDPHAOOGHI>k__BackingField;    // 0x0x10
    public KNOAAFBCKLF <BBLFKLGNAAN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HIHLFEEKHFB
//   REQUEST  POST   api/playerevents/v2   [Service.Auth]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.Auth]
public class HIHLFEEKHFB
{
    public long <DJFEMIFLDFL>k__BackingField;    // 0x0x10
    public long? <EKOBEEOEBFN>k__BackingField;    // 0x0x18
    public long? <BIEPFNEABBE>k__BackingField;    // 0x0x28
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x38
    public string <OKIOLHMEOJN>k__BackingField;    // 0x0x40
    public List<string> <PHHIFPMFHNN>k__BackingField;    // 0x0x48
    public string <MGBMIOJNCBD>k__BackingField;    // 0x0x50
    public DateTime <IKDBDDMMHPN>k__BackingField;    // 0x0x58
    public DateTime <LMCCJDPKKNP>k__BackingField;    // 0x0x60
    public LMPKFHOFHGP <MMNMJGJAOPM>k__BackingField;    // 0x0x68
    public bool <NKHMJBFGJEJ>k__BackingField;    // 0x0x6C
    public bool <GJHJAMHELJF>k__BackingField;    // 0x0x6D
    public DHGLHKCLGNE <NOMHDFNLINM>k__BackingField;    // 0x0x70
    public DHGLHKCLGNE <FHLAJBFMJIB>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// IALLJFAEKPI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IALLJFAEKPI
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// IBGGLCMILFI
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.WWW]
public class IBGGLCMILFI
{
    public List<NLHMHMGLFMP> <DIALAEOLPIG>k__BackingField;    // 0x0x10
    public string <NJIIAADFOKK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IKCGIBHHFEE
//   RESPONSE POST   api/PlayerCheer/v1/create   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v1/instantKick   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v3/create   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v3/voteToKick   [Service.Auth]
//   RESPONSE POST   api/clubreporting/v1/report   [Service.?]
//   RESPONSE POST   api/inventions/v1/report   [Service.Auth]
//   RESPONSE POST   api/playerevents/v1/report   [Service.Auth]
//   RESPONSE POST   api/relationships/sendfriendintroductions   [Service.Auth]
//   RESPONSE POST   api/rooms/v2/report   [Service.Auth]
//   RESPONSE POST   api/screensharereports/v1/report   [Service.Auth]
public class IKCGIBHHFEE
{
    public bool <GMNFINFGEOO>k__BackingField;    // 0x0x10
    public string <IHALGGJDELE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IOLNGKOPIOE
//   REQUEST  POST   api/roomcurrencies/v1/awardCurrency/bulk   [Service.WWW]
public class IOLNGKOPIOE
{
    public Guid <JNMJEGPIGNH>k__BackingField;    // 0x0x10
    public int <LCFCIANDONO>k__BackingField;    // 0x0x20
    public long <LMBCBOANKDD>k__BackingField;    // 0x0x28
    public Guid <MAOHBCDAGML>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// IONLJMILGCO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IONLJMILGCO
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
// JADKDANHAOK
//   (not directly referenced by a detected call)
public class JADKDANHAOK
{
    public Guid <INGAKGCBLIL>k__BackingField;    // 0x0x10
    public int <KCCKCPBCCPI>k__BackingField;    // 0x0x20
    public int <MAHJBMGFMDI>k__BackingField;    // 0x0x24
    public Guid <IDPMINCJNND>k__BackingField;    // 0x0x28
    public DateTime <BOBAHMHDNCM>k__BackingField;    // 0x0x38
    public OCNGALDAOFL <EEMIAIEDDCF>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// JBOOCIEJCHK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JBOOCIEJCHK
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// JCOIINCDBOA
//   REQUEST  POST   api/messages/v1/sendMultiple   [Service.Auth]
public class JCOIINCDBOA
{
    public List<long> <EFKIAKIIEID>k__BackingField;    // 0x0x10
    public NDBOMMDDMFO <IKNNHNHDFJP>k__BackingField;    // 0x0x18
    public string <HADODLJMELP>k__BackingField;    // 0x0x20
    public long? <DJFEMIFLDFL>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// JDCJMNELLGD
//   (not directly referenced by a detected call)
public class JDCJMNELLGD
{
    public long <GEGADDPFHCK>k__BackingField;    // 0x0x10
    public long <JFFBELDPLEG>k__BackingField;    // 0x0x18
    public int <JDIECCFDFNK>k__BackingField;    // 0x0x20
    public DateTime <IPCOOLBFFJF>k__BackingField;    // 0x0x28
    public BFAEMDLKFJD <IKNNHNHDFJP>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// JIHJBONLJKB
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class JIHJBONLJKB
{
    public Dictionary<Guid, HIDODGADNEB> <BHFPNEJMDPH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JKAAEGLGMAA
//   (not directly referenced by a detected call)
public class JKAAEGLGMAA
{
    public float <DJDLEFFMLCC>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JMCAAGICKCC
//   RESPONSE ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForCustomAvatarItemIds/v2   [Service.Auth]
public class JMCAAGICKCC
{
    public Dictionary<Guid, List<NEBPKMCEHCK>> <NGMKKGJJPBO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JNLFIINNMAP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JNLFIINNMAP
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
// KBKNIOMJPOE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KBKNIOMJPOE
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// KEMGAGEIMCL
//   (not directly referenced by a detected call)
public class KEMGAGEIMCL
{
    public int <MDPLHLIEOCD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KGJKOBOCMOC
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class KGJKOBOCMOC
{
    public Dictionary<Guid, FCAIGOOAAJA> <CLIMKPKBEAH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KHOHBPFOLDH
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.Auth]
public class KHOHBPFOLDH
{
    public string <GNGDNEMAKMA>k__BackingField;    // 0x0x10
    public string <LKMECEJHDFC>k__BackingField;    // 0x0x18
    public string <GJFFNBFFCIH>k__BackingField;    // 0x0x20
    public string <OKIOLHMEOJN>k__BackingField;    // 0x0x28
    public string <JMFAGPBPBCD>k__BackingField;    // 0x0x30
    public PLCGNIELAKI <JFDMDBMIOAH>k__BackingField;    // 0x0x38
    public List<string> <AAJPNHHJHPE>k__BackingField;    // 0x0x40
    public List<string> <PHHIFPMFHNN>k__BackingField;    // 0x0x48
    public string <NOIHHNJPIPD>k__BackingField;    // 0x0x50
    public List<MPAJLOMCHJJ> <CEIMOHLFKKJ>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// KKKAJFNJDJH
//   RESPONSE GET    api/config/v2   [Service.Auth]
public class KKKAJFNJDJH
{
    public Dictionary<int, int> <DMAPDDKLIEH>k__BackingField;    // 0x0x10
    public List<LJFNKCNAIDM> <FOFIMGNKOGN>k__BackingField;    // 0x0x18
    public OJJOFFHCMEA[][] <CNMLHPINMMP>k__BackingField;    // 0x0x20
    public MLODMLEADKG <AMLOPAKKNGI>k__BackingField;    // 0x0x28
    public NLNJCCKNJEO <IMAIMEHCOFM>k__BackingField;    // 0x0x30
    public LLGNDCAELGF <MCGGIKJPFAH>k__BackingField;    // 0x0x38
    public KEMGAGEIMCL <ACBBOGHJONO>k__BackingField;    // 0x0x40
    public JKAAEGLGMAA <FCICKLGAGOF>k__BackingField;    // 0x0x48
    public string <NKHAOHJOBHF>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// KMODHJLAICE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KMODHJLAICE
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
// KNLBHCCBAHG
//   RESPONSE DELETE api/roomconsumables   [Service.WWW]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{aCOAAGPDIBI}   [Service.WWW]
public class KNLBHCCBAHG
{
    public CKOBDLDILON <JFDMDBMIOAH>k__BackingField;    // 0x0x10
    public OCNGALDAOFL <EEMIAIEDDCF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KNOAAFBCKLF
//   REQUEST  PUT    api/roomconsumables   [Service.WWW]
public class KNOAAFBCKLF
{
    public Guid? <PKNHFAHMOGN>k__BackingField;    // 0x0x10
    public Guid <JOMPDDLBBLH>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// LFFCHJMEJBO
//   REQUEST  POST   api/roomkeys/v1/awardbulk   [Service.WWW]
public class LFFCHJMEJBO
{
    public long <IKDNAJGNLDH>k__BackingField;    // 0x0x10
    public int <KCCKCPBCCPI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LGEEOCCKELE
//   REQUEST  POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
public class LGEEOCCKELE
{
    public List<string> <BENJGMFHPPF>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LLGNDCAELGF
//   (not directly referenced by a detected call)
public class LLGNDCAELGF
{
    public int <NHNAIEMPMPN>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LMPKFHOFHGP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LMPKFHOFHGP
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// MCDIFLDCOND
//   REQUEST  POST   api/customAvatarItems   [Service.Auth]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
public class MCDIFLDCOND
{
    public LCNFGGHLNHL <BGOPIANNJAJ>k__BackingField;    // 0x0x10
    public string <BFDEAIHJAAL>k__BackingField;    // 0x0x18
    public int? <MIJEFOENGON>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MFECJANMCNP
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.WWW]
public class MFECJANMCNP
{
    public List<int> <KIFHOLKEGNC>k__BackingField;    // 0x0x10
    public string <NJIIAADFOKK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MGJGKOIGOBD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MGJGKOIGOBD
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
    InappropriateDescription = 12,
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
    InventionContainsBetaContent = 48,
    PlatformDoesntSupportPublishing = 49,
    MismatchedUgcVersions = 50,
    ConvertedFromSameUgcVersion = 51,
    ConvertedFromInventionDoesNotExist = 52,
    ConvertedFromInventionHigherVersion = 53,
    PlatformDoesntSupportInvention = 54,
}

// --------------------------------------------------------------------------
// MJPLEAIBKPG
//   (not directly referenced by a detected call)
public class MJPLEAIBKPG
{
    public long <IKDNAJGNLDH>k__BackingField;    // 0x0x10
    public Guid <DFENAGNBKEB>k__BackingField;    // 0x0x18
    public long <DJFEMIFLDFL>k__BackingField;    // 0x0x28
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x30
    public string <OKIOLHMEOJN>k__BackingField;    // 0x0x38
    public int <OBDKKCPBKDG>k__BackingField;    // 0x0x40
    public Guid? <NNKDKODLIKM>k__BackingField;    // 0x0x44
    public DateTime <IPCOOLBFFJF>k__BackingField;    // 0x0x58
    public string <MGBMIOJNCBD>k__BackingField;    // 0x0x60
    public AOMAGIFLPKI <IKNNHNHDFJP>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// MLBJEKANJPF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MLBJEKANJPF
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// MLODMLEADKG
//   (not directly referenced by a detected call)
public class MLODMLEADKG
{
    public int <LCALBDNMGGP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MPAJLOMCHJJ
//   (not directly referenced by a detected call)
public class MPAJLOMCHJJ
{
    public DateTime <IPCOOLBFFJF>k__BackingField;    // 0x0x10
    public string <ALABJCIAJLA>k__BackingField;    // 0x0x18
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
// NEBPKMCEHCK
//   (not directly referenced by a detected call)
public class NEBPKMCEHCK
{
    public long <ELLKIKLBKHA>k__BackingField;    // 0x0x10
    public Guid <LMPGCPMJNCM>k__BackingField;    // 0x0x18
    public Guid <ODEPMDIFEEI>k__BackingField;    // 0x0x28
    public DateTime <IPCOOLBFFJF>k__BackingField;    // 0x0x38
    public string <GLPNKKMHFEP>k__BackingField;    // 0x0x40
    public string <MCOBBALMKBE>k__BackingField;    // 0x0x48
    public int <GBOAEBMKHHD>k__BackingField;    // 0x0x50
    public string <GABJMDNNNDH>k__BackingField;    // 0x0x58
    public string <APBAJNOKDPN>k__BackingField;    // 0x0x60
    public string <NAKBPBPIIHB>k__BackingField;    // 0x0x68
    public string <IPLFDBJFOCD>k__BackingField;    // 0x0x70
    public int <NEAJCFJONAC>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// NFIFBBBONPI
//   RESPONSE POST   api/inventions/v1/cheer   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/delete   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/update   [Service.Auth]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.Auth]
//   RESPONSE GET    api/inventions/v3/publish   [Service.Matchmaking]
//   RESPONSE POST   api/inventions/v7/addversion   [Service.Notifications]
//   RESPONSE POST   api/inventions/v8/save   [Service.Matchmaking]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.WWW]
public class NFIFBBBONPI
{
    public MGJGKOIGOBD <JFDMDBMIOAH>k__BackingField;    // 0x0x10
    public FGJAIMIMBOK <IODFIDDOBIF>k__BackingField;    // 0x0x18
    public NPNHFKPNFBO <GFILCKJDELH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// NGCCGOABFEM
//   (not directly referenced by a detected call)
public class NGCCGOABFEM
{
    public int <GFHOPNAPDED>k__BackingField;    // 0x0x10
    public AEGKAFBKAIF <PLHFKIEOJJK>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// NHFEFLJCGCO
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class NHFEFLJCGCO
{
    public long <JFFBELDPLEG>k__BackingField;    // 0x0x10
    public int <MNKKILDNIIO>k__BackingField;    // 0x0x18
    public long <DJFEMIFLDFL>k__BackingField;    // 0x0x20
    public long? <EKOBEEOEBFN>k__BackingField;    // 0x0x28
    public long? <BIEPFNEABBE>k__BackingField;    // 0x0x38
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x48
    public string <OKIOLHMEOJN>k__BackingField;    // 0x0x50
    public string <MGBMIOJNCBD>k__BackingField;    // 0x0x58
    public DateTime <IKDBDDMMHPN>k__BackingField;    // 0x0x60
    public DateTime <LMCCJDPKKNP>k__BackingField;    // 0x0x68
    public int <BNEJGHJDAOK>k__BackingField;    // 0x0x70
    public LMPKFHOFHGP <MMNMJGJAOPM>k__BackingField;    // 0x0x74
    public bool <NKHMJBFGJEJ>k__BackingField;    // 0x0x78
    public bool <GJHJAMHELJF>k__BackingField;    // 0x0x79
    public DHGLHKCLGNE <NOMHDFNLINM>k__BackingField;    // 0x0x7C
    public DHGLHKCLGNE <FHLAJBFMJIB>k__BackingField;    // 0x0x80
    public long? <EMOHLBFKABH>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// NLHMHMGLFMP
//   (not directly referenced by a detected call)
public class NLHMHMGLFMP
{
    public int <CCOFKLIJHOD>k__BackingField;    // 0x0x10
    public DateTime <IPCOOLBFFJF>k__BackingField;    // 0x0x18
    public DateTime? <LOFLIDPIJJM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// NLNJCCKNJEO
//   (not directly referenced by a detected call)
public class NLNJCCKNJEO
{
    public float <POIJNBGCNOJ>k__BackingField;    // 0x0x10
    public float <FFKOBGNGLDB>k__BackingField;    // 0x0x14
    public float <GOJPIABEKOM>k__BackingField;    // 0x0x18
    public float <ANMEOJLGFKE>k__BackingField;    // 0x0x1C
    public float <KAICOHFMGNM>k__BackingField;    // 0x0x20
    public float <CCIOLAACKHN>k__BackingField;    // 0x0x24
    public float <ONENAAGFIEE>k__BackingField;    // 0x0x28
    public float <EGGDBCDELEM>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// NMAFDFFPFOK
// base   : AGIBHFBABDL`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.Auth]
public class NMAFDFFPFOK
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// NNFKHOFIEEE
//   RESPONSE GET    api/testcasemanagement/   [Service.Auth]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{cABAGOHBNFK}   [Service.Auth]
public class NNFKHOFIEEE
{
    public uint <GNGDNEMAKMA>k__BackingField;    // 0x0x10
    public uint? <JLEECNJEHBP>k__BackingField;    // 0x0x14
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x20
    public string <OKIOLHMEOJN>k__BackingField;    // 0x0x28
    public DateTime <HEODBHOIHLJ>k__BackingField;    // 0x0x30
    public DateTime? <GIBLACABNMN>k__BackingField;    // 0x0x38
    public bool <JICCKKNDLNM>k__BackingField;    // 0x0x48
    public List<KHOHBPFOLDH> <DGOADLNMGNK>k__BackingField;    // 0x0x50
    public List<string> <PHHIFPMFHNN>k__BackingField;    // 0x0x58
    public int <KBCEPFDGNCH>k__BackingField;    // 0x0x60
    public int <PGHKBGIFHBD>k__BackingField;    // 0x0x64
    public int <CIIDCKMBCPM>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// NPNHFKPNFBO
//   (not directly referenced by a detected call)
public class NPNHFKPNFBO
{
    public long <MOPFPHMCOAM>k__BackingField;    // 0x0x10
    public string <DFENAGNBKEB>k__BackingField;    // 0x0x18
    public int <IDGLBMIGDBO>k__BackingField;    // 0x0x20
    public bool <GFJOIBDBLEL>k__BackingField;    // 0x0x24
    public int <CCJAKFGKHAH>k__BackingField;    // 0x0x28
    public int <BHKNJPALBGB>k__BackingField;    // 0x0x2C
    public int <IIFKHOKFONN>k__BackingField;    // 0x0x30
    public int <OGDNODCIEPH>k__BackingField;    // 0x0x34
    public string <KNHFNKEGOBG>k__BackingField;    // 0x0x38
    public string <INHGGOJOBME>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// OCNGALDAOFL
//   (not directly referenced by a detected call)
public class OCNGALDAOFL
{
    public Guid <INGAKGCBLIL>k__BackingField;    // 0x0x10
    public long <DJFEMIFLDFL>k__BackingField;    // 0x0x20
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x28
    public string <OKIOLHMEOJN>k__BackingField;    // 0x0x30
    public string <MGBMIOJNCBD>k__BackingField;    // 0x0x38
    public long <OBDKKCPBKDG>k__BackingField;    // 0x0x40
    public Guid? <NNKDKODLIKM>k__BackingField;    // 0x0x48
    public DateTime <BOBAHMHDNCM>k__BackingField;    // 0x0x60
    public int <PPMIIEICCKA>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// OCPGIHIMBHH
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/checklist/v1/complete   [Service.WWW]
//   RESPONSE POST   api/progressionEvents   [Service.Auth]
//   RESPONSE POST   api/progressionEvents/collect/{mELONOGBNCF}/{pDBGOAPFIPN}   [Service.Auth]
public class OCPGIHIMBHH
{
    public long? <GNGDNEMAKMA>k__BackingField;    // 0x0x10
    public int <JDIECCFDFNK>k__BackingField;    // 0x0x20
    public int? <PODGMMFLDFH>k__BackingField;    // 0x0x24
    public string <IFGLNJFGOPH>k__BackingField;    // 0x0x30
    public JBOOCIEJCHK? <BFGLLLPMAKL>k__BackingField;    // 0x0x38
    public string <APJBOIEBNNO>k__BackingField;    // 0x0x40
    public Guid? <LMPGCPMJNCM>k__BackingField;    // 0x0x48
    public string <BKJEHCCJDKM>k__BackingField;    // 0x0x60
    public string <CJJMACJPNEI>k__BackingField;    // 0x0x68
    public DCBGCNMMENB <AFPGLELIILA>k__BackingField;    // 0x0x70
    public int <PKJMNNOJBAJ>k__BackingField;    // 0x0x74
    public int <MLLIKINJBEK>k__BackingField;    // 0x0x78
    public PFOAPKFADOF <PPDPCNJBMJC>k__BackingField;    // 0x0x7C
    public KBKNIOMJPOE <EIHGFPGHONL>k__BackingField;    // 0x0x80
    public string <ONFOLKNBKAH>k__BackingField;    // 0x0x88
    public FEPOFBMICJP <IEJFKBGAFEI>k__BackingField;    // 0x0x90
    public EMONNAFLJIC <GIAPGCBGILA>k__BackingField;    // 0x0x94
    public PNJDNIJNAKM? <AJCGMPJBIBH>k__BackingField;    // 0x0x98
    public bool <FADOOMEODEE>k__BackingField;    // 0x0xA0
    public bool <DHIBFMCLPDM>k__BackingField;    // 0x0xA1
    public string <ICLFJJGBHFF>k__BackingField;    // 0x0xA8
    public bool <JFAMHFGKCKF>k__BackingField;    // 0x0xB0
    public bool CFMPBIEPCHN;    // 0x0xB1
}

// --------------------------------------------------------------------------
// OGNFDICGIMO
//   RESPONSE GET    api/config/v1/azurespeech   [Service.Auth]
public class OGNFDICGIMO
{
    public bool <DHFACEEOKNF>k__BackingField;    // 0x0x10
    public string <LKMECEJHDFC>k__BackingField;    // 0x0x18
    public string <PCJMMLFAJIH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OJJOFFHCMEA
//   (not directly referenced by a detected call)
public class OJJOFFHCMEA
{
    public OLFJDAGMJGO HIAKJGJHFAN;    // 0x0x10
    public int GCOIHAAEEHL;    // 0x0x14
}

// --------------------------------------------------------------------------
// OLFJDAGMJGO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OLFJDAGMJGO
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
// ONHJMEMEPCF
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.Auth]
public class ONHJMEMEPCF
{
    public List<NGCCGOABFEM> <LHMHONKFJDC>k__BackingField;    // 0x0x10
    public AEGKAFBKAIF <PLHFKIEOJJK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ONPNCNEAIBD
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.WWW]
//   RESPONSE POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
//   RESPONSE GET    api/avatar/v4/items   [Service.WWW]
public class ONPNCNEAIBD
{
    public JBOOCIEJCHK <BFGLLLPMAKL>k__BackingField;    // 0x0x10
    public string <ODAIPFEBIHK>k__BackingField;    // 0x0x18
    public string <LNKAHMCBCHB>k__BackingField;    // 0x0x20
    public string <GMKFOMDDMPM>k__BackingField;    // 0x0x28
    public KBKNIOMJPOE <GFOOEIHMDJF>k__BackingField;    // 0x0x30
    public string <ANANBMAFOFB>k__BackingField;    // 0x0x38
    public int <OLHLCCFIDDM>k__BackingField;    // 0x0x40
    public bool <GJAGDMEJFIA>k__BackingField;    // 0x0x44
}

// --------------------------------------------------------------------------
// ONPPBAKMNMN
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.WWW]
public class ONPPBAKMNMN
{
    public int <DJHCEGONBOD>k__BackingField;    // 0x0x10
    public bool <JBDGOPOEJPA>k__BackingField;    // 0x0x14
    public DateTime <NJMANBHLBOA>k__BackingField;    // 0x0x18
    public bool <GEBENNEGDEI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OPAFMLEELGF
//   (not directly referenced by a detected call)
public class OPAFMLEELGF
{
    public int <MBOCKAPPLPB>k__BackingField;    // 0x0x10
    public MLBJEKANJPF <IKNNHNHDFJP>k__BackingField;    // 0x0x14
    public List<HHFHLKPMDBG> <ANLGODENEPD>k__BackingField;    // 0x0x18
    public List<HHFHLKPMDBG> <GGFGFABPAJN>k__BackingField;    // 0x0x20
    public bool <LAGIFBOKMID>k__BackingField;    // 0x0x28
    public DateTime? <EDBMFCLFJGG>k__BackingField;    // 0x0x30
    public DateTime? <PGFFDLFHPAN>k__BackingField;    // 0x0x40
    public DateTime? <HNCOOFFOFEE>k__BackingField;    // 0x0x50
    public bool <IKBFFNLLGKB>k__BackingField;    // 0x0x60
    public bool <EAMLJLJCOKP>k__BackingField;    // 0x0x61
}

// --------------------------------------------------------------------------
// OPPOJNEGCOK
//   REQUEST  ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForCustomAvatarItemIds/v2   [Service.Auth]
public class OPPOJNEGCOK
{
    public List<Guid> <MBHDMNNLABO>k__BackingField;    // 0x0x10
    public byte <OKJHCKCNOAF>k__BackingField;    // 0x0x18
    public int <CNJHAOPOKNC>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// PBMPPGFJGDB
//   REQUEST  PUT    api/customAvatarItems   [Service.Auth]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
public class PBMPPGFJGDB
{
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x10
    public string <OKIOLHMEOJN>k__BackingField;    // 0x0x18
    public int? <OBDKKCPBKDG>k__BackingField;    // 0x0x20
    public EMCFGHOJEPP? <MMNMJGJAOPM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// PFOAPKFADOF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PFOAPKFADOF
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
// PIDGONDLECD
// base   : System.Enum
//   RESPONSE ?      api/roomkeys/   [Service.Data]
//   RESPONSE DELETE api/roomkeys/v1/delete/{cJINBGABBIG}   [Service.WWW]
public enum PIDGONDLECD
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
// PLCGNIELAKI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PLCGNIELAKI
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// PMFOFJJLJNE
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs/v2   [Service.Auth]
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems/v2   [Service.Notifications]
public class PMFOFJJLJNE
{
    public Dictionary<string, List<NEBPKMCEHCK>> <MNIDAFKPHLE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// PNJDNIJNAKM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PNJDNIJNAKM
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
    SwitchPurchased = 9,
    PlayStationNonPurchasedP2P = 100,
    NonPlayStationNonPurchasedP2P = 101,
    NonPurchasedEarnedByP2P = 1000,
    NonPurchasedEarnedByP2Pv2 = 1001,
}

// --------------------------------------------------------------------------
// POJNKFKPMKM
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.WWW]
public class POJNKFKPMKM
{
    public long <IKDNAJGNLDH>k__BackingField;    // 0x0x10
    public int <KCCKCPBCCPI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.Clubs]
public class AddKeepsakeInstanceRequest
{
    public long <DJFEMIFLDFL>k__BackingField;    // 0x0x10
    public long? <EKOBEEOEBFN>k__BackingField;    // 0x0x18
    public EMCICLIIJNH <JENNOCBGGBN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddVersionInventionRequestDTO
//   REQUEST  POST   api/inventions/v7/addversion   [Service.Notifications]
public class AddVersionInventionRequestDTO
{
    public long inventionId;    // 0x0x10
    public bool hasBetaContent;    // 0x0x18
    public int instantiationCost;    // 0x0x1C
    public int lightsCost;    // 0x0x20
    public int chipsCost;    // 0x0x24
    public int cloudVariablesCost;    // 0x0x28
    public int aiCost;    // 0x0x2C
    public byte ugcVersion;    // 0x0x30
    public long creationRoomId;    // 0x0x38
    public string inventionDataFilename;    // 0x0x40
    public List<long> referencedInventions;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecNet.AppleMusicPromotionResponseDTO
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.Auth]
public class AppleMusicPromotionResponseDTO
{
    public BFGHOCBIIFB <PLHFKIEOJJK>k__BackingField;    // 0x0x10
    public string <NMKCFKJJAFF>k__BackingField;    // 0x0x18
    public string <ECIFBPCLDOO>k__BackingField;    // 0x0x20
    public string <DCMGJFMHKBN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public DCBGCNMMENB <CurrencyType>k__BackingField;    // 0x0x18
    public PNJDNIJNAKM <BalanceType>k__BackingField;    // 0x0x1C
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
    public long <JFFBELDPLEG>k__BackingField;    // 0x0x10
    public long? <HCCIAHFFPFM>k__BackingField;    // 0x0x18
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
    public OCJFDCCNDBH FilterType;    // 0x0x20
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
    public EMCICLIIJNH <LGDCJJPBKCH>k__BackingField;    // 0x0x10
    public string <POFFMDHHFCB>k__BackingField;    // 0x0x18
    public int <EJHIPDHLKPG>k__BackingField;    // 0x0x20
    public int <OBFONNJDEBB>k__BackingField;    // 0x0x24
    public string <CMJEMBNMAPN>k__BackingField;    // 0x0x28
    public string <LBPGEACJIIF>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <KCCKCPBCCPI>k__BackingField;    // 0x0x10
    public Guid <CPPDHIOMICD>k__BackingField;    // 0x0x14
    public DateTime <LNGMDPEGLPN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.Auth]
public class KeepsakeGlobalConfigDTO
{
    public bool <APFECBFHEBP>k__BackingField;    // 0x0x10
    public int <CPFELFMGNLF>k__BackingField;    // 0x0x14
    public bool <JOIBMIHAHDK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <CPPDHIOMICD>k__BackingField;    // 0x0x10
    public EMCICLIIJNH <JLOLPIBLFKN>k__BackingField;    // 0x0x20
    public int <BMEDODAGBEP>k__BackingField;    // 0x0x24
    public long <DJFEMIFLDFL>k__BackingField;    // 0x0x28
    public long? <EKOBEEOEBFN>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.Auth]
//   RESPONSE GET    api/keepsakes/events/{cPMPBPKKOGH}   [Service.Auth]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <CEFMDLFAPCO>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <HCEPACHPLBM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <LCOCNKANAEA>k__BackingField;    // 0x0x10
    public long <DJFEMIFLDFL>k__BackingField;    // 0x0x18
    public long <MACMAOPFDPI>k__BackingField;    // 0x0x20
    public OAHHFBIBDGG <IKNNHNHDFJP>k__BackingField;    // 0x0x28
    public int <BMFHCNPNFAF>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <DJFEMIFLDFL>k__BackingField;    // 0x0x10
    public List<Guid> <DOAKNOCHFCI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <CEFMDLFAPCO>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <HCEPACHPLBM>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <EDFCILPEAKH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <MACMAOPFDPI>k__BackingField;    // 0x0x10
    public long <OPADCOBJBJP>k__BackingField;    // 0x0x18
    public int? <CIMHLDBEJLF>k__BackingField;    // 0x0x20
    public int? <FPGCOBFMCPC>k__BackingField;    // 0x0x28
    public long? <NLICKMCILMI>k__BackingField;    // 0x0x30
    public long <LACGMJOAFFI>k__BackingField;    // 0x0x40
    public long <OOPJOKEFKAM>k__BackingField;    // 0x0x48
    public int <KEPBDPMBOFF>k__BackingField;    // 0x0x50
    public OAHHFBIBDGG <OJDKGBDKABC>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <DBNGDDHBNBA>k__BackingField;    // 0x0x58
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
//   REQUEST  POST   api/freegifts/v1/sendmultiple   [Service.WWW]
public class MultiRecipientFreeGiftRequestDTO
{
    public List<int> <ToPlayerIds>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public PFOAPKFADOF <GiftContext>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.NewInventionRequestDTO
//   REQUEST  POST   api/inventions/v8/save   [Service.Matchmaking]
public class NewInventionRequestDTO
{
    public string name;    // 0x0x10
    public string description;    // 0x0x18
    public string imageName;    // 0x0x20
    public bool hasBetaContent;    // 0x0x28
    public int instantiationCost;    // 0x0x2C
    public int lightsCost;    // 0x0x30
    public int chipsCost;    // 0x0x34
    public int cloudVariablesCost;    // 0x0x38
    public int aiCost;    // 0x0x3C
    public byte ugcVersion;    // 0x0x40
    public long creationRoomId;    // 0x0x48
    public string inventionDataFilename;    // 0x0x50
    public List<long> referencedInventions;    // 0x0x58
    public CDDOIGKGONH creatorAccountRole;    // 0x0x60
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public KJIMEGGEEJP <KKDEIAHEHNM>k__BackingField;    // 0x0x10
    public JDHHMIAPOEF <MLMCKKAOBEH>k__BackingField;    // 0x0x14
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x18
    public string <OKIOLHMEOJN>k__BackingField;    // 0x0x20
    public bool <GGPBIKLKPFN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<KJIMEGGEEJP> <BFHKGJNACED>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/event/{mELONOGBNCF}   [Service.Auth]
public class ProgressionEventDTO
{
    public long <OPADCOBJBJP>k__BackingField;    // 0x0x10
    public string <OODBCAGOKLD>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <JBJPMNGABEC>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <KFPBABHMGME>k__BackingField;    // 0x0x28
    public DateTime <IKDBDDMMHPN>k__BackingField;    // 0x0x30
    public DateTime <LMCCJDPKKNP>k__BackingField;    // 0x0x38
    public DateTime <DFJPMDMPLMM>k__BackingField;    // 0x0x40
    public bool <MDPEJCDIOJE>k__BackingField;    // 0x0x48
    public int <DFFGPJPDAAH>k__BackingField;    // 0x0x4C
    public float <HDMMCAKOCGO>k__BackingField;    // 0x0x50
    public Guid? <PCKBJAGBCAC>k__BackingField;    // 0x0x54
    public string <JJLNAIKJNAL>k__BackingField;    // 0x0x68
    public string <BMDLGGICMMK>k__BackingField;    // 0x0x70
    public string <GDJLOMGCJDP>k__BackingField;    // 0x0x78
    public string <NIAJCBLDNBN>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <FFIPNKHKHOG>k__BackingField;    // 0x0x10
    public int <KLEJAFGNFJM>k__BackingField;    // 0x0x20
    public int <BBHIBHBBNIG>k__BackingField;    // 0x0x24
    public int <AEEOANDBHMM>k__BackingField;    // 0x0x28
    public long <LPNABOGOPLJ>k__BackingField;    // 0x0x30
    public long <JDFIOJBNICO>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.Auth]
public class ProgressionEventRecordDTO
{
    public int <KCCKCPBCCPI>k__BackingField;    // 0x0x10
    public int <MLLIKINJBEK>k__BackingField;    // 0x0x14
    public int <OABHALHMFPN>k__BackingField;    // 0x0x18
    public int <CIILKIPOJDF>k__BackingField;    // 0x0x1C
    public int <OAJAGPJICJD>k__BackingField;    // 0x0x20
    public DateTime? <KLNDIHBCOBD>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <DKIPPAHNHOL>k__BackingField;    // 0x0x10
    public int <KKGGLFKABGF>k__BackingField;    // 0x0x18
    public string <MGBMIOJNCBD>k__BackingField;    // 0x0x20
    public int <MLLIKINJBEK>k__BackingField;    // 0x0x28
    public int <IBCHMFIEPLM>k__BackingField;    // 0x0x2C
    public bool <HCBGCEBDNHD>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.Auth]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public ILCNJEHPFGA ReportCategory;    // 0x0x20
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
    public bool CGHPPGMNBOO;    // 0x0x28
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
    public PFPLFJKKBIF? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [Auth POST]
public class PlayerCheerV1CreateRequest
{
    public PFPLFJKKBIF PHBIJGLMJGI;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [Auth POST]
public class PlayerReportingV1DeviceIdRequest
{
    public FEPOFBMICJP CBIBABLHIDF;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [Auth POST]
public class PlayerReportingV1HileRequest
{
    public BLOABCAOCEK HGPIKDLKBHO;  // wrapper
    public int? HCNGPPCOOGK;  // wrapper
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
    public GAJLOINGNBJ AMKKFHAFHFM;  // wrapper
    public float? EPBPBAPPKKO;  // wrapper
    public bool? OHCJOFFEPKK;  // wrapper
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
    public List<CMEPKGFHLPL> desc;  // wrapper
}

// api/avatar/v2/gifts/generate  [WWW POST]
public class AvatarV2GiftsGenerateRequest
{
    public PFOAPKFADOF NGDLPEOFMHL;  // wrapper
    public PFOAPKFADOF? JBAELBJMEGM;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [WWW POST]
public class AvatarV3GiftsGenerateRequest
{
    public PFOAPKFADOF NGDLPEOFMHL;  // wrapper
    public PFOAPKFADOF? JBAELBJMEGM;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/chatreport/createChatReport  [? POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage NKAJDDICLFH;  // wrapper
    public PBPGOJGKOBJ AMKKFHAFHFM;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [Notifications POST]
public class ClubreportingV1ReportRequest
{
    public GAJLOINGNBJ AMKKFHAFHFM;  // wrapper
    public object details;  // candidate
    public object clubId;  // candidate
    public object reportCategory;  // candidate
}

// api/config/v1/backtrace  [API GET]
public class ConfigV1BacktraceRequest
{
    public object allocate;  // candidate
    public object platformType;  // candidate
}

// api/customAvatarItems/v1  [Auth POST]
public class CustomAvatarItemsV1Request
{
    public EMCFGHOJEPP NKOJACBBKBN;  // wrapper
    public LOBGGBGPOJE PLMNKBKHDJD;  // wrapper
    public IEHBAPAGMED ENAKNFEBAHM;  // wrapper
    public IEHBAPAGMED ENCACFJEMIP;  // wrapper
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
    public KEAKMPONMHH ADMGCKMOGPI;  // wrapper
    public PFOAPKFADOF? DNOICCJFPHF;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [WWW POST]
public class GamerewardsV1SelectRequest
{
    public KGJBMHJHJDG BCLOICMCBEL;  // wrapper
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
    public FGJAIMIMBOK inventionId;  // wrapper
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

// api/keepsakes/{hHNICFJCOKP}/collect  [Auth POST]
public class KeepsakesHHNICFJCOKPCollectRequest
{
    public Guid HHNICFJCOKP;  // wrapper
}

// api/messages/v2/send  [Auth POST]
public class MessagesV2SendRequest
{
    public NDBOMMDDMFO PONNJPECLLD;  // wrapper
    public long? ACIHEOIHPAO;  // wrapper
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
    public IReadOnlyCollection<long> CNEKHJPFCBE;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [Auth PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public LMPKFHOFHGP NKOJACBBKBN;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [Auth PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? JGJLEBNHOEB;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [Auth PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public DHGLHKCLGNE JNAALDOKOHO;  // wrapper
    public DHGLHKCLGNE LOAPHHACBMI;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [Auth PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? GPDLAAEANOD;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [Auth PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime CMLKPGPBFBC;  // wrapper
    public DateTime NLHHOLAAEOF;  // wrapper
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
    public GAJLOINGNBJ AMKKFHAFHFM;  // wrapper
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
    public Guid PPJCOMLPBAC;  // wrapper
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
    public Guid MPCBGGEEPGP;  // wrapper
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
    public Guid MPCBGGEEPGP;  // wrapper
    public long? AFGPNEOJHBJ;  // wrapper
    public byte? LHMLGAAONPF;  // wrapper
    public int? NMMFNOOBBFO;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [WWW POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid PPJCOMLPBAC;  // wrapper
    public long? OKHGBBBDKLP;  // wrapper
    public long? AAIDNOFBEPI;  // wrapper
    public int? AFLEEIGIAGF;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [WWW PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> AINJPEDDNEM;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [WWW POST]
public class RoomkeysV1CreateRequest
{
    public AOMAGIFLPKI HGPIKDLKBHO;  // wrapper
    public Guid? HIEAAPEIPKB;  // wrapper
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
    public GAJLOINGNBJ AMKKFHAFHFM;  // wrapper
    public long? DLLBKOJKMJC;  // wrapper
    public Guid? GLFHEBIIEJI;  // wrapper
    public int? PICDPGELPGN;  // wrapper
    public object RoomOfferVersion;  // candidate
    public object ReportCategory;  // candidate
    public object RoomOfferId;  // candidate
    public object RoomId;  // candidate
    public object RoomKeyId;  // candidate
}

// api/screensharereports/v1/report  [Auth POST]
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
    public Guid GCEBMDJJEAB;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [WWW POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid FDGFKBLGGCL;  // wrapper
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
    public PLCGNIELAKI GDMLJGODBFP;  // wrapper
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public int? pid;  // wrapper
}

