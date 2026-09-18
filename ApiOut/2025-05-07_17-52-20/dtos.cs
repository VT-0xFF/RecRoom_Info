// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 263 (plus referenced enums)

// --------------------------------------------------------------------------
// AAFJAOALNII
// base   : KJFFGAJIBFG
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.Econ]
public class AAFJAOALNII : KJFFGAJIBFG
{
    public AMLDHMIJPGG? <IDGLCGJBMJA>k__BackingField;    // 0x0x18
    public CPCMLOACIGF <NJGFIDFOFPL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AAGBAMPLMIJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AAGBAMPLMIJ
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// AAGJIOJMIFP
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.Econ]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.Econ]
public class AAGJIOJMIFP
{
    public LOEHMCNCEPF <AKKOEOKHINL>k__BackingField;    // 0x0x10
    public ONMGFICPFAP <IJAJAPIAKDG>k__BackingField;    // 0x0x18
    public int <HLKPHOADDBJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ABKIICKCJNB
//   REQUEST  POST   api/playerevents/v1/report   [Service.API]
public class ABKIICKCJNB
{
    public CACKPAOFAJP <KJBGHIPICNL>k__BackingField;    // 0x0x10
    public long <DHCKKJIHICH>k__BackingField;    // 0x0x18
    public string <IHECJMEBINE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ADNMJEICHEN
//   RESPONSE PUT    api/roomconsumables   [Service.Econ]
public class ADNMJEICHEN
{
    public CJHPCLELFIA <MHELAINJAIG>k__BackingField;    // 0x0x10
    public KNKPJEDCHEL <IIJLCHCLEOM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AFFGNFKPFBL
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class AFFGNFKPFBL
{
    public CACKPAOFAJP <KJBGHIPICNL>k__BackingField;    // 0x0x10
    public int <OMJOPJJCHPD>k__BackingField;    // 0x0x14
    public long <AJBEIOIDKFA>k__BackingField;    // 0x0x18
    public bool <GKNAMDEANGC>k__BackingField;    // 0x0x20
    public string <HOMBOPKNNGB>k__BackingField;    // 0x0x28
    public int? <JPLLDBGIFMC>k__BackingField;    // 0x0x30
    public bool <DNAKFCGLNGC>k__BackingField;    // 0x0x38
    public bool <KJFMIFFBCFN>k__BackingField;    // 0x0x39
    public bool <PLBIHPHNDHF>k__BackingField;    // 0x0x3A
    public bool <AGOPJNLJPDG>k__BackingField;    // 0x0x3B
    public string <BIDHMCJIMGM>k__BackingField;    // 0x0x40
    public DateTime? <HGFIKCJAKAB>k__BackingField;    // 0x0x48
    public string <DPHDKNPACHK>k__BackingField;    // 0x0x58
    public float <OPCOJEPALFP>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// AFLEGFMKPCB
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.API]
public class AFLEGFMKPCB
{
    public int <LDAPMHAEOCE>k__BackingField;    // 0x0x10
    public int? <LGEHPAJEEFH>k__BackingField;    // 0x0x14
    public string <FCHPICNHDAE>k__BackingField;    // 0x0x20
    public string <KHOOHDFDGFD>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// AJCDICPBHHL
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class AJCDICPBHHL
{
    public JDLCPNJPBHB <PBOBDOGGKMH>k__BackingField;    // 0x0x10
    public List<string> <BAGBILNLKFK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AJPOHJAHAMN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AJPOHJAHAMN
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
// ALIONPJIEDL
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.Econ]
public class ALIONPJIEDL
{
    public int <IIGKNPIENHO>k__BackingField;    // 0x0x10
    public bool <POCIKHCPIGH>k__BackingField;    // 0x0x14
    public DateTime <EKNOEMOODJL>k__BackingField;    // 0x0x18
    public bool <KMIPMMDOGKG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AMLDHMIJPGG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AMLDHMIJPGG
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// APCAKCGDFCO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum APCAKCGDFCO
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
// APCMALGKHEN
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class APCMALGKHEN
{
    public List<IKHHCFPOCPH> <POAKECBCKNI>k__BackingField;    // 0x0x10
    public AJPOHJAHAMN <PBOBDOGGKMH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// APPNANGFABC
//   (not directly referenced by a detected call)
public class APPNANGFABC
{
    public string <BGDKGICBEFE>k__BackingField;    // 0x0x10
    public OAPMNGPFEMF <LEOLJMABNCL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BAAIMDALMOP
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/checklist/v1/complete   [Service.Econ]
//   RESPONSE POST   api/progressionEvents   [Service.API]
//   RESPONSE POST   api/progressionEvents/collect/{aJOCAMLGEFH}/{eACGHCMBFHP}   [Service.API]
public class BAAIMDALMOP
{
    public long? <PPNIEDCHLJF>k__BackingField;    // 0x0x10
    public int <BLLKHEABJFK>k__BackingField;    // 0x0x20
    public int? <GKEEILJKOKF>k__BackingField;    // 0x0x24
    public string <IFHBNHDLGJO>k__BackingField;    // 0x0x30
    public DKDANGFCEKG? <NDMJDIIPFJL>k__BackingField;    // 0x0x38
    public string <JNGGPGLGMMO>k__BackingField;    // 0x0x40
    public Guid? <HIGLICCMIFL>k__BackingField;    // 0x0x48
    public string <AKIMBIJCNJH>k__BackingField;    // 0x0x60
    public string <DEKDALHNBGN>k__BackingField;    // 0x0x68
    public COAFHABICNE <BMNFDDBBFKF>k__BackingField;    // 0x0x70
    public int <LJKFMHANMFM>k__BackingField;    // 0x0x74
    public int <JJLOCDOIBJO>k__BackingField;    // 0x0x78
    public IPAJFKBAJFI <LLECGIAJFAL>k__BackingField;    // 0x0x7C
    public NGFKJBKJKIN <GECKOCIKEHB>k__BackingField;    // 0x0x80
    public string <JNHIOECMJDB>k__BackingField;    // 0x0x88
    public string <ENCDKNFOFJB>k__BackingField;    // 0x0x90
    public bool <IMLOMJAMOLB>k__BackingField;    // 0x0x98
    public KBKDLGNDCGI <MGIDMENPJCD>k__BackingField;    // 0x0x9C
    public FFEEJALAFLP <PLIINMBOOFD>k__BackingField;    // 0x0xA0
    public ENBJEHKMOJF? <LLOHEOGDICB>k__BackingField;    // 0x0xA4
    public bool <HIJDMJFNABI>k__BackingField;    // 0x0xAC
    public bool <NNMMOIEEJLM>k__BackingField;    // 0x0xAD
    public string <OLGLAKEAGHC>k__BackingField;    // 0x0xB0
    public string <EALPGAHAIOG>k__BackingField;    // 0x0xB8
    public bool <EDPNPHEBIAB>k__BackingField;    // 0x0xC0
    public bool GEEBJGIMIDG;    // 0x0xC1
}

// --------------------------------------------------------------------------
// BBECJNGCOMP
//   (not directly referenced by a detected call)
public class BBECJNGCOMP
{
    public EPDOOECNGMH <LNJECFCMKNJ>k__BackingField;    // 0x0x10
    public long <OIPIGFJNPAF>k__BackingField;    // 0x0x18
    public GiftItemDTO <GKOMONBHIHM>k__BackingField;    // 0x0x20
    public long? <ENJBOFPFJGL>k__BackingField;    // 0x0x28
    public int <INGPMHBGNFJ>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// BEKBAAJDHFF
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class BEKBAAJDHFF
{
    public List<APPNANGFABC> <BAGBILNLKFK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// BFMDHLIIKKK
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.API]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
//   RESPONSE POST   api/relationships/v2/updateVoiceVolume   [Service.API]
public class BFMDHLIIKKK
{
    public int <GHGPKLAJMDK>k__BackingField;    // 0x0x10
    public KBMDFKALGAK <LEOLJMABNCL>k__BackingField;    // 0x0x14
    public CHLKGHEFHEH <NAJJOEOGBNC>k__BackingField;    // 0x0x18
    public CHLKGHEFHEH <KPBLICMDGID>k__BackingField;    // 0x0x1C
    public CHLKGHEFHEH <OFKFHEEPILD>k__BackingField;    // 0x0x20
    public byte? <DCHGLDIHGGL>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// BIEPLGEKHBI
//   REQUEST  POST   api/roomcurrencies/v1/awardCurrency/bulk   [Service.Econ]
public class BIEPLGEKHBI
{
    public Guid <BBACMKPOGFB>k__BackingField;    // 0x0x10
    public int <BEJEBEPEDLJ>k__BackingField;    // 0x0x20
    public long <MEAIGCDMOCK>k__BackingField;    // 0x0x28
    public Guid <DINOAEKPLEK>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// BLGNIANEJDL
//   RESPONSE GET    api/testcasemanagement/   [Service.API]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{hJPLNJNIFLL}   [Service.API]
public class BLGNIANEJDL
{
    public uint <PPNIEDCHLJF>k__BackingField;    // 0x0x10
    public uint? <HDDLNEBDMJO>k__BackingField;    // 0x0x14
    public string <APBEBINKLBB>k__BackingField;    // 0x0x20
    public string <HAIMJKBFIJI>k__BackingField;    // 0x0x28
    public DateTime <EIGABCJEFHL>k__BackingField;    // 0x0x30
    public DateTime? <JKHDKOBDJBL>k__BackingField;    // 0x0x38
    public bool <CMGMFNDGLBP>k__BackingField;    // 0x0x48
    public List<LKLMOKMADIF> <ECKHADKLIKM>k__BackingField;    // 0x0x50
    public List<string> <BAGBILNLKFK>k__BackingField;    // 0x0x58
    public int <LEHEKMIMFJK>k__BackingField;    // 0x0x60
    public int <DKLOBCIEHEB>k__BackingField;    // 0x0x64
    public int <LNPPKELBGMG>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// BPEAFBEECDE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BPEAFBEECDE
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// BPKEEJMDHEO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BPKEEJMDHEO
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
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
// CJHPCLELFIA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CJHPCLELFIA
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
// CLHLOMJFIBC
//   (not directly referenced by a detected call)
public class CLHLOMJFIBC
{
    public long <CDJAOJLGPAD>k__BackingField;    // 0x0x10
    public long <DHCKKJIHICH>k__BackingField;    // 0x0x18
    public int <BLLKHEABJFK>k__BackingField;    // 0x0x20
    public DateTime <MOGKIJLNBGN>k__BackingField;    // 0x0x28
    public NLDJOMHIBDG <LEOLJMABNCL>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// CLMJHLFPLGN
//   REQUEST  POST   api/items/purchaseInfos   [Service.Econ]
public class CLMJHLFPLGN
{
    public IReadOnlyList<MMOPDGKBAEH> <GBHOJCONJDL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// CMDDEGLKAEL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CMDDEGLKAEL
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
// COAFHABICNE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum COAFHABICNE
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
// CPCMLOACIGF
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.Econ]
public class CPCMLOACIGF
{
    public int <JDPEDNHCKEA>k__BackingField;    // 0x0x10
    public Guid <BBACMKPOGFB>k__BackingField;    // 0x0x14
    public long <MMIGIOHKANP>k__BackingField;    // 0x0x28
    public DateTime <DBAMKFLIGFE>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// DAGGDADKPAE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DAGGDADKPAE
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// DFABKELIKIG
//   (not directly referenced by a detected call)
public class DFABKELIKIG
{
    public LCPABLOEAHC GGPHPLMOMEI;    // 0x0x10
    public int DDOCDCLKBKP;    // 0x0x14
}

// --------------------------------------------------------------------------
// DHMNCODBNBK
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class DHMNCODBNBK : ValueType
{
    public Guid DGNNPFFMIEE;    // 0x0x0
}

// --------------------------------------------------------------------------
// DJPGKJKKDJM
//   REQUEST  POST   api/playerevents/v2   [Service.API]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.API]
public class DJPGKJKKDJM
{
    public long <KDGFHLDADEF>k__BackingField;    // 0x0x10
    public long? <HACHNHBPIBM>k__BackingField;    // 0x0x18
    public long? <CKOPIFKLLEA>k__BackingField;    // 0x0x28
    public string <APBEBINKLBB>k__BackingField;    // 0x0x38
    public string <HAIMJKBFIJI>k__BackingField;    // 0x0x40
    public List<string> <BAGBILNLKFK>k__BackingField;    // 0x0x48
    public string <HMPHMMJOFPA>k__BackingField;    // 0x0x50
    public DateTime <DHIPGKPLMBH>k__BackingField;    // 0x0x58
    public DateTime <AEDPHOGJFCD>k__BackingField;    // 0x0x60
    public BPEAFBEECDE <JKCPEJLDHAO>k__BackingField;    // 0x0x68
    public bool <OCIMJLDCNBB>k__BackingField;    // 0x0x6C
    public bool <BOOOJGADGGH>k__BackingField;    // 0x0x6D
    public BPKEEJMDHEO <LMLIHBGKDNO>k__BackingField;    // 0x0x70
    public BPKEEJMDHEO <BLDDLOKEIEF>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// DKAFOOLLHHG
//   (not directly referenced by a detected call)
public class DKAFOOLLHHG
{
    public int <KCOKJKACONA>k__BackingField;    // 0x0x10
    public string <DJGJLACFBHL>k__BackingField;    // 0x0x18
    public string <PEMHDKCCMCF>k__BackingField;    // 0x0x20
    public string <IFALKEAPCOK>k__BackingField;    // 0x0x28
    public string <IFHBNHDLGJO>k__BackingField;    // 0x0x30
    public KEEOBDBOKHK? <HGFICLKEICB>k__BackingField;    // 0x0x38
    public string <JNGGPGLGMMO>k__BackingField;    // 0x0x70
    public Guid? <HIGLICCMIFL>k__BackingField;    // 0x0x78
    public DKDANGFCEKG? <NDMJDIIPFJL>k__BackingField;    // 0x0x8C
    public string <AKIMBIJCNJH>k__BackingField;    // 0x0x98
    public string <DEKDALHNBGN>k__BackingField;    // 0x0xA0
    public bool <IEDKIADCMKM>k__BackingField;    // 0x0xA8
    public bool <OGODCHHGCGD>k__BackingField;    // 0x0xA9
    public bool <PCNCCLEDENF>k__BackingField;    // 0x0xAA
    public NGFKJBKJKIN <ANJIKNLGFDD>k__BackingField;    // 0x0xAC
    public COAFHABICNE <BMNFDDBBFKF>k__BackingField;    // 0x0xB0
    public int <LJKFMHANMFM>k__BackingField;    // 0x0xB4
    public APCAKCGDFCO <PDHOMPMODJB>k__BackingField;    // 0x0xB8
    public IPAJFKBAJFI <GFPHNBCLOOP>k__BackingField;    // 0x0xBC
    public int? <AFEABKAEPHB>k__BackingField;    // 0x0xC0
    public string <PLBEONKGAMI>k__BackingField;    // 0x0xC8
    public int? <KOAKLEEAJCA>k__BackingField;    // 0x0xD0
    public int? <GJINHJCAMBO>k__BackingField;    // 0x0xD8
    public string <EFIBICPFPBP>k__BackingField;    // 0x0xE0
}

// --------------------------------------------------------------------------
// DKDANGFCEKG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DKDANGFCEKG
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// DLBGOCDKMOA
//   (not directly referenced by a detected call)
public class DLBGOCDKMOA
{
    public int <JKKEDJBMPNK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DNEAFCFNOBO
//   (not directly referenced by a detected call)
public class DNEAFCFNOBO
{
    public bool <JCALCJJFHKB>k__BackingField;    // 0x0x10
    public DKAFOOLLHHG <IBFMKPDJDKA>k__BackingField;    // 0x0x18
    public float <AAJHLALBAII>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EEPDMJNMOND
//   RESPONSE GET    api/config/v1/azurespeech   [Service.API]
public class EEPDMJNMOND
{
    public bool <GCJCJJGNCCF>k__BackingField;    // 0x0x10
    public string <JFBNJPFEKAF>k__BackingField;    // 0x0x18
    public string <ECLGCIBJFDI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EMCOMMCJGIB
//   RESPONSE GET    api/config/v1/backtrace   [Service.API]
public class EMCOMMCJGIB
{
    public int <GCEIINIOLFB>k__BackingField;    // 0x0x10
    public int <FLNFOFLIMEE>k__BackingField;    // 0x0x14
    public float <JLINAHEKFPA>k__BackingField;    // 0x0x18
    public int <HIGOIACNIFE>k__BackingField;    // 0x0x1C
    public int <LDNHHNINBFI>k__BackingField;    // 0x0x20
    public int <KLKBNFDNLDG>k__BackingField;    // 0x0x24
    public int <LKGGCAMNINL>k__BackingField;    // 0x0x28
    public string <HEADBNBIHJJ>k__BackingField;    // 0x0x30
    public string <POOGHHPJKJE>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// ENBJEHKMOJF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ENBJEHKMOJF
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
// ENMAJHPHPEK
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
public class ENMAJHPHPEK
{
    public List<string> <CEJIBGGHKBG>k__BackingField;    // 0x0x10
    public List<string> <AAJBPCOEPDE>k__BackingField;    // 0x0x18
    public List<string> <OPPPCMMKKKP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EPDOOECNGMH
//   (not directly referenced by a detected call)
public class EPDOOECNGMH
{
    public OILBOLBBFDD <LEOLJMABNCL>k__BackingField;    // 0x0x10
    public int? <KHECPFMONFC>k__BackingField;    // 0x0x14
    public Guid? <OFPIADDJPJI>k__BackingField;    // 0x0x1C
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
// FCOLGFNCLME
// base   : MGNELHNLHHI
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class FCOLGFNCLME : MGNELHNLHHI
{
    public List<APPNANGFABC> <BAGBILNLKFK>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// FFEEJALAFLP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FFEEJALAFLP
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
// FGKMHEANHBI
// base   : KJFFGAJIBFG
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.Econ]
public class FGKMHEANHBI : KJFFGAJIBFG
{
    public LNDBPNALOAJ? <IDGLCGJBMJA>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <KPEGLBIKEPC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// FIEKDBFPOOB
//   RESPONSE GET    api/config/v2   [Service.API]
public class FIEKDBFPOOB
{
    public Dictionary<int, int> <FOJEKEMIAKP>k__BackingField;    // 0x0x10
    public List<HFNOLIHEGNA> <EJANLIMFLPB>k__BackingField;    // 0x0x18
    public DFABKELIKIG[][] <OKCPMIBCDHP>k__BackingField;    // 0x0x20
    public DLBGOCDKMOA <BNILLEBEMDK>k__BackingField;    // 0x0x28
    public LEALPEBBHNO <FDFAIPNLGIC>k__BackingField;    // 0x0x30
    public IHDAINAIGIB <OAHDBPMPLEL>k__BackingField;    // 0x0x38
    public PIGEAABNFFH <OHFPHPILALB>k__BackingField;    // 0x0x40
    public GFLLIMNMALJ <NIBOOEDKNFI>k__BackingField;    // 0x0x48
    public string <LEIGMLNBCJN>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// FIFMJCDJOJE
//   (not directly referenced by a detected call)
public class FIFMJCDJOJE
{
    public MGNELHNLHHI <IHPPIIFADLH>k__BackingField;    // 0x0x10
    public CLHLOMJFIBC <EECANABLIBN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FOKDHJLGHLL
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.Econ]
public class FOKDHJLGHLL
{
    public List<POKLIKKAEEP> <DCAHKPKPAMF>k__BackingField;    // 0x0x10
    public string <LCGODBMPGFH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GBGLCJIHCHJ
//   REQUEST  POST   api/roomkeys/v1/awardbulk   [Service.Econ]
public class GBGLCJIHCHJ
{
    public long <OMBCJMMOPBC>k__BackingField;    // 0x0x10
    public int <JDPEDNHCKEA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GCMKECCEFOC
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class GCMKECCEFOC
{
    public Dictionary<Guid, MFELNCEGGHF> <PGDPMOCJFNK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// GFLLIMNMALJ
//   (not directly referenced by a detected call)
public class GFLLIMNMALJ
{
    public float <MPLMMBNKHED>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// GGBJCIFEEKL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GGBJCIFEEKL
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// GJANAOLJBDF
//   REQUEST  POST   api/customAvatarItems   [Service.API]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
public class GJANAOLJBDF
{
    public IAAEJFMKBFM <KJBGHIPICNL>k__BackingField;    // 0x0x10
    public string <IHECJMEBINE>k__BackingField;    // 0x0x18
    public int? <EMDLKAGOMOC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GKJDIMLKBKE
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.Econ]
public class GKJDIMLKBKE
{
    public long <KDGFHLDADEF>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <FNKNIKNDKOC>k__BackingField;    // 0x0x18
    public KEAMNBBEIJO <BGILLALKIHI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GKLOEJKHHCC
//   (not directly referenced by a detected call)
public class GKLOEJKHHCC
{
    public long <OMBCJMMOPBC>k__BackingField;    // 0x0x10
    public Guid <GBNFHANENJN>k__BackingField;    // 0x0x18
    public long <KDGFHLDADEF>k__BackingField;    // 0x0x28
    public string <APBEBINKLBB>k__BackingField;    // 0x0x30
    public string <HAIMJKBFIJI>k__BackingField;    // 0x0x38
    public int <INIMPIMKAEN>k__BackingField;    // 0x0x40
    public Guid? <LFGDMAIGAEA>k__BackingField;    // 0x0x44
    public DateTime <MOGKIJLNBGN>k__BackingField;    // 0x0x58
    public string <HMPHMMJOFPA>k__BackingField;    // 0x0x60
    public PBIJHBBHANL <LEOLJMABNCL>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// GKOCLAEFPKE
//   (not directly referenced by a detected call)
public class GKOCLAEFPKE
{
    public int <KKDHIKNEEOP>k__BackingField;    // 0x0x10
    public DateTime? <EGMKCHLOJIO>k__BackingField;    // 0x0x18
    public DateTime? <OHJGEOKFIPA>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// HDONLLDGGOO
//   REQUEST  POST   api/playerevents/v1/respond   [Service.API]
public class HDONLLDGGOO
{
    public long <DHCKKJIHICH>k__BackingField;    // 0x0x10
    public NLDJOMHIBDG <LEOLJMABNCL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HEFHJOPJAOD
//   (not directly referenced by a detected call)
public class HEFHJOPJAOD
{
    public int <ABFHDHGMGFD>k__BackingField;    // 0x0x10
    public AAGBAMPLMIJ <LEOLJMABNCL>k__BackingField;    // 0x0x14
    public List<PAMBPODMHLK> <EFLKFCFIPME>k__BackingField;    // 0x0x18
    public List<PAMBPODMHLK> <PNCHJMAGJNF>k__BackingField;    // 0x0x20
    public bool <LIBJOHNCPPP>k__BackingField;    // 0x0x28
    public DateTime? <FJCAODDPENL>k__BackingField;    // 0x0x30
    public DateTime? <CLFDMHNHBNP>k__BackingField;    // 0x0x40
    public DateTime? <BIBNAMIMPCA>k__BackingField;    // 0x0x50
    public bool <BNFDPILJJLN>k__BackingField;    // 0x0x60
    public bool <OBOBCHOIFLH>k__BackingField;    // 0x0x61
}

// --------------------------------------------------------------------------
// HEGCNOHCAEK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HEGCNOHCAEK
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// HMAHAJIAFLI
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class HMAHAJIAFLI
{
    public AJPOHJAHAMN <PBOBDOGGKMH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// IAGILDBJJLC
//   RESPONSE POST   api/PlayerCheer/v1/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v1/instantKick   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v1/modKick   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/voteToKick   [Service.API]
//   RESPONSE POST   api/clubreporting/v1/report   [Service.API]
//   RESPONSE POST   api/inventions/v1/report   [Service.API]
//   RESPONSE POST   api/playerevents/v1/report   [Service.API]
//   RESPONSE POST   api/relationships/sendfriendintroductions   [Service.API]
//   RESPONSE POST   api/rooms/v2/report   [Service.API]
//   RESPONSE POST   api/screensharereports/v1/report   [Service.API]
public class IAGILDBJJLC
{
    public bool <GDKNLBDDJFJ>k__BackingField;    // 0x0x10
    public string <HOMBOPKNNGB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IFCGNKKPFDO
//   REQUEST  POST   api/roomkeys/v1/owns/bulk   [Service.Econ]
public class IFCGNKKPFDO
{
    public int COMMLBDCOLJ;    // 0x0x10
    public long PMNCCHDHDKF;    // 0x0x18
}

// --------------------------------------------------------------------------
// IFHCEGGBIKD
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.API]
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{aJOCAMLGEFH}   [Service.API]
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
public class IFHCEGGBIKD
{
    public FCOLGFNCLME <IHPPIIFADLH>k__BackingField;    // 0x0x10
    public AJPOHJAHAMN <PBOBDOGGKMH>k__BackingField;    // 0x0x18
    public AJCDICPBHHL <CMJOANIGFIF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// IFPMKDDAGCK
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
public class IFPMKDDAGCK
{
    public Guid? <PMPAELFNPHD>k__BackingField;    // 0x0x10
    public long? <KDGFHLDADEF>k__BackingField;    // 0x0x28
    public string <APBEBINKLBB>k__BackingField;    // 0x0x38
    public string <HAIMJKBFIJI>k__BackingField;    // 0x0x40
    public string <HMPHMMJOFPA>k__BackingField;    // 0x0x48
    public ONMGFICPFAP <BGFMKCADJDE>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// IGMLGPGPONN
//   RESPONSE DELETE api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{mPKKNNEDJKH}   [Service.Econ]
public class IGMLGPGPONN
{
    public CJHPCLELFIA <MHELAINJAIG>k__BackingField;    // 0x0x10
    public PCCDCJOHGBE <DCGMEPDMCGI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IHDAINAIGIB
//   (not directly referenced by a detected call)
public class IHDAINAIGIB
{
    public int <DCBAPHOLKGI>k__BackingField;    // 0x0x10
    public DateTime <HEPBGNBHCEG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IKHHCFPOCPH
//   (not directly referenced by a detected call)
public class IKHHCFPOCPH
{
    public int <LKENNAMIFCJ>k__BackingField;    // 0x0x10
    public AJPOHJAHAMN <PBOBDOGGKMH>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// INGDBPKOLAP
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.Econ]
public class INGDBPKOLAP
{
    public int <OMJOPJJCHPD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// IPAJFKBAJFI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IPAJFKBAJFI
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
// JDLCPNJPBHB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JDLCPNJPBHB
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
// JFBGKDJHCKL
//   REQUEST  POST   api/roomcurrencies   [Service.Econ]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.Econ]
public class JFBGKDJHCKL
{
    public Guid <DINOAEKPLEK>k__BackingField;    // 0x0x10
    public long <CKLOOEPKKHC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JFKGKCHMMGK
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.API]
public class JFKGKCHMMGK
{
    public List<MGNELHNLHHI> <OIAAOPIFMDE>k__BackingField;    // 0x0x10
    public string <LCGODBMPGFH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JGHCOLCIHBH
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.Econ]
//   RESPONSE POST   api/avatar/v1/lockeditems/bulk   [Service.Econ]
//   RESPONSE GET    api/avatar/v4/items   [Service.Econ]
public class JGHCOLCIHBH
{
    public DKDANGFCEKG <NDMJDIIPFJL>k__BackingField;    // 0x0x10
    public string <DAOBOPPGECJ>k__BackingField;    // 0x0x18
    public string <DJGJLACFBHL>k__BackingField;    // 0x0x20
    public string <PEMHDKCCMCF>k__BackingField;    // 0x0x28
    public NGFKJBKJKIN <ANJIKNLGFDD>k__BackingField;    // 0x0x30
    public string <IFALKEAPCOK>k__BackingField;    // 0x0x38
    public int <KOAKLEEAJCA>k__BackingField;    // 0x0x40
    public bool <IIOONMKACFO>k__BackingField;    // 0x0x44
    public string <NHCBPDALFNA>k__BackingField;    // 0x0x48
    public DateTime <MOGKIJLNBGN>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// JKDLJAFLBMC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JKDLJAFLBMC
{
    RoomKey = 0,
    RoomConsumable = 1,
    RoomCurrencyPurchaseOffer = 2,
    CustomAvatarItem = 3,
    StoreUGCAvatarItem = 4,
    UNDEFINED = 5,
}

// --------------------------------------------------------------------------
// JLNBEFKEEAH
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class JLNBEFKEEAH
{
    public int? <CCLHPLACONK>k__BackingField;    // 0x0x10
    public string <PJFPBDPGLDP>k__BackingField;    // 0x0x18
    public string <CFEIDNGHPMC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JMOEJMOBKKG
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.Econ]
public class JMOEJMOBKKG
{
    public long <OMBCJMMOPBC>k__BackingField;    // 0x0x10
    public int <JDPEDNHCKEA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JOJGBOEJLKC
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{jIIJIDFJIGK}/{cINMBJMHCOB}   [Service.Econ]
public class JOJGBOEJLKC
{
    public COAFHABICNE <BMNFDDBBFKF>k__BackingField;    // 0x0x10
    public CMDDEGLKAEL <EDBOBHEJAHF>k__BackingField;    // 0x0x14
    public int <DEBGLLNIEHE>k__BackingField;    // 0x0x18
    public int <DODIMJFKFDH>k__BackingField;    // 0x0x1C
    public int <PMDCFCDNOLG>k__BackingField;    // 0x0x20
    public DAGGDADKPAE <PDLFLPEIFAJ>k__BackingField;    // 0x0x24
    public bool <DBFLNFLKOJN>k__BackingField;    // 0x0x28
    public float <OLKJNICGFOO>k__BackingField;    // 0x0x2C
    public int <PIDMHEKOFHO>k__BackingField;    // 0x0x30
    public bool <CJAGENHFDBN>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// JONNECMJKFA
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class JONNECMJKFA
{
    public Dictionary<Guid, ADNMJEICHEN> <KKIAIELEAPO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KBKDLGNDCGI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KBKDLGNDCGI
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
// KDDKLCMGMDF
// base   : HEFHJOPJAOD
//   (not directly referenced by a detected call)
public class KDDKLCMGMDF : HEFHJOPJAOD
{
    public int <FJEBLPLKOKE>k__BackingField;    // 0x0x68
    public List<DNEAFCFNOBO> <GCBDMJDJHDB>k__BackingField;    // 0x0x70
    public List<DNEAFCFNOBO> <IIFCHIDNOAH>k__BackingField;    // 0x0x78
    public List<DNEAFCFNOBO> <GIIOFEHIGDB>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// KDEDMOMGEBI
// base   : FDPGAAIPEKA`1<EHGDCJFOLHP>
//   RESPONSE GET    api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{aGHKMNFEKEJ}   [Service.API]
public class KDEDMOMGEBI
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// KEAMNBBEIJO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KEAMNBBEIJO
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// KEEOBDBOKHK
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class KEEOBDBOKHK : ValueType
{
    public PJDNIEDEHFC ILJCGCMLCHH;    // 0x0x0
    public DHMNCODBNBK FLBKJBKDDDE;    // 0x0x10
    public Guid BJLCIJDDMDD;    // 0x0x20
}

// --------------------------------------------------------------------------
// KNKPJEDCHEL
//   (not directly referenced by a detected call)
public class KNKPJEDCHEL
{
    public Guid <PMPAELFNPHD>k__BackingField;    // 0x0x10
    public int <JDPEDNHCKEA>k__BackingField;    // 0x0x20
    public int <LJLEGLPIBIC>k__BackingField;    // 0x0x24
    public Guid <GCOHKAHELNF>k__BackingField;    // 0x0x28
    public DateTime <DBAMKFLIGFE>k__BackingField;    // 0x0x38
    public PCCDCJOHGBE <DCGMEPDMCGI>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// LCPABLOEAHC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LCPABLOEAHC
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
// LEALPEBBHNO
//   (not directly referenced by a detected call)
public class LEALPEBBHNO
{
    public float <DIGICMOFMOG>k__BackingField;    // 0x0x10
    public float <BJAFAKAFENO>k__BackingField;    // 0x0x14
    public float <PIHJDLNIKJL>k__BackingField;    // 0x0x18
    public float <DMNJBFFBLNE>k__BackingField;    // 0x0x1C
    public float <HLEOGMIJJPJ>k__BackingField;    // 0x0x20
    public float <EHHOEDKFEMN>k__BackingField;    // 0x0x24
    public float <JOACIJNABGI>k__BackingField;    // 0x0x28
    public float <LCHLOGJDLCC>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// LFMHPJKHHOI
//   REQUEST  POST   api/avatar/v1/lockeditems/bulk   [Service.Econ]
public class LFMHPJKHHOI
{
    public List<string> <MHGAEKIMDLG>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LKLMOKMADIF
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.API]
public class LKLMOKMADIF
{
    public string <PPNIEDCHLJF>k__BackingField;    // 0x0x10
    public string <JFBNJPFEKAF>k__BackingField;    // 0x0x18
    public string <JBCCEKOCBAE>k__BackingField;    // 0x0x20
    public string <HAIMJKBFIJI>k__BackingField;    // 0x0x28
    public string <PJFPBDPGLDP>k__BackingField;    // 0x0x30
    public HEGCNOHCAEK <MHELAINJAIG>k__BackingField;    // 0x0x38
    public List<string> <FNEJMMIOLKN>k__BackingField;    // 0x0x40
    public List<string> <BAGBILNLKFK>k__BackingField;    // 0x0x48
    public string <DNBJLKBELBF>k__BackingField;    // 0x0x50
    public List<MBFMHMLJINE> <AIBMLFNIPEH>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// LNDBPNALOAJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LNDBPNALOAJ
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
// LOEHMCNCEPF
//   REQUEST  PUT    api/roomconsumables   [Service.Econ]
public class LOEHMCNCEPF
{
    public Guid? <BPKOALHNJHO>k__BackingField;    // 0x0x10
    public Guid <NBJEFPKEHHO>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// MBFMHMLJINE
//   (not directly referenced by a detected call)
public class MBFMHMLJINE
{
    public DateTime <MOGKIJLNBGN>k__BackingField;    // 0x0x10
    public string <JFKLBLFOOLK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MDPKOJIHEAN
//   RESPONSE POST   api/chatreport/createChatReport   [Service.API]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.Econ]
//   RESPONSE PUT    api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.API]
//   RESPONSE PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{dGPIPOJOJGM}/appeal   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.API]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.Econ]
//   RESPONSE POST   api/images/v2/modifyaccessibility   [Service.API]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.Econ]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.Econ]
//   RESPONSE DELETE api/keepsakes   [Service.API]
//   RESPONSE DELETE api/keepsakes/{jMMICACHJNH}   [Service.API]
//   RESPONSE POST   api/playerwarnings   [Service.API]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.Econ]
public class MDPKOJIHEAN
{
    public bool <GDKNLBDDJFJ>k__BackingField;    // 0x0x10
    public string <ENMKGNALDBH>k__BackingField;    // 0x0x18
    public string <KIAIJCHIMKA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MEBFPDFHNNL
//   (not directly referenced by a detected call)
public class MEBFPDFHNNL
{
    public bool <IIGNELHAOGE>k__BackingField;    // 0x0x10
    public FFEEJALAFLP <EKCAJPOGPPK>k__BackingField;    // 0x0x14
    public int <OPGOPKNFDPN>k__BackingField;    // 0x0x18
    public DateTime <DBAMKFLIGFE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MFELNCEGGHF
//   (not directly referenced by a detected call)
public class MFELNCEGGHF
{
    public int <HLKPHOADDBJ>k__BackingField;    // 0x0x10
    public LOEHMCNCEPF <AKKOEOKHINL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MGBDFGJJOKD
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.Econ]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.Econ]
public class MGBDFGJJOKD
{
    public int <AOCHMADDHCE>k__BackingField;    // 0x0x10
    public int <IIGKNPIENHO>k__BackingField;    // 0x0x14
    public float <PPGKCMMMPKC>k__BackingField;    // 0x0x18
    public float <PBFPMKIDKHD>k__BackingField;    // 0x0x1C
    public bool <POCIKHCPIGH>k__BackingField;    // 0x0x20
    public bool <JELLAJEKBLN>k__BackingField;    // 0x0x21
    public bool <MDBLBHNEMHO>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// MGNELHNLHHI
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class MGNELHNLHHI
{
    public long <DHCKKJIHICH>k__BackingField;    // 0x0x10
    public int <NKJFCCJDJPF>k__BackingField;    // 0x0x18
    public long <KDGFHLDADEF>k__BackingField;    // 0x0x20
    public long? <HACHNHBPIBM>k__BackingField;    // 0x0x28
    public long? <CKOPIFKLLEA>k__BackingField;    // 0x0x38
    public string <APBEBINKLBB>k__BackingField;    // 0x0x48
    public string <HAIMJKBFIJI>k__BackingField;    // 0x0x50
    public string <HMPHMMJOFPA>k__BackingField;    // 0x0x58
    public DateTime <DHIPGKPLMBH>k__BackingField;    // 0x0x60
    public DateTime <AEDPHOGJFCD>k__BackingField;    // 0x0x68
    public int <DBLPBKONELJ>k__BackingField;    // 0x0x70
    public BPEAFBEECDE <JKCPEJLDHAO>k__BackingField;    // 0x0x74
    public bool <OCIMJLDCNBB>k__BackingField;    // 0x0x78
    public bool <BOOOJGADGGH>k__BackingField;    // 0x0x79
    public BPKEEJMDHEO <LMLIHBGKDNO>k__BackingField;    // 0x0x7C
    public BPKEEJMDHEO <BLDDLOKEIEF>k__BackingField;    // 0x0x80
    public long? <NPAJLEDINLF>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// MLJAINNHFIH
// base   : FDPGAAIPEKA`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.API]
public class MLJAINNHFIH
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// MMOPDGKBAEH
// base   : KEGPDCCONLK
//   (not directly referenced by a detected call)
public class MMOPDGKBAEH : KEGPDCCONLK
{
    public JKDLJAFLBMC OHMPGLBFBMP;    // 0x0x20
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
// NADNFHAAAGL
//   REQUEST  POST   api/messages/v1/sendMultiple   [Service.API]
public class NADNFHAAAGL
{
    public List<long> <DOJLBMCNJFB>k__BackingField;    // 0x0x10
    public GBOALAENMDP <LEOLJMABNCL>k__BackingField;    // 0x0x18
    public string <MCMNDLFDMAB>k__BackingField;    // 0x0x20
    public long? <KDGFHLDADEF>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// NDHNCEHANCH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NDHNCEHANCH
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
// NGFKJBKJKIN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NGFKJBKJKIN
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// NIEOJIOPPLJ
//   (not directly referenced by a detected call)
public class NIEOJIOPPLJ
{
    public Guid <LLDOCFFDJLG>k__BackingField;    // 0x0x10
    public Guid <INFODDJGOAI>k__BackingField;    // 0x0x20
    public DateTime <JHMIGCKEDJB>k__BackingField;    // 0x0x30
    public List<DKAFOOLLHHG> <AEMHFMCIIPC>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// NKIDAEAJOLK
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Auth]
public class NKIDAEAJOLK
{
    public Guid <DOHGIHPCJCD>k__BackingField;    // 0x0x10
    public string <APBEBINKLBB>k__BackingField;    // 0x0x20
    public string <HMPHMMJOFPA>k__BackingField;    // 0x0x28
    public DateTime <JHMIGCKEDJB>k__BackingField;    // 0x0x30
    public DateTime? <NEOLBPDKDMO>k__BackingField;    // 0x0x38
    public List<NIEOJIOPPLJ> <HGKHLJIKLCJ>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// NLDJOMHIBDG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NLDJOMHIBDG
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// NNGKJHFPNFO
//   RESPONSE GET    api/inventions/   [Service.API]
//   RESPONSE GET    api/inventions/v1/personaldetails/{oEOACNOOFPP}   [Service.API]
public class NNGKJHFPNFO
{
    public bool <AAKPACEJMAP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OAPMNGPFEMF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OAPMNGPFEMF
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// OBDMPMHLNDA
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{bEKCOFDFFEG}   [Service.API]
public class OBDMPMHLNDA
{
    public List<MGNELHNLHHI> <HBJOECJEAHJ>k__BackingField;    // 0x0x10
    public List<FIFMJCDJOJE> <KKFFHBNJIKL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ODBPAOHDNBP
//   RESPONSE PUT    api/roomkeys/v1/   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Matchmaking]
public class ODBPAOHDNBP
{
    public RoomKeyResult <MHELAINJAIG>k__BackingField;    // 0x0x10
    public GKLOEJKHHCC <OPKCIPCAIFP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OHAHJOABBAH
//   REQUEST  POST   api/equipment/v1/update   [Service.Econ]
public class OHAHJOABBAH
{
    public string <AHNMIMNPEGJ>k__BackingField;    // 0x0x10
    public string <EAIILMONANK>k__BackingField;    // 0x0x18
    public string <DJGJLACFBHL>k__BackingField;    // 0x0x20
    public string <PEMHDKCCMCF>k__BackingField;    // 0x0x28
    public NGFKJBKJKIN <ANJIKNLGFDD>k__BackingField;    // 0x0x30
    public string <EFIBICPFPBP>k__BackingField;    // 0x0x38
    public bool LHBNBMMPNLF;    // 0x0x40
    public bool <MDBLBHNEMHO>k__BackingField;    // 0x0x41
}

// --------------------------------------------------------------------------
// OHFLKJEABMI
// base   : FJDLNLCHNML
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/season/{jLKOEGKPAAA}   [Service.Econ]
public class OHFLKJEABMI : FJDLNLCHNML
{
    public int <MHGNIGJBACP>k__BackingField;    // 0x0x30
    public string <APBEBINKLBB>k__BackingField;    // 0x0x38
    public DateTime <JHMIGCKEDJB>k__BackingField;    // 0x0x40
    public DateTime <IAKFGOEGJLB>k__BackingField;    // 0x0x48
    public COAFHABICNE <BMNFDDBBFKF>k__BackingField;    // 0x0x50
    public HEFHJOPJAOD <MBGOMAGALMM>k__BackingField;    // 0x0x58
    public List<KDDKLCMGMDF> <CNPGDPGPPAN>k__BackingField;    // 0x0x60
    public MEBFPDFHNNL <FHLCKLOMNCE>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// OILBOLBBFDD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OILBOLBBFDD
{
    PurchasableItem = 0,
    CustomAvatarItem = 1,
}

// --------------------------------------------------------------------------
// ONMGFICPFAP
//   (not directly referenced by a detected call)
public class ONMGFICPFAP
{
    public long <INIMPIMKAEN>k__BackingField;    // 0x0x10
    public Guid? <BBACMKPOGFB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PAMBPODMHLK
//   (not directly referenced by a detected call)
public class PAMBPODMHLK
{
    public COAFHABICNE <BMNFDDBBFKF>k__BackingField;    // 0x0x10
    public int <INIMPIMKAEN>k__BackingField;    // 0x0x14
    public GKOCLAEFPKE <CCBCKKIPGEM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PBIJHBBHANL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PBIJHBBHANL
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// PCALNDAGPID
//   REQUEST  POST   api/relationships/v2/updateVoiceVolume   [Service.API]
public class PCALNDAGPID
{
    public int <BLLKHEABJFK>k__BackingField;    // 0x0x10
    public byte <DCHGLDIHGGL>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// PCCDCJOHGBE
//   (not directly referenced by a detected call)
public class PCCDCJOHGBE
{
    public Guid <PMPAELFNPHD>k__BackingField;    // 0x0x10
    public long <KDGFHLDADEF>k__BackingField;    // 0x0x20
    public string <APBEBINKLBB>k__BackingField;    // 0x0x28
    public string <HAIMJKBFIJI>k__BackingField;    // 0x0x30
    public string <HMPHMMJOFPA>k__BackingField;    // 0x0x38
    public long <INIMPIMKAEN>k__BackingField;    // 0x0x40
    public Guid? <LFGDMAIGAEA>k__BackingField;    // 0x0x48
    public DateTime <DBAMKFLIGFE>k__BackingField;    // 0x0x60
    public int <IINABKPNHMA>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// PFAEBGPDKBN
//   REQUEST  POST   api/items/bulkpurchase   [Service.Econ]
public class PFAEBGPDKBN
{
    public List<BBECJNGCOMP> <IOOOMPDMLEM>k__BackingField;    // 0x0x10
    public NDHNCEHANCH? <EKLMOKDAPKH>k__BackingField;    // 0x0x18
    public COAFHABICNE <BMNFDDBBFKF>k__BackingField;    // 0x0x20
    public bool <AJHJEPAIBGH>k__BackingField;    // 0x0x24
    public bool <JGCEOIDOJCJ>k__BackingField;    // 0x0x25
}

// --------------------------------------------------------------------------
// PHLNFPHINGE
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.Econ]
public class PHLNFPHINGE
{
    public List<int> <NIEOPKGAEDH>k__BackingField;    // 0x0x10
    public string <LCGODBMPGFH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PIGEAABNFFH
//   (not directly referenced by a detected call)
public class PIGEAABNFFH
{
    public int <OENGBMOGFPO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// PJDNIEDEHFC
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class PJDNIEDEHFC : ValueType
{
    public Guid DGNNPFFMIEE;    // 0x0x0
}

// --------------------------------------------------------------------------
// POKLIKKAEEP
//   (not directly referenced by a detected call)
public class POKLIKKAEEP
{
    public int <OJPCIJPGAOH>k__BackingField;    // 0x0x10
    public DateTime <MOGKIJLNBGN>k__BackingField;    // 0x0x18
    public DateTime? <JMJMKLACDFE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PPIOEJJHFFG
//   REQUEST  PUT    api/customAvatarItems   [Service.API]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
public class PPIOEJJHFFG
{
    public string <APBEBINKLBB>k__BackingField;    // 0x0x10
    public string <HAIMJKBFIJI>k__BackingField;    // 0x0x18
    public int? <INIMPIMKAEN>k__BackingField;    // 0x0x20
    public GGBJCIFEEKL? <JKCPEJLDHAO>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.Clubs]
public class AddKeepsakeInstanceRequest
{
    public long <KDGFHLDADEF>k__BackingField;    // 0x0x10
    public long? <HACHNHBPIBM>k__BackingField;    // 0x0x18
    public AFACIFHCNFE <EMAGNOPPFJK>k__BackingField;    // 0x0x28
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
    public MBLBDMEKPIG <PBOBDOGGKMH>k__BackingField;    // 0x0x10
    public string <NKAICBOAHOA>k__BackingField;    // 0x0x18
    public string <PKPHFFKHDKA>k__BackingField;    // 0x0x20
    public string <LMBOHDGIDEH>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public COAFHABICNE <CurrencyType>k__BackingField;    // 0x0x18
    public ENBJEHKMOJF <BalanceType>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.BalanceUpdateResponseDTO`1
// base   : RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceUpdateResponseDTO : BalanceResponseDTO
{
    public List<DCMOODBCEDF<DataTypeDTO>> <BalanceUpdates>k__BackingField;    // 0x0x0
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
//   REQUEST  POST   api/messages/v3/delete   [Service.Data]
public class DeleteMessagesRequestDTO
{
    public List<long> MessageIds;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Events.BroadcastRoomInstanceRequest
//   REQUEST  POST   api/playerevents/v1/broadcast   [Service.API]
public class BroadcastRoomInstanceRequest
{
    public long <DHCKKJIHICH>k__BackingField;    // 0x0x10
    public long? <OFNMJMOALHJ>k__BackingField;    // 0x0x18
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
    public string <BOFCAJGLNIA>k__BackingField;    // 0x0x10
    public int <NGONGGMFHFP>k__BackingField;    // 0x0x18
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
    public NCJHGJHCBKO FilterType;    // 0x0x20
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
    public IPAJFKBAJFI <GiftContext>k__BackingField;    // 0x0x24
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
    public AFACIFHCNFE <PBPKBFBIDIP>k__BackingField;    // 0x0x10
    public string <HMMNNOFEICK>k__BackingField;    // 0x0x18
    public int <MLPFECGPILJ>k__BackingField;    // 0x0x20
    public int <GMIEAKOAHML>k__BackingField;    // 0x0x24
    public string <BMBBMPINEAI>k__BackingField;    // 0x0x28
    public string <LKDEKFDNFFB>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <JDPEDNHCKEA>k__BackingField;    // 0x0x10
    public Guid <KOFNOBEJJAG>k__BackingField;    // 0x0x14
    public DateTime <JADHDDKFCOG>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.API]
public class KeepsakeGlobalConfigDTO
{
    public bool <MOGPHLFGNPP>k__BackingField;    // 0x0x10
    public int <GOCDOANDKHD>k__BackingField;    // 0x0x14
    public bool <KJHIIKKHNAK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <KOFNOBEJJAG>k__BackingField;    // 0x0x10
    public AFACIFHCNFE <LCHDBDIFHHJ>k__BackingField;    // 0x0x20
    public int <CEBGLNNINAC>k__BackingField;    // 0x0x24
    public long <KDGFHLDADEF>k__BackingField;    // 0x0x28
    public long? <HACHNHBPIBM>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.API]
//   RESPONSE GET    api/keepsakes/events/{fMIBHJAGMML}   [Service.API]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <PCMFGKEIAPK>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <FMHPHABEDIC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <LKNBMPBFJDF>k__BackingField;    // 0x0x10
    public long <KDGFHLDADEF>k__BackingField;    // 0x0x18
    public long <DKHAJOINLDF>k__BackingField;    // 0x0x20
    public MCEBFBBCOHL <LEOLJMABNCL>k__BackingField;    // 0x0x28
    public int <ANLNGLJJPBN>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <KDGFHLDADEF>k__BackingField;    // 0x0x10
    public List<Guid> <DDJDDDLBCIA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <PCMFGKEIAPK>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <FMHPHABEDIC>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <PNLFJDBINGI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <DKHAJOINLDF>k__BackingField;    // 0x0x10
    public long <NFCCLDFACJH>k__BackingField;    // 0x0x18
    public int? <LJKKGKBGDBL>k__BackingField;    // 0x0x20
    public int? <MOMBDNCEKFN>k__BackingField;    // 0x0x28
    public long? <LANOOHDNHFO>k__BackingField;    // 0x0x30
    public long <EKFIHLNGGGM>k__BackingField;    // 0x0x40
    public long <CEFFFJJPBFO>k__BackingField;    // 0x0x48
    public int <GKAMAPNOFKJ>k__BackingField;    // 0x0x50
    public MCEBFBBCOHL <KNANPMGOPFO>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <HKJIFOFFGIJ>k__BackingField;    // 0x0x58
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
    public IPAJFKBAJFI <GiftContext>k__BackingField;    // 0x0x20
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
    public PFBDGKHFNEC creatorAccountRole;    // 0x0x68
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
    public KANEIIJAOEF <LAPGJPPEACI>k__BackingField;    // 0x0x10
    public PNHCGGJACJN <ENBNPKEFHMK>k__BackingField;    // 0x0x14
    public string <APBEBINKLBB>k__BackingField;    // 0x0x18
    public string <HAIMJKBFIJI>k__BackingField;    // 0x0x20
    public bool <FMGALIPJGFK>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<KANEIIJAOEF> <ONEGLKJCNKJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE GET    api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/event/{aJOCAMLGEFH}   [Service.API]
public class ProgressionEventDTO
{
    public long <NFCCLDFACJH>k__BackingField;    // 0x0x10
    public string <APBEBINKLBB>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <GIIOFEHIGDB>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <FGJNLALEGDH>k__BackingField;    // 0x0x28
    public DateTime <DHIPGKPLMBH>k__BackingField;    // 0x0x30
    public DateTime <AEDPHOGJFCD>k__BackingField;    // 0x0x38
    public DateTime <MBGBACAOGJN>k__BackingField;    // 0x0x40
    public bool <AEHFAEFMBOM>k__BackingField;    // 0x0x48
    public int <JIOAKFHFIME>k__BackingField;    // 0x0x4C
    public float <HDNDFIDDCDP>k__BackingField;    // 0x0x50
    public Guid? <FMAJGLOPPJC>k__BackingField;    // 0x0x54
    public string <NKFGNDBPCPE>k__BackingField;    // 0x0x68
    public string <BGGPLHHAPIM>k__BackingField;    // 0x0x70
    public string <GKPKCCNGMEH>k__BackingField;    // 0x0x78
    public string <CNPBMOJKCOO>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <HAABEPPHGIP>k__BackingField;    // 0x0x10
    public int <LGPJEDGKPLC>k__BackingField;    // 0x0x20
    public int <BENCPBKDHLA>k__BackingField;    // 0x0x24
    public int <KHLKELDJAGL>k__BackingField;    // 0x0x28
    public long <IAGLCDJOKDC>k__BackingField;    // 0x0x30
    public long <MNGBOJDKALL>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE GET    api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.API]
public class ProgressionEventRecordDTO
{
    public int <JDPEDNHCKEA>k__BackingField;    // 0x0x10
    public int <JJLOCDOIBJO>k__BackingField;    // 0x0x14
    public int <LHKHIAGJOAK>k__BackingField;    // 0x0x18
    public int <OEOBCENEIOP>k__BackingField;    // 0x0x1C
    public int <GICKBCGHAMF>k__BackingField;    // 0x0x20
    public DateTime? <IFNIFJIPMDL>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <FMDEJPPAKKE>k__BackingField;    // 0x0x10
    public int <KCOKJKACONA>k__BackingField;    // 0x0x18
    public string <HMPHMMJOFPA>k__BackingField;    // 0x0x20
    public int <JJLOCDOIBJO>k__BackingField;    // 0x0x28
    public int <KBJNMOFDCDB>k__BackingField;    // 0x0x2C
    public bool <DKGDICNIMBB>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.PublishInventionRequest
//   REQUEST  POST   api/inventions/v4/publish   [Service.API]
public class PublishInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public IJNDBPBABID <Permission>k__BackingField;    // 0x0x18
    public GGBJCIFEEKL <Accessibility>k__BackingField;    // 0x0x1C
    public int? <Price>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.PurchaseBalanceUpdateResponseDTO`1
// base   : RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class PurchaseBalanceUpdateResponseDTO : BalanceResponseDTO
{
    public List<BOJNIBECDEI<DataTypeDTO>> <BalanceUpdates>k__BackingField;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public MBNLFGINNEI ReportCategory;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.SetInventionVersionAccessibilityRequest
//   REQUEST  PUT    api/inventions/v2/accessibility   [Service.API]
public class SetInventionVersionAccessibilityRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public int <VersionNumber>k__BackingField;    // 0x0x18
    public GGBJCIFEEKL <NewAccessibility>k__BackingField;    // 0x0x1C
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
    public IJNDBPBABID <Permission>k__BackingField;    // 0x0x18
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
    public LILBLNMJKIH <ImageFile>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.MessageDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class MessageDTO : BaseDTO
{
    public List<FNJJCGONJMG> <Content>k__BackingField;    // 0x0x18
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
    public bool IsDormOnly;    // 0x0x30
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
//   RESPONSE DELETE api/roomkeys/v1/delete/{lCKDLBCFBKI}   [Service.Econ]
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
    public bool AKHNBBFFHBB;    // 0x0x28
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
    public CNKDBEEDHHN? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public CNKDBEEDHHN MCGBBBGJMFG;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public KBKDLGNDCGI PIJDDEALOLF;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public GHCFLBOPIHD MLCOGCMJLBB;  // wrapper
    public int? IECCCDIAEJG;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v1/modKick  [API POST]
public class PlayerReportingV1ModKickRequest
{
    public CACKPAOFAJP MOLMHDFNOGC;  // wrapper
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
    public byte[] APDBNIMCPID;  // wrapper
    public BMJNINHHILO IGNEHPKNIKK;  // wrapper
    public object meta;  // candidate
    public object data;  // candidate
    public object file.bin;  // candidate
}

// api/PlayerReporting/v3/create  [API POST]
public class PlayerReportingV3CreateRequest
{
    public CACKPAOFAJP KJEJKJPDGGJ;  // wrapper
    public float? BBBIIDIDFOB;  // wrapper
    public bool? LPIMIBHHBKN;  // wrapper
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
    public List<KEEOBDBOKHK> desc;  // wrapper
}

// api/avatar/v2/gifts/generate  [Econ POST]
public class AvatarV2GiftsGenerateRequest
{
    public IPAJFKBAJFI INLEBAAACKH;  // wrapper
    public IPAJFKBAJFI? LMEKGIKJNGO;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [Econ POST]
public class AvatarV3GiftsGenerateRequest
{
    public IPAJFKBAJFI INLEBAAACKH;  // wrapper
    public IPAJFKBAJFI? LMEKGIKJNGO;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/chatreport/createChatReport  [API POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage NAAMEAFIHJI;  // wrapper
    public OGMALIJKOHJ KJEJKJPDGGJ;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public CACKPAOFAJP KJEJKJPDGGJ;  // wrapper
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
    public GGBJCIFEEKL MPCIGGLFCOI;  // wrapper
    public DGMMFMEHEGC FFDDIILDGKK;  // wrapper
    public FEENGPGFEJP LHHMECEAFMI;  // wrapper
    public FEENGPGFEJP HCHJAFJOPHN;  // wrapper
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

// api/customAvatarItems/v1/{dGPIPOJOJGM}/appeal  [API POST]
public class CustomAvatarItemsV1DGPIPOJOJGMAppealRequest
{
    public Guid DGPIPOJOJGM;  // wrapper
}

// api/customAvatarItems/v2/fromCreator/{aGHKMNFEKEJ}  [API GET]
public class CustomAvatarItemsV2FromCreatorAGHKMNFEKEJRequest
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
    public PJPPJBADFFL EKNMDAAHFBH;  // wrapper
    public IPAJFKBAJFI? EOOLAKPCMOC;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [Econ POST]
public class GamerewardsV1SelectRequest
{
    public PDMPIKBJJBA JCALMNAPDHH;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/images/  [API GET]
public class ImagesRequest
{
    public object sort;  // candidate
    public object filter;  // candidate
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
    public int? LADFILOPOFK;  // wrapper
    public Guid? DGPIPOJOJGM;  // wrapper
    public object customAvatarItemId;  // candidate
    public object purchasableItemId;  // candidate
}

// api/itemWishlists/v1/wishlist/remove  [Econ POST]
public class ItemWishlistsV1WishlistRemoveRequest
{
    public int? LADFILOPOFK;  // wrapper
    public Guid? DGPIPOJOJGM;  // wrapper
    public object customAvatarItemId;  // candidate
    public object purchasableItemId;  // candidate
}

// api/keepsakes/{jMMICACHJNH}/collect  [API POST]
public class KeepsakesJMMICACHJNHCollectRequest
{
    public Guid JMMICACHJNH;  // wrapper
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public GBOALAENMDP OAOFDBDEHAG;  // wrapper
    public long? CINEDGEJAIA;  // wrapper
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
    public IReadOnlyCollection<long> ELBPOOCMKJL;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public BPEAFBEECDE MPCIGGLFCOI;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? POGGADIPNGD;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public BPKEEJMDHEO NBMIACLJLBH;  // wrapper
    public BPKEEJMDHEO EIBALGFMPKC;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? DPKCNMHAPEB;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime OMDABEJMMKM;  // wrapper
    public DateTime MKDGBOGGCJD;  // wrapper
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
    public CACKPAOFAJP KJEJKJPDGGJ;  // wrapper
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
    public Guid BHICOBAOBDK;  // wrapper
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
    public Guid HKMFEKAGEEJ;  // wrapper
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
    public Guid HKMFEKAGEEJ;  // wrapper
    public long? AINMILKAFDF;  // wrapper
    public byte? HIECCNNOPLP;  // wrapper
    public int? NGGKCKILBNF;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid BHICOBAOBDK;  // wrapper
    public long? MKEAIFEPEDJ;  // wrapper
    public long? NBDBEANPNJP;  // wrapper
    public int? PFCGPNCOPEG;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [Econ PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> PMLCGCAHNGK;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [Econ POST]
public class RoomkeysV1CreateRequest
{
    public PBIJHBBHANL MLCOGCMJLBB;  // wrapper
    public Guid? CFDJJCFFGGK;  // wrapper
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
    public CACKPAOFAJP KJEJKJPDGGJ;  // wrapper
    public long? OGGGLNJDODF;  // wrapper
    public Guid? PIEOAJKENIP;  // wrapper
    public int? FKDOHFDIOAB;  // wrapper
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
    public Guid JIBPIHFCDFA;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [Econ POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid JIEADNIDHDB;  // wrapper
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
    public HEGCNOHCAEK MGGPFBECIOG;  // wrapper
}

