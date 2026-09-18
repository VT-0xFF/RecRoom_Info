// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 246 (plus referenced enums)

// --------------------------------------------------------------------------
// AEAMHCDDOBK
// base   : System.Enum
//   RESPONSE ?      api/roomkeys/   [Service.Econ]
//   RESPONSE DELETE api/roomkeys/v1/delete/{roomKeyId}   [Service.Econ]
public enum AEAMHCDDOBK
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
    PriceTooLow = 10,
    PriceTooHigh = 11,
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
// AFBECNPBOOA
//   (not directly referenced by a detected call)
public class AFBECNPBOOA
{
    public string <NHCJNPHDFPM>k__BackingField;    // 0x0x10
    public IMFKEBMJBKK <CAODMDDNLAM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AHLKILKNOMG
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class AHLKILKNOMG
{
    public FPNAKLCCNGK <KIJBCADOGJI>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// AJPBDAOGJEO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AJPBDAOGJEO
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
// ALLJEAFIAOI
//   (not directly referenced by a detected call)
public class ALLJEAFIAOI
{
    public float <CDFMINHIFMM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// APEMKEBLKEE
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.Econ]
public class APEMKEBLKEE
{
    public int <JNPBAEMBENO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// BBMELDFFIBI
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
//   RESPONSE DELETE api/keepsakes/{bHFEEHHPAJE}   [Service.API]
//   RESPONSE POST   api/playerwarnings   [Service.API]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.Econ]
public class BBMELDFFIBI
{
    public bool <PCMGPKFHLJN>k__BackingField;    // 0x0x10
    public string <IKOBIIEBLGJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BCPOECCLBAO
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class BCPOECCLBAO
{
    public int? <KHMBCAJFNPO>k__BackingField;    // 0x0x10
    public string <GDOBMJBIBOE>k__BackingField;    // 0x0x18
    public string <EFMNCPJNHJC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BDJOHGNDMOH
//   (not directly referenced by a detected call)
public class BDJOHGNDMOH
{
    public bool <LEEPCKHFNKC>k__BackingField;    // 0x0x10
    public KBAKOCOEIIO <EHCAFFPNEGE>k__BackingField;    // 0x0x18
    public float <PNMMHFFFOOI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BFPJJMDFJDH
//   REQUEST  POST   api/avatar/v3/saved/set   [Service.Econ]
public class BFPJJMDFJDH
{
    public int <CMGGIBDINMM>k__BackingField;    // 0x0x10
    public string <ABFFAKANLEC>k__BackingField;    // 0x0x18
    public string <DMNJFKKIGEE>k__BackingField;    // 0x0x20
    public string <NJJNKALDJGD>k__BackingField;    // 0x0x28
    public string <EDHPAPDKODH>k__BackingField;    // 0x0x30
    public string <HIEIPCHMBEN>k__BackingField;    // 0x0x38
    public string <KCFINHBDHNI>k__BackingField;    // 0x0x40
    public List<GPDCLOKIFNI> <IJFOHBBOAMP>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// BJINICFHCON
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{jKJGIENFAPP}   [Service.Econ]
public class BJINICFHCON
{
    public MLPCHJLKHHH <DGGJEKIKGIB>k__BackingField;    // 0x0x10
    public CDBOKBMOJBJ <CDIOKDBPJNP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BNBOGJMLJOI
//   RESPONSE GET    api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class BNBOGJMLJOI
{
    public DHGJGCOMKOM <MEKAKMHEHBI>k__BackingField;    // 0x0x10
    public int <JNPBAEMBENO>k__BackingField;    // 0x0x14
    public long <ELBMHAGAMEF>k__BackingField;    // 0x0x18
    public bool <BHNFCLNBDDP>k__BackingField;    // 0x0x20
    public string <CDHAKLLFKNJ>k__BackingField;    // 0x0x28
    public int? <OICFMFEKEJH>k__BackingField;    // 0x0x30
    public bool <FAKDMPIAENM>k__BackingField;    // 0x0x38
    public bool <BBJDMGHPANP>k__BackingField;    // 0x0x39
    public bool <MCFIEOEBOEF>k__BackingField;    // 0x0x3A
    public string <IOHILEPCHDA>k__BackingField;    // 0x0x40
    public DateTime? <FOAHKBNJLAN>k__BackingField;    // 0x0x48
    public float <HBMANJAMEKB>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// BOKALNCNCPP
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.Econ]
public class BOKALNCNCPP
{
    public List<int> <CGOAFCMCOBG>k__BackingField;    // 0x0x10
    public string <FKDDKBACEPG>k__BackingField;    // 0x0x18
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
// CCIJGEOLBHA
//   RESPONSE ?      api/roomkeys/v1/   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Econ]
public class CCIJGEOLBHA
{
    public AEAMHCDDOBK <DGGJEKIKGIB>k__BackingField;    // 0x0x10
    public MEKJGDHHNLL <CANCEPANBLB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CDBOKBMOJBJ
//   (not directly referenced by a detected call)
public class CDBOKBMOJBJ
{
    public Guid <OMODPOFCFMK>k__BackingField;    // 0x0x10
    public long <HIEEAHOHOHM>k__BackingField;    // 0x0x20
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x28
    public string <NPFNIBAFPOO>k__BackingField;    // 0x0x30
    public string <MCAODCOBBLN>k__BackingField;    // 0x0x38
    public long <BFBDMGPBJAJ>k__BackingField;    // 0x0x40
    public Guid? <EGNGEBBFDNF>k__BackingField;    // 0x0x48
    public DateTime <EGAMAHECJHK>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// CEEGGBGCGEG
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.Econ]
public class CEEGGBGCGEG
{
    public int <MCNJKHDKIFH>k__BackingField;    // 0x0x10
    public string <MCFCKOFDJNM>k__BackingField;    // 0x0x18
    public List<ICFJBECNMCK> <DINPBBIHGOB>k__BackingField;    // 0x0x20
    public KCPCFNNMCFI <PANFEFPFPDB>k__BackingField;    // 0x0x28
    public string <CLEDNAKAFHF>k__BackingField;    // 0x0x30
    public DateTime <AOBPMHHELPM>k__BackingField;    // 0x0x38
    public DateTime <BHBPEIICNJM>k__BackingField;    // 0x0x40
    public DateTime <DGALFOALFMM>k__BackingField;    // 0x0x48
    public bool? <GJPHEEALJGE>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// CGJAMKIPDKK
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.API]
public class CGJAMKIPDKK
{
    public int <BDGGOIJKCPF>k__BackingField;    // 0x0x10
    public int? <GDENOIHAJKB>k__BackingField;    // 0x0x14
    public string <FEGOJENPFBC>k__BackingField;    // 0x0x20
    public string <CEKKDGHFIGJ>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// CGKNHNCMOMD
//   REQUEST  ?      api/roomconsumables   [Service.Econ]
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/consume   [Service.Econ]
public class CGKNHNCMOMD
{
    public Guid? <MJAOOCPPLOI>k__BackingField;    // 0x0x10
    public Guid <GAFNALINPCA>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// CICGFFIIKMK
//   RESPONSE ?      api/incentivizedreferrals/   [Service.Econ]
public class CICGFFIIKMK
{
    public List<EKHGDNLEIAI> <GLMMAMLCMGN>k__BackingField;    // 0x0x10
    public string <FKDDKBACEPG>k__BackingField;    // 0x0x18
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
// DCFIICOBPME
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DCFIICOBPME
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// DDOLJHDHBJP
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/consume   [Service.Econ]
public class DDOLJHDHBJP
{
    public MLPCHJLKHHH <DGGJEKIKGIB>k__BackingField;    // 0x0x10
    public HKCMNKOMFLJ <OOJJMHDKIHB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DGFNIDFDLDC
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class DGFNIDFDLDC
{
    public CGKNHNCMOMD <NKLFAEOPCBN>k__BackingField;    // 0x0x10
    public JFJAGBNACFI <ACNJCPMJNAB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DJPIJFEEDEA
//   RESPONSE ?      api/avatar/   [Service.Econ]
//   RESPONSE GET    api/avatar/v2   [Service.Econ]
//   REQUEST  POST   api/avatar/v2/set   [Service.Econ]
//   RESPONSE GET    api/avatar/v2/{hOHMOBPJMJF}   [Service.Econ]
public class DJPIJFEEDEA
{
    public string <DMNJFKKIGEE>k__BackingField;    // 0x0x10
    public string <NJJNKALDJGD>k__BackingField;    // 0x0x18
    public string <EDHPAPDKODH>k__BackingField;    // 0x0x20
    public string <HIEIPCHMBEN>k__BackingField;    // 0x0x28
    public string <KCFINHBDHNI>k__BackingField;    // 0x0x30
    public List<GPDCLOKIFNI> <IJFOHBBOAMP>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// EDFIAGHDBBP
//   (not directly referenced by a detected call)
public class EDFIAGHDBBP
{
    public GNHKMHKKAKO <AEHFFCFHBCL>k__BackingField;    // 0x0x10
    public HNCGFIDHKAF <ABCGLIGJFIF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EGBPHLJFKJE
//   (not directly referenced by a detected call)
public class EGBPHLJFKJE
{
    public DateTime <IPEGGABNLMP>k__BackingField;    // 0x0x10
    public string <DPAECJJAPNM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EHEPFLIJJMH
//   RESPONSE POST   api/inventions/v1/cheer   [Service.API]
//   RESPONSE GET    api/inventions/v1/delete   [Service.API]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.API]
//   RESPONSE GET    api/inventions/v1/update   [Service.API]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.API]
//   RESPONSE GET    api/inventions/v3/publish   [Service.API]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.Econ]
public class EHEPFLIJJMH
{
    public IIMCPFJKDGA <DGGJEKIKGIB>k__BackingField;    // 0x0x10
    public NJHMOEEKHJF <OLPFHKKNONL>k__BackingField;    // 0x0x18
    public PKJLGCCOPEO <PPKHPNFFIAI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EIOKKEGNICB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EIOKKEGNICB
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// EIOMEKEPNIO
//   (not directly referenced by a detected call)
public class EIOMEKEPNIO
{
    public Guid <BNBHABFKNCK>k__BackingField;    // 0x0x10
    public Guid <PKCDGDOOIKE>k__BackingField;    // 0x0x20
    public DateTime <AOBPMHHELPM>k__BackingField;    // 0x0x30
    public List<KBAKOCOEIIO> <KAOEHJLHMJJ>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// EJDBJFMFLPJ
//   (not directly referenced by a detected call)
public class EJDBJFMFLPJ
{
    public int <PJJGGBFJIDL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// EKHGDNLEIAI
//   (not directly referenced by a detected call)
public class EKHGDNLEIAI
{
    public int <GHAKOLBMGDN>k__BackingField;    // 0x0x10
    public DateTime <IPEGGABNLMP>k__BackingField;    // 0x0x18
    public DateTime? <KNOGNHKPOKJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EKHNIPJGOEH
// base   : EJPKLKNONKJ
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class EKHNIPJGOEH : EJPKLKNONKJ
{
    public IINENNFANCE? <DLLNDJALIFI>k__BackingField;    // 0x0x18
    public FMHGKIPCMJN <DGLNFCDAAEA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EOJDLKDMCEL
//   RESPONSE GET    api/config/v1/azurespeech   [Service.API]
public class EOJDLKDMCEL
{
    public bool <ELFOGAPEJEL>k__BackingField;    // 0x0x10
    public string <JIMJHMFDEPA>k__BackingField;    // 0x0x18
    public string <ODJBKPGCEJE>k__BackingField;    // 0x0x20
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
// FBEOGEFDDBI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FBEOGEFDDBI
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// FCNPMPCDEJG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FCNPMPCDEJG
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// FMHGKIPCMJN
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.Econ]
public class FMHGKIPCMJN
{
    public int <AOMMGOMJHPE>k__BackingField;    // 0x0x10
    public Guid <AJCNFOONIAD>k__BackingField;    // 0x0x14
    public long <DMGPJKJELEL>k__BackingField;    // 0x0x28
    public DateTime <EGAMAHECJHK>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// FNEENOPABGD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FNEENOPABGD
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
// FPNAKLCCNGK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FPNAKLCCNGK
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
// GGFIPENIPIO
//   RESPONSE GET    api/config/v1/amplitude   [Service.API]
public class GGFIPENIPIO
{
    public string <MONGKBNLDDK>k__BackingField;    // 0x0x10
    public string <GFIJMDGIHBG>k__BackingField;    // 0x0x18
    public bool <NKLCFNBADPM>k__BackingField;    // 0x0x20
    public string <EAPDPNJFIKJ>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// GKCHFPLMBGI
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
public class GKCHFPLMBGI
{
    public List<string> <LFNNAMGHNAH>k__BackingField;    // 0x0x10
    public List<string> <IHCLDPCAJJC>k__BackingField;    // 0x0x18
    public List<string> <OBFBMOJIDJH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GNCFODKHCOA
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.Econ]
public class GNCFODKHCOA
{
    public long <HIEEAHOHOHM>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <LNEKBGDPHGA>k__BackingField;    // 0x0x18
    public PIOKMJCMOLM <NFDKDHOPALI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GNHKMHKKAKO
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class GNHKMHKKAKO
{
    public long <MPACMOBONAL>k__BackingField;    // 0x0x10
    public int <MHKFCACJOLH>k__BackingField;    // 0x0x18
    public long <HIEEAHOHOHM>k__BackingField;    // 0x0x20
    public long? <LKFKHOKPAME>k__BackingField;    // 0x0x28
    public long? <JLECKNFNGPF>k__BackingField;    // 0x0x38
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x48
    public string <NPFNIBAFPOO>k__BackingField;    // 0x0x50
    public string <MCAODCOBBLN>k__BackingField;    // 0x0x58
    public DateTime <NMJDCIOHDJE>k__BackingField;    // 0x0x60
    public DateTime <OEKBPIMKBNG>k__BackingField;    // 0x0x68
    public int <FFHGMGBDIHA>k__BackingField;    // 0x0x70
    public EIOKKEGNICB <CAHINGJHFIL>k__BackingField;    // 0x0x74
    public bool <KPIOMAJMDGB>k__BackingField;    // 0x0x78
    public bool <BEOOFONMBLJ>k__BackingField;    // 0x0x79
    public IEKKAGLGFFC <FDDLAPEFBDO>k__BackingField;    // 0x0x7C
    public IEKKAGLGFFC <EHFFCKONHNH>k__BackingField;    // 0x0x80
    public long? <BNPOBLPJAJG>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// GPDCLOKIFNI
//   (not directly referenced by a detected call)
public class GPDCLOKIFNI
{
    public Guid <HGELPBIDILJ>k__BackingField;    // 0x0x10
    public byte <LELGLFMJKPG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HBKDNINFNEF
// base   : GNHKMHKKAKO
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class HBKDNINFNEF : GNHKMHKKAKO
{
    public List<AFBECNPBOOA> <NMEGJDBKJKJ>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// HJJLCFPFOGN
//   (not directly referenced by a detected call)
public class HJJLCFPFOGN
{
    public int <NLMBHLCBDEH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// HKCMNKOMFLJ
//   (not directly referenced by a detected call)
public class HKCMNKOMFLJ
{
    public Guid <OMODPOFCFMK>k__BackingField;    // 0x0x10
    public int <AOMMGOMJHPE>k__BackingField;    // 0x0x20
    public int <MMMJHOJECBE>k__BackingField;    // 0x0x24
    public Guid <LMIEPFIDNJK>k__BackingField;    // 0x0x28
    public DateTime <EGAMAHECJHK>k__BackingField;    // 0x0x38
    public CDBOKBMOJBJ <CDIOKDBPJNP>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// HLECHMLANEK
// base   : JOIBMNHBCBP
//   (not directly referenced by a detected call)
public class HLECHMLANEK : JOIBMNHBCBP
{
    public int <ABCLEOODAKG>k__BackingField;    // 0x0x60
    public List<BDJOHGNDMOH> <PGKPMGMBEPB>k__BackingField;    // 0x0x68
    public List<BDJOHGNDMOH> <GPFHLKJEMLF>k__BackingField;    // 0x0x70
    public List<BDJOHGNDMOH> <POBEFAMCOOE>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// HNCGFIDHKAF
//   (not directly referenced by a detected call)
public class HNCGFIDHKAF
{
    public long <ADAECOCHJMO>k__BackingField;    // 0x0x10
    public long <MPACMOBONAL>k__BackingField;    // 0x0x18
    public int <CHLBAHFOKDG>k__BackingField;    // 0x0x20
    public DateTime <IPEGGABNLMP>k__BackingField;    // 0x0x28
    public DCFIICOBPME <CAODMDDNLAM>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// HNMLOAHFMGF
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.API]
public class HNMLOAHFMGF
{
    public List<GNHKMHKKAKO> <KADGBGGPPDJ>k__BackingField;    // 0x0x10
    public string <FKDDKBACEPG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HOOFCEHMJML
// base   : EJPKLKNONKJ
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class HOOFCEHMJML : EJPKLKNONKJ
{
    public BFJEOKMPHOM? <DLLNDJALIFI>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <KJPHIAMNAEE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// IBFJKHEIMCE
//   (not directly referenced by a detected call)
public class IBFJKHEIMCE
{
    public float <GEICHLJDFPA>k__BackingField;    // 0x0x10
    public float <BOMGPKNBBHM>k__BackingField;    // 0x0x14
    public float <GALAIDPIIGH>k__BackingField;    // 0x0x18
    public float <HBBNIEOAGJP>k__BackingField;    // 0x0x1C
    public float <PKKMIBDNBCA>k__BackingField;    // 0x0x20
    public float <BBBNGPIBPDB>k__BackingField;    // 0x0x24
    public float <MIAOLNNDMFN>k__BackingField;    // 0x0x28
    public float <CEPGJGKCHNA>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// ICFJBECNMCK
//   (not directly referenced by a detected call)
public class ICFJBECNMCK
{
    public int <GFFOGPMJAGG>k__BackingField;    // 0x0x10
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x18
    public string <JFIPGFHNDOK>k__BackingField;    // 0x0x20
    public string <NPFNIBAFPOO>k__BackingField;    // 0x0x28
    public string <BCJDEIHOLON>k__BackingField;    // 0x0x30
    public bool <NEEPDFAOPCA>k__BackingField;    // 0x0x38
    public int <CMGGIBDINMM>k__BackingField;    // 0x0x3C
    public LGGEDMKILCB <OBIDMAFOIBB>k__BackingField;    // 0x0x40
    public LNOMEKCBJFH GHCKOBKEBGG;    // 0x0x48
    public LNOMEKCBJFH FPGPHFIGGJI;    // 0x0x50
    public LNOMEKCBJFH OKOIAGEAIAC;    // 0x0x58
    public KKKKGHOBIKD KHAJNLOCFNC;    // 0x0x60
}

// --------------------------------------------------------------------------
// IEKKAGLGFFC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IEKKAGLGFFC
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// IIMCPFJKDGA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IIMCPFJKDGA
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
// IIMPACIFINK
//   (not directly referenced by a detected call)
public class IIMPACIFINK
{
    public NNOPMNLKINO <HPAKNACCPAH>k__BackingField;    // 0x0x10
    public int <BFBDMGPBJAJ>k__BackingField;    // 0x0x14
    public PFHKEKPAHLE <IGIIELEHMDJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IINENNFANCE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IINENNFANCE
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// IMFKEBMJBKK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IMFKEBMJBKK
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// JAPKOGIEAAF
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{balanceaddtypeId}/False   [Service.Econ]
public class JAPKOGIEAAF
{
    public NNOPMNLKINO <HPAKNACCPAH>k__BackingField;    // 0x0x10
    public OAPGKNOMGOO <CAFHKDIOCDK>k__BackingField;    // 0x0x14
    public int <CBHGCBJJGFI>k__BackingField;    // 0x0x18
    public int <FOAEIFFGJEI>k__BackingField;    // 0x0x1C
    public int <POIHBOIGOBP>k__BackingField;    // 0x0x20
    public JHLELKIOJCP <BNCCNFOHFFK>k__BackingField;    // 0x0x24
    public bool <DHHPCDLNJAD>k__BackingField;    // 0x0x28
    public float <AGEBKNJHMLB>k__BackingField;    // 0x0x2C
    public int <BDJHKGAPDIP>k__BackingField;    // 0x0x30
    public bool <MAHPIAMKNHC>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// JFJAGBNACFI
//   (not directly referenced by a detected call)
public class JFJAGBNACFI
{
    public long <BFBDMGPBJAJ>k__BackingField;    // 0x0x10
    public Guid? <AJCNFOONIAD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JHLELKIOJCP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JHLELKIOJCP
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// JIDNONNCFPM
//   (not directly referenced by a detected call)
public class JIDNONNCFPM
{
    public bool <IKKFKOMMPDK>k__BackingField;    // 0x0x10
    public AJPBDAOGJEO <GCJODCOFEIE>k__BackingField;    // 0x0x14
    public int <LEGGIICGMII>k__BackingField;    // 0x0x18
    public DateTime <EGAMAHECJHK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JJLCNGFKFLK
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
public class JJLCNGFKFLK
{
    public JHHFCDGCLEI <MEKAKMHEHBI>k__BackingField;    // 0x0x10
    public string <NPLAPNJFEHM>k__BackingField;    // 0x0x18
    public int? <OFNLPBMNLMJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JMPPDBEMNEB
//   RESPONSE ?      api/inventions/   [Service.API]
//   RESPONSE GET    api/inventions/v1/personaldetails/{eENIGONCEJB}   [Service.API]
public class JMPPDBEMNEB
{
    public bool <IJCHIMKIOFE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JOIBMNHBCBP
//   (not directly referenced by a detected call)
public class JOIBMNHBCBP
{
    public int <COAIHEEGDFL>k__BackingField;    // 0x0x10
    public FBEOGEFDDBI <CAODMDDNLAM>k__BackingField;    // 0x0x14
    public List<IIMPACIFINK> <EFLJFBAEHOA>k__BackingField;    // 0x0x18
    public List<IIMPACIFINK> <PCANBEIDAKC>k__BackingField;    // 0x0x20
    public bool <AIFEJDHFAGO>k__BackingField;    // 0x0x28
    public DateTime? <HIHMOAMHHEO>k__BackingField;    // 0x0x30
    public DateTime? <MABCICDOMLP>k__BackingField;    // 0x0x40
    public DateTime? <EOLLBCFILAP>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// JPDHPKKPAKM
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
public class JPDHPKKPAKM
{
    public bool <PCMGPKFHLJN>k__BackingField;    // 0x0x10
    public string <CDHAKLLFKNJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KBAKOCOEIIO
//   (not directly referenced by a detected call)
public class KBAKOCOEIIO
{
    public int <BKEBHLIMABI>k__BackingField;    // 0x0x10
    public string <DLCIOLLIJDL>k__BackingField;    // 0x0x18
    public string <BCJDEIHOLON>k__BackingField;    // 0x0x20
    public string <GLPONPGHKOH>k__BackingField;    // 0x0x28
    public string <NKCCPAJEAGJ>k__BackingField;    // 0x0x30
    public string <AHBHLGLAFHF>k__BackingField;    // 0x0x38
    public IEFCPEPNOHH? <HPNGHGKJCAP>k__BackingField;    // 0x0x40
    public string <OEDBMEOKNLJ>k__BackingField;    // 0x0x48
    public string <AFPGFHDAINN>k__BackingField;    // 0x0x50
    public bool <CJBECAPAKDO>k__BackingField;    // 0x0x58
    public bool <DDAKJFLFINI>k__BackingField;    // 0x0x59
    public bool <BJLLJKHKPMK>k__BackingField;    // 0x0x5A
    public FCNPMPCDEJG <OENALGFFNNH>k__BackingField;    // 0x0x5C
    public int <FGACDOKOHNA>k__BackingField;    // 0x0x60
    public NNOPMNLKINO <HPAKNACCPAH>k__BackingField;    // 0x0x64
    public int <PAMINPAAFMM>k__BackingField;    // 0x0x68
    public KECMLNAOOIK <FFCKNFIPPIJ>k__BackingField;    // 0x0x6C
    public FNEENOPABGD <DMLOGPPDODM>k__BackingField;    // 0x0x70
    public int? <OJFAHFLPDAK>k__BackingField;    // 0x0x74
    public string <FCGGNMJICCF>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// KCPCFNNMCFI
//   (not directly referenced by a detected call)
public class KCPCFNNMCFI
{
    public long <BKEBHLIMABI>k__BackingField;    // 0x0x10
    public string <NKCCPAJEAGJ>k__BackingField;    // 0x0x18
    public string <HGBDHDFCJJO>k__BackingField;    // 0x0x20
    public IEFCPEPNOHH? <HPNGHGKJCAP>k__BackingField;    // 0x0x28
    public string <OEDBMEOKNLJ>k__BackingField;    // 0x0x30
    public string <AFPGFHDAINN>k__BackingField;    // 0x0x38
    public NMPNHJAFCNH <ENDLBEHKIPA>k__BackingField;    // 0x0x40
    public int <FOGNIAANEEG>k__BackingField;    // 0x0x44
    public int <FIDMEHFKDAO>k__BackingField;    // 0x0x48
    public FNEENOPABGD? <DOGJLHPLNAN>k__BackingField;    // 0x0x4C
    public FCNPMPCDEJG? <PHIALDCILBD>k__BackingField;    // 0x0x54
}

// --------------------------------------------------------------------------
// KECMLNAOOIK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KECMLNAOOIK
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
// LBHCOMAELPN
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class LBHCOMAELPN
{
    public List<MAABEJBIOCK> <JDKPJPPANGI>k__BackingField;    // 0x0x10
    public FPNAKLCCNGK <KIJBCADOGJI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LEGNNGADLBI
//   (not directly referenced by a detected call)
public class LEGNNGADLBI
{
    public int <IJNKBNPFJKA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LGALNHPPCPC
// base   : CFLCFDIDDPJ<BPNDMMCJPIA>
//   RESPONSE ?      api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{gHLHAKBBHEN}   [Service.API]
public class LGALNHPPCPC
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// LGGEDMKILCB
//   (not directly referenced by a detected call)
public class LGGEDMKILCB
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// LJAPOLJDCFP
//   RESPONSE GET    api/config/v2   [Service.API]
public class LJAPOLJDCFP
{
    public Dictionary<int, int> <LKFFDPCMAMD>k__BackingField;    // 0x0x10
    public List<BCJDDDCHABH> <NAHHGAAPEHC>k__BackingField;    // 0x0x18
    public OFDCKGCPFFB[][] <CDFKFCIOKIA>k__BackingField;    // 0x0x20
    public LEGNNGADLBI <LHOPBPCFAKL>k__BackingField;    // 0x0x28
    public IBFJKHEIMCE <GIMMKLMAILF>k__BackingField;    // 0x0x30
    public EJDBJFMFLPJ <DMILLJFCCLK>k__BackingField;    // 0x0x38
    public HJJLCFPFOGN <BCDCKJJNDJA>k__BackingField;    // 0x0x40
    public ALLJEAFIAOI <IMOGJADPCBN>k__BackingField;    // 0x0x48
    public string <BMIECIPHJBJ>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// LLKEOMGOAKC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LLKEOMGOAKC
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
// LMIFCEFKFIF
//   RESPONSE GET    api/testcasemanagement/   [Service.API]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{bJKMNBIBKCI}   [Service.API]
public class LMIFCEFKFIF
{
    public uint <FKOAFNLHKNF>k__BackingField;    // 0x0x10
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x18
    public string <NPFNIBAFPOO>k__BackingField;    // 0x0x20
    public DateTime <ENGIKCFPGHD>k__BackingField;    // 0x0x28
    public DateTime? <CCFCAFHIFIA>k__BackingField;    // 0x0x30
    public bool <GGNPHCNIJLO>k__BackingField;    // 0x0x40
    public List<PBAMPJPPNMH> <DBPOEJCPEEG>k__BackingField;    // 0x0x48
    public List<string> <NMEGJDBKJKJ>k__BackingField;    // 0x0x50
    public int <CIOAKNCAPEF>k__BackingField;    // 0x0x58
    public int <LHHOPODCCBF>k__BackingField;    // 0x0x5C
    public int <GGIJLNCFJHO>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// LOIJDMALDAP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LOIJDMALDAP
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
// MAABEJBIOCK
//   (not directly referenced by a detected call)
public class MAABEJBIOCK
{
    public int <ELFNJMGBDJL>k__BackingField;    // 0x0x10
    public FPNAKLCCNGK <KIJBCADOGJI>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// MEKJGDHHNLL
//   (not directly referenced by a detected call)
public class MEKJGDHHNLL
{
    public long <KLHBHJGCCBL>k__BackingField;    // 0x0x10
    public Guid <EELFHODOGED>k__BackingField;    // 0x0x18
    public long <HIEEAHOHOHM>k__BackingField;    // 0x0x28
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x30
    public string <NPFNIBAFPOO>k__BackingField;    // 0x0x38
    public int <BFBDMGPBJAJ>k__BackingField;    // 0x0x40
    public Guid? <EGNGEBBFDNF>k__BackingField;    // 0x0x44
    public DateTime <IPEGGABNLMP>k__BackingField;    // 0x0x58
    public string <MCAODCOBBLN>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// MEKLENOHKCD
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
public class MEKLENOHKCD
{
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x10
    public string <NPFNIBAFPOO>k__BackingField;    // 0x0x18
    public int? <BFBDMGPBJAJ>k__BackingField;    // 0x0x20
    public NPHIAEDGHJL? <CAHINGJHFIL>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// MFIBADKANNK
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{hOHMOBPJMJF}   [Service.API]
public class MFIBADKANNK
{
    public List<GNHKMHKKAKO> <EEFLMNFGGGN>k__BackingField;    // 0x0x10
    public List<EDFIAGHDBBP> <JCOLJFOEOAK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MJJPGPFGOBC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MJJPGPFGOBC
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
// MLPCHJLKHHH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MLPCHJLKHHH
{
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
}

// --------------------------------------------------------------------------
// MMMNLMCMGNM
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.Econ]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.Econ]
public class MMMNLMCMGNM
{
    public int <BDMDMMMOBHC>k__BackingField;    // 0x0x10
    public int <DAMFOLJLABK>k__BackingField;    // 0x0x14
    public float <IEILKGHACEH>k__BackingField;    // 0x0x18
    public float <MHDLIJFDBHM>k__BackingField;    // 0x0x1C
    public bool <IEHMLKLMDCN>k__BackingField;    // 0x0x20
    public bool <EBMLPJHPBIH>k__BackingField;    // 0x0x21
    public bool <IKEKOAAEHII>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// MNIIIDJKGCE
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.API]
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{cKCOMGHDNBG}   [Service.API]
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
public class MNIIIDJKGCE
{
    public HBKDNINFNEF <AEHFFCFHBCL>k__BackingField;    // 0x0x10
    public FPNAKLCCNGK <KIJBCADOGJI>k__BackingField;    // 0x0x18
    public PHIPCJLLJDB <GNKFDGLCKGN>k__BackingField;    // 0x0x20
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
// NABPAHGMLLC
//   RESPONSE GET    api/config/v1/backtrace   [Service.API]
public class NABPAHGMLLC
{
    public int <KDBONNOLGLI>k__BackingField;    // 0x0x10
    public int <KIIMEIOKBNI>k__BackingField;    // 0x0x14
    public float <NOLKABFHBBA>k__BackingField;    // 0x0x18
    public int <BLELMAEAPPO>k__BackingField;    // 0x0x1C
    public int <DPFIFFGFKAP>k__BackingField;    // 0x0x20
    public int <DFCGPFBGGCL>k__BackingField;    // 0x0x24
    public int <ANJAHBPDGEM>k__BackingField;    // 0x0x28
    public string <HPMMANIHJAJ>k__BackingField;    // 0x0x30
    public string <LCABCGBOPNK>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// NEGJLGJIDCJ
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Econ]
public class NEGJLGJIDCJ
{
    public Guid <NPNEMDHAOAH>k__BackingField;    // 0x0x10
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x20
    public string <MCAODCOBBLN>k__BackingField;    // 0x0x28
    public DateTime <AOBPMHHELPM>k__BackingField;    // 0x0x30
    public DateTime? <OGBNAOLKHLF>k__BackingField;    // 0x0x38
    public List<EIOMEKEPNIO> <PKKPEHBCJGJ>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// NJHMOEEKHJF
//   (not directly referenced by a detected call)
public class NJHMOEEKHJF
{
    public ObscuredLong <ANBNAADODOF>k__BackingField;    // 0x0x10
    public string <EELFHODOGED>k__BackingField;    // 0x0x38
    public ObscuredInt <MHKFCACJOLH>k__BackingField;    // 0x0x40
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x58
    public string <NPFNIBAFPOO>k__BackingField;    // 0x0x60
    public string <MCAODCOBBLN>k__BackingField;    // 0x0x68
    public int <COMKOMHOCFF>k__BackingField;    // 0x0x70
    public NPHIAEDGHJL <CAHINGJHFIL>k__BackingField;    // 0x0x74
    public DateTime <EGAMAHECJHK>k__BackingField;    // 0x0x78
    public DateTime <IPEGGABNLMP>k__BackingField;    // 0x0x80
    public DateTime? <OBHDOEPPGLP>k__BackingField;    // 0x0x88
    public long? <NFOJNOGBFJH>k__BackingField;    // 0x0x98
    public int <ENNEDMBCLDM>k__BackingField;    // 0x0xA8
    public int <JMJCLPKHBFI>k__BackingField;    // 0x0xAC
    public int <LDJMGADJJJE>k__BackingField;    // 0x0xB0
    public MJJPGPFGOBC <PMHFBLLFNLI>k__BackingField;    // 0x0xB4
    public MJJPGPFGOBC <GMKOGJGIDCH>k__BackingField;    // 0x0xB8
    public ObscuredBool <HNADEHCABEI>k__BackingField;    // 0x0xBC
    public ObscuredBool <NGKPFJMFMEI>k__BackingField;    // 0x0xC8
    public ObscuredBool <KCLLHCDFBOP>k__BackingField;    // 0x0xD4
    public int? <BFBDMGPBJAJ>k__BackingField;    // 0x0xE0
    public bool <MEHPODEIHOI>k__BackingField;    // 0x0xE8
}

// --------------------------------------------------------------------------
// NMLACGIKCCJ
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class NMLACGIKCCJ
{
    public List<AFBECNPBOOA> <NMEGJDBKJKJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// NMPNHJAFCNH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NMPNHJAFCNH
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
// NNOPMNLKINO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NNOPMNLKINO
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
// OAPGKNOMGOO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OAPGKNOMGOO
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
// OBLJILLKKJC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OBLJILLKKJC
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// OCODAEIDIKJ
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.API]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
public class OCODAEIDIKJ
{
    public int <CCOPAKECMPD>k__BackingField;    // 0x0x10
    public CPDGJMAJOBD <CAODMDDNLAM>k__BackingField;    // 0x0x14
    public FONLABFJJGF <ALCAODNMLAK>k__BackingField;    // 0x0x18
    public FONLABFJJGF <NNAPDJJJALH>k__BackingField;    // 0x0x1C
    public FONLABFJJGF <JIKMDBHEHNM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OFDCKGCPFFB
//   (not directly referenced by a detected call)
public class OFDCKGCPFFB
{
    public LLKEOMGOAKC KLIAOPMOPKJ;    // 0x0x10
    public int FENAIGFHBLK;    // 0x0x14
}

// --------------------------------------------------------------------------
// OIOPLBHEDKJ
// base   : CFLCFDIDDPJ<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.API]
public class OIOPLBHEDKJ
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// OKILHDFFPJP
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
public class OKILHDFFPJP
{
    public Guid? <OMODPOFCFMK>k__BackingField;    // 0x0x10
    public long? <HIEEAHOHOHM>k__BackingField;    // 0x0x28
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x38
    public string <NPFNIBAFPOO>k__BackingField;    // 0x0x40
    public string <MCAODCOBBLN>k__BackingField;    // 0x0x48
    public JFJAGBNACFI <PPGFMPFHLGH>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// PBAMPJPPNMH
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.API]
public class PBAMPJPPNMH
{
    public string <FKOAFNLHKNF>k__BackingField;    // 0x0x10
    public string <JIMJHMFDEPA>k__BackingField;    // 0x0x18
    public string <OGOLKOIBJJG>k__BackingField;    // 0x0x20
    public string <NPFNIBAFPOO>k__BackingField;    // 0x0x28
    public string <GDOBMJBIBOE>k__BackingField;    // 0x0x30
    public OBLJILLKKJC <DGGJEKIKGIB>k__BackingField;    // 0x0x38
    public List<string> <BDAJGFPDFKK>k__BackingField;    // 0x0x40
    public List<string> <NMEGJDBKJKJ>k__BackingField;    // 0x0x48
    public string <OEJINLAFLII>k__BackingField;    // 0x0x50
    public List<EGBPHLJFKJE> <KJHGJBLIKPP>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// PFHKEKPAHLE
//   (not directly referenced by a detected call)
public class PFHKEKPAHLE
{
    public int <NKAEIDGHBBD>k__BackingField;    // 0x0x10
    public DateTime? <IHACAIKCJOO>k__BackingField;    // 0x0x18
    public DateTime? <MNHLFIHAMLM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// PHIPCJLLJDB
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class PHIPCJLLJDB
{
    public LOIJDMALDAP <KIJBCADOGJI>k__BackingField;    // 0x0x10
    public List<string> <NMEGJDBKJKJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PIOKMJCMOLM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PIOKMJCMOLM
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// PJCFECMDMJF
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.Auth]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.Econ]
public class PJCFECMDMJF
{
    public int <DAMFOLJLABK>k__BackingField;    // 0x0x10
    public bool <IEHMLKLMDCN>k__BackingField;    // 0x0x14
    public DateTime <NLIJEKCNNAD>k__BackingField;    // 0x0x18
    public bool <PJJEKIPPGDE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PKIKOLFBFAK
// base   : ILDDJAFCDJK
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/season/{dMOOHKFKNKO}   [Service.Econ]
public class PKIKOLFBFAK : ILDDJAFCDJK
{
    public int <KLHAMIKLBJN>k__BackingField;    // 0x0x30
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x38
    public DateTime <AOBPMHHELPM>k__BackingField;    // 0x0x40
    public DateTime <BHBPEIICNJM>k__BackingField;    // 0x0x48
    public NNOPMNLKINO <HPAKNACCPAH>k__BackingField;    // 0x0x50
    public JOIBMNHBCBP <EKALGGLODMF>k__BackingField;    // 0x0x58
    public List<HLECHMLANEK> <BIJALMGDAPM>k__BackingField;    // 0x0x60
    public JIDNONNCFPM <KICCFLDCLLG>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// PKJLGCCOPEO
//   (not directly referenced by a detected call)
public class PKJLGCCOPEO
{
    public long <ANBNAADODOF>k__BackingField;    // 0x0x10
    public string <EELFHODOGED>k__BackingField;    // 0x0x18
    public int <PBFHMAGAIHE>k__BackingField;    // 0x0x20
    public int <AOJEDALLKIA>k__BackingField;    // 0x0x24
    public int <OKLHPLKJCPC>k__BackingField;    // 0x0x28
    public int <AEEPKKHJLJF>k__BackingField;    // 0x0x2C
    public int <LGAIFMJCOCJ>k__BackingField;    // 0x0x30
    public string <JMOLNFHKBFG>k__BackingField;    // 0x0x38
    public string <PAJEMFFJEKB>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.API]
public class AddKeepsakeInstanceRequest
{
    public long <HIEEAHOHOHM>k__BackingField;    // 0x0x10
    public long? <LKFKHOKPAME>k__BackingField;    // 0x0x18
    public BNJAPKFAEJH <ALANKFJGBDH>k__BackingField;    // 0x0x28
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
    public NBEMJKFGLEA <KIJBCADOGJI>k__BackingField;    // 0x0x10
    public string <FLJAEEDIIKD>k__BackingField;    // 0x0x18
    public string <MLJDBPLGCGC>k__BackingField;    // 0x0x20
    public string <IBKDBMCKKCA>k__BackingField;    // 0x0x28
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
    public long <MPACMOBONAL>k__BackingField;    // 0x0x10
    public long? <KHEMPFPHILP>k__BackingField;    // 0x0x18
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
    public PKDOPEDJLPJ FilterType;    // 0x0x20
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
    public BNJAPKFAEJH <BPEEKJIJNEA>k__BackingField;    // 0x0x10
    public string <OPHGIHGLCPN>k__BackingField;    // 0x0x18
    public int <NLNIJOAGKND>k__BackingField;    // 0x0x20
    public int <PHMHNCFGPBD>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <AOMMGOMJHPE>k__BackingField;    // 0x0x10
    public Guid <FMFFCFFOAMF>k__BackingField;    // 0x0x14
    public DateTime <HMLGMNKJJDM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.API]
public class KeepsakeGlobalConfigDTO
{
    public bool <NAPKECKHNOO>k__BackingField;    // 0x0x10
    public int <CAGHGIJFELA>k__BackingField;    // 0x0x14
    public bool <FKFMFOCNGCL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <FMFFCFFOAMF>k__BackingField;    // 0x0x10
    public BNJAPKFAEJH <GKCCPENMJMG>k__BackingField;    // 0x0x20
    public int <OILDIJOFDAO>k__BackingField;    // 0x0x24
    public long <HIEEAHOHOHM>k__BackingField;    // 0x0x28
    public long? <LKFKHOKPAME>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE POST   api/keepsakes   [Service.API]
//   RESPONSE GET    api/keepsakes/events/{aCDKGHBFBOL}   [Service.API]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <HGIPCDBFIPI>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <IOKFOAGLMBM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <LENGCPGAFFK>k__BackingField;    // 0x0x10
    public long <HIEEAHOHOHM>k__BackingField;    // 0x0x18
    public long <MOIPIPKBOFN>k__BackingField;    // 0x0x20
    public KJGFEDNPDHB <CAODMDDNLAM>k__BackingField;    // 0x0x28
    public int <MMHKEMGHCPO>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <HIEEAHOHOHM>k__BackingField;    // 0x0x10
    public List<Guid> <JIABMMENOOP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <HGIPCDBFIPI>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <IOKFOAGLMBM>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <HFCHBCLCKLA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <MOIPIPKBOFN>k__BackingField;    // 0x0x10
    public long <ADOGJGCEGDP>k__BackingField;    // 0x0x18
    public int? <GBMNNEJKHIL>k__BackingField;    // 0x0x20
    public int? <GNGDJLFDPNH>k__BackingField;    // 0x0x28
    public long? <GOOCNMNBHIF>k__BackingField;    // 0x0x30
    public long <OJAMOBNEDJH>k__BackingField;    // 0x0x40
    public long <MBGBOFBNHIE>k__BackingField;    // 0x0x48
    public int <ELKKFONPLKE>k__BackingField;    // 0x0x50
    public KJGFEDNPDHB <HPFDJFIMJDG>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <JFGFPIOKJDE>k__BackingField;    // 0x0x58
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
    public FNEENOPABGD <GiftContext>k__BackingField;    // 0x0x20
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
    public OGBJCPACCPN creatorAccountRole;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public IEGPAGBKNGF <HGCLDMCPFOL>k__BackingField;    // 0x0x10
    public KJKCCHKLHPC <NGBCGAILICI>k__BackingField;    // 0x0x14
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x18
    public string <NPFNIBAFPOO>k__BackingField;    // 0x0x20
    public bool <AJFGHBOKAEE>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public List<IEGPAGBKNGF> <AHNEIIENFPM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/event/{cKCOMGHDNBG}   [Service.API]
public class ProgressionEventDTO
{
    public long <ADOGJGCEGDP>k__BackingField;    // 0x0x10
    public string <CBNLPPDPLJF>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <POBEFAMCOOE>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <HCBBGNJFMHO>k__BackingField;    // 0x0x28
    public DateTime <NMJDCIOHDJE>k__BackingField;    // 0x0x30
    public DateTime <OEKBPIMKBNG>k__BackingField;    // 0x0x38
    public DateTime <COCICLKFCLG>k__BackingField;    // 0x0x40
    public bool <NGAJBKNGGBH>k__BackingField;    // 0x0x48
    public int <LFFJBMJNOJE>k__BackingField;    // 0x0x4C
    public float <AAAFCHDIDGJ>k__BackingField;    // 0x0x50
    public Guid? <JACMFJHJIFH>k__BackingField;    // 0x0x54
    public string <LGJGJPPIGFC>k__BackingField;    // 0x0x68
    public string <GPANPICDPFK>k__BackingField;    // 0x0x70
    public string <BIBLBOAMHIE>k__BackingField;    // 0x0x78
    public string <NBMJJAOHGPN>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <CGLOCDAOCDE>k__BackingField;    // 0x0x10
    public int <FDGCCKGGJEM>k__BackingField;    // 0x0x20
    public int <PADKGOHDPEA>k__BackingField;    // 0x0x24
    public int <NBCMKABIOPD>k__BackingField;    // 0x0x28
    public long <GGAKOHMJNLP>k__BackingField;    // 0x0x30
    public long <DHEGOBJGJPN>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/record/{cKCOMGHDNBG}   [Service.API]
public class ProgressionEventRecordDTO
{
    public int <AOMMGOMJHPE>k__BackingField;    // 0x0x10
    public int <FOGNIAANEEG>k__BackingField;    // 0x0x14
    public int <EEFBEAOIPLC>k__BackingField;    // 0x0x18
    public int <NPPDCPCONPG>k__BackingField;    // 0x0x1C
    public int <HLKBBOBPEHG>k__BackingField;    // 0x0x20
    public DateTime? <LALIGOKDIOF>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <GDFKDPEAHJB>k__BackingField;    // 0x0x10
    public int <BKEBHLIMABI>k__BackingField;    // 0x0x18
    public string <MCAODCOBBLN>k__BackingField;    // 0x0x20
    public int <FOGNIAANEEG>k__BackingField;    // 0x0x28
    public int <BAMOMBNMOEE>k__BackingField;    // 0x0x2C
    public bool <CKPANHFLACL>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public BLJLPBJMHHL ReportCategory;    // 0x0x20
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
    public bool OHEHKGJILPN;    // 0x0x28
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
    public HGHIJGGFKLH? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public HGHIJGGFKLH ABCCICBBBBG;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public GNDMPBIHMPA IPKBKPKJICO;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public MMEIIFKNGDM BKGBGEHNCAE;  // wrapper
    public int? LKCOCLKIGNF;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v3/create  [API POST]
public class PlayerReportingV3CreateRequest
{
    public DHGJGCOMKOM GMCBCPANNKI;  // wrapper
    public float? CFNOEPJAPOL;  // wrapper
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
    public KJHOAAHOELP UnlockedLevel;  // wrapper
}

// api/avatar/v2/gifts/generate  [Econ POST]
public class AvatarV2GiftsGenerateRequest
{
    public FNEENOPABGD OEGBAMNPENI;  // wrapper
    public FNEENOPABGD? MBGOBOCABOM;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [Econ POST]
public class AvatarV3GiftsGenerateRequest
{
    public FNEENOPABGD OEGBAMNPENI;  // wrapper
    public FNEENOPABGD? MBGOBOCABOM;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/challenge/v2/updateProgress  [Econ POST]
public class ChallengeV2UpdateProgressRequest
{
    public ICFJBECNMCK INACFAEMNMI;  // wrapper
    public object UpdateChallengeProgress;  // candidate
    public object ChallengeId;  // candidate
    public object Config;  // candidate
    public object ChallengeMapId;  // candidate
    public object Complete;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public DHGJGCOMKOM GMCBCPANNKI;  // wrapper
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
    public NPHIAEDGHJL HHPDLCPIMKC;  // wrapper
    public byte[] FHFHCAILEFO;  // wrapper
    public byte[] PPJGPNIPHKC;  // wrapper
    public Color EELAMBEFNPK;  // wrapper
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

// api/equipment/v1/update  [Econ POST]
public class EquipmentV1UpdateRequest
{
    public List<CBMHFGJNNKB> GKHADCFLHAD;  // wrapper
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
    public ALFLLJBOMHE JMBBFDPMDBE;  // wrapper
    public FNEENOPABGD? NHDLFJHNCKO;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [Econ POST]
public class GamerewardsV1SelectRequest
{
    public KKCGJMDCOOH NCMJLPMPEFB;  // wrapper
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
    public NJHMOEEKHJF inventionId;  // wrapper
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

// api/keepsakes/{bHFEEHHPAJE}/collect  [API POST]
public class KeepsakesBHFEEHHPAJECollectRequest
{
    public Guid BHFEEHHPAJE;  // wrapper
}

// api/messages/v1/sendMultiple  [API POST]
public class MessagesV1SendMultipleRequest
{
    public List<long> LJHINBGJGOH;  // wrapper
    public HCIFPEMHLEA JDPBOHJLPIB;  // wrapper
    public long? COLNHBBPCAP;  // wrapper
    public object ToPlayerIds;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
    public object SendMessageMultiple;  // candidate
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public HCIFPEMHLEA JDPBOHJLPIB;  // wrapper
    public long? COLNHBBPCAP;  // wrapper
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
    public long? IDMFCNPGJKI;  // wrapper
}

// api/playerevents/v1/bulk  [API POST]
public class PlayereventsV1BulkRequest
{
    public IReadOnlyList<long> JPKMMOCNLJI;  // wrapper
}

// api/playerevents/v1/bulkInvite  [API POST]
public class PlayereventsV1BulkInviteRequest
{
    public List<int> LJHINBGJGOH;  // wrapper
}

// api/playerevents/v1/deleteResponse  [API POST]
public class PlayereventsV1DeleteResponseRequest
{
    public DCFIICOBPME EDJCBOJCAGB;  // wrapper
}

// api/playerevents/v1/report  [API POST]
public class PlayereventsV1ReportRequest
{
    public DHGJGCOMKOM GMCBCPANNKI;  // wrapper
}

// api/playerevents/v1/respond  [API POST]
public class PlayereventsV1RespondRequest
{
    public DCFIICOBPME EDJCBOJCAGB;  // wrapper
}

// api/playerevents/v2  [API POST]
public class PlayereventsV2Request
{
    public long? JPKIIMPIPPD;  // wrapper
    public long? PGFABDBHHMJ;  // wrapper
    public List<string> FABFGKGHPAH;  // wrapper
    public DateTime HLGGLCGNNLC;  // wrapper
    public DateTime DGIHAKEODBF;  // wrapper
    public EIOKKEGNICB HHPDLCPIMKC;  // wrapper
    public IEKKAGLGFFC FHNODGDNAPK;  // wrapper
    public IEKKAGLGFFC NDKHEDBKALL;  // wrapper
}

// api/playerevents/v2/{eventId}  [API POST]
public class PlayereventsV2EventIdRequest
{
    public long? JPKIIMPIPPD;  // wrapper
    public List<string> FABFGKGHPAH;  // wrapper
    public DateTime HLGGLCGNNLC;  // wrapper
    public DateTime DGIHAKEODBF;  // wrapper
    public EIOKKEGNICB HHPDLCPIMKC;  // wrapper
    public long? PGFABDBHHMJ;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public EIOKKEGNICB HHPDLCPIMKC;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? PGFABDBHHMJ;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public IEKKAGLGFFC FHNODGDNAPK;  // wrapper
    public IEKKAGLGFFC CPDNKAMLOLB;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? JPKIIMPIPPD;  // wrapper
}

// api/playerevents/v2/{eventId}/tags  [API PUT]
public class PlayereventsV2EventIdTagsRequest
{
    public List<string> FABFGKGHPAH;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime HLGGLCGNNLC;  // wrapper
    public DateTime DGIHAKEODBF;  // wrapper
}

// api/playerwarnings  [API POST]
public class PlayerwarningsRequest
{
    public DHGJGCOMKOM GMCBCPANNKI;  // wrapper
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
    public Guid GMECBMCDKIL;  // wrapper
    public object PurchaseOfferId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedAmount;  // candidate
}

// api/roomcurrencies/v1/awardCurrency/bulk  [Econ POST]
public class RoomcurrenciesV1AwardCurrencyBulkRequest
{
    public List<DNOJPDPKJIP> LABEJABFOAA;  // wrapper
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
    public Guid IABGJMIMBOM;  // wrapper
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
    public Guid IABGJMIMBOM;  // wrapper
    public long? ENENGFDNBAM;  // wrapper
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
    public object Description;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid GMECBMCDKIL;  // wrapper
    public long? LBBHGLNPMEA;  // wrapper
    public long? OOBPCEOCDNP;  // wrapper
    public int? HDAJNMPBNIL;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [Econ PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> PEEIAPNNFMK;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [Econ POST]
public class RoomkeysV1CreateRequest
{
    public Guid? IMCEDMPPLNC;  // wrapper
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
    public DHGJGCOMKOM GMCBCPANNKI;  // wrapper
    public long? LMDLMAIPIHP;  // wrapper
    public object ReportCategory;  // candidate
    public object RoomId;  // candidate
    public object RoomKeyId;  // candidate
    public object Details;  // candidate
}

// api/royale/v2/matchcomplete  [Econ POST]
public class RoyaleV2MatchcompleteRequest
{
    public MatchCompleteStats JNFGHPPGMKB;  // wrapper
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
    public Guid FOMAFDMIBPO;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [Econ POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid BJEKJHFJKFC;  // wrapper
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
    public List<KLIOJNLDOAE> JODHACJDLAK;  // wrapper
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
    public OBLJILLKKJC MMFMIFLMKOL;  // wrapper
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public int? pid;  // wrapper
}

