// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 272 (plus referenced enums)

// --------------------------------------------------------------------------
// ABFCMBADJKP
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.Econ]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.Econ]
public class ABFCMBADJKP
{
    public int <DCGCFHEJHJN>k__BackingField;    // 0x0x10
    public int <ACMMEIDEIEF>k__BackingField;    // 0x0x14
    public float <MJNCGGIELFF>k__BackingField;    // 0x0x18
    public float <OFGIGNFELLM>k__BackingField;    // 0x0x1C
    public bool <IBEANELLEGP>k__BackingField;    // 0x0x20
    public bool <GNPMHBFJDFL>k__BackingField;    // 0x0x21
    public bool <MDMCANMODAE>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// ABMNDBIGKHO
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{jKEBOOMJBEM}/{mPCABBDOKLF}   [Service.Econ]
public class ABMNDBIGKHO
{
    public CPLLFGEHMIB <HJBJMKIMCIM>k__BackingField;    // 0x0x10
    public ICEBHHEFLBG <EBGGCNHNDBJ>k__BackingField;    // 0x0x14
    public int <KCMFJOONOMJ>k__BackingField;    // 0x0x18
    public int <ADHCMNLBLEK>k__BackingField;    // 0x0x1C
    public int <KLMFAJINNIN>k__BackingField;    // 0x0x20
    public KPJDMOFFENF <GEFDHMHODFD>k__BackingField;    // 0x0x24
    public bool <OMDNKICPEOA>k__BackingField;    // 0x0x28
    public float <MEMILFCCHEP>k__BackingField;    // 0x0x2C
    public int <OGKJFODDCDI>k__BackingField;    // 0x0x30
    public bool <CDGOEFOGIFC>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// ADNHONACCKG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ADNHONACCKG
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// AEEOBFBBBFO
//   REQUEST  POST   api/playerevents/v1/report   [Service.API]
public class AEEOBFBBBFO
{
    public KBGOCEGMGOO <PKGNDIFLHCK>k__BackingField;    // 0x0x10
    public long <HDHDJJCOMGJ>k__BackingField;    // 0x0x18
    public string <KALNGIGHGPH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AJGCGHPLGNO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AJGCGHPLGNO
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
// AKAFHHEDMEG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AKAFHHEDMEG
{
    PurchasableItem = 0,
    CustomAvatarItem = 1,
}

// --------------------------------------------------------------------------
// ALAKAAHDKEN
//   (not directly referenced by a detected call)
public class ALAKAAHDKEN
{
    public int <EBFGGFHHDNE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// ALNKEGAOCKD
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/checklist/v1/complete   [Service.Econ]
//   RESPONSE POST   api/progressionEvents   [Service.API]
//   RESPONSE POST   api/progressionEvents/collect/{mCDJNNMKHIL}/{dAJNBNMFEMA}   [Service.API]
public class ALNKEGAOCKD
{
    public long? <GPGDOAJDPKG>k__BackingField;    // 0x0x10
    public int <IEFLHMJFAAE>k__BackingField;    // 0x0x20
    public int? <NFAOMNLGKMF>k__BackingField;    // 0x0x24
    public string <CCLHIHMACHJ>k__BackingField;    // 0x0x30
    public DJPAOKFHDAB? <EPPBLKMEDAK>k__BackingField;    // 0x0x38
    public string <IDHOBDBMNIE>k__BackingField;    // 0x0x40
    public Guid? <HCMOHFOPMIJ>k__BackingField;    // 0x0x48
    public string <ILKAMAMEDEO>k__BackingField;    // 0x0x60
    public string <ILKMDBKBFMP>k__BackingField;    // 0x0x68
    public CPLLFGEHMIB <HJBJMKIMCIM>k__BackingField;    // 0x0x70
    public int <EMGGMEJJFJA>k__BackingField;    // 0x0x74
    public int <MFGMPGHHCHI>k__BackingField;    // 0x0x78
    public KCJNALNJGNJ <BBPHMIFIHIG>k__BackingField;    // 0x0x7C
    public ADNHONACCKG <IFILOPDJNEO>k__BackingField;    // 0x0x80
    public string <JEPDBNNOGNM>k__BackingField;    // 0x0x88
    public string <CKAPFBLACBP>k__BackingField;    // 0x0x90
    public bool <NMIOEMGMAIG>k__BackingField;    // 0x0x98
    public FHEHDDAJNCC <KIFBAFEANDE>k__BackingField;    // 0x0x9C
    public LPFMLMENMHJ <EHAFHGOGHKL>k__BackingField;    // 0x0xA0
    public PKIHMKKKDAH? <DEKOGOAMBLJ>k__BackingField;    // 0x0xA4
    public bool <PHIFCLCIAPN>k__BackingField;    // 0x0xAC
    public bool <LBNLKPACJJM>k__BackingField;    // 0x0xAD
    public string <NNGLLLGGOCP>k__BackingField;    // 0x0xB0
    public string <NABDMADCLEC>k__BackingField;    // 0x0xB8
    public bool <GJOFGBOIBKH>k__BackingField;    // 0x0xC0
    public bool OPPLEKKECGL;    // 0x0xC1
}

// --------------------------------------------------------------------------
// AMLJAOCAJEO
//   (not directly referenced by a detected call)
public class AMLJAOCAJEO
{
    public Guid <LFDGOEPAEIM>k__BackingField;    // 0x0x10
    public long <LOAMABPIJJG>k__BackingField;    // 0x0x20
    public string <MDMLKLKCKHN>k__BackingField;    // 0x0x28
    public string <OFOAJDEONEL>k__BackingField;    // 0x0x30
    public string <LIFOPKKBMIJ>k__BackingField;    // 0x0x38
    public long <AGOHLGKGGLG>k__BackingField;    // 0x0x40
    public Guid? <LECMNMLJCCK>k__BackingField;    // 0x0x48
    public DateTime <GCCLOGOLNMM>k__BackingField;    // 0x0x60
    public int <EPEPFBAHLGH>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// ANLLJDNMKHE
//   (not directly referenced by a detected call)
public class ANLLJDNMKHE
{
    public Guid <NEBGBLLFDKO>k__BackingField;    // 0x0x10
    public Guid <BODFCALCJOJ>k__BackingField;    // 0x0x20
    public DateTime <FMKJEPHKGMC>k__BackingField;    // 0x0x30
    public List<KNCBLIHIANP> <NCBEBNJBBBI>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// BAFAHHEIMPO
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class BAFAHHEIMPO
{
    public long <HDHDJJCOMGJ>k__BackingField;    // 0x0x10
    public int <GBIBKMLLJOG>k__BackingField;    // 0x0x18
    public long <LOAMABPIJJG>k__BackingField;    // 0x0x20
    public long? <GGHBDBCDMHO>k__BackingField;    // 0x0x28
    public long? <AKANPMHOBDC>k__BackingField;    // 0x0x38
    public string <MDMLKLKCKHN>k__BackingField;    // 0x0x48
    public string <OFOAJDEONEL>k__BackingField;    // 0x0x50
    public string <LIFOPKKBMIJ>k__BackingField;    // 0x0x58
    public DateTime <FAHAJICNGMA>k__BackingField;    // 0x0x60
    public DateTime <CDNOBJOGCEK>k__BackingField;    // 0x0x68
    public int <PEGCANKJOAM>k__BackingField;    // 0x0x70
    public CFDDBKBJOOK <JKICJMJPEIC>k__BackingField;    // 0x0x74
    public bool <AHACKJPNIAL>k__BackingField;    // 0x0x78
    public bool <CNBAGPCFABE>k__BackingField;    // 0x0x79
    public PMOMGBEMEBI <PAOPOJJIIIK>k__BackingField;    // 0x0x7C
    public PMOMGBEMEBI <IAAGPKGIMEA>k__BackingField;    // 0x0x80
    public long? <MJFHJMGGJON>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// BBGNFOFFJHH
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class BBGNFOFFJHH
{
    public EDEONIPOBIH <DGBJLEAHDGL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// BEHDDPIJONH
//   (not directly referenced by a detected call)
public class BEHDDPIJONH
{
    public int <CALMACCKGCO>k__BackingField;    // 0x0x10
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
    public Stream HeaderStream;    // 0x0x80
    public Stream BodyStream;    // 0x0x88
    public List<ValueTuple<byte[], int>> streamedFragments;    // 0x0x90
    public object SyncRoot;    // 0x0x98
    public byte[] fragmentBuffer;    // 0x0xA0
    public int fragmentBufferDataLength;    // 0x0xA8
    public Stream cacheStream;    // 0x0xB0
    public int allFragmentSize;    // 0x0xB8
    public BufferPoolMemoryStream decompressorInputStream;    // 0x0xC0
    public BufferPoolMemoryStream decompressorOutputStream;    // 0x0xC8
    public GZipStream decompressorGZipStream;    // 0x0xD0
    public AutoResetEvent fragmentWaitEvent;    // 0x0xD8
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
    public WebSocket <WebSocket>k__BackingField;    // 0x0xE0
    public Action<WebSocketResponse, string> OnText;    // 0x0xE8
    public Action<WebSocketResponse, byte[]> OnBinary;    // 0x0xF0
    public Action<WebSocketResponse, WebSocketFrameReader> OnIncompleteFrame;    // 0x0xF8
    public Action<WebSocketResponse, ushort, string> OnClosed;    // 0x0x100
    public TimeSpan <PingFrequnecy>k__BackingField;    // 0x0x108
    public ushort <MaxFragmentSize>k__BackingField;    // 0x0x110
    public int _bufferedAmount;    // 0x0x114
    public int <Latency>k__BackingField;    // 0x0x118
    public List<WebSocketFrameReader> IncompleteFrames;    // 0x0x120
    public List<WebSocketFrameReader> CompletedFrames;    // 0x0x128
    public List<WebSocketFrameReader> frameCache;    // 0x0x130
    public WebSocketFrameReader CloseFrame;    // 0x0x138
    public object FrameLock;    // 0x0x158
    public object SendLock;    // 0x0x160
    public List<WebSocketFrame> unsentFrames;    // 0x0x168
    public AutoResetEvent newFrameSignal;    // 0x0x170
    public bool sendThreadCreated;    // 0x0x178
    public bool closeSent;    // 0x0x179
    public bool closed;    // 0x0x17A
    public DateTime lastPing;    // 0x0x180
    public DateTime lastMessage;    // 0x0x188
    public CircularBuffer<int> rtts;    // 0x0x190
}

// --------------------------------------------------------------------------
// CCFJIHGOINH
//   REQUEST  POST   api/messages/v1/sendMultiple   [Service.API]
public class CCFJIHGOINH
{
    public List<long> <DDMJNBOELFC>k__BackingField;    // 0x0x10
    public KMBELCEBGMB <FOJLKCJMIFM>k__BackingField;    // 0x0x18
    public string <CENLFIKBGEI>k__BackingField;    // 0x0x20
    public long? <LOAMABPIJJG>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// CFDDBKBJOOK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CFDDBKBJOOK
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// CJJCNHKMNOJ
//   RESPONSE PUT    api/roomconsumables   [Service.Econ]
public class CJJCNHKMNOJ
{
    public AJGCGHPLGNO <DEAIGLHJNMA>k__BackingField;    // 0x0x10
    public ENFNIIKEADP <DPOLFLMLCAD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CPBOPMGNMMO
//   (not directly referenced by a detected call)
public class CPBOPMGNMMO
{
    public long <AGOHLGKGGLG>k__BackingField;    // 0x0x10
    public Guid? <NHDLLLDBOGP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CPLLFGEHMIB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CPLLFGEHMIB
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
    RoomieCredits = 500,
}

// --------------------------------------------------------------------------
// DBADGPAGOMC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DBADGPAGOMC
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// DCGGFLJBPLO
//   REQUEST  POST   api/equipment/v1/update   [Service.Econ]
public class DCGGFLJBPLO
{
    public string <CLDCIGMECJJ>k__BackingField;    // 0x0x10
    public string <BCJLBEOOFLE>k__BackingField;    // 0x0x18
    public string <DOFFNLPDFMH>k__BackingField;    // 0x0x20
    public string <LAMHMHIGOLC>k__BackingField;    // 0x0x28
    public ADNHONACCKG <FJLAMDCMPIM>k__BackingField;    // 0x0x30
    public string <OLKLEBGHKNM>k__BackingField;    // 0x0x38
    public bool EELIACMAEDC;    // 0x0x40
    public bool <MDMCANMODAE>k__BackingField;    // 0x0x41
}

// --------------------------------------------------------------------------
// DCKEHMOPCJJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DCKEHMOPCJJ
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
// DGKOJLBPBMJ
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.Econ]
public class DGKOJLBPBMJ
{
    public int <ACMMEIDEIEF>k__BackingField;    // 0x0x10
    public bool <IBEANELLEGP>k__BackingField;    // 0x0x14
    public DateTime <LAEJBALCNMJ>k__BackingField;    // 0x0x18
    public bool <JJPHPCAJLHE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DIGPIEFAPJA
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.Econ]
//   RESPONSE POST   api/avatar/v1/lockeditems/bulk   [Service.Econ]
//   RESPONSE GET    api/avatar/v4/items   [Service.Econ]
public class DIGPIEFAPJA
{
    public DJPAOKFHDAB <EPPBLKMEDAK>k__BackingField;    // 0x0x10
    public string <AHKKADHHLJF>k__BackingField;    // 0x0x18
    public string <DOFFNLPDFMH>k__BackingField;    // 0x0x20
    public string <LAMHMHIGOLC>k__BackingField;    // 0x0x28
    public ADNHONACCKG <FJLAMDCMPIM>k__BackingField;    // 0x0x30
    public string <CJJBAKPKLDJ>k__BackingField;    // 0x0x38
    public int <DGDEHJCMKPJ>k__BackingField;    // 0x0x40
    public bool <AKPMBKLNACI>k__BackingField;    // 0x0x44
    public string <FDILGNKPEFG>k__BackingField;    // 0x0x48
    public DateTime <MOAGDKLKGBJ>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// DJPAOKFHDAB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DJPAOKFHDAB
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// EDEONIPOBIH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EDEONIPOBIH
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
// EDKBGKHBCOG
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class EDKBGKHBCOG
{
    public Dictionary<Guid, PHHDLKLONNA> <JMLHCPDNADE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// EEFAOGHHCJG
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class EEFAOGHHCJG
{
    public KBGOCEGMGOO <PKGNDIFLHCK>k__BackingField;    // 0x0x10
    public int <HCOGINMLNCF>k__BackingField;    // 0x0x14
    public long <FKJNHIHJFOK>k__BackingField;    // 0x0x18
    public bool <JJGBPNPBIOJ>k__BackingField;    // 0x0x20
    public string <LMDHAOIPMCE>k__BackingField;    // 0x0x28
    public int? <OHPDMEIGDGH>k__BackingField;    // 0x0x30
    public bool <PNCMKGMECDM>k__BackingField;    // 0x0x38
    public bool <HKGAKMBLHFG>k__BackingField;    // 0x0x39
    public bool <GEIPJIKODBN>k__BackingField;    // 0x0x3A
    public bool <CLBNMPKGNKA>k__BackingField;    // 0x0x3B
    public string <MCIGDACKJDG>k__BackingField;    // 0x0x40
    public DateTime? <CLIDHGMEFPD>k__BackingField;    // 0x0x48
    public string <GPDGLEJALJA>k__BackingField;    // 0x0x58
    public bool <KBFBJOABDNI>k__BackingField;    // 0x0x60
    public string <LINCEBFBHCD>k__BackingField;    // 0x0x68
    public string <JBBEHCHONPJ>k__BackingField;    // 0x0x70
    public float <GLPHOGPPFBF>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// EEHANMIHBIO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EEHANMIHBIO
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
// EEIAMMGFDDA
//   (not directly referenced by a detected call)
public class EEIAMMGFDDA
{
    public EEHANMIHBIO NDICCADLBAJ;    // 0x0x10
    public int FBALNHPCGGD;    // 0x0x14
}

// --------------------------------------------------------------------------
// EFKFAKCOGHP
//   REQUEST  POST   api/playerevents/v2   [Service.API]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.API]
public class EFKFAKCOGHP
{
    public long <LOAMABPIJJG>k__BackingField;    // 0x0x10
    public long? <GGHBDBCDMHO>k__BackingField;    // 0x0x18
    public long? <AKANPMHOBDC>k__BackingField;    // 0x0x28
    public string <MDMLKLKCKHN>k__BackingField;    // 0x0x38
    public string <OFOAJDEONEL>k__BackingField;    // 0x0x40
    public List<string> <GMMCELAFOCC>k__BackingField;    // 0x0x48
    public string <LIFOPKKBMIJ>k__BackingField;    // 0x0x50
    public DateTime <FAHAJICNGMA>k__BackingField;    // 0x0x58
    public DateTime <CDNOBJOGCEK>k__BackingField;    // 0x0x60
    public CFDDBKBJOOK <JKICJMJPEIC>k__BackingField;    // 0x0x68
    public bool <AHACKJPNIAL>k__BackingField;    // 0x0x6C
    public bool <CNBAGPCFABE>k__BackingField;    // 0x0x6D
    public PMOMGBEMEBI <PAOPOJJIIIK>k__BackingField;    // 0x0x70
    public PMOMGBEMEBI <IAAGPKGIMEA>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// EIPLENACPCD
//   (not directly referenced by a detected call)
public class EIPLENACPCD
{
    public bool <CNABECHHHBD>k__BackingField;    // 0x0x10
    public LPFMLMENMHJ <DAHMMCHPFAB>k__BackingField;    // 0x0x14
    public int <NENNOMFGABD>k__BackingField;    // 0x0x18
    public DateTime <GCCLOGOLNMM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EJIHJOENKJD
// base   : NJIOAAFNCPE
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/season/{eHCAMONKEKN}   [Service.Econ]
public class EJIHJOENKJD : NJIOAAFNCPE
{
    public int <BDGBNJKJJFA>k__BackingField;    // 0x0x30
    public string <MDMLKLKCKHN>k__BackingField;    // 0x0x38
    public DateTime <FMKJEPHKGMC>k__BackingField;    // 0x0x40
    public DateTime <AGCIJGCKFEO>k__BackingField;    // 0x0x48
    public CPLLFGEHMIB <HJBJMKIMCIM>k__BackingField;    // 0x0x50
    public LJKNIBLNFPC <DMFCBGFEHCC>k__BackingField;    // 0x0x58
    public List<HOKBECNNAKL> <MIBEBHAHEPD>k__BackingField;    // 0x0x60
    public EIPLENACPCD <ANOBDIFMOMH>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// EMIPHPEOPMO
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class EMIPHPEOPMO : ValueType
{
    public NANMHMIBICI BOOAIGDDPAD;    // 0x0x0
    public MKELHNOGKHJ PKIFDDOIJAB;    // 0x0x10
    public Guid BEKGCCGIBNC;    // 0x0x20
}

// --------------------------------------------------------------------------
// ENFNIIKEADP
//   (not directly referenced by a detected call)
public class ENFNIIKEADP
{
    public Guid <LFDGOEPAEIM>k__BackingField;    // 0x0x10
    public int <EDAAMGNFHNO>k__BackingField;    // 0x0x20
    public int <FOPJPMNMJLJ>k__BackingField;    // 0x0x24
    public Guid <IJMMNKGOOMN>k__BackingField;    // 0x0x28
    public DateTime <GCCLOGOLNMM>k__BackingField;    // 0x0x38
    public AMLJAOCAJEO <HHNACLMOJFI>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// EPAMKPAKFJF
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Auth]
public class EPAMKPAKFJF
{
    public Guid <GPLPFCEFHFP>k__BackingField;    // 0x0x10
    public string <MDMLKLKCKHN>k__BackingField;    // 0x0x20
    public string <LIFOPKKBMIJ>k__BackingField;    // 0x0x28
    public DateTime <FMKJEPHKGMC>k__BackingField;    // 0x0x30
    public DateTime? <MGJPMGPNDOC>k__BackingField;    // 0x0x38
    public List<ANLLJDNMKHE> <NNPPLNGHFFB>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// EPJMHJLFJIO
//   REQUEST  POST   api/relationships/v2/updateVoiceVolume   [Service.API]
public class EPJMHJLFJIO
{
    public int <IEFLHMJFAAE>k__BackingField;    // 0x0x10
    public byte <HDANDOEEDOF>k__BackingField;    // 0x0x14
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
// FAOJBHJNHHE
//   RESPONSE POST   api/PlayerReporting/v1/roomModKick   [Service.API]
//   RESPONSE POST   api/chatreport/createChatReport   [Service.API]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.Econ]
//   RESPONSE POST   api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{aIGIABENOBD}/appeal   [Service.API]
//   RESPONSE PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.API]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.Econ]
//   RESPONSE POST   api/images/v2/modifyaccessibility   [Service.API]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.Econ]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.Econ]
//   RESPONSE DELETE api/keepsakes   [Service.API]
//   RESPONSE DELETE api/keepsakes/{oEDJPEFAHHO}   [Service.API]
//   RESPONSE POST   api/makerai/activatefreetrial   [Service.API]
//   RESPONSE GET    api/makerai/checkfreetrialeligibility   [Service.Econ]
//   RESPONSE POST   api/playerwarnings   [Service.API]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.Econ]
public class FAOJBHJNHHE
{
    public bool <HAHMHJBMAJJ>k__BackingField;    // 0x0x10
    public string <FCPEHADCMMC>k__BackingField;    // 0x0x18
    public string <NLAHGJJFCJF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// FBHLNBCDOJP
//   RESPONSE GET    api/config/v1/azurespeech   [Service.API]
public class FBHLNBCDOJP
{
    public bool <BEJKJDPLDAH>k__BackingField;    // 0x0x10
    public string <NEMCKJPEEDJ>k__BackingField;    // 0x0x18
    public string <EFLIGNGKHCO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// FHEHDDAJNCC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FHEHDDAJNCC
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
// FPHMHBOMDBN
//   REQUEST  PUT    api/roomconsumables   [Service.Econ]
public class FPHMHBOMDBN
{
    public Guid? <NFAJEMJNJON>k__BackingField;    // 0x0x10
    public Guid <DMABPNLGEGE>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// GAMFCKILMFL
//   REQUEST  PUT    api/customAvatarItems   [Service.API]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
public class GAMFCKILMFL
{
    public string <MDMLKLKCKHN>k__BackingField;    // 0x0x10
    public string <OFOAJDEONEL>k__BackingField;    // 0x0x18
    public int? <AGOHLGKGGLG>k__BackingField;    // 0x0x20
    public NGHFCMNNGJM? <JKICJMJPEIC>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// GIKLGCAKHOE
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class GIKLGCAKHOE
{
    public FPHMHBOMDBN <PJAMEJFDAPJ>k__BackingField;    // 0x0x10
    public CPBOPMGNMMO <KABNKMEELNL>k__BackingField;    // 0x0x18
    public int <NAJLBNKMGJJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GJHHANOJDDE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GJHHANOJDDE
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// GLMBPKDMOFE
// base   : BAFAHHEIMPO
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class GLMBPKDMOFE : BAFAHHEIMPO
{
    public List<NJKCCNFEAPN> <GMMCELAFOCC>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// GMGCIFPDJLA
// base   : LEPAKJEPHDM
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class GMGCIFPDJLA : LEPAKJEPHDM
{
    public MEELCAECJGM? <MHGFIMBFMPG>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <MEFLIBNCJBM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GPIDDFFKPOF
//   REQUEST  POST   api/customAvatarItems   [Service.API]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
public class GPIDDFFKPOF
{
    public MEIOCJPJGDJ <PKGNDIFLHCK>k__BackingField;    // 0x0x10
    public string <KALNGIGHGPH>k__BackingField;    // 0x0x18
    public int? <LCODJCLDAKD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GPPLNOMAFEM
//   (not directly referenced by a detected call)
public class GPPLNOMAFEM
{
    public BAFAHHEIMPO <POAHFOFEGMD>k__BackingField;    // 0x0x10
    public MPLEDICCGLC <IMOAOACMHBI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HIGPPMMEOEO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HIGPPMMEOEO
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// HJMOPGCPGEL
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class HJMOPGCPGEL
{
    public List<KGEOJAINENB> <DOIFPCLHLLG>k__BackingField;    // 0x0x10
    public EDEONIPOBIH <DGBJLEAHDGL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HLJBBAEPCHE
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.API]
public class HLJBBAEPCHE
{
    public int <JAKMECGIDMJ>k__BackingField;    // 0x0x10
    public int? <HNGBFKMMKDB>k__BackingField;    // 0x0x14
    public string <IDPDAPCGGGL>k__BackingField;    // 0x0x20
    public string <NLOKNIJEGCO>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// HOCMNDGLKGN
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class HOCMNDGLKGN
{
    public int? <JJHKOHKIJCG>k__BackingField;    // 0x0x10
    public string <PLANGCIENKM>k__BackingField;    // 0x0x18
    public string <IJMHDIBHHFB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HOKBECNNAKL
// base   : LJKNIBLNFPC
//   (not directly referenced by a detected call)
public class HOKBECNNAKL : LJKNIBLNFPC
{
    public int <NDHAMJHOLNE>k__BackingField;    // 0x0x68
    public List<LCFBIFNOCND> <FNGEPDPCPAE>k__BackingField;    // 0x0x70
    public List<LCFBIFNOCND> <FIJDDOMJICM>k__BackingField;    // 0x0x78
    public List<LCFBIFNOCND> <LNPJHJEFAIJ>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// ICEBHHEFLBG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ICEBHHEFLBG
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
// IEGGJIEOANE
//   RESPONSE GET    api/testcasemanagement/   [Service.API]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{pPPFBKMGIMA}   [Service.API]
public class IEGGJIEOANE
{
    public uint <GPGDOAJDPKG>k__BackingField;    // 0x0x10
    public uint? <JBFMJLJEDOG>k__BackingField;    // 0x0x14
    public string <MDMLKLKCKHN>k__BackingField;    // 0x0x20
    public string <OFOAJDEONEL>k__BackingField;    // 0x0x28
    public DateTime <LKJEMEEAADI>k__BackingField;    // 0x0x30
    public DateTime? <IEBHADGEKJK>k__BackingField;    // 0x0x38
    public bool <KGBMFKOFCJL>k__BackingField;    // 0x0x48
    public List<ODEGDKPJABI> <IJCGNAOAKLB>k__BackingField;    // 0x0x50
    public List<string> <GMMCELAFOCC>k__BackingField;    // 0x0x58
    public int <IOLJOCMKECJ>k__BackingField;    // 0x0x60
    public int <JONMNFMENLM>k__BackingField;    // 0x0x64
    public int <LAEEKIBOPON>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// IJCMJNEFHHD
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
public class IJCMJNEFHHD
{
    public List<string> <PGAECMPCPAJ>k__BackingField;    // 0x0x10
    public List<string> <BFPELFKIOAM>k__BackingField;    // 0x0x18
    public List<string> <JPMKBEGCHHG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ILBNEDAPMCF
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.Econ]
public class ILBNEDAPMCF
{
    public long <NKMFIMKNLJJ>k__BackingField;    // 0x0x10
    public int <EDAAMGNFHNO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ILOECOCCBIG
//   (not directly referenced by a detected call)
public class ILOECOCCBIG
{
    public long <NKMFIMKNLJJ>k__BackingField;    // 0x0x10
    public Guid <LDHEGJPGKNI>k__BackingField;    // 0x0x18
    public long <LOAMABPIJJG>k__BackingField;    // 0x0x28
    public string <MDMLKLKCKHN>k__BackingField;    // 0x0x30
    public string <OFOAJDEONEL>k__BackingField;    // 0x0x38
    public int <AGOHLGKGGLG>k__BackingField;    // 0x0x40
    public Guid? <LECMNMLJCCK>k__BackingField;    // 0x0x44
    public DateTime <MOAGDKLKGBJ>k__BackingField;    // 0x0x58
    public string <LIFOPKKBMIJ>k__BackingField;    // 0x0x60
    public HIGPPMMEOEO <FOJLKCJMIFM>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// IPIPKPIPJKF
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.Econ]
public class IPIPKPIPJKF
{
    public int <HCOGINMLNCF>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JBADHBGGEII
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JBADHBGGEII
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// JBPKFCGAFMN
//   (not directly referenced by a detected call)
public class JBPKFCGAFMN
{
    public AKAFHHEDMEG <FOJLKCJMIFM>k__BackingField;    // 0x0x10
    public int? <DKPBIBLFACG>k__BackingField;    // 0x0x14
    public Guid? <KOKLEPLDBJE>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// JCBFHEEKKKD
//   (not directly referenced by a detected call)
public class JCBFHEEKKKD
{
    public DateTime <MOAGDKLKGBJ>k__BackingField;    // 0x0x10
    public string <NPHJFHDPEML>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JDFBEGFJJDF
//   RESPONSE GET    api/config/v2   [Service.API]
public class JDFBEGFJJDF
{
    public Dictionary<int, int> <JMILBCJJLON>k__BackingField;    // 0x0x10
    public List<KNAEEOINDDP> <AELBKNNPHGM>k__BackingField;    // 0x0x18
    public EEIAMMGFDDA[][] <KGLOOJKLDGD>k__BackingField;    // 0x0x20
    public BEHDDPIJONH <KNOKMLOGIJB>k__BackingField;    // 0x0x28
    public NJKBPJHMAAK <OHMPCHPGCIF>k__BackingField;    // 0x0x30
    public LMIIHNEOGMP <AHNANDEJMAG>k__BackingField;    // 0x0x38
    public ALAKAAHDKEN <NIFJLGGGNPE>k__BackingField;    // 0x0x40
    public LIOPGFPIGEA <NABJHKIHNIF>k__BackingField;    // 0x0x48
    public string <HBIMHNMPKMN>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// JDOHKGHKOMI
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.Econ]
public class JDOHKGHKOMI
{
    public List<int> <ECICPAIGGEC>k__BackingField;    // 0x0x10
    public string <KBCLDGPHKAF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JHBELHCLHPH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JHBELHCLHPH
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// JKOGBHNADMP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JKOGBHNADMP
{
    RoomKey = 0,
    RoomConsumable = 1,
    RoomCurrencyPurchaseOffer = 2,
    CustomAvatarItem = 3,
    StoreUGCAvatarItem = 4,
    UNDEFINED = 5,
}

// --------------------------------------------------------------------------
// JNJCDLBNLCE
//   REQUEST  POST   api/roomcurrencies/v1/awardCurrency/bulk   [Service.Econ]
public class JNJCDLBNLCE
{
    public Guid <NHDLLLDBOGP>k__BackingField;    // 0x0x10
    public int <MNBKOAGOKMA>k__BackingField;    // 0x0x20
    public long <GHADIOHFILF>k__BackingField;    // 0x0x28
    public Guid <IPGKMBNADBC>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// JPHLLBLANHP
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.API]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
//   RESPONSE POST   api/relationships/v2/updateVoiceVolume   [Service.API]
public class JPHLLBLANHP
{
    public int <GKPNLDKHHEG>k__BackingField;    // 0x0x10
    public KGMAIKCICCO <FOJLKCJMIFM>k__BackingField;    // 0x0x14
    public FPKPLAKKBIG <PEBJCLPAINN>k__BackingField;    // 0x0x18
    public FPKPLAKKBIG <CFBMHBHHCHJ>k__BackingField;    // 0x0x1C
    public FPKPLAKKBIG <HDIJGAJPHEI>k__BackingField;    // 0x0x20
    public byte? <HDANDOEEDOF>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// KCJNALNJGNJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KCJNALNJGNJ
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
    GameRewards_A = 53,
    GameRewards_B = 54,
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
    MyLittleMonsters = 12200,
    RunTheBlock = 12300,
    RROStorefront_ToBeNamed_2 = 12400,
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
// KFMKHJEOHBM
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.API]
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{mCDJNNMKHIL}   [Service.API]
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
public class KFMKHJEOHBM
{
    public GLMBPKDMOFE <POAHFOFEGMD>k__BackingField;    // 0x0x10
    public EDEONIPOBIH <DGBJLEAHDGL>k__BackingField;    // 0x0x18
    public PKEKEIJGFCO <GOIIFPFOJFK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KGCICJFGEMD
//   REQUEST  POST   api/roomkeys/v1/awardbulk   [Service.Econ]
public class KGCICJFGEMD
{
    public long <NKMFIMKNLJJ>k__BackingField;    // 0x0x10
    public int <EDAAMGNFHNO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KGEOJAINENB
//   (not directly referenced by a detected call)
public class KGEOJAINENB
{
    public int <CJNFDGECLOD>k__BackingField;    // 0x0x10
    public EDEONIPOBIH <DGBJLEAHDGL>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// KHHFKBAIHHI
// base   : KLNJBOMAAMI`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.API]
public class KHHFKBAIHHI
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// KIHKGGNJMNO
//   REQUEST  POST   api/roomcurrencies   [Service.Econ]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.Econ]
public class KIHKGGNJMNO
{
    public Guid <IPGKMBNADBC>k__BackingField;    // 0x0x10
    public long <DLEILGKCIDD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KNCBLIHIANP
//   (not directly referenced by a detected call)
public class KNCBLIHIANP
{
    public int <GFHKDPPOHFA>k__BackingField;    // 0x0x10
    public string <DOFFNLPDFMH>k__BackingField;    // 0x0x18
    public string <LAMHMHIGOLC>k__BackingField;    // 0x0x20
    public string <CJJBAKPKLDJ>k__BackingField;    // 0x0x28
    public string <CCLHIHMACHJ>k__BackingField;    // 0x0x30
    public EMIPHPEOPMO? <GLOMAGIFPJE>k__BackingField;    // 0x0x38
    public string <IDHOBDBMNIE>k__BackingField;    // 0x0x70
    public Guid? <HCMOHFOPMIJ>k__BackingField;    // 0x0x78
    public DJPAOKFHDAB? <EPPBLKMEDAK>k__BackingField;    // 0x0x8C
    public string <ILKAMAMEDEO>k__BackingField;    // 0x0x98
    public string <ILKMDBKBFMP>k__BackingField;    // 0x0xA0
    public bool <BMHFLNLEFJF>k__BackingField;    // 0x0xA8
    public bool <NJILBOIALAC>k__BackingField;    // 0x0xA9
    public bool <PGHGIMJOFNK>k__BackingField;    // 0x0xAA
    public ADNHONACCKG <FJLAMDCMPIM>k__BackingField;    // 0x0xAC
    public CPLLFGEHMIB <HJBJMKIMCIM>k__BackingField;    // 0x0xB0
    public int <EMGGMEJJFJA>k__BackingField;    // 0x0xB4
    public OPLMDJHILKC <HCMAEKPMHGF>k__BackingField;    // 0x0xB8
    public KCJNALNJGNJ <GKLPMHLGJAI>k__BackingField;    // 0x0xBC
    public int? <ADAOCABNPKB>k__BackingField;    // 0x0xC0
    public string <MOOPHEHFDAF>k__BackingField;    // 0x0xC8
    public int? <DGDEHJCMKPJ>k__BackingField;    // 0x0xD0
    public int? <MJIGFCPBNNI>k__BackingField;    // 0x0xD8
    public string <OLKLEBGHKNM>k__BackingField;    // 0x0xE0
}

// --------------------------------------------------------------------------
// KPJDMOFFENF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KPJDMOFFENF
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// LACJIEMAPLB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LACJIEMAPLB
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// LBLIIJLBMEF
//   (not directly referenced by a detected call)
public class LBLIIJLBMEF
{
    public int <JLOCHIFNBHK>k__BackingField;    // 0x0x10
    public DateTime? <EHKLFDGEPIC>k__BackingField;    // 0x0x18
    public DateTime? <EBCHHLCPLKH>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// LCFBIFNOCND
//   (not directly referenced by a detected call)
public class LCFBIFNOCND
{
    public bool <AJLFOKFEKGJ>k__BackingField;    // 0x0x10
    public KNCBLIHIANP <MDDEGJOBLFM>k__BackingField;    // 0x0x18
    public float <MEMOALOACBH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LDKKEAPOACK
// base   : LEPAKJEPHDM
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class LDKKEAPOACK : LEPAKJEPHDM
{
    public JBADHBGGEII? <MHGFIMBFMPG>k__BackingField;    // 0x0x18
    public OOCFKHECEFI <JIDDDFDBNLL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LDNKAGMGKPP
//   RESPONSE GET    api/config/v1/backtrace   [Service.API]
public class LDNKAGMGKPP
{
    public int <HPCJKGPMPFM>k__BackingField;    // 0x0x10
    public int <MLHBPGCPAFN>k__BackingField;    // 0x0x14
    public float <PPJPLBKGCCG>k__BackingField;    // 0x0x18
    public int <PCCEJGEGHFA>k__BackingField;    // 0x0x1C
    public int <EHMBAFAEHHH>k__BackingField;    // 0x0x20
    public int <JFGBFCBPBAL>k__BackingField;    // 0x0x24
    public int <PNJJBHFIMOG>k__BackingField;    // 0x0x28
    public string <GGKLHHNPOGD>k__BackingField;    // 0x0x30
    public string <OCBAEJLPFNB>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// LGKKGHPNBPK
//   REQUEST  POST   api/items/purchaseInfos   [Service.Econ]
public class LGKKGHPNBPK
{
    public IReadOnlyList<LNAJIECANIH> <GAILIHFDMGC>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LIOPGFPIGEA
//   (not directly referenced by a detected call)
public class LIOPGFPIGEA
{
    public float <BPDIEPPGCOJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LJKNIBLNFPC
//   (not directly referenced by a detected call)
public class LJKNIBLNFPC
{
    public int <BAKHCOEEMAF>k__BackingField;    // 0x0x10
    public GJHHANOJDDE <FOJLKCJMIFM>k__BackingField;    // 0x0x14
    public List<OMGJBDGJFCO> <GLHNKGCALJJ>k__BackingField;    // 0x0x18
    public List<OMGJBDGJFCO> <EEJGMLPHGJK>k__BackingField;    // 0x0x20
    public bool <KHOCEKMLKOH>k__BackingField;    // 0x0x28
    public DateTime? <OPEFPLPLOGE>k__BackingField;    // 0x0x30
    public DateTime? <NKDJKBEKAJL>k__BackingField;    // 0x0x40
    public DateTime? <AOIPMBBFNBN>k__BackingField;    // 0x0x50
    public bool <OBOGFPFOIOM>k__BackingField;    // 0x0x60
    public bool <ALILHJNOLKL>k__BackingField;    // 0x0x61
}

// --------------------------------------------------------------------------
// LMIIHNEOGMP
//   (not directly referenced by a detected call)
public class LMIIHNEOGMP
{
    public int <KOCLEMNDEDC>k__BackingField;    // 0x0x10
    public DateTime <MKDLLAEFLFC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LNAJIECANIH
// base   : JLOBBPMCEGI
//   (not directly referenced by a detected call)
public class LNAJIECANIH : JLOBBPMCEGI
{
    public JKOGBHNADMP BPHOADOIGAP;    // 0x0x20
}

// --------------------------------------------------------------------------
// LOAODBOJGLP
//   REQUEST  POST   api/avatar/v1/lockeditems/bulk   [Service.Econ]
public class LOAODBOJGLP
{
    public List<string> <BAAHKAANEJD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LPALFLGPPBK
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.Econ]
public class LPALFLGPPBK
{
    public List<PNAFLMCIPNB> <FNDNFILKMJM>k__BackingField;    // 0x0x10
    public string <KBCLDGPHKAF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LPFMLMENMHJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LPFMLMENMHJ
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
// MACGEMOHPAH
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
public class MACGEMOHPAH
{
    public Guid? <LFDGOEPAEIM>k__BackingField;    // 0x0x10
    public long? <LOAMABPIJJG>k__BackingField;    // 0x0x28
    public string <MDMLKLKCKHN>k__BackingField;    // 0x0x38
    public string <OFOAJDEONEL>k__BackingField;    // 0x0x40
    public string <LIFOPKKBMIJ>k__BackingField;    // 0x0x48
    public CPBOPMGNMMO <KKDHGBANDPM>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// MEELCAECJGM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MEELCAECJGM
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
// MHEKNBGFNGL
//   RESPONSE DELETE api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{gJOAADEPHGA}   [Service.Econ]
public class MHEKNBGFNGL
{
    public AJGCGHPLGNO <DEAIGLHJNMA>k__BackingField;    // 0x0x10
    public AMLJAOCAJEO <HHNACLMOJFI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MHIPDKDDENI
//   RESPONSE PUT    api/roomkeys/v1/   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Matchmaking]
public class MHIPDKDDENI
{
    public RoomKeyResult <DEAIGLHJNMA>k__BackingField;    // 0x0x10
    public ILOECOCCBIG <NAPOIFFAPAC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MHJCOAJDKEN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MHJCOAJDKEN
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// MIHHIEODNMP
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{aDHDKEKHIJI}   [Service.API]
public class MIHHIEODNMP
{
    public List<BAFAHHEIMPO> <GFOEAHJHONH>k__BackingField;    // 0x0x10
    public List<GPPLNOMAFEM> <OHKMHEJDBFM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MKELHNOGKHJ
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class MKELHNOGKHJ : ValueType
{
    public Guid OKDHAOKOGCM;    // 0x0x0
}

// --------------------------------------------------------------------------
// MKHKBBDILNJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MKHKBBDILNJ
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
    Destiny = 2201,
    RunTheBlock = 2202,
    RROStorefront_ToBeNamed_2 = 2203,
    DevStorefront_DoNotAddToWatch_1 = 2300,
    DevStorefront_DoNotAddToWatch_2 = 2301,
    DevStorefront_DoNotAddToWatch_3 = 2302,
    DevStorefront_DoNotAddToWatch_4 = 2303,
    DevStorefront_DoNotAddToWatch_5 = 2304,
}

// --------------------------------------------------------------------------
// MLMINPFEMMH
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
public class MLMINPFEMMH
{
    public bool <HAHMHJBMAJJ>k__BackingField;    // 0x0x10
    public string <LMDHAOIPMCE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MNDDOLLAAEN
//   (not directly referenced by a detected call)
public class MNDDOLLAAEN
{
    public JBPKFCGAFMN <CBDKAFJJCCB>k__BackingField;    // 0x0x10
    public long <FJIBLCLNGOJ>k__BackingField;    // 0x0x18
    public GiftItemDTO <KIFFFAICOGG>k__BackingField;    // 0x0x20
    public long? <NMFMKDNGHGC>k__BackingField;    // 0x0x28
    public int <EFAAPNMECOM>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// MPHCIACDLJI
//   REQUEST  POST   api/items/bulkpurchase   [Service.Commerce]
public class MPHCIACDLJI
{
    public List<MNDDOLLAAEN> <JLJPDMGPCFE>k__BackingField;    // 0x0x10
    public MKHKBBDILNJ? <GFDLCHJHKLI>k__BackingField;    // 0x0x18
    public CPLLFGEHMIB <HJBJMKIMCIM>k__BackingField;    // 0x0x20
    public bool <GIPHKLGBCAK>k__BackingField;    // 0x0x24
    public bool <GEIJPGCOEIL>k__BackingField;    // 0x0x25
    public Guid? <PLCICCNGDJO>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// MPLEDICCGLC
//   (not directly referenced by a detected call)
public class MPLEDICCGLC
{
    public long <KGJCMKEBFAN>k__BackingField;    // 0x0x10
    public long <HDHDJJCOMGJ>k__BackingField;    // 0x0x18
    public int <IEFLHMJFAAE>k__BackingField;    // 0x0x20
    public DateTime <MOAGDKLKGBJ>k__BackingField;    // 0x0x28
    public LACJIEMAPLB <FOJLKCJMIFM>k__BackingField;    // 0x0x30
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
// NANMHMIBICI
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class NANMHMIBICI : ValueType
{
    public Guid OKDHAOKOGCM;    // 0x0x0
}

// --------------------------------------------------------------------------
// NFFMJKMNGFO
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class NFFMJKMNGFO
{
    public Dictionary<Guid, CJJCNHKMNOJ> <MDOLPAMAJHJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// NGHFCMNNGJM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NGHFCMNNGJM
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// NIEEDBIMBPI
// base   : KLNJBOMAAMI`1<FNHOEBPLBMN>
//   RESPONSE GET    api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{bDKJIDMBCNG}   [Service.API]
public class NIEEDBIMBPI
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// NJKBPJHMAAK
//   (not directly referenced by a detected call)
public class NJKBPJHMAAK
{
    public float <MENKEGNJNLK>k__BackingField;    // 0x0x10
    public float <GHAKHHEPMNH>k__BackingField;    // 0x0x14
    public float <POJMNCBEHFL>k__BackingField;    // 0x0x18
    public float <GIFBIAMGHCA>k__BackingField;    // 0x0x1C
    public float <BKKGMAHLEGB>k__BackingField;    // 0x0x20
    public float <BDKAFJKBDAO>k__BackingField;    // 0x0x24
    public float <MPKJJIHEMOD>k__BackingField;    // 0x0x28
    public float <IMEGCAPAKKH>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// NJKCCNFEAPN
//   (not directly referenced by a detected call)
public class NJKCCNFEAPN
{
    public string <EJEKAEIEHGA>k__BackingField;    // 0x0x10
    public DBADGPAGOMC <FOJLKCJMIFM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NMDCCGHIDKG
//   RESPONSE GET    api/makerai/freetrialconfig   [Service.Econ]
public class NMDCCGHIDKG
{
    public TimeSpan <MABGHMAGKAA>k__BackingField;    // 0x0x10
    public TimeSpan <HCOGINMLNCF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NNNENKDEMJP
//   REQUEST  POST   api/roomkeys/v1/owns/bulk   [Service.Econ]
public class NNNENKDEMJP
{
    public int PCBFONIICIN;    // 0x0x10
    public long DBOOAMEPAJO;    // 0x0x18
}

// --------------------------------------------------------------------------
// ODEGDKPJABI
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.API]
public class ODEGDKPJABI
{
    public string <GPGDOAJDPKG>k__BackingField;    // 0x0x10
    public string <NEMCKJPEEDJ>k__BackingField;    // 0x0x18
    public string <GECNEKFPAIG>k__BackingField;    // 0x0x20
    public string <OFOAJDEONEL>k__BackingField;    // 0x0x28
    public string <PLANGCIENKM>k__BackingField;    // 0x0x30
    public JHBELHCLHPH <DEAIGLHJNMA>k__BackingField;    // 0x0x38
    public List<string> <KJMPIIIBJEB>k__BackingField;    // 0x0x40
    public List<string> <GMMCELAFOCC>k__BackingField;    // 0x0x48
    public string <IBEKCNHIENP>k__BackingField;    // 0x0x50
    public List<JCBFHEEKKKD> <BAJMMHBJILG>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// OGEGIMDMAPI
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.API]
public class OGEGIMDMAPI
{
    public List<BAFAHHEIMPO> <OMJNCEMJICH>k__BackingField;    // 0x0x10
    public string <KBCLDGPHKAF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OMGJBDGJFCO
//   (not directly referenced by a detected call)
public class OMGJBDGJFCO
{
    public CPLLFGEHMIB <HJBJMKIMCIM>k__BackingField;    // 0x0x10
    public int <AGOHLGKGGLG>k__BackingField;    // 0x0x14
    public LBLIIJLBMEF <DJKDEAAEHDB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OOCFKHECEFI
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.Econ]
public class OOCFKHECEFI
{
    public int <EDAAMGNFHNO>k__BackingField;    // 0x0x10
    public Guid <NHDLLLDBOGP>k__BackingField;    // 0x0x14
    public long <MAMGGLFEKAL>k__BackingField;    // 0x0x28
    public DateTime <GCCLOGOLNMM>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// OPLMDJHILKC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OPLMDJHILKC
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
// PHHDLKLONNA
//   (not directly referenced by a detected call)
public class PHHDLKLONNA
{
    public int <NAJLBNKMGJJ>k__BackingField;    // 0x0x10
    public FPHMHBOMDBN <PJAMEJFDAPJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PKEKEIJGFCO
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class PKEKEIJGFCO
{
    public DCKEHMOPCJJ <DGBJLEAHDGL>k__BackingField;    // 0x0x10
    public List<string> <GMMCELAFOCC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PKIHMKKKDAH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PKIHMKKKDAH
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
// PLAAGHJBIBF
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class PLAAGHJBIBF
{
    public List<NJKCCNFEAPN> <GMMCELAFOCC>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// PMOMGBEMEBI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PMOMGBEMEBI
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// PNAFLMCIPNB
//   (not directly referenced by a detected call)
public class PNAFLMCIPNB
{
    public int <HFJFLHNAGFA>k__BackingField;    // 0x0x10
    public DateTime <MOAGDKLKGBJ>k__BackingField;    // 0x0x18
    public DateTime? <EPHKFPINCFB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PNKNGJPFJBH
//   REQUEST  POST   api/playerevents/v1/respond   [Service.API]
public class PNKNGJPFJBH
{
    public long <HDHDJJCOMGJ>k__BackingField;    // 0x0x10
    public LACJIEMAPLB <FOJLKCJMIFM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PPCKLMAIMMO
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.Econ]
public class PPCKLMAIMMO
{
    public long <LOAMABPIJJG>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <HJAAOBPBPFE>k__BackingField;    // 0x0x18
    public MHJCOAJDKEN <IFNDGIPCGNK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.Clubs]
public class AddKeepsakeInstanceRequest
{
    public long <LOAMABPIJJG>k__BackingField;    // 0x0x10
    public long? <GGHBDBCDMHO>k__BackingField;    // 0x0x18
    public MMIEHDFJNAE <JEKBNBJMJON>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddVersionInventionRequestDTO
//   REQUEST  POST   api/inventions/v8/addversion   [Service.Notifications]
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
    public IReadOnlyList<Guid> referencedUnityAssetIds;    // 0x0x50
    public ModifyTagsRequest tagsRequest;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.AppleMusicPromotionResponseDTO
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.API]
public class AppleMusicPromotionResponseDTO
{
    public OPLCLNCHFON <DGBJLEAHDGL>k__BackingField;    // 0x0x10
    public string <GPBHGODBMAJ>k__BackingField;    // 0x0x18
    public string <KPKCBIEJLOH>k__BackingField;    // 0x0x20
    public string <KLKMMPBEFGN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public CPLLFGEHMIB <CurrencyType>k__BackingField;    // 0x0x18
    public PKIHMKKKDAH <BalanceType>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.BalanceUpdateResponseDTO`1
// base   : RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceUpdateResponseDTO : BalanceResponseDTO
{
    public List<HMDOABJGPEA<DataTypeDTO>> <BalanceUpdates>k__BackingField;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecNet.CheerRequest
//   REQUEST  POST   api/inventions/v2/cheer   [Service.API]
public class CheerRequest
{
    public long InventionId;    // 0x0x10
    public bool Cheer;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.DeleteInventionRequest
//   REQUEST  POST   api/inventions/v2/delete   [Service.API]
public class DeleteInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
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
//   REQUEST  POST   api/playerevents/v1/broadcast   [Service.API]
public class BroadcastRoomInstanceRequest
{
    public long <HDHDJJCOMGJ>k__BackingField;    // 0x0x10
    public long? <FNMGDGLOCJE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.BulkInviteRequest
//   REQUEST  POST   api/playerevents/v1/bulkInvite   [Service.API]
public class BulkInviteRequest
{
    public long PlayerEventId;    // 0x0x10
    public List<int> InvitedPlayerIds;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.DeleteResponseRequest
//   REQUEST  POST   api/playerevents/v1/deleteResponse   [Service.API]
public class DeleteResponseRequest
{
    public long PlayerEventId;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.FilteredTextDTO
//   (not directly referenced by a detected call)
public class FilteredTextDTO
{
    public string <BANJABHLAAO>k__BackingField;    // 0x0x10
    public int <HKLLKKPLJBF>k__BackingField;    // 0x0x18
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
    public AGICGPAACML FilterType;    // 0x0x20
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
// RecNet.GiftItemDTO
//   (not directly referenced by a detected call)
public class GiftItemDTO
{
    public int <ToPlayerId>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public bool <Anonymous>k__BackingField;    // 0x0x20
    public KCJNALNJGNJ <GiftContext>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.InventionModifyTagsRequest
// base   : RecNet.ModifyTagsRequest
//   REQUEST  POST   api/inventions/v1/settags   [Service.API]
public class InventionModifyTagsRequest : ModifyTagsRequest
{
    public long InventionId;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCategoryConfigDTO
//   (not directly referenced by a detected call)
public class KeepsakeCategoryConfigDTO
{
    public MMIEHDFJNAE <MCMONMNHBBN>k__BackingField;    // 0x0x10
    public string <NLFJKDMDGFD>k__BackingField;    // 0x0x18
    public int <LEBLIFOFCPO>k__BackingField;    // 0x0x20
    public int <LGFBBIFIBGJ>k__BackingField;    // 0x0x24
    public string <OBKJLCNEHBI>k__BackingField;    // 0x0x28
    public string <DOBNGLKGEGF>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <EDAAMGNFHNO>k__BackingField;    // 0x0x10
    public Guid <AIKOKNOCGNA>k__BackingField;    // 0x0x14
    public DateTime <FANJMFMBBAM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.API]
public class KeepsakeGlobalConfigDTO
{
    public bool <PMBKJNAFEPL>k__BackingField;    // 0x0x10
    public int <PKMBFECBKNP>k__BackingField;    // 0x0x14
    public bool <EBGMCCBHEIK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <AIKOKNOCGNA>k__BackingField;    // 0x0x10
    public MMIEHDFJNAE <ILKILKMBFCC>k__BackingField;    // 0x0x20
    public int <CPCKAKOHMLI>k__BackingField;    // 0x0x24
    public long <LOAMABPIJJG>k__BackingField;    // 0x0x28
    public long? <GGHBDBCDMHO>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.API]
//   RESPONSE GET    api/keepsakes/events/{bJAMPOPKJDH}   [Service.API]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <CFDOBNAKHEC>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <HAANGMGPFCM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <JNADODBONMO>k__BackingField;    // 0x0x10
    public long <LOAMABPIJJG>k__BackingField;    // 0x0x18
    public long <EOHBOJPCEHH>k__BackingField;    // 0x0x20
    public JNCBCEICIPM <FOJLKCJMIFM>k__BackingField;    // 0x0x28
    public int <JKEHCNBEIPC>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <LOAMABPIJJG>k__BackingField;    // 0x0x10
    public List<Guid> <BIFPGADCGJP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <CFDOBNAKHEC>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <HAANGMGPFCM>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <CLLJPLAFOFO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <EOHBOJPCEHH>k__BackingField;    // 0x0x10
    public long <HIMLHPOHGNP>k__BackingField;    // 0x0x18
    public int? <AEIBPLCDGAP>k__BackingField;    // 0x0x20
    public int? <JLHGBDKCCKJ>k__BackingField;    // 0x0x28
    public long? <NCHBMEEFICE>k__BackingField;    // 0x0x30
    public long <BLDFMBBFANJ>k__BackingField;    // 0x0x40
    public long <JGFBJPDCCCF>k__BackingField;    // 0x0x48
    public int <HBPGFJCHLLA>k__BackingField;    // 0x0x50
    public JNCBCEICIPM <MJEPMHPFJMK>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <NAAFNEJJBAI>k__BackingField;    // 0x0x58
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
//   (not directly referenced by a detected call)
public class ModifyTagsRequest
{
    public List<string> AutoTags;    // 0x0x10
    public List<string> CustomTags;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.MultiRecipientFreeGiftRequestDTO
//   REQUEST  POST   api/freegifts/v1/sendmultiple   [Service.Econ]
public class MultiRecipientFreeGiftRequestDTO
{
    public List<int> <ToPlayerIds>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public KCJNALNJGNJ <GiftContext>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.NewInventionRequestDTO
//   REQUEST  POST   api/inventions/v9/save   [Service.Matchmaking]
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
    public IReadOnlyList<Guid> referencedUnityAssetIds;    // 0x0x60
    public KIBEKEOAJNC creatorAccountRole;    // 0x0x68
    public long? convertedFromInventionId;    // 0x0x70
    public string displayMetadataJson;    // 0x0x80
    public string longDescription;    // 0x0x88
    public ModifyTagsRequest tagsRequest;    // 0x0x90
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public FCOFKLFDLPK <EMKOOJGACCL>k__BackingField;    // 0x0x10
    public DAEDKPHHFMM <ODMJANHNGFD>k__BackingField;    // 0x0x14
    public string <MDMLKLKCKHN>k__BackingField;    // 0x0x18
    public string <OFOAJDEONEL>k__BackingField;    // 0x0x20
    public bool <GNNPNBJJKLD>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<FCOFKLFDLPK> <KHGDHCIGAPP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE GET    api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/event/{mCDJNNMKHIL}   [Service.API]
public class ProgressionEventDTO
{
    public long <HIMLHPOHGNP>k__BackingField;    // 0x0x10
    public string <MDMLKLKCKHN>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <LNPJHJEFAIJ>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <IGEFKALFGPM>k__BackingField;    // 0x0x28
    public DateTime <FAHAJICNGMA>k__BackingField;    // 0x0x30
    public DateTime <CDNOBJOGCEK>k__BackingField;    // 0x0x38
    public DateTime <NPPNBDMADIB>k__BackingField;    // 0x0x40
    public bool <KNBFIEBOHLN>k__BackingField;    // 0x0x48
    public int <JGAFKKJGFEM>k__BackingField;    // 0x0x4C
    public float <HJHEBIOGPHP>k__BackingField;    // 0x0x50
    public Guid? <FCGKEOAIKOA>k__BackingField;    // 0x0x54
    public string <CJCCMANPBHI>k__BackingField;    // 0x0x68
    public string <NOKJJALPELJ>k__BackingField;    // 0x0x70
    public string <MEACEKNBAHH>k__BackingField;    // 0x0x78
    public string <EDEFMDCLPJK>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <FGMIIOOLPLG>k__BackingField;    // 0x0x10
    public int <GGCDHPKNPGK>k__BackingField;    // 0x0x20
    public int <KFPMPCKOGAC>k__BackingField;    // 0x0x24
    public int <GMODHLGFAFD>k__BackingField;    // 0x0x28
    public long <EMLECEJMBLK>k__BackingField;    // 0x0x30
    public long <AMPNJEANAEN>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE GET    api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.API]
public class ProgressionEventRecordDTO
{
    public int <EDAAMGNFHNO>k__BackingField;    // 0x0x10
    public int <MFGMPGHHCHI>k__BackingField;    // 0x0x14
    public int <CHHIJANAEEN>k__BackingField;    // 0x0x18
    public int <KBJGGDPPFEE>k__BackingField;    // 0x0x1C
    public int <MNGFBJPHACE>k__BackingField;    // 0x0x20
    public DateTime? <IBPGHAHPJHG>k__BackingField;    // 0x0x28
    public int <CFLLCOOJMEB>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <IEPIGDEFJPE>k__BackingField;    // 0x0x10
    public int <GFHKDPPOHFA>k__BackingField;    // 0x0x18
    public string <LIFOPKKBMIJ>k__BackingField;    // 0x0x20
    public int <MFGMPGHHCHI>k__BackingField;    // 0x0x28
    public int <ENNDKEPECIP>k__BackingField;    // 0x0x2C
    public bool <OFCKEJOAEAB>k__BackingField;    // 0x0x30
    public bool <AOPNNDFBPNJ>k__BackingField;    // 0x0x31
}

// --------------------------------------------------------------------------
// RecNet.PublishInventionRequest
//   REQUEST  POST   api/inventions/v4/publish   [Service.API]
public class PublishInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public CJHCKHABAPD <Permission>k__BackingField;    // 0x0x18
    public NGHFCMNNGJM <Accessibility>k__BackingField;    // 0x0x1C
    public int? <Price>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.PurchaseBalanceUpdateResponseDTO`1
// base   : RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class PurchaseBalanceUpdateResponseDTO : BalanceResponseDTO
{
    public List<KCCBPLJOJEI<DataTypeDTO>> <BalanceUpdates>k__BackingField;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public DDDGDGLBMMG ReportCategory;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.InventionAndVersionReplicationIdsDTO
//   (not directly referenced by a detected call)
public class InventionAndVersionReplicationIdsDTO
{
    public Guid <ReplicationId>k__BackingField;    // 0x0x10
    public Guid <VersionReplicationId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.ReplicationUnityAssetsDTO
//   (not directly referenced by a detected call)
public class ReplicationUnityAssetsDTO
{
    public InventionAndVersionReplicationIdsDTO <Invention>k__BackingField;    // 0x0x10
    public List<FJFIGNIPHCH> <UnityAssets>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.SetInventionVersionAccessibilityRequest
//   REQUEST  PUT    api/inventions/v2/accessibility   [Service.API]
public class SetInventionVersionAccessibilityRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public int <VersionNumber>k__BackingField;    // 0x0x18
    public NGHFCMNNGJM <NewAccessibility>k__BackingField;    // 0x0x1C
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
// RecNet.SpecialTags
//   RESPONSE GET    api/inventions/v1/specialTags   [Service.API]
public class SpecialTags
{
    public List<string> <AutoTags>k__BackingField;    // 0x0x10
    public List<string> <AGOnlyTags>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.UnpublishInventionRequest
//   REQUEST  POST   api/inventions/v2/unpublish   [Service.API]
public class UnpublishInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.UpdateInventionGeneralPermissionRequest
//   REQUEST  POST   api/inventions/v2/update   [Service.API]
public class UpdateInventionGeneralPermissionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public CJHCKHABAPD <Permission>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.UpdateInventionMetadataRequest
//   REQUEST  PUT    api/inventions/v2/metadata   [Service.Data]
public class UpdateInventionMetadataRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
    public string <LongDescription>k__BackingField;    // 0x0x28
    public string <ImageName>k__BackingField;    // 0x0x30
    public ModifyTagsRequest <TagsRequest>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.UpdatePriceRequest
//   REQUEST  POST   api/inventions/v2/updateprice   [Service.API]
public class UpdatePriceRequest
{
    public long InventionId;    // 0x0x10
    public int Price;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class BaseDTO
{
    public string <Id>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.FileDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class FileDTO : BaseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.MessageContentDTO
//   (not directly referenced by a detected call)
public class MessageContentDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Text>k__BackingField;    // 0x0x18
    public BFEDGLKKMDG <ImageFile>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.MessageDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class MessageDTO : BaseDTO
{
    public List<PCHIKNPNBGK> <Content>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.RunDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class RunDTO : BaseDTO
{
    public string <ThreadId>k__BackingField;    // 0x0x18
    public RunStatus <Status>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.ThreadDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class ThreadDTO : BaseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ClientEventBaseDTO : EventBaseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationCreatedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationCreatedEventDTO : EventBaseDTO
{
    public ConversationDTO <Conversation>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationDTO
//   (not directly referenced by a detected call)
public class ConversationDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemContentDTO
//   (not directly referenced by a detected call)
public class ConversationItemContentDTO
{
    public ConversationItemContentType <Type>k__BackingField;    // 0x0x10
    public string <Text>k__BackingField;    // 0x0x18
    public string <Id>k__BackingField;    // 0x0x20
    public string <Audio>k__BackingField;    // 0x0x28
    public string <Transcript>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemCreateEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemCreateEventDTO : ClientEventBaseDTO
{
    public string <PreviousItemId>k__BackingField;    // 0x0x20
    public ConversationItemDTO <Item>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemCreatedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemCreatedEventDTO : EventBaseDTO
{
    public string <PreviousItemId>k__BackingField;    // 0x0x20
    public ConversationItemDTO <Item>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemDTO
//   (not directly referenced by a detected call)
public class ConversationItemDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public ConversationItemType <Type>k__BackingField;    // 0x0x18
    public Role? <Role>k__BackingField;    // 0x0x1C
    public List<ConversationItemContentDTO> <Content>k__BackingField;    // 0x0x28
    public string <CallId>k__BackingField;    // 0x0x30
    public string <Name>k__BackingField;    // 0x0x38
    public string <Arguments>k__BackingField;    // 0x0x40
    public string <Output>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemDeleteEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemDeleteEventDTO : ClientEventBaseDTO
{
    public string <ItemId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemDeletedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemDeletedEventDTO : EventBaseDTO
{
    public string <ItemId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemInputAudioTranscriptionCompletedEventDTO : EventBaseDTO
{
    public string <ItemId>k__BackingField;    // 0x0x20
    public int <ContentIndex>k__BackingField;    // 0x0x28
    public string <Transcript>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemTruncateEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemTruncateEventDTO : ClientEventBaseDTO
{
    public string <ItemId>k__BackingField;    // 0x0x20
    public long <AudioEndMs>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ErrorDTO
//   (not directly referenced by a detected call)
public class ErrorDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Code>k__BackingField;    // 0x0x18
    public string <Message>k__BackingField;    // 0x0x20
    public string <Param>k__BackingField;    // 0x0x28
    public string <EventId>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ErrorEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ErrorEventDTO : EventBaseDTO
{
    public ErrorDTO <Error>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class EventBaseDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <EventId>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferAppendEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferAppendEventDTO : ClientEventBaseDTO
{
    public string <Audio>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferCommittedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferCommittedEventDTO : EventBaseDTO
{
    public string <PreviousItemId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferSpeechStartedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferSpeechStartedEventDTO : EventBaseDTO
{
    public int <AudioStartMs>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferSpeechStoppedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferSpeechStoppedEventDTO : EventBaseDTO
{
    public int <AudioEndMs>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioTranscriptionDTO
//   (not directly referenced by a detected call)
public class InputAudioTranscriptionDTO
{
    public string <Model>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputTokenDetailsDTO
// base   : RecRoom.AI.OpenAI.Realtime.TokenDetailsDTO
//   (not directly referenced by a detected call)
public class InputTokenDetailsDTO : TokenDetailsDTO
{
    public int <CachedTokens>k__BackingField;    // 0x0x18
    public TokenDetailsDTO <CachedTokensDetails>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.OutputAudioBufferClearedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.OutputAudioBufferEventDTO
//   (not directly referenced by a detected call)
public class OutputAudioBufferClearedEventDTO : OutputAudioBufferEventDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.OutputAudioBufferEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class OutputAudioBufferEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.OutputAudioBufferStartedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.OutputAudioBufferEventDTO
//   (not directly referenced by a detected call)
public class OutputAudioBufferStartedEventDTO : OutputAudioBufferEventDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.OutputAudioBufferStoppedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.OutputAudioBufferEventDTO
//   (not directly referenced by a detected call)
public class OutputAudioBufferStoppedEventDTO : OutputAudioBufferEventDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.RateLimitDTO
//   (not directly referenced by a detected call)
public class RateLimitDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public int <Limit>k__BackingField;    // 0x0x18
    public int <Remaining>k__BackingField;    // 0x0x1C
    public float <ResetSeconds>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.RateLimitsUpdatedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class RateLimitsUpdatedEventDTO : EventBaseDTO
{
    public RateLimitDTO[] <RateLimits>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseAudioDeltaEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseAudioDeltaEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public string <Delta>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseAudioDoneEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseAudioDoneEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseAudioTranscriptDoneEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseAudioTranscriptDoneEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public string <Transcript>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseContentPartEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseContentPartEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public ConversationItemContentDTO <Part>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseCreateEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseCreateEventDTO : ClientEventBaseDTO
{
    public ResponseDTO <Response>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseDTO
//   (not directly referenced by a detected call)
public class ResponseDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public ResponseStatus <Status>k__BackingField;    // 0x0x18
    public ResponseStatusDetailsDTO <StatusDetails>k__BackingField;    // 0x0x20
    public List<ConversationItemDTO> <Output>k__BackingField;    // 0x0x28
    public TokenUsageDTO <Usage>k__BackingField;    // 0x0x30
    public Dictionary<string, string> <Metadata>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseErrorDTO
//   (not directly referenced by a detected call)
public class ResponseErrorDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Code>k__BackingField;    // 0x0x18
    public string <Message>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseEventDTO : EventBaseDTO
{
    public ResponseDTO <Response>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseFunctionCallArgumentsDeltaEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public string <CallId>k__BackingField;    // 0x0x38
    public string <Delta>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseFunctionCallArgumentsDoneEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseFunctionCallArgumentsDoneEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public string <CallId>k__BackingField;    // 0x0x38
    public string <Name>k__BackingField;    // 0x0x40
    public string <Arguments>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseOutputItemEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseOutputItemEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public int <OutputIndex>k__BackingField;    // 0x0x28
    public ConversationItemDTO <Item>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseStatusDetailsDTO
//   (not directly referenced by a detected call)
public class ResponseStatusDetailsDTO
{
    public ResponseStatus <Type>k__BackingField;    // 0x0x10
    public string <Reason>k__BackingField;    // 0x0x18
    public ResponseErrorDTO <Error>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseTextDeltaEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseTextDeltaEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public string <Delta>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.SessionDTO
//   (not directly referenced by a detected call)
public class SessionDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public DateTime <ExpiresAt>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.SessionEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class SessionEventDTO : EventBaseDTO
{
    public SessionDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.TokenDetailsDTO
//   (not directly referenced by a detected call)
public class TokenDetailsDTO
{
    public int <TextTokens>k__BackingField;    // 0x0x10
    public int <AudioTokens>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.TokenUsageDTO
//   (not directly referenced by a detected call)
public class TokenUsageDTO
{
    public int <TotalTokens>k__BackingField;    // 0x0x10
    public int <InputTokens>k__BackingField;    // 0x0x14
    public int <OutputTokens>k__BackingField;    // 0x0x18
    public InputTokenDetailsDTO <InputTokenDetails>k__BackingField;    // 0x0x20
    public TokenDetailsDTO <OutputTokenDetails>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ToolDTO
//   (not directly referenced by a detected call)
public class ToolDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
    public JsonSchema <Parameters>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateInputVoiceTranscriptionEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateInputVoiceTranscriptionEventDTO : ClientEventBaseDTO
{
    public UpdateInputVoiceTranscriptionDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateSessionAudioConfigEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateSessionAudioConfigEventDTO : ClientEventBaseDTO
{
    public UpdateSessionAudioConfigDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateSessionConfigurationEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateSessionConfigurationEventDTO : ClientEventBaseDTO
{
    public UpdateSessionConfigurationDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateToolConfigEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateToolConfigEventDTO : ClientEventBaseDTO
{
    public UpdateToolConfigDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.DataLayer.RoomKeyResult
// base   : System.Enum
//   RESPONSE DELETE api/roomkeys/   [Service.Econ]
//   RESPONSE DELETE api/roomkeys/v1/delete/{fBDOKKFGLAO}   [Service.Econ]
public enum RoomKeyResult
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
// RecRoom.Debugging.AutocompleteResult
// base   : UnityEngine.MonoBehaviour
//   (not directly referenced by a detected call)
public class AutocompleteResult : MonoBehaviour
{
    public RawImage backgroundImage;    // 0x0x18
    public TMP_Text text;    // 0x0x20
    public bool IAKHFCODNJL;    // 0x0x28
}

// --------------------------------------------------------------------------
// RoomieActivities.Catch.Response
//   (not directly referenced by a detected call)
public class Response
{
    public string prompt;    // 0x0x10
    public string animation;    // 0x0x18
    public float weight;    // 0x0x20
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

// api/CampusCard/v1/UpdateAndGetSubscription  [Econ POST]
public class CampusCardV1UpdateAndGetSubscriptionRequest
{
    public string accessToken;  // wrapper
}

// api/PlayerCheer/v1/SetSelectedCheer  [API POST]
public class PlayerCheerV1SetSelectedCheerRequest
{
    public ILBOCPBOEJB? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public ILBOCPBOEJB PFKGHOELJGI;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public FHEHDDAJNCC DFIHIGFMBCB;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public FIMFMEDFMFD DGPNPBEKOOD;  // wrapper
    public int? MNNLPAJLFDD;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v1/modKick  [API POST]
public class PlayerReportingV1ModKickRequest
{
    public KBGOCEGMGOO MMODAPCIJEH;  // wrapper
    public object IsFromReport;  // candidate
    public object FromReportCategory;  // candidate
    public object GameSessionId;  // candidate
    public object PlayerId;  // candidate
}

// api/PlayerReporting/v1/moderationBlockDetails  [API POST]
public class PlayerReportingV1ModerationBlockDetailsRequest
{
    public string deviceToken;  // wrapper
}

// api/PlayerReporting/v1/referee  [API POST]
public class PlayerReportingV1RefereeRequest
{
    public byte[] BOIPFNOKGBJ;  // wrapper
    public KKJCMCKMKPH PLKPOIOLAOH;  // wrapper
    public object meta;  // candidate
    public object data;  // candidate
    public object file.bin;  // candidate
}

// api/PlayerReporting/v1/roomModKick  [API POST]
public class PlayerReportingV1RoomModKickRequest
{
    public object GameSessionId;  // candidate
    public object PlayerId;  // candidate
    public object Reason;  // candidate
}

// api/PlayerReporting/v3/create  [API POST]
public class PlayerReportingV3CreateRequest
{
    public KBGOCEGMGOO AJCAFJDCFMK;  // wrapper
    public float? HKEFOAFDLCI;  // wrapper
    public bool? APECMCKGGGA;  // wrapper
    public object IsFullBodyAvatarReport;  // candidate
    public object IsReporterFullBodyAvatar;  // candidate
    public object IsGiftingReport;  // candidate
    public object ReportCategory;  // candidate
    public object HeightReporter;  // candidate
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
    public List<EMIPHPEOPMO> desc;  // wrapper
}

// api/avatar/v2/gifts/consume/  [Econ POST]
public class AvatarV2GiftsConsumeRequest
{
    public object UnlockedLevel;  // candidate
}

// api/avatar/v2/gifts/generate  [Econ POST]
public class AvatarV2GiftsGenerateRequest
{
    public KCJNALNJGNJ IEOOLFDDEEF;  // wrapper
    public KCJNALNJGNJ? EIDOECDKODM;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [Econ POST]
public class AvatarV3GiftsGenerateRequest
{
    public KCJNALNJGNJ IEOOLFDDEEF;  // wrapper
    public KCJNALNJGNJ? EIDOECDKODM;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/chatreport/createChatReport  [API POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage IIHOFBLPONF;  // wrapper
    public HPPPEFKGMCM AJCAFJDCFMK;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public KBGOCEGMGOO AJCAFJDCFMK;  // wrapper
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
    public NGHFCMNNGJM KNADKFHEGDI;  // wrapper
    public ANMBCLICMLK COHMEKMPKNF;  // wrapper
    public KLOAFGMCNLB HGJPIFAJGIN;  // wrapper
    public KLOAFGMCNLB AGOBGNBIPDC;  // wrapper
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

// api/customAvatarItems/v1/featured  [API GET]
public class CustomAvatarItemsV1FeaturedRequest
{
    public object unityAssetVersion;  // candidate
    public object unityAssetTarget;  // candidate
}

// api/customAvatarItems/v1/hot  [API GET]
public class CustomAvatarItemsV1HotRequest
{
    public object unityAssetVersion;  // candidate
    public object unityAssetTarget;  // candidate
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
    public object outfitTypes;  // candidate
    public object minPrice;  // candidate
    public object isOwned;  // candidate
    public object itemTypes;  // candidate
    public object isFeatured;  // candidate
}

// api/customAvatarItems/v1/{aIGIABENOBD}/appeal  [API POST]
public class CustomAvatarItemsV1AIGIABENOBDAppealRequest
{
    public Guid AIGIABENOBD;  // wrapper
}

// api/customAvatarItems/v2/fromCreator/{bDKJIDMBCNG}  [API GET]
public class CustomAvatarItemsV2FromCreatorBDKJIDMBCNGRequest
{
    public int take;  // wrapper
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
    public DONCIBHPGIF JHLEGCELFDC;  // wrapper
    public KCJNALNJGNJ? MNKDOBJMLJL;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [Econ POST]
public class GamerewardsV1SelectRequest
{
    public LKNINGOHGNG IDOCIBOFNAF;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/images/  [API GET]
public class ImagesRequest
{
    public object filter;  // candidate
    public object sort;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/images/v4/room/{roomId}  [API GET]
public class ImagesV4RoomRoomIdRequest
{
    public object filter;  // candidate
    public object sort;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
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
    public object ugcVersion;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/itemWishlists/v1/isonwishlist/bulk  [Econ POST]
public class ItemWishlistsV1IsonwishlistBulkRequest
{
    public List<int> accountIds;  // form
}

// api/itemWishlists/v1/wishlist/add  [Econ POST]
public class ItemWishlistsV1WishlistAddRequest
{
    public int? ODIHMGLNBFC;  // wrapper
    public Guid? AIGIABENOBD;  // wrapper
    public object customAvatarItemId;  // candidate
    public object purchasableItemId;  // candidate
}

// api/itemWishlists/v1/wishlist/remove  [Econ POST]
public class ItemWishlistsV1WishlistRemoveRequest
{
    public int? ODIHMGLNBFC;  // wrapper
    public Guid? AIGIABENOBD;  // wrapper
    public object customAvatarItemId;  // candidate
    public object purchasableItemId;  // candidate
}

// api/keepsakes/{oEDJPEFAHHO}/collect  [API POST]
public class KeepsakesOEDJPEFAHHOCollectRequest
{
    public Guid OEDJPEFAHHO;  // wrapper
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public KMBELCEBGMB IKGGDIGKPEC;  // wrapper
    public long? NCGHDDJNJOM;  // wrapper
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

// api/playerevents/v1/bulk  [API POST]
public class PlayereventsV1BulkRequest
{
    public List<long> Ids;  // form
}

// api/playerevents/v1/clubs  [API POST]
public class PlayereventsV1ClubsRequest
{
    public IReadOnlyCollection<long> HMJFLDDFJDL;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public CFDDBKBJOOK KNADKFHEGDI;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? LDPKEBJJOHL;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public PMOMGBEMEBI NFFOKGKGNIA;  // wrapper
    public PMOMGBEMEBI POAIEGCCIAO;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? HEPLHKILNBD;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime JJLJKJFEDOP;  // wrapper
    public DateTime NNJPCGBFIBO;  // wrapper
}

// api/playeritems/v1/isavataritemowned/bulk  [Econ POST]
public class PlayeritemsV1IsavataritemownedBulkRequest
{
    public List<int> accountIds;  // form
}

// api/playeritems/v1/isequipmentitemowned/bulk  [Econ POST]
public class PlayeritemsV1IsequipmentitemownedBulkRequest
{
    public List<int> accountIds;  // form
}

// api/playerwarnings  [API POST]
public class PlayerwarningsRequest
{
    public KBGOCEGMGOO AJCAFJDCFMK;  // wrapper
    public object ModeratorNote;  // candidate
    public object WarnedPlayerId;  // candidate
    public object ReportCategory;  // candidate
    public object DisplayReason;  // candidate
}

// api/relationships/  [API POST]
public class RelationshipsRequest
{
    public object PlayerId;  // candidate
}

// api/relationships/v1/addfriendwithcode  [API GET]
public class RelationshipsV1AddfriendwithcodeRequest
{
    public object code;  // candidate
}

// api/roomCurrencies/v2/purchase  [Econ POST]
public class RoomCurrenciesV2PurchaseRequest
{
    public Guid LIJCKAMLCEH;  // wrapper
    public object PurchaseOfferId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedAmount;  // candidate
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
    public Guid KECDBLAMLBA;  // wrapper
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
    public Guid KECDBLAMLBA;  // wrapper
    public long? JBGBPKGDLBH;  // wrapper
    public byte? KDLDDCCMAJC;  // wrapper
    public int? PFKMCINIKNC;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid LIJCKAMLCEH;  // wrapper
    public long? CGHPGNAOOBN;  // wrapper
    public long? DBNAILDCGHC;  // wrapper
    public int? NGGOMNNDFMN;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [Econ PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> OAEBFAAHGEJ;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [Econ POST]
public class RoomkeysV1CreateRequest
{
    public HIGPPMMEOEO DGPNPBEKOOD;  // wrapper
    public Guid? FDMEOBJCLPB;  // wrapper
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
    public KBGOCEGMGOO AJCAFJDCFMK;  // wrapper
    public long? FDMNIHBIFED;  // wrapper
    public Guid? DKOCPAOBKNG;  // wrapper
    public int? BONIFNLBDPF;  // wrapper
    public object RoomOfferVersion;  // candidate
    public object ReportCategory;  // candidate
    public object RoomOfferId;  // candidate
    public object RoomId;  // candidate
    public object RoomKeyId;  // candidate
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
    public Guid JPMDOJDIKMP;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [Econ POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid BCLHLPMLFBL;  // wrapper
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

// api/storefronts/v2/trialInvention  [Econ POST]
public class StorefrontsV2TrialInventionRequest
{
    public long inventionId;  // wrapper
}

// api/testcasemanagement/v1/testcase/  [API POST]
public class TestcasemanagementV1TestcaseRequest
{
    public JHBELHCLHPH BJHDMCIJCNK;  // wrapper
}

