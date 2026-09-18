// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 251 (plus referenced enums)

// --------------------------------------------------------------------------
// AAPINKCPOMG
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.API]
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{bINPFEABBIL}   [Service.API]
//   RESPONSE POST   api/playerevents/v2/{eventId}   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/accessibility   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/club   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/description   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/image   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/multiinstance   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/name   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/room   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/tags   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/time   [Service.API]
public class AAPINKCPOMG
{
    public FHGPDJGNCMI <FLHCBDNGCKO>k__BackingField;    // 0x0x10
    public DNPDKMHJGAO <ENKPHDJDBGN>k__BackingField;    // 0x0x18
    public BIGHKDENGLL <JBHEPEFEKMC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AFEBJAFEJJJ
//   (not directly referenced by a detected call)
public class AFEBJAFEJJJ
{
    public int <LLIHGLPELHN>k__BackingField;    // 0x0x10
    public string <CAJMINEBBAB>k__BackingField;    // 0x0x18
    public string <GLMDENKGNDM>k__BackingField;    // 0x0x20
    public string <FLMMAMOJLCC>k__BackingField;    // 0x0x28
    public string <NMFINGKDNJN>k__BackingField;    // 0x0x30
    public string <PKKPIANDBHG>k__BackingField;    // 0x0x38
    public BKPGDDFBLKB? <OOCKLCKICFJ>k__BackingField;    // 0x0x40
    public string <OJECIIHOAIF>k__BackingField;    // 0x0x48
    public string <EKDPOGHOKOI>k__BackingField;    // 0x0x50
    public bool <IJBPMLGKPPB>k__BackingField;    // 0x0x58
    public bool <NKKBGJFNEFC>k__BackingField;    // 0x0x59
    public bool <NHLIJGJJAOH>k__BackingField;    // 0x0x5A
    public PDGHMLLBBCB <KIOFNKILIDF>k__BackingField;    // 0x0x5C
    public int <LOCHDBMDLGI>k__BackingField;    // 0x0x60
    public PMKKDOJNMGM <GKNFMPIAINO>k__BackingField;    // 0x0x64
    public int <NDGNOMDLIEI>k__BackingField;    // 0x0x68
    public GOLIMFBGJFG <MCHFBIBKDLA>k__BackingField;    // 0x0x6C
    public MKMPCEKEFLK <FJKHAALIMNO>k__BackingField;    // 0x0x70
    public int? <NGCPNBPILFP>k__BackingField;    // 0x0x74
    public string <LPEJFBAIKEN>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// AHFIKOPAODB
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.API]
public class AHFIKOPAODB
{
    public string <HMPFECFPHGH>k__BackingField;    // 0x0x10
    public string <EOFPGCLJIHJ>k__BackingField;    // 0x0x18
    public string <FCGFCNGIGBG>k__BackingField;    // 0x0x20
    public string <PONPFJBCEGB>k__BackingField;    // 0x0x28
    public string <BKKHHPBDDIB>k__BackingField;    // 0x0x30
    public LNBDBABNIDC <DCFGIAEHNMK>k__BackingField;    // 0x0x38
    public List<string> <MGGBCLPMCCI>k__BackingField;    // 0x0x40
    public List<string> <DHJEEKBMONM>k__BackingField;    // 0x0x48
    public string <MLPMBBGIJOG>k__BackingField;    // 0x0x50
    public List<GNHBAKCANKD> <IDDHJCHBGKP>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// AMGONMFHPFL
// base   : System.Enum
//   RESPONSE ?      api/roomkeys/   [Service.Econ]
//   RESPONSE DELETE api/roomkeys/v1/delete/{roomKeyId}   [Service.Econ]
public enum AMGONMFHPFL
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
// AODANCADFOC
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.API]
public class AODANCADFOC
{
    public int <JJMFBKFEMAA>k__BackingField;    // 0x0x10
    public int? <FKIEGEINEGB>k__BackingField;    // 0x0x14
    public string <NKMJEDMELNO>k__BackingField;    // 0x0x20
    public string <KFKNCBNCJNA>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// BAJEPNEDFEF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BAJEPNEDFEF
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// BEEFOFGBPAI
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
public class BEEFOFGBPAI
{
    public string <CONKJABBPPD>k__BackingField;    // 0x0x10
    public string <PONPFJBCEGB>k__BackingField;    // 0x0x18
    public int? <JJDHHAAMFII>k__BackingField;    // 0x0x20
    public FOLDEHLIODE? <AOEOIGAAPGD>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// BEGNIGJOLFA
//   RESPONSE GET    api/config/v1/backtrace   [Service.API]
public class BEGNIGJOLFA
{
    public int <DCOKDGHFDJI>k__BackingField;    // 0x0x10
    public int <CIDFOGOFLIA>k__BackingField;    // 0x0x14
    public float <BHCDDFGDLJD>k__BackingField;    // 0x0x18
    public int <IPAPIAJDDJN>k__BackingField;    // 0x0x1C
    public int <BGPPKOCFKMD>k__BackingField;    // 0x0x20
    public int <HFDGBMIPFIL>k__BackingField;    // 0x0x24
    public int <AEAFCBMOAGH>k__BackingField;    // 0x0x28
    public string <EBOGMBMNECE>k__BackingField;    // 0x0x30
    public string <BBLIBKJEDED>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// BIGHKDENGLL
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class BIGHKDENGLL
{
    public DMKNHONHPDD <ENKPHDJDBGN>k__BackingField;    // 0x0x10
    public List<string> <DHJEEKBMONM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BPNKKAEMMBF
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class BPNKKAEMMBF
{
    public List<NDKMAFMEHJO> <DHJEEKBMONM>k__BackingField;    // 0x0x10
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
    public bool <IsUpgraded>k__BackingField;    // 0x0x50
    public List<Cookie> <Cookies>k__BackingField;    // 0x0x58
    public string dataAsText;    // 0x0x60
    public Texture2D texture;    // 0x0x68
    public bool <IsClosedManually>k__BackingField;    // 0x0x70
    public HTTPRequest baseRequest;    // 0x0x78
    public Stream Stream;    // 0x0x80
    public List<byte[]> streamedFragments;    // 0x0x88
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
// CGKFKKKMLKF
//   RESPONSE GET    api/testcasemanagement/   [Service.API]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{lNJCEIMJDGG}   [Service.API]
public class CGKFKKKMLKF
{
    public uint <HMPFECFPHGH>k__BackingField;    // 0x0x10
    public uint? <NPFOEFDFCEE>k__BackingField;    // 0x0x14
    public string <CONKJABBPPD>k__BackingField;    // 0x0x20
    public string <PONPFJBCEGB>k__BackingField;    // 0x0x28
    public DateTime <DLCEKGIEFDF>k__BackingField;    // 0x0x30
    public DateTime? <KIJLBONIFLJ>k__BackingField;    // 0x0x38
    public bool <BGBAOMKPBMH>k__BackingField;    // 0x0x48
    public List<AHFIKOPAODB> <PKMNNKMPGEG>k__BackingField;    // 0x0x50
    public List<string> <DHJEEKBMONM>k__BackingField;    // 0x0x58
    public int <OKGMEELPLOK>k__BackingField;    // 0x0x60
    public int <HEBCJMAMFMD>k__BackingField;    // 0x0x64
    public int <ICPDBKBFOKA>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// CHJIOCMNPPD
// base   : KLHBADGALDA
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class CHJIOCMNPPD : KLHBADGALDA
{
    public NGOJJMEHJKB? <DENBEFHMKEO>k__BackingField;    // 0x0x18
    public ILCEEEKIPCJ <KMODMNFLGIJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CKNCEGHKNJP
//   (not directly referenced by a detected call)
public class CKNCEGHKNJP
{
    public Guid <NMPPBPECFBD>k__BackingField;    // 0x0x10
    public int <GKDMFACMLNL>k__BackingField;    // 0x0x20
    public int <IOJKDBICBBI>k__BackingField;    // 0x0x24
    public Guid <ADKDFIJLLBH>k__BackingField;    // 0x0x28
    public DateTime <BDOFEFFKICI>k__BackingField;    // 0x0x38
    public LHNIJKHMPEI <PPDPIJIACLP>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// CKNKIIPJIOJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CKNKIIPJIOJ
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// CLODGKHBHBG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CLODGKHBHBG
{
    Equal = 0,
    Custom = 1,
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
// DAFGJKPDONJ
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
public class DAFGJKPDONJ
{
    public CMGODLPMJCH <NOODDOOMOMG>k__BackingField;    // 0x0x10
    public string <CEGMFFMBKCE>k__BackingField;    // 0x0x18
    public int? <OKDFNKLOJFP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DEBHIDKOJNC
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class DEBHIDKOJNC
{
    public JICPIAKDECF <MEENOBBMCHA>k__BackingField;    // 0x0x10
    public GNHFBLBKOND <KAPKAIHNHAG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DEMBBLFNGMB
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.API]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
public class DEMBBLFNGMB
{
    public int <FBAICHGCAHA>k__BackingField;    // 0x0x10
    public JLCGILABNNM <EBELECOJBBC>k__BackingField;    // 0x0x14
    public IBLCILGGBFG <LOJFNEFCAOE>k__BackingField;    // 0x0x18
    public IBLCILGGBFG <CDCLPFFHNCI>k__BackingField;    // 0x0x1C
    public IBLCILGGBFG <OBMNMGNIAOI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DHCANHMAICB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DHCANHMAICB
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
// DIAJFHFHOOM
//   (not directly referenced by a detected call)
public class DIAJFHFHOOM
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// DMKNHONHPDD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DMKNHONHPDD
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
    RoomPlaylistDoesNotExist = 13,
}

// --------------------------------------------------------------------------
// DNPDKMHJGAO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DNPDKMHJGAO
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
}

// --------------------------------------------------------------------------
// DPBCLLLPNML
//   (not directly referenced by a detected call)
public class DPBCLLLPNML
{
    public PMKKDOJNMGM <GKNFMPIAINO>k__BackingField;    // 0x0x10
    public int <JJDHHAAMFII>k__BackingField;    // 0x0x14
    public GPICIHPKPMO <NAOABPLLNCB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EECIICOCBLI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EECIICOCBLI
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// EHOGAOAGNBA
//   RESPONSE ?      api/inventions/   [Service.API]
//   RESPONSE GET    api/inventions/v1/personaldetails/{dPEBIILOGIL}   [Service.API]
public class EHOGAOAGNBA
{
    public bool <EPEADEEDJOA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// EJFHGMANLGK
// base   : KINPNKBMCGE
//   (not directly referenced by a detected call)
public class EJFHGMANLGK : KINPNKBMCGE
{
    public int <NBOPBPHJOCF>k__BackingField;    // 0x0x60
    public List<FONIPGHPEMC> <NHGNOJODFBC>k__BackingField;    // 0x0x68
    public List<FONIPGHPEMC> <OBDDHHBCHEH>k__BackingField;    // 0x0x70
    public List<FONIPGHPEMC> <CBOEPFNCNJD>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// EMMDILNBKNB
//   (not directly referenced by a detected call)
public class EMMDILNBKNB
{
    public long <FGFEKHBFAGE>k__BackingField;    // 0x0x10
    public Guid <PNCLEBFHIBA>k__BackingField;    // 0x0x18
    public long <LKCBLBEFIAI>k__BackingField;    // 0x0x28
    public string <CONKJABBPPD>k__BackingField;    // 0x0x30
    public string <PONPFJBCEGB>k__BackingField;    // 0x0x38
    public int <JJDHHAAMFII>k__BackingField;    // 0x0x40
    public Guid? <LOEGMJMOPCC>k__BackingField;    // 0x0x44
    public DateTime <FLFCMCEGMFE>k__BackingField;    // 0x0x58
    public string <EDBOLNBDLOA>k__BackingField;    // 0x0x60
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
// FBFONFFOBMB
// base   : KJLFFBOMIHP<DOOLBGICOEM>
//   RESPONSE ?      api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{dCDCIBFBKNH}   [Service.API]
public class FBFONFFOBMB
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// FDMOJCHMPMK
//   (not directly referenced by a detected call)
public class FDMOJCHMPMK
{
    public int <LKNELIFIAPJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// FHGPDJGNCMI
// base   : KHDKOOBDMFC
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class FHGPDJGNCMI : KHDKOOBDMFC
{
    public List<NDKMAFMEHJO> <DHJEEKBMONM>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// FICDOCKPJKK
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.Econ]
public class FICDOCKPJKK
{
    public List<int> <AFEDIKJJMMC>k__BackingField;    // 0x0x10
    public string <JHFEFBBAOFB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FONIPGHPEMC
//   (not directly referenced by a detected call)
public class FONIPGHPEMC
{
    public bool <KABJBFKIADC>k__BackingField;    // 0x0x10
    public AFEBJAFEJJJ <JFIPHAOAOAE>k__BackingField;    // 0x0x18
    public float <GPGEBLENAGK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// FPNCCKPPBBN
//   RESPONSE ?      api/roomkeys/v1/   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Econ]
public class FPNCCKPPBBN
{
    public AMGONMFHPFL <DCFGIAEHNMK>k__BackingField;    // 0x0x10
    public EMMDILNBKNB <IIFBOPFBOAF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GCDPHPOEDHG
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class GCDPHPOEDHG
{
    public Dictionary<Guid, GJHJDNOFKIG> <NKMBJKJEHKE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// GDAGKKNOMHD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GDAGKKNOMHD
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
    RoomCurrency = 1200,
    Wishlist = 1300,
    RoomConsumable = 1400,
    RecRally = 1600,
    PopUpShop_1 = 1700,
    PopUpShop_2 = 1701,
    PopUpShop_3 = 1702,
    PopUpShop_4 = 1703,
    PopUpShop_5 = 1704,
    CustomAvatarItems = 1800,
    ProgressionEventPurchasableXpBoosts = 1900,
    PopUpShop_ProgressionEvent_1 = 2000,
    PopUpShop_ProgressionEvent_2 = 2001,
    PopUpShop_ProgressionEvent_3 = 2002,
    PopUpShop_ProgressionEvent_4 = 2003,
    PopUpShop_ProgressionEvent_5 = 2004,
}

// --------------------------------------------------------------------------
// GFNEGBJLFIN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GFNEGBJLFIN
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
// GJHJDNOFKIG
//   (not directly referenced by a detected call)
public class GJHJDNOFKIG
{
    public int <LDFBNHHMFJM>k__BackingField;    // 0x0x10
    public JICPIAKDECF <MEENOBBMCHA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GNACGKPAIHF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GNACGKPAIHF
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// GNHBAKCANKD
//   (not directly referenced by a detected call)
public class GNHBAKCANKD
{
    public DateTime <FLFCMCEGMFE>k__BackingField;    // 0x0x10
    public string <DEHIJNCFHAK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GNHFBLBKOND
//   (not directly referenced by a detected call)
public class GNHFBLBKOND
{
    public long <JJDHHAAMFII>k__BackingField;    // 0x0x10
    public Guid? <KJDMHCEJIOO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GOLIMFBGJFG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GOLIMFBGJFG
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
// GPICIHPKPMO
//   (not directly referenced by a detected call)
public class GPICIHPKPMO
{
    public int <BDDCHDGFFLA>k__BackingField;    // 0x0x10
    public DateTime? <MDBFPEOPFKA>k__BackingField;    // 0x0x18
    public DateTime? <DAELOBMCKBF>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// HBPBGPPGDGF
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{bKNOAMJJOPO}   [Service.API]
public class HBPBGPPGDGF
{
    public List<KHDKOOBDMFC> <BANJODEJPPG>k__BackingField;    // 0x0x10
    public List<NODPGFMBLJE> <KLMJFNCABGM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HNLGDPBMPIB
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class HNLGDPBMPIB
{
    public int? <JOKIDAPOOAK>k__BackingField;    // 0x0x10
    public string <BKKHHPBDDIB>k__BackingField;    // 0x0x18
    public string <HCCGCMCHAIH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HOJHCFKHFAH
//   (not directly referenced by a detected call)
public class HOJHCFKHFAH
{
    public int <CPLAHHINHIJ>k__BackingField;    // 0x0x10
    public string <CONKJABBPPD>k__BackingField;    // 0x0x18
    public string <HOEAEBCKOCP>k__BackingField;    // 0x0x20
    public string <PONPFJBCEGB>k__BackingField;    // 0x0x28
    public string <GLMDENKGNDM>k__BackingField;    // 0x0x30
    public bool <FFDHJHLBMOO>k__BackingField;    // 0x0x38
    public int <DCGIFDGNGNI>k__BackingField;    // 0x0x3C
    public DIAJFHFHOOM <BIAEIGDGMAC>k__BackingField;    // 0x0x40
    public CBFJGFBIMKA GJLGNMGNFIK;    // 0x0x48
    public CBFJGFBIMKA PABNLPCKHLE;    // 0x0x50
    public CBFJGFBIMKA JGGALAMKKAJ;    // 0x0x58
    public COKEPMDHEEP CPAEGHMPBJH;    // 0x0x60
}

// --------------------------------------------------------------------------
// IAOKJFLEKOA
//   REQUEST  ?      api/roomcurrencies   [Service.Econ]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.Econ]
public class IAOKJFLEKOA
{
    public Guid <AILKOHMDPII>k__BackingField;    // 0x0x10
    public long <HCFLOJJJEFG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// IBKOKIEFLPP
//   RESPONSE GET    api/config/v2   [Service.API]
public class IBKOKIEFLPP
{
    public Dictionary<int, int> <PGMBACBGBEI>k__BackingField;    // 0x0x10
    public List<DKLEHADPNBF> <MGBLPMAGNBJ>k__BackingField;    // 0x0x18
    public JEAJHAEPDFN[][] <PCPDIBFICKN>k__BackingField;    // 0x0x20
    public ODNMNFHBDGA <NHMNBOJGIOA>k__BackingField;    // 0x0x28
    public MNGBOMOAHOP <FLIKHPAAOLI>k__BackingField;    // 0x0x30
    public PFLCHIGAFFI <EDJPABFKJJF>k__BackingField;    // 0x0x38
    public FDMOJCHMPMK <IIPFCNJODKJ>k__BackingField;    // 0x0x40
    public NDGANLIFNFH <JLPPCIDHOFC>k__BackingField;    // 0x0x48
    public string <IAFPDPNNDJL>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// ICAKCCAIMME
//   RESPONSE POST   api/avatar/v4/saved/set   [Service.Econ]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.Econ]
//   RESPONSE ?      api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.API]
//   RESPONSE PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.API]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.Econ]
//   RESPONSE POST   api/gamesight/event   [Service.API]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.Econ]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.Econ]
//   RESPONSE POST   api/keepsakes   [Service.API]
//   RESPONSE DELETE api/keepsakes/{pGDCMKGLNJL}   [Service.API]
//   RESPONSE POST   api/playerwarnings   [Service.API]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.Econ]
public class ICAKCCAIMME
{
    public bool <KAMPMBDHPAI>k__BackingField;    // 0x0x10
    public string <GKNGGMNBOCF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IDEKANNEPNB
//   (not directly referenced by a detected call)
public class IDEKANNEPNB
{
    public bool <CNIEKHDGJOE>k__BackingField;    // 0x0x10
    public KAKABOEOPLG <PBABAIDGDGC>k__BackingField;    // 0x0x14
    public int <IBEOMBMHLNJ>k__BackingField;    // 0x0x18
    public DateTime <BDOFEFFKICI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// IFCODFCFDML
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/consume   [Service.Econ]
public class IFCODFCFDML
{
    public GFNEGBJLFIN <DCFGIAEHNMK>k__BackingField;    // 0x0x10
    public CKNCEGHKNJP <NDPECAOEFLE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IIJCODDNLFD
// base   : KJLFFBOMIHP<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.API]
public class IIJCODDNLFD
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// IILDBEFDFIF
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class IILDBEFDFIF
{
    public DNPDKMHJGAO <ENKPHDJDBGN>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// IIMLKDENFLL
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.Econ]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.Econ]
public class IIMLKDENFLL
{
    public int <BJPPOGIGMLN>k__BackingField;    // 0x0x10
    public int <MJHLDGJLANK>k__BackingField;    // 0x0x14
    public float <ABGPGHEPEIB>k__BackingField;    // 0x0x18
    public float <BDBCENPLABC>k__BackingField;    // 0x0x1C
    public bool <IECIHFEAODI>k__BackingField;    // 0x0x20
    public bool <OEINJPAAJAC>k__BackingField;    // 0x0x21
    public bool <JOINDPPEBDH>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// IKBKNCMFOPE
//   (not directly referenced by a detected call)
public class IKBKNCMFOPE
{
    public long <CIBPOHJEPPL>k__BackingField;    // 0x0x10
    public long <AFEHBIGNHFN>k__BackingField;    // 0x0x18
    public int <EDAMPPHJMNL>k__BackingField;    // 0x0x20
    public DateTime <FLFCMCEGMFE>k__BackingField;    // 0x0x28
    public LAHPKFOHLHP <EBELECOJBBC>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// ILCEEEKIPCJ
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.Econ]
public class ILCEEEKIPCJ
{
    public int <GKDMFACMLNL>k__BackingField;    // 0x0x10
    public Guid <KJDMHCEJIOO>k__BackingField;    // 0x0x14
    public long <FCHEHLDPOPN>k__BackingField;    // 0x0x28
    public DateTime <BDOFEFFKICI>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// JALOIAEBIKM
//   (not directly referenced by a detected call)
public class JALOIAEBIKM
{
    public int <GFBINKMOOAF>k__BackingField;    // 0x0x10
    public DateTime <FLFCMCEGMFE>k__BackingField;    // 0x0x18
    public DateTime? <MMEJHDNHPHI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JEAJHAEPDFN
//   (not directly referenced by a detected call)
public class JEAJHAEPDFN
{
    public DHCANHMAICB EIGPECJOEPF;    // 0x0x10
    public int NCNPONNCNOB;    // 0x0x14
}

// --------------------------------------------------------------------------
// JFKJPKOFAOL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JFKJPKOFAOL
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
}

// --------------------------------------------------------------------------
// JICPIAKDECF
//   REQUEST  ?      api/roomconsumables   [Service.Econ]
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/consume   [Service.Econ]
public class JICPIAKDECF
{
    public Guid? <ELMIOJLDEOI>k__BackingField;    // 0x0x10
    public Guid <NLCFEIFHPKD>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// JJLLHMDFHDM
//   (not directly referenced by a detected call)
public class JJLLHMDFHDM
{
    public Guid <CGEGHPDJCIB>k__BackingField;    // 0x0x10
    public Guid <MLBJECAEACE>k__BackingField;    // 0x0x20
    public DateTime <BJDJFFGDKNE>k__BackingField;    // 0x0x30
    public List<AFEBJAFEJJJ> <MOECDGONAHH>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// JKFCDCDNGPC
//   (not directly referenced by a detected call)
public class JKFCDCDNGPC
{
    public long <MMBDDFKGPIJ>k__BackingField;    // 0x0x10
    public string <PNCLEBFHIBA>k__BackingField;    // 0x0x18
    public int <HEGHBMIGNNN>k__BackingField;    // 0x0x20
    public int <NOFEHACKDLJ>k__BackingField;    // 0x0x24
    public int <DKKCEFCCNDJ>k__BackingField;    // 0x0x28
    public int <DFIHDEDGFDP>k__BackingField;    // 0x0x2C
    public int <JBJBCFCDCLD>k__BackingField;    // 0x0x30
    public string <MDMOKGAHPDF>k__BackingField;    // 0x0x38
    public string <EBINGMHAKOJ>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// KAAILAODPNI
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{balanceaddtypeId}/False   [Service.Econ]
public class KAAILAODPNI
{
    public PMKKDOJNMGM <GKNFMPIAINO>k__BackingField;    // 0x0x10
    public KMPKMOMHMJA <GCMGACBKNHE>k__BackingField;    // 0x0x14
    public int <JOLDMHKPOOA>k__BackingField;    // 0x0x18
    public int <NCGBLHBOLLC>k__BackingField;    // 0x0x1C
    public int <PMIHJBEPBOF>k__BackingField;    // 0x0x20
    public GNACGKPAIHF <LNFDDKPLMKJ>k__BackingField;    // 0x0x24
    public bool <GGHLBMELOCD>k__BackingField;    // 0x0x28
    public float <OHGCCDNIIED>k__BackingField;    // 0x0x2C
    public int <PODBPJOPELH>k__BackingField;    // 0x0x30
    public bool <OEEHPEOJIKB>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// KAKABOEOPLG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KAKABOEOPLG
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
}

// --------------------------------------------------------------------------
// KFBOGJIOPDH
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class KFBOGJIOPDH
{
    public List<NAAHOOFGPNC> <AHBGCOGDHJI>k__BackingField;    // 0x0x10
    public DNPDKMHJGAO <ENKPHDJDBGN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KFEALJOOMPN
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.Econ]
public class KFEALJOOMPN
{
    public int <DADCKAKNBFB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KGDMDEHIMAO
//   RESPONSE GET    api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class KGDMDEHIMAO
{
    public FOCLJOBLLOL <NOODDOOMOMG>k__BackingField;    // 0x0x10
    public int <DADCKAKNBFB>k__BackingField;    // 0x0x14
    public long <HEBHMFJFENB>k__BackingField;    // 0x0x18
    public bool <INKFOOHCLFA>k__BackingField;    // 0x0x20
    public string <MPOCNIGFNIJ>k__BackingField;    // 0x0x28
    public int? <PHOEBLMJBLF>k__BackingField;    // 0x0x30
    public bool <MKNAHKEBIAP>k__BackingField;    // 0x0x38
    public bool <KBBFOPKPLDI>k__BackingField;    // 0x0x39
    public bool <BPNABOFACAA>k__BackingField;    // 0x0x3A
    public string <PODMEAJKAJA>k__BackingField;    // 0x0x40
    public DateTime? <EBOMHCCHCLN>k__BackingField;    // 0x0x48
    public float <CJOHIOOKMJD>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// KHDKOOBDMFC
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class KHDKOOBDMFC
{
    public long <AFEHBIGNHFN>k__BackingField;    // 0x0x10
    public int <EAICMEIHOLF>k__BackingField;    // 0x0x18
    public long <LKCBLBEFIAI>k__BackingField;    // 0x0x20
    public long? <HAPEELJOPBD>k__BackingField;    // 0x0x28
    public long? <OHCFEDMJDIC>k__BackingField;    // 0x0x38
    public string <CONKJABBPPD>k__BackingField;    // 0x0x48
    public string <PONPFJBCEGB>k__BackingField;    // 0x0x50
    public string <EDBOLNBDLOA>k__BackingField;    // 0x0x58
    public DateTime <CNDGIOIFBAI>k__BackingField;    // 0x0x60
    public DateTime <EIHLDODAILL>k__BackingField;    // 0x0x68
    public int <KMEKIGMGPII>k__BackingField;    // 0x0x70
    public OBMDKFJPBCD <AOEOIGAAPGD>k__BackingField;    // 0x0x74
    public bool <ILECPBNEBFL>k__BackingField;    // 0x0x78
    public bool <KAILOJIHAJN>k__BackingField;    // 0x0x79
    public BAJEPNEDFEF <OHJKIGLJGCC>k__BackingField;    // 0x0x7C
    public BAJEPNEDFEF <FCINONNIBPA>k__BackingField;    // 0x0x80
    public long? <EONPONFJGDB>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// KINPNKBMCGE
//   (not directly referenced by a detected call)
public class KINPNKBMCGE
{
    public int <KAKBPDACILI>k__BackingField;    // 0x0x10
    public EECIICOCBLI <EBELECOJBBC>k__BackingField;    // 0x0x14
    public List<DPBCLLLPNML> <MDPHOJDHGND>k__BackingField;    // 0x0x18
    public List<DPBCLLLPNML> <BDENNAPOFEP>k__BackingField;    // 0x0x20
    public bool <LEJDEFKJLCD>k__BackingField;    // 0x0x28
    public DateTime? <CHILHGOKJKL>k__BackingField;    // 0x0x30
    public DateTime? <DOEPOEPJNEM>k__BackingField;    // 0x0x40
    public DateTime? <APELLGJCOBC>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// KKFALHDJOLB
//   RESPONSE POST   api/inventions/v1/cheer   [Service.API]
//   RESPONSE GET    api/inventions/v1/delete   [Service.API]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.API]
//   RESPONSE GET    api/inventions/v1/update   [Service.API]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.API]
//   RESPONSE GET    api/inventions/v3/publish   [Service.API]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.Econ]
public class KKFALHDJOLB
{
    public JFKJPKOFAOL <DCFGIAEHNMK>k__BackingField;    // 0x0x10
    public LEBCJODDAKI <JCLDFNELHHO>k__BackingField;    // 0x0x18
    public JKFCDCDNGPC <JKOKJIEKJCK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KMPKMOMHMJA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KMPKMOMHMJA
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
}

// --------------------------------------------------------------------------
// KNJKCEGCINA
//   RESPONSE GET    api/config/v1/amplitude   [Service.API]
public class KNJKCEGCINA
{
    public string <HFGPMPNGMHF>k__BackingField;    // 0x0x10
    public string <ADABNPHNDAA>k__BackingField;    // 0x0x18
    public bool <BILABAGNPAL>k__BackingField;    // 0x0x20
    public string <NAJJEHIIJCG>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// KOMPGAPDDBF
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.Econ]
public class KOMPGAPDDBF
{
    public long <FGFEKHBFAGE>k__BackingField;    // 0x0x10
    public int <GKDMFACMLNL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LAHPKFOHLHP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LAHPKFOHLHP
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// LEBCJODDAKI
//   (not directly referenced by a detected call)
public class LEBCJODDAKI
{
    public ObscuredLong <MMBDDFKGPIJ>k__BackingField;    // 0x0x10
    public string <PNCLEBFHIBA>k__BackingField;    // 0x0x38
    public ObscuredInt <EAICMEIHOLF>k__BackingField;    // 0x0x40
    public string <CONKJABBPPD>k__BackingField;    // 0x0x58
    public string <PONPFJBCEGB>k__BackingField;    // 0x0x60
    public string <EDBOLNBDLOA>k__BackingField;    // 0x0x68
    public int <IFEHKKPNGNO>k__BackingField;    // 0x0x70
    public FOLDEHLIODE <AOEOIGAAPGD>k__BackingField;    // 0x0x74
    public DateTime <BDOFEFFKICI>k__BackingField;    // 0x0x78
    public DateTime <FLFCMCEGMFE>k__BackingField;    // 0x0x80
    public DateTime? <FLNBENIMEIH>k__BackingField;    // 0x0x88
    public long? <MNFPADLOGDH>k__BackingField;    // 0x0x98
    public int <CDPEHDABCEC>k__BackingField;    // 0x0xA8
    public int <ODIFPBPACPE>k__BackingField;    // 0x0xAC
    public int <PNNMHFKALOI>k__BackingField;    // 0x0xB0
    public LEKJJCDIFMN <KFPMMEEJCGD>k__BackingField;    // 0x0xB4
    public LEKJJCDIFMN <OLNIDGJJJPM>k__BackingField;    // 0x0xB8
    public ObscuredBool <OPNEENBLIDG>k__BackingField;    // 0x0xBC
    public ObscuredBool <IDPOHDJEMFP>k__BackingField;    // 0x0xC8
    public ObscuredBool <AMDLAKIOHOD>k__BackingField;    // 0x0xD4
    public int? <JJDHHAAMFII>k__BackingField;    // 0x0xE0
    public bool <CAMPOFLDLEH>k__BackingField;    // 0x0xE8
}

// --------------------------------------------------------------------------
// LEKJJCDIFMN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LEKJJCDIFMN
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
// LENKFMNIGOC
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
public class LENKFMNIGOC
{
    public Guid? <NMPPBPECFBD>k__BackingField;    // 0x0x10
    public long? <LKCBLBEFIAI>k__BackingField;    // 0x0x28
    public string <CONKJABBPPD>k__BackingField;    // 0x0x38
    public string <PONPFJBCEGB>k__BackingField;    // 0x0x40
    public string <EDBOLNBDLOA>k__BackingField;    // 0x0x48
    public GNHFBLBKOND <HDENNILBAJO>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// LEONFLIKJHI
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.Econ]
public class LEONFLIKJHI
{
    public int <NIMKPHHFJHC>k__BackingField;    // 0x0x10
    public string <MAHEBMOEGJA>k__BackingField;    // 0x0x18
    public List<HOJHCFKHFAH> <IBPJHCDLBIE>k__BackingField;    // 0x0x20
    public MOLMCKCBDFG <JJAAKMLPDLK>k__BackingField;    // 0x0x28
    public string <JGEAPCCGFPO>k__BackingField;    // 0x0x30
    public DateTime <BJDJFFGDKNE>k__BackingField;    // 0x0x38
    public DateTime <PAJGLDMJAEA>k__BackingField;    // 0x0x40
    public DateTime <DFNINDCLFFA>k__BackingField;    // 0x0x48
    public bool? <MEHANIKHNPG>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// LHNIJKHMPEI
//   (not directly referenced by a detected call)
public class LHNIJKHMPEI
{
    public Guid <NMPPBPECFBD>k__BackingField;    // 0x0x10
    public long <LKCBLBEFIAI>k__BackingField;    // 0x0x20
    public string <CONKJABBPPD>k__BackingField;    // 0x0x28
    public string <PONPFJBCEGB>k__BackingField;    // 0x0x30
    public string <EDBOLNBDLOA>k__BackingField;    // 0x0x38
    public long <JJDHHAAMFII>k__BackingField;    // 0x0x40
    public Guid? <LOEGMJMOPCC>k__BackingField;    // 0x0x48
    public DateTime <BDOFEFFKICI>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// LIEJEJLAEGO
//   RESPONSE POST   api/AppIntegrity/v1/iospaymentqueuefailed   [Service.API]
//   RESPONSE POST   api/AppIntegrity/v1/iosproducts   [Service.API]
//   RESPONSE POST   api/PlayerCheer/v1/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v1/instantKick   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/voteToKick   [Service.API]
//   RESPONSE POST   api/clubreporting/v1/report   [Service.API]
//   RESPONSE POST   api/inventions/v1/report   [Service.API]
//   RESPONSE POST   api/playerevents/v1/report   [Service.API]
//   RESPONSE POST   api/relationships/sendfriendintroductions   [Service.API]
//   RESPONSE POST   api/rooms/v2/report   [Service.API]
//   RESPONSE POST   api/screensharereports/v1/report   [Service.API]
public class LIEJEJLAEGO
{
    public bool <KAMPMBDHPAI>k__BackingField;    // 0x0x10
    public string <MPOCNIGFNIJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LNBDBABNIDC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LNBDBABNIDC
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// MCIHICBDNJI
// base   : KLHBADGALDA
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class MCIHICBDNJI : KLHBADGALDA
{
    public FNOBEEGIBBE? <DENBEFHMKEO>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <NFIIIECAHLM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MFOJPNOLFHH
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class MFOJPNOLFHH
{
    public Dictionary<Guid, IFCODFCFDML> <CBCBCNEHIGB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MHJCLEPEBKI
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.Econ]
public class MHJCLEPEBKI
{
    public long <LKCBLBEFIAI>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <EKIJPPONICE>k__BackingField;    // 0x0x18
    public CLODGKHBHBG <DIGAOBHKOBO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MKMPCEKEFLK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MKMPCEKEFLK
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
// MLIMIINGCBE
//   RESPONSE ?      api/incentivizedreferrals/   [Service.Econ]
public class MLIMIINGCBE
{
    public List<JALOIAEBIKM> <OMDGAOIAHJF>k__BackingField;    // 0x0x10
    public string <JHFEFBBAOFB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MMOLOLCLAMF
//   (not directly referenced by a detected call)
public class MMOLOLCLAMF
{
    public Guid <FHGEJALDIOI>k__BackingField;    // 0x0x10
    public byte <EFOLLAADHFP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MNGBOMOAHOP
//   (not directly referenced by a detected call)
public class MNGBOMOAHOP
{
    public float <OEDDFIDOBEB>k__BackingField;    // 0x0x10
    public float <INOKOCNKEKP>k__BackingField;    // 0x0x14
    public float <EEDFABIGLEI>k__BackingField;    // 0x0x18
    public float <CDFEOBDKOGG>k__BackingField;    // 0x0x1C
    public float <JNDMOIAJLDL>k__BackingField;    // 0x0x20
    public float <IMDJCMHHEJN>k__BackingField;    // 0x0x24
    public float <PJAOCILICOP>k__BackingField;    // 0x0x28
    public float <NJGBDGOGGBK>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// MOLMCKCBDFG
//   (not directly referenced by a detected call)
public class MOLMCKCBDFG
{
    public long <LLIHGLPELHN>k__BackingField;    // 0x0x10
    public string <NMFINGKDNJN>k__BackingField;    // 0x0x18
    public string <BMIAHBLGHPJ>k__BackingField;    // 0x0x20
    public BKPGDDFBLKB? <OOCKLCKICFJ>k__BackingField;    // 0x0x28
    public string <OJECIIHOAIF>k__BackingField;    // 0x0x30
    public string <EKDPOGHOKOI>k__BackingField;    // 0x0x38
    public GDAGKKNOMHD <NGFEHLFECJG>k__BackingField;    // 0x0x40
    public int <DNMGADCAJHA>k__BackingField;    // 0x0x44
    public int <MLNLIBBOGHI>k__BackingField;    // 0x0x48
    public MKMPCEKEFLK? <MLBEPCLDMHM>k__BackingField;    // 0x0x4C
    public PDGHMLLBBCB? <KHJCOPFLOHN>k__BackingField;    // 0x0x54
}

// --------------------------------------------------------------------------
// MOMEPMMDFJP
//   RESPONSE ?      api/avatar/   [Service.Econ]
//   RESPONSE GET    api/avatar/v2   [Service.Econ]
//   REQUEST  POST   api/avatar/v2/set   [Service.Econ]
//   RESPONSE GET    api/avatar/v2/{bKNOAMJJOPO}   [Service.Econ]
public class MOMEPMMDFJP
{
    public string <CPAPAMCLOGK>k__BackingField;    // 0x0x10
    public string <EIOKEGLFLEH>k__BackingField;    // 0x0x18
    public string <MHAPAKHEGIL>k__BackingField;    // 0x0x20
    public string <ABEOKEKEMPK>k__BackingField;    // 0x0x28
    public string <JCJDDHGNOEJ>k__BackingField;    // 0x0x30
    public List<MMOLOLCLAMF> <BMNODMMEAOF>k__BackingField;    // 0x0x38
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
// NAAHOOFGPNC
//   (not directly referenced by a detected call)
public class NAAHOOFGPNC
{
    public int <ELBDGCAJILF>k__BackingField;    // 0x0x10
    public DNPDKMHJGAO <ENKPHDJDBGN>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// NDGANLIFNFH
//   (not directly referenced by a detected call)
public class NDGANLIFNFH
{
    public float <GICIJOCDJBI>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// NDKMAFMEHJO
//   (not directly referenced by a detected call)
public class NDKMAFMEHJO
{
    public string <AECOEOFHPMB>k__BackingField;    // 0x0x10
    public CKNKIIPJIOJ <EBELECOJBBC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NGOJJMEHJKB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NGOJJMEHJKB
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// NHCBPDHLANI
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{nGKAJNIACFJ}   [Service.Econ]
public class NHCBPDHLANI
{
    public GFNEGBJLFIN <DCFGIAEHNMK>k__BackingField;    // 0x0x10
    public LHNIJKHMPEI <PPDPIJIACLP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NIBLEAEGJKE
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.Auth]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.Econ]
public class NIBLEAEGJKE
{
    public int <MJHLDGJLANK>k__BackingField;    // 0x0x10
    public bool <IECIHFEAODI>k__BackingField;    // 0x0x14
    public DateTime <HLJCMGDOOMJ>k__BackingField;    // 0x0x18
    public bool <ANPOLDKIGLJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// NKJJLOACFPJ
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.API]
public class NKJJLOACFPJ
{
    public List<KHDKOOBDMFC> <ALLDAFIKDPK>k__BackingField;    // 0x0x10
    public string <JHFEFBBAOFB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NODPGFMBLJE
//   (not directly referenced by a detected call)
public class NODPGFMBLJE
{
    public KHDKOOBDMFC <FLHCBDNGCKO>k__BackingField;    // 0x0x10
    public IKBKNCMFOPE <NIIANBHOIHB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OBMDKFJPBCD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OBMDKFJPBCD
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// ODNMNFHBDGA
//   (not directly referenced by a detected call)
public class ODNMNFHBDGA
{
    public int <LMEMDAAAEPM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OKCPAINAKBA
//   REQUEST  POST   api/avatar/v4/saved/set   [Service.Econ]
public class OKCPAINAKBA
{
    public int <DCGIFDGNGNI>k__BackingField;    // 0x0x10
    public string <CONKJABBPPD>k__BackingField;    // 0x0x18
    public string <AHMMNPLLHKO>k__BackingField;    // 0x0x20
    public string <CPAPAMCLOGK>k__BackingField;    // 0x0x28
    public string <EIOKEGLFLEH>k__BackingField;    // 0x0x30
    public string <MHAPAKHEGIL>k__BackingField;    // 0x0x38
    public string <ABEOKEKEMPK>k__BackingField;    // 0x0x40
    public string <JCJDDHGNOEJ>k__BackingField;    // 0x0x48
    public List<MMOLOLCLAMF> <BMNODMMEAOF>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// ONIBFLLCBJK
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Econ]
public class ONIBFLLCBJK
{
    public Guid <DLFNGOJIAGP>k__BackingField;    // 0x0x10
    public string <CONKJABBPPD>k__BackingField;    // 0x0x20
    public string <EDBOLNBDLOA>k__BackingField;    // 0x0x28
    public DateTime <BJDJFFGDKNE>k__BackingField;    // 0x0x30
    public DateTime? <AGALKOBKBOA>k__BackingField;    // 0x0x38
    public List<JJLLHMDFHDM> <LCLFCCFHKBK>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// PCHPODDIDBG
//   RESPONSE GET    api/config/v1/azurespeech   [Service.API]
public class PCHPODDIDBG
{
    public bool <HELAIHJMBMC>k__BackingField;    // 0x0x10
    public string <EOFPGCLJIHJ>k__BackingField;    // 0x0x18
    public string <ALEJOAGLOJE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PCNJCNANMAE
// base   : AEABFFAACGD
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/season/{kLICGNKOCLG}   [Service.Econ]
public class PCNJCNANMAE : AEABFFAACGD
{
    public int <DDOGHJDELCB>k__BackingField;    // 0x0x30
    public string <CONKJABBPPD>k__BackingField;    // 0x0x38
    public DateTime <BJDJFFGDKNE>k__BackingField;    // 0x0x40
    public DateTime <PAJGLDMJAEA>k__BackingField;    // 0x0x48
    public PMKKDOJNMGM <GKNFMPIAINO>k__BackingField;    // 0x0x50
    public KINPNKBMCGE <CLLKFBHAANK>k__BackingField;    // 0x0x58
    public List<EJFHGMANLGK> <IHCDPMPODOH>k__BackingField;    // 0x0x60
    public IDEKANNEPNB <PLJMOPIHJAC>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// PDGHMLLBBCB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PDGHMLLBBCB
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// PFLCHIGAFFI
//   (not directly referenced by a detected call)
public class PFLCHIGAFFI
{
    public int <JKGJKDJCONO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// PLALLELGFGD
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
public class PLALLELGFGD
{
    public List<string> <ONELEKGKCBD>k__BackingField;    // 0x0x10
    public List<string> <EBABIINIEJO>k__BackingField;    // 0x0x18
    public List<string> <FCDLDGNGKOI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PMKKDOJNMGM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PMKKDOJNMGM
{
    Invalid = 0,
    LaserTagTickets = 1,
    RecCenterTokens = 2,
    LostSkullsGold = 100,
    DraculaSilver = 101,
    RecRoyale_Season1 = 200,
    RoomCurrency = 300,
    ProgressionEvent = 400,
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.API]
public class AddKeepsakeInstanceRequest
{
    public long <LKCBLBEFIAI>k__BackingField;    // 0x0x10
    public long? <HAPEELJOPBD>k__BackingField;    // 0x0x18
    public JHAAPFBDNOG <CJGKFKGMKBF>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddVersionInventionRequestDTO
//   (not directly referenced by a detected call)
public class AddVersionInventionRequestDTO
{
    public long inventionId;    // 0x0x10
    public int instantiationCost;    // 0x0x18
    public int lightsCost;    // 0x0x1C
    public int chipsCost;    // 0x0x20
    public int cloudVariablesCost;    // 0x0x24
    public int aiCost;    // 0x0x28
    public long creationRoomId;    // 0x0x30
    public string inventionDataFilename;    // 0x0x38
    public List<long> referencedInventions;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.AppleMusicPromotionResponseDTO
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.API]
public class AppleMusicPromotionResponseDTO
{
    public LHKHBGEMLMB <ENKPHDJDBGN>k__BackingField;    // 0x0x10
    public string <PPHIBNHBBKE>k__BackingField;    // 0x0x18
    public string <NFLPFGPFEIP>k__BackingField;    // 0x0x20
    public string <KPIFKLCLLJN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.CheerRequest
//   REQUEST  POST   api/inventions/v1/cheer   [Service.API]
public class CheerRequest
{
    public long InventionId;    // 0x0x10
    public bool Cheer;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.DeleteMessagesRequestDTO
//   REQUEST  POST   api/messages/v3/delete   [Service.API]
public class DeleteMessagesRequestDTO
{
    public List<long> MessageIds;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Events.BroadcastRoomInstanceRequest
//   (not directly referenced by a detected call)
public class BroadcastRoomInstanceRequest
{
    public long <AFEHBIGNHFN>k__BackingField;    // 0x0x10
    public long? <POKHKBLCHDC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.BulkInviteRequest
//   (not directly referenced by a detected call)
public class BulkInviteRequest
{
    public long PlayerEventId;    // 0x0x10
    public List<int> InvitedPlayerIds;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.DeleteResponseRequest
//   (not directly referenced by a detected call)
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
    public JJBGMKPENGF FilterType;    // 0x0x20
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
// RecNet.InventionBatchRequest
//   (not directly referenced by a detected call)
public class InventionBatchRequest
{
    public List<long> InventionIds;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCategoryConfigDTO
//   (not directly referenced by a detected call)
public class KeepsakeCategoryConfigDTO
{
    public JHAAPFBDNOG <OKIOIKECEIH>k__BackingField;    // 0x0x10
    public string <GCBPMFLCGKI>k__BackingField;    // 0x0x18
    public int <IKBLJCJGDGO>k__BackingField;    // 0x0x20
    public int <JNLFEOFLKND>k__BackingField;    // 0x0x24
    public string <AHIFPJHNNBM>k__BackingField;    // 0x0x28
    public string <NEKHOMIODJH>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <GKDMFACMLNL>k__BackingField;    // 0x0x10
    public Guid <MBMOCCIIKJN>k__BackingField;    // 0x0x14
    public DateTime <EGFCBCHDBNN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.API]
public class KeepsakeGlobalConfigDTO
{
    public bool <JMMBKKBNEFO>k__BackingField;    // 0x0x10
    public int <PHKOPKCDAGI>k__BackingField;    // 0x0x14
    public bool <CMLAKNJJGLB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <MBMOCCIIKJN>k__BackingField;    // 0x0x10
    public JHAAPFBDNOG <GFDHHIIMJBK>k__BackingField;    // 0x0x20
    public int <HMHCPFNMNCE>k__BackingField;    // 0x0x24
    public long <LKCBLBEFIAI>k__BackingField;    // 0x0x28
    public long? <HAPEELJOPBD>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE POST   api/keepsakes   [Service.API]
//   RESPONSE GET    api/keepsakes/events/{iHEMHLGHIIK}   [Service.API]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <OGFKKNIMOEC>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <OMCJAJKCAFE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <AHEKDPFFHMJ>k__BackingField;    // 0x0x10
    public long <LKCBLBEFIAI>k__BackingField;    // 0x0x18
    public long <PKOLLPAKGJO>k__BackingField;    // 0x0x20
    public KMLAJEKFFBE <EBELECOJBBC>k__BackingField;    // 0x0x28
    public int <FJMDHPECNJA>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <LKCBLBEFIAI>k__BackingField;    // 0x0x10
    public List<Guid> <OBMBDCFDIOL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <OGFKKNIMOEC>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <OMCJAJKCAFE>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <FIHIMPENAPH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <PKOLLPAKGJO>k__BackingField;    // 0x0x10
    public long <JKMLGPEBGLP>k__BackingField;    // 0x0x18
    public int? <BPOODDLJMFB>k__BackingField;    // 0x0x20
    public int? <FPPODKJGNEL>k__BackingField;    // 0x0x28
    public long? <IAEMHFPCBGF>k__BackingField;    // 0x0x30
    public long <AIBHPHPNBJB>k__BackingField;    // 0x0x40
    public long <PONOPCPPKHI>k__BackingField;    // 0x0x48
    public int <BLNIHKAIGFH>k__BackingField;    // 0x0x50
    public KMLAJEKFFBE <APONIMJAGJJ>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <OHEFBHJOBEB>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.KickPlayerDTO
//   REQUEST  POST   api/PlayerReporting/v1/instantKick   [Service.API]
public class KickPlayerDTO
{
    public long GameSessionId;    // 0x0x10
    public List<int> PlayerIds;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ModifyTagsRequest
//   REQUEST  POST   api/inventions/v1/settags   [Service.API]
public class ModifyTagsRequest
{
    public long InventionId;    // 0x0x10
    public List<string> AutoTags;    // 0x0x18
    public List<string> CustomTags;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.MultiRecipientFreeGiftRequestDTO
//   REQUEST  POST   api/freegifts/v1/sendmultiple   [Service.Econ]
public class MultiRecipientFreeGiftRequestDTO
{
    public List<int> <ToPlayerIds>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public MKMPCEKEFLK <GiftContext>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.NewInventionRequestDTO
//   (not directly referenced by a detected call)
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
    public long creationRoomId;    // 0x0x40
    public string inventionDataFilename;    // 0x0x48
    public List<long> referencedInventions;    // 0x0x50
    public GBHHNOAKMKO creatorAccountRole;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public FCDKKOKJMAA <ODCIAGIEKFB>k__BackingField;    // 0x0x10
    public JBHILMBNEMN <FMLCBHHPMEG>k__BackingField;    // 0x0x14
    public string <CONKJABBPPD>k__BackingField;    // 0x0x18
    public string <PONPFJBCEGB>k__BackingField;    // 0x0x20
    public bool <LCNLMOKIFKA>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public List<FCDKKOKJMAA> <COFIBHPKOMP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/event/{bINPFEABBIL}   [Service.API]
public class ProgressionEventDTO
{
    public long <JKMLGPEBGLP>k__BackingField;    // 0x0x10
    public string <CONKJABBPPD>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <CBOEPFNCNJD>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <BLOKFOMBCHN>k__BackingField;    // 0x0x28
    public DateTime <CNDGIOIFBAI>k__BackingField;    // 0x0x30
    public DateTime <EIHLDODAILL>k__BackingField;    // 0x0x38
    public DateTime <NKDEEPDCAAN>k__BackingField;    // 0x0x40
    public bool <EAHBFOOIBHO>k__BackingField;    // 0x0x48
    public int <KIJKFNNICJD>k__BackingField;    // 0x0x4C
    public float <BAIBFBKFMGA>k__BackingField;    // 0x0x50
    public Guid? <OJIIFNNFILG>k__BackingField;    // 0x0x54
    public string <EMIBLEKKFIL>k__BackingField;    // 0x0x68
    public string <LBNIGOPKEPE>k__BackingField;    // 0x0x70
    public string <PPFIONEJMLE>k__BackingField;    // 0x0x78
    public string <NOABDHKEMPG>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <OBBNBCOIBDD>k__BackingField;    // 0x0x10
    public int <COIGMMNNGPK>k__BackingField;    // 0x0x20
    public int <KLMHJMGFHMN>k__BackingField;    // 0x0x24
    public int <PEMKICKGKLM>k__BackingField;    // 0x0x28
    public long <NIIEHBLPHJF>k__BackingField;    // 0x0x30
    public long <LKEAOEHAJOE>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.API]
public class ProgressionEventRecordDTO
{
    public int <GKDMFACMLNL>k__BackingField;    // 0x0x10
    public int <DNMGADCAJHA>k__BackingField;    // 0x0x14
    public int <PHHDIAIJBPH>k__BackingField;    // 0x0x18
    public int <BOJIAABBEMG>k__BackingField;    // 0x0x1C
    public int <PMLJNIPPKKH>k__BackingField;    // 0x0x20
    public DateTime? <KGOLNPILFBC>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <AELFBJIGKOE>k__BackingField;    // 0x0x10
    public int <LLIHGLPELHN>k__BackingField;    // 0x0x18
    public string <EDBOLNBDLOA>k__BackingField;    // 0x0x20
    public int <DNMGADCAJHA>k__BackingField;    // 0x0x28
    public int <LMLLLCDFEAF>k__BackingField;    // 0x0x2C
    public bool <HBHCGBIJPOL>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public GPOPEGPDPHH ReportCategory;    // 0x0x20
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
//   REQUEST  POST   api/inventions/v1/updateprice   [Service.API]
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
    public bool EEGCGKCEJOE;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.Foundation.Templates.SA_DataResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class SA_DataResult : SA_Result
{
    public string m_Data;    // 0x0x28
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
// SA.iOS.AuthenticationServices.ISN_ASAuthorizationOpenIDRequest
// base   : SA.iOS.AuthenticationServices.ISN_ASAuthorizationRequest
//   (not directly referenced by a detected call)
public class ISN_ASAuthorizationOpenIDRequest : ISN_ASAuthorizationRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.AuthenticationServices.ISN_ASAuthorizationRequest
// base   : SA.iOS.Utilities.ISN_NativeObject
//   (not directly referenced by a detected call)
public class ISN_ASAuthorizationRequest : ISN_NativeObject
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.AuthenticationServices.ISN_ASAuthorizationSingleSignOnRequest
// base   : SA.iOS.AuthenticationServices.ISN_IASAuthorizationAppleIDRequest
//   (not directly referenced by a detected call)
public class ISN_ASAuthorizationSingleSignOnRequest : ISN_IASAuthorizationAppleIDRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.AuthenticationServices.ISN_IASAuthorizationAppleIDRequest
// base   : SA.iOS.AuthenticationServices.ISN_ASAuthorizationOpenIDRequest
//   (not directly referenced by a detected call)
public class ISN_IASAuthorizationAppleIDRequest : ISN_ASAuthorizationOpenIDRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.CloudKit.ISN_CKResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_CKResult : SA_Result
{
    public string m_State;    // 0x0x28
    public string m_Description;    // 0x0x30
    public int m_ErrorCode;    // 0x0x38
    public ISN_CKRecord m_Record;    // 0x0x40
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
// SA.iOS.EventKit.ISN_AlarmDataRequest
//   (not directly referenced by a detected call)
public class ISN_AlarmDataRequest
{
    public bool m_HasAlarm;    // 0x0x10
    public bool m_isAbsoluteDate;    // 0x0x11
    public long m_DueDate;    // 0x0x18
    public long m_TimeStamp;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EKAlarmDataRequest
//   (not directly referenced by a detected call)
public class ISN_EKAlarmDataRequest
{
    public bool m_HasAlarm;    // 0x0x10
    public bool m_IsAbsoluteDate;    // 0x0x11
    public long m_DueDate;    // 0x0x18
    public long m_TimeStamp;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EKDataRequest
//   (not directly referenced by a detected call)
public class ISN_EKDataRequest
{
    public string m_Title;    // 0x0x10
    public long m_StartDate;    // 0x0x18
    public long m_EndDate;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EKRecurrenceRuleRequest
//   (not directly referenced by a detected call)
public class ISN_EKRecurrenceRuleRequest
{
    public bool m_HasRule;    // 0x0x10
    public string m_Frequency;    // 0x0x18
    public int m_Interval;    // 0x0x20
    public bool m_HasEndDate;    // 0x0x24
    public long m_EndDate;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EKSaveResult
//   (not directly referenced by a detected call)
public class ISN_EKSaveResult
{
    public string m_Identifier;    // 0x0x10
    public SA_Result m_Result;    // 0x0x18
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EventKitDataRequest
//   (not directly referenced by a detected call)
public class ISN_EventKitDataRequest
{
    public string m_Title;    // 0x0x10
    public long m_StartDate;    // 0x0x18
    public long m_EndDate;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EventKitSaveResult
//   (not directly referenced by a detected call)
public class ISN_EventKitSaveResult
{
    public string m_Identifier;    // 0x0x10
    public SA_Result m_Result;    // 0x0x18
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_RecurrenceRuleRequest
//   (not directly referenced by a detected call)
public class ISN_RecurrenceRuleRequest
{
    public bool m_HasRule;    // 0x0x10
    public string m_Frequency;    // 0x0x18
    public int m_Interval;    // 0x0x20
    public bool m_HasEndDate;    // 0x0x24
    public long m_EndDate;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.Foundation.ISN_NSKeyValueResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_NSKeyValueResult : SA_Result
{
    public ISN_NSKeyValueObject m_KeyValueObject;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKAchievementsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKAchievementsResult : SA_Result
{
    public List<ISN_GKAchievement> m_Achievements;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKIdentityVerificationSignatureResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKIdentityVerificationSignatureResult : SA_Result
{
    public string m_PublicKeyUrl;    // 0x0x28
    public string m_Signature;    // 0x0x30
    public string m_Salt;    // 0x0x38
    public long m_Timestamp;    // 0x0x40
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKImageLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKImageLoadResult : SA_Result
{
    public Texture2D m_Image;    // 0x0x28
    public string m_ImageBase64;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKLeaderboardsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKLeaderboardsResult : SA_Result
{
    public List<ISN_GKLeaderboard> m_Leaderboards;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKLoadDefaultLeaderboardResult
// base   : SA.Foundation.Templates.SA_DataResult
//   (not directly referenced by a detected call)
public class ISN_GKLoadDefaultLeaderboardResult : SA_DataResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKResolveSavedGamesRequest
//   (not directly referenced by a detected call)
public class ISN_GKResolveSavedGamesRequest
{
    public List<string> m_ConflictedGames;    // 0x0x10
    public string m_Data;    // 0x0x18
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKSavedGameFetchResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameFetchResult : SA_Result
{
    public List<ISN_GKSavedGame> m_SavedGames;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKSavedGameLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameLoadResult : SA_Result
{
    public string m_Data;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKSavedGameSaveResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameSaveResult : SA_Result
{
    public ISN_GKSavedGame m_SavedGame;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKScoreLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKScoreLoadResult : SA_Result
{
    public List<ISN_GKScore> m_Scores;    // 0x0x28
    public ISN_GKLeaderboard m_Leaderboard;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.Internal.ISN_GKScoreRequest
//   (not directly referenced by a detected call)
public class ISN_GKScoreRequest
{
    public List<ISN_GKScore> m_scores;    // 0x0x10
}

// --------------------------------------------------------------------------
// SA.iOS.Photos.ISN_PHFetchResult`1
// base   : SA.iOS.Utilities.ISN_NativeObject
//   (not directly referenced by a detected call)
public class ISN_PHFetchResult : ISN_NativeObject
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.ReplayKit.ISN_PRPreviewResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_PRPreviewResult : SA_Result
{
    public List<string> m_ActivityTypes;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.ReplayKit.ISN_RPStopResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_RPStopResult : SA_Result
{
    public bool m_HasPreviewController;    // 0x0x28
    public ISN_RPPreviewViewController PreviewController;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.Social.Enum.TextMessageComposeResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum TextMessageComposeResult
{
    Cancelled = 0,
    Sent = 1,
    Failed = 2,
    NotSupportedByDevice = 3,
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
// SA.iOS.StoreKit.ISN_SKInitResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_SKInitResult : SA_Result
{
    public List<ISN_SKProduct> m_Products;    // 0x0x28
    public List<string> m_InvalidProductIdentifiers;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKProductsRequest
//   (not directly referenced by a detected call)
public class ISN_SKProductsRequest
{
    public ISN_LoadStoreRequest m_loadStoreRequest;    // 0x0x10
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
// SA.iOS.UIKit.ISN_UIApplicationDelegateResult
//   (not directly referenced by a detected call)
public class ISN_UIApplicationDelegateResult
{
    public string m_EventName;    // 0x0x10
    public string m_Data;    // 0x0x18
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIMenuControllerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIMenuControllerResult : SA_Result
{
    public int m_ChosenIndex;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIPickerControllerRequest
//   (not directly referenced by a detected call)
public class ISN_UIPickerControllerRequest
{
    public List<string> m_MediaTypes;    // 0x0x10
    public ISN_UIImagePickerControllerSourceType m_SourceType;    // 0x0x18
    public bool m_AllowsEditing;    // 0x0x1C
    public float m_ImageCompressionRate;    // 0x0x20
    public int m_MaxImageSize;    // 0x0x24
    public ISN_UIImageCompressionFormat m_EncodingType;    // 0x0x28
    public ISN_UIImagePickerControllerCameraDevice m_CameraDevice;    // 0x0x2C
    public ISN_UIModalPresentationStyle m_ModalPresentationStyle;    // 0x0x30
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
    public string m_DeviceTokenUtf8;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIWheelPickerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIWheelPickerResult : SA_Result
{
    public string m_Value;    // 0x0x28
    public string m_State;    // 0x0x30
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
// StansAssets.Foundation.CachedWebRequest
//   (not directly referenced by a detected call)
public class CachedWebRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// StansAssets.Foundation.Models.IResult
//   (not directly referenced by a detected call)
public class IResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// StansAssets.Foundation.Models.Result
//   (not directly referenced by a detected call)
public class Result
{
    public Error m_Error;    // 0x0x10
}

// --------------------------------------------------------------------------
// Steamworks.CallResult
//   (not directly referenced by a detected call)
public class CallResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Steamworks.CallResult`1
// base   : Steamworks.CallResult
//   (not directly referenced by a detected call)
public class CallResult : CallResult
{
    public APIDispatchDelegate<T> m_Func;    // 0x0x0
    public SteamAPICall_t m_hAPICall;    // 0x0x0
    public bool m_bDisposed;    // 0x0x0
}

// --------------------------------------------------------------------------
// Steamworks.EAuthSessionResponse
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EAuthSessionResponse
{
    k_EAuthSessionResponseOK = 0,
    k_EAuthSessionResponseUserNotConnectedToSteam = 1,
    k_EAuthSessionResponseNoLicenseOrExpired = 2,
    k_EAuthSessionResponseVACBanned = 3,
    k_EAuthSessionResponseLoggedInElseWhere = 4,
    k_EAuthSessionResponseVACCheckTimedOut = 5,
    k_EAuthSessionResponseAuthTicketCanceled = 6,
    k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed = 7,
    k_EAuthSessionResponseAuthTicketInvalid = 8,
    k_EAuthSessionResponsePublisherIssuedBan = 9,
}

// --------------------------------------------------------------------------
// Steamworks.EBeginAuthSessionResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EBeginAuthSessionResult
{
    k_EBeginAuthSessionResultOK = 0,
    k_EBeginAuthSessionResultInvalidTicket = 1,
    k_EBeginAuthSessionResultDuplicateRequest = 2,
    k_EBeginAuthSessionResultInvalidVersion = 3,
    k_EBeginAuthSessionResultGameMismatch = 4,
    k_EBeginAuthSessionResultExpiredTicket = 5,
}

// --------------------------------------------------------------------------
// Steamworks.EBroadcastUploadResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EBroadcastUploadResult
{
    k_EBroadcastUploadResultNone = 0,
    k_EBroadcastUploadResultOK = 1,
    k_EBroadcastUploadResultInitFailed = 2,
    k_EBroadcastUploadResultFrameFailed = 3,
    k_EBroadcastUploadResultTimeout = 4,
    k_EBroadcastUploadResultBandwidthExceeded = 5,
    k_EBroadcastUploadResultLowFPS = 6,
    k_EBroadcastUploadResultMissingKeyFrames = 7,
    k_EBroadcastUploadResultNoConnection = 8,
    k_EBroadcastUploadResultRelayFailed = 9,
    k_EBroadcastUploadResultSettingsChanged = 10,
    k_EBroadcastUploadResultMissingAudio = 11,
    k_EBroadcastUploadResultTooFarBehind = 12,
    k_EBroadcastUploadResultTranscodeBehind = 13,
    k_EBroadcastUploadResultNotAllowedToPlay = 14,
    k_EBroadcastUploadResultBusy = 15,
    k_EBroadcastUploadResultBanned = 16,
    k_EBroadcastUploadResultAlreadyActive = 17,
    k_EBroadcastUploadResultForcedOff = 18,
    k_EBroadcastUploadResultAudioBehind = 19,
    k_EBroadcastUploadResultShutdown = 20,
    k_EBroadcastUploadResultDisconnect = 21,
    k_EBroadcastUploadResultVideoInitFailed = 22,
    k_EBroadcastUploadResultAudioInitFailed = 23,
}

// --------------------------------------------------------------------------
// Steamworks.EChatRoomEnterResponse
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EChatRoomEnterResponse
{
    k_EChatRoomEnterResponseSuccess = 1,
    k_EChatRoomEnterResponseDoesntExist = 2,
    k_EChatRoomEnterResponseNotAllowed = 3,
    k_EChatRoomEnterResponseFull = 4,
    k_EChatRoomEnterResponseError = 5,
    k_EChatRoomEnterResponseBanned = 6,
    k_EChatRoomEnterResponseLimited = 7,
    k_EChatRoomEnterResponseClanDisabled = 8,
    k_EChatRoomEnterResponseCommunityBan = 9,
    k_EChatRoomEnterResponseMemberBlockedYou = 10,
    k_EChatRoomEnterResponseYouBlockedMember = 11,
    k_EChatRoomEnterResponseRatelimitExceeded = 15,
}

// --------------------------------------------------------------------------
// Steamworks.ELeaderboardDataRequest
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ELeaderboardDataRequest
{
    k_ELeaderboardDataRequestGlobal = 0,
    k_ELeaderboardDataRequestGlobalAroundUser = 1,
    k_ELeaderboardDataRequestFriends = 2,
    k_ELeaderboardDataRequestUsers = 3,
}

// --------------------------------------------------------------------------
// Steamworks.EMatchMakingServerResponse
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EMatchMakingServerResponse
{
    eServerResponded = 0,
    eServerFailedToRespond = 1,
    eNoServersListedOnMasterServer = 2,
}

// --------------------------------------------------------------------------
// Steamworks.ERegisterActivationCodeResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ERegisterActivationCodeResult
{
    k_ERegisterActivationCodeResultOK = 0,
    k_ERegisterActivationCodeResultFail = 1,
    k_ERegisterActivationCodeResultAlreadyRegistered = 2,
    k_ERegisterActivationCodeResultTimeout = 3,
    k_ERegisterActivationCodeAlreadyOwned = 4,
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
// Steamworks.EUserHasLicenseForAppResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EUserHasLicenseForAppResult
{
    k_EUserHasLicenseResultHasLicense = 0,
    k_EUserHasLicenseResultDoesNotHaveLicense = 1,
    k_EUserHasLicenseResultNoAuth = 2,
}

// --------------------------------------------------------------------------
// Steamworks.EVoiceResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EVoiceResult
{
    k_EVoiceResultOK = 0,
    k_EVoiceResultNotInitialized = 1,
    k_EVoiceResultNotRecording = 2,
    k_EVoiceResultNoData = 3,
    k_EVoiceResultBufferTooSmall = 4,
    k_EVoiceResultDataCorrupted = 5,
    k_EVoiceResultRestricted = 6,
    k_EVoiceResultUnsupportedCodec = 7,
    k_EVoiceResultReceiverOutOfDate = 8,
    k_EVoiceResultReceiverDidNotAnswer = 9,
}

// --------------------------------------------------------------------------
// Steamworks.HServerListRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class HServerListRequest : ValueType
{
    public nint m_HServerListRequest;    // 0x0x0
}

// --------------------------------------------------------------------------
// Steamworks.ISteamMatchmakingPingResponse
//   (not directly referenced by a detected call)
public class ISteamMatchmakingPingResponse
{
    public VTable m_VTable;    // 0x0x10
    public nint m_pVTable;    // 0x0x18
    public GCHandle m_pGCHandle;    // 0x0x20
    public ServerResponded m_ServerResponded;    // 0x0x28
    public ServerFailedToRespond m_ServerFailedToRespond;    // 0x0x30
}

// --------------------------------------------------------------------------
// Steamworks.ISteamMatchmakingPlayersResponse
//   (not directly referenced by a detected call)
public class ISteamMatchmakingPlayersResponse
{
    public VTable m_VTable;    // 0x0x10
    public nint m_pVTable;    // 0x0x18
    public GCHandle m_pGCHandle;    // 0x0x20
    public AddPlayerToList m_AddPlayerToList;    // 0x0x28
    public PlayersFailedToRespond m_PlayersFailedToRespond;    // 0x0x30
    public PlayersRefreshComplete m_PlayersRefreshComplete;    // 0x0x38
}

// --------------------------------------------------------------------------
// Steamworks.ISteamMatchmakingRulesResponse
//   (not directly referenced by a detected call)
public class ISteamMatchmakingRulesResponse
{
    public VTable m_VTable;    // 0x0x10
    public nint m_pVTable;    // 0x0x18
    public GCHandle m_pGCHandle;    // 0x0x20
    public RulesResponded m_RulesResponded;    // 0x0x28
    public RulesFailedToRespond m_RulesFailedToRespond;    // 0x0x30
    public RulesRefreshComplete m_RulesRefreshComplete;    // 0x0x38
}

// --------------------------------------------------------------------------
// Steamworks.ISteamMatchmakingServerListResponse
//   (not directly referenced by a detected call)
public class ISteamMatchmakingServerListResponse
{
    public VTable m_VTable;    // 0x0x10
    public nint m_pVTable;    // 0x0x18
    public GCHandle m_pGCHandle;    // 0x0x20
    public ServerResponded m_ServerResponded;    // 0x0x28
    public ServerFailedToRespond m_ServerFailedToRespond;    // 0x0x30
    public RefreshComplete m_RefreshComplete;    // 0x0x38
}

// --------------------------------------------------------------------------
// Unity.Burst.EagerCompilationRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class EagerCompilationRequest : ValueType
{
    public string EncodedMethod;    // 0x0x0
    public string Options;    // 0x0x8
}

// ==========================================================================
// SYNTHESIZED request DTOs: no wire body DTO was observed;
// these are built from observed form/query params, wrapper
// params and candidate keys. Field origins: form = POST/PUT
// form field, query = URL query param, wrapper = wrapper
// signature (not observed on wire), candidate = low
// confidence key. Names derive from the route.
// ==========================================================================

// api/CampusCard/v1/UpdateAndGetSubscription  [Econ POST]
public class CampusCardV1UpdateAndGetSubscriptionRequest
{
    public string accessToken;  // wrapper
}

// api/PlayerCheer/v1/SetSelectedCheer  [API POST]
public class PlayerCheerV1SetSelectedCheerRequest
{
    public BBDDFDPHGKC? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public BBDDFDPHGKC JANEPFDJEIP;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public MOFMPAFGGMG FNDLLPGIPGJ;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public PGGOOHJPFPC LEDIIMFEFLP;  // wrapper
    public int? GFDIPLHHPAN;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v3/create  [API POST]
public class PlayerReportingV3CreateRequest
{
    public FOCLJOBLLOL FJPNCGCNOLL;  // wrapper
    public float? MDEAGJBLMDI;  // wrapper
    public object ReportCategory;  // candidate
    public object HeightReporter;  // candidate
    public object RoomInstanceType;  // candidate
    public object RoomId;  // candidate
    public object HeightReported;  // candidate
}

// api/PlayerReporting/v3/voteToKick  [API POST]
public class PlayerReportingV3VoteToKickRequest
{
    public object Response;  // candidate
    public object GameSessionId;  // candidate
    public object PlayerId;  // candidate
    public object Reason;  // candidate
}

// api/avatar/v1/lockeditems  [Econ GET]
public class AvatarV1LockeditemsRequest
{
    public List<string> desc;  // query
}

// api/avatar/v2/gifts/consume/  [Econ POST]
public class AvatarV2GiftsConsumeRequest
{
    public CGGJJIKBPOP UnlockedLevel;  // wrapper
}

// api/avatar/v2/gifts/generate  [Econ POST]
public class AvatarV2GiftsGenerateRequest
{
    public MKMPCEKEFLK IJBJKIBEJLN;  // wrapper
    public MKMPCEKEFLK? AKPCCJMJBEF;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [Econ POST]
public class AvatarV3GiftsGenerateRequest
{
    public MKMPCEKEFLK IJBJKIBEJLN;  // wrapper
    public MKMPCEKEFLK? AKPCCJMJBEF;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/challenge/v2/updateProgress  [Econ POST]
public class ChallengeV2UpdateProgressRequest
{
    public HOJHCFKHFAH OBADIJFCOPH;  // wrapper
    public object UpdateChallengeProgress;  // candidate
    public object ChallengeId;  // candidate
    public object Config;  // candidate
    public object ChallengeMapId;  // candidate
    public object Complete;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public FOCLJOBLLOL FJPNCGCNOLL;  // wrapper
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

// api/customAvatarItems/v1  [API POST]
public class CustomAvatarItemsV1Request
{
    public FOLDEHLIODE GGMKKBDFNNH;  // wrapper
    public DPCCPIFEEED OOFEGEIMBHN;  // wrapper
    public byte[] PDNOLLAOMFD;  // wrapper
    public byte[] OBOJDEPMFPN;  // wrapper
    public Color MHCJBLNNNKG;  // wrapper
    public object metadata;  // candidate
    public object thumbnailImage;  // candidate
    public object design;  // candidate
    public object file.bin;  // candidate
}

// api/customAvatarItems/v1/me  [API GET]
public class CustomAvatarItemsV1MeRequest
{
    public object take;  // candidate
    public object skip;  // candidate
}

// api/customAvatarItems/v1/search  [API GET]
public class CustomAvatarItemsV1SearchRequest
{
    public object minPrice;  // candidate
    public object isOwned;  // candidate
    public object itemTypes;  // candidate
    public object isFeatured;  // candidate
    public object creatorUsername;  // candidate
}

// api/equipment/v1/update  [Econ POST]
public class EquipmentV1UpdateRequest
{
    public List<HPMJEFKNIAC> ANCPBOAEGOI;  // wrapper
}

// api/externalfriendinvite/v1/createplatforminvite  [API POST]
public class ExternalfriendinviteV1CreateplatforminviteRequest
{
    public string platformId;  // wrapper
}

// api/externalfriendinvite/v1/sendtextmessageinvite  [API POST]
public class ExternalfriendinviteV1SendtextmessageinviteRequest
{
    public object phoneNumber;  // candidate
    public object senderName;  // candidate
    public object friendCode;  // candidate
}

// api/gamerewards/v1/request  [Econ POST]
public class GamerewardsV1RequestRequest
{
    public PIOIBGDLBGG DLHCEEFBBDN;  // wrapper
    public MKMPCEKEFLK? KOCNAHJDHEG;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [Econ POST]
public class GamerewardsV1SelectRequest
{
    public BAMINPFAEAL DIIGKGPADOD;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/gamesight/event  [API POST]
public class GamesightEventRequest
{
    public object EventData;  // candidate
    public object cumulative;  // candidate
}

// api/images/v5/bulk  [API ?]
public class ImagesV5BulkRequest
{
    public List<long> ids;  // param
}

// api/images/v5/cheered/bulk  [API ?]
public class ImagesV5CheeredBulkRequest
{
    public List<long> id;  // param
}

// api/images/v5/player/{playerId}  [API GET]
public class ImagesV5PlayerPlayerIdRequest
{
    public object sort;  // candidate
}

// api/images/v6  [API GET]
public class ImagesV6Request
{
    public string name;  // wrapper
}

// api/incentivizedreferrals/  [Econ GET]
public class IncentivizedreferralsRequest
{
    public object referrals;  // candidate
    public object continuationToken;  // candidate
    public object take;  // candidate
}

// api/incentivizedreferrals/claim  [Econ POST]
public class IncentivizedreferralsClaimRequest
{
    public int ReferralRewardId;  // wrapper
}

// api/influencerpartnerprogram/influencer  [Econ GET]
public class InfluencerpartnerprogramInfluencerRequest
{
    public int accountId;  // wrapper
}

// api/influencerpartnerprogram/influencers  [Econ GET]
public class InfluencerpartnerprogramInfluencersRequest
{
    public object continuationToken;  // candidate
    public object take;  // candidate
}

// api/influencerpartnerprogram/remove  [Econ POST]
public class InfluencerpartnerprogramRemoveRequest
{
    public int influencerAccountId;  // wrapper
}

// api/influencerpartnerprogram/support  [Econ POST]
public class InfluencerpartnerprogramSupportRequest
{
    public int influencerAccountId;  // wrapper
}

// api/inventions/v1/delete  [API GET]
public class InventionsV1DeleteRequest
{
    public LEBCJODDAKI inventionId;  // wrapper
}

// api/inventions/v1/details  [API GET]
public class InventionsV1DetailsRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v1/dormskinsfromids  [API ?]
public class InventionsV1DormskinsfromidsRequest
{
    public List<long> ids;  // param
}

// api/inventions/v1/fulllineageowner  [API GET]
public class InventionsV1FulllineageownerRequest
{
    public List<long> id;  // query
}

// api/inventions/v1/unpublish  [API GET]
public class InventionsV1UnpublishRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v1/update  [API GET]
public class InventionsV1UpdateRequest
{
    public object name;  // candidate
    public object inventionId;  // candidate
    public object description;  // candidate
    public object imgName;  // candidate
    public object permission;  // candidate
}

// api/inventions/v1/versions  [API GET]
public class InventionsV1VersionsRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v2/batch  [API ?]
public class InventionsV2BatchRequest
{
    public List<long> id;  // param
}

// api/inventions/v2/search  [API GET]
public class InventionsV2SearchRequest
{
    public object value;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/inventions/v3/publish  [API GET]
public class InventionsV3PublishRequest
{
    public object price;  // candidate
    public object accessibility;  // candidate
    public object permissionLevel;  // candidate
    public object inventionId;  // candidate
}

// api/keepsakes/{pGDCMKGLNJL}/collect  [API POST]
public class KeepsakesPGDCMKGLNJLCollectRequest
{
    public Guid PGDCMKGLNJL;  // wrapper
}

// api/messages/v1/sendMultiple  [API POST]
public class MessagesV1SendMultipleRequest
{
    public List<long> PKDJLFEANKI;  // wrapper
    public DOKOBKNFKGC ACGOEHFICPM;  // wrapper
    public long? GJDNMGJBIPD;  // wrapper
    public object ToPlayerIds;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
    public object SendMessageMultiple;  // candidate
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public DOKOBKNFKGC ACGOEHFICPM;  // wrapper
    public long? GJDNMGJBIPD;  // wrapper
    public object ToPlayerId;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
}

// api/offlineinvite/v1/send  [API POST]
public class OfflineinviteV1SendRequest
{
    public long PlayerId;  // wrapper
}

// api/playerevents/v1/broadcast  [API POST]
public class PlayereventsV1BroadcastRequest
{
    public long? NBFNMFGBHGB;  // wrapper
}

// api/playerevents/v1/bulk  [API POST]
public class PlayereventsV1BulkRequest
{
    public IReadOnlyList<long> BKDHCGHBBKN;  // wrapper
}

// api/playerevents/v1/bulkInvite  [API POST]
public class PlayereventsV1BulkInviteRequest
{
    public List<int> PKDJLFEANKI;  // wrapper
}

// api/playerevents/v1/deleteResponse  [API POST]
public class PlayereventsV1DeleteResponseRequest
{
    public LAHPKFOHLHP FBLMHHGAGOK;  // wrapper
}

// api/playerevents/v1/report  [API POST]
public class PlayereventsV1ReportRequest
{
    public FOCLJOBLLOL FJPNCGCNOLL;  // wrapper
}

// api/playerevents/v1/respond  [API POST]
public class PlayereventsV1RespondRequest
{
    public LAHPKFOHLHP FBLMHHGAGOK;  // wrapper
}

// api/playerevents/v2  [API POST]
public class PlayereventsV2Request
{
    public long? EOEOMNAMOHH;  // wrapper
    public long? PPENBIEBLOG;  // wrapper
    public List<string> BHOCDGAIFEO;  // wrapper
    public DateTime OFBGFAMJLFM;  // wrapper
    public DateTime JDFAADPEHNP;  // wrapper
    public OBMDKFJPBCD GGMKKBDFNNH;  // wrapper
    public BAJEPNEDFEF JAAEOPCNOKA;  // wrapper
    public BAJEPNEDFEF FOKJJJCJELE;  // wrapper
}

// api/playerevents/v2/{eventId}  [API POST]
public class PlayereventsV2EventIdRequest
{
    public long? EOEOMNAMOHH;  // wrapper
    public List<string> BHOCDGAIFEO;  // wrapper
    public DateTime OFBGFAMJLFM;  // wrapper
    public DateTime JDFAADPEHNP;  // wrapper
    public OBMDKFJPBCD GGMKKBDFNNH;  // wrapper
    public long? PPENBIEBLOG;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public OBMDKFJPBCD GGMKKBDFNNH;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? PPENBIEBLOG;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public BAJEPNEDFEF JAAEOPCNOKA;  // wrapper
    public BAJEPNEDFEF KHNLAJGBJAF;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? EOEOMNAMOHH;  // wrapper
}

// api/playerevents/v2/{eventId}/tags  [API PUT]
public class PlayereventsV2EventIdTagsRequest
{
    public List<string> BHOCDGAIFEO;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime OFBGFAMJLFM;  // wrapper
    public DateTime JDFAADPEHNP;  // wrapper
}

// api/playerwarnings  [API POST]
public class PlayerwarningsRequest
{
    public FOCLJOBLLOL FJPNCGCNOLL;  // wrapper
    public object ModeratorNote;  // candidate
    public object WarnedPlayerId;  // candidate
    public object ReportCategory;  // candidate
    public object DisplayReason;  // candidate
}

// api/relationships/v1/addfriendwithcode  [API GET]
public class RelationshipsV1AddfriendwithcodeRequest
{
    public object code;  // candidate
}

// api/roomCurrencies/v2/purchase  [Econ POST]
public class RoomCurrenciesV2PurchaseRequest
{
    public Guid EBMENFPIEOK;  // wrapper
    public object PurchaseOfferId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedAmount;  // candidate
}

// api/roomcurrencies/v1/awardCurrency/bulk  [Econ POST]
public class RoomcurrenciesV1AwardCurrencyBulkRequest
{
    public List<CLCDDMJAKFK> LOKCNOKJPKO;  // wrapper
}

// api/roomcurrencies/v1/createCurrency  [Econ POST]
public class RoomcurrenciesV1CreateCurrencyRequest
{
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
    public object RoomId;  // candidate
    public object Description;  // candidate
}

// api/roomcurrencies/v1/createPurchaseOffer  [Econ POST]
public class RoomcurrenciesV1CreatePurchaseOfferRequest
{
    public Guid ELLEFEEDEGF;  // wrapper
    public object Price;  // candidate
    public object CurrencyId;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object Order;  // candidate
}

// api/roomcurrencies/v1/currencies  [Econ GET]
public class RoomcurrenciesV1CurrenciesRequest
{
    public object roomId;  // candidate
}

// api/roomcurrencies/v1/deletePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1DeletePurchaseOfferRequest
{
    public Guid PurchaseOfferId;  // wrapper
}

// api/roomcurrencies/v1/getAllBalances  [Econ GET]
public class RoomcurrenciesV1GetAllBalancesRequest
{
    public object roomId;  // candidate
}

// api/roomcurrencies/v1/getBalance  [Econ GET]
public class RoomcurrenciesV1GetBalanceRequest
{
    public object accountId;  // candidate
    public object currencyId;  // candidate
}

// api/roomcurrencies/v1/updateCurrency  [Econ POST]
public class RoomcurrenciesV1UpdateCurrencyRequest
{
    public Guid ELLEFEEDEGF;  // wrapper
    public long? GJPPPGOHKEB;  // wrapper
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
    public object Description;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid EBMENFPIEOK;  // wrapper
    public long? IAJFCILFPNL;  // wrapper
    public long? AHOMMDLFNII;  // wrapper
    public int? AELDILNFOHF;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [Econ PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> DNHNNDBCPLH;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/awardbulk  [Econ POST]
public class RoomkeysV1AwardbulkRequest
{
    public IEnumerable<FJLGBEHGKFN> HDODKOGGAII;  // wrapper
}

// api/roomkeys/v1/create  [Econ POST]
public class RoomkeysV1CreateRequest
{
    public Guid? NNDIDIGJHPJ;  // wrapper
    public object Price;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object RoomId;  // candidate
    public object PurchaseCurrencyId;  // candidate
}

// api/roomkeys/v1/owns  [Econ GET]
public class RoomkeysV1OwnsRequest
{
    public object playerId;  // candidate
    public object roomKeyId;  // candidate
}

// api/rooms/v1/verifyRole  [API POST]
public class RoomsV1VerifyRoleRequest
{
    public object roomId;  // candidate
    public object role;  // candidate
    public object context;  // candidate
}

// api/rooms/v2/report  [API POST]
public class RoomsV2ReportRequest
{
    public FOCLJOBLLOL FJPNCGCNOLL;  // wrapper
    public long? OJALLCGMDPI;  // wrapper
    public object ReportCategory;  // candidate
    public object RoomId;  // candidate
    public object RoomKeyId;  // candidate
    public object Details;  // candidate
}

// api/royale/v2/matchcomplete  [Econ POST]
public class RoyaleV2MatchcompleteRequest
{
    public MatchCompleteStats IMAJGJIBGKD;  // wrapper
}

// api/screensharereports/v1/report  [API POST]
public class ScreensharereportsV1ReportRequest
{
    public object ReportedPlayerId;  // candidate
    public object RoomInstanceId;  // candidate
    public object ImageName;  // candidate
    public object RoomInstanceType;  // candidate
    public object RoomId;  // candidate
}

// api/storefronts/v1/PurchaseRoomKeyWithCurrency  [Econ POST]
public class StorefrontsV1PurchaseRoomKeyWithCurrencyRequest
{
    public Guid OOGOCABJNGJ;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [Econ POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid LGCHDBLIMKO;  // wrapper
    public object progressionEventId;  // candidate
    public object requestedPrice;  // candidate
    public object purchasableXpBoostId;  // candidate
    public object expectedXp;  // candidate
}

// api/storefronts/v1/buyPurchaseReminder  [Econ POST]
public class StorefrontsV1BuyPurchaseReminderRequest
{
    public object purchaseReminderId;  // candidate
    public object requestedPrice;  // candidate
}

// api/storefronts/v1/buyRoomKey  [Econ GET]
public class StorefrontsV1BuyRoomKeyRequest
{
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/objectives  [Econ POST]
public class StorefrontsV1ObjectivesRequest
{
    public List<PIMGBICBEPH> PHDIKPADPDD;  // wrapper
    public object roomId;  // candidate
    public object CompleteObjectives;  // candidate
    public object objectiveType;  // candidate
    public object completionPercentage;  // candidate
}

// api/storefronts/v1/trialInvention  [Econ POST]
public class StorefrontsV1TrialInventionRequest
{
    public long inventionId;  // wrapper
}

// api/storefronts/v2/buyInvention  [Econ GET]
public class StorefrontsV2BuyInventionRequest
{
    public object requestedPrice;  // candidate
    public object inventionId;  // candidate
}

// api/testcasemanagement/v1/testcase/  [API POST]
public class TestcasemanagementV1TestcaseRequest
{
    public LNBDBABNIDC LOMCGLGCKNI;  // wrapper
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public int? pid;  // wrapper
}

