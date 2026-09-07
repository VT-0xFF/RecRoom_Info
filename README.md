# RecRoom Build Info
*A full list of every recroom version and their API request URLs, and their expected responses, Along with CPP2IL Decompiled game code.*
# Update: the new api documenting script is somewhat functional! Testing started with the last ever 2026 build with only 4 unknown responses and 19 Unknown Methods/Request Datas for 306 API Endpoints.
Short demo of the output below, When full analysis completes Every build's info will be uploaded:
```
# format: <endpoint> <Service> <METHOD> [RequestDTO] <ResponseDTO>
# unique endpoints: 306 (merged from 5946 raw records)
# "-" means "Does not handle a response from what static analysis can tell"
# "?" means "Does not have anything or we couldn't tell statically"

api/AppIntegrity/v1/iospaymentqueuefailed API POST IOSPaymentQueueSetupFailedIntegrityData -
api/AppIntegrity/v1/iosproducts API POST IOSProductIntegrityData -
api/CampusCard/PS5RecRoomPlusEnabledForAllPlayers Econ GET bool
api/CampusCard/v1/SignUpBonus Econ GET RRPlusSignUpBonusDTO
api/CampusCard/v1/UpdateAndGetSubscription Econ POST CampusCardV1UpdateAndGetSubscriptionRequest SubscriptionInfoDTO
api/PlayerCheer/v1/SetSelectedCheer API POST PlayerCheerV1SetSelectedCheerRequest -
api/PlayerCheer/v1/create API POST PlayerCheerV1CreateRequest OkResponse
api/activities/charades/v1/words/{wordId} API GET List<CardData>
api/ageverification/generateCode API POST RecNetResultPrimitive<string>
api/announcement/v1/get API GET List<AnnouncementDTO>
api/apple/musicpromotion/active API GET bool
api/apple/musicpromotion/code API GET AppleMusicPromotionResponseDTO
api/avatar/v1/defaultbaseavataritems Econ GET List<AvatarItemDetails>
api/avatar/v1/defaultunlocked Econ GET List<AvatarItemDetails>
api/avatar/v1/lockeditems Econ GET List<AvatarItemDetails>
api/avatar/v1/lockeditems/bulk Econ POST GetLockedAvatarItemDetailsBulkAsPostRequest List<AvatarItemDetails>
api/avatar/v2/gifts Econ GET List<GiftPackage>
api/avatar/v2/gifts/consume/ Econ ? AvatarV2GiftsConsumeRequest -
...
```

# How can You Help?
* The best way you can contribute, is editing the auto generated .md files to fix any issues or missing definitions. This whole project was started by me alone, being very ambitious. I will get some things wrong, or outright missing some things, so I hope that if you care about making sure anyone can read this information if they wanted to make a custom and/or private server for old versions of RecRoom if they wanted to as much as I do, that you can provide your own help or information to assist others projects as well as my own.
# Information
I am aiming to have this automated, but fully accurate, Baseline known information is that:
* All versions before `26 October 2016 – 20:30:17 UTC` do NOT use "RecNet.Core" for web requests, instead manually using UnityEngine.WWW to make requests, or the build has no HTTP requests
* For the dumps for versions `11 February 2017 – 00:57:56 UTC` and beyond, Although I can try my best to provide accurate information, please note that some things may be wrong, or missing due to the obfuscation.
* All versions before `23 June 2017 – 17:23:52 UTC` do NOT use BestHTTP, they use a custom made "RecNet.Core" Namespace that uses UnityEngine.WWW to make requests.
* All versions between `10 February 2017 – 01:48:05 UTC` and `6 December 2018 – 21:26:17 UTC` then versions `8 April 2020 – 02:56:55 UTC` and beyond have BeeByte Obfuscation.
* All versions after `6 December 2018 – 21:26:17 UTC` are Il2Cpp builds, and have been dumped with CPP2IL's Experimental IL to Assembly flags.
## Additional Dumping information
* Some of the dumping process was assisted, and documentation on how things such as metadata encryption was worked around can be read in [DUMPING.md](https://github.com/VT-0xFF/RecRoom_Info/blob/main/DUMPING.md) 
