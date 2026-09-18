// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 211 (plus referenced enums)

// --------------------------------------------------------------------------
// AFAALJHPGPD
// base   : KPNFGDCGHFL
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v3/giftdropstore/{giftdropstoreId}   [Service.Econ]
public class AFAALJHPGPD : KPNFGDCGHFL
{
    public List<IBALCCEGHLA> KHNHILDMGLL;    // 0x0x30
    public int <KOMPDACFAIO>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// AFKOIJANIGN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AFKOIJANIGN
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// AIIIAGADHHL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AIIIAGADHHL
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
// AIJOPCOANHN
//   (not directly referenced by a detected call)
public class AIJOPCOANHN
{
    public long <JMPBMOEHAMG>k__BackingField;    // 0x0x10
    public Guid <HLFDFDCPBEP>k__BackingField;    // 0x0x18
    public long <KOGFFABKFBM>k__BackingField;    // 0x0x28
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x30
    public string <AMKLBBGMPOH>k__BackingField;    // 0x0x38
    public int <GOIDPAKFEKG>k__BackingField;    // 0x0x40
    public Guid? <OEGJFEMAEAA>k__BackingField;    // 0x0x44
    public DateTime <INOEJCLIAAO>k__BackingField;    // 0x0x58
    public string <HHFOJDFIAEM>k__BackingField;    // 0x0x60
    public ANALGPFIMNK <HLJDKDPMJFH>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// AJEEOFJBJFH
//   (not directly referenced by a detected call)
public class AJEEOFJBJFH
{
    public Guid <AELELDHBDKJ>k__BackingField;    // 0x0x10
    public int <PBFEKMBBLCH>k__BackingField;    // 0x0x20
    public int <FNFKPMDOFFL>k__BackingField;    // 0x0x24
    public Guid <LDBGHIOIEKH>k__BackingField;    // 0x0x28
    public DateTime <GKOJAANCLIO>k__BackingField;    // 0x0x38
    public JENOILGMGBP <OLFHEDLAHIJ>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// AMCIAGAPPKP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AMCIAGAPPKP
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// AMGCNJEPFFE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AMGCNJEPFFE
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// ANALGPFIMNK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ANALGPFIMNK
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// ANBCNPNBHLE
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.Econ]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.Econ]
public class ANBCNPNBHLE
{
    public int <ILPOHNDIAEB>k__BackingField;    // 0x0x10
    public int <BNDLDDNPIAC>k__BackingField;    // 0x0x14
    public float <CBPEOBAFNBM>k__BackingField;    // 0x0x18
    public float <AELCFECJKHP>k__BackingField;    // 0x0x1C
    public bool <ONAFOMFJCBC>k__BackingField;    // 0x0x20
    public bool <FPEMCPFFDMO>k__BackingField;    // 0x0x21
    public bool <DPGJFIHIJBA>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// ANCNMCAJFGA
// base   : LKIJFAOCNJN
//   RESPONSE ?      api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.Econ]
public class ANCNMCAJFGA : LKIJFAOCNJN
{
    public ANALEGDIGIM? <PEDGJPBCPPM>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <CHHBMJIGIGD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AOININAHHOO
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.Econ]
//   RESPONSE GET    api/avatar/v4/items   [Service.Econ]
public class AOININAHHOO
{
    public AFKOIJANIGN <BNLFEFHNODI>k__BackingField;    // 0x0x10
    public string <GGKLEPJNBCB>k__BackingField;    // 0x0x18
    public string <FAJEJAADGMA>k__BackingField;    // 0x0x20
    public string <FGDCEOBKPLO>k__BackingField;    // 0x0x28
    public HDDKECDNDPE <BMLNOPHFFML>k__BackingField;    // 0x0x30
    public string <DGCBFBDAEBO>k__BackingField;    // 0x0x38
    public int <OFAFAKCADMC>k__BackingField;    // 0x0x40
    public bool <EGJMAIBJOCM>k__BackingField;    // 0x0x44
}

// --------------------------------------------------------------------------
// BAJHHHKLIHG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BAJHHHKLIHG
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// BGFEBHNEBAD
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class BGFEBHNEBAD
{
    public int? <AOHNFKOJKBC>k__BackingField;    // 0x0x10
    public string <BDJPHOIPLFC>k__BackingField;    // 0x0x18
    public string <LGNOOLFMFOK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BJDKFGKCGEJ
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.Econ]
public class BJDKFGKCGEJ
{
    public long <KOGFFABKFBM>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <BPAFCDFBFJG>k__BackingField;    // 0x0x18
    public HNOGKDDDMNK <NMHPALBILAH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BKFDLAKMOAE
//   (not directly referenced by a detected call)
public class BKFDLAKMOAE
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// BLOCPKJILEG
// base   : System.Enum
//   RESPONSE ?      api/roomkeys/   [Service.Econ]
//   RESPONSE DELETE api/roomkeys/v1/delete/{lFFCKIHAGPP}   [Service.Econ]
public enum BLOCPKJILEG
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
// BMFJMLBPDML
//   (not directly referenced by a detected call)
public class BMFJMLBPDML
{
    public NJGJMBFILMP <BLJALFOECBB>k__BackingField;    // 0x0x10
    public KEBCJCGEOII <IMKLANNPLPM>k__BackingField;    // 0x0x18
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
// CAHHFJPDDJK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CAHHFJPDDJK
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
// CFPAMIJCJKC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CFPAMIJCJKC
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
}

// --------------------------------------------------------------------------
// CJGCPDFJPEI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CJGCPDFJPEI
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
// DAIBEGMLFHD
//   (not directly referenced by a detected call)
public class DAIBEGMLFHD
{
    public int <MJNEMPKFHPB>k__BackingField;    // 0x0x10
    public DateTime? <FLPANOPEFJJ>k__BackingField;    // 0x0x18
    public DateTime? <NNCGGGDJAIL>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// DDAGKEBCOMB
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{mCHNJDGLEMA}   [Service.Econ]
public class DDAGKEBCOMB
{
    public IKJLPLPAMKB <HCAJHBJBKCD>k__BackingField;    // 0x0x10
    public JENOILGMGBP <OLFHEDLAHIJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DEBFDCLCPJD
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.Econ]
public class DEBFDCLCPJD
{
    public int <HFJMELDAGNB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DFCMCCLMJIH
//   (not directly referenced by a detected call)
public class DFCMCCLMJIH
{
    public long <GOIDPAKFEKG>k__BackingField;    // 0x0x10
    public Guid? <KALKNDMEOIM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DHJKMAPAGDA
//   (not directly referenced by a detected call)
public class DHJKMAPAGDA
{
    public int <CFDENLMIMCE>k__BackingField;    // 0x0x10
    public AMCIAGAPPKP <HLJDKDPMJFH>k__BackingField;    // 0x0x14
    public List<NDELCCLAAOH> <AAKHOGOKCCF>k__BackingField;    // 0x0x18
    public List<NDELCCLAAOH> <OJGPNGNCCHM>k__BackingField;    // 0x0x20
    public bool <GOGHAFDCLIA>k__BackingField;    // 0x0x28
    public DateTime? <HNAHAFBHBON>k__BackingField;    // 0x0x30
    public DateTime? <KPOPEKLGEGJ>k__BackingField;    // 0x0x40
    public DateTime? <OLHMGOMDGDG>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// DHNOAAFKKCN
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/checklist/v1/complete   [Service.Econ]
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE POST   api/progressionEvents/collect/{collectId}/False   [Service.API]
public class DHNOAAFKKCN
{
    public long? <NKAKNABLOBJ>k__BackingField;    // 0x0x10
    public int? <CFIHCJEJEAA>k__BackingField;    // 0x0x20
    public string <PMNNOLMBLCH>k__BackingField;    // 0x0x28
    public AFKOIJANIGN? <BNLFEFHNODI>k__BackingField;    // 0x0x30
    public string <EJLFGPKNDKL>k__BackingField;    // 0x0x38
    public string <APHCDNIPKCB>k__BackingField;    // 0x0x40
    public string <CINJBIHPEMO>k__BackingField;    // 0x0x48
    public IDJFOHCDAFP <NHDMKBMDJKJ>k__BackingField;    // 0x0x50
    public int <NODLKKICGEK>k__BackingField;    // 0x0x54
    public int <MGJICBCEJDM>k__BackingField;    // 0x0x58
    public IOAMOMDOIJK <NLDHKFHIGAD>k__BackingField;    // 0x0x5C
    public HDDKECDNDPE <BLDLMFGNCAJ>k__BackingField;    // 0x0x60
    public string <EBKPANOAAAB>k__BackingField;    // 0x0x68
    public CJGCPDFJPEI <IALJFCODOLD>k__BackingField;    // 0x0x70
    public AIIIAGADHHL <MNCPPOFPCKJ>k__BackingField;    // 0x0x74
    public DNBODDNEBID? <NHCGKMDEDOH>k__BackingField;    // 0x0x78
    public bool <KIIDCFCLDDD>k__BackingField;    // 0x0x80
    public bool <BBMOFPKCFLF>k__BackingField;    // 0x0x81
    public string <JHKHAHFDPNI>k__BackingField;    // 0x0x88
    public bool <KNKOFKHNONP>k__BackingField;    // 0x0x90
    public bool BBEDMHNBIJC;    // 0x0x91
}

// --------------------------------------------------------------------------
// DJCGFGIBOFL
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{eGOHECNBDPO}/{nIGFLEJLDLN}   [Service.Econ]
public class DJCGFGIBOFL
{
    public IDJFOHCDAFP <NHDMKBMDJKJ>k__BackingField;    // 0x0x10
    public FNODDMFBACF <HAJKMBODHOK>k__BackingField;    // 0x0x14
    public int <LEMLKDLEKNM>k__BackingField;    // 0x0x18
    public int <CPJEGADHGEG>k__BackingField;    // 0x0x1C
    public int <IPIHKLDIDAB>k__BackingField;    // 0x0x20
    public NGDHLOFJFBE <BJCPBAIOADC>k__BackingField;    // 0x0x24
    public bool <CAHAMCIBDDC>k__BackingField;    // 0x0x28
    public float <MLAHOFOOCJD>k__BackingField;    // 0x0x2C
    public int <NIDKLNFGEBC>k__BackingField;    // 0x0x30
    public bool <KDDLEEINJFH>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// DLOCMKEPOFP
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
public class DLOCMKEPOFP
{
    public List<string> <HNAPNPJAILD>k__BackingField;    // 0x0x10
    public List<string> <CFEBPHIKGOL>k__BackingField;    // 0x0x18
    public List<string> <NIFGPOBAIKA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DNBODDNEBID
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DNBODDNEBID
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
    PlayStationNonPurchasedP2P = 100,
    NonPlayStationNonPurchasedP2P = 101,
    NonPurchasedEarnedByP2P = 1000,
}

// --------------------------------------------------------------------------
// DOHIILJKDCJ
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.API]
public class DOHIILJKDCJ
{
    public int <LPLAJNLBMPG>k__BackingField;    // 0x0x10
    public int? <BOFNFPEGFCL>k__BackingField;    // 0x0x14
    public string <JINOOKNLGKN>k__BackingField;    // 0x0x20
    public string <MINFAFPLAGA>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// EIBAGOLDDEI
//   REQUEST  ?      api/roomcurrencies   [Service.Econ]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.Econ]
public class EIBAGOLDDEI
{
    public Guid <NBCOGLJCBMM>k__BackingField;    // 0x0x10
    public long <LCPBJCHOKKL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EJLBONIJKCO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EJLBONIJKCO
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// EOJHLNOIEJO
//   (not directly referenced by a detected call)
public class EOJHLNOIEJO
{
    public int <JCNFDICAIGJ>k__BackingField;    // 0x0x10
    public CFPAMIJCJKC <HPPFLHNLEKB>k__BackingField;    // 0x0x14
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
// FACGOKDAEIN
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{bNIMHBPGHDC}   [Service.API]
public class FACGOKDAEIN
{
    public List<NJGJMBFILMP> <CPLEMDNONKO>k__BackingField;    // 0x0x10
    public List<BMFJMLBPDML> <FHEHOADKDPH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FBKLFBIFPEF
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class FBKLFBIFPEF
{
    public List<MHKCAJBMBDC> <GBEFOLCAIFM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// FDOIDOIOCAH
//   (not directly referenced by a detected call)
public class FDOIDOIOCAH
{
    public long <FLJOIBPAGBP>k__BackingField;    // 0x0x10
    public string <PMNNOLMBLCH>k__BackingField;    // 0x0x18
    public string <BPEHKGCGEPB>k__BackingField;    // 0x0x20
    public AFKOIJANIGN? <BNLFEFHNODI>k__BackingField;    // 0x0x28
    public string <APHCDNIPKCB>k__BackingField;    // 0x0x30
    public string <CINJBIHPEMO>k__BackingField;    // 0x0x38
    public LMINBHFIAEA <GADFNKBKAJB>k__BackingField;    // 0x0x40
    public int <MGJICBCEJDM>k__BackingField;    // 0x0x44
    public int <CMGMCEGMMOA>k__BackingField;    // 0x0x48
    public IOAMOMDOIJK? <NLDHKFHIGAD>k__BackingField;    // 0x0x4C
    public HDDKECDNDPE? <BLDLMFGNCAJ>k__BackingField;    // 0x0x54
}

// --------------------------------------------------------------------------
// FEJDGLOLJGN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FEJDGLOLJGN
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// FFFIOJDAEDI
//   (not directly referenced by a detected call)
public class FFFIOJDAEDI
{
    public int <NMALHELEGOL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// FFPEEHGKAEJ
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
public class FFPEEHGKAEJ
{
    public bool <CFNNNCFJILF>k__BackingField;    // 0x0x10
    public string <PHEFDBEKENN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FHMMIMHPEMH
//   RESPONSE GET    api/config/v1/backtrace   [Service.API]
public class FHMMIMHPEMH
{
    public int <CNNIPHKLNLJ>k__BackingField;    // 0x0x10
    public int <NPMLBIPPBJL>k__BackingField;    // 0x0x14
    public float <FOCAPCNIJPJ>k__BackingField;    // 0x0x18
    public int <INIENCBCEGD>k__BackingField;    // 0x0x1C
    public int <NAKOLFBKNHO>k__BackingField;    // 0x0x20
    public int <FKOJOCCEFFJ>k__BackingField;    // 0x0x24
    public int <LGOIHJINIPH>k__BackingField;    // 0x0x28
    public string <DLFDMAOKBHL>k__BackingField;    // 0x0x30
    public string <PBMPIMPKIII>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// FLJDBDLOOFO
// base   : KPNFGDCGHFL
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/season/{lHNJFKBDEIM}   [Service.Econ]
public class FLJDBDLOOFO : KPNFGDCGHFL
{
    public int <LHNCLMBCIEP>k__BackingField;    // 0x0x30
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x38
    public DateTime <FGJIHPHELDF>k__BackingField;    // 0x0x40
    public DateTime <POLNEBICHIL>k__BackingField;    // 0x0x48
    public IDJFOHCDAFP <NHDMKBMDJKJ>k__BackingField;    // 0x0x50
    public DHJKMAPAGDA <DGCPJCMGMPO>k__BackingField;    // 0x0x58
    public List<JEEAMICHABJ> <BNFCCBMEEKN>k__BackingField;    // 0x0x60
    public LCOGKFPCECA <LJIAKOPFMKM>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// FNODDMFBACF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FNODDMFBACF
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
// FPADPBNJHMG
//   (not directly referenced by a detected call)
public class FPADPBNJHMG
{
    public ObscuredLong <MPEGEGDCLBD>k__BackingField;    // 0x0x10
    public string <HLFDFDCPBEP>k__BackingField;    // 0x0x38
    public ObscuredInt <JPGBDPKOPAI>k__BackingField;    // 0x0x40
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x58
    public string <AMKLBBGMPOH>k__BackingField;    // 0x0x60
    public string <HHFOJDFIAEM>k__BackingField;    // 0x0x68
    public int <HCCJNCPHLIG>k__BackingField;    // 0x0x70
    public EJLBONIJKCO <DCBFIFPPELA>k__BackingField;    // 0x0x74
    public DateTime <GKOJAANCLIO>k__BackingField;    // 0x0x78
    public DateTime <INOEJCLIAAO>k__BackingField;    // 0x0x80
    public DateTime? <OKMPPKAFBAF>k__BackingField;    // 0x0x88
    public long? <PKNFABPGMPD>k__BackingField;    // 0x0x98
    public int <NPOGCENOIEF>k__BackingField;    // 0x0xA8
    public int <PMDCKDLIJDO>k__BackingField;    // 0x0xAC
    public int <KEJBDBJABDP>k__BackingField;    // 0x0xB0
    public CAHHFJPDDJK <LOHKEHHJGPJ>k__BackingField;    // 0x0xB4
    public CAHHFJPDDJK <KNGFIDAHICD>k__BackingField;    // 0x0xB8
    public ObscuredBool <AACJIGELGLD>k__BackingField;    // 0x0xBC
    public ObscuredBool <BFHEJMANFEK>k__BackingField;    // 0x0xC8
    public ObscuredBool <IGDJDFBJLHJ>k__BackingField;    // 0x0xD4
    public int? <GOIDPAKFEKG>k__BackingField;    // 0x0xE0
    public bool <HOCLAONIBMA>k__BackingField;    // 0x0xE8
}

// --------------------------------------------------------------------------
// GHEKBCPCEOP
//   (not directly referenced by a detected call)
public class GHEKBCPCEOP
{
    public int <HEBKDDHOJFI>k__BackingField;    // 0x0x10
    public DateTime <INOEJCLIAAO>k__BackingField;    // 0x0x18
    public DateTime? <IDNHJLOEABG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GKKELEDHAOH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GKKELEDHAOH
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
// GOJNMCJMNIF
// base   : NJGJMBFILMP
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class GOJNMCJMNIF : NJGJMBFILMP
{
    public List<MHKCAJBMBDC> <GBEFOLCAIFM>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// GPKDJBILFAJ
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs   [Service.API]
public class GPKDJBILFAJ
{
    public List<string> <KGOEMMDFMAM>k__BackingField;    // 0x0x10
    public byte <MDKLABAGCIO>k__BackingField;    // 0x0x18
    public int <HMKBCOOEGJJ>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// HCNHPDLMOOJ
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.API]
public class HCNHPDLMOOJ
{
    public List<NJGJMBFILMP> <NOILDLIFMDE>k__BackingField;    // 0x0x10
    public string <DFOOKLIOJPN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HDDKECDNDPE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HDDKECDNDPE
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// HILEMOEFBEC
//   (not directly referenced by a detected call)
public class HILEMOEFBEC
{
    public long <PELOGOEHCFO>k__BackingField;    // 0x0x10
    public Guid <OPNOKFNOOHE>k__BackingField;    // 0x0x18
    public Guid <JDEOGDLEIFB>k__BackingField;    // 0x0x28
    public DateTime <INOEJCLIAAO>k__BackingField;    // 0x0x38
    public string <AKIHNDKKBIO>k__BackingField;    // 0x0x40
    public string <DBNAGCAJAKH>k__BackingField;    // 0x0x48
    public string <AGPDAHDPBOJ>k__BackingField;    // 0x0x50
    public string <NMFLNJCPPFD>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// HJGJDCGDBHK
//   (not directly referenced by a detected call)
public class HJGJDCGDBHK
{
    public long <MPEGEGDCLBD>k__BackingField;    // 0x0x10
    public string <HLFDFDCPBEP>k__BackingField;    // 0x0x18
    public int <HAFLCECBEAI>k__BackingField;    // 0x0x20
    public int <BBFALNOMKEB>k__BackingField;    // 0x0x24
    public int <HCBKOCJNCNP>k__BackingField;    // 0x0x28
    public int <DEPKEAEDELB>k__BackingField;    // 0x0x2C
    public int <NOIGHGMMFCN>k__BackingField;    // 0x0x30
    public string <KMKMOCPDDCK>k__BackingField;    // 0x0x38
    public string <KGAHJKBHJJI>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// HJLMIBEJHID
//   RESPONSE GET    api/config/v1/azurespeech   [Service.API]
public class HJLMIBEJHID
{
    public bool <CDEFOHDPBJL>k__BackingField;    // 0x0x10
    public string <PANBGKNDFBK>k__BackingField;    // 0x0x18
    public string <FIMLBGMOBKK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HMGKBFNLLKI
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
public class HMGKBFNLLKI
{
    public HCCFEKBBKCC <IALDJJJDFKL>k__BackingField;    // 0x0x10
    public string <AAJELEBPFEJ>k__BackingField;    // 0x0x18
    public int? <OCCKNGEEANC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HNCMJPNGNIG
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.API]
public class HNCMJPNGNIG
{
    public string <NKAKNABLOBJ>k__BackingField;    // 0x0x10
    public string <PANBGKNDFBK>k__BackingField;    // 0x0x18
    public string <AIDPBKPFNLC>k__BackingField;    // 0x0x20
    public string <AMKLBBGMPOH>k__BackingField;    // 0x0x28
    public string <BDJPHOIPLFC>k__BackingField;    // 0x0x30
    public FEJDGLOLJGN <HCAJHBJBKCD>k__BackingField;    // 0x0x38
    public List<string> <LAMBGKAJLPK>k__BackingField;    // 0x0x40
    public List<string> <GBEFOLCAIFM>k__BackingField;    // 0x0x48
    public string <KIFJAOGDOCM>k__BackingField;    // 0x0x50
    public List<ICFCHNPHAED> <LNFGDNAOIIA>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// HNOGKDDDMNK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HNOGKDDDMNK
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// HPBLGHHOEBG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HPBLGHHOEBG
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// HPLGDJIOCJO
//   (not directly referenced by a detected call)
public class HPLGDJIOCJO
{
    public bool <PFFJCIJCOAM>k__BackingField;    // 0x0x10
    public LOJJHHLEGKF <GNCOJKHKEIL>k__BackingField;    // 0x0x18
    public float <HNOHCHKNNOO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// IBALCCEGHLA
// base   : DHJKMAPAGDA
//   (not directly referenced by a detected call)
public class IBALCCEGHLA : DHJKMAPAGDA
{
    public LOJJHHLEGKF <GNCOJKHKEIL>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// ICFCHNPHAED
//   (not directly referenced by a detected call)
public class ICFCHNPHAED
{
    public DateTime <INOEJCLIAAO>k__BackingField;    // 0x0x10
    public string <NIFJCLHAMCC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IDJFOHCDAFP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IDJFOHCDAFP
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
// IGIALMKMDBJ
// base   : IDBEHODKHKG`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.API]
public class IGIALMKMDBJ
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// IKJLPLPAMKB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IKJLPLPAMKB
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
// IKPOMCNEBBJ
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.Auth]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.Econ]
public class IKPOMCNEBBJ
{
    public int <BNDLDDNPIAC>k__BackingField;    // 0x0x10
    public bool <ONAFOMFJCBC>k__BackingField;    // 0x0x14
    public DateTime <JFIIMBAMGAA>k__BackingField;    // 0x0x18
    public bool <DNAGNNMGNPI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// IOAMOMDOIJK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IOAMOMDOIJK
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
// IOEIMGIODNF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IOEIMGIODNF
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
// JAKKOGJHMDN
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.Econ]
public class JAKKOGJHMDN
{
    public int <PINHDOCFEJI>k__BackingField;    // 0x0x10
    public string <FEJHADBKGDE>k__BackingField;    // 0x0x18
    public List<PLLNIDDHIKI> <EMPGKIGNBCL>k__BackingField;    // 0x0x20
    public FDOIDOIOCAH <IPBNPODFAKP>k__BackingField;    // 0x0x28
    public string <FBCDBHDKJHJ>k__BackingField;    // 0x0x30
    public DateTime <FGJIHPHELDF>k__BackingField;    // 0x0x38
    public DateTime <POLNEBICHIL>k__BackingField;    // 0x0x40
    public DateTime <EJCIJGLHGNP>k__BackingField;    // 0x0x48
    public bool? <ONMGPMIPNAN>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// JDBEEEJGBPD
//   (not directly referenced by a detected call)
public class JDBEEEJGBPD
{
    public float <BAKHGBFHGMO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JEEAMICHABJ
// base   : DHJKMAPAGDA
//   (not directly referenced by a detected call)
public class JEEAMICHABJ : DHJKMAPAGDA
{
    public int <PHKAKBJHMLB>k__BackingField;    // 0x0x60
    public List<HPLGDJIOCJO> <INFPGOFENLM>k__BackingField;    // 0x0x68
    public List<HPLGDJIOCJO> <IGAKBEFKKNG>k__BackingField;    // 0x0x70
    public List<HPLGDJIOCJO> <PFCMOCNEKOA>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// JENOILGMGBP
//   (not directly referenced by a detected call)
public class JENOILGMGBP
{
    public Guid <AELELDHBDKJ>k__BackingField;    // 0x0x10
    public long <KOGFFABKFBM>k__BackingField;    // 0x0x20
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x28
    public string <AMKLBBGMPOH>k__BackingField;    // 0x0x30
    public string <HHFOJDFIAEM>k__BackingField;    // 0x0x38
    public long <GOIDPAKFEKG>k__BackingField;    // 0x0x40
    public Guid? <OEGJFEMAEAA>k__BackingField;    // 0x0x48
    public DateTime <GKOJAANCLIO>k__BackingField;    // 0x0x60
    public int <FAEFNLJLJPH>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// JFBBNGGKPJJ
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems   [Service.API]
public class JFBBNGGKPJJ
{
    public byte <MDKLABAGCIO>k__BackingField;    // 0x0x10
    public int <HMKBCOOEGJJ>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// JGEOMHFBNHO
//   RESPONSE POST   api/inventions/v1/cheer   [Service.API]
//   RESPONSE GET    api/inventions/v1/delete   [Service.API]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.API]
//   RESPONSE GET    api/inventions/v1/update   [Service.API]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.API]
//   RESPONSE GET    api/inventions/v3/publish   [Service.API]
//   RESPONSE POST   api/inventions/v4/addversion   [Service.API]
//   RESPONSE POST   api/inventions/v6/save   [Service.API]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.Econ]
public class JGEOMHFBNHO
{
    public IOEIMGIODNF <HCAJHBJBKCD>k__BackingField;    // 0x0x10
    public FPADPBNJHMG <FHMPMNNDFJF>k__BackingField;    // 0x0x18
    public HJGJDCGDBHK <ACJKHPOOGGP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JHGPEOMJEIM
//   RESPONSE GET    api/config/v1/amplitude   [Service.API]
public class JHGPEOMJEIM
{
    public string <IKCGLCLOKAJ>k__BackingField;    // 0x0x10
    public string <GEEAAOGBIHE>k__BackingField;    // 0x0x18
    public bool <LFENIFLOACL>k__BackingField;    // 0x0x20
    public string <DMPCPCIIELD>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// JIOMCFICGJM
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.Econ]
public class JIOMCFICGJM
{
    public long <JMPBMOEHAMG>k__BackingField;    // 0x0x10
    public int <PBFEKMBBLCH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JJAKKJLIHMH
// base   : LKIJFAOCNJN
//   RESPONSE ?      api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.Econ]
public class JJAKKJLIHMH : LKIJFAOCNJN
{
    public LNBIAJJMPIN? <PEDGJPBCPPM>k__BackingField;    // 0x0x18
    public PEMHPGIHDKN <JMBACGGALIK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JLIJPHDFNFC
//   (not directly referenced by a detected call)
public class JLIJPHDFNFC
{
    public int <BPBHFAGAGFF>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JPIIKBOADFO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JPIIKBOADFO
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// KEBCJCGEOII
//   (not directly referenced by a detected call)
public class KEBCJCGEOII
{
    public long <JJJDDHJJOIM>k__BackingField;    // 0x0x10
    public long <NFEDNNNJEBH>k__BackingField;    // 0x0x18
    public int <EGDDMONBNLF>k__BackingField;    // 0x0x20
    public DateTime <INOEJCLIAAO>k__BackingField;    // 0x0x28
    public AMGCNJEPFFE <HLJDKDPMJFH>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// KHFEFFIDHFM
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.Econ]
public class KHFEFFIDHFM
{
    public List<int> <HKLINPFOBOI>k__BackingField;    // 0x0x10
    public string <DFOOKLIOJPN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KJEMKPCKNMO
//   RESPONSE ?      api/roomkeys/v1/   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Econ]
public class KJEMKPCKNMO
{
    public BLOCPKJILEG <HCAJHBJBKCD>k__BackingField;    // 0x0x10
    public AIJOPCOANHN <EBILOLCKMHD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LCOGKFPCECA
//   (not directly referenced by a detected call)
public class LCOGKFPCECA
{
    public bool <CMOCPELANJL>k__BackingField;    // 0x0x10
    public AIIIAGADHHL <CGIMFHFHGHP>k__BackingField;    // 0x0x14
    public int <MJIFFLOLGLG>k__BackingField;    // 0x0x18
    public DateTime <GKOJAANCLIO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LGJMOHEFAOM
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class LGJMOHEFAOM
{
    public Dictionary<Guid, PGHCPDJEBHB> <BCMJBGPKLHM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LGMLBBLHKOD
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class LGMLBBLHKOD
{
    public Dictionary<Guid, OMDIOGFCHJI> <JHBDGGLPFPH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LHCEDGBMFDP
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
public class LHCEDGBMFDP
{
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x10
    public string <AMKLBBGMPOH>k__BackingField;    // 0x0x18
    public int? <GOIDPAKFEKG>k__BackingField;    // 0x0x20
    public EJLBONIJKCO? <DCBFIFPPELA>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// LKBDKDNHDMA
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs   [Service.API]
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems   [Service.API]
public class LKBDKDNHDMA
{
    public Dictionary<string, HILEMOEFBEC> <FMJFDALJMKC>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LMINBHFIAEA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LMINBHFIAEA
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
    PopUpShop_6 = 1705,
    PopUpShop_7 = 1706,
    PopUpShop_8 = 1707,
    PopUpShop_9 = 1708,
    PopUpShop_10 = 1709,
    CustomAvatarItems = 1800,
    ProgressionEventPurchasableXpBoosts = 1900,
    PopUpShop_ProgressionEvent_1 = 2000,
    PopUpShop_ProgressionEvent_2 = 2001,
    PopUpShop_ProgressionEvent_3 = 2002,
    PopUpShop_ProgressionEvent_4 = 2003,
    PopUpShop_ProgressionEvent_5 = 2004,
}

// --------------------------------------------------------------------------
// LNBIAJJMPIN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LNBIAJJMPIN
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// LOJJHHLEGKF
//   (not directly referenced by a detected call)
public class LOJJHHLEGKF
{
    public int <FLJOIBPAGBP>k__BackingField;    // 0x0x10
    public string <FAJEJAADGMA>k__BackingField;    // 0x0x18
    public string <FGDCEOBKPLO>k__BackingField;    // 0x0x20
    public string <DGCBFBDAEBO>k__BackingField;    // 0x0x28
    public string <PMNNOLMBLCH>k__BackingField;    // 0x0x30
    public string <EJLFGPKNDKL>k__BackingField;    // 0x0x38
    public AFKOIJANIGN? <BNLFEFHNODI>k__BackingField;    // 0x0x40
    public string <APHCDNIPKCB>k__BackingField;    // 0x0x48
    public string <CINJBIHPEMO>k__BackingField;    // 0x0x50
    public bool <ICDCHIIAGJP>k__BackingField;    // 0x0x58
    public bool <KKEGJMDEEOM>k__BackingField;    // 0x0x59
    public bool <MKFGFKGIBBO>k__BackingField;    // 0x0x5A
    public HDDKECDNDPE <BMLNOPHFFML>k__BackingField;    // 0x0x5C
    public int <OFAFAKCADMC>k__BackingField;    // 0x0x60
    public IDJFOHCDAFP <NHDMKBMDJKJ>k__BackingField;    // 0x0x64
    public int <NODLKKICGEK>k__BackingField;    // 0x0x68
    public GKKELEDHAOH <KDANPIPOAAE>k__BackingField;    // 0x0x6C
    public IOAMOMDOIJK <OFDIBKHEOOK>k__BackingField;    // 0x0x70
    public int? <HMOFPHGJCOJ>k__BackingField;    // 0x0x74
    public string <LODLFHEBCPO>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// MANFPOBIMFJ
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class MANFPOBIMFJ
{
    public NMGLLJJGCME <HPPFLHNLEKB>k__BackingField;    // 0x0x10
    public List<string> <GBEFOLCAIFM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MBFCMJKALID
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.API]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
public class MBFCMJKALID
{
    public int <ADAOOKFONFJ>k__BackingField;    // 0x0x10
    public FOHGNJKEJIK <HLJDKDPMJFH>k__BackingField;    // 0x0x14
    public KEFJOGDGCMJ <GFPMOJKMGPK>k__BackingField;    // 0x0x18
    public KEFJOGDGCMJ <CFKHGMIFMEJ>k__BackingField;    // 0x0x1C
    public KEFJOGDGCMJ <PAFGBKKAGEH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MBJHCKOBCNK
// base   : IDBEHODKHKG`1<OJFCJJBFNLD>
//   RESPONSE ?      api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{jHHGGCOIGDA}   [Service.API]
public class MBJHCKOBCNK
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// MEJJKBBGBPJ
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
public class MEJJKBBGBPJ
{
    public Guid? <AELELDHBDKJ>k__BackingField;    // 0x0x10
    public long? <KOGFFABKFBM>k__BackingField;    // 0x0x28
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x38
    public string <AMKLBBGMPOH>k__BackingField;    // 0x0x40
    public string <HHFOJDFIAEM>k__BackingField;    // 0x0x48
    public DFCMCCLMJIH <GEEHEPCFKEE>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// MHKCAJBMBDC
//   (not directly referenced by a detected call)
public class MHKCAJBMBDC
{
    public string <JENMAJPAKAJ>k__BackingField;    // 0x0x10
    public JPIIKBOADFO <HLJDKDPMJFH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MMNOLAFEMEN
//   (not directly referenced by a detected call)
public class MMNOLAFEMEN
{
    public NIFAHACLAKF GCGONMJOJPI;    // 0x0x10
    public int DIAAAHLCLGJ;    // 0x0x14
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
// NDELCCLAAOH
//   (not directly referenced by a detected call)
public class NDELCCLAAOH
{
    public IDJFOHCDAFP <NHDMKBMDJKJ>k__BackingField;    // 0x0x10
    public int <GOIDPAKFEKG>k__BackingField;    // 0x0x14
    public DAIBEGMLFHD <NEPLEJMKBIH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NGDHLOFJFBE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NGDHLOFJFBE
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// NIFAHACLAKF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NIFAHACLAKF
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
// NJGJMBFILMP
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class NJGJMBFILMP
{
    public long <NFEDNNNJEBH>k__BackingField;    // 0x0x10
    public int <JPGBDPKOPAI>k__BackingField;    // 0x0x18
    public long <KOGFFABKFBM>k__BackingField;    // 0x0x20
    public long? <OHCDPOHMGBL>k__BackingField;    // 0x0x28
    public long? <FMMPGCEILCI>k__BackingField;    // 0x0x38
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x48
    public string <AMKLBBGMPOH>k__BackingField;    // 0x0x50
    public string <HHFOJDFIAEM>k__BackingField;    // 0x0x58
    public DateTime <HAENIHLLMOD>k__BackingField;    // 0x0x60
    public DateTime <HPMDINGOMJK>k__BackingField;    // 0x0x68
    public int <IANHPKJCBCJ>k__BackingField;    // 0x0x70
    public BAJHHHKLIHG <DCBFIFPPELA>k__BackingField;    // 0x0x74
    public bool <EKOLHNBCOME>k__BackingField;    // 0x0x78
    public bool <NNGEDLHGCKP>k__BackingField;    // 0x0x79
    public HPBLGHHOEBG <IFHIIGOIGIH>k__BackingField;    // 0x0x7C
    public HPBLGHHOEBG <NMOBGNIPJGL>k__BackingField;    // 0x0x80
    public long? <LMBHEOCBILJ>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// NMGLLJJGCME
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NMGLLJJGCME
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
}

// --------------------------------------------------------------------------
// NNOGKMHCIPM
//   (not directly referenced by a detected call)
public class NNOGKMHCIPM
{
    public int <CGKHJHLAPJP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OHLEDNCICIP
//   RESPONSE GET    api/config/v2   [Service.API]
public class OHLEDNCICIP
{
    public Dictionary<int, int> <ABMOEAMGCCN>k__BackingField;    // 0x0x10
    public List<CELJKFPIEJG> <OFDBDDDKOOH>k__BackingField;    // 0x0x18
    public MMNOLAFEMEN[][] <BOPCGAIENAK>k__BackingField;    // 0x0x20
    public NNOGKMHCIPM <DALDABOGOPM>k__BackingField;    // 0x0x28
    public OOFGBLMALKO <MEKKIFPMBLE>k__BackingField;    // 0x0x30
    public JLIJPHDFNFC <LHOOOFOKEKL>k__BackingField;    // 0x0x38
    public FFFIOJDAEDI <AJANPNLIFHI>k__BackingField;    // 0x0x40
    public JDBEEEJGBPD <KOKIHNFFNBA>k__BackingField;    // 0x0x48
    public string <JHKKIEFNCBP>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// OLBBIIOPHIA
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.API]
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{bNLMOEMNEJG}   [Service.API]
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
public class OLBBIIOPHIA
{
    public GOJNMCJMNIF <BLJALFOECBB>k__BackingField;    // 0x0x10
    public CFPAMIJCJKC <HPPFLHNLEKB>k__BackingField;    // 0x0x18
    public MANFPOBIMFJ <APLLADDABPF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OMDIOGFCHJI
//   (not directly referenced by a detected call)
public class OMDIOGFCHJI
{
    public int <CLPPDCEPCDB>k__BackingField;    // 0x0x10
    public PJGAEOMODEN <EELEJPGNLJL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OOFGBLMALKO
//   (not directly referenced by a detected call)
public class OOFGBLMALKO
{
    public float <NDEPBLKPJIF>k__BackingField;    // 0x0x10
    public float <GCDKKOADBOG>k__BackingField;    // 0x0x14
    public float <NECGDLPKIKP>k__BackingField;    // 0x0x18
    public float <CJIJCNBBLCE>k__BackingField;    // 0x0x1C
    public float <DLGPMGJOGPF>k__BackingField;    // 0x0x20
    public float <AOIEDLIGMLB>k__BackingField;    // 0x0x24
    public float <ALBNCBCEOIB>k__BackingField;    // 0x0x28
    public float <DIABOELIPOJ>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// PBFCELKANEO
//   RESPONSE GET    api/testcasemanagement/   [Service.API]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{lJHGKCLAIHG}   [Service.API]
public class PBFCELKANEO
{
    public uint <NKAKNABLOBJ>k__BackingField;    // 0x0x10
    public uint? <FJAKIJIJGLM>k__BackingField;    // 0x0x14
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x20
    public string <AMKLBBGMPOH>k__BackingField;    // 0x0x28
    public DateTime <JINCKOFNCBG>k__BackingField;    // 0x0x30
    public DateTime? <OKFMMKCACHA>k__BackingField;    // 0x0x38
    public bool <DNPNPCOMPGJ>k__BackingField;    // 0x0x48
    public List<HNCMJPNGNIG> <EKIBFACNIKN>k__BackingField;    // 0x0x50
    public List<string> <GBEFOLCAIFM>k__BackingField;    // 0x0x58
    public int <HGLPDMKAMEJ>k__BackingField;    // 0x0x60
    public int <DDPFCKGKMMB>k__BackingField;    // 0x0x64
    public int <EDFMPJMJIED>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// PDOFEJMCHBL
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Econ]
public class PDOFEJMCHBL
{
    public Guid <GHIFMKPIMIJ>k__BackingField;    // 0x0x10
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x20
    public string <HHFOJDFIAEM>k__BackingField;    // 0x0x28
    public DateTime <FGJIHPHELDF>k__BackingField;    // 0x0x30
    public DateTime? <IENFPIGKDIN>k__BackingField;    // 0x0x38
    public List<PNEONMPGAAL> <OJOPBDILNAJ>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// PEMHPGIHDKN
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.Econ]
public class PEMHPGIHDKN
{
    public int <PBFEKMBBLCH>k__BackingField;    // 0x0x10
    public Guid <KALKNDMEOIM>k__BackingField;    // 0x0x14
    public long <LLHBPGMNGDL>k__BackingField;    // 0x0x28
    public DateTime <GKOJAANCLIO>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// PEMPFJLGPPB
//   RESPONSE POST   api/consumables/v1/transfer   [Service.Econ]
//   RESPONSE ?      api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.API]
//   RESPONSE PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.API]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.Econ]
//   RESPONSE ?      api/gamerewards/v1/request   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.Econ]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.Econ]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.Econ]
//   RESPONSE POST   api/keepsakes   [Service.API]
//   RESPONSE DELETE api/keepsakes/{kNBGMNMIJEJ}   [Service.API]
//   RESPONSE POST   api/playerwarnings   [Service.API]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.Econ]
public class PEMPFJLGPPB
{
    public bool <CFNNNCFJILF>k__BackingField;    // 0x0x10
    public string <IBCADBPMIFO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PGHCPDJEBHB
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
public class PGHCPDJEBHB
{
    public IKJLPLPAMKB <HCAJHBJBKCD>k__BackingField;    // 0x0x10
    public AJEEOFJBJFH <INBDGEGIGBF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PIFOOLPOBBG
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class PIFOOLPOBBG
{
    public CFPAMIJCJKC <HPPFLHNLEKB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// PIMCPALPANK
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class PIMCPALPANK
{
    public HBFCHDJCDFD <IALDJJJDFKL>k__BackingField;    // 0x0x10
    public int <HFJMELDAGNB>k__BackingField;    // 0x0x14
    public long <JGHLBNPJGGP>k__BackingField;    // 0x0x18
    public bool <NFADCBOGJHL>k__BackingField;    // 0x0x20
    public string <PHEFDBEKENN>k__BackingField;    // 0x0x28
    public int? <NONFNDKJFMO>k__BackingField;    // 0x0x30
    public bool <KCGKPPHPBEL>k__BackingField;    // 0x0x38
    public bool <HCDHDLCDBGK>k__BackingField;    // 0x0x39
    public bool <BAJFLJNPPDB>k__BackingField;    // 0x0x3A
    public bool <FDIKIEIGJEC>k__BackingField;    // 0x0x3B
    public string <NIGIAJNBHPM>k__BackingField;    // 0x0x40
    public DateTime? <CJDNHLCGFEE>k__BackingField;    // 0x0x48
    public float <OENOAFHONBC>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// PJGAEOMODEN
//   (not directly referenced by a detected call)
public class PJGAEOMODEN
{
    public Guid? <IDKMNIPOHLJ>k__BackingField;    // 0x0x10
    public Guid <LGAEFOMHFFE>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// PLLNIDDHIKI
//   (not directly referenced by a detected call)
public class PLLNIDDHIKI
{
    public int <MLFJMMEJHGE>k__BackingField;    // 0x0x10
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x18
    public string <BDOCLHFOEEA>k__BackingField;    // 0x0x20
    public string <AMKLBBGMPOH>k__BackingField;    // 0x0x28
    public string <FGDCEOBKPLO>k__BackingField;    // 0x0x30
    public bool <OCGAOPLNDIL>k__BackingField;    // 0x0x38
    public int <KIKPLMLHLHA>k__BackingField;    // 0x0x3C
    public BKFDLAKMOAE <GBEMHKBLKOM>k__BackingField;    // 0x0x40
    public HOOPJGJFDMN MMHNBBICOME;    // 0x0x48
    public HOOPJGJFDMN IGJFMIFABMG;    // 0x0x50
    public HOOPJGJFDMN FLGINFGFCOF;    // 0x0x58
    public AJIOLOLDJIC AOFDOAOEDCL;    // 0x0x60
}

// --------------------------------------------------------------------------
// PMHPNPEPKJL
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class PMHPNPEPKJL
{
    public List<EOJHLNOIEJO> <IEOMHDMJPHP>k__BackingField;    // 0x0x10
    public CFPAMIJCJKC <HPPFLHNLEKB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PNEONMPGAAL
//   (not directly referenced by a detected call)
public class PNEONMPGAAL
{
    public Guid <PPKPKAJFIDC>k__BackingField;    // 0x0x10
    public Guid <BCKJLLDPCIF>k__BackingField;    // 0x0x20
    public DateTime <FGJIHPHELDF>k__BackingField;    // 0x0x30
    public List<LOJJHHLEGKF> <CFEAIPEBBGI>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// POMNILBNMKP
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.Econ]
public class POMNILBNMKP
{
    public List<GHEKBCPCEOP> <DJNLGBAJNFK>k__BackingField;    // 0x0x10
    public string <DFOOKLIOJPN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.API]
public class AddKeepsakeInstanceRequest
{
    public long <KOGFFABKFBM>k__BackingField;    // 0x0x10
    public long? <OHCDPOHMGBL>k__BackingField;    // 0x0x18
    public NJFKBBPNNAP <LDKIGAJJBGE>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddVersionInventionRequestDTO
//   REQUEST  POST   api/inventions/v4/addversion   [Service.API]
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
    public GMDIMHOFANO <HPPFLHNLEKB>k__BackingField;    // 0x0x10
    public string <FMGEHBOAKPK>k__BackingField;    // 0x0x18
    public string <HKHHDINKLIA>k__BackingField;    // 0x0x20
    public string <KAEGBNAEAFF>k__BackingField;    // 0x0x28
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
    public long <NFEDNNNJEBH>k__BackingField;    // 0x0x10
    public long? <AJPJNGEFJOI>k__BackingField;    // 0x0x18
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
    public PFJHFNCMFEJ FilterType;    // 0x0x20
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
    public NJFKBBPNNAP <NCMFJHKLPOF>k__BackingField;    // 0x0x10
    public string <IMNMAJOHBHF>k__BackingField;    // 0x0x18
    public int <MPKGJMFIMFH>k__BackingField;    // 0x0x20
    public int <CMBPPFDMOFI>k__BackingField;    // 0x0x24
    public string <BANFJHJBDMB>k__BackingField;    // 0x0x28
    public string <CHNFIPCKKOB>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <PBFEKMBBLCH>k__BackingField;    // 0x0x10
    public Guid <AFAAEHCCHIO>k__BackingField;    // 0x0x14
    public DateTime <DKOJNMBJFHB>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.API]
public class KeepsakeGlobalConfigDTO
{
    public bool <OINGDBNABCF>k__BackingField;    // 0x0x10
    public int <AIBCIMGCMIB>k__BackingField;    // 0x0x14
    public bool <FFMLENLJILN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <AFAAEHCCHIO>k__BackingField;    // 0x0x10
    public NJFKBBPNNAP <GLHGAJLJFHC>k__BackingField;    // 0x0x20
    public int <ALDNFCFCBII>k__BackingField;    // 0x0x24
    public long <KOGFFABKFBM>k__BackingField;    // 0x0x28
    public long? <OHCDPOHMGBL>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE POST   api/keepsakes   [Service.API]
//   RESPONSE GET    api/keepsakes/events/{eNLIPOMDFFC}   [Service.API]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <LPNPKNNJDOM>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <NCOPJAKDKLP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <KMDEOMFKPII>k__BackingField;    // 0x0x10
    public long <KOGFFABKFBM>k__BackingField;    // 0x0x18
    public long <ILGDFCMPDHB>k__BackingField;    // 0x0x20
    public HJGPLEDMFGJ <HLJDKDPMJFH>k__BackingField;    // 0x0x28
    public int <LEFIDMCPCAG>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <KOGFFABKFBM>k__BackingField;    // 0x0x10
    public List<Guid> <KPNIOKBJCFM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <LPNPKNNJDOM>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <NCOPJAKDKLP>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <HLBFDIGGLMN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <ILGDFCMPDHB>k__BackingField;    // 0x0x10
    public long <PPFFDPNFPGD>k__BackingField;    // 0x0x18
    public int? <JODADDKLHGA>k__BackingField;    // 0x0x20
    public int? <MFECAOOCOCE>k__BackingField;    // 0x0x28
    public long? <NLPEJJIJEEL>k__BackingField;    // 0x0x30
    public long <JAELEKMCAPF>k__BackingField;    // 0x0x40
    public long <IKMHKNJHEAH>k__BackingField;    // 0x0x48
    public int <OBOOPCILCMB>k__BackingField;    // 0x0x50
    public HJGPLEDMFGJ <NLBMMDENJII>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <KCEKIIDFAJF>k__BackingField;    // 0x0x58
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
    public IOAMOMDOIJK <GiftContext>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.NewInventionRequestDTO
//   REQUEST  POST   api/inventions/v6/save   [Service.API]
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
    public EDMLCNGKNBJ creatorAccountRole;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public GMHEBHBDDFM <LFBJOPIILNE>k__BackingField;    // 0x0x10
    public ONGMMLCPDBD <DJKPCGBCIDH>k__BackingField;    // 0x0x14
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x18
    public string <AMKLBBGMPOH>k__BackingField;    // 0x0x20
    public bool <HDGBDLGFEAC>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public List<GMHEBHBDDFM> <NCJEJNNFBOA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/event/{bNLMOEMNEJG}   [Service.API]
public class ProgressionEventDTO
{
    public long <PPFFDPNFPGD>k__BackingField;    // 0x0x10
    public string <PNBNNHJPLOI>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <PFCMOCNEKOA>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <KIBMMMEHAHL>k__BackingField;    // 0x0x28
    public DateTime <HAENIHLLMOD>k__BackingField;    // 0x0x30
    public DateTime <HPMDINGOMJK>k__BackingField;    // 0x0x38
    public DateTime <GOGJPMPMCGC>k__BackingField;    // 0x0x40
    public bool <KBLDFHMHFIP>k__BackingField;    // 0x0x48
    public int <FBFIMDAMMOP>k__BackingField;    // 0x0x4C
    public float <GOODILFCNIE>k__BackingField;    // 0x0x50
    public Guid? <EBLGMDNJECM>k__BackingField;    // 0x0x54
    public string <OJGAPOPCICB>k__BackingField;    // 0x0x68
    public string <MEJABACONCK>k__BackingField;    // 0x0x70
    public string <PDGFFDJLHEA>k__BackingField;    // 0x0x78
    public string <LOKPCLFMNHI>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <CCMGDBABANF>k__BackingField;    // 0x0x10
    public int <GJHHIKFJNEC>k__BackingField;    // 0x0x20
    public int <FJMJGEDDHML>k__BackingField;    // 0x0x24
    public int <KEBPCBNDGNC>k__BackingField;    // 0x0x28
    public long <OGFBDCNJHIG>k__BackingField;    // 0x0x30
    public long <FPAGIOLOLNB>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.API]
public class ProgressionEventRecordDTO
{
    public int <PBFEKMBBLCH>k__BackingField;    // 0x0x10
    public int <MGJICBCEJDM>k__BackingField;    // 0x0x14
    public int <PLGDFFDCPGC>k__BackingField;    // 0x0x18
    public int <HEPAOCEGMFN>k__BackingField;    // 0x0x1C
    public int <OPIPGGIDKCA>k__BackingField;    // 0x0x20
    public DateTime? <LAIDJKIKFNC>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <PLDHFPDMKJP>k__BackingField;    // 0x0x10
    public int <FLJOIBPAGBP>k__BackingField;    // 0x0x18
    public string <HHFOJDFIAEM>k__BackingField;    // 0x0x20
    public int <MGJICBCEJDM>k__BackingField;    // 0x0x28
    public int <GNKBKHLMDKI>k__BackingField;    // 0x0x2C
    public bool <HHCGIDPFCAP>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public GDLDIHFBBNB ReportCategory;    // 0x0x20
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
    public bool IMOABIGIFNO;    // 0x0x28
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
// SA.iOS.GameKit.ISN_GKSavedGameFetchResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameFetchResult : SA_Result
{
    public List<ISN_GKSavedGame> m_SavedGames;    // 0x0x28
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

// api/CampusCard/v1/UpdateAndGetSubscription  [Econ POST]
public class CampusCardV1UpdateAndGetSubscriptionRequest
{
    public string accessToken;  // wrapper
}

// api/PlayerCheer/v1/SetSelectedCheer  [API POST]
public class PlayerCheerV1SetSelectedCheerRequest
{
    public MFHEPGIONMF? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public MFHEPGIONMF BBKHBPKELJG;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public CJGCPDFJPEI MKEAHNIIJJE;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public OGPGLOGEJOP BJKOKHNAAID;  // wrapper
    public int? FJGIJACKLLP;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v1/moderationBlockDetails  [API POST]
public class PlayerReportingV1ModerationBlockDetailsRequest
{
    public string deviceToken;  // wrapper
}

// api/PlayerReporting/v3/create  [API POST]
public class PlayerReportingV3CreateRequest
{
    public HBFCHDJCDFD BNCGKLEKLLN;  // wrapper
    public float? DAACCACMOFI;  // wrapper
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
    public List<LEBODCONKGF> desc;  // wrapper
}

// api/avatar/v2/gifts/consume/  [Econ POST]
public class AvatarV2GiftsConsumeRequest
{
    public DHNOAAFKKCN UnlockedLevel;  // wrapper
}

// api/avatar/v2/gifts/generate  [Econ POST]
public class AvatarV2GiftsGenerateRequest
{
    public IOAMOMDOIJK LIODJEBJPCP;  // wrapper
    public IOAMOMDOIJK? OHLJEBCHGLB;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [Econ POST]
public class AvatarV3GiftsGenerateRequest
{
    public IOAMOMDOIJK LIODJEBJPCP;  // wrapper
    public IOAMOMDOIJK? OHLJEBCHGLB;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/challenge/v2/updateProgress  [Econ POST]
public class ChallengeV2UpdateProgressRequest
{
    public PLLNIDDHIKI NLBAPAEAOPM;  // wrapper
    public object UpdateChallengeProgress;  // candidate
    public object ChallengeId;  // candidate
    public object Config;  // candidate
    public object ChallengeMapId;  // candidate
    public object Complete;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public HBFCHDJCDFD BNCGKLEKLLN;  // wrapper
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
    public EJLBONIJKCO OEAMOCNEKDF;  // wrapper
    public NIDANHLBICP HEBEEOOBEKJ;  // wrapper
    public byte[] PBMILKNBBLN;  // wrapper
    public byte[] MJCCFKBJAHN;  // wrapper
    public Color JFJPGCGPBNP;  // wrapper
    public object metadata;  // candidate
    public object thumbnailImage;  // candidate
    public object design;  // candidate
    public object file.bin;  // candidate
}

// api/customAvatarItems/v1/design  [API GET]
public class CustomAvatarItemsV1DesignRequest
{
    public object metadata;  // candidate
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
    public List<FKGKBCPCKEF> JONKACOIJEB;  // wrapper
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
    public HNHMPHOFFLK FBIPHIMFBFH;  // wrapper
    public IOAMOMDOIJK? JHLFLEOJHPG;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [Econ POST]
public class GamerewardsV1SelectRequest
{
    public GDFOJNKFFIC ANPPBLOAGPB;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/images/v4/room/{roomId}  [API GET]
public class ImagesV4RoomRoomIdRequest
{
    public object filter;  // candidate
    public object sort;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/images/v5/bulk  [API GET]
public class ImagesV5BulkRequest
{
    public List<long> ids;  // query
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

// api/incentivizedreferrals/claim  [Econ POST]
public class IncentivizedreferralsClaimRequest
{
    public int ReferralRewardId;  // wrapper
}

// api/incentivizedreferrals/referrals  [Econ GET]
public class IncentivizedreferralsReferralsRequest
{
    public object continuationToken;  // candidate
    public object take;  // candidate
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
    public FPADPBNJHMG inventionId;  // wrapper
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

// api/keepsakes/{kNBGMNMIJEJ}/collect  [API POST]
public class KeepsakesKNBGMNMIJEJCollectRequest
{
    public Guid KNBGMNMIJEJ;  // wrapper
}

// api/messages/v1/sendMultiple  [API POST]
public class MessagesV1SendMultipleRequest
{
    public List<long> PGAEIHLHNEM;  // wrapper
    public GJEPKLBOMHE NEIDMAOMGFA;  // wrapper
    public long? EJLCNJNHKAA;  // wrapper
    public object ToPlayerIds;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
    public object SendMessageMultiple;  // candidate
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public GJEPKLBOMHE NEIDMAOMGFA;  // wrapper
    public long? EJLCNJNHKAA;  // wrapper
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
    public long? MNHLFPBJIPK;  // wrapper
}

// api/playerevents/v1/bulk  [API POST]
public class PlayereventsV1BulkRequest
{
    public List<long> Ids;  // form
}

// api/playerevents/v1/bulkInvite  [API POST]
public class PlayereventsV1BulkInviteRequest
{
    public List<int> PGAEIHLHNEM;  // wrapper
}

// api/playerevents/v1/deleteResponse  [API POST]
public class PlayereventsV1DeleteResponseRequest
{
    public AMGCNJEPFFE EHFOPPOKGLL;  // wrapper
}

// api/playerevents/v1/report  [API POST]
public class PlayereventsV1ReportRequest
{
    public HBFCHDJCDFD BNCGKLEKLLN;  // wrapper
}

// api/playerevents/v1/respond  [API POST]
public class PlayereventsV1RespondRequest
{
    public AMGCNJEPFFE EHFOPPOKGLL;  // wrapper
}

// api/playerevents/v2  [API POST]
public class PlayereventsV2Request
{
    public long? KEECHBIDKCE;  // wrapper
    public long? PDHLMGBLOJO;  // wrapper
    public List<string> BFALHMLJNBE;  // wrapper
    public DateTime JHOEGDEHLMP;  // wrapper
    public DateTime DEOPBJPCPDJ;  // wrapper
    public BAJHHHKLIHG OEAMOCNEKDF;  // wrapper
    public HPBLGHHOEBG ABEPKLLIICO;  // wrapper
    public HPBLGHHOEBG EIMPNHBBPMJ;  // wrapper
}

// api/playerevents/v2/{eventId}  [API POST]
public class PlayereventsV2EventIdRequest
{
    public long? KEECHBIDKCE;  // wrapper
    public List<string> BFALHMLJNBE;  // wrapper
    public DateTime JHOEGDEHLMP;  // wrapper
    public DateTime DEOPBJPCPDJ;  // wrapper
    public BAJHHHKLIHG OEAMOCNEKDF;  // wrapper
    public long? PDHLMGBLOJO;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public BAJHHHKLIHG OEAMOCNEKDF;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? PDHLMGBLOJO;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public HPBLGHHOEBG ABEPKLLIICO;  // wrapper
    public HPBLGHHOEBG MFDFINKNJNG;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? KEECHBIDKCE;  // wrapper
}

// api/playerevents/v2/{eventId}/tags  [API PUT]
public class PlayereventsV2EventIdTagsRequest
{
    public List<string> BFALHMLJNBE;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime JHOEGDEHLMP;  // wrapper
    public DateTime DEOPBJPCPDJ;  // wrapper
}

// api/playerwarnings  [API POST]
public class PlayerwarningsRequest
{
    public HBFCHDJCDFD BNCGKLEKLLN;  // wrapper
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
    public Guid LBMHLNHHDMI;  // wrapper
    public object PurchaseOfferId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedAmount;  // candidate
}

// api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency  [Econ PUT]
public class RoomconsumablesV1RoomconsumableRoomconsumableIdPurchaseCurrencyRequest
{
    public Guid MCHNJDGLEMA;  // wrapper
    public Guid PNNDAJAFLAN;  // wrapper
    public Guid? PEEFDAEGHOJ;  // wrapper
}

// api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens  [Econ PUT]
public class RoomconsumablesV1RoomconsumableRoomconsumableIdPurchaseTokensRequest
{
    public Guid MCHNJDGLEMA;  // wrapper
    public Guid? PEEFDAEGHOJ;  // wrapper
}

// api/roomcurrencies/v1/awardCurrency/bulk  [Econ POST]
public class RoomcurrenciesV1AwardCurrencyBulkRequest
{
    public List<KLCMCDIJAEN> EBMKCAFAAHP;  // wrapper
}

// api/roomcurrencies/v1/createCurrency  [Econ POST]
public class RoomcurrenciesV1CreateCurrencyRequest
{
    public object Color;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
    public object Shape;  // candidate
}

// api/roomcurrencies/v1/createPurchaseOffer  [Econ POST]
public class RoomcurrenciesV1CreatePurchaseOfferRequest
{
    public Guid GIKONMMFHLB;  // wrapper
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
    public Guid GIKONMMFHLB;  // wrapper
    public long? LPMFMJFILEC;  // wrapper
    public byte? FECMDKHDNMG;  // wrapper
    public int? JFJPGCGPBNP;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid LBMHLNHHDMI;  // wrapper
    public long? NFMKJCDPNEG;  // wrapper
    public long? LLJHDFCKCBI;  // wrapper
    public int? AKHAMFLNNCP;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [Econ PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> HIKDFDIFDNM;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/awardbulk  [Econ POST]
public class RoomkeysV1AwardbulkRequest
{
    public IEnumerable<IPDDGPGLMCL> NKCEMDLDIOM;  // wrapper
}

// api/roomkeys/v1/create  [Econ POST]
public class RoomkeysV1CreateRequest
{
    public ANALGPFIMNK BJKOKHNAAID;  // wrapper
    public Guid? JOINEGDFFPL;  // wrapper
    public object Price;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Type;  // candidate
    public object RoomId;  // candidate
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
    public HBFCHDJCDFD BNCGKLEKLLN;  // wrapper
    public long? ONLFDKFJMMM;  // wrapper
    public object ReportCategory;  // candidate
    public object RoomId;  // candidate
    public object RoomKeyId;  // candidate
    public object Details;  // candidate
}

// api/royale/v2/matchcomplete  [Econ POST]
public class RoyaleV2MatchcompleteRequest
{
    public MatchCompleteStats EFMMFENOFJF;  // wrapper
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
    public Guid OPKFGNDFMAH;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [Econ POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid KLKEMJIEDJH;  // wrapper
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
    public List<ELDOGPMEIKD> HAOFFNAMNPG;  // wrapper
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
    public FEJDGLOLJGN AJGLECPBAGJ;  // wrapper
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public int? pid;  // wrapper
}

